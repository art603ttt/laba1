using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{/// <summary>
 /// Интерфейс ITwoArgOperations поддерживает набор математических операций с двумя аргументами
 /// </summary>
    public interface ITwoArgOperations
    {
       
        /// <summary>
        /// Метод Plus вычисляет сумму двух чисел
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        double Plus(double arg1, double arg2);

        /// <summary>
        /// Метод Difference вычисляет разность двух чисел
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        double Difference(double arg1, double arg2);

        /// <summary>
        /// Метод Divizion вычисляет результат деления одного числа на другое
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        double Divizion(double arg1, double arg2);

        /// <summary>
        /// Метод Multiply вычисляет произведение двух чисел
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        double Multiply(double arg1, double arg2);

        /// <summary>
        /// Метод Exponentiation вычисляет результат возведения одного числа в степень равную другому числу
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        double Exponentiation(double arg1, double arg2);
    }
}
