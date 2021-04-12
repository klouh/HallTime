using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Input
{
    interface IInputReader
    {
        IList read(string path);
    }
}
