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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ОБДЗ
{
    public partial class MeteorologistAddRecord : Form
    {
        public MeteorologistAddRecord()
        {
            InitializeComponent();
        }

        private void TabInsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabInsAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                //reda data from ActinometerAddRecord
                string tb1 = textBox1.Text;
                string tb2 = textBox2.Text;
                string tb3 = textBox3.Text;
                string tb4 = textBox4.Text;
                string tb5 = textBox5.Text;
                //comand to add record
                string sql = "INSERT INTO Meteorologist " +
                    "(`idMeteorologist`, `Initials`, `Address`, `Place of work`, `Contacts`) " +
                    "VALUES (@TK1, @TK2, @TK3, @TK4, @TK5)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TK1", tb1);
                cmd.Parameters.AddWithValue("@TK2", tb2);
                cmd.Parameters.AddWithValue("@TK3", tb3);
                cmd.Parameters.AddWithValue("@TK4", tb4);
                cmd.Parameters.AddWithValue("@TK5", tb5);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Додавання запису пройшло вдало");
            }
            this.Close();
        }
    }
}
