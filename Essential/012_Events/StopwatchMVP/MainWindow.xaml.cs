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

namespace StopwatchMVP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EventHandler startEvent;
        private EventHandler stopEvent;
        private EventHandler resetEvent;

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler StartEvent
        {
            add { startEvent += value; }
            remove { startEvent -= value; }
        }

        public event EventHandler StopEvent
        {
            add { stopEvent += value; }
            remove { stopEvent -= value; }
        }

        public event EventHandler ResetEvent
        {
            add { resetEvent += value; }
            remove { resetEvent -= value; }
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            startEvent.Invoke(sender, e);
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            stopEvent.Invoke(sender, e);
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            resetEvent.Invoke(sender, e);
        }
    }
}
