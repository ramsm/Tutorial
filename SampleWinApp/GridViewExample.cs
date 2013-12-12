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
            try
            {
                //SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["CommerceDbConnectionString"]);

                //SqlDataAdapter da = new SqlDataAdapter("GetOrder", connection);

                //da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //SqlParameter orderIdParameter = new SqlParameter();

                //orderIdParameter.ParameterName = "@OrderId";
                //orderIdParameter.DbType = DbType.Guid;
                //orderIdParameter.Direction = ParameterDirection.Input;
                //orderIdParameter.Value = new Guid("FCF233FB-D622-4B47-B2DA-0E59C4D39896");

                //da.SelectCommand.Parameters.Add(orderIdParameter);


                //DataSet ds = new DataSet();


                //da.Fill(ds, "Orders");

                //dgvOrders.AutoGenerateColumns = false;

                //dgvOrders.DataSource = ds.Tables["Orders"];

                SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["CommerceDbConnectionString"]);

                SqlCommand cmd = new SqlCommand("GetOrder", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter orderIdParameter = new SqlParameter();

                orderIdParameter.ParameterName = "@OrderId";
                orderIdParameter.DbType = DbType.Guid;
                orderIdParameter.Direction = ParameterDirection.Input;
                orderIdParameter.Value = new Guid("FCF233FB-D622-4B47-B2DA-0E59C4D39896");

                cmd.Parameters.Add(orderIdParameter);

                connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                dgvOrders.AutoGenerateColumns = false;

                dgvOrders.DataSource = dr;

                connection.Close();


            }
            catch (Exception ex)
            {
                
                throw;
            }            
                
        }
    }
}
