using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExtensions;

namespace MathExtensionsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = (a + 1).Abs();
            int c = 2;
            var d = c.Max(3);
            double[] e = new double[] { 1, 2, 3, 4 };

            var f = e.Where(e.GreaterThan(1).And(e.LessThan(4)));
        }
    }
}
