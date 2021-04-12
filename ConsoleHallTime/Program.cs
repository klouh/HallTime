﻿using System;
using System.Collections.Generic;
using ConsoleHallTime;
namespace ConsoleHallTime
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputReader reader = FileInputReader();
            List data = reader.read("./data.txt");
            ICalculation calculation = HallTimeCalculation();
            IReportGenerator generator = TxtReportGenerator();
            generator.generate("./data.xlsx", calculation.calculate(data, LinearInterpolation()));
            Console.WriteLine("Hello World!");
        }
    }
}
