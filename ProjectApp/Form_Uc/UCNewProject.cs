using ProjectApp.Context;
using ProjectApp.Models;
using ProjectApp.OtherServices;
using ProjectApp.Repositories;
using ProjectApp.Services;
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
    public partial class UCNewProject : UserControl
    {
        ProjectContext context;
        ProjectRepository pRepos;
        CompanyRepository cRepos;
        ServiceRepository sRepos;
        ProjectServices pService;
        MessageBoxes ms;
        public UCNewProject()
        {
            InitializeComponent();
            this.context = new ProjectContext();
            this.pRepos = new ProjectRepository(context);
            this.cRepos = new CompanyRepository(context);
            this.sRepos = new ServiceRepository(context);
            this.pService = new ProjectServices(context);
            this.ms = new MessageBoxes();
            //nextBtn.Visible = true;
        }
        private void addCompanyBtn_Click(object sender, EventArgs e)
        {
            var id = int.Parse(companyIdTbx.Text);
            using (var context = new ProjectContext())
            {

                #region LV fill
                try
                {
                    ListViewItem item = new ListViewItem($"{companyIdTbx.Text}");

                    var company = cRepos.GetCompanyById(id);
                    //item.SubItems.Add(company.CompanyId.ToString());
                    item.SubItems.Add(company.CompanyName.ToString());
                    item.SubItems.Add(company.Taxnumber.ToString());
                    item.SubItems.Add(company.Address.ToString());
                    item.SubItems.Add(company.PhoneNumber.ToString());
                    item.SubItems.Add(company.Email.ToString());
                    companyLv.Items.AddRange(new ListViewItem[] { item });
                }
                catch (Exception)
                {

                    ms.WarningMessage("A megadott Cég ID-val nem léteznek adatok!");
                    return;
                }

                #endregion

                #region Új projekt létrehozás


                if (!string.IsNullOrWhiteSpace(companyId.Text))
                {

                    Project project = new Project()
                    {
                        Status1 = "Nyitott",
                        Status2 = "Új",
                        DeadLine = DateTime.Now,
                        Creation_date = DateTime.Now,
                        CompanyId = cRepos.GetCompanyById(int.Parse(companyIdTbx.Text)).CompanyId
                    };

                    pService.AddProject(project);
                }

                else
                {
                    ms.WarningMessage("Cég ID megadása kötelező!");

                }



                UCAddServiceToProject uc = new UCAddServiceToProject();
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
                panelContainer.Controls["UCAddServiceToProject"].BringToFront();

                companyPanel.Visible = false;
                #endregion



            }
        }
    }
}


