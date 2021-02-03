using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opit
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo = double.Parse(Console.ReadLine());
            if (chislo >= -9223372036854775808 && chislo <= 9223372036854775807)
            { Console.WriteLine("integer"); }
                    else
            {
                Console.WriteLine("realno"); }
        }
    }
}
