using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.MainLibrary.Books
{
    public class Inventory
    {
        private List<Book> BookInventory { get; set; }
        
        public Inventory(Book BookInventory)
        {
            this.BookInventory.Add(BookInventory);
        }

        public List<Book> getInventory()
        {
            return this.BookInventory;
        }
    }
}
