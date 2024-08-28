namespace Menü_Strip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Esaretin Bedeli (orijinal adıyla The Shawshank Redemption), Stephen King’in bir novellasından uyarlanan ve Frank Darabont tarafından yönetilen 1994 yapımı bir dram filmidir. Film, Andy Dufresne adlı genç ve başarılı bir bankacının hikayesini anlatır. Andy, karısını ve onun sevgilisini öldürmek suçundan ömür boyu hapis cezasına çarptırılır ve Shawshank Hapishanesi’ne gönderilir. “Esaretin Bedeli” (The Shawshank Redemption), haksız yere ömür boyu hapis cezasına çarptırılan Andy Dufresne’in Shawshank Hapishanesi’nde yaşadıklarını anlatır. Andy, hapishanede yeni arkadaşlıklar kurar ve özellikle Red isimli bir mahkumla yakın dostluk geliştirir. Film, Andy’nin özgürlüğe olan inancını ve hapishane koşullarına rağmen umudunu kaybetmemesini konu alır.";
            listBox1.Items.Add("Esaretin Bedeli");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }
    }
}
