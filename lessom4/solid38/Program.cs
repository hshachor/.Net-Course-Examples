using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// מקביל לדוגמא Ex4
/// שימוש בEVENT
/// ירושה מEVENTARG
/// </summary>
namespace solid38
{
    public class MyValue
    {
        private int myvalue = 0;
        /// <summary>
        /// הגדרה של שדה מסוג אירוע EVENTHANDLER
        /// זהו הדלגט אליו נרשמים במקרה שיש שינוי פרטים
        /// בגלל הסוג שלו - הוא מקבל שני פרמטרים (השולח, ופרטי האירוע)
        /// </summary>
        public event EventHandler ValueChanged;


        /// <summary>
        /// פונקציה שמפעילה את הדלגט
        /// שולחת כפרטמרים את העצם המפעיל את האירוע
        /// ואת ARGS
        /// </summary>
        /// <param name="args">פרטי האירוע</param>
        protected void OnValueChanged(ValueChangedEventArgs args)
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, args);
            }
        }

        public int Value
        {
            get { return myvalue; }

            set
            {//כאשר ערך כלשהו משתנה, חוץ מהטיפול בו - ניצור פרטי אירוע ונזמן את הדלגט,
                ValueChangedEventArgs args = new ValueChangedEventArgs(myvalue, value);
                myvalue = value;
                OnValueChanged(args);
            }
        }
    }



    /// <summary>
    /// מחלקה זו יוצרת פרטי אירוע.
    /// מאחר ויש לנו כמה פרטים, נירש ממחלקת EVENTARGS
    /// ונוסיף את הפרטים
    /// </summary>
    public class ValueChangedEventArgs : EventArgs
    {
        public readonly int OldValue, NewValue;

        public ValueChangedEventArgs(int oldTemp, int newTemp)
        {
            OldValue = oldTemp;
            NewValue = newTemp;
        }
    }
    //היה אפשר לעבוד עם דלגט במקום אירוע - אבל סיכמנו שזה לא רעיון טוב
    //   public delegate void ValueChangedEventHandler(Object sender, EventArgs args);
    /// <summary>
    ///      מחלקת משקיף - לפי התבנית עיצוב
    ///      יש בנאי ופונקציה מתאימה לדלגט (=אירוע)
    /// </summary>
    public class ValueChangeObserver
    {
        //הבנאי נרשם לאירוע
        public ValueChangeObserver(MyValue t)
        {
            t.ValueChanged += this.ValueChangeFunc;
        }

        public void ValueChangeFunc(Object sender, EventArgs e)
        { 
            //במידה והפרמטר שנשלח אינו כולל את פרטי האירוע - יש לנו תקלה
            if (!(e is ValueChangedEventArgs))
                return;
            //עושים המרה שיהיה קל יותר לעבוד. בהמשך כמובן שנעדיף מחלקה גנרית
            ValueChangedEventArgs temp = (ValueChangedEventArgs)e;
            Console.WriteLine("ChangeObserver: Old={0}, New={1}, Change={2}",
                temp.OldValue, temp.NewValue,
                temp.NewValue - temp.OldValue);
        }
    }

    //מחלקה נוספת, הכוללת אותם דברים, אבל עושה דברים אחרים
    public class ValueAverageObserver
    {
        private int sum = 0, count = 0;
        public ValueAverageObserver(MyValue t)
        {
            t.ValueChanged += this.ValueChangeFunc;
        }
        public void ValueChangeFunc(Object sender, EventArgs e)
        {
            if (e is ValueChangedEventArgs)
            {
                ValueChangedEventArgs temp = (ValueChangedEventArgs)e;

                count++;
                sum += temp.NewValue;

                Console.WriteLine("AverageObserver: Average={0:F}", (double)sum / (double)count);
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //הצהרה על עצם מסוג האירוע
            MyValue t = new MyValue();

            ValueChangeObserver v1 = new ValueChangeObserver(t);
           //למעשה - לא חייבים ליצור מצביע לעצם. העיקר שנרשמנו לאירוע
            new ValueAverageObserver(t);

            //כל שינוי בערך - מפעיל את 2 הפונקציות
            t.Value = 100;
            t.Value = 99;
            t.Value = 88;
            t.Value = 77;
        }
    }
}
