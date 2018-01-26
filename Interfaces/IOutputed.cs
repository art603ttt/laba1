using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;
namespace calc
{
    /// <summary>
    /// Интерфейс IOutputed поддерживает методы для вывода информации
    /// </summary>
    interface IOutputed
    {
        /// <summary>
        /// Метод ShowValue возращает результат вычисления
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        string ShowValue(double arg);

    }
}
