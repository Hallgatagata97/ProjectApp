using ProjectApp.Context;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.Repositories
{
    public class ProjectRepository
    {
        protected readonly ProjectContext context;

        public ProjectRepository(ProjectContext context)
        {
            this.context = context;
        }
        public Project GetProjectByStatus2(string status)
        {
            return (from p in context.Projects where p.Status2 == status select p).FirstOrDefault();
        }
        #region Lists
        public List<Project> GetAllProject()
        {
            return context.Projects.ToList();
        }

        public List<Project> GetAllProjectDataById(int id)
        {
            return (from p in context.Projects where p.ProjectId == id select p).ToList();
        }

        public List<Project> GetAllProjectDataByStatus2(string status)
        {
            var project = context.Projects.Where(p => p.Status2.Contains(status));
            return project.ToList();
        }

        public List<Project> GetAllProjectDataByDeadline(DateTime from, DateTime to)
        {
            var project = context.Projects.Where
                (p => p.DeadLine >= from &&
                p.DeadLine <= to);
            return project.ToList();
        }

        public List<Project> GetNewProjects(string stat)
        {
            var project = context.Projects.Where
                (p => p.Status2.Equals(stat));
            return project.ToList();
        }
        #endregion


    }
}
