namespace Seyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "irembagcivan" && textBox2.Text == "1234")
            {
                Form2 seyahat = new Form2();
                seyahat.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalý Giriþ!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
