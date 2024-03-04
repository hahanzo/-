using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОБДЗ
{
    public partial class myBD : Form
    {
        public myBD()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void проToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            f1.ShowDialog();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator f1 = new Calculator();
            f1.ShowDialog();
        }

        private void myBD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OpenTableActinometer_Click(object sender, EventArgs e)
        {
            frmActinometer frm = new frmActinometer();
            frm.ShowDialog();
        }

        private void OpenTableMeasuremen_Click(object sender, EventArgs e)
        {
            frmMeasurement frm = new frmMeasurement();
            frm.ShowDialog();
        }

        private void OpenTableMeteorologist_Click(object sender, EventArgs e)
        {
            frmMeteorologist frm = new frmMeteorologist();
            frm.ShowDialog();
        }

        private void OpenTableUserName_Click(object sender, EventArgs e)
        {
            frmUserName frm = new frmUserName();
            frm.ShowDialog();
        }
    }
}
