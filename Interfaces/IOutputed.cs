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
        /// Метод ShowValue вывод значение аргумента в Textbox
        /// </summary>
        /// <param name="tb_out"></param>
        /// <param name="arg"></param>
        void ShowValue(TextBox tb_out,double arg);

    }
}
