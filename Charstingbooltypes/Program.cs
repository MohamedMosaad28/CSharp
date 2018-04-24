using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charstingbooltypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charmax = char.MaxValue;
            int charmin = char.MinValue;

            char myvar = 'M';
            int myvarvalue = 'M';
            char myvar2 = Convert.ToChar(77);

            Console.WriteLine("max char = {0}  min char = {1}  my character = {2}" +
                "my value character = {3} my conversion value = {4}"
                , charmax, charmin,myvar,myvarvalue,myvar2);

            string mystring = "this my string";
            Console.WriteLine("my string is = {0}", mystring);

            bool mybool = true;
            Console.WriteLine("my bool is {0}", mybool);
            Console.ReadKey();
        }
    }
}
