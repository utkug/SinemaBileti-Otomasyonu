using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string kullaniciAdi = "admin";//Kullanıcı Adı
        public string sifre = "admin";//Şifre

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            if (adTextBox.Text == kullaniciAdi && sifreTextBox.Text == sifre)
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
            }
            else { MessageBox.Show("Kullanıcı adı veya şifre yanlış,", "Uyarı"); }
        }
    }
}
