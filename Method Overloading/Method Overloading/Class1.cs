using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Circle
    {
        public double radius;

        public readonly double pi = 3.14;

        public double FindArea(double radius)
        {
            return this.pi * (radius * radius);
        }
        public Circle(double radius)
        { 
        this.radius = radius;  
        
        }




    }

    internal class Rectangle
    {

        public double lenght;
        public double width;

        public double Findarea2(double lenght, double width)
        {
            return lenght * width;

        }

        public Rectangle(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;

        }
    }


    internal class Triangle {

        public double Base;
        public double height;

        public double Findarea3(double Base, double height)
        {

            return (Base * height)/2;
        }

        public Triangle(double Base, double height)
        {

            this.Base = Base;
            this.height = height;
        
        
        }
    
    
    
    }
}
