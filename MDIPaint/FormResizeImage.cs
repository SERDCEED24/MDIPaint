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
        int Width {  get; set; }
        int Height { get; set; }
        public FormResizeImage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //int.TryParse(textBox1.Text, out Width);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
