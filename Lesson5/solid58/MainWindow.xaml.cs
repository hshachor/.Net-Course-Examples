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

namespace solid58
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mytb.TextChanged += Mytb_TextChanged;
        }

        private void Mytb_TextChanged(object sender, TextChangedEventArgs e)
        {
            myb.IsEnabled = true;
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            myb.Visibility = Visibility.Visible;
            mytb.Visibility = Visibility.Visible;
        }

        private void myb_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem newitem = new ListBoxItem();
            newitem.Content = mytb.Text;
            mylb.Items.Add(newitem);
        }
    }
}
