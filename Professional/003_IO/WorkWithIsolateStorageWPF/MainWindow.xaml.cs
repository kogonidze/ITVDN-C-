using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
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

namespace WorkWithIsolateStorageWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IsolatedStorageFile userStorage;
        IsolatedStorageFileStream userStream;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            userStream =
                new IsolatedStorageFileStream("ColorSettings.dat", FileMode.OpenOrCreate, userStorage);

            using (var streamReader = new StreamReader(userStream))
            {
                var contents = streamReader.ReadToEnd();
                if (!string.IsNullOrEmpty(contents))
                {
                    ColorPicker.SelectedColor = (Color?)ColorConverter.ConvertFromString(contents);
                    ColorLabel.Content = contents;
                    ColorLabel.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(contents));
                }               
            }
        }

        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            ColorLabel.Content = e.NewValue.Value;
            ColorLabel.Background = new SolidColorBrush(e.NewValue.Value);
        }

        private void SaveDataBtn_Click(object sender, RoutedEventArgs e)
        {
            //IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            //IsolatedStorageFileStream userStream = 
            //    new IsolatedStorageFileStream("ColorSettings.dat", System.IO.FileMode.Create, userStorage);
            userStream =
               new IsolatedStorageFileStream("ColorSettings.dat", System.IO.FileMode.Create, userStorage);

            using (var userWriter = new StreamWriter(userStream))
            {
                userWriter.WriteLine(ColorPicker.SelectedColor);
            }
        }
    }
}
