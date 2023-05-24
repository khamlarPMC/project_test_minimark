using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using Microsoft.SqlServer;

namespace Mini_soutsaka_2023
{
    public partial class product_unit : Form
    {

        string imder = null;
        public product_unit()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void bthoup_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd=new OpenFileDialog())
                  {
                    if (ofd.ShowDialog()==DialogResult.OK)
                {
                    imder = ofd.FileName;
                    pthoup.Image=Image.FromFile(ofd.FileName);
                }
                   }
        }

        private void pthoup_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
