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
    public partial class SeçList : Form
    {
        public SeçList()
        {
            InitializeComponent();
        }

        private void geri(object sender, EventArgs e)
        {
            İlkForm ilk = new İlkForm();
            ilk.Show();
            this.Close();
        }

        private void sklst(object sender, EventArgs e)
        {
            //Şikayet Alanını Listele
            List list = new List();
            list.Show();
            this.Close();
        }

        private void onerilist(object sender, EventArgs e)
        {
            //Öneri Alanını Listele
            ÖneriList öneri = new ÖneriList();
            öneri.Show();
            this.Close();
        }

        private void SeçList_Load(object sender, EventArgs e)
        {
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;
        }
    }
}
