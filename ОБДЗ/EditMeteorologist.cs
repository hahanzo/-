using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
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
            string sqlStr;

            if ((checkBox1.Checked == true) && (checkBox2.Checked == false))
            {
                sqlStr = "UPDATE Meteorologist SET " + tbSetToUpdate.Text + " WHERE " + tbWheteToUpdate.Text;

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
            }

            if ((checkBox1.Checked ==  false) && (checkBox2.Checked == true))
            {
                int FileSize;
                byte[] masBytes;
                FileStream fs;
                string strFileName;

                strFileName = h.pathToPhoto;
                fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                FileSize = (Int32)fs.Length;
                masBytes = new byte[fs.Length];
                fs.Read(masBytes, 0, FileSize);
                fs.Close();

                sqlStr = "UPDATE Meteorologist SET foto = @File WHERE " + tbWheteToUpdate.Text;

                if (MessageBox.Show("Ви впевнені, що хочете замінити дані?", "Заміна",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                        cmd.Parameters.AddWithValue("@File",masBytes);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Редагування запису пройшло вдало");
                    }
                }
            }

            if ((checkBox1.Checked == true) &&  (checkBox2.Checked == true))
            {
                int FileSize;
                byte[] masBytes;
                FileStream fs;
                string strFileName;

                strFileName = h.pathToPhoto;
                fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                FileSize = (Int32)fs.Length;
                masBytes = new byte[fs.Length];
                fs.Read(masBytes, 0, FileSize);
                fs.Close();

                sqlStr = "UPDATE Meteorologist SET " + tbSetToUpdate.Text + 
                    ", foto = @File " + " WHERE " + tbWheteToUpdate.Text;

                if (MessageBox.Show("Ви впевнені, що хочете замінити дані?", "Заміна",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                        cmd.Parameters.AddWithValue("@File", masBytes);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Редагування запису пройшло вдало");
                    }
                }
            }
            this.Close();
        }

        private void EditMeteorologist_Load(object sender, EventArgs e)
        {
            h.pathToPhoto = Application.StartupPath + @"\" + "1.jpg";
            pictureBox1.Image = Image.FromFile(h.pathToPhoto);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            { 
                label1.Visible = true;
                label3.Visible = true;
                tbSetToUpdate.Visible = true;
                UpdateItemButton.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {
                label1.Visible = false;
                label3.Visible = false;
                tbSetToUpdate.Visible = false;
                if (checkBox2.Checked == false)
                {
                    UpdateItemButton.Visible = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                panel2.Visible = true;
                label5.Visible = true;
                choosePictureButton.Visible = true;
                pictureBox1 .Visible = true;
                UpdateItemButton .Visible = true;
            }
            else if (checkBox2.Checked == false)
            {
                panel2.Visible = false;
                label5.Visible = false;
                choosePictureButton.Visible = false;
                pictureBox1.Visible = false;
                if (checkBox1.Checked == false)
                {
                    UpdateItemButton.Visible = false;
                }
            }
        }

        private void choosePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Виберіть файл";
            OFD.Filter = "img files (*.jpg)|*.jpg|bmp file (*.bmp)|*.bmp|All files (*.*)|*.*";
            OFD.InitialDirectory = Application.StartupPath;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                h.pathToPhoto = OFD.FileName;
                pictureBox1.Image = Image.FromFile(h.pathToPhoto);
            }
        }
    }
}
