using MDIPaint.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class FormDocument : Form
    {
        int x, y;
        Bitmap bitmap;
        Bitmap bitmapTemp;
        private Stopwatch sw = new Stopwatch();
        private bool isModified = false;
        private float currentScaling = 1.0f;
        public float CurrentScaling
        {
            get { return currentScaling; }
            set
            {
                if (value < 0.1f || value > 10f) return;
                currentScaling = value;
                Invalidate();
            }
        }
        public string CurrentPath { get; set; }
        public Bitmap Canvas
        {
            get
            {
                return bitmap;
            }
            set
            {
                bitmap = value;
            }
        }
        public Bitmap CanvasTemp
        {
            get
            {
                return bitmapTemp;
            }
            set
            {
                bitmapTemp = value;
            }
        }
        public FormDocument()
        {
            InitializeComponent();
            bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
            }
            bitmapTemp = new Bitmap(bitmap);
            CurrentPath = null;
        }

        public FormDocument(Bitmap bmp)
        {
            InitializeComponent();
            bitmap = bmp;
            bitmapTemp = new Bitmap(bmp);
        }

        private void FormDocument_Load(object sender, EventArgs e)
        {

        }

        private void FormDocument_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
                if (MainForm.CurrentTool == Tools.Text)
                {

                    using (var dlg = new FormInputText())
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            string textToPlace = dlg.UserInput;
                            if (!string.IsNullOrWhiteSpace(textToPlace))
                            {
                                using (Graphics g = Graphics.FromImage(bitmapTemp))
                                {
                                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                                    using (Brush textBrush = new SolidBrush(MainForm.CurrentColor))
                                    {
                                        g.DrawString(textToPlace, MainForm.CurrentFont, textBrush, x, y);
                                    }
                                }
                                isModified = true;
                                Invalidate();
                            }
                        }
                    }

                }
                if (MainForm.CurrentTool == Tools.Fill)
                {
                    FillСlosedArea(bitmapTemp, e.X, e.Y, MainForm.CurrentColor);
                    isModified = true;
                }
            }
        }
        private void FillСlosedArea(Bitmap bmp, int x, int y, Color newColor)
        {
            Color oldColor = bmp.GetPixel(x, y);
            if (oldColor.ToArgb() == newColor.ToArgb()) return;

            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point p = pixels.Dequeue();
                if (p.X < 0 || p.X >= bmp.Width || p.Y < 0 || p.Y >= bmp.Height)
                    continue;
                if (bmp.GetPixel(p.X, p.Y) != oldColor)
                    continue;

                bmp.SetPixel(p.X, p.Y, newColor);

                pixels.Enqueue(new Point(p.X + 1, p.Y));
                pixels.Enqueue(new Point(p.X - 1, p.Y));
                pixels.Enqueue(new Point(p.X, p.Y + 1));
                pixels.Enqueue(new Point(p.X, p.Y - 1));
            }

            Invalidate();
        }
        private void FormDocument_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isModified = true;
                using (var pen = new Pen(MainForm.CurrentColor, MainForm.CurrentWidth))
                {
                    var g = Graphics.FromImage(bitmapTemp);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.CompositingQuality = CompositingQuality.HighQuality;

                    switch (MainForm.CurrentTool)
                    {
                        case Tools.Pen:
                            g = Graphics.FromImage(bitmapTemp);
                            g.DrawLine(pen, x, y, e.X, e.Y);
                            x = e.X;
                            y = e.Y;
                            break;

                        case Tools.Circle:
                            bitmapTemp = (Bitmap)bitmap.Clone();
                            g = Graphics.FromImage(bitmapTemp);
                            g.DrawEllipse(pen, new Rectangle(Math.Min(x, e.X), Math.Min(y, e.Y), Math.Abs(e.X - x), Math.Abs(e.Y - y)));
                            break;

                        case Tools.Rectangle:
                            bitmapTemp = (Bitmap)bitmap.Clone();
                            g = Graphics.FromImage(bitmapTemp);
                            g.DrawRectangle(pen, new Rectangle(Math.Min(x, e.X), Math.Min(y, e.Y), Math.Abs(e.X - x), Math.Abs(e.Y - y)));
                            break;
                        case Tools.Eraser:
                            g = Graphics.FromImage(bitmapTemp);
                            int eraserRadius = MainForm.CurrentWidth * 3;
                            using (var eraserBrush = new SolidBrush(Color.White))
                            {
                                g.FillEllipse(eraserBrush, e.X - eraserRadius / 2, e.Y - eraserRadius / 2, eraserRadius, eraserRadius);
                            }
                            break;
                        case Tools.Line:
                            bitmapTemp = (Bitmap)bitmap.Clone();
                            g = Graphics.FromImage(bitmapTemp);
                            g.DrawLine(pen, x, y, e.X, e.Y);
                            break;
                        case Tools.FilledRectangle:
                            bitmapTemp = (Bitmap)bitmap.Clone();
                            g = Graphics.FromImage(bitmapTemp);
                            using (var brush = new SolidBrush(MainForm.CurrentColor))
                            {
                                g.FillRectangle(brush, new Rectangle(Math.Min(x, e.X), Math.Min(y, e.Y), Math.Abs(e.X - x), Math.Abs(e.Y - y)));
                            }
                            break;
                        case Tools.FilledCircle:
                            bitmapTemp = (Bitmap)bitmap.Clone();
                            g = Graphics.FromImage(bitmapTemp);
                            using (var brush = new SolidBrush(MainForm.CurrentColor))
                            {
                                g.FillEllipse(brush, new Rectangle(Math.Min(x, e.X), Math.Min(y, e.Y), Math.Abs(e.X - x), Math.Abs(e.Y - y)));
                            }
                            break;
                        case Tools.Star:
                            bitmapTemp = (Bitmap)bitmap.Clone();
                            g = Graphics.FromImage(bitmapTemp);
                            int width = Math.Abs(e.X - x);
                            int height = Math.Abs(e.Y - y);
                            int outerRadius = Math.Min(width, height) / 2;
                            int innerRadius = (int)(outerRadius * MainForm.CurrentStarRadiusRatio);
                            PointF[] starPoints = GetStarPoints(x, y, MainForm.CurrentStarRays, innerRadius, outerRadius);
                            g.DrawPolygon(new Pen(MainForm.CurrentColor, 2), starPoints);
                            break;
                        case Tools.FilledStar:
                            bitmapTemp = (Bitmap)bitmap.Clone();
                            g = Graphics.FromImage(bitmapTemp);
                            width = Math.Abs(e.X - x);
                            height = Math.Abs(e.Y - y);
                            outerRadius = Math.Min(width, height) / 2;
                            innerRadius = (int)(outerRadius * MainForm.CurrentStarRadiusRatio);
                            starPoints = GetStarPoints(x, y, MainForm.CurrentStarRays, innerRadius, outerRadius);
                            g.FillPolygon(new SolidBrush(MainForm.CurrentColor), starPoints);
                            break;
                    }

                }
                Invalidate();
            }

            var parent = MdiParent as MainForm;
            if (parent != null && (e.X != x || e.Y != y))
            {
                if (!sw.IsRunning || sw.ElapsedMilliseconds > 20) // Обновление координат в статус баре раз в 20 мс
                {
                    sw.Restart();
                    parent.ShowPosition(e.X, e.Y);
                }
            }
        }

        private void FormDocument_MouseUp(object sender, MouseEventArgs e)
        {
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(bitmapTemp, 0, 0);
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            int newWidth = (int)(bitmapTemp.Width * CurrentScaling);
            int newHeight = (int)(bitmapTemp.Height * CurrentScaling);
            int offsetX = (ClientSize.Width - newWidth) / 2;
            int offsetY = (ClientSize.Height - newHeight) / 2;

            e.Graphics.DrawImage(bitmapTemp, new Rectangle(offsetX, offsetY, newWidth, newHeight));
        }

        private void FormDocument_MouseLeave(object sender, EventArgs e)
        {
            var parent = MdiParent as MainForm;
            parent?.ShowPosition(-1, -1);
        }

        public void SaveAs(string path)
        {
            bitmap.Save(path);
        }
        public void ResizeCanvas(int newWidth, int newHeight)
        {
            Bitmap newBitmap = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.Clear(Color.Transparent);
                g.DrawImage(bitmap, 0, 0);
            }

            bitmap.Dispose();
            bitmap = newBitmap;
            bitmapTemp = new Bitmap(bitmap);
            Invalidate();
        }

        private void FormDocument_MouseEnter(object sender, EventArgs e)
        {
            UpdateCursor();
        }

        private PointF[] GetStarPoints(int cx, int cy, int rays, float innerRadius, float outerRadius)
        {
            double angleStep = Math.PI / rays;
            List<PointF> points = new List<PointF>();

            for (int i = 0; i < rays * 2; i++)
            {
                double angle = i * angleStep;
                float radius = (i % 2 == 0) ? outerRadius : innerRadius;
                float x = cx + (float)(Math.Cos(angle) * radius);
                float y = cy + (float)(Math.Sin(angle) * radius);
                points.Add(new PointF(x, y));
            }

            return points.ToArray();
        }


        public void UpdateCursor()
        {
            switch (MainForm.CurrentTool)
            {
                case Tools.Pen:
                    this.Cursor = new Cursor(new MemoryStream(Resources.pen_cursor));
                    break;
                case Tools.Circle:
                    this.Cursor = new Cursor(new MemoryStream(Resources.circle_cursor));
                    break;
                case Tools.FilledCircle:
                    this.Cursor = new Cursor(new MemoryStream(Resources.filled_circle_cursor));
                    break;
                case Tools.Rectangle:
                    this.Cursor = new Cursor(new MemoryStream(Resources.rectangle_cursor));
                    break;
                case Tools.FilledRectangle:
                    this.Cursor = new Cursor(new MemoryStream(Resources.filled_rectangle_cursor));
                    break;
                case Tools.Eraser:
                    this.Cursor = new Cursor(new MemoryStream(Resources.eraser_cursor));
                    break;
                case Tools.Line:
                    this.Cursor = new Cursor(new MemoryStream(Resources.line_cursor));
                    break;
                case Tools.Text:
                    this.Cursor = new Cursor(new MemoryStream(Resources.text_cursor));
                    break;
                case Tools.Fill:
                    this.Cursor = new Cursor(new MemoryStream(Resources.fill_cursor));
                    break;
                case Tools.Star:
                    this.Cursor = new Cursor(new MemoryStream(Resources.star_cursor));
                    break;
                case Tools.FilledStar:
                    this.Cursor = new Cursor(new MemoryStream(Resources.filled_star_cursor));
                    break;
                default:
                    this.Cursor = Cursors.Default;
                    break;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (isModified)
            {
                var result = MessageBox.Show(
                    "Вы хотите сохранить вашу работу?",
                    "Есть несохранённые изменения в файле!",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(CurrentPath))
                    {
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|Bitmap Image|*.bmp|GIF Image|*.gif";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                SaveAs(saveFileDialog.FileName);
                                isModified = false;
                            }
                            else
                            {
                                e.Cancel = true;
                            }
                        }
                    }
                    else
                    {
                        SaveAs(CurrentPath);
                        isModified = false;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        public void ZoomIn()
        {
            CurrentScaling *= 1.1f;
        }
        public void ZoomOut()
        {
            CurrentScaling /= 1.1f;
        }
    }
}
