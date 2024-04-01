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
    public partial class frmMeasurement : Form
    {
        public frmMeasurement()
        {
            InitializeComponent();
        }

        private void frmMeasurement_Load(object sender, EventArgs e)
        {
            this.Height = 496;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("Select * from Measurement");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            h.bs1.Sort = "Solar radiation DESC";

            DGWFormat();

            DataTable dtBorder = new DataTable();
            DataTable dtDistinct = new DataTable();
            dtBorder = h.myfunDt("SELECT min(`Date and time`), max(`Date and time`), " +
                "min(`Solar radiation`), max(`Solar radiation`), " +
                "min(`Atmospheric radiation`), max(`Atmospheric radiation`)," +
                "min(`Terrestrial radiation`), max(`Terrestrial radiation`)" +
                "FROM Measurement");
            dtDistinct = h.myfunDt("SELECT distinct `Name of the object` FROM Measurement");
            //Задаємо межі фільтрування
            dtpDNOFrom.Value = Convert.ToDateTime(dtBorder.Rows[0][0].ToString());
            dtpDNOTo.Value = Convert.ToDateTime(dtBorder.Rows[0][1].ToString());
            txtSolRFrom.Text = dtBorder.Rows[0][2].ToString();
            txtSolRTo.Text = dtBorder.Rows[0][3].ToString();
            txtAtmRFrom.Text = dtBorder.Rows[0][4].ToString();
            txtAtmRTo.Text = dtBorder.Rows[0][5].ToString();
            txtTerRFrom.Text = dtBorder.Rows[0][6].ToString();
            txtTerRTo.Text = dtBorder.Rows[0][7].ToString();

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
                this.Height = 676;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 496;
                groupBox1.Visible = false;
            }
        }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            string strFilter = "";
            strFilter += "idMeasurement > 0";
            //filter Model 
            if (txtNameOfObject.Text != "")
                strFilter += " AND `Name of the object` LIKE '" + txtNameOfObject.Text + "%'";
            //filter Model year
            strFilter += " AND (`Date and time` >= '" + dtpDNOFrom.Value.ToString("yyyy-MM-dd") + "'" +
                " AND `Date and time` <= '" + dtpDNOTo.Value.ToString("yyyy-MM-dd") + "')";
            //filter solar radiation
            if ((txtSolRFrom.Text != "") && (txtSolRTo.Text != ""))
                strFilter += " AND (`Solar radiation` >= '" + txtSolRFrom.Text.ToString().Replace('.', ',') + "'" +
                    " AND `Solar radiation` <= '" + txtSolRTo.Text.ToString().Replace('.', ',') + "')";
            else if ((txtSolRFrom.Text == "") && (txtSolRTo.Text != ""))
                strFilter += " AND (`Solar radiation` <= '" + txtSolRTo.Text.ToString().Replace('.', ',') + "')";
            else if ((txtSolRFrom.Text != "") && (txtSolRTo.Text == ""))
                strFilter += " AND (`Solar radiation` >= '" + txtSolRFrom.Text.ToString().Replace('.', ',') + "')";
            //filter atmospheric radiation
            if ((txtAtmRFrom.Text != "") && (txtAtmRTo.Text != ""))
                strFilter += " AND (`Atmospheric radiation` >= '" + txtAtmRFrom.Text.ToString().Replace('.', ',') + "'" +
                    " AND `Atmospheric radiation` <= '" + txtAtmRTo.Text.ToString().Replace('.', ',') + "')";
            else if ((txtAtmRFrom.Text == "") && (txtAtmRTo.Text != ""))
                strFilter += " AND (`Atmospheric radiation` <= '" + txtAtmRTo.Text.ToString().Replace('.', ',') + "')";
            else if ((txtAtmRFrom.Text != "") && (txtAtmRTo.Text == ""))
                strFilter += " AND (`Atmospheric radiation` >= '" + txtAtmRFrom.Text.ToString().Replace('.', ',') + "')";
            //filet terrestrial radiation
            if ((txtTerRFrom.Text != "") && (txtTerRTo.Text != ""))
                strFilter += " AND (`Terrestrial radiation` >= '" + txtTerRFrom.Text.ToString().Replace('.', ',') + "'" +
                    " AND `Terrestrial radiation` <= '" + txtTerRTo.Text.ToString().Replace('.', ',') + "')";
            else if ((txtTerRFrom.Text == "") && (txtTerRTo.Text != ""))
                strFilter += " AND (`Terrestrial radiation` <= '" + txtTerRTo.Text.ToString().Replace('.', ',') + "')";
            else if ((txtTerRFrom.Text != "") && (txtTerRTo.Text == ""))
                strFilter += " AND (`Terrestrial radiation` >= '" + txtTerRFrom.Text.ToString().Replace('.', ',') + "')";
            
            MessageBox.Show(strFilter);

            h.bs1.Filter = strFilter;
        }

        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            h.bs1.RemoveFilter();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            MeasurementAddRecord ActAdd = new MeasurementAddRecord();
            ActAdd.ShowDialog();
            h.bs1.DataSource = h.myfunDt("select * from Measurement");
            dataGridView1.DataSource = h.bs1;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            MeasurementDeleteRecord ActDelete = new MeasurementDeleteRecord();
            ActDelete.ShowDialog();

            h.bs1.DataSource = h.myfunDt("SELECT * FROM Measurement");
            dataGridView1.DataSource = h.bs1;
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            h.keyName = dataGridView1.Columns[0].Name;
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

            int curColInx = dataGridView1.CurrentCellAddress.X;
            string curColName = dataGridView1.Columns[curColInx].Name;
            string newCurCellVal = e.Value.ToString();

            if (curColName == "idMeasurement" || curColName == "idMeteorologist" || curColName == "Name of the object" 
                || curColName == "Geographic coordinates")
            {
                newCurCellVal = "'" + newCurCellVal + "'";
            }

            if (curColName == "Date and time")
            {
                newCurCellVal = Convert.ToDateTime(newCurCellVal).ToString("yyyy-MM-dd");
                newCurCellVal = "'" + newCurCellVal + "'";
            }

            if (curColName == "Solar radiation" || curColName == "Atmospheric radiation" || curColName == "Terrestrial radiation")
            {
                newCurCellVal = newCurCellVal.Replace(',','.');
            }

            string sqlStr = "UPDATE Measurement SET " + "`" + curColName + "`" + " = " + newCurCellVal + " WHERE " + h.keyName + "=" + h.curVal0;

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

            EditMeasurement editMeasurement = new EditMeasurement();
            editMeasurement.ShowDialog();

            h.bs1.DataSource = h.myfunDt("SELECT * FROM Measurement");
            dataGridView1.DataSource = h.bs1;
        }
    }
}
