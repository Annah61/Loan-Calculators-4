namespace Loan_Calculators_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            IbIMonthlyPayment=new Label();
            txtLoanAmount=new TextBox();
            txtDownPayment=new TextBox();
            txtInterestRate=new TextBox();
            txtTerms=new TextBox();
            btnMortgage=new Button();
            btnAuto=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(28, 39);
            label1.Name="label1";
            label1.Size=new Size(120, 25);
            label1.TabIndex=0;
            label1.Text="Loan Amount";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(30, 91);
            label2.Name="label2";
            label2.Size=new Size(132, 25);
            label2.TabIndex=1;
            label2.Text="Down Payment";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(37, 153);
            label3.Name="label3";
            label3.Size=new Size(111, 25);
            label3.TabIndex=2;
            label3.Text="Interest Rate";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(38, 214);
            label4.Name="label4";
            label4.Size=new Size(122, 25);
            label4.TabIndex=3;
            label4.Text="Terms in Years";
            // 
            // IbIMonthlyPayment
            // 
            IbIMonthlyPayment.AutoSize=true;
            IbIMonthlyPayment.Location=new Point(269, 372);
            IbIMonthlyPayment.Name="IbIMonthlyPayment";
            IbIMonthlyPayment.Size=new Size(151, 25);
            IbIMonthlyPayment.TabIndex=4;
            IbIMonthlyPayment.Text="Monthly Payment";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location=new Point(205, 39);
            txtLoanAmount.Name="txtLoanAmount";
            txtLoanAmount.Size=new Size(150, 31);
            txtLoanAmount.TabIndex=5;
            // 
            // txtDownPayment
            // 
            txtDownPayment.Location=new Point(199, 91);
            txtDownPayment.Name="txtDownPayment";
            txtDownPayment.Size=new Size(150, 31);
            txtDownPayment.TabIndex=6;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location=new Point(199, 147);
            txtInterestRate.Name="txtInterestRate";
            txtInterestRate.Size=new Size(150, 31);
            txtInterestRate.TabIndex=7;
            // 
            // txtTerms
            // 
            txtTerms.Location=new Point(202, 211);
            txtTerms.Name="txtTerms";
            txtTerms.Size=new Size(150, 31);
            txtTerms.TabIndex=8;
            // 
            // btnMortgage
            // 
            btnMortgage.Location=new Point(269, 290);
            btnMortgage.Name="btnMortgage";
            btnMortgage.Size=new Size(112, 34);
            btnMortgage.TabIndex=9;
            btnMortgage.Text="Mortgage";
            btnMortgage.UseVisualStyleBackColor=true;
            btnMortgage.Click+=btnMortgage_Click;
            // 
            // btnAuto
            // 
            btnAuto.Location=new Point(433, 290);
            btnAuto.Name="btnAuto";
            btnAuto.Size=new Size(112, 34);
            btnAuto.TabIndex=10;
            btnAuto.Text="Auto";
            btnAuto.UseVisualStyleBackColor=true;
            btnAuto.Click+=btnAuto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(btnAuto);
            Controls.Add(btnMortgage);
            Controls.Add(txtTerms);
            Controls.Add(txtInterestRate);
            Controls.Add(txtDownPayment);
            Controls.Add(txtLoanAmount);
            Controls.Add(IbIMonthlyPayment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form1";
            Text="Loan Calculators";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label IbIMonthlyPayment;
        private TextBox txtLoanAmount;
        private TextBox txtDownPayment;
        private TextBox txtInterestRate;
        private TextBox txtTerms;
        private Button btnMortgage;
        private Button btnAuto;
    }
}