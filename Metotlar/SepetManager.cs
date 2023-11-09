using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax - sözdizimi

        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler! "+product.Adi + " sepetinize eklendi!");

        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : "+ urunAdi);
        }
    }
}
