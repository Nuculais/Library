
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Data.Entity;

namespace Library.Repositories
{
   public class MemberRepository : IRepository<Member, int>
    {
        LibraryContext _context;

        public MemberRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public IEnumerable<Member> All() {
            return _context.Members.Include(l => l.Loans).ToList();
        }

        public void Add(Member item)
        {
            _context.Members.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Member item)
        {
            _context.Members.Remove(item);
            _context.SaveChanges();
        }

        public Member Find(int id)
        {
            var b = (from Member in _context.Members where Member.Id == id select Member).FirstOrDefault();          
            return b;
        }

        public void Edit(Member item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}
