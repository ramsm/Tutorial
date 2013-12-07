using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinApp
{
    public partial class AnimationLable : Form
    {
        public AnimationLable()
        {
            InitializeComponent();
        }

        int x = 0; 


        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //switch (x)
            //{
            //    case 0:
            //        lblName.Location.X = 50;
            //        lblName.Location.Y = 100;
            //        x = 1;
            //        break;
            //    case 1:
            //         lblName.Location.X = 50;
            //        lblName.Location.Y = 100;
            //        x = 2;
            //        break;
            //    case 2:
            //         lblName.Location.X = 50;
            //        lblName.Location.Y = 100;
            //        x = 3;
            //        break;
            //    case 3:
            //         lblName.Location.X = 50;
            //        lblName.Location.Y = 100;
            //        x = 0;
            //        break;
            //}
        }
    }
}
