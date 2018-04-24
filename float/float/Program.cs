using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @float
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin = float.MinValue;
            float flmax = float.MaxValue;

            Console.WriteLine("min Value = {0} max Value = {1}",flmin,flmax);

            float flvar = 1F / 3;
            double dlvar = 1D / 3;
            decimal dcvar = 1M / 3;

            Console.WriteLine("\nfloat value = {0} \ndouble value = {1} \ndeciaml value = {2}", flvar, dlvar, dcvar);

            Console.ReadKey();
        }
    }
}
