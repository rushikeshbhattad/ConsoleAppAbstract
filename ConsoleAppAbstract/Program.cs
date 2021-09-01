﻿using System;

namespace Abstract
{
    abstract class Shape
    {
        public abstract double Area(params double[] dimension);
    }
    class Square : Shape
    {
        public override double Area(params double[] dimension)
        {
            return dimension[0] * dimension[0];
        }
    }
    class Rectangle : Shape
    {
        public override double Area(params double[] dimension)
        {
            return dimension[0];
        }
    }
    class Circle : Shape
    {
        public override double Area(params double[] dimension)
        {
            return Math.PI * dimension[0]*dimension[0];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double d1, d2;
            Console.Write("Enter length of square: ");
            d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of Square: " + new Square().Area(d1));
            Console.Write("Enter length of rectangle: ");
            d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter breadth of rectangle: ");
            d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of Rectangle: " + new Rectangle().Area(d1, d2));
            Console.Write("Enter radius of circle: ");
            d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of Circle: " + new Circle().Area(d1));
            Console.ReadKey();
        }
    }
}