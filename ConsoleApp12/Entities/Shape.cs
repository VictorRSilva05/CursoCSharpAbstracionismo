using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp12.Entities.Enums;

namespace ConsoleApp12.Entities
{
    internal abstract class Shape
    {
        public Colors Colors { get; set; }

        public Shape()
        {
        }

        public Shape(Colors colors)
        {
            Colors = colors;
        }

        public abstract double Area();
    }
}
