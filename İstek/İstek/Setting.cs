using System;
using System.IO;
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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;

            string bildirim = File.ReadAllText("C:\\Users\\mrcod\\source\\repos\\İstek\\İstek\\veri.txt");

            if (bildirim == "Bildirimler Açık")
            {
                button2.Text = "Bildirimleri Açık";
            }
        }

        private void geri(object sender, EventArgs e)
        {
            İlkForm ilk = new İlkForm();
            ilk.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string bildirim = "C:\\Users\\mrcod\\source\\repos\\İstek\\İstek\\veri.txt";

        private void bildirimkapa(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if (btn.Text == "Bildirimleri Kapalı")
                {
                    btn.Text = "Bildirimleri Açık";
                    File.WriteAllText(bildirim,"Bildirimler Açık");
                }
                else
                {
                    btn.Text = "Bildirimleri Kapalı";
                    File.WriteAllText(bildirim, "Bildirimler Kapalı");
                }
            }
        }
    }
}
