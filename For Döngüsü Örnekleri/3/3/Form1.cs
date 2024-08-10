namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int sonuc = 1;

            for (i = 1; i<=5; i++)
            {
                sonuc = sonuc * i;
            }

            label1.Text = sonuc.ToString();
        }
    }
}
