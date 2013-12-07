using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SampleWinApp
{
    public partial class FileHandling : Form
    {     

        public FileHandling()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string[] d = Directory.GetLogicalDrives();
           

            foreach (string str in d)
            {
                cmbDirectory.Items.Add(str);
            }
        }
    }
}
