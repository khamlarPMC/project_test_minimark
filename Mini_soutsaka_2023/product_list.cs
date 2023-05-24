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
using System.Data.Common;

namespace Mini_soutsaka_2023
{
    public partial class product_list : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connectder cd = new connectder();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void sadaeng()
        {
            da = new SqlDataAdapter("select * from type_product", cd.conder);
            da.Fill(ds);
            ds.Tables.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].HeaderText = "ລະຫັດ";
            dataGridView1.Columns[1].HeaderText = "ຊື່ປະເພດສິນຄ້າ";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 362;
        }
        public product_list()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void product_list_Load(object sender, EventArgs e)
        {
            cd.Connectder();
            sadaeng();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into type_product values(@t_name)",cd.conder);
            cmd.Parameters.AddWithValue("@t_name",txtname.Text);
            if (cmd.ExecuteNonQuery()==1)
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
            cmd = new SqlCommand("update type_product set t_name=@t_name where t_id=@t_id", cd.conder);
            cmd.Parameters.AddWithValue("@t_id", txtid.Text);
            cmd.Parameters.AddWithValue("@t_name", txtname.Text);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete type_product where t_id=@t_id", cd.conder);
            cmd.Parameters.AddWithValue("@t_id", txtid.Text);
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

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from type_product where t_name like N'"+txtsearch.Text+"%'",cd.conder);
            da.Fill(ds);
            ds.Tables[0].Rows.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
