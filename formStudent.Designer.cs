namespace Ass7
{
    partial class formStudent
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
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.labSelectStudent = new System.Windows.Forms.Label();
            this.txtTotalEarnedHours = new System.Windows.Forms.TextBox();
            this.labEnterEarnedHours = new System.Windows.Forms.Label();
            this.lbStudentCourses = new System.Windows.Forms.ListBox();
            this.labEnrollCourses = new System.Windows.Forms.Label();
            this.btnStudentSave = new System.Windows.Forms.Button();
            this.btnStudentDel = new System.Windows.Forms.Button();
            this.labEnterScores = new System.Windows.Forms.Label();
            this.labEnrolledCoursesErrorMsg = new System.Windows.Forms.Label();
            this.btnStudentClear = new System.Windows.Forms.Button();
            this.labEnterOrModifyStudentID = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbEnrolledCourses = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbCourseWk = new System.Windows.Forms.ListBox();
            this.tbScores = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnDisplayCourseGrades = new System.Windows.Forms.Button();
            this.tbCourseGrade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbStudent
            // 
            this.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(817, 36);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(121, 32);
            this.cbStudent.TabIndex = 0;
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.cbStudent_SelectedIndexChanged);
            // 
            // labSelectStudent
            // 
            this.labSelectStudent.AutoSize = true;
            this.labSelectStudent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSelectStudent.Location = new System.Drawing.Point(304, 44);
            this.labSelectStudent.Name = "labSelectStudent";
            this.labSelectStudent.Size = new System.Drawing.Size(429, 24);
            this.labSelectStudent.TabIndex = 1;
            this.labSelectStudent.Text = "Select an existing student from the drop down:";
            // 
            // txtTotalEarnedHours
            // 
            this.txtTotalEarnedHours.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEarnedHours.Location = new System.Drawing.Point(817, 153);
            this.txtTotalEarnedHours.Name = "txtTotalEarnedHours";
            this.txtTotalEarnedHours.Size = new System.Drawing.Size(100, 32);
            this.txtTotalEarnedHours.TabIndex = 2;
            this.txtTotalEarnedHours.Text = " ";
            this.txtTotalEarnedHours.TextChanged += new System.EventHandler(this.txtTotalEarnedHours_TextChanged);
            // 
            // labEnterEarnedHours
            // 
            this.labEnterEarnedHours.AutoSize = true;
            this.labEnterEarnedHours.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnterEarnedHours.Location = new System.Drawing.Point(71, 161);
            this.labEnterEarnedHours.Name = "labEnterEarnedHours";
            this.labEnterEarnedHours.Size = new System.Drawing.Size(668, 24);
            this.labEnterEarnedHours.TabIndex = 3;
            this.labEnterEarnedHours.Text = "Enter Total Earned Hours (not including those taken in current semester):";
            // 
            // lbStudentCourses
            // 
            this.lbStudentCourses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentCourses.FormattingEnabled = true;
            this.lbStudentCourses.ItemHeight = 24;
            this.lbStudentCourses.Location = new System.Drawing.Point(16, 293);
            this.lbStudentCourses.Name = "lbStudentCourses";
            this.lbStudentCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbStudentCourses.Size = new System.Drawing.Size(182, 292);
            this.lbStudentCourses.TabIndex = 4;
            this.lbStudentCourses.SelectedIndexChanged += new System.EventHandler(this.lbStudentCourses_SelectedIndexChanged);
            // 
            // labEnrollCourses
            // 
            this.labEnrollCourses.AutoSize = true;
            this.labEnrollCourses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnrollCourses.Location = new System.Drawing.Point(12, 233);
            this.labEnrollCourses.Name = "labEnrollCourses";
            this.labEnrollCourses.Size = new System.Drawing.Size(233, 24);
            this.labEnrollCourses.TabIndex = 5;
            this.labEnrollCourses.Text = "Enroll for upto 5 courses:";
            // 
            // btnStudentSave
            // 
            this.btnStudentSave.AutoSize = true;
            this.btnStudentSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentSave.Location = new System.Drawing.Point(652, 624);
            this.btnStudentSave.Name = "btnStudentSave";
            this.btnStudentSave.Size = new System.Drawing.Size(75, 34);
            this.btnStudentSave.TabIndex = 6;
            this.btnStudentSave.Text = "Save";
            this.btnStudentSave.UseVisualStyleBackColor = true;
            this.btnStudentSave.Click += new System.EventHandler(this.btnStudentSave_Click);
            // 
            // btnStudentDel
            // 
            this.btnStudentDel.AutoSize = true;
            this.btnStudentDel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentDel.Location = new System.Drawing.Point(773, 624);
            this.btnStudentDel.Name = "btnStudentDel";
            this.btnStudentDel.Size = new System.Drawing.Size(79, 34);
            this.btnStudentDel.TabIndex = 7;
            this.btnStudentDel.Text = "Delete";
            this.btnStudentDel.UseVisualStyleBackColor = true;
            this.btnStudentDel.Click += new System.EventHandler(this.btnStudentDel_Click);
            // 
            // labEnterScores
            // 
            this.labEnterScores.AutoSize = true;
            this.labEnterScores.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnterScores.Location = new System.Drawing.Point(746, 236);
            this.labEnterScores.Name = "labEnterScores";
            this.labEnterScores.Size = new System.Drawing.Size(384, 24);
            this.labEnterScores.TabIndex = 25;
            this.labEnterScores.Text = "Enter scores for the selected CourseWork:";
            // 
            // labEnrolledCoursesErrorMsg
            // 
            this.labEnrolledCoursesErrorMsg.AutoSize = true;
            this.labEnrolledCoursesErrorMsg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnrolledCoursesErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.labEnrolledCoursesErrorMsg.Location = new System.Drawing.Point(184, 624);
            this.labEnrolledCoursesErrorMsg.Name = "labEnrolledCoursesErrorMsg";
            this.labEnrolledCoursesErrorMsg.Size = new System.Drawing.Size(0, 18);
            this.labEnrolledCoursesErrorMsg.TabIndex = 40;
            // 
            // btnStudentClear
            // 
            this.btnStudentClear.AutoSize = true;
            this.btnStudentClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentClear.Location = new System.Drawing.Point(899, 624);
            this.btnStudentClear.Name = "btnStudentClear";
            this.btnStudentClear.Size = new System.Drawing.Size(79, 34);
            this.btnStudentClear.TabIndex = 41;
            this.btnStudentClear.Text = "Clear";
            this.btnStudentClear.UseVisualStyleBackColor = true;
            this.btnStudentClear.Click += new System.EventHandler(this.btnStudentClear_Click);
            // 
            // labEnterOrModifyStudentID
            // 
            this.labEnterOrModifyStudentID.AutoSize = true;
            this.labEnterOrModifyStudentID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnterOrModifyStudentID.Location = new System.Drawing.Point(110, 104);
            this.labEnterOrModifyStudentID.Name = "labEnterOrModifyStudentID";
            this.labEnterOrModifyStudentID.Size = new System.Drawing.Size(627, 24);
            this.labEnterOrModifyStudentID.TabIndex = 43;
            this.labEnterOrModifyStudentID.Text = "Enter new StudentID or Modify StudentID of Selected Student above:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(817, 96);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 32);
            this.txtStudentId.TabIndex = 42;
            this.txtStudentId.Text = " ";
            this.txtStudentId.TextChanged += new System.EventHandler(this.txtStudentId_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1032, 624);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(354, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "(Clear existing contents if any to create a new student.)";
            // 
            // lbEnrolledCourses
            // 
            this.lbEnrolledCourses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnrolledCourses.FormattingEnabled = true;
            this.lbEnrolledCourses.ItemHeight = 24;
            this.lbEnrolledCourses.Location = new System.Drawing.Point(262, 296);
            this.lbEnrolledCourses.Name = "lbEnrolledCourses";
            this.lbEnrolledCourses.Size = new System.Drawing.Size(200, 292);
            this.lbEnrolledCourses.TabIndex = 47;
            this.lbEnrolledCourses.SelectedIndexChanged += new System.EventHandler(this.lbEnrolledCourses_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 24);
            this.label11.TabIndex = 48;
            this.label11.Text = "List of Enrolled courses:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(529, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "Course Works:";
            // 
            // lbCourseWk
            // 
            this.lbCourseWk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseWk.FormattingEnabled = true;
            this.lbCourseWk.ItemHeight = 24;
            this.lbCourseWk.Location = new System.Drawing.Point(533, 296);
            this.lbCourseWk.Name = "lbCourseWk";
            this.lbCourseWk.Size = new System.Drawing.Size(200, 292);
            this.lbCourseWk.TabIndex = 49;
            this.lbCourseWk.SelectedIndexChanged += new System.EventHandler(this.lbCourseWk_SelectedIndexChanged);
            // 
            // tbScores
            // 
            this.tbScores.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScores.Location = new System.Drawing.Point(784, 326);
            this.tbScores.Name = "tbScores";
            this.tbScores.Size = new System.Drawing.Size(100, 32);
            this.tbScores.TabIndex = 51;
            this.tbScores.Text = " ";
            // 
            // btnAddScore
            // 
            this.btnAddScore.AutoSize = true;
            this.btnAddScore.Enabled = false;
            this.btnAddScore.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddScore.Location = new System.Drawing.Point(946, 324);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(109, 34);
            this.btnAddScore.TabIndex = 52;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // btnDisplayCourseGrades
            // 
            this.btnDisplayCourseGrades.AutoSize = true;
            this.btnDisplayCourseGrades.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayCourseGrades.Location = new System.Drawing.Point(777, 489);
            this.btnDisplayCourseGrades.Name = "btnDisplayCourseGrades";
            this.btnDisplayCourseGrades.Size = new System.Drawing.Size(323, 34);
            this.btnDisplayCourseGrades.TabIndex = 53;
            this.btnDisplayCourseGrades.Text = "Display Scores and Course Grades";
            this.btnDisplayCourseGrades.UseVisualStyleBackColor = true;
            this.btnDisplayCourseGrades.Click += new System.EventHandler(this.btnDisplayCourseGrades_Click);
            // 
            // tbCourseGrade
            // 
            this.tbCourseGrade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCourseGrade.Location = new System.Drawing.Point(955, 433);
            this.tbCourseGrade.Name = "tbCourseGrade";
            this.tbCourseGrade.ReadOnly = true;
            this.tbCourseGrade.Size = new System.Drawing.Size(100, 32);
            this.tbCourseGrade.TabIndex = 54;
            this.tbCourseGrade.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(780, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Course  Grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(767, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "(To remove score for coursework,clear the textbox ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(770, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "contents and click on Add Score button.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(550, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "(*Modifying enrolled courses list after giving scores will reset all the existing" +
    " scores.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "(Select all courses to be enrolled at once.)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(793, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "(Ensure that a courseWork is selected.)";
            // 
            // formStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 670);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCourseGrade);
            this.Controls.Add(this.btnDisplayCourseGrades);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.tbScores);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbCourseWk);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbEnrolledCourses);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labEnterOrModifyStudentID);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.btnStudentClear);
            this.Controls.Add(this.labEnrolledCoursesErrorMsg);
            this.Controls.Add(this.labEnterScores);
            this.Controls.Add(this.btnStudentDel);
            this.Controls.Add(this.btnStudentSave);
            this.Controls.Add(this.labEnrollCourses);
            this.Controls.Add(this.lbStudentCourses);
            this.Controls.Add(this.labEnterEarnedHours);
            this.Controls.Add(this.txtTotalEarnedHours);
            this.Controls.Add(this.labSelectStudent);
            this.Controls.Add(this.cbStudent);
            this.Name = "formStudent";
            this.Text = "formStudent";
            this.Load += new System.EventHandler(this.formStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label labSelectStudent;
        private System.Windows.Forms.TextBox txtTotalEarnedHours;
        private System.Windows.Forms.Label labEnterEarnedHours;
        private System.Windows.Forms.ListBox lbStudentCourses;
        private System.Windows.Forms.Label labEnrollCourses;
        private System.Windows.Forms.Button btnStudentSave;
        private System.Windows.Forms.Button btnStudentDel;
        private System.Windows.Forms.Label labEnterScores;
        private System.Windows.Forms.Label labEnrolledCoursesErrorMsg;
        private System.Windows.Forms.Button btnStudentClear;
        private System.Windows.Forms.Label labEnterOrModifyStudentID;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbEnrolledCourses;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbCourseWk;
        private System.Windows.Forms.TextBox tbScores;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Button btnDisplayCourseGrades;
        private System.Windows.Forms.TextBox tbCourseGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}