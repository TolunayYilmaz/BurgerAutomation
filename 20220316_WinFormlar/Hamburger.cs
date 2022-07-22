using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220316_WinFormlar
{
    class Hamburger : Ürün,ISifirla, IBoylar
    {
        public static Hashtable HamburgerListe = new Hashtable();

        public int Sifirlama { get; set; } = 0;
        public string Boy { get; set; }
        public int BoyFiyat { get ; set; }

        public override void UrunListeEkle(int HamburgerFiyati, string HamburgerAdi, string uyari)
        {
            {
                try
                {
                    if (HamburgerFiyati > Sifirlama & HamburgerAdi.Length > Sifirlama)
                    {
                        HamburgerListe.Add(HamburgerAdi, HamburgerFiyati);
                        MessageBox.Show(HamburgerAdi + " hamburgeri eklendi.");
                    }
                    else if (HamburgerAdi.Length == Sifirlama)//sos adı boş karakter olamaz
                    {
                        MessageBox.Show("Lütfen hamburgerinize isim veriniz.");
                    }
                    else if (HamburgerFiyati == Sifirlama)
                    {
                        MessageBox.Show(HamburgerAdi + " menünüzü bedava satamazsınız.");
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(uyari);
                }

            }


        }//Hamburgere özel ezdirilen metod
    }
    
}
