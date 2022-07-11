﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class PngStrategy : IStrategy
    {
        public void Export()
        {
            Console.WriteLine("Archivo exportado a PNG");
        }
    }
}