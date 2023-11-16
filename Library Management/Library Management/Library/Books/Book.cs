using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.MainLibrary.Books
{
    public class Book
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private string Author { get; set; }
        private float Price { get; set; }
        private bool HasBorrower { get; set; }
        private List<Borrower> BookBorrower { get; set; }

        public Book(string Title, string Description, string Author, float Price)
        {
            this.Title = Title;
            this.Description = Description;
            this.Author = Author;
            this.Price = Price;
            this.HasBorrower = false;
            this.BookBorrower = new List<Borrower>();
        }

        public Book(string Title, string Description, string Author, float Price, bool HasBorrower, Borrower borrower)
        {
            this.Title = Title;
            this.Description = Description;
            this.Author = Author;
            this.Price = Price;
            this.HasBorrower = HasBorrower;
            this.BookBorrower = new List<Borrower> { borrower };
        }

        public string getTitle()
        {
            return this.Title;
        }

        public string getDescription()
        {
            return this.Description;
        }

        public string getAuthor()
        {
            return this.Author;
        }

        public float getPrice()
        {
            return this.Price;
        }

        public bool getBorrower()
        {
            return this.HasBorrower;
        }

        public List<Borrower> getBorrowerList()
        {
            return this.BookBorrower;
        }
    }
}
