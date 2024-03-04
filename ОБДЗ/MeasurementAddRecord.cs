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
    public partial class MeasurementAddRecord : Form
    {
        public MeasurementAddRecord()
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
                string tb6 = textBox6.Text;
                string tb7 = textBox7.Text;
                string tb8 = textBox8.Text;
                //comand to add record
                string sql = "INSERT INTO Measurement " +
                    "(`idMeasurement`, `idMeteorologist`, `Name of the object`, `Geographic coordinates`, " +
                    "`Date and time`, `Solar radiation`, `Atmospheric radiation`, `Terrestrial radiation`)" +
                    " VALUES (@TK1, @TK2, @TK3, @TK4, @TK5, @TK6, @TK7, @TK8)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TK1", tb1);
                cmd.Parameters.AddWithValue("@TK2", tb2);
                cmd.Parameters.AddWithValue("@TK3", tb3);
                cmd.Parameters.AddWithValue("@TK4", tb4);
                cmd.Parameters.AddWithValue("@TK5", tb5);
                cmd.Parameters.AddWithValue("@TK6", tb6);
                cmd.Parameters.AddWithValue("@TK7", tb7);
                cmd.Parameters.AddWithValue("@TK8", tb8);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Додавання запису пройшло вдало");
            }
            this.Close();
        }

    }
}
