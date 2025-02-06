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
            }
        }

        private void FormDocument_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
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
            e.Graphics.DrawImage(bitmapTemp, 0, 0);
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

    }
}
