namespace ОБДЗ
{
    partial class EditActinometer
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
            this.SuspendLayout();
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.Location = new System.Drawing.Point(212, 123);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(133, 40);
            this.UpdateItemButton.TabIndex = 0;
            this.UpdateItemButton.Text = "Замінити";
            this.UpdateItemButton.UseVisualStyleBackColor = true;
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateItemButton_Click);
            // 
            // tbSetToUpdate
            // 
            this.tbSetToUpdate.Location = new System.Drawing.Point(351, 23);
            this.tbSetToUpdate.Name = "tbSetToUpdate";
            this.tbSetToUpdate.Size = new System.Drawing.Size(189, 20);
            this.tbSetToUpdate.TabIndex = 2;
            // 
            // tbWheteToUpdate
            // 
            this.tbWheteToUpdate.Location = new System.Drawing.Point(351, 76);
            this.tbWheteToUpdate.Name = "tbWheteToUpdate";
            this.tbWheteToUpdate.Size = new System.Drawing.Size(189, 20);
            this.tbWheteToUpdate.TabIndex = 3;
            // 
            // UpdateItemCancelButton
            // 
            this.UpdateItemCancelButton.Location = new System.Drawing.Point(407, 123);
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
            this.label1.Location = new System.Drawing.Point(289, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "SET:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "WHERE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вкажіть поля та їх нові значення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Запишіть умови, для яких \r\nзаписів робити значення";
            // 
            // EditActinometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 188);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateItemCancelButton);
            this.Controls.Add(this.tbWheteToUpdate);
            this.Controls.Add(this.tbSetToUpdate);
            this.Controls.Add(this.UpdateItemButton);
            this.Name = "EditActinometer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditActinometer";
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
    }
}