namespace Ass6
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNextFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.freezePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unfreezePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.Location = new System.Drawing.Point(87, 35);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(160, 29);
            this.cb1.TabIndex = 1;
            this.cb1.Text = "Freeze Picture";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNextFormToolStripMenuItem,
            this.toolStripSeparator1,
            this.freezePictureToolStripMenuItem,
            this.unfreezePictureToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openNextFormToolStripMenuItem
            // 
            this.openNextFormToolStripMenuItem.Name = "openNextFormToolStripMenuItem";
            this.openNextFormToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openNextFormToolStripMenuItem.Text = "Open next form";
            this.openNextFormToolStripMenuItem.Click += new System.EventHandler(this.openNextFormToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // freezePictureToolStripMenuItem
            // 
            this.freezePictureToolStripMenuItem.Name = "freezePictureToolStripMenuItem";
            this.freezePictureToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.freezePictureToolStripMenuItem.Text = "Freeze Picture";
            this.freezePictureToolStripMenuItem.Click += new System.EventHandler(this.freezePictureToolStripMenuItem_Click);
            // 
            // unfreezePictureToolStripMenuItem
            // 
            this.unfreezePictureToolStripMenuItem.Name = "unfreezePictureToolStripMenuItem";
            this.unfreezePictureToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.unfreezePictureToolStripMenuItem.Text = "Unfreeze Picture";
            this.unfreezePictureToolStripMenuItem.Click += new System.EventHandler(this.unfreezePictureToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // picBox1
            // 
            this.picBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox1.Location = new System.Drawing.Point(0, 28);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(1095, 574);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 602);
            this.ControlBox = false;
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNextFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem freezePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unfreezePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

