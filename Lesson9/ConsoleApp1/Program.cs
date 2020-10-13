using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        private static Thread gMapsThread;
        private static bool isRun;

        private static void PrintDrivingDistanceInMiles()
        {
            Console.Write("origin address: ");
            string origin = Console.ReadLine(); //"pisga 10 st. jerusalem";
            Console.Write("destination address: ");
            string destination = Console.ReadLine(); // "gilgal 42 st. ramat-gan";

            string url = @"http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" +
              origin + "&destinations=" + destination +
              "&mode=driving&sensor=false&language=en-EN&units=imperial";

            while (isRun)
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader sreader = new StreamReader(dataStream);
                string responsereader = sreader.ReadToEnd();
                response.Close();

                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(responsereader);

                //Console.WriteLine(xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText);
                if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK") //we have answer 
                {
                    isRun = false; //stop the thread

                    //Console.WriteLine(xmldoc.GetElementsByTagName("status")[1].ChildNodes[0].InnerText);
                    if (xmldoc.GetElementsByTagName("status")[1].ChildNodes[0].InnerText == "NOT_FOUND")//one of the addresses is not found
                        Console.WriteLine("one of the adrresses is not found");
                    else
                    {
                        XmlNodeList distance = xmldoc.GetElementsByTagName("distance");
                        double dist = Convert.ToDouble(distance[0].ChildNodes[1].InnerText.Replace(" mi", ""));
                        Console.WriteLine(dist * 1.609344);

                        XmlNodeList duration = xmldoc.GetElementsByTagName("duration");
                        string dur = duration[0].ChildNodes[1].InnerText;
                        Console.WriteLine(dur);
                    }
                }
                else
                    Thread.Sleep(1000);

            }
        }
        static void Main(string[] args)
        {
            isRun = true;
            gMapsThread = new Thread(PrintDrivingDistanceInMiles);
            gMapsThread.Start();

        }
    }
}

//without thread

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;

//namespace ConsoleApplication1
//{
//    class Program
//    {

//        /// <summary>
//        /// returns driving distance in miles
//        /// </summary>
//        /// <param name="origin"></param>
//        /// <param name="destination"></param>
//        /// <returns></returns>
//        public static double GetDrivingDistanceInMiles(string origin, string destination)
//        {
//            string url = @"http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" +
//              origin + "&destinations=" + destination +
//              "&mode=driving&sensor=false&language=en-EN&units=imperial";

//            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

//            //the following line should be wrapped with thread
//            WebResponse response = request.GetResponse();

//            Stream dataStream = response.GetResponseStream();
//            StreamReader sreader = new StreamReader(dataStream);
//            string responsereader = sreader.ReadToEnd();
//            response.Close();

//            XmlDocument xmldoc = new XmlDocument();
//            xmldoc.LoadXml(responsereader);


//            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
//            {
//                XmlNodeList distance = xmldoc.GetElementsByTagName("distance");
//                return Convert.ToDouble(distance[0].ChildNodes[1].InnerText.Replace(" mi", ""));
//            }

//            return 0;
//        }
//        static void Main(string[] args)
//        {
//            string a = "pisga 10 st. jerusalem";
//            string b = "gilgal 42 st. ramat-gan";
//            Console.WriteLine(GetDrivingDistanceInMiles(a, b) * 1.609344);
//        }
//    }
//}
