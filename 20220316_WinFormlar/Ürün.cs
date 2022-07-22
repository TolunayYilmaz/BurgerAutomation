using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220316_WinFormlar
{
    abstract class Ürün
    {  
        abstract public void UrunListeEkle(int UrunFiyati, string UrunAdi, string uyari);//ürün ekleme metodu

        public string[] ListViewKolon = { "Boy ", " Hamburger Adı ", " Hamburger Adeti ", " Fiyatı ", " Toplam Sos Fiyat ", "Soslar " };
        
        public string[] Liste;
        public string ÜrünAdi { get; set; }
        public int UrunFiyat { get; set; }
        public int UrunAdet { get; set; }
        public int toplamfiyat { get; set; }
        public byte FalseSay { get; set; }



    }  
}
