using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid53
{
    public interface ISports
    {
        double LengthOfCourt { get; set; }  // מאפיינים
        double WidthOfCourt { get; set; }
        int NumberOfPlayers { get; set; }
        string NameOfSport { get; }
        void PrintSportInfo();          // מתודה
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
        public static void Main()
        {
            SportBall volley = new SportBall(6, "Volley Ball");
            volley.LengthOfCourt = 18;
            volley.WidthOfCourt = 9;
            volley.PrintSportInfo();
            SportBall tennis = new SportBall(1, "Table Tennis");
            tennis.LengthOfCourt = 23.7;
            tennis.WidthOfCourt = 8.25;
            tennis.PrintSportInfo();
        }
    }





}
