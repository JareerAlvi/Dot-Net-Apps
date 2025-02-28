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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.lbFNameMsg = new System.Windows.Forms.Label();
            this.lbLNameMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAgeMsg = new System.Windows.Forms.Label();
            this.lbGradeMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lbEmailMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbDOBMsg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grdStudents = new System.Windows.Forms.DataGridView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnSubmitUpdate = new System.Windows.Forms.Button();
            this.cbGrades = new System.Windows.Forms.ComboBox();
            this.lbStudentFormTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSortOrder = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lbSearchMsg = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddPannel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.newStudentPanel = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.fdExportCSV = new System.Windows.Forms.SaveFileDialog();
            this.fdImportCSV = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.newStudentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // lbFNameMsg
            // 
            this.lbFNameMsg.AutoSize = true;
            this.lbFNameMsg.ForeColor = System.Drawing.Color.Red;
            this.lbFNameMsg.Location = new System.Drawing.Point(212, 183);
            this.lbFNameMsg.Name = "lbFNameMsg";
            this.lbFNameMsg.Size = new System.Drawing.Size(0, 13);
            this.lbFNameMsg.TabIndex = 4;
            // 
            // lbLNameMsg
            // 
            this.lbLNameMsg.AutoSize = true;
            this.lbLNameMsg.ForeColor = System.Drawing.Color.Red;
            this.lbLNameMsg.Location = new System.Drawing.Point(565, 181);
            this.lbLNameMsg.Name = "lbLNameMsg";
            this.lbLNameMsg.Size = new System.Drawing.Size(0, 13);
            this.lbLNameMsg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(215, 159);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(194, 26);
            this.tbFirstName.TabIndex = 7;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbLastName.Location = new System.Drawing.Point(568, 157);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(194, 26);
            this.tbLastName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Age";
            // 
            // lbAgeMsg
            // 
            this.lbAgeMsg.AutoSize = true;
            this.lbAgeMsg.ForeColor = System.Drawing.Color.Red;
            this.lbAgeMsg.Location = new System.Drawing.Point(217, 259);
            this.lbAgeMsg.Name = "lbAgeMsg";
            this.lbAgeMsg.Size = new System.Drawing.Size(0, 13);
            this.lbAgeMsg.TabIndex = 10;
            // 
            // lbGradeMsg
            // 
            this.lbGradeMsg.AutoSize = true;
            this.lbGradeMsg.ForeColor = System.Drawing.Color.Red;
            this.lbGradeMsg.Location = new System.Drawing.Point(534, 223);
            this.lbGradeMsg.Name = "lbGradeMsg";
            this.lbGradeMsg.Size = new System.Drawing.Size(0, 13);
            this.lbGradeMsg.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grade";
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAge.Location = new System.Drawing.Point(217, 235);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(194, 26);
            this.tbAge.TabIndex = 13;
            // 
            // lbEmailMsg
            // 
            this.lbEmailMsg.AutoSize = true;
            this.lbEmailMsg.ForeColor = System.Drawing.Color.Red;
            this.lbEmailMsg.Location = new System.Drawing.Point(568, 266);
            this.lbEmailMsg.Name = "lbEmailMsg";
            this.lbEmailMsg.Size = new System.Drawing.Size(0, 13);
            this.lbEmailMsg.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEmail.Location = new System.Drawing.Point(565, 241);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(194, 26);
            this.tbEmail.TabIndex = 17;
            // 
            // lbDOBMsg
            // 
            this.lbDOBMsg.AutoSize = true;
            this.lbDOBMsg.ForeColor = System.Drawing.Color.Red;
            this.lbDOBMsg.Location = new System.Drawing.Point(233, 350);
            this.lbDOBMsg.Name = "lbDOBMsg";
            this.lbDOBMsg.Size = new System.Drawing.Size(0, 13);
            this.lbDOBMsg.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date Of Birth";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(237, 324);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker.TabIndex = 21;
            // 
            // grdStudents
            // 
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdStudents.Location = new System.Drawing.Point(91, 131);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdStudents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdStudents.Size = new System.Drawing.Size(755, 424);
            this.grdStudents.TabIndex = 22;
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
            this.btnAddStudent.Location = new System.Drawing.Point(373, 421);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(144, 54);
            this.btnAddStudent.TabIndex = 23;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
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
            this.btnUpdateStudent.Location = new System.Drawing.Point(292, 83);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(98, 39);
            this.btnUpdateStudent.TabIndex = 24;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
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
            this.btnSubmitUpdate.Location = new System.Drawing.Point(373, 421);
            this.btnSubmitUpdate.Name = "btnSubmitUpdate";
            this.btnSubmitUpdate.Size = new System.Drawing.Size(149, 54);
            this.btnSubmitUpdate.TabIndex = 25;
            this.btnSubmitUpdate.Text = "Update";
            this.btnSubmitUpdate.UseVisualStyleBackColor = false;
            this.btnSubmitUpdate.Visible = false;
            this.btnSubmitUpdate.Click += new System.EventHandler(this.btnSubmitUpdate_Click);
            // 
            // cbGrades
            // 
            this.cbGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbGrades.FormattingEnabled = true;
            this.cbGrades.Location = new System.Drawing.Point(582, 319);
            this.cbGrades.Name = "cbGrades";
            this.cbGrades.Size = new System.Drawing.Size(121, 28);
            this.cbGrades.TabIndex = 27;
            // 
            // lbStudentFormTitle
            // 
            this.lbStudentFormTitle.AutoSize = true;
            this.lbStudentFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentFormTitle.Location = new System.Drawing.Point(345, 17);
            this.lbStudentFormTitle.Name = "lbStudentFormTitle";
            this.lbStudentFormTitle.Size = new System.Drawing.Size(255, 42);
            this.lbStudentFormTitle.TabIndex = 28;
            this.lbStudentFormTitle.Text = "Student Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbSortOrder);
            this.panel1.Controls.Add(this.cbSort);
            this.panel1.Controls.Add(this.lbSearchMsg);
            this.panel1.Controls.Add(this.btnGenerateReport);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAddPannel);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnUpdateStudent);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.lbStudentFormTitle);
            this.panel1.Controls.Add(this.grdStudents);
            this.panel1.Location = new System.Drawing.Point(29, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 622);
            this.panel1.TabIndex = 1;
            // 
            // cbSortOrder
            // 
            this.cbSortOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortOrder.FormattingEnabled = true;
            this.cbSortOrder.Location = new System.Drawing.Point(235, 38);
            this.cbSortOrder.Name = "cbSortOrder";
            this.cbSortOrder.Size = new System.Drawing.Size(73, 21);
            this.cbSortOrder.TabIndex = 40;
            // 
            // cbSort
            // 
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(149, 38);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(79, 21);
            this.cbSort.TabIndex = 39;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // lbSearchMsg
            // 
            this.lbSearchMsg.AutoSize = true;
            this.lbSearchMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchMsg.Location = new System.Drawing.Point(96, 41);
            this.lbSearchMsg.Name = "lbSearchMsg";
            this.lbSearchMsg.Size = new System.Drawing.Size(47, 13);
            this.lbSearchMsg.TabIndex = 38;
            this.lbSearchMsg.Text = "Sort By :";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGenerateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerateReport.Location = new System.Drawing.Point(809, 572);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(127, 39);
            this.btnGenerateReport.TabIndex = 37;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImport.Location = new System.Drawing.Point(16, 572);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(127, 39);
            this.btnImport.TabIndex = 36;
            this.btnImport.Text = "Import From CSV";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExport.Location = new System.Drawing.Point(166, 572);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 39);
            this.btnExport.TabIndex = 35;
            this.btnExport.Text = "Export To CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(89, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 39);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAddPannel
            // 
            this.btnAddPannel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddPannel.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddPannel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddPannel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddPannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPannel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPannel.Location = new System.Drawing.Point(188, 83);
            this.btnAddPannel.Name = "btnAddPannel";
            this.btnAddPannel.Size = new System.Drawing.Size(98, 39);
            this.btnAddPannel.TabIndex = 31;
            this.btnAddPannel.Text = "Add";
            this.btnAddPannel.UseVisualStyleBackColor = false;
            this.btnAddPannel.Click += new System.EventHandler(this.btnAddPannel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(838, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 28);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(497, 83);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(336, 26);
            this.tbSearch.TabIndex = 29;
            // 
            // newStudentPanel
            // 
            this.newStudentPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.newStudentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newStudentPanel.Controls.Add(this.lbDOBMsg);
            this.newStudentPanel.Controls.Add(this.btnSubmitUpdate);
            this.newStudentPanel.Controls.Add(this.label5);
            this.newStudentPanel.Controls.Add(this.dateTimePicker);
            this.newStudentPanel.Controls.Add(this.lbTitle);
            this.newStudentPanel.Controls.Add(this.label1);
            this.newStudentPanel.Controls.Add(this.cbGrades);
            this.newStudentPanel.Controls.Add(this.btnAddStudent);
            this.newStudentPanel.Controls.Add(this.lbEmailMsg);
            this.newStudentPanel.Controls.Add(this.tbAge);
            this.newStudentPanel.Controls.Add(this.label4);
            this.newStudentPanel.Controls.Add(this.label3);
            this.newStudentPanel.Controls.Add(this.tbEmail);
            this.newStudentPanel.Controls.Add(this.lbFNameMsg);
            this.newStudentPanel.Controls.Add(this.lbGradeMsg);
            this.newStudentPanel.Controls.Add(this.lbLNameMsg);
            this.newStudentPanel.Controls.Add(this.label2);
            this.newStudentPanel.Controls.Add(this.lbAgeMsg);
            this.newStudentPanel.Controls.Add(this.tbFirstName);
            this.newStudentPanel.Controls.Add(this.tbLastName);
            this.newStudentPanel.Controls.Add(this.label6);
            this.newStudentPanel.Controls.Add(this.btnBack2);
            this.newStudentPanel.Location = new System.Drawing.Point(28, 34);
            this.newStudentPanel.Name = "newStudentPanel";
            this.newStudentPanel.Size = new System.Drawing.Size(941, 622);
            this.newStudentPanel.TabIndex = 32;
            this.newStudentPanel.Visible = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(291, 37);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(243, 42);
            this.lbTitle.TabIndex = 28;
            this.lbTitle.Text = "New Student";
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack2.BackgroundImage")));
            this.btnBack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack2.Location = new System.Drawing.Point(-1, -1);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(50, 40);
            this.btnBack2.TabIndex = 29;
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click_1);
            // 
            // fdExportCSV
            // 
            this.fdExportCSV.FileName = "studensts.csv";
            this.fdExportCSV.Filter = "CSV files (*.csv)|*.csv";
            this.fdExportCSV.Title = "Select a CSV File";
            // 
            // fdImportCSV
            // 
            this.fdImportCSV.Filter = "CSV files (*.csv)|*.csv";
            this.fdImportCSV.Title = "Select a CSV File";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 684);
            this.Controls.Add(this.newStudentPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.newStudentPanel.ResumeLayout(false);
            this.newStudentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Label lbFNameMsg;
        private Label lbLNameMsg;
        private Label label2;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Label label6;
        private Label lbAgeMsg;
        private Label lbGradeMsg;
        private Label label3;
        private TextBox tbAge;
        private Label lbEmailMsg;
        private Label label4;
        private TextBox tbEmail;
        private Label lbDOBMsg;
        private Label label5;
        private DateTimePicker dateTimePicker;
        private DataGridView grdStudents;
        private Button btnAddStudent;
        private Button btnUpdateStudent;
        private Button btnSubmitUpdate;
        private ComboBox cbGrades;
        private Label lbStudentFormTitle;
        private Panel panel1;
        private Button btnSearch;
        private TextBox tbSearch;
        private Button btnAddPannel;
        private Panel newStudentPanel;
        private Label lbTitle;
        private Button btnBack2;
        private Button btnDelete;
        private Button btnGenerateReport;
        private Button btnImport;
        private Button btnExport;
        private SaveFileDialog fdExportCSV;
        private OpenFileDialog fdImportCSV;
        private ComboBox cbSort;
        private Label lbSearchMsg;
        private ComboBox cbSortOrder;
    }
}