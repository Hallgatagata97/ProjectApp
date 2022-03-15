using ProjectApp.Context;
using ProjectApp.Models;
using ProjectApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp.Form_Uc
{
    public partial class UCHome : UserControl
    {
        ProjectContext context;
        ProjectRepository pRepos;
        public UCHome()
        {
            InitializeComponent();
            this.context = new ProjectContext();
            this.pRepos = new ProjectRepository(context);

        }

        private void newProjectsBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            var project = pRepos.GetProjectByStatus2("új");
          
            item.SubItems.Add(project.ProjectId.ToString());
            item.SubItems.Add(project.Company.CompanyName.ToString());
            item.SubItems.Add(project.Status2.ToString());
           
            
            showResultsLv.Items.AddRange(new ListViewItem[] { item });
            ListView lv = new ListView();
          
        }

        private string[] LvFill(Project item)
        {
            return new string[]
            {
                item.ProjectId.ToString(),
                item.Status2.ToString(),
                item.Company.CompanyId.ToString(),
                item.DeadLine.ToString(),
                item.Creation_date.ToString()

            };
        }
    }
}
