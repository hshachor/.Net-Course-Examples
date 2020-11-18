using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadsWpf0
{
    class Account
    {
        public enum AccountState { RUNNING, STOPCLOSED, STOP }
        public const int CLOSED = -999999;
        public const int UPDATE = -999998;

        public event EventHandler<AccountEventArgs> BalanceChanged;
        public event EventHandler AccountClosed = (o,e) => { };
        
        void BalanceChangedHandler(int balance)
        {
            if (BalanceChanged != null)
            {
                BalanceChanged(this, new AccountEventArgs(balance));
            }
        }

        private int balance;
        private int Balance
        {
            get { return balance; }
            set
            {
                if (balance == CLOSED) return;
                if (balance != value)
                {
                    balance = value;
                    BalanceChangedHandler(value);
                }
            }
        }

        private readonly int interestRate; // integer % number
        private Thread myThread;
        private volatile AccountState _shouldStop;
        public Account(int initBalance, int interestRate)
        {
            this.Balance = initBalance;
            this.interestRate = interestRate;
            BackgroundWorker balance_worker = new BackgroundWorker();
            balance_worker.DoWork += (o, e) =>
            {
                myThread = Thread.CurrentThread;
                _shouldStop = AccountState.RUNNING;
                while (_shouldStop == AccountState.RUNNING)
                {
                    //applyInterest();
                    balance_worker.ReportProgress(UPDATE);
                    Thread.Sleep(3000); // 3 secs
                }
                for (int down = 5; down > 0; down--)
                {
                    balance_worker.ReportProgress(down);
                    Thread.Sleep(1000); // 5 secs delay
                }
                if (_shouldStop == AccountState.STOPCLOSED)
                    balance_worker.ReportProgress(CLOSED);
            };

            balance_worker.ProgressChanged += (o, e) =>
            {
                if (e.ProgressPercentage == UPDATE)
                {
                    applyInterest();
                }
                else
                {
                    Balance = e.ProgressPercentage;
                }
            };

            balance_worker.RunWorkerCompleted += (o, e) => AccountClosed(this, EventArgs.Empty);

            balance_worker.WorkerReportsProgress = true;
            balance_worker.RunWorkerAsync();
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public bool Withdraw(int amount)
        {
            if (amount > Balance) return false;
            Balance -= amount;
            return true;
        }

        private void applyInterest()
        {
            Balance = (Balance * (100 + interestRate)) / 100;
        }

        public void Close(bool upd)
        {
            _shouldStop = upd ? AccountState.STOPCLOSED : AccountState.STOP;
        }

        public bool threadFinished(bool sync)
        {
            if (myThread == null)
                return true;
            if (sync)
            {
                myThread.Join();
                return true;
            }
            bool t = !myThread.IsAlive;
            return t;
        }
    }
}
