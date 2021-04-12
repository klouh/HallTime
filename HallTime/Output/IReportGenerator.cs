using System;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Output
{
    interface IReportGenerator
    {
        void generate(string path, string data);
    }
}
