using ProjectApp.Context;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp.Repositories
{
    public class CompanyRepository
    {
        protected readonly ProjectContext context;

        public CompanyRepository(ProjectContext context)
        {
            this.context = context;
        }

        public Company GetCompanyById(int id)
        {
            return (from c in context.Companies where c.CompanyId == id select c).First();
        }

        public List<Company> GetAllCompany()
        {
            return context.Companies.ToList();
        }
        public List<Company> GetAllCompanyDataById(int id)
        {
            return (from c in context.Companies where c.CompanyId == id select c).ToList();
        }
        public List<Company> GetAllCompanyDataByName(string name)
        {
            var company = context.Companies.Where(c => c.CompanyName.Contains(name));
            return company.ToList();
        }

        public void DeleteFilters(TextBox tbxId, TextBox tbxName, DataGridView dgv)
        {
            tbxId.Text = "";
            tbxName.Text = "";
            dgv.DataSource = GetAllCompany();
        }
    }
}
