﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp12.Entities.Enums;

namespace ConsoleApp12.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle()
        {
        }

        public Circle(Colors color,double radius) : base(color) 
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
