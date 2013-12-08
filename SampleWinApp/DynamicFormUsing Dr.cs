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
    public partial class DynamicFormUsing_Dr : Form
    {
        public DynamicFormUsing_Dr()
        {
            InitializeComponent();
        }

        private void DynamicFormUsing_Dr_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationSettings.AppSettings["CommerceDbConnectionString"]);

                SqlDataAdapter da = new SqlDataAdapter("select top 10 * from Orders", connection);

                DataSet ds = new DataSet();
                 

                da.Fill(ds, "Orders");
                

                cmbOrder.DataSource = ds.Tables["Orders"];
                cmbOrder.ValueMember = "OrderID";
                cmbOrder.DisplayMember = "OrderID";
               
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void cmbOrder_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        
    }
}
