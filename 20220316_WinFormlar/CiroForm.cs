using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220316_WinFormlar
{
    public partial class IkinciForm : Form
    {
       private int Ciro = 0;
       private int ToplamExtraMalzeme = 0;// sayfa her açıldığında newleniyor
       private int ToplamUrunAdeti = 0;
        Sos sos = new Sos();
        Hamburger Hamburger = new Hamburger();
       
        public IkinciForm()
        {
            InitializeComponent();
        }


        private void IkinciForm_Load(object sender, EventArgs e)
        {
            ekranyükle();
        }


        void ekranyükle()
        {
            foreach (string item in Hamburger.ListViewKolon)
            {
                listView1.Columns.Add(item);
            }

            foreach (var item in Listeler.CiroForm)
            {
              

                Hamburger.Liste = item.Split(' ');//ramde duran listeyi listboxa aktarıldı ardından listboxdaki ürünler split edilerek uygun labellara koyuldu.(String Arraye eklendi)
                Hamburger.Boy = Hamburger.Liste[1];
                Hamburger.ÜrünAdi = Hamburger.Liste[4];
                Hamburger.UrunAdet = Convert.ToInt32(Hamburger.Liste[7]);
                Hamburger.UrunFiyat =Convert.ToInt32(Hamburger.Liste[9]);
                sos.UrunFiyat= Convert.ToInt32(Hamburger.Liste[14]);
                sos.ÜrünAdi = "";
                for (int i = 17; i < Hamburger.Liste.Length-1; i++)
                {
                    sos.ÜrünAdi += " " + Hamburger.Liste[i]; ;
                }       

                ToplamExtraMalzeme += sos.UrunFiyat;
                ToplamUrunAdeti += Hamburger.UrunAdet;
                Ciro += Hamburger.UrunFiyat+sos.UrunFiyat;
                string[] liste = { Hamburger.Boy, Hamburger.ÜrünAdi, Hamburger.UrunAdet.ToString(), Hamburger.UrunFiyat.ToString(), sos.UrunFiyat.ToString(), sos.ÜrünAdi };

                listView1.Items.Add(new ListViewItem(liste));
            }
            
            ExtraMalzemeGelirLbl.Text = ToplamExtraMalzeme.ToString()+" TL";
            CiroArayuzTxt.Text = Ciro.ToString()+" TL";
            SatilanUrunAdetiLbl.Text = ToplamUrunAdeti.ToString()+" Adet";
            SiparisSayiLbl.Text = listView1.Items.Count.ToString();

        }
    }
}
