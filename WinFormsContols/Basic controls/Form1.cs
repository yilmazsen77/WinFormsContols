using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsContols
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UyeOl()
        {
            string ad, soyad, email, sifre, adres, sehir, ilgialani, uzmanlık;
            bool cinsiyet;
            DateTime tarih;

            ad = txtIsim.Text.ToString();
            soyad = txtSoyisim.Text.ToString();
            email = txtEmail.Text.ToString();
            sifre = txtSifre.Text.ToString();

            if (radioButton1.Checked == true)
            {
                cinsiyet = true;
            }
            else { cinsiyet = false; }

            tarih = dateTimePicker1.Value;

            adres = txtAdres.Text.ToString();

            sehir = comboBox1.SelectedItem.ToString();

            ilgialani = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                ilgialani += checkedListBox1.CheckedItems[i].ToString() + ",";
            }

            uzmanlık = listBox1.SelectedItem.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("İsim");
            dt.Columns.Add("Soyisim");
            dt.Columns.Add("E-Mail");
            dt.Columns.Add("Şifre");
            dt.Columns.Add("Cinsiyet");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Adres");
            dt.Columns.Add("Şehir");
            dt.Columns.Add("İlgi");
            dt.Columns.Add("Uzmanlık");

            DataRow drow = dt.NewRow();
            drow["İsim"] = ad;
            drow["Soyisim"] = soyad;
            drow["E-Mail"] = email;
            drow["Şifre"] = sifre;
            drow["Cinsiyet"] = cinsiyet.ToString();
            drow["Tarih"] = tarih.ToString();
            drow["Adres"] = adres;
            drow["Şehir"] = sehir;
            drow["İlgi"] = ilgialani;
            drow["Uzmanlık"] = uzmanlık;

            dt.Rows.Add(drow);

            dataGridView1.DataSource = dt;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("İsim");
            listView1.Columns.Add("Soyisim");
            listView1.Columns.Add("E-Mail");
            listView1.Columns.Add("Şifre");
            listView1.Columns.Add("Cinsiyet");
            listView1.Columns.Add("Tarih");
            listView1.Columns.Add("Adres");
            listView1.Columns.Add("Şehir");
            listView1.Columns.Add("İlgi");
            listView1.Columns.Add("Uzmanlık");

            string[] uyeler = { ad, soyad, email, sifre, cinsiyet.ToString(), tarih.ToString(), adres, sehir, ilgialani, uzmanlık };
            var listUye = new ListViewItem(uyeler);
            listView1.Items.Add(listUye);

        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                UyeOl();
            }
        }
    }
}
