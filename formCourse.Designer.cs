namespace Ass7
{
    partial class formCourse
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
            this.labCourseEnterCourseInfo = new System.Windows.Forms.Label();
            this.labEnterCourseName = new System.Windows.Forms.Label();
            this.labEnterCourseNo = new System.Windows.Forms.Label();
            this.labCourseWkHelpText = new System.Windows.Forms.Label();
            this.labEnterCourseWk1 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseNumber = new System.Windows.Forms.TextBox();
            this.txtCourseWk = new System.Windows.Forms.TextBox();
            this.btnCourseEnter = new System.Windows.Forms.Button();
            this.btnCourseClear = new System.Windows.Forms.Button();
            this.btnCourseExit = new System.Windows.Forms.Button();
            this.btnCourseNextForm = new System.Windows.Forms.Button();
            this.labCourseNumErrorMsg = new System.Windows.Forms.Label();
            this.btnAddCourseWk = new System.Windows.Forms.Button();
            this.lbCourseWk = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labCourseEnterCourseInfo
            // 
            this.labCourseEnterCourseInfo.AutoSize = true;
            this.labCourseEnterCourseInfo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCourseEnterCourseInfo.Location = new System.Drawing.Point(12, 18);
            this.labCourseEnterCourseInfo.Name = "labCourseEnterCourseInfo";
            this.labCourseEnterCourseInfo.Size = new System.Drawing.Size(349, 34);
            this.labCourseEnterCourseInfo.TabIndex = 0;
            this.labCourseEnterCourseInfo.Text = "Enter Course Information: ";
            // 
            // labEnterCourseName
            // 
            this.labEnterCourseName.AutoSize = true;
            this.labEnterCourseName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnterCourseName.Location = new System.Drawing.Point(15, 96);
            this.labEnterCourseName.Name = "labEnterCourseName";
            this.labEnterCourseName.Size = new System.Drawing.Size(195, 24);
            this.labEnterCourseName.TabIndex = 1;
            this.labEnterCourseName.Text = "Enter Course Name: ";
            // 
            // labEnterCourseNo
            // 
            this.labEnterCourseNo.AutoSize = true;
            this.labEnterCourseNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnterCourseNo.Location = new System.Drawing.Point(15, 172);
            this.labEnterCourseNo.Name = "labEnterCourseNo";
            this.labEnterCourseNo.Size = new System.Drawing.Size(281, 24);
            this.labEnterCourseNo.TabIndex = 2;
            this.labEnterCourseNo.Text = "Enter Unique Course Number: ";
            // 
            // labCourseWkHelpText
            // 
            this.labCourseWkHelpText.AutoSize = true;
            this.labCourseWkHelpText.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCourseWkHelpText.Location = new System.Drawing.Point(16, 296);
            this.labCourseWkHelpText.Name = "labCourseWkHelpText";
            this.labCourseWkHelpText.Size = new System.Drawing.Size(564, 17);
            this.labCourseWkHelpText.TabIndex = 4;
            this.labCourseWkHelpText.Text = "* Course Work can be an assignment (Eg. ass1), quiz (Eg. quiz1) or project (Eg. p" +
    "roject1).";
            // 
            // labEnterCourseWk1
            // 
            this.labEnterCourseWk1.AutoSize = true;
            this.labEnterCourseWk1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnterCourseWk1.Location = new System.Drawing.Point(15, 252);
            this.labEnterCourseWk1.Name = "labEnterCourseWk1";
            this.labEnterCourseWk1.Size = new System.Drawing.Size(183, 24);
            this.labEnterCourseWk1.TabIndex = 7;
            this.labEnterCourseWk1.Text = "Enter Course Work:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(325, 88);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(263, 32);
            this.txtCourseName.TabIndex = 8;
            // 
            // txtCourseNumber
            // 
            this.txtCourseNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseNumber.Location = new System.Drawing.Point(325, 164);
            this.txtCourseNumber.Name = "txtCourseNumber";
            this.txtCourseNumber.Size = new System.Drawing.Size(263, 32);
            this.txtCourseNumber.TabIndex = 9;
            this.txtCourseNumber.TextChanged += new System.EventHandler(this.txtCourseNumber_TextChanged);
            // 
            // txtCourseWk
            // 
            this.txtCourseWk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseWk.Location = new System.Drawing.Point(325, 244);
            this.txtCourseWk.Name = "txtCourseWk";
            this.txtCourseWk.Size = new System.Drawing.Size(263, 32);
            this.txtCourseWk.TabIndex = 10;
            // 
            // btnCourseEnter
            // 
            this.btnCourseEnter.AutoSize = true;
            this.btnCourseEnter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseEnter.Location = new System.Drawing.Point(887, 370);
            this.btnCourseEnter.Name = "btnCourseEnter";
            this.btnCourseEnter.Size = new System.Drawing.Size(89, 34);
            this.btnCourseEnter.TabIndex = 13;
            this.btnCourseEnter.Text = "Save";
            this.btnCourseEnter.UseVisualStyleBackColor = true;
            this.btnCourseEnter.Click += new System.EventHandler(this.btnCourseEnter_Click);
            // 
            // btnCourseClear
            // 
            this.btnCourseClear.AutoSize = true;
            this.btnCourseClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseClear.Location = new System.Drawing.Point(887, 430);
            this.btnCourseClear.Name = "btnCourseClear";
            this.btnCourseClear.Size = new System.Drawing.Size(89, 34);
            this.btnCourseClear.TabIndex = 14;
            this.btnCourseClear.Text = "Clear";
            this.btnCourseClear.UseVisualStyleBackColor = true;
            this.btnCourseClear.Click += new System.EventHandler(this.btnCourseClear_Click);
            // 
            // btnCourseExit
            // 
            this.btnCourseExit.AutoSize = true;
            this.btnCourseExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseExit.Location = new System.Drawing.Point(887, 494);
            this.btnCourseExit.Name = "btnCourseExit";
            this.btnCourseExit.Size = new System.Drawing.Size(89, 34);
            this.btnCourseExit.TabIndex = 15;
            this.btnCourseExit.Text = "Exit";
            this.btnCourseExit.UseVisualStyleBackColor = true;
            this.btnCourseExit.Click += new System.EventHandler(this.btnCourseExit_Click);
            // 
            // btnCourseNextForm
            // 
            this.btnCourseNextForm.AutoSize = true;
            this.btnCourseNextForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseNextForm.Location = new System.Drawing.Point(810, 554);
            this.btnCourseNextForm.Name = "btnCourseNextForm";
            this.btnCourseNextForm.Size = new System.Drawing.Size(166, 34);
            this.btnCourseNextForm.TabIndex = 16;
            this.btnCourseNextForm.Text = "Go to Next Form";
            this.btnCourseNextForm.UseVisualStyleBackColor = true;
            this.btnCourseNextForm.Click += new System.EventHandler(this.btnCourseNextForm_Click);
            // 
            // labCourseNumErrorMsg
            // 
            this.labCourseNumErrorMsg.AutoSize = true;
            this.labCourseNumErrorMsg.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCourseNumErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.labCourseNumErrorMsg.Location = new System.Drawing.Point(606, 137);
            this.labCourseNumErrorMsg.Name = "labCourseNumErrorMsg";
            this.labCourseNumErrorMsg.Size = new System.Drawing.Size(0, 17);
            this.labCourseNumErrorMsg.TabIndex = 17;
            // 
            // btnAddCourseWk
            // 
            this.btnAddCourseWk.AutoSize = true;
            this.btnAddCourseWk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourseWk.Location = new System.Drawing.Point(594, 242);
            this.btnAddCourseWk.Name = "btnAddCourseWk";
            this.btnAddCourseWk.Size = new System.Drawing.Size(167, 34);
            this.btnAddCourseWk.TabIndex = 18;
            this.btnAddCourseWk.Text = "Add CourseWork";
            this.btnAddCourseWk.UseVisualStyleBackColor = true;
            this.btnAddCourseWk.Click += new System.EventHandler(this.btnAddCourseWk_Click);
            // 
            // lbCourseWk
            // 
            this.lbCourseWk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseWk.FormattingEnabled = true;
            this.lbCourseWk.ItemHeight = 24;
            this.lbCourseWk.Location = new System.Drawing.Point(19, 379);
            this.lbCourseWk.Name = "lbCourseWk";
            this.lbCourseWk.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbCourseWk.Size = new System.Drawing.Size(179, 196);
            this.lbCourseWk.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "List of Course Works added:";
            // 
            // formCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCourseWk);
            this.Controls.Add(this.btnAddCourseWk);
            this.Controls.Add(this.labCourseNumErrorMsg);
            this.Controls.Add(this.btnCourseNextForm);
            this.Controls.Add(this.btnCourseExit);
            this.Controls.Add(this.btnCourseClear);
            this.Controls.Add(this.btnCourseEnter);
            this.Controls.Add(this.txtCourseWk);
            this.Controls.Add(this.txtCourseNumber);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.labEnterCourseWk1);
            this.Controls.Add(this.labCourseWkHelpText);
            this.Controls.Add(this.labEnterCourseNo);
            this.Controls.Add(this.labEnterCourseName);
            this.Controls.Add(this.labCourseEnterCourseInfo);
            this.Name = "formCourse";
            this.Text = "formCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCourseEnterCourseInfo;
        private System.Windows.Forms.Label labEnterCourseName;
        private System.Windows.Forms.Label labEnterCourseNo;
        private System.Windows.Forms.Label labCourseWkHelpText;
        private System.Windows.Forms.Label labEnterCourseWk1;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseNumber;
        private System.Windows.Forms.TextBox txtCourseWk;
        private System.Windows.Forms.Button btnCourseEnter;
        private System.Windows.Forms.Button btnCourseClear;
        private System.Windows.Forms.Button btnCourseExit;
        private System.Windows.Forms.Button btnCourseNextForm;
        private System.Windows.Forms.Label labCourseNumErrorMsg;
        private System.Windows.Forms.Button btnAddCourseWk;
        private System.Windows.Forms.ListBox lbCourseWk;
        private System.Windows.Forms.Label label1;
    }
}