using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class FormResizeImage : Form
    {
        public int CanvasWidth { get; set; } = 0;
        public int CanvasHeight { get; set; } = 0;
        public int FormDocumentHeight { get; set; } = 0;
        public int FormDocumentWidth { get; set; } = 0;
        public FormResizeImage()
        {
            InitializeComponent();
        }
        public FormResizeImage(int currentWidth, int currentHeight, int windowWidth, int windowHeight)
        {
            InitializeComponent();
            CanvasWidth = currentWidth;
            CanvasHeight = currentHeight;
            FormDocumentWidth = windowWidth;
            FormDocumentHeight = windowHeight;
            textBox1.Text = CanvasWidth.ToString();
            textBox2.Text = CanvasHeight.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int newWidth) || newWidth <= 0 || newWidth > FormDocumentWidth)
            {
                MessageBox.Show($"Введите корректную ширину (целое число от 1 до {FormDocumentWidth})!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text, out int newHeight) || newHeight <= 0 || newHeight > FormDocumentHeight)
            {
                MessageBox.Show($"Введите корректную высоту (целое число от 1 до {FormDocumentHeight})!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                return;
            }
            CanvasWidth = newWidth;
            CanvasHeight = newHeight;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void setValuesAccordingToWindowSize_Click(object sender, EventArgs e)
        {
            CanvasWidth = FormDocumentWidth;
            CanvasHeight = FormDocumentHeight;
            textBox1.Text = CanvasWidth.ToString();
            textBox2.Text = CanvasHeight.ToString();
        }
    }
}
