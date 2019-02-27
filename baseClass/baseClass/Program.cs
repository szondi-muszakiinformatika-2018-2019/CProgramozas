using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
                Book mybook1 = new Book(); 
             */

            Book[] myBooks;
            string cim;
            string iro;
            int lapszam;

            for (int i = 0;i<5;i++)
            {
                Console.Write("Kérem a(z) {0}. könyv cimét: ",i+1);
                cim = Console.ReadLine();
            }

            
            Console.ReadLine();

        }
    }
}
