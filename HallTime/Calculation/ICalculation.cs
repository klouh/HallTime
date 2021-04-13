using System;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Calculation
{
    interface ICalculation
    {
        object calculate(object data, IStrategyInterploation strategy);
    }
}
