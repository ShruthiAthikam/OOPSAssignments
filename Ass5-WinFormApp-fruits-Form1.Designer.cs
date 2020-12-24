namespace Ass5_vs
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.btn_x1 = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btn_x3 = new System.Windows.Forms.Button();
            this.btn_x2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic1.Image = global::Ass5_vs.Properties.Resources.Watermelon;
            this.pic1.Location = new System.Drawing.Point(87, 47);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(139, 137);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic2.Image = global::Ass5_vs.Properties.Resources.Watermelon;
            this.pic2.Location = new System.Drawing.Point(271, 47);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(140, 137);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic3.Image = global::Ass5_vs.Properties.Resources.Watermelon;
            this.pic3.Location = new System.Drawing.Point(451, 47);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(139, 137);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // btn_x1
            // 
            this.btn_x1.AutoSize = true;
            this.btn_x1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x1.Location = new System.Drawing.Point(117, 216);
            this.btn_x1.Name = "btn_x1";
            this.btn_x1.Size = new System.Drawing.Size(75, 31);
            this.btn_x1.TabIndex = 3;
            this.btn_x1.Text = "x";
            this.btn_x1.UseVisualStyleBackColor = true;
            this.btn_x1.Click += new System.EventHandler(this.btn_x1_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.AutoSize = true;
            this.btnSpin.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(647, 106);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 39);
            this.btnSpin.TabIndex = 6;
            this.btnSpin.Tag = "";
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnFlip
            // 
            this.btnFlip.AutoSize = true;
            this.btnFlip.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlip.Location = new System.Drawing.Point(256, 308);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(205, 39);
            this.btnFlip.TabIndex = 7;
            this.btnFlip.Text = "Flip twice/second";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btn_x3
            // 
            this.btn_x3.AutoSize = true;
            this.btn_x3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x3.Location = new System.Drawing.Point(489, 216);
            this.btn_x3.Name = "btn_x3";
            this.btn_x3.Size = new System.Drawing.Size(75, 31);
            this.btn_x3.TabIndex = 8;
            this.btn_x3.Text = "x";
            this.btn_x3.UseVisualStyleBackColor = true;
            this.btn_x3.Click += new System.EventHandler(this.btn_x3_Click);
            // 
            // btn_x2
            // 
            this.btn_x2.AutoSize = true;
            this.btn_x2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x2.Location = new System.Drawing.Point(306, 216);
            this.btn_x2.Name = "btn_x2";
            this.btn_x2.Size = new System.Drawing.Size(75, 31);
            this.btn_x2.TabIndex = 9;
            this.btn_x2.Text = "x";
            this.btn_x2.UseVisualStyleBackColor = true;
            this.btn_x2.Click += new System.EventHandler(this.btn_x2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_x2);
            this.Controls.Add(this.btn_x3);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btn_x1);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Button btn_x1;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btn_x3;
        private System.Windows.Forms.Button btn_x2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

