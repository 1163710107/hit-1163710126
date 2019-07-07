using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = Console.ReadLine();
            mystring = mystring.Replace("no", "yes");

            Console.WriteLine("the result is");
            Console.WriteLine("{0}", mystring);
            Console.ReadKey();
        }
      

    }
}
