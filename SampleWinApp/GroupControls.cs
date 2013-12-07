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

using System.Configuration;

namespace SampleWinApp
{
    public partial class GroupControls : Form
    {
        public GroupControls()
        {
            InitializeComponent();
        }

        private void GroupControls_Load(object sender, EventArgs e)
        {
            List<Level> source = new List<Level>();

            //comboBox1.DataSource = source;

            //comboBox1.ValueMember = "LevelValue";
            //comboBox1.DisplayMember = "Name";

            //listBox1.DataSource = source;
            //listBox1.ValueMember = "LevelValue";
            //listBox1.DisplayMember = "Name";


            SqlConnection connection = new SqlConnection("Initial Catalog=Drsis1;Data Source=RAMS-PC\\SQLEXPRESS2008;Integrated Security=SSPI;");

            connection.Open();

            SqlCommand cmd  = new SqlCommand("select * from admin", connection);

            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;

            while (dr.Read())
            {
                Level l = new Level();

                l.Name = dr["sname"].ToString();
                l.LevelValue = i++;

                source.Add(l);
            }

            comboBox1.DataSource = source;
            comboBox1.ValueMember = "LevelValue";
            comboBox1.DisplayMember = "Name";

            connection.Close();
           
        }

        private List<Level> GetSourceValues()
        {
            List<Level> source = new List<Level>();

            Level l1 = new Level();
            l1.Name = "One";
            l1.LevelValue = 1;
            source.Add(l1);

            Level l2 = new Level();
            l2.Name = "Two";
            l2.LevelValue = 2;
            source.Add(l2);

            Level l3 = new Level();
            l3.Name = "Three";
            l3.LevelValue = 3;
            source.Add(l3);


            return source;
        }

        class Level
        {
            public string Name { get; set; }
            public int LevelValue { get; set; }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var i = comboBox1.SelectedValue;
        }
       
    }
}
