using ProjectApp.Context;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.Services
{
    public class CompanyService
    {
        ProjectContext context;

        public CompanyService(ProjectContext context)
        {
            this.context = context;
        }

        public void AddCompany(Company company)
        {
            context.Companies.Add(company);
            context.SaveChanges();
        }
    }
}
