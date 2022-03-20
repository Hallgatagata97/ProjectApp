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

        public void UpdateCompany(int id, string address, string phone, string email)
        {
            using (context)
            {
                var company = context.Companies.Where(c => c.CompanyId == id).First();
                company.Address = address;
                company.PhoneNumber = phone;
                company.Email = email;
                context.SaveChanges();
            }

        }
    }
}
