using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MathExtensions
{
    /// <summary>
    /// Provides a set of extension methods that wraps built-in Complex methods 
    /// so they can be used by the MathEnumerable&lt;T&gt; class.
    /// </summary>
    public static class ComplexExtensions
    {

        #region System.Numerics.Complex wrappers

        /// <summary>
        /// Gets the absolute value (or magnitude) of a complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The absolute value of value.
        /// </returns>
        public static double Abs(this Complex value)
        {
            return Complex.Abs(value);
        }

        /// <summary>
        /// Returns the angle that is the arc cosine of the specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number that represents a cosine.
        /// </param>
        /// <returns>
        /// The angle, measured in radians, which is the arc cosine of value.
        /// </returns>
        public static Complex Acos(this Complex value)
        {
            return Complex.Acos(value);
        }

        /// <summary>
        /// Returns the angle that is the arc sine of the specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The angle which is the arc sine of value.
        /// </returns>
        public static Complex Asin(this Complex value)
        {
            return Complex.Asin(value);
        }

        /// <summary>
        /// Returns the angle that is the arc tangent of the specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The angle that is the arc tangent of value.
        /// </returns>
        public static Complex Atan(this Complex value)
        {
            return Complex.Atan(value);
        }

        /// <summary>
        /// Computes the conjugate of a complex number and returns the result.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The conjugate of value.
        /// </returns>
        public static Complex Conjugate(this Complex value)
        {
            return Complex.Conjugate(value);
        }

        /// <summary>
        /// Returns the cosine of the specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The cosine of value.
        /// </returns>
        public static Complex Cos(this Complex value)
        {
            return Complex.Cos(value);
        }

        /// <summary>
        /// Returns the hyperbolic cosine of the specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The hyperbolic cosine of value.
        /// </returns>
        public static Complex Cosh(Complex value)
        {
            return Complex.Cosh(value);
        }

        /// <summary>
        /// Returns e raised to the power specified by a complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number that specifies a power.
        /// </param>
        /// <returns>
        /// The number e raised to the power value.
        /// </returns>
        public static Complex Exp(this Complex value)
        {
            return Complex.Exp(value);
        }

        /// <summary>
        /// Creates a complex number from a point's polar coordinates.
        /// </summary>
        /// <param name="magnitude">
        /// The magnitude, which is the distance from the origin (the intersection of
        /// the x-axis and the y-axis) to the number.
        /// </param>
        /// <param name="phase">
        /// The phase, which is the angle from the line to the horizontal axis, measured
        /// in radians.
        /// </param>
        /// <returns>
        /// A complex number.
        /// </returns>
        public static Complex FromPolarCoordinates(this double magnitude, double phase)
        {
            return Complex.FromPolarCoordinates(magnitude, phase);
        }

        /// <summary>
        /// Returns the natural (base e) logarithm of a specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The natural (base e) logarithm of value.
        /// </returns>
        public static Complex Log(this Complex value)
        {
            return Complex.Log(value);
        }

        /// <summary>
        /// Returns the logarithm of a specified complex number in a specified base.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <param name="baseValue">
        /// The base of the logarithm.
        /// </param>
        /// <returns>
        /// The logarithm of value in base baseValue.
        /// </returns>
        public static Complex Log(this Complex value, double baseValue)
        {
            return Complex.Log(value, baseValue);
        }

        /// <summary>
        /// Returns the base-10 logarithm of a specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The base-10 logarithm of value.
        /// </returns>
        public static Complex Log10(this Complex value)
        {
            return Complex.Log10(value);
        }

        /// <summary>
        /// Returns a specified complex number raised to a power specified by a complex
        /// number.
        /// </summary>
        /// <param name="value">
        /// A complex number to be raised to a power.
        /// </param>
        /// <param name="power">
        /// A complex number that specifies a power.
        /// </param>
        /// <returns>
        /// The complex number value raised to the power power.
        /// </returns>
        public static Complex Pow(this Complex value, Complex power)
        {
            return Complex.Pow(value, power);
        }

        /// <summary>
        /// Returns the multiplicative inverse of a complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The reciprocal of value.
        /// </returns>
        public static Complex Reciprocal(this Complex value)
        {
            return Complex.Reciprocal(value);
        }

        /// <summary>
        /// Returns the sine of the specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The sine of value.
        /// </returns>
        public static Complex Sin(this Complex value)
        {
            return Complex.Sin(value);
        }

        /// <summary>
        /// Returns the hyperbolic sine of the specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The hyperbolic sine of value.
        /// </returns>
        public static Complex Sinh(this Complex value)
        {
            return Complex.Sinh(value);
        }

        /// <summary>
        /// Returns the square root of a specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The square root of value.
        /// </returns>
        public static Complex Sqrt(this Complex value)
        {
            return Complex.Sqrt(value);
        }

        /// <summary>
        /// Returns the tangent of the specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The tangent of value.
        /// </returns>
        public static Complex Tan(this Complex value)
        {
            return Complex.Tan(value);
        }

        /// <summary>
        /// Returns the hyperbolic tangent of the specified complex number.
        /// </summary>
        /// <param name="value">
        /// A complex number.
        /// </param>
        /// <returns>
        /// The hyperbolic tangent of value.
        /// </returns>
        public static Complex Tanh(this Complex value)
        {
            return Complex.Tanh(value);
        }

        #endregion

    }
}
