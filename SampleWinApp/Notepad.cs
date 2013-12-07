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
using System.Diagnostics;


namespace SampleWinApp
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogNotepad.ShowDialog();

            StreamReader sr = new StreamReader(openFileDialogNotepad.FileName);

            txtNotepad.Text = sr.ReadToEnd();

            sr.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogNotepad.ShowDialog();

            StreamWriter sw = new StreamWriter(saveFileDialogNotepad.FileName);

            sw.WriteLine(txtNotepad.Text);

            sw.Flush();

            sw.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            Application.Exit();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo p = new ProcessStartInfo("calc.exe");

            Process.Start(p);
        }
    }
}
