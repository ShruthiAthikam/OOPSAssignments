using System;

namespace Ass4_vs
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
            this.txtInt1 = new System.Windows.Forms.TextBox();
            this.labInt1 = new System.Windows.Forms.Label();
            this.labInt2 = new System.Windows.Forms.Label();
            this.txtInt2 = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.labRand1 = new System.Windows.Forms.Label();
            this.labRand2 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.labAbove = new System.Windows.Forms.Label();
            this.labBetween = new System.Windows.Forms.Label();
            this.labBelow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInt1
            // 
            this.txtInt1.BackColor = System.Drawing.Color.Aqua;
            this.txtInt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInt1.Location = new System.Drawing.Point(251, 13);
            this.txtInt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInt1.Name = "txtInt1";
            this.txtInt1.Size = new System.Drawing.Size(129, 45);
            this.txtInt1.TabIndex = 0;
           
            // 
            // labInt1
            // 
            this.labInt1.AutoSize = true;
            this.labInt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInt1.Location = new System.Drawing.Point(40, 24);
            this.labInt1.Name = "labInt1";
            this.labInt1.Size = new System.Drawing.Size(194, 29);
            this.labInt1.TabIndex = 2;
            this.labInt1.Text = "Enter 1st integer:";
            // 
            // labInt2
            // 
            this.labInt2.AutoSize = true;
            this.labInt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInt2.Location = new System.Drawing.Point(38, 76);
            this.labInt2.Name = "labInt2";
            this.labInt2.Size = new System.Drawing.Size(203, 29);
            this.labInt2.TabIndex = 4;
            this.labInt2.Text = "Enter 2nd integer:";
            // 
            // txtInt2
            // 
            this.txtInt2.BackColor = System.Drawing.Color.Aqua;
            this.txtInt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInt2.Location = new System.Drawing.Point(252, 72);
            this.txtInt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInt2.Name = "txtInt2";
            this.txtInt2.Size = new System.Drawing.Size(129, 45);
            this.txtInt2.TabIndex = 3;
            
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.Red;
            this.btnEnter.Location = new System.Drawing.Point(406, 71);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(101, 46);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // labRand1
            // 
            this.labRand1.AutoSize = true;
            this.labRand1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labRand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRand1.ForeColor = System.Drawing.Color.Magenta;
            this.labRand1.Location = new System.Drawing.Point(253, 127);
            this.labRand1.Name = "labRand1";
            this.labRand1.Size = new System.Drawing.Size(49, 54);
            this.labRand1.TabIndex = 6;
            this.labRand1.Text = "?";
            // 
            // labRand2
            // 
            this.labRand2.AutoSize = true;
            this.labRand2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labRand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRand2.ForeColor = System.Drawing.Color.Magenta;
            this.labRand2.Location = new System.Drawing.Point(254, 190);
            this.labRand2.Name = "labRand2";
            this.labRand2.Size = new System.Drawing.Size(49, 54);
            this.labRand2.TabIndex = 7;
            this.labRand2.Text = "?";
            // 
            // btnSub
            // 
            this.btnSub.AutoEllipsis = true;
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSub.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSub.ForeColor = System.Drawing.Color.Maroon;
            this.btnSub.Location = new System.Drawing.Point(428, 190);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(42, 49);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.AutoEllipsis = true;
            this.btnMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMul.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMul.ForeColor = System.Drawing.Color.Maroon;
            this.btnMul.Location = new System.Drawing.Point(494, 189);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(42, 49);
            this.btnMul.TabIndex = 10;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.AutoEllipsis = true;
            this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDiv.ForeColor = System.Drawing.Color.Maroon;
            this.btnDiv.Location = new System.Drawing.Point(557, 189);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(42, 49);
            this.btnDiv.TabIndex = 11;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMod
            // 
            this.btnMod.AutoEllipsis = true;
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMod.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMod.ForeColor = System.Drawing.Color.Maroon;
            this.btnMod.Location = new System.Drawing.Point(620, 189);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(42, 49);
            this.btnMod.TabIndex = 12;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.AutoEllipsis = true;
            this.btnAvg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAvg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAvg.ForeColor = System.Drawing.Color.Maroon;
            this.btnAvg.Location = new System.Drawing.Point(680, 189);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(72, 49);
            this.btnAvg.TabIndex = 13;
            this.btnAvg.Text = "Avg";
            this.btnAvg.UseVisualStyleBackColor = false;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoEllipsis = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(358, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 49);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResult.ForeColor = System.Drawing.Color.Yellow;
            this.labResult.Location = new System.Drawing.Point(254, 254);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(49, 54);
            this.labResult.TabIndex = 15;
            this.labResult.Text = "?";
            this.labResult.TextChanged += new System.EventHandler(this.labResult_TextChanged);
            // 
            // labAbove
            // 
            this.labAbove.AutoSize = true;
            this.labAbove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAbove.Location = new System.Drawing.Point(40, 343);
            this.labAbove.Name = "labAbove";
            this.labAbove.Size = new System.Drawing.Size(81, 29);
            this.labAbove.TabIndex = 16;
            this.labAbove.Text = "Above";
            // 
            // labBetween
            // 
            this.labBetween.AutoSize = true;
            this.labBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBetween.Location = new System.Drawing.Point(40, 436);
            this.labBetween.Name = "labBetween";
            this.labBetween.Size = new System.Drawing.Size(108, 29);
            this.labBetween.TabIndex = 17;
            this.labBetween.Text = "Between";
            // 
            // labBelow
            // 
            this.labBelow.AutoSize = true;
            this.labBelow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBelow.Location = new System.Drawing.Point(40, 388);
            this.labBelow.Name = "labBelow";
            this.labBelow.Size = new System.Drawing.Size(81, 29);
            this.labBelow.TabIndex = 18;
            this.labBelow.Text = "Below";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 491);
            this.Controls.Add(this.labBelow);
            this.Controls.Add(this.labBetween);
            this.Controls.Add(this.labAbove);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.labRand2);
            this.Controls.Add(this.labRand1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.labInt2);
            this.Controls.Add(this.txtInt2);
            this.Controls.Add(this.labInt1);
            this.Controls.Add(this.txtInt1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInt1;
        private System.Windows.Forms.Label labInt1;
        private System.Windows.Forms.Label labInt2;
        private System.Windows.Forms.TextBox txtInt2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label labRand1;
        private System.Windows.Forms.Label labRand2;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labAbove;
        private System.Windows.Forms.Label labBetween;
        private System.Windows.Forms.Label labBelow;
       
    }
}

