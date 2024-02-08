using ConsoleApp12.Entities;
using ConsoleApp12.Entities.Enums;
using System.Globalization;
namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            byte n = byte.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nShape #{i+1} data:");
                Console.Write("Rectangle or circle (r / c) ? ");
                string shape = Console.ReadLine().ToLower();

                Console.Write("Color (Black / Red / Blue) ");
                string color = Console.ReadLine();

                if (shape == "r")
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(Enum.Parse<Colors>(color),width,height));
                }
                else if (shape == "c" )
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(Enum.Parse<Colors>(color),radius));
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}
