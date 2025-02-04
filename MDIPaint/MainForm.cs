using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class MainForm : Form
    {
        public static Color CurrentColor { get; set; }
        private static int currentWidth;
        public static int CurrentWidth
        {
            get { return currentWidth; }
            set
            {
                currentWidth = value;
                ShowSize();
            }
        }

        public static Tools CurrentTool { get; set; }
        public MainForm()
        {
            InitializeComponent();
            CurrentColor = Color.Black;
            CurrentWidth = 1;
            CurrentTool = Tools.Pen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new FormAbout();
            aboutForm.ShowDialog();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var documentForm = new FormDocument();
            documentForm.MdiParent = this;
            documentForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Green;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Blue;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Red;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            using (var dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    CurrentColor = dlg.Color;
                }
            }
        }
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CurrentWidth = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CurrentWidth = 2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CurrentWidth = 3;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CurrentWidth = 4;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CurrentWidth = 5;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            CurrentWidth = 6;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            CurrentWidth = 7;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            CurrentWidth = 8;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            CurrentWidth = 9;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            CurrentWidth = 10;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void слеваНаправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void сверхуВнизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void упорядочитьЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void choosePen_Click(object sender, EventArgs e)
        {
            CurrentTool = Tools.Pen;
        }

        private void chooseCircle_Click(object sender, EventArgs e)
        {
            CurrentTool = Tools.Circle;
        }

        private void chooseRectangle_Click(object sender, EventArgs e)
        {
            CurrentTool = Tools.Rectangle;
        }

        private void saveDocumentAs(FormDocument d)
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|Bitmap Image|*.bmp|GIF Image|*.gif";
                dlg.Title = "Сохранить изображение как";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    d.SaveAs(dlg.FileName);
                    d.Text = dlg.FileName;
                    d.CurrentPath = dlg.FileName;
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as FormDocument;
            if (d != null)
            {
                saveDocumentAs(d);
            }
        }

        private void файлToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as FormDocument;
            сохранитьToolStripMenuItem.Enabled = d != null;
            сохранитьКакToolStripMenuItem.Enabled = d != null;
        }

        public void ShowPosition(int x, int y)
        {
            if (x != -1 && y != -1)
            {
                statusLabelPosition.Text = $"X: {x} Y: {y}";
            }
            else
            {
                statusLabelPosition.Text = string.Empty;
            }
        }
        public static void ShowSize()
        {
            var mainForm = Application.OpenForms["MainForm"] as MainForm;
            if (mainForm != null)
                mainForm.statusLabelSize.Text = $"Размер пера: {CurrentWidth}";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Изображения (*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                dlg.Title = "Открыть изображение";
                dlg.Multiselect = false;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var bmp = new Bitmap(dlg.FileName);
                        var d = new FormDocument(bmp);
                        d.Text = dlg.FileName;
                        d.CurrentPath = dlg.FileName;
                        d.MdiParent = this;
                        d.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = ActiveMdiChild as FormDocument;
            if (d != null)
            {
                if (d.CurrentPath != null)
                {
                    d.SaveAs(d.CurrentPath);
                }
                else
                {
                    saveDocumentAs(d);
                }
            }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem.Enabled = true;
            сохранитьКакToolStripMenuItem.Enabled = true;
        }
    }
}
