using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;
        int firstValue;
        int secondValue;
        double result;
        Operations op = 0;
        bool shouldClearLabel = false;

        string LabelText 
        { 
            get
            {
                return this.mainWindow.calculatorLabel.Content.ToString();
            }
            set
            {
                if (value != "Clear")
                {
                    this.mainWindow.calculatorLabel.Content = $"{LabelText}{value}";
                }
                else
                {
                    this.mainWindow.calculatorLabel.Content = "";
                }
            }
        }

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            model = new Model();
            this.mainWindow.NumberEvent += MainWindow_NumberEvent;
            this.mainWindow.OperationEvent += MainWindow_OperationEvent;
            this.mainWindow.ClearEvent += MainWindow_ClearEvent;
        }

        private void MainWindow_ClearEvent(object sender, EventArgs e)
        {
            ClearValues();
            LabelText = "Clear";
        }

        private void MainWindow_NumberEvent(object sender, EventArgs e)
        {
            if (shouldClearLabel)
            {
                LabelText = "Clear";
                shouldClearLabel = false;
            }

            Button btn = (Button)sender;
            var number = btn.Content.ToString();
            if (op == 0)
            {
                firstValue = Convert.ToInt32($"{firstValue}{number}");
                LabelText = number;
            }
            else
            {
                secondValue = Convert.ToInt32($"{secondValue}{number}");
                LabelText = number;
            }
        }

        private void MainWindow_OperationEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            LabelText = $" {btn.Content.ToString()} ";

            switch (btn.Content.ToString())
            {
                case "+":
                    op = Operations.Add;
                    break;
                case "-":
                    op = Operations.Difference;
                    break;
                case "*":
                    op = Operations.Multiplication;
                    break;
                case "/":
                    op = Operations.Division;
                    break;
                case "=":
                    result = model.GetArithmeticResult(firstValue, secondValue, op);
                    LabelText = $" {result.ToString()} ";
                    ClearValues();
                    break;
                default:
                    break;
            }
        }

        private void ClearValues()
        {
            firstValue = 0;
            secondValue = 0;
            op = 0;
            shouldClearLabel = true;
        }
    }
}
