using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer;

namespace Mini_soutsaka_2023
{
    internal class connectder
    {
        public string con = @"Data Source=DEV-PC\SQLEXPRESS;initial Catalog=minimark_ssk; integrated security=True";
        public SqlConnection conder= new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public void Connectder()
        {
            conder.ConnectionString = con;
            conder.Open();
        }
    }
}
