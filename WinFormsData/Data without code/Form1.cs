using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eticaretFilmDataSet.tbl_Filmler' table. You can move, or remove it, as needed.
            this.tbl_FilmlerTableAdapter.Fill(this.eticaretFilmDataSet.tbl_Filmler);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
            MessageBox.Show(comboBox1.SelectedText.ToString());
        }
    }
}
