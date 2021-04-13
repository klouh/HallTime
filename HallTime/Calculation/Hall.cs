using HallTime.Calculation;
using System;
using System.Collections.Generic;

namespace HallTime
{
    public class Hall:Element,ICalculation
    {
        bool bKolosniki;
        bool bGigant;
        bool bSmall;
        double volume;
        List<double> tbltime;
        static List<double> tblvolume;
        List<double> tblNotkolosniki;
        List<double> tblkolosniki;
        double time;
        public HashSet<Exit> exits;
        public double height;
        public object calculate(object data, IStrategyInterploation strategy)
        {
            bGigant = (volume > 60000) ? true : false;
            bSmall = (volume < 5000) ? true : false;
            //Если объем помещения более 60000 м куб применение формулы
            if (bGigant)
            {
                time = 0.115 * (Math.Pow(volume, 1d / 3d));
            }
            //иначе интерполяция
            else if (bSmall)
            {
                time = (bKolosniki) ? 1.5 : 2.0;
            }
            //иначе интерполяция
            else
            {
                tbltime = (bKolosniki) ? tblkolosniki : tblNotkolosniki;
                base.NessaryTime= TimeSpan.FromMinutes( strategy.interpolate(tblvolume.ToArray(), tbltime.ToArray(), volume));
            }

            return null;
        }

    }
}
