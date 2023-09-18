namespace Calculator_Application
{
    public partial class Form1 : Form
    {
        CalculatorClass cal;
        double num1, num2;
        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);
            if (cbOperator.Text == "+")
            {
                cal.CalculateEvent += new Information<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.GetSum);
            }
            else if (cbOperator.Text == "-")
            {
                cal.CalculateEvent += new Information<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.GetDifference);
            }
            else if (cbOperator.Text == "*")
            {
                cal.CalculateEvent += new Information<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.GetProduct);
            }
            else if (cbOperator.Text == "/")
            {
                cal.CalculateEvent += new Information<double>(cal.GetQuotient);
                lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.GetQuotient);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}