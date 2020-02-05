using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!\n");

            var b = new Banana();
            var m = new Mango();
            var s = new Strawberry();
            var c = new IceCubes();

            Console.WriteLine(b.Blend());
            Console.WriteLine(m.Blend());
            Console.WriteLine(s.Blend() + "\n");

            List<IBlendable> fuits = new List<IBlendable>() {b, m, s, c};

            foreach(var f in fuits)
            {
                Console.WriteLine(f.Blend());
            }
        }
    }
}
