//Malin Augustsson & Leila Soufi
//Project
//OOP II

using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {
    class BookService : IService
    {
        BookRepository _bookRepository;

        public event EventHandler Updated;

        protected virtual void OnUpdated(object sender, EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        //gets all books
        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        } 

        //adds book
        public void AddBook(Book boo)
        {
          
            _bookRepository.Add(boo);
            OnUpdated(this, EventArgs.Empty);
            
        }

        //removes book
        public void RemoveAuthor(Book boo)
        {
            _bookRepository.Remove(boo);
            OnUpdated(this, EventArgs.Empty);
        }

        //Creates book object
        public void MakeBook(string title, long isbn, Author aut, string descr)
        {
            Book newbook = new Book()
            {
                Title = title,
                ISBN = isbn,
                Author = aut,
                Description = descr
            };

            AddBook(newbook);
        }
    }
}
