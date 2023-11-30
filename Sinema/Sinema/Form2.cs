using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Form2 : Form
    {
        public string tempFilm { get; set; }
        DateTime dateTime = DateTime.Now;
        public Form2()
        {
            InitializeComponent();

            //radio butonu kısıtlamaları
            if(dateTimePicker1.Value.Date == dateTime.Date) 
            {
                if (17 <= dateTime.Hour)
                {
                    radioButton1.Enabled = false; radioButton2.Enabled = false; radioButton3.Enabled = false;
                }
                else if (15 < dateTime.Hour) { radioButton1.Enabled = false; radioButton2.Enabled = false; }
                else if (13 < dateTime.Hour) { radioButton1.Enabled = false; }
            }
            //if (17 <= dateTime.Hour)
            //{
            //    radioButton1.Enabled = false; radioButton2.Enabled = false; radioButton3.Enabled = false;
            //}
            //else if (15 < dateTime.Hour) { radioButton1.Enabled = false; radioButton2.Enabled = false; }
            //else if (13 < dateTime.Hour) { radioButton1.Enabled = false; }
            //max seçilecek gün
            //dateTimePicker1.MaxDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day + 4);
            dateTimePicker1.MaxDate = dateTimePicker1.Value.AddDays(7);
            dateTimePicker1.MinDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void devamEtButton_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.tempFilm = tempFilm;
            form3.tempTarih = dateTimePicker1.Value.ToShortDateString();
            foreach (var radio in this.Controls.OfType<RadioButton>())
            {
                if (radio.Checked == true) { form3.tempSaat = radio.Text; }
                //else { MessageBox.Show("Lütfen saat seçiniz", "Uyarı"); return; }
            }

            form3.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {//dateTimePicker gün ve saat ayarlaması
            if (dateTimePicker1.Value.Date != dateTime.Date)
            {
                //if (dateTimePicker1.Value.Day > DateTime.Now.Day)
                //{
                radioButton1.Enabled = true; radioButton2.Enabled = true; radioButton3.Enabled = true;
                //}
                //else
                //{
                //if (17 <= dateTime.Hour)
                //{
                //    radioButton1.Enabled = false; radioButton2.Enabled = false; radioButton3.Enabled = false;
                //}
                //else if (15 < dateTime.Hour) { radioButton1.Enabled = false; radioButton2.Enabled = false; }
                //else if (13 < dateTime.Hour) { radioButton1.Enabled = false; }
                //}
            }
            else
            {
                if (17 <= dateTime.Hour)
                {
                    radioButton1.Enabled = false; radioButton2.Enabled = false; radioButton3.Enabled = false;
                }
                else if (15 < dateTime.Hour) { radioButton1.Enabled = false; radioButton2.Enabled = false; }
                else if (13 < dateTime.Hour) { radioButton1.Enabled = false; }
                //if (dateTimePicker1.Value.Day > DateTime.Now.Day)
                //{
                //    radioButton1.Enabled = true; radioButton2.Enabled = true; radioButton3.Enabled = true;
                //}
                //else
                //{
                //    if (17 <= dateTime.Hour)
                //    {
                //        radioButton1.Enabled = false; radioButton2.Enabled = false; radioButton3.Enabled = false;
                //    }
                //    else if (15 < dateTime.Hour) { radioButton1.Enabled = false; radioButton2.Enabled = false; }
                //    else if (13 < dateTime.Hour) { radioButton1.Enabled = false; }
                //}
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
