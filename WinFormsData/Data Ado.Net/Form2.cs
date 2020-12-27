using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsData
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DataCekCombo();
            DataCekGrid();
        }
        private void DataCekCombo()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-TLNUALJ\SQLEXPRESS;Initial Catalog=EticaretFilm;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from tbl_Filmler", cnn);

            cnn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["FilmAdi"].ToString());
            }

            dr.Close();
            cnn.Close();
        }

        private void DataCekGrid()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-TLNUALJ\SQLEXPRESS;Initial Catalog=EticaretFilm;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Filmler", cnn);

            DataTable dt = new DataTable();

            cnn.Open();
            da.Fill(dt);

            cnn.Close();
            dataGridView1.DataSource = dt;
        }

    }
}
