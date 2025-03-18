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
    public partial class ListLogin : Form
    {
        public ListLogin()
        {
            InitializeComponent();
        }


        private void lstLogin(object sender, EventArgs e)
        {
            //Giriş butonuna tıklanınca çalışır.
            string password = "1234";
            string login_password = lstlogib.Text;
            //Şifre 1234 olarak tanımlanmış ve Text dosyasında girilen yazı tanımlanmış.

            if (login_password == password)
            {
                //Texte yazılan yazının gerçek şifre olup olmadığı kontrol edilir.
                SeçList seclst = new SeçList();
                seclst.Show();
                this.Close();
                //Şifre doğruysa bu ekran kapanır list açılır.
            }
            else
            {
                MessageBox.Show("Lütfen Şifreyi Tekrar Giriniz.");
                //Şifre yanlışsa mesaj Kutusu olarak çıkar.
            }
        }

        private void ListLogin_Load(object sender, EventArgs e)
        {
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            lstlogib.Left = (this.ClientSize.Width - lstlogib.Width) / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void geri(object sender, EventArgs e)
        {
            //Geri butonuna tıklanınca çalışır.
            İlkForm ilk = new İlkForm();
            ilk.Show();
            this.Close();
            //Bu ekran Kapanır İlkForm açılır.
        }

        private void LoginPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Giriş butonuna tıklanınca çalışır.
                string password = "1234";
                string login_password = lstlogib.Text;
                //Şifre 1234 olarak tanımlanmış ve Text dosyasında girilen yazı tanımlanmış.

                if (login_password == password)
                {
                    //Texte yazılan yazının gerçek şifre olup olmadığı kontrol edilir.
                    List list = new List();
                    list.Show();
                    this.Close();
                    //Şifre doğruysa bu ekran kapanır list açılır.
                }
                else
                {
                    MessageBox.Show("Lütfen Şifreyi Tekrar Giriniz.");
                    //Şifre yanlışsa mesaj Kutusu olarak çıkar.
                }
            }
        }
    }

}
