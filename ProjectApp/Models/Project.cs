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
    [Table("Projects")]
    public class Project 
    {
        public Project()
        {
            this.Services = new HashSet<Service>();
        }

        [Key]
       
     
        public int ProjectId { get; set; }
   
        public string Status1 { get; set; }
  
        public string Status2 { get; set; }
      
        public DateTime DeadLine { get; set; }
      
        public DateTime Creation_date { get; set; }
       [Column("Companies_CompanyId")]
       
        public Company Company { get; set; }
        
        public ICollection<ProjectService> ProjectService { get; set; }
        
        public ICollection<Service> Services { get; set; }

      
    }
}
