namespace _2
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
            int sonuc = 0;

            for (i = 0 ; i < 10 ; i++ )
            {
                sonuc = sonuc + i;
            }

            label1.Text = sonuc.ToString();

        }
    }
}
