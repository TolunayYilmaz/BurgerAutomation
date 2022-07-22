using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _20220316_WinFormlar
{
    public partial class SiparisAlForm : Form,ISifirla
    {
        Sos SosFiyat = new Sos();
        Hamburger Hamburger = new Hamburger();
        private List<string> SosToplaListe = new List<string>();
        public int Sifirlama { get; set; } = 0;

        // interface sadece sıfırlanacak elemanlar var ilerikiseviye farklı sayfalarda sıfırlama işlemi yapılırsa kullanılmak için yapılmıştır.


        public SiparisAlForm()
        {
            InitializeComponent();
        }

        #region MenuEkleÇıkar
        private void SiparişAlForm_Load(object sender, EventArgs e)
        {

            ekle();

        }

        void ekle()
        {
            listBox1.Visible = false;
            foreach (string sos in Sos.SosListe.Keys)
            {
                CheckBox chekuret = new CheckBox();

                chekuret.Tag = sos;
                chekuret.Text = sos;
                chekuret.AutoSize = true;
                SosPanel.Controls.Add(chekuret);

            }
            foreach (string boy in Enum.GetNames(typeof(Boy)))
            {
                RadioButton ButtonUret = new RadioButton();
                ButtonUret.Tag = boy;
                ButtonUret.Name = boy + "";
                ButtonUret.Text = boy;
                ButtonUret.AutoSize = true;
                BoyPanel.Controls.Add(ButtonUret);

            }//boy ve sos butonları eklendi
             //HamburgerBox.Items.AddRange(Enum.GetNames(typeof(Hamburgerler)));// hamburgerler enumdan comboboa çekilmiştir.
            /*  listeolustur.HambugerListeEkle();
              HamburgerBox.Items.Add(listeolustur.HamburgerListe[12]);*/

            foreach (var item in Hamburger.HamburgerListe.Keys)
            {
                HamburgerBox.Items.Add(item);
            }



            foreach (string item in Hamburger.ListViewKolon)
            {
                listView1.Columns.Add(item);
            }
        }
        void menusec()

        {


            Hamburger.UrunAdet= (int)hamburgerAdet.Value;
            try
            {
                if (Hamburger.HamburgerListe.ContainsKey(HamburgerBox.SelectedItem) & Hamburger.UrunAdet > 0)
                {

                    Hamburger.UrunFiyat = (int)Hamburger.HamburgerListe[HamburgerBox.SelectedItem];//Hastable içindeki seçilen obje casting işlemine uğratıldı.
                    SosToplaListe.Clear();// sıfırlanma ise ekleye ekleye gider
                    Hamburger.ÜrünAdi = HamburgerBox.SelectedItem.ToString();//seçilen obje stringe ezdirildi.
                    SosFiyat.FalseSay = (byte)Sifirlama;
                    Hamburger.FalseSay= (byte)Sifirlama;       //sayma boylarda seçim yapılmaz ise false kadar sayıp 3 olunca boy seç uyarı yap.

                    foreach (CheckBox sos in this.SosPanel.Controls)
                    {

                        if (sos.Checked)
                        {

                            
                            SosFiyat.ÜrünAdi = " ";// sıfırlanma ise ekleye ekleye gider
                            SosToplaListe.Add(sos.Text);

                            foreach (string item in SosToplaListe)
                            {
                                SosFiyat.ÜrünAdi += item + ", ";
                            }

                           SosFiyat.Sifirlama += (int)Sos.SosListe[sos.Text];

                        }
                        else if (sos.Checked == false)
                        {

                            SosFiyat.FalseSay++;
                            if (SosFiyat.FalseSay == this.SosPanel.Controls.Count)
                            {
                                SosFiyat.Sifirlama = Sifirlama;
                                SosFiyat.ÜrünAdi = " ";
                                SosFiyat.FalseSay =(byte)Sifirlama;
                            }
                        }


                    }


                    foreach (RadioButton boy in this.BoyPanel.Controls)
                    {

                        if (boy.Checked)
                        {
                            SosFiyat.ÜrünAdi.Trim(',', ' ');
                            Hamburger.BoyFiyat = (int)Enum.Parse(typeof(Boy), boy.Text);//boy enumunun içindeki değeri aldırdı.
                            Hamburger.toplamfiyat = (Hamburger.BoyFiyat + Hamburger.UrunFiyat) * Hamburger.UrunAdet;
                            SosFiyat.toplamfiyat= SosFiyat.Sifirlama * Hamburger.UrunAdet;
                            listBox1.Items.Add("Boy: " + boy.Text + " Hamburger Adı: " + HamburgerBox.Text + " Hamburger Adeti: " + Hamburger.UrunAdet + " Fiyatı: " + (Hamburger.toplamfiyat) + " TL" + " Toplam Sos Fiyat: " + SosFiyat.toplamfiyat + " TL" + " Soslar: " + SosFiyat.ÜrünAdi);
                            string[] liste = { boy.Text, HamburgerBox.Text, Hamburger.UrunAdet + " Adet", (Hamburger.toplamfiyat) + " TL", SosFiyat.toplamfiyat + " TL", SosFiyat.ÜrünAdi };

                            listView1.Items.Add(new ListViewItem(liste));
                            Hamburger.Sifirlama += (Hamburger.toplamfiyat + SosFiyat.toplamfiyat);
                            tutarLbl.Text = Hamburger.Sifirlama.ToString() + " TL";

                        }
                        if (boy.Checked == false) // sayma işlemi yapar 3 üde false ise uyarı verir

                        {
                            Hamburger.FalseSay += 1;
                            if (Hamburger.FalseSay == 3)
                            {
                                MessageBox.Show("Lütfen hamburgerin boyunu seçiniz.");
                                Hamburger.FalseSay = (byte)Sifirlama;
                            }
                        }

                    }


                }
                if (Hamburger.UrunAdet == 0)
                {
                    MessageBox.Show("Lütfen Adet Seçiniz");
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Lütfen Ürün Seçiniz  ");
            }

        }
        void clear()
        {
            foreach (RadioButton boy in this.BoyPanel.Controls)
            {
                boy.Checked = false;
            }
            foreach (CheckBox sos in this.SosPanel.Controls)
            {
                sos.Checked = false;
            }
            hamburgerAdet.Value = Sifirlama;
          

        }
        #endregion
        void SiparisKaydet()
        {

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kaydedilsin mi?", "Sipariş Kaydet", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes & listView1.Items.Count > Sifirlama)
            {
                foreach (string item in listBox1.Items)
                {
                    Listeler.CiroForm.Add(item);

                }
                listBox1.Items.Clear();//sipariş kaydedildikten sonra eski siparişler silinmeli
                Hamburger.Sifirlama = Sifirlama;
                listView1.Items.Clear();
                tutarLbl.Text = Hamburger.Sifirlama.ToString(); MessageBox.Show("Kaydedildi");
            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("Kaydedilmedi.");
            }
            else if (listBox1.Items.Count == Sifirlama)
            {
                MessageBox.Show("Lütfen kaydedilmesi için sipariş ekleyin!");
            }

        }


        private void sprsVerBtn_Click(object sender, EventArgs e)
        {

            menusec();
            clear();


        }

        private void SiparisKydtBtn_Click(object sender, EventArgs e)
        {
            SiparisKaydet();

        }


    }
}
