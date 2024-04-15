namespace ОБДЗ
{
    partial class EditMeteorologist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpdateItemButton = new System.Windows.Forms.Button();
            this.tbSetToUpdate = new System.Windows.Forms.TextBox();
            this.tbWheteToUpdate = new System.Windows.Forms.TextBox();
            this.UpdateItemCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.choosePictureButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.Location = new System.Drawing.Point(202, 577);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(133, 40);
            this.UpdateItemButton.TabIndex = 0;
            this.UpdateItemButton.Text = "Замінити";
            this.UpdateItemButton.UseVisualStyleBackColor = true;
            this.UpdateItemButton.Visible = false;
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateItemButton_Click);
            // 
            // tbSetToUpdate
            // 
            this.tbSetToUpdate.Location = new System.Drawing.Point(329, 66);
            this.tbSetToUpdate.Name = "tbSetToUpdate";
            this.tbSetToUpdate.Size = new System.Drawing.Size(189, 20);
            this.tbSetToUpdate.TabIndex = 2;
            this.tbSetToUpdate.Visible = false;
            // 
            // tbWheteToUpdate
            // 
            this.tbWheteToUpdate.Location = new System.Drawing.Point(341, 530);
            this.tbWheteToUpdate.Name = "tbWheteToUpdate";
            this.tbWheteToUpdate.Size = new System.Drawing.Size(189, 20);
            this.tbWheteToUpdate.TabIndex = 3;
            // 
            // UpdateItemCancelButton
            // 
            this.UpdateItemCancelButton.Location = new System.Drawing.Point(397, 577);
            this.UpdateItemCancelButton.Name = "UpdateItemCancelButton";
            this.UpdateItemCancelButton.Size = new System.Drawing.Size(133, 40);
            this.UpdateItemCancelButton.TabIndex = 4;
            this.UpdateItemCancelButton.Text = "Відмінити";
            this.UpdateItemCancelButton.UseVisualStyleBackColor = true;
            this.UpdateItemCancelButton.Click += new System.EventHandler(this.UpdateItemCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "SET:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "WHERE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вкажіть поля та їх нові значення";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Запишіть умови, для яких \r\nзаписів робити значення";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(37, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(262, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Текстові, числові поля та дата";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(329, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 24);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Рисунок";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.choosePictureButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.tbSetToUpdate);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 500);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(211, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 369);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(56, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Фото";
            this.label5.Visible = false;
            // 
            // choosePictureButton
            // 
            this.choosePictureButton.Location = new System.Drawing.Point(19, 173);
            this.choosePictureButton.Name = "choosePictureButton";
            this.choosePictureButton.Size = new System.Drawing.Size(133, 40);
            this.choosePictureButton.TabIndex = 12;
            this.choosePictureButton.Text = "Вибрати";
            this.choosePictureButton.UseVisualStyleBackColor = true;
            this.choosePictureButton.Visible = false;
            this.choosePictureButton.Click += new System.EventHandler(this.choosePictureButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EditMeteorologist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateItemCancelButton);
            this.Controls.Add(this.tbWheteToUpdate);
            this.Controls.Add(this.UpdateItemButton);
            this.Name = "EditMeteorologist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMeteorologist";
            this.Load += new System.EventHandler(this.EditMeteorologist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateItemButton;
        private System.Windows.Forms.TextBox tbSetToUpdate;
        private System.Windows.Forms.TextBox tbWheteToUpdate;
        private System.Windows.Forms.Button UpdateItemCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button choosePictureButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}