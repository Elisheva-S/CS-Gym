using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    internal class Delegate
    {
        public delegate int Calculations(int a, int b);
        public void Run()
        {
            Calculations c;
            c = Calc1;
            int a = c(1,2);
            c = Calc3;
            a=c(3,4);
            CalcTax(200, Calc1);
            CalcTax(200, Calc3);
            CalcTax(200, Calc2);
        }
        public int CalcTax(int price,Calculations c)
        {
            return (c(price,2));
        }
        public int Calc1(int a,int b)
        {
            return a + b; 
        }
        public int Calc2(int a, int b)
        {
            return a * b;
        }
        public int Calc3(int a, int b)
        {
            return a - b;
        }
    }
}
