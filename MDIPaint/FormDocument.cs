using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        public FormDocument()
        {
            InitializeComponent();
            bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            bitmapTemp = bitmap;
            CurrentPath = null;
        }

        public FormDocument(Bitmap bmp)
        {
            InitializeComponent();
            bitmap = bmp;
            bitmapTemp = bmp;
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
                var pen = new Pen(MainForm.CurrentColor, MainForm.CurrentWidth);
                switch (MainForm.CurrentTool)
                {
                    case Tools.Pen:
                        using (var g = Graphics.FromImage(bitmap))
                        {
                            g.DrawLine(pen, x, y, e.X, e.Y);
                        }
                        x = e.X;
                        y = e.Y;
                        bitmapTemp = bitmap;
                        break;

                    case Tools.Circle:
                        bitmapTemp = (Bitmap)bitmap.Clone();
                        using (var g = Graphics.FromImage(bitmapTemp))
                        {
                            g.DrawEllipse(pen, new Rectangle(x, y, e.X - x, e.Y - y));
                        }
                        break;

                    case Tools.Rectangle:
                        bitmapTemp = (Bitmap)bitmap.Clone();
                        using (var g = Graphics.FromImage(bitmapTemp))
                        {
                            g.DrawRectangle(pen, new Rectangle(x, y, e.X - x, e.Y - y));
                        }
                        break;
                }   
                Invalidate();
            }
            var parent = MdiParent as MainForm;
            if (parent != null && (e.X != x || e.Y != y))
            {
                if (!sw.IsRunning || sw.ElapsedMilliseconds > 20) // Обновление координат в статус баре раз в 20 мс
                {
                    x = e.X;
                    y = e.Y;
                    sw.Restart();
                    parent.ShowPosition(e.X, e.Y);
                }
            }
        }

        private void FormDocument_MouseUp(object sender, MouseEventArgs e)
        {
            if (MainForm.CurrentTool != Tools.Pen)
            {
                bitmap = bitmapTemp;
                Invalidate();
            }
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
    }
}
