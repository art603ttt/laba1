using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Calculator :ITwoArgOperations, IOneArgOperations
    {
        
        public String Operation { get; set; }
        //public IInputed Inputer { get; private set; }

        //public IOutputed Outputer { get; private set; }
        //public Calculator(IInputed inputer, IOutputed outputer)
        //{
        //    Inputer = inputer;
        //    Outputer = outputer;
        //}
        //TODO realize all classes

        #region realization ITwoArgOperations
        
        /// <summary>
        /// Method Pluses two arguments.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public double Plus(double arg1, double arg2)
        {
            return arg1 + arg2;
        }
        /// <summary>
        /// Method Differences two arguments.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public double Difference(double arg1, double arg2)
        {
            return arg1 - arg2;
        }
        /// <summary>
        /// Method Devizions two arguments.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public double Divizion(double arg1, double arg2)
        {
            return arg1 / arg2;
        }
        /// <summary>
        /// Method Multiplies two arguments.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public double Multiply(double arg1, double arg2)
        {
            return arg1 * arg2;
        }
        /// <summary>
        /// Method Exponentiations two arguments.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public double Exponentiation(double arg1, double arg2)
        {
            return Math.Pow(arg1, arg2);
        }

        #endregion

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
