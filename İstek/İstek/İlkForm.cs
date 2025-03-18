using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// this.FormBorderStyle = FormBorderStyle.None; ** Bu kod Çıkış yerlerini Gizler.

namespace İstek
{
    public partial class İlkForm : Form
    {
        public İlkForm()
        {
            InitializeComponent();
        }
        
        private void İlkForm_Load(object sender, EventArgs e)
        {
            //Yazıları Ortalıyoruz.bz
            button.Left = (this.ClientSize.Width - button.Width) / 2;
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;

            button.FlatStyle = FlatStyle.Flat;  // Düz stil seç
            button.FlatAppearance.BorderSize = 0;  // Kenarlıkları kaldır
            button.BackColor = Color.FromArgb(255, 128, 0);  // Arka plan rengini belirle
            button.ForeColor = Color.White;  // Yazı rengini ayarla

            // Kenarları yuvarlatmak için GraphicsPath kullanma
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, button.Height, button.Height, 180, 90); // Sol üst köşe
            path.AddArc(button.Width - button.Height, 0, button.Height, button.Height, 270, 90); // Sağ üst köşe
            path.AddArc(button.Width - button.Height, button.Height - button.Height, button.Height, button.Height, 0, 90); // Sağ alt köşe
            path.AddArc(0, button.Height - button.Height, button.Height, button.Height, 90, 90); // Sol alt köşe
            path.CloseAllFigures();

            button.Region = new Region(path);
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;

            // Butonu forma ekleme
            Controls.Add(button);
        }

        private void Sk(object sender, EventArgs e)
        {
            // İstek Butonuna tıklandığı zaman çalışır.
            SecenekForm ana = new SecenekForm();
            ana.Show();
            this.Hide();
            //Bu ekranı kapıyor ve SecenekForm açıyor.
        }

        private void List(object sender, EventArgs e)
        {
            //List butonuna tıklandığı zaman çalışır.
            try
            {
                ListLogin lstlogin = new ListLogin();
                lstlogin.Show();
                this.Hide();
                //Bu ekranı kapar ve ListLogin formunu çalıştırır.
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Hata"+ex.Message);
                //Hata verirse Mesaj Kutusu olarak gelir ve hata mesajını gösterir
            }
        }

        private void Setting(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            this.Hide();
        }
    }
}
