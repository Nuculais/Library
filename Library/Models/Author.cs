
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web;

namespace Library.Models
{
    //The object class Author which contains several properties
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        //An author may have written several books, one to many
        public virtual ICollection<Book> Books { get; set; }


        public override string ToString()
        {
            return String.Format("{0}", this.Name);
        }
    }
}
