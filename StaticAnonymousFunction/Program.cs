using System;
using System.Runtime.CompilerServices;
using System.Collections;

namespace StaticAnonymousFunction
{
    public class MyList
    {
        private int[] data = { 1, 2, 3, 4, 5 };

        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i < data.Length)
            {
                yield return data[i];
                i++;
            }
        }
    }

    public class Demo
    {
        private const string formattedText = "{0} It was developed by Microsoft's Anders Hejlsberg in the year 2000.";
        
        void DisplayText(Func<string, string> func)
        {
            Console.WriteLine(func("C# is a popular programming language."));
        }

        public void Display()
        {
            DisplayText(static text => string.Format(formattedText, text));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            new Demo().Display();

            /*var list = new MyList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            IEnumerator it = list.GetEnumerator();
            it.MoveNext();
            Console.WriteLine(it.Current);
            it.MoveNext();
            Console.WriteLine(it.Current);*/

        }

        string formatString = $"{0}-{1}";

        void GenerateSummary(string[] args)
        {
            string result = GenerateOrderReport(static () =>
            {
                // return formatString; // Will get error
                return $"Order Id: {1}, Order Date: {1}";
            });
            Console.WriteLine(result);
        }

        static string GenerateOrderReport(Func<string> getFormatString)
        {
            var order = new
            {
                Orderid = 1,
                OrderDate = DateTime.Now
            };
            return string.Format(getFormatString(), order.Orderid);
        }

        /*public static IEnumerable<string> ReadLineByLine(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) throw new ArgumentNullException(nameof(fileName));
            foreach (var line in File.ReadAllLines(fileName))
            {
                yield return line;
            }
        }*/
    }
}
