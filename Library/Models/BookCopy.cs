
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Library.Models
{
    public class BookCopy
    {
        //Multiple copies can be associated with one book
        [Required]
        public virtual Book boken { get; set; }

        [Key]
        public int Id { get; set; }

        //The string displays copyID, title and author
        public override string ToString()
        {
            return String.Format("[{0}] -- {1} by {2}", this.Id, boken.Title, boken.Author.Name);

        }
    }
}
