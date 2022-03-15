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
    [Table("ProjectService")]
    public class ProjectService
    {
        public ProjectService()
        {
            
            this.Services = new HashSet<Service>();
        }

       [Key]
        
        public int ProjectServiceId { get; set; }
      
       
        public float QuantityPrice { get; set; }
       
        
        public float Quantity { get; set; }
   
        public Project Projects { get; set; }
       
        public virtual ICollection<Service> Services { get; set; }

      
    }
}
