using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string Taxnumber { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }


        public ICollection<Project> Project { get; set; }

        public override string ToString()
        {
            return $"{CompanyId}{CompanyName}{Taxnumber}{Address}{PhoneNumber}{Email}";
        }
    }
}
