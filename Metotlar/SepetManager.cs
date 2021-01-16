using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Product product) 
        {
            Console.WriteLine("Sepete Eklendi: " + product.Adi);

        }

        public void Ekle2(string productAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi: " + productAdi);
        }  
    }
}
