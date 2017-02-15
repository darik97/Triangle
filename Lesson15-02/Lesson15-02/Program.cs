using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var listDouble = new List<double>();
            var dict = new Dictionary<int, string>();
            var array = new int[5];

            //var mylist = new MyList();
            //mylist.Add(1);
            //mylist.Add(2);
            //mylist.Add(3);

            try
            {
                var x = TryDivideXbyY(1, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int TryDivideXbyY(int x, int y)
        {
            if (y == 0)
            {
                throw new Exception();
                throw new ArgumentException("Division by zero");
            }
            else
            {
                return x / y;
            }
        }
    }
}
