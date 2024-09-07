namespace tugas_modul_2_2
{
    public partial class Form1 : Form
    {
        int sisi;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out sisi))
            {
                MessageBox.Show("masukan angka yang benar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                sisi = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int volumeKubus = (int)Math.Pow((int)sisi, 3);
            textBox2.Text = volumeKubus.ToString();
        }
    }
}
