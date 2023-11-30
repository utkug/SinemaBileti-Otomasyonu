using System.Data;
using System.Diagnostics;
using System.Resources;
using MySql.Data.MySqlClient;
using Sinema.Properties;

namespace Sinema
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start(new ProcessStartInfo("https://tr.wikipedia.org/wiki/The_Batman_(film)") { UseShellExecute = true });
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void filmLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://tr.wikipedia.org/wiki/Y%C4%B1ld%C4%B1z_Sava%C5%9Flar%C4%B1:_B%C3%B6l%C3%BCm_III_-_Sith%27in_%C4%B0ntikam%C4%B1") { UseShellExecute = true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.tempFilm = filmLabel1.Text;
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.tempFilm = filmLabel2.Text;
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.tempFilm = filmLabel3.Text;
            form2.ShowDialog();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}