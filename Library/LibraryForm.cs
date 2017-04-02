//Malin Augustsson & Leila Soufi
//Project
//OOP II

using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Library {
    public partial class LibraryForm : Form {

        BookService _bookService;
        AuthorService _authorService;
        LoanService _loanService;
        MemberService _memberService;
        BookCopyService _bookcopyService;

        public LibraryForm() {

            InitializeComponent();


            RepositoryFactory repoFactory = new RepositoryFactory();

            _bookService = new BookService(repoFactory);
            _authorService = new AuthorService(repoFactory);
            _loanService = new LoanService(repoFactory);
            _memberService = new MemberService(repoFactory);
            _bookcopyService = new BookCopyService(repoFactory);


            _bookService.Updated += _bookService_Updated;
            _bookcopyService.Updated += _bookcopyService_Updated;
            _loanService.Updated += _loanService_Updated;
            _memberService.Updated += _memberService_Updated;
            _authorService.Updated += _authorService_Updated;

            LoadLibrary();

        }

        //All listboxes being loaded
        public void LoadLibrary()
        {
            ListAllBooks();
            ListAllMembers();
            ListAllBooksAgain();
            ListAllAuthors();
            DisplayLoans();
        }

        //The scrollbox for loans
        public void DisplayLoans()
        {

            cbLoans.Items.Add("Current Loans");
            cbLoans.Items.Add("Late Loans");
            cbLoans.Items.Add("Returned Loans");

        }

        //List all books on the Books&Author tab
        private void ListAllBooks() 
        {
            lbBooks.Items.Clear();
            foreach (Book book in _bookService.All()) 
            {
                lbBooks.Items.Add(book);
            }
        }

        //Lists all authors on the books&author tab
        private void ListAllAuthors()
        {
            lbAuthors.Items.Clear();

            foreach (Author aut in _authorService.All())
            {
                lbAuthors.Items.Add(aut);
            }
        }

        //List all Books in the Create tab. Makes sure textboxes are cleared as well.
        private void ListAllBooksAgain()
        {
            lbBooksAgain.Items.Clear();
            tBookTitle.Clear();
            tBookAuthor.Clear();
            tBookISBN.Clear();
            tBookDescription.Clear();
            foreach (Book book in _bookService.All())
            {               
                lbBooksAgain.Items.Add(book);            
            }
        }

        //Lists all members in members&loans tab
        public void ListAllMembers()
        {
            lbMembers.Items.Clear();
            foreach (Member member in _memberService.All())
            {
                lbMembers.Items.Add(member);
            }
        }

        //Lists all loans by a specific member
        public void ListLoansByMember(Member member)
        {
            lbMemberLoans.Items.Clear();
            IEnumerable<Loan> loans = _loanService.CurrentLoans(member);
            foreach (Loan loa in loans)
            {
                lbMemberLoans.Items.Add(loa);
            }
        }

        //Lists all available books that can be borrowed
        private void ListAllAvailableBooks()
        {
            lbBooks.Items.Clear();

            foreach (Book boo in _bookService.All())
            {
                if (_bookcopyService.AvailableCopies(boo) > 0)
                {
                    lbBooks.Items.Add(boo);
                }
            }
        }

        //when bookservice is updated
        public void _bookService_Updated(object sender, EventArgs e)
        {
            lbBooks.Items.Clear();
            lbBooksAgain.Items.Clear();
            ListAllBooks();
            ListAllBooksAgain();
        }
        //When authorservice is updated
        public void _authorService_Updated(object sender, EventArgs e)
        {
            lbAuthors.Items.Clear();
            ListAllAuthors();

        }
        //When loanservice is updated
        public void _loanService_Updated(object sender, EventArgs e)
        {
            lbMemberLoans.Items.Clear();

        }
        //When memberservice is updated
        public void _memberService_Updated(object sender, EventArgs e)
        {
            tMemberName.Clear();
            tMemberPersonalID.Clear();
            lbMembers.Items.Clear();
            ListAllMembers();
        }
        //when bookcopyservice is updated
        public void _bookcopyService_Updated(object sender, EventArgs e)
        {
            
        }

        //When you press the make loan button it sends you to the members&loans page with relevant info
        private void MakeLoanButton_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedIndex = 1;

            Book valdaboken = (Book)lbBooks.SelectedItem;
            lChosenBook.Text = valdaboken.Title;

            lAvailableCopies.Text = _bookcopyService.TotalCopies(valdaboken).ToString();
            if (_bookcopyService.AvailableCopies(valdaboken) == 0)
            {
                bConfirmLoan.Enabled = false;

            }
        }

        //For returning a loan
        private void ReturnLoanButton_Click(object sender, EventArgs e)
        {                           
                Loan loanedBook = (Loan)lbMemberLoans.SelectedItem;

                double fine = _loanService.BeforeReturnLoan(loanedBook);
                if (fine > 0)
                {
                    MessageBox.Show("Due to late return, you will be fined " + fine + " kr.");

                    _loanService.ReturnLoan(loanedBook);
                    cbLoans.Text = "Returned Loans";
                }
                else { _loanService.ReturnLoan(loanedBook);
                        cbLoans.Text = "Returned Loans";
                    }
        }

        //For when you select a loan in the loans listbox
        private void cbLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Member medlemmen = (Member)lbMembers.SelectedItem;
            if(cbLoans.SelectedItem.ToString() == "Current Loans")
            {               
                lbMemberLoans.Items.Clear();
                ListLoansByMember(medlemmen);            
            }
            else if(cbLoans.SelectedItem.ToString() == "Late Loans")
            {              
                lbMemberLoans.Items.Clear();

                foreach (Loan loa in _loanService.LoansPassedTheirDueDates(medlemmen))
                {
                    lbMemberLoans.Items.Add(loa);
                }
            }
            else if(cbLoans.SelectedItem.ToString() == "Returned Loans")
            {
                ReturnLoanButton.Enabled = false;
                lbMemberLoans.Items.Clear();

                foreach (Loan loa in _loanService.LoansPreviouslyReturned(medlemmen))
                {
                    lbMemberLoans.Items.Add(loa);
                }
            }
        }

        //When you select a book on the books&author page it shows relevant info
        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

            MakeLoanButton.Enabled = true;
            Book boo = (Book)lbBooks.SelectedItem;

            Author booau = boo.Author;

            bTitle.Text = boo.Title;
            bAuthor.Text = booau.Name;
            bISBN.Text = boo.ISBN.ToString();
            bDescription.Text = boo.Description;

            bCopies.Text = _bookcopyService.TotalCopies(boo).ToString();
            lAvailCopies.Text = _bookcopyService.AvailableCopies(boo).ToString();

            label_bookinfo.Visible = true;
            bTitle.Visible = true;
            bAuthor.Visible = true;
            label_authorinfo.Visible = true;
            bISBN.Visible = true;
            label_isbninfo.Visible = true;
            bDescription.Visible = true;
            label_descriptioninfo.Visible = true;
            bCopies.Visible = true;
            label_totalinfo.Visible = true;
            lAvailCopies.Visible = true;
            label_availableinfo.Visible = true;


            lbAuthors.Items.Clear();
            lbAuthors.Items.Add(booau);

        }


        //For adding a book
        private void AddBookButton_Click(object sender, EventArgs e)
        {

            //Check that textboxes are correctly filled
            if (!String.IsNullOrWhiteSpace(tBookTitle.Text) && !String.IsNullOrWhiteSpace(tBookAuthor.Text) && !String.IsNullOrWhiteSpace(tBookDescription.Text))
            {
                string title = tBookTitle.Text;
                string autho = tBookAuthor.Text;
                string descript = tBookDescription.Text;

                long ISBN;
                //checks that isbn is correctly filled
                if (!long.TryParse(tBookISBN.Text, out ISBN))
                {
                    MessageBox.Show("Invalid ISBN.");
                    return;
                }
                else
                {
                    ISBN = Convert.ToInt64(tBookISBN.Text);
                }

                //If author doesn't already exists, we make an author object as well
                if (_authorService.ContainsAuthor(autho) == true)
                {
                    var aut = _authorService.MakeAuthor(autho);
                    _bookService.MakeBook(title, ISBN, aut, descript);

                    //The Event for _bookservice_updated and _authorservice_updated should be called
                    //update lists insteads.
                }

                else
                {
                    //If author exists, we only need to get the author object
                    var aut = _authorService.GetAuthor(autho);
                    _bookService.MakeBook(title, ISBN, aut, descript);
                    //The Event for bookservice_updated should be called update the lists instead. 
                }
            }
            else
            {
                MessageBox.Show("Please input valid book information.");
            }
        }

        //for making a bookcopy of a book
        private void bAddBookCopy_Click(object sender, EventArgs e)
        {
           if (lbBooksAgain.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book to create a copy of.");
            }

            else
            {
                Book boo = (Book)lbBooksAgain.SelectedItem;
                _bookcopyService.AddBookCopy(boo);

                string avail = _bookcopyService.TotalCopies(boo).ToString();
                MessageBox.Show("You have successfully created a copy of the book " + boo.Title + " by " + boo.Author.Name + ".\r\n There are now " + avail + " total copies of that book.");
             }
           }
        
        //For when you search/select an author, it displays their books
        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeLoanButton.Enabled = false;
            Author aut = (Author)lbAuthors.SelectedItem;
            var theirbooks = (from b in _bookService.All() where b.Author == aut select b);

            lbBooks.Items.Clear();
            foreach(Book b in theirbooks)
            {
                lbBooks.Items.Add(b);
            }
        }

        //For making a loan
        private void bConfirmLoan_Click(object sender, EventArgs e)
        {
            
            Member mem = (Member)lbMembers.SelectedItem;
            Book boo = (Book)lbBooks.SelectedItem;
            _loanService.MakeLoan(mem, boo);

            lAvailableCopies.Text = _bookcopyService.AvailableCopies(boo).ToString();

            cbLoans.Text = "Current Loans";
        }

        //For adding a member
        private void bAddMember_Click(object sender, EventArgs e)
        {
            string memName = tMemberName.Text;
            long memID;
            if (!long.TryParse(tMemberPersonalID.Text, out memID))
            {
                MessageBox.Show("Invalid personal ID.");
                return;
            }
            else
            {
                memID = Convert.ToInt64(tMemberPersonalID.Text);
                _memberService.AddMember(memID, memName);
                
                //Event _memberservice_updated should be  called and update the member lists
            }
        }

        private void lbBooksAgain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        
        //For showing all or available books
        private void bShowBooks_Click(object sender, EventArgs e)
        {
            if(bShowBooks.Text == "Show All Available Books")
            {
                ListAllAvailableBooks();
                ListAllAuthors();
                bShowBooks.Text = "Show All Books";
            }
            else if(bShowBooks.Text == "Show All Books")
            {
                ListAllBooks();
                ListAllAuthors();
                bShowBooks.Text = "Show All Available Books";
            }
            
            
        }

        //When you select a member, it shows if you can make a loan or not dependent on book selected and copies available
        private void lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

                if (lbBooks.SelectedIndex != -1)
                {
                    Book valdaboken = (Book)lbBooks.SelectedItem;
                    lChosenBook.Text = valdaboken.Title;
                    lAvailableCopies.Visible = true;
                    lAvailableCopies.Text = _bookcopyService.AvailableCopies(valdaboken).ToString() + " Copies";

                    if (_bookcopyService.AvailableCopies(valdaboken) > 0)
                    {
                        bConfirmLoan.Enabled = true;
                    }           
                }

                else
                {
                    lChosenBook.Text = "To make a loan, select a book at the Books&Authors page and click 'Make Loan'";
                    lAvailableCopies.Visible = false;
                    bConfirmLoan.Enabled = false;
                }
                
        }

        //Shows if you can return loan or not
        private void lbMemberLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLoans.Text == "Current Loans" || cbLoans.Text == "Late Loans")
            {
                ReturnLoanButton.Enabled = true;
            }
        }

    }
}
