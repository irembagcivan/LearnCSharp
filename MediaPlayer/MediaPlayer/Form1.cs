namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\90546\\Desktop\\1.mp3";
            pictureBox1.ImageLocation = "C:\\Users\\90546\\Desktop\\2.png";
        }
    }
}
