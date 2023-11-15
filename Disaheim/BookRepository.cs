using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            Book? locatedBook = null;

            // Delegate method ----------------------------------
            //locatedBook = _books.Find(x => x.ItemId == itemId);
            //return locatedBook;
            // --------------------------------------------------

            //// Simple method ----------------------------------
            //if (_books != null)
            //{
            //    for (int b = 0; b < _books.Count; b++)
            //    {
            //        if (_books[b] != null && _books[b].ItemId == itemId)
            //        {
            //            return _books[b];
            //        }
            //    }
            //}
            //// ------------------------------------------------

            // Alternative --------------------------------------
            foreach (Book b in _books)
            {
                if (b.ItemId == itemId)
                    locatedBook = b;
            }
            return locatedBook;
            // --------------------------------------------------
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (Book book in _books)
            {
                total += book.Price;
            }
            return total;
        }
    }
}
