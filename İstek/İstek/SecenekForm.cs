using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstek
{
    public partial class SecenekForm : Form
    {
        public SecenekForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;
        }

        private void geri(object sender, EventArgs e)
        {
            //Geri butonuna tıklandığı zaman çalışır.
            İlkForm ilk = new İlkForm();
            ilk.Show();
            this.Close();
            //Bu ekranı kapar ve İlkForm açılır.
        }

        private void öneri(object sender, EventArgs e)
        {
            //Öneri butonuna tıklandığı zaman çalışır.
            ÖneriForm öneri = new ÖneriForm();
            öneri.Show();
            this.Close();
            //Bu ekran kapanır ve ÖneriForm açılır.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Şikayet botununa tıklandığı zaman çalışır.
            ŞikayetForm sikayet = new ŞikayetForm();
            sikayet.Show();
            this.Close();
            //Bu ekran kapanır ve ŞikayetForm çalışır.
        }
    }
}
