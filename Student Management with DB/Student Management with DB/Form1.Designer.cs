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
            this.btnDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GradeWiseDisplayPannel = new System.Windows.Forms.Panel();
            this.lbGradeCount = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.lbGrademsg = new System.Windows.Forms.Label();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnSubmitUpdate = new System.Windows.Forms.Button();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
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
            this.btnSubmit.Location = new System.Drawing.Point(337, 191);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 37);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(226, 190);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(82, 35);
            this.btnDisplayAll.TabIndex = 8;
            this.btnDisplayAll.Text = "Display Students";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // grdStudents
            // 
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Location = new System.Drawing.Point(166, 288);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.Size = new System.Drawing.Size(443, 150);
            this.grdStudents.TabIndex = 9;
            // 
            // btnDisplayByGrade
            // 
            this.btnDisplayByGrade.Location = new System.Drawing.Point(279, 237);
            this.btnDisplayByGrade.Name = "btnDisplayByGrade";
            this.btnDisplayByGrade.Size = new System.Drawing.Size(82, 37);
            this.btnDisplayByGrade.TabIndex = 10;
            this.btnDisplayByGrade.Text = "Grade Summary";
            this.btnDisplayByGrade.UseVisualStyleBackColor = true;
            this.btnDisplayByGrade.Click += new System.EventHandler(this.btnDisplayAStudents_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(631, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 28);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteFailingStudents
            // 
            this.btnDeleteFailingStudents.Location = new System.Drawing.Point(389, 237);
            this.btnDeleteFailingStudents.Name = "btnDeleteFailingStudents";
            this.btnDeleteFailingStudents.Size = new System.Drawing.Size(82, 39);
            this.btnDeleteFailingStudents.TabIndex = 16;
            this.btnDeleteFailingStudents.Text = "Delete Failed ";
            this.btnDeleteFailingStudents.UseVisualStyleBackColor = true;
            this.btnDeleteFailingStudents.Click += new System.EventHandler(this.btnDeleteFailingStudents_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(631, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 28);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // GradeWiseDisplayPannel
            // 
            this.GradeWiseDisplayPannel.Controls.Add(this.lbGradeCount);
            this.GradeWiseDisplayPannel.Controls.Add(this.lbGrade);
            this.GradeWiseDisplayPannel.Controls.Add(this.lbGrademsg);
            this.GradeWiseDisplayPannel.Controls.Add(this.btnB);
            this.GradeWiseDisplayPannel.Controls.Add(this.btnD);
            this.GradeWiseDisplayPannel.Controls.Add(this.btnC);
            this.GradeWiseDisplayPannel.Controls.Add(this.btnF);
            this.GradeWiseDisplayPannel.Controls.Add(this.btnA);
            this.GradeWiseDisplayPannel.Location = new System.Drawing.Point(32, 24);
            this.GradeWiseDisplayPannel.Name = "GradeWiseDisplayPannel";
            this.GradeWiseDisplayPannel.Size = new System.Drawing.Size(729, 161);
            this.GradeWiseDisplayPannel.TabIndex = 24;
            this.GradeWiseDisplayPannel.Visible = false;
            // 
            // lbGradeCount
            // 
            this.lbGradeCount.AutoSize = true;
            this.lbGradeCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGradeCount.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbGradeCount.Location = new System.Drawing.Point(485, 106);
            this.lbGradeCount.Name = "lbGradeCount";
            this.lbGradeCount.Size = new System.Drawing.Size(19, 16);
            this.lbGradeCount.TabIndex = 26;
            this.lbGradeCount.Text = "  ";
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbGrade.Location = new System.Drawing.Point(406, 106);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(19, 16);
            this.lbGrade.TabIndex = 25;
            this.lbGrade.Text = "  ";
            // 
            // lbGrademsg
            // 
            this.lbGrademsg.AutoSize = true;
            this.lbGrademsg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrademsg.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbGrademsg.Location = new System.Drawing.Point(191, 105);
            this.lbGrademsg.Name = "lbGrademsg";
            this.lbGrademsg.Size = new System.Drawing.Size(212, 16);
            this.lbGrademsg.TabIndex = 24;
            this.lbGrademsg.Text = "Number of Students having";
            this.lbGrademsg.Visible = false;
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(321, 170);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(82, 28);
            this.btnB.TabIndex = 23;
            this.btnB.Text = "Grade B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(259, 213);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(82, 28);
            this.btnD.TabIndex = 22;
            this.btnD.Text = "Grade D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(436, 170);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(82, 28);
            this.btnC.TabIndex = 21;
            this.btnC.Text = "Grade C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(369, 213);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(82, 28);
            this.btnF.TabIndex = 20;
            this.btnF.Text = "Grade F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(217, 170);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(82, 28);
            this.btnA.TabIndex = 18;
            this.btnA.Text = "Grade A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnSubmitUpdate
            // 
            this.btnSubmitUpdate.Location = new System.Drawing.Point(631, 367);
            this.btnSubmitUpdate.Name = "btnSubmitUpdate";
            this.btnSubmitUpdate.Size = new System.Drawing.Size(82, 28);
            this.btnSubmitUpdate.TabIndex = 25;
            this.btnSubmitUpdate.Text = "Submit";
            this.btnSubmitUpdate.UseVisualStyleBackColor = true;
            this.btnSubmitUpdate.Visible = false;
            this.btnSubmitUpdate.Click += new System.EventHandler(this.btnSubmitUpdate_Click);
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdate.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbUpdate.Location = new System.Drawing.Point(78, 5);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(169, 16);
            this.lbUpdate.TabIndex = 26;
            this.lbUpdate.Text = "Enter the New Data: ";
            this.lbUpdate.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(454, 191);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 35);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GradeWiseDisplayPannel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdStudents);
            this.Controls.Add(this.btnSubmitUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnDisplayByGrade);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDeleteFailingStudents);
            this.Controls.Add(this.btnSearch);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.GradeWiseDisplayPannel.ResumeLayout(false);
            this.GradeWiseDisplayPannel.PerformLayout();
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
        private System.Windows.Forms.Button btnDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel GradeWiseDisplayPannel;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnSubmitUpdate;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbGradeCount;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Label lbGrademsg;
        private System.Windows.Forms.Button btnSearch;
    }
}

