using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MDIPaint
{
    public partial class FormConfigureStar : Form
    {
        private int numberOfRays;
        private float radiusRatio;
        public int NumberOfRays 
        { 
            get 
            { 
                return numberOfRays;
            }
            set 
            { 
                numberOfRays = value;
                numericUpDown1.Value = numberOfRays;
            } 
        }
        public float RadiusRatio
        {
            get
            {
                return radiusRatio;
            }
            set
            {
                radiusRatio = value;
                numericUpDown2.Value = (decimal)radiusRatio;
            }
        }
        public FormConfigureStar()
        {
            InitializeComponent();
        }

        public FormConfigureStar(int rayNum, float rR)
        {
            InitializeComponent();
            NumberOfRays = rayNum;
            RadiusRatio = rR;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 4 || numericUpDown1.Value > 100)
            {
                MessageBox.Show("Количество лучей должно быть в пределах от 4 до 100", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericUpDown2.Value < 0.1m || numericUpDown2.Value > 1m)
            {
                MessageBox.Show("Отношение радиусов должно быть в пределах от 0.1 до 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NumberOfRays = (int)numericUpDown1.Value;
            RadiusRatio = (float)numericUpDown2.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormConfigureStar_Load(object sender, EventArgs e)
        {
            numericUpDown2.Minimum = 0.1m;
            numericUpDown2.Maximum = 1m;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Increment = 0.05m;
        }
    }
}
