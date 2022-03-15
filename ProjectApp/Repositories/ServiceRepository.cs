using ProjectApp.Context;
using ProjectApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp.Repositories
{
    public class ServiceRepository : IQueryable
    {
        #region context
        protected readonly ProjectContext context;

        public ServiceRepository(ProjectContext context)
        {
            this.context = context;
        }
        #endregion

        public Service GetServiceById(int id)
        {
            return (from s in context.Services where s.ServiceId == id select s).First();
        }

        #region Lists
        public List<Service> GetAllService()
        {
            return context.Services.ToList();
        }
        public List<Service> GetAllServiceDataById(int id)
        {
            return (from s in context.Services where s.ServiceId == id select s).ToList();
        }

        public List<Service> GetAllServiceDataByName(string name)
        {
            var service = context.Services.Where(s => s.Name.Contains(name));
            return service.ToList();
        }
        public List<Service> GetServicesByPriceInterval(float from, float to)
        {
            var service = context.Services.Where
                (s => s.UnitPrice >= from &&
                s.UnitPrice <= to);
            return service.ToList();
        }
        #endregion


        public void DeleteFilters(TextBox tbxId, TextBox tbxName, NumericUpDown nudPriceFrom, NumericUpDown nudPriceTo, DataGridView dgv)
        {

            tbxId.Text = "";
            tbxName.Text = "";
            nudPriceFrom.Value = 0;
            nudPriceTo.Value = 0;
            dgv.DataSource = GetAllService();
        }



        #region Automatic Interface Imlementations
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public Expression Expression => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();
        #endregion
        
    }
}
