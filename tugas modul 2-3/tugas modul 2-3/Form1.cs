namespace tugas_modul_2_3
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        double c;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("masukan nilai yang benar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                a = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("masukan nilai yang benar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                b = 0;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox3.Text, out c))
            {
                MessageBox.Show("masukan nilai yang benar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
                c = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = Math.Pow((double)a / b, b * c);
            textBox4.Text = d.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
