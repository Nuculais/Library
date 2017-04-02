
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Data.Entity;

namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext _context;

        public LoanRepository(LibraryContext ctx) 
        {
            _context = ctx;
        }

        public IEnumerable<Loan> All() 
        {
            return _context.Loans.ToList();
        }

        public void Add(Loan item)
        {
            _context.Loans.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Loan item)
        {
            _context.Loans.Remove(item);
            _context.SaveChanges();
        }

        public Loan Find(int id)
        {
            var b = (from Loan in _context.Loans where Loan.Id == id select Loan).FirstOrDefault();
            return b;
        }

        public void Edit(Loan item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}
