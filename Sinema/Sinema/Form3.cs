using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Sinema
{
    public partial class Form3 : Form
    {
        public string tempFilm { get; set; }
        public string tempSaat { get; set; }
        public string tempTarih { get; set; }

        int tamUcret = 80;//Tam ücret
        int ogrenciUCret = 50;//Öğrenci ücret

        MySqlConnection con = new MySqlConnection("Server=localhost;Database=sinema;Uid=root;Pwd=utku;");
        MySqlCommand cmd;
        MySqlDataReader reader;

        System.Windows.Forms.Button[] butonlar;
        public Form3()
        {
            InitializeComponent();
            butonlar = new System.Windows.Forms.Button[19];
            butonlar[0] = button1; butonlar[1] = button2; butonlar[2] = button3; butonlar[3] = button4; butonlar[4] = button5; butonlar[5] = button6; butonlar[6] = button7; butonlar[7] = button8; butonlar[8] = button9; butonlar[9] = button10; butonlar[10] = button11; butonlar[11] = button12; butonlar[12] = button13; butonlar[13] = button14; butonlar[14] = button15; butonlar[15] = button16; butonlar[16] = button17; butonlar[17] = button18; butonlar[18] = button19;
            for (int k = 0; k < butonlar.Length; k++)
            {
                butonlar[k].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                butonlar[k].FlatAppearance.BorderSize = 0;
                butonlar[k].BackColor = Color.Transparent;
            }
        }

        private void tamPlusButton_Click(object sender, EventArgs e)//Arttırma Butonu
        {
            tamTextBox.Text = Convert.ToInt32(tamTextBox.Text) + 1 + "";
        }

        private void tamMinButton_Click(object sender, EventArgs e)//Azaltma Butonu
        {
            if (!(Convert.ToInt32(tamTextBox.Text) == 0))
            {
                tamTextBox.Text = Convert.ToInt32(tamTextBox.Text) - 1 + "";
            }

        }
        private void ogrPlusButton_Click(object sender, EventArgs e)//Arttırma Butonu
        {
            ogrenTextBox.Text = Convert.ToInt32(ogrenTextBox.Text) + 1 + "";
        }

        private void ogrMinButton_Click(object sender, EventArgs e)//Azaltma Butonu
        {
            if (!(Convert.ToInt32(tamTextBox.Text) == 0))
            {
                ogrenTextBox.Text = Convert.ToInt32(ogrenTextBox.Text) - 1 + "";
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string filmIsmi = tempFilm.Replace(" ", "_");
            Debug.WriteLine(filmIsmi);
            var image = Properties.Resources.ResourceManager.GetObject(filmIsmi) as Image;
            //var image = Properties.Resources.;
            //string link = "Resources/" + "Star_wars_3" + ".jpg";//Filmin resmi için
            ////string link = "C:\\Users\\Utku\\Desktop\\res\\" + tempFilm + ".jpg";//Filmin resmi için
            //string realLink = System.IO.Path.GetFullPath(link);
            //pictureBox1.Image = Image.FromFile(realLink);
            pictureBox1.Image = image;
            filmIsmiLabel.Text = "Film İsmi: " + tempFilm;
            saatLabel.Text = "Seans Saati: " + tempSaat;
            oku();
        }

        private void biletAlButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(isimTextBox.Text)) { MessageBox.Show("Lütfen isim giriniz", "Uyarı"); return; }
            if ((Convert.ToInt32(tamTextBox.Text) + Convert.ToInt32(ogrenTextBox.Text) != secilenKoltukSayisi))
            {
                MessageBox.Show("Seçilen koltuk sayısı kadar ödeyiniz", "Uyarı");
                return;
            }
            string[] secilenKoltuklar = new string[4];
            string adres;
            int koltukSayac = 0;
            int ucret = Convert.ToInt32(tamTextBox.Text) * tamUcret + Convert.ToInt32(ogrenTextBox.Text) * ogrenciUCret;
            string sorgu = "Insert into biletler (film,saat,tarih,isim_soyisim,ucret,koltuk1,koltuk2,koltuk3,koltuk4) values (@film,@saat,@tarih,@isim,@ucret,@koltuk1,@koltuk2,@koltuk3,@koltuk4)";
            cmd = new MySqlCommand(sorgu, con);//Bilgilerin veritabanına kaydedilmesi
            cmd.Parameters.AddWithValue("@film", tempFilm);
            cmd.Parameters.AddWithValue("@saat", tempSaat);
            cmd.Parameters.AddWithValue("@tarih", tempTarih);
            cmd.Parameters.AddWithValue("@isim", isimTextBox.Text);
            cmd.Parameters.AddWithValue("@ucret", ucret);
            for (int i = 0; i < butonlar.Length; i++)
            {
                if (butonlar[i].BackColor == Color.LightGreen)
                {
                    secilenKoltuklar[koltukSayac] = butonlar[i].Text;
                    koltukSayac++;
                }
            }
            cmd.Parameters.AddWithValue("@koltuk1", secilenKoltuklar[0]);
            cmd.Parameters.AddWithValue("@koltuk2", secilenKoltuklar[1]);
            cmd.Parameters.AddWithValue("@koltuk3", secilenKoltuklar[2]);
            cmd.Parameters.AddWithValue("@koltuk4", secilenKoltuklar[3]);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bilet başarıyla satın alındı", "Bilgi");
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();

        }
        public int secilenKoltukSayisi = 0;
        private void butonTiklama(object sender, EventArgs e)//19 tane koltuk için tıklama eventi
        {
            System.Windows.Forms.Button buton = (System.Windows.Forms.Button)sender;

            if (buton.BackColor == Color.Transparent)//koltuk seç
            {
                if (secilenKoltukSayisi == 4) { MessageBox.Show("En Fazla 4 adet koltuk seçilebilir", "Uyarı"); return; }
                buton.BackColor = Color.LightGreen;
                secilenKoltukSayisi++;
                koltukNoTextBox.Text += buton.Text + " ";
            }
            else if (buton.BackColor == Color.LightGreen)//koltuk secim kaldır
            {
                buton.BackColor = Color.Transparent;
                secilenKoltukSayisi--;
                int index = koltukNoTextBox.Text.IndexOf(buton.Text);
                koltukNoTextBox.Text = koltukNoTextBox.Text.Substring(0, index) + koltukNoTextBox.Text.Substring(index + buton.Text.Length);
            }
        }
        void oku()//Form ilk açıldığında koltuk verilerinin alınması için
        {
            string sorgu = "SELECT * FROM biletler WHERE film = @film AND saat=@saat AND tarih=@tarih";
            con.Open();
            cmd = new MySqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@film", tempFilm);
            cmd.Parameters.AddWithValue("@saat", tempSaat);
            cmd.Parameters.AddWithValue("@tarih", tempTarih);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //if (reader["koltuk1"].ToString() != null) { butonlar[Convert.ToInt32(reader["koltuk1"].ToString()) - 1].BackColor = Color.Red; }
                //if (reader["koltuk2"].ToString() != null) { butonlar[Convert.ToInt32(reader["koltuk2"].ToString()) - 1].BackColor = Color.Red; }
                //if (reader["koltuk3"].ToString() != null) { butonlar[Convert.ToInt32(reader["koltuk3"].ToString()) - 1].BackColor = Color.Red; }
                //if (reader["koltuk4"].ToString() != null) { butonlar[Convert.ToInt32(reader["koltuk4"].ToString()) - 1].BackColor = Color.Red; }
                string koltuk1Value = reader["koltuk1"].ToString();
                int koltuk1Int;
                if (!string.IsNullOrEmpty(koltuk1Value) && int.TryParse(koltuk1Value, out koltuk1Int))
                {
                    butonlar[koltuk1Int - 1].BackColor = Color.Red;
                }
                string koltuk2Value = reader["koltuk2"].ToString();
                int koltuk2Int;
                if (!string.IsNullOrEmpty(koltuk2Value) && int.TryParse(koltuk2Value, out koltuk2Int))
                {
                    butonlar[koltuk2Int - 1].BackColor = Color.Red;
                }
                string koltuk3Value = reader["koltuk3"].ToString();
                int koltuk3Int;
                if (!string.IsNullOrEmpty(koltuk3Value) && int.TryParse(koltuk3Value, out koltuk3Int))
                {
                    butonlar[koltuk3Int - 1].BackColor = Color.Red;
                }
                string koltuk4Value = reader["koltuk4"].ToString();
                int koltuk4Int;
                if (!string.IsNullOrEmpty(koltuk4Value) && int.TryParse(koltuk4Value, out koltuk4Int))
                {
                    butonlar[koltuk4Int - 1].BackColor = Color.Red;
                }





            }
            con.Close();
        }
    }
}
