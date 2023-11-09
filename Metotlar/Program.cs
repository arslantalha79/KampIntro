using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args) 
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1,product2};

            //type safety - tip güvenliği
            foreach (Product product in products) 
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("-------------Metotlar--------------");

            //instance - örnek
            //encapsulation - kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,23);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,2);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,5);
        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice