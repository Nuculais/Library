
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Data.Entity;

namespace Library.Models
{
    //Loan object class
    public class Loan
    {
        public virtual Book aBook { get; set; }

        [Required]
        public virtual Member aMember { get; set; }

        [Required]
        public virtual BookCopy aCopy { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public Nullable<DateTime> TimeOfReturn { get; set; }


        public override string ToString()
        {
            return String.Format("Borrowed by: {3} -- Time of Loan: {0} -- DueDate {1} -- CopyNr: {2}", this.TimeOfLoan, this.DueDate, this.aCopy.Id, aMember.Name);
        }
    }
}
