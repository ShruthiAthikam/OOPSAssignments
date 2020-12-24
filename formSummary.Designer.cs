namespace Ass7
{
    partial class formSummary
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
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.labSelectCourse = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.labSelectStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCourses
            // 
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.ItemHeight = 16;
            this.lbCourses.Location = new System.Drawing.Point(39, 106);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(251, 276);
            this.lbCourses.TabIndex = 0;
            this.lbCourses.SelectedIndexChanged += new System.EventHandler(this.lbCourses_SelectedIndexChanged);
            // 
            // labSelectCourse
            // 
            this.labSelectCourse.AutoSize = true;
            this.labSelectCourse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSelectCourse.Location = new System.Drawing.Point(32, 52);
            this.labSelectCourse.Name = "labSelectCourse";
            this.labSelectCourse.Size = new System.Drawing.Size(258, 24);
            this.labSelectCourse.TabIndex = 2;
            this.labSelectCourse.Text = "Select a course from below:";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(683, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Location = new System.Drawing.Point(454, 106);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(251, 276);
            this.lbStudents.TabIndex = 4;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            // 
            // labSelectStudent
            // 
            this.labSelectStudent.AutoSize = true;
            this.labSelectStudent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSelectStudent.Location = new System.Drawing.Point(447, 52);
            this.labSelectStudent.Name = "labSelectStudent";
            this.labSelectStudent.Size = new System.Drawing.Size(267, 24);
            this.labSelectStudent.TabIndex = 5;
            this.labSelectStudent.Text = "Select a student from below:";
            // 
            // formSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labSelectStudent);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labSelectCourse);
            this.Controls.Add(this.lbCourses);
            this.Name = "formSummary";
            this.Text = "formSummary";
            this.Load += new System.EventHandler(this.formSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.Label labSelectCourse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Label labSelectStudent;
    }
}