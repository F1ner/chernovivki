using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aababiy18_3
{
    class Triangle : Figure
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(string name, double side1, double side2, double side3) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }

        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }

        public double Side3
        {
            get { return side3; }
            set { side3 = value; }
        }

        public override double Area()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Side1: {Side1}");
            Console.WriteLine($"Side2: {Side2}");
            Console.WriteLine($"Side3: {Side3}");
        }
    }

}
