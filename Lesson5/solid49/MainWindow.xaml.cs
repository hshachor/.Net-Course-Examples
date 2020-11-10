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

namespace solid49
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.button1.MouseEnter += Button_MouseEnter;
            this.button1.MouseLeave += Button_MouseLeave;

            this.button2.MouseEnter += Button_MouseEnter;
            this.button2.MouseLeave += Button_MouseLeave;

            this.button3.MouseEnter += Button_MouseEnter;
            this.button3.MouseLeave += Button_MouseLeave;
            this.button4.MouseEnter += Button_MouseEnter;
            this.button4.MouseLeave += Button_MouseLeave;
        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                b.Height += b.Height;
                b.Width += b.Width;
            }
        }
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                b.Height = b.Height / 2;
                b.Width = b.Width / 2;
            }
        }
    }
}
