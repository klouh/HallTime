using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HallTime.Calculation
{
   // [DataContract]
    public class Exit : Element
    {
        double level;
        double distanceToCeil;
        
        private Exit(Hall el):base(el)
        {
            
            level = 0.0;
            //  [DataMember(Name = "name.exit")]
            //base.name=
            distanceToCeil = ((Hall)parent).height - level;
            if (distanceToCeil == ((Hall)parent).height * 0.3)
            {
                base.korrection = 0.35;
            }
            else if (distanceToCeil == ((Hall)parent).height * 0.5)
            {
                base.korrection = 0.65;
            }
            else
            {
                base.korrection = 1.0;
            }
        }
    }


    }

