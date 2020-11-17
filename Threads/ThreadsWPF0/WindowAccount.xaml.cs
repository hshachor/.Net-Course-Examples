using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ThreadsWpf0
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
        private Account myAccount;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myAccount = new Account(1000, 2);
            myAccount.BalanceChanged += windowAccountObserver;
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (myAccount != null)
                new Thread(() => myAccount.Close(true)).Start();
        }

        private void textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (myAccount != null)
            {
                myAccount.Close(false);
                myAccount.threadFinished(true);
            }
        }
        private void windowAccountObserver(object sender, AccountEventArgs args)
        {
            updateBalance(args.Balance);
        }

        private void updateBalance(int balance)
        {
            txtBalance.Content = String.Format("{0}", balance);
        }

    }
}
