using System;

namespace MetotOrnek
{
    class Program
    {
        // Geriye deger dondurmeyen bir void metot
        static void YazdirSarkiSozu()
        {
            Console.WriteLine("Sevdiğim şarkı: \"Here i am, in the land of the morningstar. Will you send me an angel?\"");
        }

        // Geriye tamsayı donduren bir metot
        static int RastgeleSayiKalani()
        {
            Random random = new Random();
            int rastgeleSayi = random.Next(1, 100); // 1 ile 99 arasında rastgele sayı
            return rastgeleSayi % 2; // Sayının 2'ye bölümünden kalan
        }

        // Parametre alan ve geriye deger donduren bir metot
        static int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2; // İki sayının çarpımı
        }

        // Parametre alan ve geriye deger dondurmeyen bir metot
        static void HosGeldiniz(string isim, string soyisim)
        {
            Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
        }

        static void Main(string[] args)
        {
            // Metotları cagirma
            YazdirSarkiSozu();

            int kalan = RastgeleSayiKalani();
            Console.WriteLine($"Rastgele sayının 2'ye bölümünden kalan: {kalan}");

            int carpimSonucu = Carpma(5, 10);
            Console.WriteLine($"5 ile 10'un çarpımı: {carpimSonucu}");

            HosGeldiniz("Melis", "Yıldız");

            Console.ReadLine(); // Konsolun hemen kapanmaması icin
        }
    }
}
