namespace PurnaCalculator
{
    public partial class PurnaCalculator : Form
    {
        public PurnaCalculator()
        {
            InitializeComponent();
        }

        private void PerformCalculation(string operation)
        {
            try
            {
                double number1 = double.Parse(textBox1.Text);
                double number2 = double.Parse(textBox2.Text);
                double result = 0;
                string description = "";

                switch (operation)
                {
                    case "+":
                        this.Hide();
                        result = number1 + number2;
                        description = $"The calculation of {number1} + {number2} = {result}";
                        break;
                    case "-":
                        this.Hide();
                        result = number1 - number2;
                        description = $"The calculation of {number1} - {number2} = {result}.";
                        break;
                    case "*":
                        this.Hide();
                        result = number1 * number2;
                        description = $"The calculation of {number1} * {number2} = {result}.";
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            MessageBox.Show("Division by 0 is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        this.Hide();
                        result = number1 / number2;
                        description = $"The calculation of {number1} / {number2} = {result}.";
                        break;
                }

                MessageBox.Show($"{description}\n\n- Purna Shrestha", "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PerformCalculation("+");
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            PerformCalculation("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PerformCalculation("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            PerformCalculation("/");
        } 
    }
}