using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid53
{
    public interface ISports //: IComparable<ISports>
    {
        double LengthOfCourt { get; set; }  // מאפיינים
        double WidthOfCourt { get; set; }
        int NumberOfPlayers { get; set; }
        string NameOfSport { get; }
        void PrintSportInfo();          // מתודה
    }
    public class SurfingSport : ISports
    {
        public double LengthOfCourt { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public double WidthOfCourt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfPlayers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string NameOfSport => throw new NotImplementedException();

        public void PrintSportInfo()
        {
            throw new NotImplementedException();
        }
    }
    public class SportBall : ISports
    {
        int numPlayers;
        string sportName;
        double length;
        double width;

        public SportBall(int num, string name)
        {  // constructor
            numPlayers = num;
            sportName = name;
        }

        public int NumberOfPlayers
        {
            //	מימוש המאפיינים של המשק
            get { return numPlayers; }
            set { numPlayers = value; }
        }

        public string NameOfSport
        {
            get { return sportName; }
        }

        public double LengthOfCourt
        {
            get { return length; }
            set { length = value; }
        }

        public double WidthOfCourt
        {
            get { return width; }
            set { width = value; }
        }
        /*
        public int CompareTo(ISports other)
        {
            return NumberOfPlayers.CompareTo(other.NumberOfPlayers);
        }
        */
        public void PrintSportInfo()
        {
            //   מימוש המתודה מהממשק

            Console.WriteLine("Sport Info");
            Console.WriteLine("Name of Sport: {0}", NameOfSport);
            Console.WriteLine("# of Players:  {0}", NumberOfPlayers);
            Console.WriteLine("Court Dimensions: {0}m x {1}m",
                        LengthOfCourt, WidthOfCourt);
        }
    }
    class AppClass
    {
        /*
        public static void SortByBubble(IComparable[] arr)
        {
            int i = 0, j = 0;
            if (arr[i].CompareTo(arr[j]) == -1)
            {
                //swap
                IComparable temp = arr[j];

            }
        }
        */
        public static void Main()
        {
            //Console.WriteLine("5".CompareTo(7));
          /*  string[] arrS = new string[10];
            // fill array with string...
            SortByBubble(arrS);
            int[] arrI = new int[50];
            Array.Sort(arrI);
            // fill array...
//            SortByBubble(arrI);
          */
            SportBall volley = new SportBall(6, "Volley Ball");
            volley.LengthOfCourt = 18;
            volley.WidthOfCourt = 9;
            volley.PrintSportInfo();
            SportBall tennis = new SportBall(1, "Table Tennis");
            tennis.LengthOfCourt = 23.7;
            tennis.WidthOfCourt = 8.25;
            tennis.PrintSportInfo();

            ISports s = volley;
            s.PrintSportInfo();
        }
    }





}
