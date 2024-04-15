using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

                string strFileName = h.pathToPhoto;
                FileStream fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                int FileSize = (Int32)fs.Length;
                byte[] rawData = new byte[FileSize];
                fs.Read(rawData, 0, FileSize);
                fs.Close();

                //comand to add record
                string sql = "INSERT INTO Meteorologist " +
                    "(`idMeteorologist`, `Initials`, `Address`, `Place of work`, `Contacts`, `foto`) " +
                    "VALUES (@TK1, @TK2, @TK3, @TK4, @TK5, @File)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TK1", tb1);
                cmd.Parameters.AddWithValue("@TK2", tb2);
                cmd.Parameters.AddWithValue("@TK3", tb3);
                cmd.Parameters.AddWithValue("@TK4", tb4);
                cmd.Parameters.AddWithValue("@TK5", tb5);

                cmd.Parameters.AddWithValue("@File", rawData);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Додавання запису пройшло вдало");
            }
            this.Close();
        }

        private void MeteorologistAddRecord_Load(object sender, EventArgs e)
        {
            h.pathToPhoto = Application.StartupPath + @"\" + "1.jpg";
            pictureBox1.Image = Image.FromFile(h.pathToPhoto);
        }

        private void сhoosePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Виберіть файл";
            openFileDialog.Filter = "img files (*.jpg)|*.jpg|bmp file (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK) return;
            {
                h.pathToPhoto = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(h.pathToPhoto);
            }
        }
    }
}
