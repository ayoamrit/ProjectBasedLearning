using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Management.MainLibrary.Books;

namespace Library_Management.MainLibrary
{
    public class Library
    {

        public Library()
        {
            Borrower borrower = new Borrower("Amrit@gmail.com");

            Book book = new Book("Harry Potter", "Jump Into The Magical World of Wizards", "J.K Rowling", 23.3f, true, borrower);


            Console.WriteLine(book.getTitle());
        }
    }
}
