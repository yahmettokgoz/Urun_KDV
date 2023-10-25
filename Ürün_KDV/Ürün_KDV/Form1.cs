namespace Ürün_KDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ürün = textBox1.Text;
            int fiyat = Convert.ToInt16(textBox2.Text);

            double kdvli = fiyat * (1 + (20 / 100));
            listBox1.Items.Add("Ürün: " + ürün + "KDV'siz fiyat: " + fiyat + "KDV'Li fiyat: " + kdvli);

        }
    }
}