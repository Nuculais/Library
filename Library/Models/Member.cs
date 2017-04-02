
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
    /// <summary>
    /// Member-object class with several properties
    /// </summary>
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public long personalID { get; set; }

        public string Name { get; set; }


        //A member could have zero to many loans
        public List<Loan> Loans { get; set; }

        public override string ToString()
        {
            return String.Format("{1} (PersonalId:{0})", this.personalID, this.Name);
        }
    }
}
