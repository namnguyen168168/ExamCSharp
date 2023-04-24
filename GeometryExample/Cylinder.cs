using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    internal class Cylinder
    {
        private double radius;
        private double height;
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public void Process()
        {
            baseArea = radius * radius * Math.PI;
            lateralArea = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * radius * radius * height;
        }

        public string Result()
        {
            string result = "Cylinder Characteristics\n";
            result += "Radius: " + radius + "\n";
            result += "Height: " + height + "\n";
            result += "Base Area: " + baseArea + "\n";
            result += "Lateral Area: " + lateralArea + "\n";
            result += "Total Area: " + totalArea + "\n";
            result += "Volume: " + volume + "\n";
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the Cylinder:");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the Cylinder:");
            double height = double.Parse(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();

            Console.WriteLine(cylinder.Result());
            Console.ReadLine();
        }
    }
}
