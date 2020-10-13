using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// דוגמא לשימוש במבנה הנתונים מילון
/// ניתן להמיר בעזרתו מחרוזות למספר
/// </summary>
namespace solid10a
{
    class ConverterStringNumber
    {
        static string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        static Dictionary<string, int> dictionary = new Dictionary<string, int>();

        static ConverterStringNumber()
        {
            for (int i = 0; i < strings.Length; i++)
            {
                dictionary.Add(strings[i], i);
            }
        }

        public static int ConvertToInt(string str)
        {
            return dictionary[str];
        }

        public static int[] ConvertToIntArray(string str)
        {
            string[] numbers = str.Split(' ', ',');
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = dictionary[numbers[i].Trim()];
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Digit {\"zero\", \"one\", \"two\", \"three\", ...}");
            string str = Console.ReadLine().ToLower();
            if (str.Contains(",") || str.Contains(" "))
            {
                int[] result = ConverterStringNumber.ConvertToIntArray(str);
                for (int i = 0; i < result.Length; i++)
                    Console.Write("{0} ", result[i]);
            }
            else
            {
                Console.Write("{0} ", ConverterStringNumber.ConvertToInt(str));
            }
        }

    }
}
