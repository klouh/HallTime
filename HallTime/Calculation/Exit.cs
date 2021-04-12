using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HallTime.Calculation
{
    [DataContract]
    class Exit : Element
    {

        Exit()
        {
            [DataMember(Name = "name.exit")]
        //base.name=
        public string name { get; set; }
    }
    }


    }

