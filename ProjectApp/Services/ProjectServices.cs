using ProjectApp.Context;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.Services
{
    
    public class ProjectServices
    {
        #region context
        ProjectContext context;

        public ProjectServices(ProjectContext context)
        {
            this.context = context;
        }
        #endregion

        public void AddProject(Project project)
        {
            context.Projects.Add(project);
            context.SaveChanges();
        }
    }
}
