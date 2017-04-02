
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Library.Models
{
    /// <summary>
    /// Book object class with several properties
    /// </summary>
    public class Book 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }       

        public long ISBN { get; set; }
 
        public string Description { get; set; }
 
        //A book has a reference to a author-object and then the
        //Book table will contain a foreign key to the Author table
        public virtual Author Author { get; set; }
        public virtual ICollection<BookCopy> Copy { get; set; }

        //The whole object String displays title, author, ISBN and description
        public override string ToString()
        {
            return String.Format("{0} by {1} -- (ISBN:{2}) -- Summary:{3}", this.Title, this.Author.Name, this.ISBN, this.Description);

        }

        //For displaying only book and author
        public string BookAuthor
        {
            get
            {
                return Title + " by " + Author.Name;
            }
        }
    }
}