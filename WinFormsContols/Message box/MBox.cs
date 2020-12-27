using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsContols.Message_box
{
    public partial class MBox : Form
    {
        public MBox()
        {
            InitializeComponent();
            MessageBox.Show("Message", "Title");

            DialogResult result = MessageBox.Show("Sure?","Exit", MessageBoxButtons.YesNo);
            DialogResult result7 = MessageBox.Show("Sure?","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            DialogResult result2 = MessageBox.Show("Sure?","Exit", MessageBoxButtons.YesNoCancel);
            DialogResult result3 = MessageBox.Show("Sure?","Exit", MessageBoxButtons.OK);
            DialogResult result4 = MessageBox.Show("Sure?","Exit", MessageBoxButtons.AbortRetryIgnore);


            DialogResult result5 = MessageBox.Show("Sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DialogResult result6 = MessageBox.Show("Sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);


            //if (result2 == DialogResult.Yes)
            //{
            //    this.Close();
            //}
            //else if (result == DialogResult.No)
            //{

            //}
        }
    }
}
