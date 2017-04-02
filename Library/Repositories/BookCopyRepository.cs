
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Data.Entity;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx) 
        {
            _context = ctx;
        }

        public IEnumerable<BookCopy> All() 
        {
            return _context.Copy.ToList();
        }

        public void Add(BookCopy item)
        {
            _context.Copy.Add(item);
            _context.SaveChanges();
        }

        public void Remove(BookCopy item)
        {
            _context.Copy.Remove(item);
            _context.SaveChanges();
        }

        public BookCopy Find(int id)
        {
            var b = (from copy in _context.Copy where copy.Id == id select copy).FirstOrDefault();
            return b;
        }

        public void Edit(BookCopy item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}
