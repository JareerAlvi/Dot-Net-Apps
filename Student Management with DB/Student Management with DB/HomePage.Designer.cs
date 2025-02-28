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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.newStudentPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // lbFNameMsg
            // 
            this.lbFNameMsg.AutoSize = true;
            this.lbFNameMsg.ForeColor = System.Drawing.Color.Red;
            this.lbFNameMsg.Location = new System.Drawing.Point(283, 225);
            this.lbFNameMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFNameMsg.Name = "lbFNameMsg";
            this.lbFNameMsg.Size = new System.Drawing.Size(0, 16);
            this.lbFNameMsg.TabIndex = 4;
            // 
            // lbLNameMsg
            // 
            this.lbLNameMsg.AutoSize = true;
            this.lbLNameMsg.ForeColor = System.Drawing.Color.Red;
            this.lbLNameMsg.Location = new System.Drawing.Point(753, 223);
            this.lbLNameMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLNameMsg.Name = "lbLNameMsg";
            this.lbLNameMsg.Size = new System.Drawing.Size(0, 16);
            this.lbLNameMsg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(287, 196);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(257, 30);
            this.tbFirstName.TabIndex = 7;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbLastName.Location = new System.Drawing.Point(757, 193);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(257, 30);
            this.tbLastName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Age";
            // 
            // lbAgeMsg
            // 
            this.lbAgeMsg.AutoSize = true;
            this.lbAgeMsg.ForeColor = System.Drawing.Color.Red;
            this.lbAgeMsg.Location = new System.Drawing.Point(289, 319);
            this.lbAgeMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAgeMsg.Name = "lbAgeMsg";
            this.lbAgeMsg.Size = new System.Drawing.Size(0, 16);
            this.lbAgeMsg.TabIndex = 10;
            // 
            // lbGradeMsg
            // 
            this.lbGradeMsg.AutoSize = true;
            this.lbGradeMsg.ForeColor = System.Drawing.Color.Red;
            this.lbGradeMsg.Location = new System.Drawing.Point(712, 274);
            this.lbGradeMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGradeMsg.Name = "lbGradeMsg";
            this.lbGradeMsg.Size = new System.Drawing.Size(0, 16);
            this.lbGradeMsg.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grade";
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAge.Location = new System.Drawing.Point(289, 289);
            this.tbAge.Margin = new System.Windows.Forms.Padding(4);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(257, 30);
            this.tbAge.TabIndex = 13;
            // 
            // lbEmailMsg
            // 
            this.lbEmailMsg.AutoSize = true;
            this.lbEmailMsg.ForeColor = System.Drawing.Color.Red;
            this.lbEmailMsg.Location = new System.Drawing.Point(757, 327);
            this.lbEmailMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmailMsg.Name = "lbEmailMsg";
            this.lbEmailMsg.Size = new System.Drawing.Size(0, 16);
            this.lbEmailMsg.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEmail.Location = new System.Drawing.Point(753, 297);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(257, 30);
            this.tbEmail.TabIndex = 17;
            // 
            // lbDOBMsg
            // 
            this.lbDOBMsg.AutoSize = true;
            this.lbDOBMsg.ForeColor = System.Drawing.Color.Red;
            this.lbDOBMsg.Location = new System.Drawing.Point(311, 431);
            this.lbDOBMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDOBMsg.Name = "lbDOBMsg";
            this.lbDOBMsg.Size = new System.Drawing.Size(0, 16);
            this.lbDOBMsg.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 399);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date Of Birth";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(316, 399);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(319, 26);
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
            this.grdStudents.Location = new System.Drawing.Point(121, 161);
            this.grdStudents.Margin = new System.Windows.Forms.Padding(4);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdStudents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdStudents.Size = new System.Drawing.Size(1007, 522);
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
            this.btnAddStudent.Location = new System.Drawing.Point(497, 518);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(192, 66);
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
            this.btnUpdateStudent.Location = new System.Drawing.Point(389, 102);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(131, 48);
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
            this.btnSubmitUpdate.Location = new System.Drawing.Point(497, 518);
            this.btnSubmitUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitUpdate.Name = "btnSubmitUpdate";
            this.btnSubmitUpdate.Size = new System.Drawing.Size(199, 66);
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
            this.cbGrades.Location = new System.Drawing.Point(776, 393);
            this.cbGrades.Margin = new System.Windows.Forms.Padding(4);
            this.cbGrades.Name = "cbGrades";
            this.cbGrades.Size = new System.Drawing.Size(238, 33);
            this.cbGrades.TabIndex = 27;
            // 
            // lbStudentFormTitle
            // 
            this.lbStudentFormTitle.AutoSize = true;
            this.lbStudentFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentFormTitle.Location = new System.Drawing.Point(460, 21);
            this.lbStudentFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStudentFormTitle.Name = "lbStudentFormTitle";
            this.lbStudentFormTitle.Size = new System.Drawing.Size(318, 54);
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
            this.panel1.Location = new System.Drawing.Point(39, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 765);
            this.panel1.TabIndex = 1;
            // 
            // cbSortOrder
            // 
            this.cbSortOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortOrder.FormattingEnabled = true;
            this.cbSortOrder.Location = new System.Drawing.Point(313, 47);
            this.cbSortOrder.Margin = new System.Windows.Forms.Padding(4);
            this.cbSortOrder.Name = "cbSortOrder";
            this.cbSortOrder.Size = new System.Drawing.Size(96, 25);
            this.cbSortOrder.TabIndex = 40;
            // 
            // cbSort
            // 
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(199, 47);
            this.cbSort.Margin = new System.Windows.Forms.Padding(4);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(104, 25);
            this.cbSort.TabIndex = 39;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // lbSearchMsg
            // 
            this.lbSearchMsg.AutoSize = true;
            this.lbSearchMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchMsg.Location = new System.Drawing.Point(128, 50);
            this.lbSearchMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchMsg.Name = "lbSearchMsg";
            this.lbSearchMsg.Size = new System.Drawing.Size(62, 17);
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
            this.btnGenerateReport.Location = new System.Drawing.Point(1079, 704);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(169, 48);
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
            this.btnImport.Location = new System.Drawing.Point(21, 704);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(169, 48);
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
            this.btnExport.Location = new System.Drawing.Point(221, 704);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(169, 48);
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
            this.btnDelete.Location = new System.Drawing.Point(119, 102);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 48);
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
            this.btnAddPannel.Location = new System.Drawing.Point(251, 102);
            this.btnAddPannel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPannel.Name = "btnAddPannel";
            this.btnAddPannel.Size = new System.Drawing.Size(131, 48);
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
            this.btnSearch.Location = new System.Drawing.Point(1117, 102);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 34);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(663, 102);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(447, 30);
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
            this.newStudentPanel.Location = new System.Drawing.Point(37, 42);
            this.newStudentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.newStudentPanel.Name = "newStudentPanel";
            this.newStudentPanel.Size = new System.Drawing.Size(1254, 765);
            this.newStudentPanel.TabIndex = 32;
            this.newStudentPanel.Visible = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(388, 46);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(301, 54);
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
            this.btnBack2.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(67, 49);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 842);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newStudentPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.newStudentPanel.ResumeLayout(false);
            this.newStudentPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem studentsToolStripMenuItem;
    }
}