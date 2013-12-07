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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void txtText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {               
                txtText.Text = (string)e.Data.GetData(DataFormats.Text);
            }
        }

        private void txtText_MouseHover(object sender, EventArgs e)
        {
            lblHover.Visible = false;
        }

        private void txtText_MouseMove(object sender, MouseEventArgs e)
        {
            lblHover.Location = new Point(e.X, e.Y);
            lblHover.Text = "Text Box";
            lblHover.Visible = true;
        }

        private void txtText_MouseLeave(object sender, EventArgs e)
        {
            lblHover.Visible = false;
        }
    }
}
