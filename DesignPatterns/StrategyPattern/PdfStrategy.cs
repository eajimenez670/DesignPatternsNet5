using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class PdfStrategy : IStrategy
    {
        public void Export()
        {
            Console.WriteLine("Archivo exportado a PDF");
        }
    }
}
