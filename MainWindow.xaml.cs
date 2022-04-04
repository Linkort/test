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
using System.IO;

namespace ProviCilkV2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            double _height = SystemParameters.PrimaryScreenHeight;
            double _width = SystemParameters.PrimaryScreenWidth;
            MessageBox.Show("Разрешение экрана: " + _width.ToString() + " X " + _height.ToString());
        }

        private void BtnLogs_Click(object sender, RoutedEventArgs e)
        {   
            if (TabControlLogsPort.Visibility == Visibility.Collapsed)
            {
                TabControlLogsPort.Visibility = Visibility.Visible;
            }
            else
            {
                TextBoxLogs.ClearValue(TextBox.TextProperty);
                TextBoxPort.ClearValue(TextBox.TextProperty);
                TabControlLogsPort.Visibility = Visibility.Collapsed;
            }
            TabItemSettings.IsSelected = true;

        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnA_Click(object sender, RoutedEventArgs e)
        {
            if (TabItemLogs.IsSelected == true & TabControlLogsPort.Visibility == Visibility.Visible)
            {
                TextBoxLogs.Text += "Btn" + sender.ToString() + "\n";
            }
        }

    }
}
