namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float firstNumber = 0;
        private float secondNumber = 0;
        private Operation currentOperation = Operation.None;
        private bool wasComma = false;

        public enum Operation
        {
            None,
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        private void OnClickNumberButton(object sender, EventArgs e)
        {
            var clickedValue = ((Button)sender).Text;
            
            if (Display.Text == "0" && clickedValue == "0")
            {
                Display.Text = "0";
            }
            else
            {
                if (Display.Text == "0")
                {
                    Display.Text = string.Empty;
                    if (clickedValue == ",")
                    {
                        Display.Text = "0";
                        wasComma = true;
                    }
                }
                
                Display.Text += clickedValue;

            }                       
        }

        private void ClearButton(object sender, EventArgs e)
        {
            Display.Text = 0.ToString();
            firstNumber = 0;
            secondNumber = 0;
            currentOperation = Operation.None;  
        }

        private void OnClickOperationButton(object sender, EventArgs e)
        {
            firstNumber = float.Parse(Display.Text);

            var operation = ((Button)sender).Text;

            currentOperation = operation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Subtraction,
                "÷" => Operation.Division,
                "x" => Operation.Multiplication
            };

            Display.Text = string.Empty;
        }

        private void OnClickResultButton(object sender, EventArgs e)
        {
            secondNumber = float.Parse(Display.Text);   

            var result = Calculate(firstNumber, secondNumber);

            Display.Text = result.ToString();
        }

        private float Calculate(float firstNumber, float secondNumber)
        {
            switch (currentOperation)
            {
                case Operation.Addition:
                    return firstNumber + secondNumber;
                case Operation.Subtraction:
                    return firstNumber - secondNumber;
                case Operation.Multiplication:
                    return firstNumber * secondNumber;
                case Operation.Division:
                    if (secondNumber == 0)
                    {
                        Display.Text = "You can't divide by zero!";
                        return 0;
                    }
                    return firstNumber / secondNumber;                    
            }
            return 0;
        }
    }
}