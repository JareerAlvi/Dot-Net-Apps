using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_with_DB
{
    partial class HomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGrades = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSubmitUpdate = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.grdStudents = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDOBMsg = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEmailMsg = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGradeMsg = new System.Windows.Forms.Label();
            this.lbAgeMsg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLNameMsg = new System.Windows.Forms.Label();
            this.lbFNameMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbStudentFormTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbStudentFormTitle);
            this.panel1.Controls.Add(this.cbGrades);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnSubmitUpdate);
            this.panel1.Controls.Add(this.btnUpdateStudent);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Controls.Add(this.grdStudents);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbDOBMsg);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbEmailMsg);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbGradeMsg);
            this.panel1.Controls.Add(this.lbAgeMsg);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbLNameMsg);
            this.panel1.Controls.Add(this.lbFNameMsg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(41, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 605);
            this.panel1.TabIndex = 1;
            // 
            // cbGrades
            // 
            this.cbGrades.FormattingEnabled = true;
            this.cbGrades.Location = new System.Drawing.Point(277, 229);
            this.cbGrades.Name = "cbGrades";
            this.cbGrades.Size = new System.Drawing.Size(121, 21);
            this.cbGrades.TabIndex = 27;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(620, 418);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(128, 39);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "Manage Students";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSubmitUpdate
            // 
            this.btnSubmitUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubmitUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubmitUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSubmitUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitUpdate.Location = new System.Drawing.Point(322, 356);
            this.btnSubmitUpdate.Name = "btnSubmitUpdate";
            this.btnSubmitUpdate.Size = new System.Drawing.Size(98, 39);
            this.btnSubmitUpdate.TabIndex = 25;
            this.btnSubmitUpdate.Text = "Update";
            this.btnSubmitUpdate.UseVisualStyleBackColor = false;
            this.btnSubmitUpdate.Visible = false;
            this.btnSubmitUpdate.Click += new System.EventHandler(this.btnSubmitUpdate_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateStudent.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdateStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateStudent.Location = new System.Drawing.Point(426, 384);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(98, 39);
            this.btnUpdateStudent.TabIndex = 24;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddStudent.Location = new System.Drawing.Point(185, 384);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(98, 39);
            this.btnAddStudent.TabIndex = 23;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // grdStudents
            // 
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Location = new System.Drawing.Point(2, 463);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.RowHeadersWidth = 51;
            this.grdStudents.Size = new System.Drawing.Size(746, 126);
            this.grdStudents.TabIndex = 22;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(279, 316);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date Of Birth";
            // 
            // lbDOBMsg
            // 
            this.lbDOBMsg.AutoSize = true;
            this.lbDOBMsg.ForeColor = System.Drawing.Color.Red;
            this.lbDOBMsg.Location = new System.Drawing.Point(275, 342);
            this.lbDOBMsg.Name = "lbDOBMsg";
            this.lbDOBMsg.Size = new System.Drawing.Size(0, 13);
            this.lbDOBMsg.TabIndex = 18;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(278, 271);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(194, 20);
            this.tbEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // lbEmailMsg
            // 
            this.lbEmailMsg.AutoSize = true;
            this.lbEmailMsg.ForeColor = System.Drawing.Color.Red;
            this.lbEmailMsg.Location = new System.Drawing.Point(275, 296);
            this.lbEmailMsg.Name = "lbEmailMsg";
            this.lbEmailMsg.Size = new System.Drawing.Size(0, 13);
            this.lbEmailMsg.TabIndex = 15;
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.Location = new System.Drawing.Point(278, 183);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(194, 20);
            this.tbAge.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grade";
            // 
            // lbGradeMsg
            // 
            this.lbGradeMsg.AutoSize = true;
            this.lbGradeMsg.ForeColor = System.Drawing.Color.Red;
            this.lbGradeMsg.Location = new System.Drawing.Point(275, 253);
            this.lbGradeMsg.Name = "lbGradeMsg";
            this.lbGradeMsg.Size = new System.Drawing.Size(0, 13);
            this.lbGradeMsg.TabIndex = 11;
            // 
            // lbAgeMsg
            // 
            this.lbAgeMsg.AutoSize = true;
            this.lbAgeMsg.ForeColor = System.Drawing.Color.Red;
            this.lbAgeMsg.Location = new System.Drawing.Point(276, 207);
            this.lbAgeMsg.Name = "lbAgeMsg";
            this.lbAgeMsg.Size = new System.Drawing.Size(0, 13);
            this.lbAgeMsg.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Age";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(279, 136);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(194, 20);
            this.tbLastName.TabIndex = 8;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(278, 89);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(194, 20);
            this.tbFirstName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // lbLNameMsg
            // 
            this.lbLNameMsg.AutoSize = true;
            this.lbLNameMsg.ForeColor = System.Drawing.Color.Red;
            this.lbLNameMsg.Location = new System.Drawing.Point(276, 160);
            this.lbLNameMsg.Name = "lbLNameMsg";
            this.lbLNameMsg.Size = new System.Drawing.Size(0, 13);
            this.lbLNameMsg.TabIndex = 5;
            // 
            // lbFNameMsg
            // 
            this.lbFNameMsg.AutoSize = true;
            this.lbFNameMsg.ForeColor = System.Drawing.Color.Red;
            this.lbFNameMsg.Location = new System.Drawing.Point(275, 113);
            this.lbFNameMsg.Name = "lbFNameMsg";
            this.lbFNameMsg.Size = new System.Drawing.Size(0, 13);
            this.lbFNameMsg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(1, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 40);
            this.btnBack.TabIndex = 24;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbStudentFormTitle
            // 
            this.lbStudentFormTitle.AutoSize = true;
            this.lbStudentFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentFormTitle.Location = new System.Drawing.Point(248, 12);
            this.lbStudentFormTitle.Name = "lbStudentFormTitle";
            this.lbStudentFormTitle.Size = new System.Drawing.Size(255, 42);
            this.lbStudentFormTitle.TabIndex = 28;
            this.lbStudentFormTitle.Text = "Student Form";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 651);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLNameMsg;
        private System.Windows.Forms.Label lbFNameMsg;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbGradeMsg;
        private System.Windows.Forms.Label lbAgeMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDOBMsg;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEmailMsg;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView grdStudents;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnSubmitUpdate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private ComboBox cbGrades;
        private Label lbStudentFormTitle;
    }
}