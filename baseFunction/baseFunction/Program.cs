using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseFunction
{
    class Program
    {
        static void Main(string[] args)
        {

            //Függvény meghívása többször
            Console.WriteLine(baseAdd(5, 6));
            Console.WriteLine(baseMine(18, 6));
            Console.WriteLine(baseMul(18, 6));


            Console.ReadKey();
        }
        //Függvény megvalósítása
        static int baseAdd(int a, int b)
        {
            // int c = a + b;
            return a + b;
        }
        //Függvény megvalósítása
        static int baseMine(int a, int b)
        {
            int c = a - b;
            return c;
        }
        //Függvény megvalósítása
        static int baseMul(int a, int b)
        {
            int c = a * b;
            return c;
        }

    }
}
}
