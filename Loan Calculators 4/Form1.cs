namespace Loan_Calculators_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMortgage_Click(object sender, EventArgs e)
        {
            // Create some local variables

            double downPayment = 0.0;
            double interestRate = 0.0;
            double MonthlyPayment = 0.0;
            double LoanAmount = 0.0;
            int terms = 0;

            // Do some validation 
            if (!String.IsNullOrEmpty(txtLoanAmount.Text)) LoanAmount = Convert.ToDouble(txtLoanAmount.Text);

            if (!String.IsNullOrEmpty(txtDownPayment.Text)) downPayment = Convert.ToDouble(txtDownPayment.Text);

            if (!String.IsNullOrEmpty(txtInterestRate.Text)) interestRate = Convert.ToDouble(txtInterestRate.Text);
            if (!String.IsNullOrEmpty(txtTerms.Text)) terms = Convert.ToInt32(txtTerms.Text);

            // Mortgage Payment calculation logic 
            // Formula: Payment = (Loan Amount - Down Payment) * (1 + Interest Rate / 12)^(Terms * 12)
            int termsinMonths = terms * 12;
            MonthlyPayment = (LoanAmount - downPayment) * (Math.Pow((1 + interestRate / 12), termsinMonths) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termsinMonths) - 1));
            MonthlyPayment = Math.Round(MonthlyPayment, 2);

            // Display the result 
            IbIMonthlyPayment.Text = String.Format("Monthly Payment: R {0}", MonthlyPayment.ToString());
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            // Create some local variables

            double downPayment = 0.0;
            double interestRate = 0.0;
            double MonthlyPayment = 0.0;
            double LoanAmount = 0.0;
            int terms = 0;

            // Do some validation 
            if (!String.IsNullOrEmpty(txtLoanAmount.Text)) LoanAmount = Convert.ToDouble(txtLoanAmount.Text);

            if (!String.IsNullOrEmpty(txtDownPayment.Text)) downPayment = Convert.ToDouble(txtDownPayment.Text);

            if (!String.IsNullOrEmpty(txtInterestRate.Text)) interestRate = Convert.ToDouble(txtInterestRate.Text);
            if (!String.IsNullOrEmpty(txtTerms.Text)) terms = Convert.ToInt32(txtTerms.Text);

            // Mortgage Payment calculation logic 
            // Formula: Payment = (Loan Amount - Down Payment) * (1 + Interest Rate / 12)^(Terms * 12)
            int termsinMonths = terms * 12;
            MonthlyPayment = (LoanAmount - downPayment) * (Math.Pow((1 + interestRate / 12), termsinMonths) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termsinMonths) - 1));
            MonthlyPayment = Math.Round(MonthlyPayment, 2);

            // Display the result 
            IbIMonthlyPayment.Text = String.Format("Monthly Payment: R {0}", MonthlyPayment.ToString());
        }
    }
}   

