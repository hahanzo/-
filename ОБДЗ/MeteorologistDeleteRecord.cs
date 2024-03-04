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
    public partial class MeteorologistDeleteRecord : Form
    {
        public MeteorologistDeleteRecord()
        {
            InitializeComponent();
        }

        private void MeteorologistDeleteRecord_Load(object sender, EventArgs e)
        {
            textBox1.Text = h.keyName + " = " + h.curVal0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "DELETE FROM Meteorologist WHERE " + textBox1.Text;

            if (MessageBox.Show("Ви впевненіб що хочете видалити запис", "Видалення",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(h.ConStr))
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStr, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
