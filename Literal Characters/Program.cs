using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = 100;
            uint myuvar = 1000;

            float myflvar = 1.5f;
            double mydvar = 100.5;
            decimal mydecvar = 100.5m;

            Console.WriteLine($"My Var {myvar} , My uvar {myuvar}");
            Console.WriteLine($"{myflvar},{mydvar},{mydecvar}");
            Console.ReadKey();
               
        }
    }
}
