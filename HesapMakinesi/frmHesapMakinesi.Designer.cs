namespace HesapMakinesi
{
    partial class frmHesapMakinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesapMakinesi));
            this.lblResult = new System.Windows.Forms.Label();
            this.grpCalculator = new System.Windows.Forms.GroupBox();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblOperationText = new System.Windows.Forms.Label();
            this.btnRoot = new System.Windows.Forms.Button();
            this.grpCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(44, 64);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(336, 70);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpCalculator
            // 
            this.grpCalculator.Controls.Add(this.btnRoot);
            this.grpCalculator.Controls.Add(this.btnComma);
            this.grpCalculator.Controls.Add(this.btnCE);
            this.grpCalculator.Controls.Add(this.btnDelete);
            this.grpCalculator.Controls.Add(this.btnCal);
            this.grpCalculator.Controls.Add(this.btnAdd);
            this.grpCalculator.Controls.Add(this.btnDiv);
            this.grpCalculator.Controls.Add(this.btnMult);
            this.grpCalculator.Controls.Add(this.btnMinus);
            this.grpCalculator.Controls.Add(this.btn0);
            this.grpCalculator.Controls.Add(this.btn9);
            this.grpCalculator.Controls.Add(this.btn8);
            this.grpCalculator.Controls.Add(this.btn7);
            this.grpCalculator.Controls.Add(this.btn6);
            this.grpCalculator.Controls.Add(this.btn5);
            this.grpCalculator.Controls.Add(this.btn4);
            this.grpCalculator.Controls.Add(this.btn3);
            this.grpCalculator.Controls.Add(this.btn2);
            this.grpCalculator.Controls.Add(this.btn1);
            this.grpCalculator.Location = new System.Drawing.Point(25, 137);
            this.grpCalculator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCalculator.Name = "grpCalculator";
            this.grpCalculator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCalculator.Size = new System.Drawing.Size(355, 400);
            this.grpCalculator.TabIndex = 17;
            this.grpCalculator.TabStop = false;
            this.grpCalculator.Text = "Hesap Makinesi";
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnComma.Location = new System.Drawing.Point(176, 28);
            this.btnComma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(75, 65);
            this.btnComma.TabIndex = 34;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.btnDot_Click_1);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCE.Location = new System.Drawing.Point(96, 27);
            this.btnCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 65);
            this.btnCE.TabIndex = 33;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(15, 27);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 65);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "C";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCal.Location = new System.Drawing.Point(177, 311);
            this.btnCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 65);
            this.btnCal.TabIndex = 31;
            this.btnCal.Text = "=";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(257, 311);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 65);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiv.Location = new System.Drawing.Point(257, 98);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 65);
            this.btnDiv.TabIndex = 29;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMult.Location = new System.Drawing.Point(257, 170);
            this.btnMult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 65);
            this.btnMult.TabIndex = 28;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinus.Location = new System.Drawing.Point(257, 240);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 65);
            this.btnMinus.TabIndex = 27;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(15, 311);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(156, 65);
            this.btn0.TabIndex = 26;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(177, 98);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 65);
            this.btn9.TabIndex = 25;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(96, 98);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 65);
            this.btn8.TabIndex = 24;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(15, 98);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 65);
            this.btn7.TabIndex = 23;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(177, 170);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 65);
            this.btn6.TabIndex = 22;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(96, 170);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 65);
            this.btn5.TabIndex = 21;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(15, 170);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 65);
            this.btn4.TabIndex = 20;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(177, 240);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 65);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(96, 240);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 65);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(15, 240);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 65);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblOperationText
            // 
            this.lblOperationText.BackColor = System.Drawing.Color.White;
            this.lblOperationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOperationText.Location = new System.Drawing.Point(39, 23);
            this.lblOperationText.Name = "lblOperationText";
            this.lblOperationText.Size = new System.Drawing.Size(336, 30);
            this.lblOperationText.TabIndex = 19;
            this.lblOperationText.Text = "0";
            this.lblOperationText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRoot
            // 
            this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoot.Location = new System.Drawing.Point(258, 29);
            this.btnRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(75, 65);
            this.btnRoot.TabIndex = 35;
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // frmHesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 546);
            this.Controls.Add(this.lblOperationText);
            this.Controls.Add(this.grpCalculator);
            this.Controls.Add(this.lblResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHesapMakinesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.frmHesapMakinesi_Load);
            this.grpCalculator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpCalculator;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Label lblOperationText;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnRoot;
    }
}

