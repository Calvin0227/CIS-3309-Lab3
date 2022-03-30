
namespace TaxCalculator
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
            this.lblTaxableIncome = new System.Windows.Forms.Label();
            this.txtTaxableIncome = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtIncometaxowed = new System.Windows.Forms.TextBox();
            this.lblIncomeTaxOwed = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaxableIncome
            // 
            this.lblTaxableIncome.AutoSize = true;
            this.lblTaxableIncome.Location = new System.Drawing.Point(19, 123);
            this.lblTaxableIncome.Name = "lblTaxableIncome";
            this.lblTaxableIncome.Size = new System.Drawing.Size(89, 12);
            this.lblTaxableIncome.TabIndex = 0;
            this.lblTaxableIncome.Text = "Taxable income";
            this.lblTaxableIncome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTaxableIncome
            // 
            this.txtTaxableIncome.Location = new System.Drawing.Point(136, 120);
            this.txtTaxableIncome.Name = "txtTaxableIncome";
            this.txtTaxableIncome.Size = new System.Drawing.Size(100, 21);
            this.txtTaxableIncome.TabIndex = 1;
            this.txtTaxableIncome.TextChanged += new System.EventHandler(this.txtTaxableIncome_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(49, 196);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCalculate_KeyPress);
            // 
            // txtIncometaxowed
            // 
            this.txtIncometaxowed.Location = new System.Drawing.Point(136, 161);
            this.txtIncometaxowed.Name = "txtIncometaxowed";
            this.txtIncometaxowed.Size = new System.Drawing.Size(100, 21);
            this.txtIncometaxowed.TabIndex = 3;
            this.txtIncometaxowed.TextChanged += new System.EventHandler(this.txtIncometaxowed_TextChanged);
            // 
            // lblIncomeTaxOwed
            // 
            this.lblIncomeTaxOwed.AutoSize = true;
            this.lblIncomeTaxOwed.Location = new System.Drawing.Point(19, 164);
            this.lblIncomeTaxOwed.Name = "lblIncomeTaxOwed";
            this.lblIncomeTaxOwed.Size = new System.Drawing.Size(95, 12);
            this.lblIncomeTaxOwed.TabIndex = 4;
            this.lblIncomeTaxOwed.Text = "Income tax owed";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(136, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(0, 27);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(65, 12);
            this.lblEnterName.TabIndex = 6;
            this.lblEnterName.Text = "Enter Name";
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(75, 27);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(100, 21);
            this.txtEnterName.TabIndex = 7;
            this.txtEnterName.TextChanged += new System.EventHandler(this.txtEnterName_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(209, 27);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(309, 231);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblIncomeTaxOwed);
            this.Controls.Add(this.txtIncometaxowed);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTaxableIncome);
            this.Controls.Add(this.lblTaxableIncome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxableIncome;
        private System.Windows.Forms.TextBox txtTaxableIncome;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtIncometaxowed;
        private System.Windows.Forms.Label lblIncomeTaxOwed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Button btnOk;
    }
}

