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

namespace BackgroundWorkerExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker worker;
        volatile bool stop = false;
        

        public MainWindow()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += doWork;
            worker.ProgressChanged += progressChanged;
            worker.RunWorkerCompleted += runWorkerCompleted;
            worker.WorkerReportsProgress = true;

        }

        private void runWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBlock.Text = $"Worker finished when counter is {e.Result} ";
        }

        private void progressChanged(object sender, ProgressChangedEventArgs e)
        {
            textBlock.Text = $"Current counter is {e.ProgressPercentage} ";
        }

        private void doWork(object sender, DoWorkEventArgs e)
        {
            int counter = 0;
            while (!stop)
            {
                Thread.Sleep(1000);
                counter++;
                worker.ReportProgress(counter);
            }
            e.Result = counter;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (!worker.IsBusy)
            {
                stop = false;
                worker.RunWorkerAsync("hello");
            } else
            {
                stop = true;
            }
        }
    }
}
