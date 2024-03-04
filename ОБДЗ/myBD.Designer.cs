namespace ОБДЗ
{
    partial class myBD
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблиціБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адмініструванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableActinometer = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableMeasuremen = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableMeteorologist = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціБДToolStripMenuItem,
            this.адмініструванняToolStripMenuItem,
            this.калькуляторToolStripMenuItem,
            this.проToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблиціБДToolStripMenuItem
            // 
            this.таблиціБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTableActinometer,
            this.OpenTableMeasuremen,
            this.OpenTableMeteorologist,
            this.OpenTableUserName});
            this.таблиціБДToolStripMenuItem.Name = "таблиціБДToolStripMenuItem";
            this.таблиціБДToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.таблиціБДToolStripMenuItem.Text = "Таблиці БД";
            // 
            // адмініструванняToolStripMenuItem
            // 
            this.адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            this.адмініструванняToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.калькуляторToolStripMenuItem_Click);
            // 
            // проToolStripMenuItem
            // 
            this.проToolStripMenuItem.Name = "проToolStripMenuItem";
            this.проToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.проToolStripMenuItem.Text = "Про програму ";
            this.проToolStripMenuItem.Click += new System.EventHandler(this.проToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // OpenTableActinometer
            // 
            this.OpenTableActinometer.Image = global::ОБДЗ.Properties.Resources.Actinometer;
            this.OpenTableActinometer.Name = "OpenTableActinometer";
            this.OpenTableActinometer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.OpenTableActinometer.Size = new System.Drawing.Size(203, 22);
            this.OpenTableActinometer.Text = "Актинометр";
            this.OpenTableActinometer.Click += new System.EventHandler(this.OpenTableActinometer_Click);
            // 
            // OpenTableMeasuremen
            // 
            this.OpenTableMeasuremen.Image = global::ОБДЗ.Properties.Resources.Measurement;
            this.OpenTableMeasuremen.Name = "OpenTableMeasuremen";
            this.OpenTableMeasuremen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.OpenTableMeasuremen.Size = new System.Drawing.Size(203, 22);
            this.OpenTableMeasuremen.Text = "Вимірювання";
            this.OpenTableMeasuremen.Click += new System.EventHandler(this.OpenTableMeasuremen_Click);
            // 
            // OpenTableMeteorologist
            // 
            this.OpenTableMeteorologist.Image = global::ОБДЗ.Properties.Resources.Meteorologist;
            this.OpenTableMeteorologist.Name = "OpenTableMeteorologist";
            this.OpenTableMeteorologist.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.OpenTableMeteorologist.Size = new System.Drawing.Size(203, 22);
            this.OpenTableMeteorologist.Text = "Метеорологісти";
            this.OpenTableMeteorologist.Click += new System.EventHandler(this.OpenTableMeteorologist_Click);
            // 
            // OpenTableUserName
            // 
            this.OpenTableUserName.Image = global::ОБДЗ.Properties.Resources.User;
            this.OpenTableUserName.Name = "OpenTableUserName";
            this.OpenTableUserName.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.OpenTableUserName.Size = new System.Drawing.Size(203, 22);
            this.OpenTableUserName.Text = "Користувачі";
            this.OpenTableUserName.Click += new System.EventHandler(this.OpenTableUserName_Click);
            // 
            // myBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 460);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "myBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вимірювання";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myBD_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблиціБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адмініструванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTableActinometer;
        private System.Windows.Forms.ToolStripMenuItem OpenTableMeasuremen;
        private System.Windows.Forms.ToolStripMenuItem OpenTableMeteorologist;
        private System.Windows.Forms.ToolStripMenuItem OpenTableUserName;
    }
}

