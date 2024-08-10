namespace _1
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

            for(i = 0; i<10; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
