using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseClass
{
    class Book
    {
        public string Name;
        public string Author;
        private int Pages;
        
        public int pages
        {
            get { return Pages; }
            set
            {
                if (value < 0)
                    throw new Exception("Invalid Pages value");
            }
        }


        //Konstruktor - minden objektum létrehozásakor lefut egyszer
        public Book(string aName,string aAuthor, int aPages)
         {

             Name = aName;
             Author = aAuthor;
            if(aPages > 0)
             Pages = aPages;
            else
                throw new Exception("Invalid Pages value");

        }
        

    }
}
