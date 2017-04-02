
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Data.Entity;

namespace Library.Repositories
{
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext _context;

        public AuthorRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public IEnumerable<Author> All() {
            return _context.Authors.ToList();
        }

        public void Add(Author item)
        {
            _context.Authors.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Author item)
        {
            _context.Authors.Remove(item);
            _context.SaveChanges();
        }

        public Author Find(int id)
        {
            var b = (from Author in _context.Authors where Author.Id == id select Author).FirstOrDefault();
            return b;         
        }

        public void Edit(Author item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}
