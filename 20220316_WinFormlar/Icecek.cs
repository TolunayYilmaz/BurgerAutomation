using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220316_WinFormlar
{
    class Icecek : Ürün, ISifirla
    {
        public static Hashtable IcicekEkle = new Hashtable();//

        public int Sifirlama { get; set; } = 0;


        public override void UrunListeEkle(int IcecekFiyati, string IcecekAdi, string uyari)
        {
            {
                try
                {
                    if (IcecekFiyati > Sifirlama & IcecekAdi.Length > Sifirlama)
                    {
                        IcicekEkle.Add(IcecekAdi, IcecekFiyati);
                        MessageBox.Show(IcecekAdi + " hamburgeri eklendi.");
                    }
                    else if (IcecekAdi.Length == Sifirlama)//sos adı boş karakter olamaz
                    {
                        MessageBox.Show("Lütfen hamburgerinize isim veriniz.");
                    }
                    else if (IcecekFiyati == Sifirlama)
                    {
                        MessageBox.Show(IcecekAdi + " menünüzü bedava satamazsınız.");
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(uyari);
                }
            }
        }
    }
}