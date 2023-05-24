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
    }
}
