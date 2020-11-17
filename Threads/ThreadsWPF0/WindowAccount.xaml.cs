using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private bool warned = false;

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
            TextBox text = sender as TextBox;
            if (text == null) return;
            if (e == null) return;

            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                if (text.Text.Length > 0)
                {
                    int amount = int.Parse(text.Text);
                    text.Text = "";
                    if (sender == txtDeposit)
                        myAccount.Deposit(amount);
                    else if (sender == txtWithdraw)
                        if (!myAccount.Withdraw(amount))
                            MessageBox.Show("You do not have enough money!", "Account",
                                            MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                e.Handled = true;
                return;
            }

            // It`s a system key (add other key here if you want to allow)
            if (e.Key == Key.Escape || e.Key == Key.Tab || e.Key == Key.Back || e.Key == Key.Delete ||
                e.Key == Key.CapsLock || e.Key == Key.LeftShift || e.Key == Key.RightShift ||
                e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl || e.Key == Key.LeftAlt ||
                e.Key == Key.RightAlt || e.Key == Key.LWin || e.Key == Key.RWin || e.Key == Key.System ||
                e.Key == Key.Left || e.Key == Key.Up || e.Key == Key.Down || e.Key == Key.Right)
                return;

            char c = (char)KeyInterop.VirtualKeyFromKey(e.Key);
            if (Char.IsControl(c)) return;
            if (Char.IsDigit(c))
                if (!(Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift) ||
                      Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl) ||
                      Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt)))
                    return;
            e.Handled = true;
            MessageBox.Show("Only numbers are allowed", "Account", MessageBoxButton.OK, MessageBoxImage.Error);
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
            bool low = UpdateBalanceCond(args.Balance);
            warnLowBalance(low);

        }

        private void warnLowBalance(bool low)
        {
            if (low && !warned)
            {
                MessageBox.Show(
                    "You are going low on balance!",
                    "Account warning",
                    MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
            }
            warned = low;
        }

        public void UpdateBalanceCond2(int balance)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (sender, args) => { args.Result = updateBalanceCond((int)args.Argument); };
            worker.RunWorkerCompleted += (sender, args) => warnLowBalance((bool)args.Result);
            //worker.WorkerReportsProgress = true;
            //worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync(balance);
        }

        private bool UpdateBalanceCond(int balance)
        {
            if (CheckAccess())
            {
                return updateBalanceCond(balance);
            }
            else
            {
                return (bool)Dispatcher.Invoke(new Predicate<int>(updateBalanceCond), balance);
            }
        }

        private bool updateBalanceCond(int balance)
        {
            updateBalance(balance);
            return balance < 500;
        }

        private void UpdateBalance(int balance)
        {
            if (CheckAccess())
            {
                updateBalance(balance);
            }
            else
            {
                Dispatcher.BeginInvoke(new Action<int>(UpdateBalance), balance);
            }
        }

        private void updateBalance(int balance)
        {
            txtBalance.Content = String.Format("{0}", balance);
        }

    }
}
