namespace obs
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int sayi1, sayi2, sonuc;
     
        public Form1()
        {
            InitializeComponent();
             

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            YeniIslem();

        }
        private void YeniIslem()
        {
            sayi1 = rnd.Next(1, 50);
            sayi2 = rnd.Next(1, 50);
            sonuc = sayi1 + sayi2;

            lblCaptcha.Text = $"{sayi1} + {sayi2} = ?";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ogrenciNo = maskedTextBoxOgrenciNo.Text;
            string sifre = txtSifre.Text;

            // Dosyadan tüm satýrlarý oku
            string[] satirlar = File.ReadAllLines(@"C:\Users\EXCALIBUR\OneDrive\Desktop\ogrenciler.txt");

            bool bulundu = satirlar.Any(s =>
            {
                var parcalar = s.Split(';');
                return parcalar[0] == ogrenciNo && parcalar[1] == sifre;
            });

            // CAPTCHA kontrolü
            int girilen;
            if (!int.TryParse(txtCaptcha.Text, out girilen))
            {
                lblDurum.Text = "CAPTCHA sayý olmalý!";
                return;
            }

            if (girilen != sonuc)
            {
                lblDurum.Text = "CAPTCHA hatalý!";
                YeniIslem(); // yanlýþsa yeni iþlem üret
                return;
            }

            // Giriþ kontrolü
            if (bulundu)
            {
                lblDurum.Text = "Giriþ baþarýlý!";
                YeniIslem(); // baþarýlý giriþten sonra da yeni iþlem üret
            }
            else
            {
                lblDurum.Text = "Öðrenci No veya Þifre yanlýþ!";
                YeniIslem(); // yanlýþ giriþte yeni iþlem üret
            }
          
            }
        }



       
    }


