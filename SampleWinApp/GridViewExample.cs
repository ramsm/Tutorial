using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinApp
{
    public partial class GridViewExample : Form
    {
        public GridViewExample()
        {
            InitializeComponent();
        }

        private void GridViewExample_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["CommerceDbConnectionString"]);

            SqlDataAdapter da = new SqlDataAdapter("select * from Orders", connection);

            DataSet ds = new DataSet();


            da.Fill(ds, "Orders");

            dgvOrders.AutoGenerateColumns = false;

            dgvOrders.DataSource = ds.Tables["Orders"];

                     
                
        }
    }
}
