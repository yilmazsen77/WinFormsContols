using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsContols.Dialog_boxes
{
    public partial class Image_save : Form
    {
        public Image_save()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG (*.png) | (*.png) | JPG (*.jpg) | (*.jpg) | All files (*.*) | *.*";
            ofd.FilterIndex = 3;

            DialogResult dr = ofd.ShowDialog();

            if (dr==DialogResult.OK)
            {
                string DosyaAdi = ofd.SafeFileName;
                string DosyaYolu = ofd.FileName;

                pictureBox1.ImageLocation = DosyaYolu;
                textBox1.Text = DosyaAdi;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG (*.png) | *.png | JPG (*.jpg) | *.jpg | All files (*.*) | *.*";
            sfd.FilterIndex = 2;
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            DialogResult dr = sfd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string extension = System.IO.Path.GetExtension(sfd.FileName);
                ImageFormat format = ImageFormat.Png;

                switch (extension)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }

                pictureBox1.Image.Save(sfd.FileName, format);


            }
        }
    }
}
