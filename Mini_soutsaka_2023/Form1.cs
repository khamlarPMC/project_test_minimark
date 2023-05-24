using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using Microsoft.SqlServer;

namespace Mini_soutsaka_2023
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connectder cd = new connectder();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void sadaeng()
        {
            da = new SqlDataAdapter("select * from product",cd.conder);
            da.Fill(ds);
            ds.Tables.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ປດToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cd.Connectder();
            sadaeng();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void ຂມນປະເພດສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product_list pl = new product_list(){TopLevel = false, TopMost = true };
            pl.FormBorderStyle = FormBorderStyle.None;
            form_popup.Controls.Add(pl);
            pl.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            product_unit pu = new product_unit() { TopLevel = false, TopMost = true };
            pu.FormBorderStyle = FormBorderStyle.None;
            form_popup.Controls.Add(pu);
            pu.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            product_list pl = new product_list() { TopLevel = false, TopMost = true };
            pl.FormBorderStyle = FormBorderStyle.None;
            form_popup.Controls.Add(pl);
            pl.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ຂມນຫວໜວຍສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product_type pt = new product_type() { TopLevel = false, TopMost = true };
            pt.FormBorderStyle = FormBorderStyle.None;
            form_popup.Controls.Add(pt);
            pt.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            product_list pl = new product_list() { TopLevel = false, TopMost = true };
            pl.FormBorderStyle = FormBorderStyle.None;
            form_popup.Controls.Add(pl);
            pl.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            product_type pt = new product_type() { TopLevel = false, TopMost = true };
            pt.FormBorderStyle = FormBorderStyle.None;
            form_popup.Controls.Add(pt);
            pt.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            product_type pt = new product_type() { TopLevel = false, TopMost = true };
            pt.FormBorderStyle = FormBorderStyle.None;
            form_popup.Controls.Add(pt);
            pt.Show();
        }

        private void ຂມນສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product_unit pu = new product_unit() { TopLevel = false, TopMost = true };
            pu.FormBorderStyle = FormBorderStyle.None;
            form_popup.Controls.Add(pu);
            pu.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            product_unit pu = new product_unit() { TopLevel = false, TopMost = true };
            pu.FormBorderStyle = FormBorderStyle.None;
            form_popup.Controls.Add(pu);
            pu.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
