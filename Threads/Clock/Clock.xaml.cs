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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Test
{
    /// <summary>
    /// Interaction logic for Clock.xaml
    /// </summary>
    public partial class Clock : Window
    {
        volatile bool shouldStop;
        public Clock()
        {
            InitializeComponent();
            shouldStop = false;
            //StartClockUsingThread();
            //startClockUsingWorker();
        }

        
        private void startClockUsingWorker()
        {
            BackgroundWorker w = new BackgroundWorker();
            w.DoWork += (o, e) =>
            {
                while (!shouldStop)
                {
                    w.ReportProgress(1);
                    Thread.Sleep(500);
                }
            };
            w.ProgressChanged += (o, e) => changeUI();
            w.RunWorkerCompleted += (o, e) => stop();
            w.WorkerReportsProgress = true;
            w.RunWorkerAsync();
        }

        private void StartClockUsingThread()
        {
            new Thread(() =>
            {
                while (!shouldStop)
                {
                    changeUIDispatcher();
                    Thread.Sleep(500);
                    
                }
            }).Start();
        }

        private void changeUIDispatcher()
        {
            if (CheckAccess())
            {
                changeUI();
            }
            else {
                Dispatcher.BeginInvoke(new Action(changeUI));
            }
        }

        private void changeUI()
        {
            DateLabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }

        private void stop()
        {
            DateLabel.Content = "Clock stopped";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            shouldStop = true;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await startClockUsingTasks();
            stop();
        }

        async Task startClockUsingTasks()
        {
            //await WithoutProgress();
            //int i = await UseProgress();
            //MessageBox.Show("" + i);
            await withoutSleep();
        }

        private async Task withoutSleep()
        {
            while (!shouldStop)
            {
                changeUI();
                await Task.Delay(500);
            }
        }

        private async Task WithoutProgress()
        {
            await Task.Run(() =>
            {
                while (!shouldStop)
                {
                    changeUI();
                    Thread.Sleep(500);
                }
            });
        }

        private async Task<int> UseProgress()
        {
            IProgress<int> p = new Progress<int>((i) => changeUI());
            await Task.Run(() =>
            {
                while (!shouldStop)
                {
                    p.Report(0);
                    Thread.Sleep(500);
                }
            });
            return 10;
        }
    }
}
