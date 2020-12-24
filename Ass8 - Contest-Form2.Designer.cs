namespace Contest
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.labAvgA = new System.Windows.Forms.Label();
            this.labAvgB = new System.Windows.Forms.Label();
            this.lstA = new System.Windows.Forms.ListBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team A:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(767, 305);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 44);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(359, 73);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(60, 44);
            this.btnMove.TabIndex = 10;
            this.btnMove.Text = "--->";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(359, 124);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 44);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "<---";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAll.Location = new System.Drawing.Point(359, 176);
            this.btnMoveAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(60, 44);
            this.btnMoveAll.TabIndex = 12;
            this.btnMoveAll.Text = ">>";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // labAvgA
            // 
            this.labAvgA.AutoSize = true;
            this.labAvgA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAvgA.ForeColor = System.Drawing.Color.Blue;
            this.labAvgA.Location = new System.Drawing.Point(35, 295);
            this.labAvgA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAvgA.Name = "labAvgA";
            this.labAvgA.Size = new System.Drawing.Size(150, 25);
            this.labAvgA.TabIndex = 13;
            this.labAvgA.Text = "Average GPA =";
            // 
            // labAvgB
            // 
            this.labAvgB.AutoSize = true;
            this.labAvgB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAvgB.ForeColor = System.Drawing.Color.Blue;
            this.labAvgB.Location = new System.Drawing.Point(445, 295);
            this.labAvgB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAvgB.Name = "labAvgB";
            this.labAvgB.Size = new System.Drawing.Size(150, 25);
            this.labAvgB.TabIndex = 14;
            this.labAvgB.Text = "Average GPA =";
            // 
            // lstA
            // 
            this.lstA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 16;
            this.lstA.Location = new System.Drawing.Point(40, 57);
            this.lstA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(297, 228);
            this.lstA.TabIndex = 15;
            // 
            // lstB
            // 
            this.lstB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 16;
            this.lstB.Location = new System.Drawing.Point(451, 57);
            this.lstB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(305, 228);
            this.lstB.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 364);
            this.Controls.Add(this.lstB);
            this.Controls.Add(this.lstA);
            this.Controls.Add(this.labAvgB);
            this.Controls.Add(this.labAvgA);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Label labAvgA;
        private System.Windows.Forms.Label labAvgB;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.ListBox lstB;
    }
}
