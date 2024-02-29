using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aababiy18_3
{
    class Square : Rectangle
    {
        public Square(string name, double side) : base(name, side, side)
        {
        }

        public new double Side
        {
            get { return base.Side1; }
            set { base.Side1 = base.Side2 = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Side: {Side}");
        }
    }

}
