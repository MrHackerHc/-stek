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
using System.Data.SqlClient;

namespace İstek
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Geri butona tıklanınca çalışır.
            SeçList seclst = new SeçList();
            seclst.Show();
            this.Close();
            //Bu dosya kapanır SeçList açılır.
        }

        private void list_Load(object sender, EventArgs e)
        {
            goster();
            sikayetlist.MultiSelect = false;
            sikayetlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void goster()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\listveri.mdf;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter vericek = new SqlDataAdapter("select * from sıkayet",baglanti);
            DataSet ds = new DataSet();
            vericek.Fill(ds);
            sikayetlist.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void veri_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void sil(object sender, EventArgs e)
        {
            if (sikayetlist.SelectedRows.Count > 0) // Eğer seçili bir satır varsa
            {
                // Seçili satırın ilk sütunundaki ID değerini al
                int seciliID = Convert.ToInt32(sikayetlist.SelectedRows[0].Cells[0].Value);

                // Veritabanı bağlantısını oluştur
                using (SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\listveri.mdf;Integrated Security=True"))
                {
                    baglanti.Open();
                    using (SqlCommand komut = new SqlCommand("DELETE FROM sıkayet WHERE id = @id", baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", seciliID);
                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Şikayet başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Güncellenmiş verileri göster
                goster();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir öneri seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
