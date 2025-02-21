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
            this.tbGrade = new System.Windows.Forms.TextBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Controls.Add(this.tbGrade);
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
            this.panel1.Location = new System.Drawing.Point(55, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 716);
            this.panel1.TabIndex = 1;
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
            this.btnNext.Location = new System.Drawing.Point(827, 486);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(171, 48);
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
            this.btnSubmitUpdate.Location = new System.Drawing.Point(429, 410);
            this.btnSubmitUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitUpdate.Name = "btnSubmitUpdate";
            this.btnSubmitUpdate.Size = new System.Drawing.Size(131, 48);
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
            this.btnUpdateStudent.Location = new System.Drawing.Point(568, 444);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(131, 48);
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
            this.btnAddStudent.Location = new System.Drawing.Point(247, 444);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(131, 48);
            this.btnAddStudent.TabIndex = 23;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // grdStudents
            // 
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Location = new System.Drawing.Point(3, 542);
            this.grdStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.RowHeadersWidth = 51;
            this.grdStudents.Size = new System.Drawing.Size(995, 155);
            this.grdStudents.TabIndex = 22;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(372, 361);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date Of Birth";
            // 
            // lbDOBMsg
            // 
            this.lbDOBMsg.AutoSize = true;
            this.lbDOBMsg.ForeColor = System.Drawing.Color.Red;
            this.lbDOBMsg.Location = new System.Drawing.Point(367, 393);
            this.lbDOBMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDOBMsg.Name = "lbDOBMsg";
            this.lbDOBMsg.Size = new System.Drawing.Size(0, 16);
            this.lbDOBMsg.TabIndex = 18;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(371, 305);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(257, 23);
            this.tbEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // lbEmailMsg
            // 
            this.lbEmailMsg.AutoSize = true;
            this.lbEmailMsg.ForeColor = System.Drawing.Color.Red;
            this.lbEmailMsg.Location = new System.Drawing.Point(367, 336);
            this.lbEmailMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmailMsg.Name = "lbEmailMsg";
            this.lbEmailMsg.Size = new System.Drawing.Size(0, 16);
            this.lbEmailMsg.TabIndex = 15;
            // 
            // tbGrade
            // 
            this.tbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGrade.Location = new System.Drawing.Point(371, 252);
            this.tbGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(257, 23);
            this.tbGrade.TabIndex = 14;
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.Location = new System.Drawing.Point(371, 197);
            this.tbAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(257, 23);
            this.tbAge.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grade";
            // 
            // lbGradeMsg
            // 
            this.lbGradeMsg.AutoSize = true;
            this.lbGradeMsg.ForeColor = System.Drawing.Color.Red;
            this.lbGradeMsg.Location = new System.Drawing.Point(367, 283);
            this.lbGradeMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGradeMsg.Name = "lbGradeMsg";
            this.lbGradeMsg.Size = new System.Drawing.Size(0, 16);
            this.lbGradeMsg.TabIndex = 11;
            // 
            // lbAgeMsg
            // 
            this.lbAgeMsg.AutoSize = true;
            this.lbAgeMsg.ForeColor = System.Drawing.Color.Red;
            this.lbAgeMsg.Location = new System.Drawing.Point(368, 226);
            this.lbAgeMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAgeMsg.Name = "lbAgeMsg";
            this.lbAgeMsg.Size = new System.Drawing.Size(0, 16);
            this.lbAgeMsg.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Age";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(372, 139);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(257, 23);
            this.tbLastName.TabIndex = 8;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(371, 81);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(257, 23);
            this.tbFirstName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // lbLNameMsg
            // 
            this.lbLNameMsg.AutoSize = true;
            this.lbLNameMsg.ForeColor = System.Drawing.Color.Red;
            this.lbLNameMsg.Location = new System.Drawing.Point(368, 169);
            this.lbLNameMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLNameMsg.Name = "lbLNameMsg";
            this.lbLNameMsg.Size = new System.Drawing.Size(0, 16);
            this.lbLNameMsg.TabIndex = 5;
            // 
            // lbFNameMsg
            // 
            this.lbFNameMsg.AutoSize = true;
            this.lbFNameMsg.ForeColor = System.Drawing.Color.Red;
            this.lbFNameMsg.Location = new System.Drawing.Point(367, 111);
            this.lbFNameMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFNameMsg.Name = "lbFNameMsg";
            this.lbFNameMsg.Size = new System.Drawing.Size(0, 16);
            this.lbFNameMsg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
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
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 49);
            this.btnBack.TabIndex = 24;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 801);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox tbGrade;
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
    }
}