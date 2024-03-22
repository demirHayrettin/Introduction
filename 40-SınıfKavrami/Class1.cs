

namespace _40_SınıfKavrami
{
    // public, private, internal, protected acsess modifiers - Erişim Belirleyicileri
    internal class Personel
    {
        // Bir sınıf içerisinde fields, properties, methods yer alabilir. SInıf üyeleri - Class members

        // Property (Özellik)
        // Property'İ oluşturmak için prop yazıp iki kere tab tuşuna basarız.
        // prop + Tab Tab
        public string Ad { get; set; }

        private int _soyad;

        // propfull+Tab+Tab
        public int Soyadd
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Unvan { get; set; }
        private decimal Maas { get; set; }
        public decimal TabanMaas { get; set; }
        public int CocukSayisi { get; set; }


        private void MaasHesapla()
        {
            if (CocukSayisi == 0)
            {
                Maas = TabanMaas;
            }
            else if (CocukSayisi < 3)
                Maas = TabanMaas * 1.05m;
            else if (CocukSayisi >= 3)
                Maas = TabanMaas * 1.10m;
        }
        public void PersonelBilgileriniYaz()
        {
            MaasHesapla();

            Console.WriteLine($"Adı: {Ad}\nSoyad: {Soyad}\nYaşı: {Yas}\nMaaşı: {Maas} ");
        }
    }
}
