using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    /// <summary>
    /// Интерфейс IOneArgOperations поддерживает набор математических операций с одним аргументом
    /// </summary>
    interface IOneArgOperations
    {
        /// <summary>
        /// Метод Sqrt вычисляет корень из числа
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        double Sqrt(double arg);

        /// <summary>
        /// Метод Squaring возводит число в квадрат
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        double Squaring(double arg);

        /// <summary>
        /// Метод InverseNumber находит обратное число
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        double InverseNumber(double arg);

        /// <summary>
        /// Метод NaturalLogarithm вычисляет натуральный логарифм
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        double NaturalLogarithm(double arg);

        /// <summary>
        /// Метод Sinus вычисляет синус числа
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        double Sinus(double arg);

        /// <summary>
        /// Метод Cosinus вычисляет косинус числа
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        double Cosinus(double arg);

        /// <summary>
        /// Метод Tangens вычисляет тангенс числа
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        double Tangens(double arg);

        /// <summary>
        /// Метод Cotangens вычисляет котангенс числа
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        double Cotangens(double arg);
    }
}


