namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            toplam = sayi1 + sayi2;
            label4.Text = toplam.ToString(); 
        }
    }
}
