namespace Ass5_vs
{
    partial class Welcome
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
            this.lab1 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.ForeColor = System.Drawing.Color.Green;
            this.lab1.Location = new System.Drawing.Point(85, 50);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(524, 27);
            this.lab1.TabIndex = 0;
            this.lab1.Text = " Welcome to Assignment 5 by Shruthi Priya Athikam.";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab4.ForeColor = System.Drawing.Color.Green;
            this.lab4.Location = new System.Drawing.Point(87, 223);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(712, 27);
            this.lab4.TabIndex = 1;
            this.lab4.Text = "You will see the total games you win and lose displayed on the form title.";
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab6.ForeColor = System.Drawing.Color.Green;
            this.lab6.Location = new System.Drawing.Point(82, 341);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(431, 27);
            this.lab6.TabIndex = 2;
            this.lab6.Text = " To begin a game, double click on this form.";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab5.ForeColor = System.Drawing.Color.Green;
            this.lab5.Location = new System.Drawing.Point(87, 282);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(987, 27);
            this.lab5.TabIndex = 3;
            this.lab5.Text = "You may play as many games as you like until you double click on its form to clos" +
    "e it and return here.";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3.ForeColor = System.Drawing.Color.Green;
            this.lab3.Location = new System.Drawing.Point(81, 165);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(869, 27);
            this.lab3.TabIndex = 4;
            this.lab3.Text = " You may choose to flip each picture once or twice per second at any time during " +
    "a game.";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.ForeColor = System.Drawing.Color.Green;
            this.lab2.Location = new System.Drawing.Point(89, 106);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(776, 27);
            this.lab2.TabIndex = 5;
            this.lab2.Text = "This program allows you to play a simple game by matching three fruit pictures.\r\n" +
    "";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1307, 588);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.lab6);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.lab1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.DoubleClick += new System.EventHandler(this.Welcome_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}
