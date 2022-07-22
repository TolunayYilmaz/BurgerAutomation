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
    public partial class BabaMdiForm : Form
    {

  
        public BabaMdiForm()
        {
            InitializeComponent();
        }


        private void BabaForm_Load(object sender, EventArgs e)
        {
            UiYukle();
            SiparisAlForm siparisAl = new SiparisAlForm();

            FormYükle(siparisAl);
        }
        private void UiYukle()
        {
            Sos.SosListe.Add("Ketçap", 1);
            Sos.SosListe.Add("Mayonez", 2);
            Sos.SosListe.Add("Ranch", 2);
            Sos.SosListe.Add("AcıSos", 1);
            Sos.SosListe.Add("Yoğurt", 3);
            Hamburger.HamburgerListe.Add("MacJrBurger", 25);
            Hamburger.HamburgerListe.Add("SteakBurger", 54);
            Hamburger.HamburgerListe.Add("DublexSteak", 65);
            Hamburger.HamburgerListe.Add("ChickenRoyale", 35);
            Hamburger.HamburgerListe.Add("BigMac", 45);  
        }//ana ekrana yüklencek menüler
        private void FormYükle(Form FormEkran)// formu flow panele ekleyip gösterdi ilk baştaki clear ise eklenen formları alt alta dizmemesi için yazıldı.
        {
            flowLayoutPanel1.Controls.Clear();
            FormEkran.MdiParent = this;
            FormEkran.FormBorderStyle = FormBorderStyle.None;
            flowLayoutPanel1.Controls.Add(FormEkran);
            FormEkran.Show();
        }

        #region Sayfa Değişimi


        private void menüBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MenüEkleForm menuBilgi = new MenüEkleForm();
            FormYükle(menuBilgi);


        }



        #endregion

        private void siparişAlToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SiparisAlForm siparisAl = new SiparisAlForm();
            FormYükle(siparisAl);
           
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tümSiparişlerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            IkinciForm Ciro = new IkinciForm();
            FormYükle(Ciro);
        }

        private void extraMalzemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtraMalzemeEkleForm extra = new ExtraMalzemeEkleForm();

            FormYükle(extra);
        }
    }
}
