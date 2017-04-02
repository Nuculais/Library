
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Data.Entity;

namespace Library.Repositories 
{
    public class BookRepository : IRepository<Book, int>
    {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public IEnumerable<Book> All() 
        {
            return _context.Books.ToList();
        }

        public void Add(Book item)
        {
            _context.Books.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Book item)
        {
            _context.Books.Remove(item);
            _context.SaveChanges();
        }

        public Book Find(int id)
        {
            var b = (from Book in _context.Books where Book.Id == id select Book).FirstOrDefault();
            return b;
        }

        public void Edit(Book item)
        {

            {               
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }

        }

    }
}