using MySql.Data.MySqlClient;
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
    public partial class frmMeteorologist : Form
    {
        public frmMeteorologist()
        {
            InitializeComponent();
        }

        private void frmMeteorologist_Load(object sender, EventArgs e)
        {
            this.Height = 485;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("Select * from Meteorologist");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            DGWFormat();
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
                this.Height = 673;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 485;
                groupBox1.Visible = false;
            }
        }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            string strFilter = "";
            strFilter += "idMeteorologist > 0";
            //filter Initials
            if (txtInitials.Text != "")
                strFilter += " AND `Initials` LIKE '%" + txtInitials.Text + "%'";
            //filter Address
            if (txtAddress.Text != "")
                strFilter += " AND `Address` LIKE '%" + txtAddress.Text + "%'";
            //filter Place of work
            if (txtPlaceOfWork.Text != "")
                strFilter += " AND `Place of work` LIKE '%" + txtPlaceOfWork.Text + "%'";
            //filter Contacts
            if (txtContacts.Text != "")
                strFilter += " AND `Contacts` LIKE '%" + txtContacts.Text + "%'";

            MessageBox.Show(strFilter);

            h.bs1.Filter = strFilter;
        }

        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            h.bs1.RemoveFilter();
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            MeteorologistAddRecord ActAdd = new MeteorologistAddRecord();
            ActAdd.ShowDialog();
            h.bs1.DataSource = h.myfunDt("select * from Meteorologist");
            dataGridView1.DataSource = h.bs1;
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            MeteorologistDeleteRecord ActDelete = new MeteorologistDeleteRecord();
            ActDelete.ShowDialog();

            h.bs1.DataSource = h.myfunDt("SELECT * FROM Meteorologist");
            dataGridView1.DataSource = h.bs1;
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            h.keyName = dataGridView1.Columns[0].Name;
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

            int curColInx = dataGridView1.CurrentCellAddress.X;
            string curColName = dataGridView1.Columns[curColInx].Name;
            string newCurCellVal = e.Value.ToString();

            if (curColName == "idMeteorologist" || curColName == "Initials" || curColName == "Address" || curColName == "Place of work" || curColName == "Contacts")
            {
                newCurCellVal = "'" + newCurCellVal + "'";
            }

            string sqlStr = "UPDATE Meteorologist SET " + "`" + curColName + "`" + " = " + newCurCellVal + " WHERE " + h.keyName + "=" + h.curVal0;

            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            EditMeteorologist editMeteorologist = new EditMeteorologist();
            editMeteorologist.ShowDialog();

            h.bs1.DataSource = h.myfunDt("SELECT * FROM Meteorologist");
            dataGridView1.DataSource = h.bs1;
        }
    }
}
