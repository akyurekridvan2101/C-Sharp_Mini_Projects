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

        // D�vizleri �eviren fonksiyon
        private double[] DovizCevir()
        {
            // Her bir d�vizin ad�n� ve kar��l�k gelen kurlar� i�eren diziler olu�turuluyor
            string[] dovizler = {
                "T�rk Liras�",
                "ABD Dolar�",
                "Euro",
                "�ngiliz Sterlini",
                "�svi�re Frang�",
                "Japon Yeni",
                "Suudi Arabistan Riyali",
                "Norve� Kronu",
                "Danimarka Kronu",
                "Avustralya Dolar�",
                "Kanada Dolar�",
                "�sve� Kronu",
                "Ruble"
            };

            // D�viz kurlar�, CurrencyConverter.Program'dan al�n�r ve uygun formata d�n��t�r�l�r
            double[] kurlar =
            {
                1,//T�rk Liras�n� referans ald���m�z i�in t�rk liras�n�n kuru 1 olmal�d�r
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

            // Se�ilen d�vizlerin kurlar�n�n oldu�u bir dizi d�nd�r�l�yor
            return new double[] { kurlar[Array.IndexOf(dovizler, Soldaki.Text)], kurlar[Array.IndexOf(dovizler, Sagdaki.Text)] };

        }

        // D�n��t�r butonuna t�kland���nda ger�ekle�ecek i�lemler
        private void Donustur_Click(object sender, EventArgs e)
        {
            
            if (Soldaki.Text == "" || Sagdaki.Text == "")
            {
                MessageBox.Show("L�tfen iki para birimini de se�iniz.");// E�er herhangi bir para birimi se�ilmediyse uyar� g�ster
                return;
            }
            else if (Miktar.Text == "")
            {
                MessageBox.Show("L�tfen miktar� giriniz.");// E�er miktar girilmediyse uyar� g�ster
                return;
            }
            else if (Soldaki.Text == Sagdaki.Text)
            {
                Sonuc.Text = Miktar.Text;// Ayn� para birimi se�ilirse, sonucu giri�le ayn� yap
                return;
            }

            // Se�ilen d�vizlerin kurlar�n� al
            double[] kurlar = DovizCevir();

            try
            {
                double miktar = Convert.ToDouble(Miktar.Text);// Miktar� al
                double sonuc = miktar * kurlar[0] / kurlar[1];// D�n���m� yap
                Sonuc.Text = sonuc.ToString();// Sonucu g�ncelle
            }
            catch (Exception)
            {
                MessageBox.Show("L�tfen miktar� do�ru giriniz.");// E�er miktar say�ya d�n��t�r�lemezse uyar� g�ster
            }

        }

    }
}
