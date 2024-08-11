namespace Fibonacci_Serisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 1;
            int sayi2 = 1;
            int sayi3;

            listBox1.Items.Add(sayi1);
            listBox1.Items.Add(sayi2);

            for (int i = 0; i <= 8; i++)
            {
                sayi3 = sayi1 + sayi2;

                sayi1 = sayi2;
                sayi2 = sayi3;

                listBox1.Items.Add(sayi3);
            }
        }
    }
}
