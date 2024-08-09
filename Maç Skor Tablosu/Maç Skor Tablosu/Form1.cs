namespace Maç_Skor_Tablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();

        int gspuan = 0;
        int tspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label1.Text = a.ToString();
            label3.Text = b.ToString();
            label4.Text = c.ToString();
            label2.Text = d.ToString();

            if (Convert.ToInt32(label1.Text) > Convert.ToInt32(label3.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label3.Text) > Convert.ToInt32(label1.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label3.Text) == Convert.ToInt32(label1.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label2.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label2.Text) > Convert.ToInt32(label4.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label2.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Visible = true;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label9.Text = a.ToString();
            label10.Text = b.ToString();
            label11.Text = c.ToString();
            label18.Text = d.ToString();

            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label10.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label10.Text) > Convert.ToInt32(label18.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label10.Text) == Convert.ToInt32(label18.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label9.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label9.Text) > Convert.ToInt32(label11.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label9.Text))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text)) && (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text)) && (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text)))
            {
                label21.Text = "ŞAMPİYON GALATASARAY";
                pictureBox1.ImageLocation = "C:\\Users\\90546\\Desktop\\gs.png";
            }

            if ((Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text)) && (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text)) && (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text)))
            {
                label21.Text = "ŞAMPİYON BEŞİKTAŞ";
                pictureBox1.ImageLocation = "C:\\Users\\90546\\Desktop\\bjk.png";
            }

            if ((Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text)) && (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text)) && (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text)))
            {
                label21.Text = "ŞAMPİYON TRABZONSPOR";
                pictureBox1.ImageLocation = "C:\\Users\\90546\\Desktop\\ts.png";
            }

            if ((Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text)) && (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text)) && (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text)))
            {
                label21.Text = "ŞAMPİYON FENERBAHÇE";
                pictureBox1.ImageLocation = "C:\\Users\\90546\\Desktop\\fb.jfif";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
