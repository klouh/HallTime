using System;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Calculation
{
    class LinearInterpolation : IStrategyInterploation
    {
        public double interpolate(double[] tblvolume, double[] tbltime, double volume)
        {
            //
            // We use piecewise linear spline to interpolate f(x)=x^2 sampled 
            // at 5 equidistant nodes on [-1,+1].
            //
            //double[] tblvolume = new double[] { -1.0, -0.5, 0.0, +0.5, +1.0 };
            //double[] tbltime = new double[] { +1.0, 0.25, 0.0, 0.25, +1.0 };
           // double volume = 0.25;
            double time;
            alglib.spline1dinterpolant s;
            // build spline
            alglib.spline1dbuildlinear(tblvolume, tbltime, out s);

            // calculate S(0.25) - it is quite different from 0.25^2=0.0625
            time = alglib.spline1dcalc(s, volume);
            return time;
        }
    }
}
