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
            this.btnDisplayAStudents = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateGrade = new System.Windows.Forms.Button();
            this.btnUpdateAge = new System.Windows.Forms.Button();
            this.AgeUpdatebtn = new System.Windows.Forms.Button();
            this.GradeUpdatebtn = new System.Windows.Forms.Button();
            this.btnDeleteFailingStudents = new System.Windows.Forms.Button();
            this.btnIDDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDelFinal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
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
            this.grdStudents.Location = new System.Drawing.Point(182, 288);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.Size = new System.Drawing.Size(443, 150);
            this.grdStudents.TabIndex = 9;
            // 
            // btnDisplayAStudents
            // 
            this.btnDisplayAStudents.Location = new System.Drawing.Point(249, 247);
            this.btnDisplayAStudents.Name = "btnDisplayAStudents";
            this.btnDisplayAStudents.Size = new System.Drawing.Size(82, 28);
            this.btnDisplayAStudents.TabIndex = 10;
            this.btnDisplayAStudents.Text = "A Grade";
            this.btnDisplayAStudents.UseVisualStyleBackColor = true;
            this.btnDisplayAStudents.Click += new System.EventHandler(this.btnDisplayAStudents_Click);
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
            // btnUpdateGrade
            // 
            this.btnUpdateGrade.Location = new System.Drawing.Point(408, 213);
            this.btnUpdateGrade.Name = "btnUpdateGrade";
            this.btnUpdateGrade.Size = new System.Drawing.Size(82, 28);
            this.btnUpdateGrade.TabIndex = 12;
            this.btnUpdateGrade.Text = "Update Grade";
            this.btnUpdateGrade.UseVisualStyleBackColor = true;
            this.btnUpdateGrade.Visible = false;
            this.btnUpdateGrade.Click += new System.EventHandler(this.btnUpdateGrade_Click);
            // 
            // btnUpdateAge
            // 
            this.btnUpdateAge.Location = new System.Drawing.Point(293, 213);
            this.btnUpdateAge.Name = "btnUpdateAge";
            this.btnUpdateAge.Size = new System.Drawing.Size(82, 28);
            this.btnUpdateAge.TabIndex = 13;
            this.btnUpdateAge.Text = "Update Age";
            this.btnUpdateAge.UseVisualStyleBackColor = true;
            this.btnUpdateAge.Visible = false;
            this.btnUpdateAge.Click += new System.EventHandler(this.btnUpdateAge_Click);
            // 
            // AgeUpdatebtn
            // 
            this.AgeUpdatebtn.Location = new System.Drawing.Point(351, 156);
            this.AgeUpdatebtn.Name = "AgeUpdatebtn";
            this.AgeUpdatebtn.Size = new System.Drawing.Size(82, 28);
            this.AgeUpdatebtn.TabIndex = 14;
            this.AgeUpdatebtn.Text = "Update";
            this.AgeUpdatebtn.UseVisualStyleBackColor = true;
            this.AgeUpdatebtn.Visible = false;
            this.AgeUpdatebtn.Click += new System.EventHandler(this.AgeUpdatebtn_Click);
            // 
            // GradeUpdatebtn
            // 
            this.GradeUpdatebtn.Location = new System.Drawing.Point(351, 156);
            this.GradeUpdatebtn.Name = "GradeUpdatebtn";
            this.GradeUpdatebtn.Size = new System.Drawing.Size(82, 28);
            this.GradeUpdatebtn.TabIndex = 15;
            this.GradeUpdatebtn.Text = "Update";
            this.GradeUpdatebtn.UseVisualStyleBackColor = true;
            this.GradeUpdatebtn.Visible = false;
            this.GradeUpdatebtn.Click += new System.EventHandler(this.GradeUpdatebtn_Click);
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
            // btnDelFinal
            // 
            this.btnDelFinal.Location = new System.Drawing.Point(351, 156);
            this.btnDelFinal.Name = "btnDelFinal";
            this.btnDelFinal.Size = new System.Drawing.Size(82, 28);
            this.btnDelFinal.TabIndex = 18;
            this.btnDelFinal.Text = "Delete";
            this.btnDelFinal.UseVisualStyleBackColor = true;
            this.btnDelFinal.Visible = false;
            this.btnDelFinal.Click += new System.EventHandler(this.btnDelFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelFinal);
            this.Controls.Add(this.btnIDDelete);
            this.Controls.Add(this.btnDeleteFailingStudents);
            this.Controls.Add(this.GradeUpdatebtn);
            this.Controls.Add(this.AgeUpdatebtn);
            this.Controls.Add(this.btnUpdateAge);
            this.Controls.Add(this.btnUpdateGrade);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDisplayAStudents);
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
        private System.Windows.Forms.Button btnDisplayAStudents;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateGrade;
        private System.Windows.Forms.Button btnUpdateAge;
        private System.Windows.Forms.Button AgeUpdatebtn;
        private System.Windows.Forms.Button GradeUpdatebtn;
        private System.Windows.Forms.Button btnDeleteFailingStudents;
        private System.Windows.Forms.Button btnIDDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDelFinal;
    }
}

