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

        }
    }
}
