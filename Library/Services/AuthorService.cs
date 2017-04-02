
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class AuthorService : IService
    {

        Book aBook = new Book();
        AuthorRepository _authorRepository;
        BookRepository _bookRepository;

        public event EventHandler Updated;

        protected virtual void OnUpdated(object sender, EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        public AuthorService(RepositoryFactory repoFactory)
        {
            _authorRepository = repoFactory.GetAuthorRepository();
            _bookRepository = repoFactory.GetBookRepository();
        }

        public IEnumerable<Author> All()
        {
            return _authorRepository.All();
        }




        //Returns all the books written by the chosen author
        public IEnumerable<Book> BooksWrittenByAuthor(Author aut)
        {  
            var a = (from Book in _bookRepository.All() where Book.Author == aut select Book);
            return a;
        }

        //Adds an author
        public void AddAuthor(Author aut)
        {

            _authorRepository.Add(aut);
            OnUpdated(this, EventArgs.Empty);
        }

        //Removes an author
        public void RemoveAuthor(Author aut)
        {
            _authorRepository.Remove(aut);
            OnUpdated(this, EventArgs.Empty);
        }

        //Checks if author already exists
        public bool ContainsAuthor(string au)
        {
            string upperAu = au.ToUpper().Trim();

            var check = (from author in All() where author.Name.ToUpper().Trim() == upperAu select author.Name).SingleOrDefault();

            if (check != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //Creates an author
        public Author MakeAuthor(string aut)
        {
            Author newaut = new Author()
            {
                Name = aut,
            };

            AddAuthor(newaut);

            return newaut;

        }

        //Retrieves the author when creating a book object where the author is already in the database
        public Author GetAuthor(string aut)
        {
            string upperAu = aut.ToUpper().Trim();

            var auth = (from author in All() where author.Name.ToUpper().Trim() == upperAu select author).SingleOrDefault();

            return auth;
        }
    
    }

}
