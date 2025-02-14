namespace Student_Management_with_DB
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.grdStudents = new System.Windows.Forms.DataGridView();
            this.btnDisplayByGrade = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteFailingStudents = new System.Windows.Forms.Button();
            this.btnIDDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UpdatePanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateFinal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGradeUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNameUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAgeUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIDForUpdate = new System.Windows.Forms.TextBox();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.btnDeleteFinal = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbIDforDelete = new System.Windows.Forms.TextBox();
            this.GradeWiseDisplayPannel = new System.Windows.Forms.Panel();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.DisplayAll2 = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.UpdatePanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.GradeWiseDisplayPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(249, 67);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(301, 20);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grade :";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(249, 109);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(301, 20);
            this.tbAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age    :";
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(249, 156);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(301, 20);
            this.tbGrade.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(351, 213);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 28);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(249, 213);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(82, 28);
            this.btnDisplayAll.TabIndex = 8;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // grdStudents
            // 
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Location = new System.Drawing.Point(148, 288);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.Size = new System.Drawing.Size(461, 150);
            this.grdStudents.TabIndex = 9;
            // 
            // btnDisplayByGrade
            // 
            this.btnDisplayByGrade.Location = new System.Drawing.Point(249, 247);
            this.btnDisplayByGrade.Name = "btnDisplayByGrade";
            this.btnDisplayByGrade.Size = new System.Drawing.Size(82, 35);
            this.btnDisplayByGrade.TabIndex = 10;
            this.btnDisplayByGrade.Text = "Display by  Grade";
            this.btnDisplayByGrade.UseVisualStyleBackColor = true;
            this.btnDisplayByGrade.Click += new System.EventHandler(this.btnDisplayAStudents_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(351, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 28);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteFailingStudents
            // 
            this.btnDeleteFailingStudents.Location = new System.Drawing.Point(439, 247);
            this.btnDeleteFailingStudents.Name = "btnDeleteFailingStudents";
            this.btnDeleteFailingStudents.Size = new System.Drawing.Size(82, 28);
            this.btnDeleteFailingStudents.TabIndex = 16;
            this.btnDeleteFailingStudents.Text = "Delete Failed ";
            this.btnDeleteFailingStudents.UseVisualStyleBackColor = true;
            this.btnDeleteFailingStudents.Click += new System.EventHandler(this.btnDeleteFailingStudents_Click);
            // 
            // btnIDDelete
            // 
            this.btnIDDelete.Location = new System.Drawing.Point(439, 213);
            this.btnIDDelete.Name = "btnIDDelete";
            this.btnIDDelete.Size = new System.Drawing.Size(82, 28);
            this.btnIDDelete.TabIndex = 17;
            this.btnIDDelete.Text = "Delete";
            this.btnIDDelete.UseVisualStyleBackColor = true;
            this.btnIDDelete.Click += new System.EventHandler(this.btnIDDelete_Click);
            // 
            // UpdatePanel
            // 
            this.UpdatePanel.Controls.Add(this.label9);
            this.UpdatePanel.Controls.Add(this.btnUpdateFinal);
            this.UpdatePanel.Controls.Add(this.label8);
            this.UpdatePanel.Controls.Add(this.label7);
            this.UpdatePanel.Controls.Add(this.tbGradeUpdate);
            this.UpdatePanel.Controls.Add(this.label6);
            this.UpdatePanel.Controls.Add(this.tbNameUpdate);
            this.UpdatePanel.Controls.Add(this.label5);
            this.UpdatePanel.Controls.Add(this.tbAgeUpdate);
            this.UpdatePanel.Controls.Add(this.label4);
            this.UpdatePanel.Controls.Add(this.tbIDForUpdate);
            this.UpdatePanel.Location = new System.Drawing.Point(31, 12);
            this.UpdatePanel.Name = "UpdatePanel";
            this.UpdatePanel.Size = new System.Drawing.Size(707, 195);
            this.UpdatePanel.TabIndex = 19;
            this.UpdatePanel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(295, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Enter the New Data";
            // 
            // btnUpdateFinal
            // 
            this.btnUpdateFinal.Location = new System.Drawing.Point(308, 147);
            this.btnUpdateFinal.Name = "btnUpdateFinal";
            this.btnUpdateFinal.Size = new System.Drawing.Size(82, 28);
            this.btnUpdateFinal.TabIndex = 23;
            this.btnUpdateFinal.Text = "Update";
            this.btnUpdateFinal.UseVisualStyleBackColor = true;
            this.btnUpdateFinal.Click += new System.EventHandler(this.btnUpdateFinal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(-3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Enter the ID of Student to be Updated";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Grade :";
            // 
            // tbGradeUpdate
            // 
            this.tbGradeUpdate.Location = new System.Drawing.Point(212, 123);
            this.tbGradeUpdate.Name = "tbGradeUpdate";
            this.tbGradeUpdate.Size = new System.Drawing.Size(301, 20);
            this.tbGradeUpdate.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Name :";
            // 
            // tbNameUpdate
            // 
            this.tbNameUpdate.Location = new System.Drawing.Point(212, 71);
            this.tbNameUpdate.Name = "tbNameUpdate";
            this.tbNameUpdate.Size = new System.Drawing.Size(301, 20);
            this.tbNameUpdate.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Age :";
            // 
            // tbAgeUpdate
            // 
            this.tbAgeUpdate.Location = new System.Drawing.Point(212, 97);
            this.tbAgeUpdate.Name = "tbAgeUpdate";
            this.tbAgeUpdate.Size = new System.Drawing.Size(301, 20);
            this.tbAgeUpdate.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID :";
            // 
            // tbIDForUpdate
            // 
            this.tbIDForUpdate.Location = new System.Drawing.Point(212, 20);
            this.tbIDForUpdate.Name = "tbIDForUpdate";
            this.tbIDForUpdate.Size = new System.Drawing.Size(301, 20);
            this.tbIDForUpdate.TabIndex = 14;
            // 
            // DeletePanel
            // 
            this.DeletePanel.Controls.Add(this.btnDeleteFinal);
            this.DeletePanel.Controls.Add(this.label11);
            this.DeletePanel.Controls.Add(this.label15);
            this.DeletePanel.Controls.Add(this.tbIDforDelete);
            this.DeletePanel.Location = new System.Drawing.Point(34, 12);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(707, 195);
            this.DeletePanel.TabIndex = 25;
            this.DeletePanel.Visible = false;
            // 
            // btnDeleteFinal
            // 
            this.btnDeleteFinal.Location = new System.Drawing.Point(298, 134);
            this.btnDeleteFinal.Name = "btnDeleteFinal";
            this.btnDeleteFinal.Size = new System.Drawing.Size(82, 28);
            this.btnDeleteFinal.TabIndex = 23;
            this.btnDeleteFinal.Text = "Delete";
            this.btnDeleteFinal.UseVisualStyleBackColor = true;
            this.btnDeleteFinal.Click += new System.EventHandler(this.btnDeleteFinal_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(-3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Enter the ID of Student to be Deleted";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(168, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "ID :";
            // 
            // tbIDforDelete
            // 
            this.tbIDforDelete.Location = new System.Drawing.Point(212, 73);
            this.tbIDforDelete.Name = "tbIDforDelete";
            this.tbIDforDelete.Size = new System.Drawing.Size(301, 20);
            this.tbIDforDelete.TabIndex = 14;
            // 
            // GradeWiseDisplayPannel
            // 
            this.GradeWiseDisplayPannel.Controls.Add(this.btnB);
            this.GradeWiseDisplayPannel.Controls.Add(this.btnD);
            this.GradeWiseDisplayPannel.Controls.Add(this.btnC);
            this.GradeWiseDisplayPannel.Controls.Add(this.btnF);
            this.GradeWiseDisplayPannel.Controls.Add(this.DisplayAll2);
            this.GradeWiseDisplayPannel.Controls.Add(this.btnA);
            this.GradeWiseDisplayPannel.Location = new System.Drawing.Point(31, 2);
            this.GradeWiseDisplayPannel.Name = "GradeWiseDisplayPannel";
            this.GradeWiseDisplayPannel.Size = new System.Drawing.Size(736, 280);
            this.GradeWiseDisplayPannel.TabIndex = 24;
            this.GradeWiseDisplayPannel.Visible = false;
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(408, 110);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(82, 28);
            this.btnB.TabIndex = 23;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(408, 144);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(82, 28);
            this.btnD.TabIndex = 22;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(320, 144);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(82, 28);
            this.btnC.TabIndex = 21;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(230, 144);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(82, 28);
            this.btnF.TabIndex = 20;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnA_Click);
            // 
            // DisplayAll2
            // 
            this.DisplayAll2.Location = new System.Drawing.Point(230, 110);
            this.DisplayAll2.Name = "DisplayAll2";
            this.DisplayAll2.Size = new System.Drawing.Size(82, 28);
            this.DisplayAll2.TabIndex = 19;
            this.DisplayAll2.Text = "Display All";
            this.DisplayAll2.UseVisualStyleBackColor = true;
            this.DisplayAll2.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(320, 110);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(82, 28);
            this.btnA.TabIndex = 18;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GradeWiseDisplayPannel);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.UpdatePanel);
            this.Controls.Add(this.btnIDDelete);
            this.Controls.Add(this.btnDeleteFailingStudents);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDisplayByGrade);
            this.Controls.Add(this.grdStudents);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.UpdatePanel.ResumeLayout(false);
            this.UpdatePanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.GradeWiseDisplayPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.DataGridView grdStudents;
        private System.Windows.Forms.Button btnDisplayByGrade;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteFailingStudents;
        private System.Windows.Forms.Button btnIDDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel UpdatePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAgeUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIDForUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGradeUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNameUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbIDforDelete;
        private System.Windows.Forms.Button btnDeleteFinal;
        private System.Windows.Forms.Panel GradeWiseDisplayPannel;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button DisplayAll2;
        private System.Windows.Forms.Button btnA;
    }
}

