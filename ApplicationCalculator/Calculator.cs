using System;
using calc;

namespace NewProject
{
    class Calculator : IOneArgOperations
    {
        #region realization IOneArgOperations
        /// <summary>
        /// Returns the factorial of a specified number.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public double Factorial(double arg)
        {
            return (arg == 0) ? 1 : arg * Factorial(arg - 1);
        }
        /// <summary>
        /// Returns the square root of a specified number.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public double Sqrt(double arg)
        {
            return Math.Sqrt(arg);
        }
        /// <summary>
        ///   Returns the squar of a specified number.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public double Squaring(double arg)
        {

            return arg * arg;
        }
        /// <summary>
        /// Returns the Inverse of a specified number.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public double InverseNumber(double arg)
        {
            return 1 / arg;
        }
        /// <summary>
        /// Returns the natural (base e) logarithm of a specified number.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public double NaturalLogarithm(double arg)
        {

            return Math.Log(arg);
        }
        /// <summary>
        /// Returns the sinus of the specified angle.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public double Sinus(double arg)
        {
            return Math.Sin(arg);
        }
        /// <summary>
        /// Returns the cosine of the specified angle.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public double Cosinus(double arg)
        {
            return Math.Cos(arg);
        }
        /// <summary>
        /// Returns the tangens of the specified angle.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public double Tangens(double arg)
        {
            return Math.Tan(arg);
        }
        /// <summary>
        /// Returns the cotangens of the specified angle.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public double Cotangens(double arg)
        {
            return 1 / Tangens(arg);
        }
        #endregion
    }
}
