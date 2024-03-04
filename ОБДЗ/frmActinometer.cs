using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОБДЗ
{
    public partial class frmActinometer : Form
    {
        public frmActinometer()
        {
            InitializeComponent();
        }

        private void frmActinometer_Load(object sender, EventArgs e)
        {
            this.Height = 400;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("Select * from Actinometer");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            h.bs1.Sort = "model year DESC";

            DGWFormat();

            DataTable dtModelYear = new DataTable();
            DataTable dtModel = new DataTable();
            dtModelYear = h.myfunDt("SELECT min(`model year`), max(`model year`) FROM Actinometer");
            dtModel = h.myfunDt("SELECT Model FROM Actinometer");
            dtpDNOFrom.Value = Convert.ToDateTime(dtModelYear.Rows[0][0].ToString());
            dtpDNOTo.Value = Convert.ToDateTime(dtModelYear.Rows[0][1].ToString());

        }

        void DGWFormat()
        {
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[0].HeaderText = "N";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(btnFind.Checked)
            {
                label1.Visible = true;
                txtFind.Visible = true;
                txtFind.Focus();
            }
            else
            {
                CancelFind();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for  (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtFind.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            btnFind.Checked = false;
            CancelFind();
        }

        private void CancelFind()
        {
            label1.Visible = false;
            txtFind.Visible = false;
            txtFind.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
                dataGridView1.Rows[i].Selected = false;
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.DarkViolet, 1);
            gfx.DrawLine(p, 0, 5, 5, 5);
            gfx.DrawLine(p, 35, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (btnFilter.Checked)
            {
                this.Height = 580;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 400;
                groupBox1.Visible = false;
            }
        }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            string strFilter = "";
            strFilter += "idActinometer > 0";
            //filter Model 
            if (txtModel.Text != "")
                strFilter += " AND Model LIKE '" + txtModel.Text + "%'";
            //filter Model year
            strFilter += " AND (`model year` >= '" + dtpDNOFrom.Value.ToString("yyyy-MM-dd") + "'" +
                " AND `model year` <= '" + dtpDNOTo.Value.ToString("yyyy-MM-dd") + "')";
            
            MessageBox.Show(strFilter);

            h.bs1.Filter = strFilter;
        }

        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            h.bs1.RemoveFilter();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            ActinometerAddRecord ActAdd = new ActinometerAddRecord();
            ActAdd.ShowDialog();
            h.bs1.DataSource = h.myfunDt("select * from Actinometer");
            dataGridView1.DataSource = h.bs1;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            ActinometerDeleteRecodrd ActDelete = new ActinometerDeleteRecodrd();
            ActDelete.ShowDialog();

            h.bs1.DataSource = h.myfunDt("SELECT * FROM Actinometer");
            dataGridView1.DataSource = h.bs1;
        }
    }
}
