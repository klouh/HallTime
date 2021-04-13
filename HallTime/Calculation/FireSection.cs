using System;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Calculation
{
    public class FireSection:Element
    {
        string constractiveClass;
        HashSet<Hall> halls;



        FireSection():base()
        {
            constractiveClass = "C0";
        }
        FireSection(string constractive) : this()
        {
            constractiveClass = constractive;
        }
        void korrection()
        {
            if (constractiveClass == "С1")
            {
                base.korrection = 0.3;
            }
            else if ((constractiveClass == "С2") | (constractiveClass == "С3"))
            {
                base.korrection = 0.5;
            }
            else if ((constractiveClass == "С0"))
            {
                base.korrection = 1.0;
            }
            else
            {
                constractiveClass = "С3";
                base.korrection = 0.5;
                //Ошибка ввода данных.
            }


        }


    }
}
