namespace CurrencyConverter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Dövizleri çeviren fonksiyon
        private double[] DovizCevir()
        {
            // Her bir dövizin adýný ve karþýlýk gelen kurlarý içeren diziler oluþturuluyor
            string[] dovizler = {
                "Türk Lirasý",
                "ABD Dolarý",
                "Euro",
                "Ýngiliz Sterlini",
                "Ýsviçre Frangý",
                "Japon Yeni",
                "Suudi Arabistan Riyali",
                "Norveç Kronu",
                "Danimarka Kronu",
                "Avustralya Dolarý",
                "Kanada Dolarý",
                "Ýsveç Kronu",
                "Ruble"
            };

            // Döviz kurlarý, CurrencyConverter.Program'dan alýnýr ve uygun formata dönüþtürülür
            double[] kurlar =
            {
                1,//Türk Lirasýný referans aldýðýmýz için türk lirasýnýn kuru 1 olmalýdýr
                Convert.ToDouble(Program.dovizBilgileri[0, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[1, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[2, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[3, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[4, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[5, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[6, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[7, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[8, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[9, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[10, 0].Replace(".", ",")),
                Convert.ToDouble(Program.dovizBilgileri[11, 0].Replace(".", ","))
            };

            // Seçilen dövizlerin kurlarýnýn olduðu bir dizi döndürülüyor
            return new double[] { kurlar[Array.IndexOf(dovizler, Soldaki.Text)], kurlar[Array.IndexOf(dovizler, Sagdaki.Text)] };

        }

        // Dönüþtür butonuna týklandýðýnda gerçekleþecek iþlemler
        private void Donustur_Click(object sender, EventArgs e)
        {
            
            if (Soldaki.Text == "" || Sagdaki.Text == "")
            {
                MessageBox.Show("Lütfen iki para birimini de seçiniz.");// Eðer herhangi bir para birimi seçilmediyse uyarý göster
                return;
            }
            else if (Miktar.Text == "")
            {
                MessageBox.Show("Lütfen miktarý giriniz.");// Eðer miktar girilmediyse uyarý göster
                return;
            }
            else if (Soldaki.Text == Sagdaki.Text)
            {
                Sonuc.Text = Miktar.Text;// Ayný para birimi seçilirse, sonucu giriþle ayný yap
                return;
            }

            // Seçilen dövizlerin kurlarýný al
            double[] kurlar = DovizCevir();

            try
            {
                double miktar = Convert.ToDouble(Miktar.Text);// Miktarý al
                double sonuc = miktar * kurlar[0] / kurlar[1];// Dönüþümü yap
                Sonuc.Text = sonuc.ToString();// Sonucu güncelle
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen miktarý doðru giriniz.");// Eðer miktar sayýya dönüþtürülemezse uyarý göster
            }

        }

    }
}
