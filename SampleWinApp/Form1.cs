using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleLib;


namespace SampleWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int i  = 20, j = 30;

            int z = Sum(i, j);

            txtOutput.Text = z.ToString();


            //string str = null;

            //int i;

            //int.TryParse(str, out i);

        }


        private int Sum(int x, int y)
        {
            x = 0;

            x = x + 1;

            return x + y;
        }

       
    }
}
