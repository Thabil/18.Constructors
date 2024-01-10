using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{   /*classes are for creating more complex data type, eg a book can have a title,
     and pages which are different data types combined*/
    class Book
    {
        public string title;
        public string author;
        public int pages;

        //this method belowis called a constructor, it is called by default when a Book
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
            
            
            
    }   
    

}
