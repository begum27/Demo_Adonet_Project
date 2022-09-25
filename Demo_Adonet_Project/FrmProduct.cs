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

namespace Demo_Adonet_Project
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GSJF6OR;Initial Catalog=SQL_Çalışmaları;Integrated Security=True");

            connection.Open();

            SqlCommand command = new SqlCommand("Select*from TblProduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); 
            DataTable datatable = new DataTable();
            adapter.Fill(datatable); 
            datagridview1.DataSource = datatable;

            connection.Close();
        }
    }
}
