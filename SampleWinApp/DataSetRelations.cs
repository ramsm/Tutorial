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
    public partial class DataSetRelations : Form
    {
        public DataSetRelations()
        {
            InitializeComponent();
        }

        private void DataSetRelations_Load(object sender, EventArgs e)
        {
            //Connection String
            SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["CommerceDbConnectionString"]);

            //Data Adapters to pull data from 2 tables
            SqlDataAdapter daOrders = new SqlDataAdapter("select * from Orders", connection);

            SqlDataAdapter daOrderItems = new SqlDataAdapter("select * from OrderItems", connection);

            //Dataset - virtula database
            DataSet ds = new DataSet();


            //Creating 2 table in Dataset
            daOrders.Fill(ds, "Orders");

            daOrderItems.Fill(ds, "OrderItems");

            

            //Data Relationship
            DataRelation dataRelation = new DataRelation("PK_Orders_OrderItems", ds.Tables["Orders"].Columns["OrderID"], ds.Tables["OrderItems"].Columns["OrderID"]);

            ds.Relations.Add(dataRelation);

            dgvRelations.AutoGenerateColumns = true;


            DataView dvOrders = ds.Tables["Orders"].DefaultView;

            dvOrders.Sort = "OrderStatusID";

            dvOrders.RowFilter = "OrderStatusID > 1";
            

            dgvRelations.DataSource = dvOrders;
        }
    }
}
