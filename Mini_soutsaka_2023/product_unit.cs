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
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connectder cd = new connectder();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void sadaeng()
        {
            da = new SqlDataAdapter("select * from product", cd.conder);
            da.Fill(ds);
            ds.Tables.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].HeaderText = "ລະຫັດ";
            dataGridView1.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            dataGridView1.Columns[2].HeaderText = "ປະເພດ";
            dataGridView1.Columns[3].HeaderText = "ຈຳນວນ";
            dataGridView1.Columns[4].HeaderText = "ຫົວໜ່ວຍ";
            dataGridView1.Columns[5].HeaderText = "ລາຄາ";
            dataGridView1.Columns[6].HeaderText = "ລາຄາລວມ";
            dataGridView1.Columns[7].HeaderText = "ວັນທີໝົດອາຍຸ";
            dataGridView1.Columns[8].HeaderText = "ຜູ້ສະໜອງ";
            dataGridView1.Columns[9].HeaderText = "ຮູບ";
        }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void product_unit_Load(object sender, EventArgs e)
        {
            cd.Connectder();
            sadaeng();
        }
    }
}
