using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les7Task1
{
    abstract class Shape
    {
        abstract public double GetАrea();
        abstract public string GetName();
    }
    class Triangle : Shape//наследование треугольник наследник фигуры
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double GetАrea()
        {
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        public override string GetName()
        {
            return GetType().Name;
        }
    }
    class Circle : Shape
    {
        double r;
        const double PI = 3.14;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double GetАrea()
        {
            {
                double s = PI * r * r;
                return s;
            }
        }
        public override string GetName()
        {
            return GetType().Name;
        }
    }
    class Rectangle : Shape
    {
        double a, b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double GetАrea()
        {
            double s = a * b;
            return s;
        }
        public override string GetName()
        {
            return GetType().Name;
        }
    }
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double a, double b, double c) : base(a, b, c)
        {
        }
    }

    class Square : Rectangle
    {
        public Square(double a) : base(a, a)
        {
        }
    }
}
