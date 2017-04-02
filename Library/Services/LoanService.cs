
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class LoanService : IService
    {
        LoanRepository _loanRepository;
        MemberRepository _memberRepository;
        BookRepository _bookRepository;
        BookCopyRepository _bookCopyRepository;

        public event EventHandler Updated;

        protected virtual void OnUpdated(object sender, EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        public LoanService(RepositoryFactory repoFactory)
        {
            _loanRepository = repoFactory.GetLoanRepository();
            _memberRepository = repoFactory.GetMemberRepository();
            _bookRepository = repoFactory.GetBookRepository();
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
        }

        //Gets all loans
        public IEnumerable<Loan> All()
        {
            return _loanRepository.All();
        }


        //Make a new loan
        public void MakeLoan(Member mem, Book boo)
        {
            IEnumerable<BookCopy> bokenskopior = (from b in _bookCopyRepository.All() where b.boken == boo select b);

            List<BookCopy> kopiorna = new List<BookCopy>();
            foreach (BookCopy bc in bokenskopior)
            {
                kopiorna.Add(bc);
            }
            foreach (Loan l in _loanRepository.All())
            {
                foreach (BookCopy bc in _bookCopyRepository.All())
                {
                    if (l.aCopy == bc && l.TimeOfReturn == null)
                    {
                        kopiorna.Remove(bc);
                    }
                }
            }

            Loan newloan = new Loan()
            {
                TimeOfLoan = DateTime.Today,
                DueDate = (DateTime.Today).AddDays(15),
                TimeOfReturn = null,
                aMember = mem,
                aCopy = kopiorna[0]
            };
            _loanRepository.Add(newloan);
            OnUpdated(this, EventArgs.Empty);
        }

        //Checks if it is a late return, and acts accordingly
        public double BeforeReturnLoan(Loan loa)
        {
            DateTime today = DateTime.Today;
            double thedays = (today - loa.DueDate).TotalDays;

            double fine = thedays * 10;

            return fine;
        }

        //Returns the book. This means that it will from now on only appear in the list of previously returned books.
        public void ReturnLoan(Loan loa)
        {
            loa.TimeOfReturn = DateTime.Today;
        }


        //All the current loans a member has, i.e those that have not been returned yet
        public IEnumerable<Loan> CurrentLoans(Member mem)
        {
            if (mem != null)
            {
                var loans = (from loan in mem.Loans where loan.TimeOfReturn == null select loan);

                if (loans != null && loans.GetEnumerator().MoveNext())
                {
                    return loans;
                }

                else
                {
                    return new List<Loan>();
                }
            }

            else
            {

                return new List<Loan>();
            }
        }

        //The late books a member currently has
        public IEnumerable<Loan> LoansPassedTheirDueDates(Member mem)
        {
            if (mem != null)
            {
                var loans = (from loan in mem.Loans where DateTime.Today > loan.DueDate select loan);

                if (loans != null && loans.GetEnumerator().MoveNext())
                {
                    return loans;
                }

                else
                {
                    return new List<Loan>();
                }
            }

            else
            {
                return new List<Loan>();
            }
        }

        //The books a member has previously returned
        public IEnumerable<Loan> LoansPreviouslyReturned(Member mem)
        {
            //All previous returned loans
            if (mem != null)
            {
                var loans = (from loan in mem.Loans where loan.TimeOfReturn != null select loan);
                if (loans != null && loans.GetEnumerator().MoveNext())
                {
                    return loans;
                }

                else
                { return new List<Loan>(); }
            }
            else { return new List<Loan>(); }
        }

    }
}
