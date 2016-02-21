using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExtensions
{
    public static class ArrayExtensions
    {


        #region System.Math wrappers

        /// <summary>
        /// Returns the absolute values of a double-precision floating-point number array.
        /// </summary>
        /// <param name="values">
        /// A number in the range System.Double.MinValue≤value≤System.Double.MaxValue.
        /// </param>
        /// <returns>
        /// A double-precision floating-point number, x, such that 0 ≤ x ≤System.Double.MaxValue.
        /// </returns>
        public static double[] Abs(this double[] values)
        {
            return values.Select(d => d.Abs()).ToArray();
        }

        #endregion

        #region "operator" wrappers

        public static double[] Plus(this double[] values, double[] rightHandTerm)
        {
            return values.Zip(rightHandTerm, (d1, d2) => d1 + d2).ToArray();
        }

        public static double[] Plus(this double[] values, double rightHandTerm)
        {
            return values.Select(d => d+rightHandTerm).ToArray();
        }


        public static double[] Minus(this double[] values, double[] rightHandTerm)
        {
            return values.Zip(rightHandTerm, (d1, d2) => d1 - d2).ToArray();
        }

        public static double[] Times(this double[] values, double[] rightHandFactor)
        {
            return values.Zip(rightHandFactor, (d1, d2) => d1 * d2).ToArray();
        }

        public static double[] DividedBy(this double[] values, double[] denominator)
        {
            return values.Zip(denominator, (d1, d2) => d1 / d2).ToArray();
        }

        #endregion

        #region Logical operators


        public static bool[] GreaterThan(this double[] values, double value)
        {
            return values.Select(d => d > value).ToArray();
        }

        public static bool[] LessThan(this double[] values, double value)
        {
            return values.Select(d => d < value).ToArray();
        }

        public static bool[] And(this bool[] values0, bool[] values)
        {
            return values0.Zip(values, (b1, b2) => b1 & b2).ToArray();
        }


        public static double[] Where(this double[] values, bool[] index)
        {
            return values.Zip(index, (d, b) => new { d, b }).Where(a => a.b).Select(a => a.d).ToArray();
        }


        #endregion




    }
}
