using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İstek
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private async void StartPage_Load(object sender, EventArgs e)
        {
            await Task.Delay(3000); // 3 saniye bekler.
            this.Close(); // Bu ekranı kapatır.
        }
    }
}
