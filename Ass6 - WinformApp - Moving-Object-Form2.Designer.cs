namespace Ass6
{
    partial class Form2
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
            this.btn = new System.Windows.Forms.Button();
            this.timerACW = new System.Windows.Forms.Timer(this.components);
            this.timerCW = new System.Windows.Forms.Timer(this.components);
            this.radbtnACW = new System.Windows.Forms.RadioButton();
            this.radbtnCW = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.counterclockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Blue;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(40, 40);
            this.btn.TabIndex = 0;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // timerACW
            // 
            this.timerACW.Enabled = true;
            this.timerACW.Tick += new System.EventHandler(this.timerACW_Tick);
            // 
            // timerCW
            // 
            this.timerCW.Tick += new System.EventHandler(this.timerCW_Tick);
            // 
            // radbtnACW
            // 
            this.radbtnACW.AutoSize = true;
            this.radbtnACW.Checked = true;
            this.radbtnACW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnACW.Location = new System.Drawing.Point(7, 56);
            this.radbtnACW.Name = "radbtnACW";
            this.radbtnACW.Size = new System.Drawing.Size(187, 29);
            this.radbtnACW.TabIndex = 1;
            this.radbtnACW.TabStop = true;
            this.radbtnACW.Text = "Counterclockwise";
            this.radbtnACW.UseVisualStyleBackColor = true;
            this.radbtnACW.CheckedChanged += new System.EventHandler(this.SelectDirection);
            // 
            // radbtnCW
            // 
            this.radbtnCW.AutoSize = true;
            this.radbtnCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnCW.Location = new System.Drawing.Point(7, 21);
            this.radbtnCW.Name = "radbtnCW";
            this.radbtnCW.Size = new System.Drawing.Size(122, 29);
            this.radbtnCW.TabIndex = 2;
            this.radbtnCW.Text = "Clockwise";
            this.radbtnCW.UseVisualStyleBackColor = true;
            this.radbtnCW.CheckedChanged += new System.EventHandler(this.SelectDirection);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.radbtnACW);
            this.groupBox1.Controls.Add(this.radbtnCW);
            this.groupBox1.Location = new System.Drawing.Point(87, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockwiseToolStripMenuItem,
            this.counterclockwiseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 52);
            // 
            // clockwiseToolStripMenuItem
            // 
            this.clockwiseToolStripMenuItem.Name = "clockwiseToolStripMenuItem";
            this.clockwiseToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.clockwiseToolStripMenuItem.Text = "Clockwise";
            this.clockwiseToolStripMenuItem.Click += new System.EventHandler(this.clockwiseToolStripMenuItem_Click);
            // 
            // counterclockwiseToolStripMenuItem
            // 
            this.counterclockwiseToolStripMenuItem.Name = "counterclockwiseToolStripMenuItem";
            this.counterclockwiseToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.counterclockwiseToolStripMenuItem.Text = "Counterclockwise";
            this.counterclockwiseToolStripMenuItem.Click += new System.EventHandler(this.counterclockwiseToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 199);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.DoubleClick += new System.EventHandler(this.Form2_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Timer timerACW;
        private System.Windows.Forms.Timer timerCW;
        private System.Windows.Forms.RadioButton radbtnACW;
        private System.Windows.Forms.RadioButton radbtnCW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem counterclockwiseToolStripMenuItem;
    }
}
