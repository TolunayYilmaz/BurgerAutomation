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
    public partial class ExtraMalzemeEkleForm : Form
    {
        Sos SosOlustur = new Sos();
        
        public ExtraMalzemeEkleForm()
        {
            InitializeComponent();
        }

        private void ExtraMalzemeEkleForm_Load(object sender, EventArgs e)
        {
          
        }


       
        private void kydtBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Sos Eklensin mi?", "Sipariş Kaydet", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                SosOlustur.UrunListeEkle((int)SosFiyatiNmrc.Value, (string)SosAdiTxt.Text, "Lütfen aynı üründen eklemeyin");//Listeler clasımın içindeki metodu çektim ve statikte duran listenin içine değer gönderdim

            }
            else
            {
                MessageBox.Show("Sos Kaydedilmedi.");
            }
            
        }

        private void extraMalzemeBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
