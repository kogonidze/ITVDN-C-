using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EventHandler numberEvent;
        private EventHandler operationEvent;
        private EventHandler clearEvent;

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler NumberEvent
        {
            add { numberEvent += value; }
            remove { numberEvent -= value; }
        }

        public event EventHandler OperationEvent
        {
            add { operationEvent += value; }
            remove { operationEvent -= value; }
        }

        public event EventHandler ClearEvent
        {
            add { clearEvent += value; }
            remove { clearEvent -= value; }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            numberEvent.Invoke(sender, e);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            numberEvent.Invoke(sender, e);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            numberEvent.Invoke(sender, e);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            numberEvent.Invoke(sender, e);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            numberEvent.Invoke(sender, e);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            numberEvent.Invoke(sender, e);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            numberEvent.Invoke(sender, e);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            numberEvent.Invoke(sender, e);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            numberEvent.Invoke(sender, e);
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            numberEvent.Invoke(sender, e);
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            operationEvent.Invoke(sender, e);
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            operationEvent.Invoke(sender, e);
        }

        private void buttonDiff_Click(object sender, RoutedEventArgs e)
        {
            operationEvent.Invoke(sender, e);
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            operationEvent.Invoke(sender, e);
        }

        private void buttonMult_Click(object sender, RoutedEventArgs e)
        {
            operationEvent.Invoke(sender, e);
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            clearEvent.Invoke(sender, e);
        }
    }
}
