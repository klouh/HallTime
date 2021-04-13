using System;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Calculation
{
    public interface IStrategyInterploation
    {
        double interpolate(double[] tblvolume,double[] time,double volume);
    }
}
