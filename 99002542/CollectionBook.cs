using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialConApp
{
    class CollectionBookManager : IBookManager
    {
        HashSet<Book> books = new HashSet<Book>();
        public bool AddNewBook(Book bk)
        {
            return books.Add(bk);
        }

        public bool DeleteBook(int id)
        {
            foreach (Book bk in books)
            {
                if (bk.BookID == id)
                {
                    books.Remove(bk);
                    return true;
                }
            }
            return false;
        }

        public Book[] GetAllBooks(string title)
        {
            //return books.ToList().FindAll((bk) => bk.Title.Contains(title)).ToArray();
            //Create a Temp List<Book> size is 0...
            List<Book> temp = new List<Book>();
            //run thro the Hashset, find the matching condition and add to the TempList...
            foreach (var bk in books)
            {
                if (bk.Title.Contains(title))
                    temp.Add(bk);
            }
            //return the List converted to array of Books.
            return temp.ToArray();
        }

        public bool UpdateBook(Book bk)
        {
            throw new NotImplementedException("Do IT URSELF!!!");
        }
    }


}
