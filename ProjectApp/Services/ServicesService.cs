using ProjectApp.Context;
using ProjectApp.Form_Uc;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp.Services
{
    
    public class ServicesService
    {
        ProjectContext context = new ProjectContext();
       

        public ServicesService(ProjectContext context)
        {
            this.context = context;
        }

        public void AddService(Service service)
        {
            context.Services.Add(service);
            context.SaveChanges();
        }

        public void UpdateService(int id, int newPrice)
        {
            using (context)
            {
                var service = context.Services.Where(s => s.ServiceId == id).First();
                service.UnitPrice = newPrice;
                context.SaveChanges();
            }
            
        }

        
    }
}
