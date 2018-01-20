using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{/// <summary>
 /// Интерфейс IInputed поддерживает методы для ввода информации
 /// </summary>
    interface IInputed
    {
        void SetValue(double arg1, double arg2);//для операций с 2 аргументами

        void SetValue(double arg);//для операций с 1 аргументом

    }
}
