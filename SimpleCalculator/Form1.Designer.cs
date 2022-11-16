namespace SimpleCalculator
{
    partial class CyberCulator3000
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CyberCulator3000));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOperand = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMemPlus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelChar = new System.Windows.Forms.Button();
            this.cmbMemoryList = new System.Windows.Forms.ComboBox();
            this.txtOperationDisp = new System.Windows.Forms.TextBox();
            this.txtResultMem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(127, 388);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOperand
            // 
            this.txtOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand.Location = new System.Drawing.Point(44, 152);
            this.txtOperand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOperand.Name = "txtOperand";
            this.txtOperand.Size = new System.Drawing.Size(276, 26);
            this.txtOperand.TabIndex = 1;
            this.txtOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOperand.TextChanged += new System.EventHandler(this.txtOperand_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(44, 220);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(314, 31);
            this.txtResult.TabIndex = 7;
            this.txtResult.TabStop = false;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(93, 472);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(93, 31);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(204, 522);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 31);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(93, 380);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubstract.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstract.ForeColor = System.Drawing.Color.Black;
            this.btnSubstract.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubstract.Location = new System.Drawing.Point(204, 380);
            this.btnSubstract.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(93, 31);
            this.btnSubstract.TabIndex = 7;
            this.btnSubstract.Text = "-";
            this.btnSubstract.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubstract.UseVisualStyleBackColor = false;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.Control;
            this.btnMultiply.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Black;
            this.btnMultiply.Location = new System.Drawing.Point(93, 425);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(93, 31);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.Control;
            this.btnDivide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDivide.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Black;
            this.btnDivide.Location = new System.Drawing.Point(204, 425);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(93, 31);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Terminator Two", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 610);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "CyberCulator 3000";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(204, 472);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 31);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMemPlus
            // 
            this.btnMemPlus.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemPlus.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemPlus.ForeColor = System.Drawing.Color.Black;
            this.btnMemPlus.Location = new System.Drawing.Point(93, 269);
            this.btnMemPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMemPlus.Name = "btnMemPlus";
            this.btnMemPlus.Size = new System.Drawing.Size(93, 31);
            this.btnMemPlus.TabIndex = 2;
            this.btnMemPlus.Text = "MS";
            this.btnMemPlus.UseVisualStyleBackColor = false;
            this.btnMemPlus.Click += new System.EventHandler(this.btnMemPlus_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(93, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelChar
            // 
            this.btnDelChar.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelChar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelChar.BackgroundImage")));
            this.btnDelChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelChar.ForeColor = System.Drawing.Color.Black;
            this.btnDelChar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelChar.Location = new System.Drawing.Point(204, 306);
            this.btnDelChar.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelChar.Name = "btnDelChar";
            this.btnDelChar.Size = new System.Drawing.Size(93, 31);
            this.btnDelChar.TabIndex = 5;
            this.btnDelChar.UseVisualStyleBackColor = false;
            this.btnDelChar.Click += new System.EventHandler(this.btnDelChar_Click);
            // 
            // cmbMemoryList
            // 
            this.cmbMemoryList.AllowDrop = true;
            this.cmbMemoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbMemoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoryList.Font = new System.Drawing.Font("Terminator Two", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMemoryList.ForeColor = System.Drawing.Color.Black;
            this.cmbMemoryList.FormattingEnabled = true;
            this.cmbMemoryList.Location = new System.Drawing.Point(204, 271);
            this.cmbMemoryList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMemoryList.Name = "cmbMemoryList";
            this.cmbMemoryList.Size = new System.Drawing.Size(94, 21);
            this.cmbMemoryList.TabIndex = 3;
            this.cmbMemoryList.TabStop = false;
            this.cmbMemoryList.SelectedIndexChanged += new System.EventHandler(this.cmbMemoryList_SelectedIndexChanged);
            // 
            // txtOperationDisp
            // 
            this.txtOperationDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperationDisp.Location = new System.Drawing.Point(327, 152);
            this.txtOperationDisp.Name = "txtOperationDisp";
            this.txtOperationDisp.ReadOnly = true;
            this.txtOperationDisp.Size = new System.Drawing.Size(32, 26);
            this.txtOperationDisp.TabIndex = 13;
            this.txtOperationDisp.TabStop = false;
            this.txtOperationDisp.TextChanged += new System.EventHandler(this.txtOperationDisp_TextChanged);
            // 
            // txtResultMem
            // 
            this.txtResultMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtResultMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultMem.Location = new System.Drawing.Point(43, 41);
            this.txtResultMem.Multiline = true;
            this.txtResultMem.Name = "txtResultMem";
            this.txtResultMem.ReadOnly = true;
            this.txtResultMem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultMem.Size = new System.Drawing.Size(315, 72);
            this.txtResultMem.TabIndex = 14;
            this.txtResultMem.TabStop = false;
            this.txtResultMem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultMem.TextChanged += new System.EventHandler(this.txtResultMem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Terminator Two", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "History";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Terminator Two", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Operand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Terminator Two", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Result";
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.BackColor = System.Drawing.Color.Transparent;
            this.Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.ForeColor = System.Drawing.Color.Black;
            this.Autor.Location = new System.Drawing.Point(292, 668);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(84, 13);
            this.Autor.TabIndex = 18;
            this.Autor.Text = "Marcin Zbylut";
            // 
            // CyberCulator3000
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(388, 690);
            this.ControlBox = false;
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultMem);
            this.Controls.Add(this.txtOperationDisp);
            this.Controls.Add(this.cmbMemoryList);
            this.Controls.Add(this.btnDelChar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMemPlus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOperand);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CyberCulator3000";
            this.Text = "CyberCulator3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOperand;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMemPlus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelChar;
        private System.Windows.Forms.ComboBox cmbMemoryList;
        private System.Windows.Forms.TextBox txtOperationDisp;
        private System.Windows.Forms.TextBox txtResultMem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Autor;
    }
}

