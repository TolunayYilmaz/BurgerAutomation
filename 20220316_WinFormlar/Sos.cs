using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220316_WinFormlar
{
    class Sos : Ürün, ISifirla
    {
        public static Hashtable SosListe = new Hashtable();

        public int Sifirlama { get; set; } = 0;
   


        public override void UrunListeEkle(int SosFiyat, string SosAdi, string uyari)//ezdirildi
        {
            {
                try
                {
                    if (SosFiyat > Sifirlama & SosAdi.Length > Sifirlama)
                    {
                        SosListe.Add(SosAdi, SosFiyat);
                        MessageBox.Show(SosAdi + " sosu eklendi");
                    }
                    else if (SosAdi.Length == Sifirlama)
                    {
                        MessageBox.Show("Lütfen sosunuza isim veriniz.");
                    }
                    else if (SosFiyat == Sifirlama)
                    {
                        MessageBox.Show(SosAdi + " sosunuzu bedava satamazsınız.");
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
