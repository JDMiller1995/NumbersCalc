using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._24.Assignments2
{
    interface ICalculater //made an interface
    {
        int Add(int a, int b); //this and below are the things for my sweet calculator 
        int Subtract(int c, int d);
        double Divide(int e, int f);
        int Multiply(int g, int h);
    }
    class Math : ICalculater //my math class being built with rules
    {
        public int Add(int a, int b) //add function, each one is named accordingly
        {
            int c = 0;
            c = a + b;
            return c;
        }
        public int Subtract(int b, int c)
        {
            int d = 0;
            d = b - c;
            return d;
        }
        public int Multiply(int a, int b)
        {
            int c = 0;
            c = a * b;
            return c;
        }
        public double Divide(int a, int b)
        {
            double c = 0;
            c = Convert.ToDouble(a) / Convert.ToDouble(b); //gotta make sure we give the people ACCURATE NUMBERS! lol
            return c;
        }
    }
}
