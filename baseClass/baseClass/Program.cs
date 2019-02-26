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

            Book myBook = new Book();
            myBook.title = "Oroszlánkölykök";
            myBook.author = "Irvin Shaw";
            myBook.pages = 400;


            Console.WriteLine("Cime: {0}", myBook.title);
            Console.WriteLine("Szerző: {0}", myBook.author);
            Console.WriteLine("Szerző: {0}", myBook.author);
            Console.ReadLine();

        }
    }
}
