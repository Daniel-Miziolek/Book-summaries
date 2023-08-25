using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaEdukacyjnaWindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public static Form3 Instance;
        public Form3(Form2 oknoGlowne)//: base()
        {
            InitializeComponent();
            Instance = this;
            OknoGlowne = oknoGlowne;
        }
        public Form3()
        {
            InitializeComponent();
            Instance = this;
            

        }
        public Form2 OknoGlowne { get; set; }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OknoGlowne.label3.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OknoGlowne.label3.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OknoGlowne.label3.ForeColor = Color.Orange;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OknoGlowne.label3.ForeColor = Color.Blue;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFontSize_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                OknoGlowne.label3.Font = fd.Font;
            }
        }
    }
}
