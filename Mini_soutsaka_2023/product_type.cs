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
    public partial class product_type : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connectder cd = new connectder();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void sadaeng()
        {
            da = new SqlDataAdapter("select * from unit", cd.conder);
            da.Fill(ds);
            ds.Tables.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].HeaderText = "ລະຫັດ";
            dataGridView1.Columns[1].HeaderText = "ຊື່ຫົວໜ່ວຍສິນຄ້າ";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 362;


        }
        public product_type()
        {
            InitializeComponent();
        }

        private void product_type_Load(object sender, EventArgs e)
        {
            cd.Connectder();
            sadaeng();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into unit values(@u_name)", cd.conder);
            cmd.Parameters.AddWithValue("@u_name", txtname.Text);
            if (cmd.ExecuteNonQuery() == 1)
            {
                sadaeng();
                txtname.Clear();
                MessageBox.Show("Save Successfuly");
            }
            else
            {
                MessageBox.Show("Save not found!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update unit set u_name=@u_name where u_id=@u_id", cd.conder);
            cmd.Parameters.AddWithValue("@u_id", txtid.Text);
            cmd.Parameters.AddWithValue("@u_name", txtname.Text);
            if (cmd.ExecuteNonQuery() == 1)
            {
                sadaeng();
                txtname.Clear();
                MessageBox.Show("Update Successfuly");
            }
            else
            {
                MessageBox.Show("Update not found!!!");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from unit where u_name like N'" + txtsearch.Text + "%'", cd.conder);
            da.Fill(ds);
            ds.Tables[0].Rows.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete unit where u_id=@u_id", cd.conder);
            cmd.Parameters.AddWithValue("@u_id", txtid.Text);
            if (cmd.ExecuteNonQuery() == 1)
            {
                sadaeng();
                txtname.Clear();
                MessageBox.Show("Delete Successfuly");
            }
            else
            {
                MessageBox.Show("Delete not found!!!");
            }
        }
    }
}
