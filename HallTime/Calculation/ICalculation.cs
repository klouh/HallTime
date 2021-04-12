using System;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Calculation
{
    interface ICalculation
    {
        List calculate(List data, StrategyInterploation strategy);
    }
}
