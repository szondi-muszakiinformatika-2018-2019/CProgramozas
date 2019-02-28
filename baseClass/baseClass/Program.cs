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

            Book[] myBooks = new Book[5];
            
            string cim;
            string iro;
            int lapszam;
            int konyvszam;
            
            //Bekérjük a könyvek számát
            Console.Write("Kérem a könyvek számát:");
            konyvszam = int.Parse(Console.ReadLine());

            //Adatbekérés
            for (int i = 0;i < konyvszam ;i++)
            {
                //Adatbekérés 
                Console.Write("Kérem a(z) {0}. könyv cimét: ",i+1);
                cim = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. könyv íróját: ", i + 1);
                iro = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. könyv lapjainak számát: ", i + 1);
                lapszam = int.Parse(Console.ReadLine());
                /*
                 * 
                 */
                //Tömbfeltöltés
                myBooks[i] = new Book(cim,iro,lapszam);
               
               

            }
            //adatkiiratás
            Console.WriteLine("A könyvtáram tartalma:");
            for (int i = 0;i<konyvszam;i++)
            {
                Console.WriteLine(myBooks[i].Name);
            }
            Console.ReadLine();

        }
    }
}
