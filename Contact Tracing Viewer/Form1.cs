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

namespace Contact_Tracing_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            string readfile = File.ReadAllText(od.FileName);
            rtxtbxViewer.Text = readfile;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtbxViewer.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Are you sure you want to exit?", "Contact Tracing Viewer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (iExit == DialogResult.No)
                {
                    return;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Contact Tracing Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
