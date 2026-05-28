using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calcolatrice
    {
        public double Somma(double a, double b)
        {
            return a + b;
        }
        public double Sottrazione(double a, double b)
        {
            return a - b;
        }
        public double Moltiplicazione(double a, double b)
        {
            return a * b;
        }
        public double Divisione(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Non è possibile dividere per zero.");
            }
            return a / b;
        }

    }
}
