using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_with_DB
{
    partial class ManageStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudents));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearchMsg = new System.Windows.Forms.Label();
            this.grdStudents = new System.Windows.Forms.DataGridView();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGenerateReport);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSort);
            this.panel2.Controls.Add(this.cbSort);
            this.panel2.Controls.Add(this.btnAll);
            this.panel2.Controls.Add(this.cbSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.lbSearchMsg);
            this.panel2.Controls.Add(this.grdStudents);
            this.panel2.Location = new System.Drawing.Point(44, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 576);
            this.panel2.TabIndex = 2;
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
            this.btnGenerateReport.Location = new System.Drawing.Point(467, 384);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(127, 39);
            this.btnGenerateReport.TabIndex = 34;
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
            this.btnImport.Location = new System.Drawing.Point(611, 384);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(127, 39);
            this.btnImport.TabIndex = 33;
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
            this.btnExport.Location = new System.Drawing.Point(611, 329);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 39);
            this.btnExport.TabIndex = 32;
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
            this.btnDelete.Location = new System.Drawing.Point(467, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 39);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSort.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSort.Location = new System.Drawing.Point(254, 384);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(98, 39);
            this.btnSort.TabIndex = 30;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbSort
            // 
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(160, 394);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(79, 21);
            this.cbSort.TabIndex = 29;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAll.Location = new System.Drawing.Point(3, 384);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(98, 39);
            this.btnAll.TabIndex = 28;
            this.btnAll.Text = "All Students";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(107, 90);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 21);
            this.cbSearch.TabIndex = 27;
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
            this.btnSearch.Location = new System.Drawing.Point(300, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 39);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(254, 90);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(194, 26);
            this.tbSearch.TabIndex = 25;
            // 
            // lbSearchMsg
            // 
            this.lbSearchMsg.AutoSize = true;
            this.lbSearchMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchMsg.Location = new System.Drawing.Point(107, 397);
            this.lbSearchMsg.Name = "lbSearchMsg";
            this.lbSearchMsg.Size = new System.Drawing.Size(47, 13);
            this.lbSearchMsg.TabIndex = 24;
            this.lbSearchMsg.Text = "Sort By :";
            // 
            // grdStudents
            // 
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Location = new System.Drawing.Point(2, 440);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.Size = new System.Drawing.Size(746, 126);
            this.grdStudents.TabIndex = 22;
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
            this.btnBack2.Location = new System.Drawing.Point(1, 0);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(50, 40);
            this.btnBack2.TabIndex = 25;
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 651);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "ManageStudents";
            this.Text = "ManageStudents";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdStudents;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearchMsg;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnBack2;

    }
}