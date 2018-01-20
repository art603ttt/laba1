using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    //НЕОБЯЗАТЕЛЬНО
    interface IСonvertible
    {
        string ConvertValueToString(double value);

        double ConvertValueToDouble(string value);

    }
}
