using System.Text.RegularExpressions;

namespace AplikacjaEdukacyjnaWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Regex regEmail;
            regEmail = new Regex(@"^[a-z][a-z0-9.]*@[a-z0-9]*\.[a-z]{2,3}$");
            regEmail.IsMatch(textBox1.Text);
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Prosz� o uzupe�nie maila!", "B��d!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            else if (!regEmail.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Mail jest niepoprawny !", "B��d!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Prosz� o uzupe�nie Has�a!", "B��d!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && regEmail.IsMatch(textBox1.Text))
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();


            }
        }
    }
}