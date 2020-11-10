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

namespace solid52
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMB_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbResult = MessageBox.Show("Do you want to continue?", "Hello", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);


            switch (mbResult)
            {
                case MessageBoxResult.Yes:
                    txt1.Text = "Yes was chosen";
                    break;
                case MessageBoxResult.No:
                    txt1.Text = "No was chosen";
                    break;
                case MessageBoxResult.Cancel:
                    txt1.Text = "Cancel was chosen";
                    break;
            }
        }

        private void btnMB2_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbResult =
                MessageBox.Show("press OK to continue, else press Cancel",
                                "Error Ocurred",
                                MessageBoxButton.OKCancel,
                                MessageBoxImage.Error);
            switch (mbResult)
            {
                case MessageBoxResult.OK:
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am a simple Message Box", "Hello World");
        }

        private void btnHeb_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("התוכן כאן", "הכותרת כאן",
                            MessageBoxButton.YesNo,
                            MessageBoxImage.Hand,
                            MessageBoxResult.Yes,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

        }

    }
}
