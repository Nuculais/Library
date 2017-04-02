
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class BookCopyService : IService
    {
        BookCopyRepository _bookcopyRepository;
        BookRepository _bookRepository;
        LoanRepository _loanRepository;

        public event EventHandler Updated;

        protected virtual void OnUpdated(object sender, EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookcopyRepository = repoFactory.GetBookCopyRepository();
            _bookRepository = repoFactory.GetBookRepository();
            _loanRepository = repoFactory.GetLoanRepository();
        }

        //Gets all book copies
        public IEnumerable<BookCopy> All()
        {
            return _bookcopyRepository.All();
        }

        //Adds book copy
        public void AddBookCopy(Book boo)
        {
            BookCopy newcopy = new BookCopy() { boken = boo };
            _bookcopyRepository.Add(newcopy);
            OnUpdated(this, EventArgs.Empty);
        }

        //Counts the total amount of copies of a given book
        public int TotalCopies(Book boo)
        {
            int total = ((from b in All() where b.boken == boo select b).Count());
            return total;
        }

        //Counts the number of available copies of a given book. (i.e the copies not currently on loan)
        public int AvailableCopies(Book boo)
        {

            int notavail = _loanRepository.All().AsEnumerable()
                .Where(lo => lo.TimeOfReturn == null)
                .Where(lo => lo.aCopy.boken.Id == boo.Id)
                .Count();

            int tot = TotalCopies(boo);

            int avail = tot - notavail;

            return avail;

        }
    }
}
