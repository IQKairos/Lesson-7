using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les8Task1Task2
{

    class program
    {
        static void Main(string[] args)
        {
            Shape f1,f2;
            f1 = new IsoscelesTriangle(10, 10, 10);
            double a = f1.GetАrea();
            string b = f1.GetName();

            f2 = new Square(10);
            double a1 = f2.GetАrea();
            string a2 = f2.GetName();
        }
    }
}
