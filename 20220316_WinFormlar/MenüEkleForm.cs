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
    public partial class MenüEkleForm : Form
    {
        Hamburger HamburgerOlustur = new Hamburger();
        public MenüEkleForm()
        {
            InitializeComponent();
        }
        Listeler hamburgerolustur = new Listeler();
        private void gecBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Menü Eklensin mi?", "Sipariş Kaydet", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                HamburgerOlustur.UrunListeEkle((int)MenuFiyatEkleNum.Value, MenuEkleTxt.Text, "Lütfen aynı üründen eklemeyin");//Listeler clasımın içindeki metodu çektim ve statikte duran listenin içine değer gönderdim

               
            }
            else
            {
                MessageBox.Show("Menü Kaydedilmedi.");
            }
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenüEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuEkleBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
