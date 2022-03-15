using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext():base("MyDb_ProjectApp")
        {
           // Database.SetInitializer<ProjectContext>(new DropCreateDatabaseAlways<ProjectContext>());
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ProjectService> ProjectServices { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }*/
    }
}
