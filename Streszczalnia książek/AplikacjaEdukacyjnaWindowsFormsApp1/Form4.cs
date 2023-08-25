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
    public partial class Form4 : Form
    {
        public static Form4 Instance;
        internal object textBoxForm4;

        public Form4(Form2 oknoGlowne)//: base()
        {
            InitializeComponent();
            Instance = this;
            OknoGlowne = oknoGlowne;
            
        }
        public Form4()
        {
            InitializeComponent();
            Instance = this;

            
        }
        public Form2 OknoGlowne { get; set; }
        

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            OknoGlowne.label3 = text;
        }




    }
}
