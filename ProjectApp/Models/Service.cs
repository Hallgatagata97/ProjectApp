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
    //[Table("Service")]
    public class Service
    {
        public Service()
        {
            this.Projects = new HashSet<Project>();
           
        }

        [Key]
        
       
        public int ServiceId { get; set; }
       
        public string Name { get; set; }
       
        public string Unit { get; set; }
       
        public float UnitPrice { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<ProjectService> ProjectService { get; set; }

        
    }
}
