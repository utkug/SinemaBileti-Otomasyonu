using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sinema
{
    public partial class Form5 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=sinema;Uid=root;Pwd=utku;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form5()
        {
            InitializeComponent();

        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM biletler", conn);
            adapter.Fill(dt);
            biletlerDataGridView.DataSource = dt;
            conn.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }
        private void biletlerDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)//Görütüleme
        {
            idTextBox.Text = biletlerDataGridView.CurrentRow.Cells[0].Value.ToString();
            filmTextBox.Text = biletlerDataGridView.CurrentRow.Cells[1].Value.ToString();
            saatTextBox.Text = biletlerDataGridView.CurrentRow.Cells[2].Value.ToString();
            tarihTextBox.Text = biletlerDataGridView.CurrentRow.Cells[3].Value.ToString();
            isimTextBox.Text = biletlerDataGridView.CurrentRow.Cells[4].Value.ToString();
            ucretTextBox.Text = biletlerDataGridView.CurrentRow.Cells[5].Value.ToString();
            koltuk1TextBox.Text = biletlerDataGridView.CurrentRow.Cells[6].Value.ToString();
            koltuk2TextBox.Text = biletlerDataGridView.CurrentRow.Cells[7].Value.ToString();
            koltuk3TextBox.Text = biletlerDataGridView.CurrentRow.Cells[8].Value.ToString();
            koltuk4TextBox.Text = biletlerDataGridView.CurrentRow.Cells[9].Value.ToString();


        }

        private void ekleButton_Click(object sender, EventArgs e)//Ekle Butonu
        {
            string sorguEkle = "Insert into biletler (film,saat,tarih,isim_soyisim,ucret,koltuk1,koltuk2,koltuk3,koltuk4) values (@film,@saat,@tarih,@isim,@ucret,@koltuk1,@koltuk2,@koltuk3,@koltuk4)";
            cmd = new MySqlCommand(sorguEkle, conn);
            cmd.Parameters.AddWithValue("@film", filmTextBox.Text);
            cmd.Parameters.AddWithValue("@saat", saatTextBox.Text);
            cmd.Parameters.AddWithValue("@tarih", tarihTextBox.Text);
            cmd.Parameters.AddWithValue("@isim", isimTextBox.Text);
            cmd.Parameters.AddWithValue("@ucret", Convert.ToInt32(ucretTextBox.Text));
            cmd.Parameters.AddWithValue("@koltuk1", koltuk1TextBox.Text);
            cmd.Parameters.AddWithValue("@koltuk2", koltuk2TextBox.Text);
            cmd.Parameters.AddWithValue("@koltuk3", koltuk3TextBox.Text);
            cmd.Parameters.AddWithValue("@koltuk4", koltuk4TextBox.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Eklendi.", "Bilgi");
        }

        private void silButton_Click(object sender, EventArgs e)//Sil butonu
        {
            string sorguSil = "DELETE FROM biletler WHERE id=@no";
            cmd = new MySqlCommand(sorguSil, conn);
            cmd.Parameters.AddWithValue("@no", idTextBox.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Silindi.", "Bilgi");
        }

        private void guncelleButton_Click(object sender, EventArgs e)//Güncelle Butonu
        {
            string sorguGuncel = "UPDATE biletler SET film=@film,saat=@saat," +
                "tarih=@tarih,isim_soyisim=@isim,ucret=@ucret," +
                "koltuk1=@koltuk1,koltuk2=@koltuk2,koltuk3=@koltuk3,koltuk4=@koltuk4 WHERE id=@no";
            cmd = new MySqlCommand(sorguGuncel, conn);
            cmd.Parameters.AddWithValue("@film", filmTextBox.Text);
            cmd.Parameters.AddWithValue("@saat", saatTextBox.Text);
            cmd.Parameters.AddWithValue("@tarih", tarihTextBox.Text);
            cmd.Parameters.AddWithValue("@isim", isimTextBox.Text);
            cmd.Parameters.AddWithValue("@ucret", Convert.ToInt32(ucretTextBox.Text));
            cmd.Parameters.AddWithValue("@koltuk1", koltuk1TextBox.Text);
            cmd.Parameters.AddWithValue("@koltuk2", koltuk2TextBox.Text);
            cmd.Parameters.AddWithValue("@koltuk3", koltuk3TextBox.Text);
            cmd.Parameters.AddWithValue("@koltuk4", koltuk4TextBox.Text);
            cmd.Parameters.AddWithValue("@no", idTextBox.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Güncellendi.", "Bilgi");

        }
    }
}
