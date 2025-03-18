using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstek
{
    public partial class ÖneriForm : Form
    {
        public ÖneriForm()
        {
            InitializeComponent();
        }
        private void ÖneriForm_Load(object sender, EventArgs e)
        {
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            txtÖneri.Left = (this.ClientSize.Width - txtÖneri.Width) / 2;
        }

        private void textÖneri(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecenekForm sec = new SecenekForm();
            sec.Show();
            this.Close();
        }
        public bool bildirimler;

        private void gönder(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\listveri.mdf;Integrated Security=True"))
            {
                baglanti.Open();

                string zaman = DateTime.Now.ToString("dd MMMM yyyy , HH:mm:ss");

                using (SqlCommand komut = new SqlCommand("INSERT INTO oneri (zaman, oneri) VALUES (@zaman, @oneri)", baglanti))
                {
                    komut.Parameters.AddWithValue("@zaman", zaman);
                    komut.Parameters.AddWithValue("@oneri", txtÖneri.Text);

                    komut.ExecuteNonQuery(); // Veriyi veritabanına ekler
                }
            }

            MessageBox.Show("Öneri Gönderildi.");
        }
        private void OneriKey(object sender, KeyEventArgs e)
        {

        }
        private void txtÖneri_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        }
    }

