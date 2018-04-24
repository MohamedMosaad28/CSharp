using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvalue = 'M';
            int myvalue1 = 'm';

            string mystring = "this my character M";
            string mystring1 = "this my character m";

            Console.WriteLine("{0} value {1} {2} Value {3}", mystring, myvalue, mystring1, myvalue1);
            Console.ReadKey();

        }
    }
}
