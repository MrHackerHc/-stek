using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstek
{
    public partial class ŞikayetForm : Form
    {
        public ŞikayetForm()
        {
            InitializeComponent();
        }

        private void geri(object sender, EventArgs e)
        {
            SecenekForm sec = new SecenekForm();
            sec.Show();
            this.Close();
        }

        private void Sikayet(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\listveri.mdf;Integrated Security=True"))
            {
                //Sql Bağlantısı açıyoruz ve çalıştırıyoruz.
                baglanti.Open();

                string zaman = DateTime.Now.ToString("dd MMMM yyyy , HH:mm:ss");

                using (SqlCommand komut = new SqlCommand("INSERT INTO sıkayet (zaman, sikayet) VALUES (@zaman, @sikayet)", baglanti))
                {
                    komut.Parameters.AddWithValue("@zaman", zaman);
                    komut.Parameters.AddWithValue("@sikayet", txtÖneri.Text);

                    komut.ExecuteNonQuery(); // Veriyi veritabanına ekler
                }
            }

            MessageBox.Show("Şikayet Gönderildi.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ŞikayetForm_Load(object sender, EventArgs e)
        {
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            txtÖneri.Left = (this.ClientSize.Width - txtÖneri.Width) / 2;
        }

        private void SikayetKey(object sender, KeyEventArgs e)
        {

        }

        private void txtÖneri_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
