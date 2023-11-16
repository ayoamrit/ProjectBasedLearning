using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.MainLibrary.Account
{
    public class BorrowedBooks
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private float Price { get; set; }

        public BorrowedBooks(string Title, string Author, float Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }

        public string getTitle()
        {
            return this.Title;
        }

        public string getAuthor()
        {
            return this.Author;
        }

        public float getPrice()
        {
            return this.Price;
        }
    }
}
