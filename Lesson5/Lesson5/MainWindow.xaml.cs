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

namespace Lesson5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.AddButton.MouseEnter += AddButton_MouseEnter;
        }

       private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.AddButton.Content = "Add";
        }

        private void AddButton_MouseEnter
            (object sender, MouseEventArgs e)

        {
            Random r = new Random();

            double Xsize = r.Next((int)this.Width / 2);
            double Ysize = r.Next((int)this.Height / 2);

            Canvas.SetLeft((UIElement)sender, Xsize);
            Canvas.SetTop((UIElement)sender, Ysize);

        }


    }
}
