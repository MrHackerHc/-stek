using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class ÖneriList : Form
    {
        public ÖneriList()
        {
            InitializeComponent();
        }

        private void geri(object sender, EventArgs e)
        {
            //Geri butona tıklanınca çalışır.
            SeçList seclst = new SeçList();
            seclst.Show();
            this.Close();
            //Bu dosya kapanır SeçList açılır.
        }

        private void IdSilText(object sender, KeyEventArgs e)
        {
            
        }
        void goster()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\listveri.mdf;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter vericek = new SqlDataAdapter("select * from oneri oneri", baglanti);
            DataSet ds = new DataSet();
            vericek.Fill(ds);
            onerilist.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void ÖneriList_Load(object sender, EventArgs e)
        {
            goster();
            onerilist.MultiSelect = false;
            onerilist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void sil(object sender, EventArgs e)
        {
            if (onerilist.SelectedRows.Count > 0) // Eğer seçili bir satır varsa
            {
                // Seçili satırın ilk sütunundaki ID değerini al
                int seciliID = Convert.ToInt32(onerilist.SelectedRows[0].Cells[0].Value);

                // Veritabanı bağlantısını oluştur
                using (SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\listveri.mdf;Integrated Security=True"))
                {
                    baglanti.Open();
                    using (SqlCommand komut = new SqlCommand("DELETE FROM oneri WHERE id = @id", baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", seciliID);
                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Öneri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
