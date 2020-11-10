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
//כל מיני משחקים בתכונות כפתור וקישור בין כפתורים ואירועים
namespace solid39
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;//מונה

        public MainWindow()
        {
            InitializeComponent();
            this.check1.Click += check1_Click_1;// רישום לאירוע שלא נעשה אוטומטית

        }

        private void btnSample1_Click(object sender, RoutedEventArgs e)
        {
            if (btnSample1.Content.Equals("Add"))//על מנת לשנות את הכיתבו על הכפתור לסירוגין, נבדוק מה הערך הנוכחי של הכפתור
                this.btnSample1.Content = "הוסף";
            else
                this.btnSample1.Content = "Add";
        }

        private void btnSample2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sample 2");//פתיחה של "חלון" נוסף
        }

        private void btnSample3_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnSample3.Content = counter++; //שימוש בפרמטר והצגה שלו בטקסט של הפקד
        }



        private void btnSample3_Click(object sender, RoutedEventArgs e)
        {


        }

        private void btnAvg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void check1_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.btnAvg != null)// אם תיבת הסימון מסומנת, הכפתור זמין (ולהיפך)
            {
                if (this.check1.IsChecked == true)
                    this.btnAvg.IsEnabled = true;
                else
                    this.btnAvg.IsEnabled = false;
            }
        }

        private void btnSample3_MouseLeave(object sender, MouseEventArgs e)
        {
            this.btnSample3.Content = 0;
        }
    }
}

