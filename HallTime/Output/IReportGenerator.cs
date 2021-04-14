using System;
using System.Collections.Generic;
using System.Text;

namespace HallTime.Output
{
    public interface IReportGenerator
    {
        bool generate(string data, string path);
    }
}
