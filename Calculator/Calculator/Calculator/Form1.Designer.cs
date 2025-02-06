using System.Drawing;

namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputDisplayBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ModBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ClearBtn2 = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SquareBtn = new System.Windows.Forms.Button();
            this.SqRootBtn = new System.Windows.Forms.Button();
            this.DivsionBtn = new System.Windows.Forms.Button();
            this.ReciprocalBtn = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.MultiplicationBtn = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.EqualsToBtn = new System.Windows.Forms.Button();
            this.DecimalBtn = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.NegateBtn = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // InputDisplayBox
            // 
            this.InputDisplayBox.BackColor = System.Drawing.SystemColors.Control;
            this.InputDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDisplayBox.Location = new System.Drawing.Point(27, 78);
            this.InputDisplayBox.Name = "InputDisplayBox";
            this.InputDisplayBox.ReadOnly = true;
            this.InputDisplayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputDisplayBox.Size = new System.Drawing.Size(289, 38);
            this.InputDisplayBox.TabIndex = 1;
            this.InputDisplayBox.TabStop = false;
            this.InputDisplayBox.Text = "0";
            this.InputDisplayBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Standard Calculator";
            // 
            // ModBtn
            // 
            this.ModBtn.AccessibleName = "ModBtn";
            this.ModBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ModBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ModBtn.FlatAppearance.BorderSize = 2;
            this.ModBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModBtn.Location = new System.Drawing.Point(5, 144);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.ModBtn.Size = new System.Drawing.Size(73, 50);
            this.ModBtn.TabIndex = 3;
            this.ModBtn.Text = "%\r\n\r\n";
            this.ModBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ModBtn.UseVisualStyleBackColor = false;
            this.ModBtn.Click += new System.EventHandler(this.ModBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.AccessibleName = "";
            this.RemoveBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Image = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.Image")));
            this.RemoveBtn.Location = new System.Drawing.Point(243, 144);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Padding = new System.Windows.Forms.Padding(0, 6, 0, 4);
            this.RemoveBtn.Size = new System.Drawing.Size(73, 50);
            this.RemoveBtn.TabIndex = 50;
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ClearBtn2
            // 
            this.ClearBtn2.AccessibleName = "";
            this.ClearBtn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn2.Location = new System.Drawing.Point(163, 144);
            this.ClearBtn2.Name = "ClearBtn2";
            this.ClearBtn2.Size = new System.Drawing.Size(73, 50);
            this.ClearBtn2.TabIndex = 51;
            this.ClearBtn2.Text = "C";
            this.ClearBtn2.UseVisualStyleBackColor = false;
            this.ClearBtn2.Click += new System.EventHandler(this.ClearBtn2_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.AccessibleName = "";
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(83, 144);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.ClearBtn.Size = new System.Drawing.Size(73, 50);
            this.ClearBtn.TabIndex = 52;
            this.ClearBtn.Text = "CE\r\n\r\n";
            this.ClearBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.AccessibleName = "";
            this.SquareBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SquareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SquareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareBtn.Location = new System.Drawing.Point(83, 200);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(73, 50);
            this.SquareBtn.TabIndex = 56;
            this.SquareBtn.Text = "x²";
            this.SquareBtn.UseVisualStyleBackColor = false;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // SqRootBtn
            // 
            this.SqRootBtn.AccessibleName = "";
            this.SqRootBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SqRootBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SqRootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqRootBtn.Location = new System.Drawing.Point(163, 200);
            this.SqRootBtn.Name = "SqRootBtn";
            this.SqRootBtn.Size = new System.Drawing.Size(73, 50);
            this.SqRootBtn.TabIndex = 55;
            this.SqRootBtn.Text = "√x\r\n";
            this.SqRootBtn.UseVisualStyleBackColor = false;
            this.SqRootBtn.Click += new System.EventHandler(this.SqRootBtn_Click);
            // 
            // DivsionBtn
            // 
            this.DivsionBtn.AccessibleName = "ModBtn";
            this.DivsionBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DivsionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DivsionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivsionBtn.Location = new System.Drawing.Point(243, 200);
            this.DivsionBtn.Name = "DivsionBtn";
            this.DivsionBtn.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.DivsionBtn.Size = new System.Drawing.Size(73, 50);
            this.DivsionBtn.TabIndex = 54;
            this.DivsionBtn.Text = " ÷ ";
            this.DivsionBtn.UseVisualStyleBackColor = false;
            this.DivsionBtn.Click += new System.EventHandler(this.DivsionBtn_Click);
            // 
            // ReciprocalBtn
            // 
            this.ReciprocalBtn.AccessibleName = "";
            this.ReciprocalBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReciprocalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReciprocalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReciprocalBtn.Location = new System.Drawing.Point(5, 200);
            this.ReciprocalBtn.Name = "ReciprocalBtn";
            this.ReciprocalBtn.Size = new System.Drawing.Size(73, 50);
            this.ReciprocalBtn.TabIndex = 53;
            this.ReciprocalBtn.Text = "1/x\r\n";
            this.ReciprocalBtn.UseVisualStyleBackColor = false;
            this.ReciprocalBtn.Click += new System.EventHandler(this.ReciprocalBtn_Click);
            // 
            // Btn8
            // 
            this.Btn8.AccessibleName = "ModBtn";
            this.Btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(84, 256);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(73, 50);
            this.Btn8.TabIndex = 60;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.AccessibleName = "ModBtn";
            this.Btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(6, 256);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(73, 50);
            this.Btn7.TabIndex = 57;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn9
            // 
            this.Btn9.AccessibleName = "ModBtn";
            this.Btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(163, 256);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(73, 50);
            this.Btn9.TabIndex = 73;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // MultiplicationBtn
            // 
            this.MultiplicationBtn.AccessibleName = "ModBtn";
            this.MultiplicationBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MultiplicationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MultiplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicationBtn.Location = new System.Drawing.Point(242, 257);
            this.MultiplicationBtn.Name = "MultiplicationBtn";
            this.MultiplicationBtn.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.MultiplicationBtn.Size = new System.Drawing.Size(73, 50);
            this.MultiplicationBtn.TabIndex = 74;
            this.MultiplicationBtn.Text = " x";
            this.MultiplicationBtn.UseVisualStyleBackColor = false;
            this.MultiplicationBtn.Click += new System.EventHandler(this.MultiplicationBtn_Click);
            // 
            // Btn4
            // 
            this.Btn4.AccessibleName = "ModBtn";
            this.Btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(6, 312);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(73, 50);
            this.Btn4.TabIndex = 75;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.AccessibleName = "ModBtn";
            this.Btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(85, 312);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(73, 50);
            this.Btn5.TabIndex = 76;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.AccessibleName = "ModBtn";
            this.Btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(163, 312);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(73, 50);
            this.Btn6.TabIndex = 77;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.AccessibleName = "ModBtn";
            this.MinusBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusBtn.Location = new System.Drawing.Point(242, 312);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.MinusBtn.Size = new System.Drawing.Size(73, 50);
            this.MinusBtn.TabIndex = 78;
            this.MinusBtn.Text = " -";
            this.MinusBtn.UseVisualStyleBackColor = false;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AccessibleName = "ModBtn";
            this.AddBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(242, 368);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.AddBtn.Size = new System.Drawing.Size(73, 50);
            this.AddBtn.TabIndex = 82;
            this.AddBtn.Text = " +";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Btn3
            // 
            this.Btn3.AccessibleName = "ModBtn";
            this.Btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(163, 368);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(73, 50);
            this.Btn3.TabIndex = 81;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.AccessibleName = "ModBtn";
            this.Btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(85, 368);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(73, 50);
            this.Btn2.TabIndex = 80;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.AccessibleName = "ModBtn";
            this.Btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(6, 368);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(73, 50);
            this.Btn1.TabIndex = 79;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // EqualsToBtn
            // 
            this.EqualsToBtn.AccessibleName = "ModBtn";
            this.EqualsToBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EqualsToBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EqualsToBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsToBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.EqualsToBtn.Location = new System.Drawing.Point(242, 424);
            this.EqualsToBtn.Name = "EqualsToBtn";
            this.EqualsToBtn.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.EqualsToBtn.Size = new System.Drawing.Size(73, 50);
            this.EqualsToBtn.TabIndex = 86;
            this.EqualsToBtn.Text = " =";
            this.EqualsToBtn.UseVisualStyleBackColor = false;
            this.EqualsToBtn.Click += new System.EventHandler(this.EqualsToBtn_Click);
            // 
            // DecimalBtn
            // 
            this.DecimalBtn.AccessibleName = "ModBtn";
            this.DecimalBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DecimalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalBtn.Location = new System.Drawing.Point(163, 424);
            this.DecimalBtn.Name = "DecimalBtn";
            this.DecimalBtn.Size = new System.Drawing.Size(73, 50);
            this.DecimalBtn.TabIndex = 85;
            this.DecimalBtn.Text = ".";
            this.DecimalBtn.UseVisualStyleBackColor = false;
            this.DecimalBtn.Click += new System.EventHandler(this.DecimalBtn_Click);
            // 
            // Btn0
            // 
            this.Btn0.AccessibleName = "ModBtn";
            this.Btn0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(85, 424);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(73, 50);
            this.Btn0.TabIndex = 84;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // NegateBtn
            // 
            this.NegateBtn.AccessibleName = "ModBtn";
            this.NegateBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NegateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NegateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegateBtn.Location = new System.Drawing.Point(6, 424);
            this.NegateBtn.Name = "NegateBtn";
            this.NegateBtn.Size = new System.Drawing.Size(73, 50);
            this.NegateBtn.TabIndex = 83;
            this.NegateBtn.Text = "+/-";
            this.NegateBtn.UseVisualStyleBackColor = false;
            this.NegateBtn.Click += new System.EventHandler(this.NegateBtn_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.resultTextBox.Location = new System.Drawing.Point(12, 23);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultTextBox.Size = new System.Drawing.Size(304, 49);
            this.resultTextBox.TabIndex = 88;
            this.resultTextBox.TabStop = false;
            this.resultTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(318, 478);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.EqualsToBtn);
            this.Controls.Add(this.DecimalBtn);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.NegateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.MultiplicationBtn);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.SquareBtn);
            this.Controls.Add(this.SqRootBtn);
            this.Controls.Add(this.DivsionBtn);
            this.Controls.Add(this.ReciprocalBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ClearBtn2);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.ModBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputDisplayBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox InputDisplayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ModBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button ClearBtn2;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SquareBtn;
        private System.Windows.Forms.Button SqRootBtn;
        private System.Windows.Forms.Button DivsionBtn;
        private System.Windows.Forms.Button ReciprocalBtn;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button MultiplicationBtn;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button EqualsToBtn;
        private System.Windows.Forms.Button DecimalBtn;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button NegateBtn;
        private System.Windows.Forms.RichTextBox resultTextBox;
    }
}

