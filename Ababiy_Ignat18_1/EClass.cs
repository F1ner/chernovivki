using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy_Ignat18_1
{
    class EClass : DClass
    {
        public override string Privet(string prv)
        {
            return prv;
        }

        public override void Method1()
        {
            Console.WriteLine("");
        }
        public override int Method2(int a, int b)
        {
            return a + b;
        }
    }
}
