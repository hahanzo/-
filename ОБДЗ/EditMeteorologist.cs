using MySql.Data.MySqlClient;
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
    public partial class EditMeteorologist : Form
    {
        public EditMeteorologist()
        {
            InitializeComponent();
        }

        private void UpdateItemCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            string sqlStr = "UPDATE Meteorologist SET " + tbSetToUpdate.Text + " WHERE " + tbWheteToUpdate.Text;

            if (MessageBox.Show("Ви впевнені, що хочете замінити дані?", "Заміна",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                using (MySqlConnection con = new MySqlConnection(h.ConStr)) 
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.Close();
        }
    }
}
