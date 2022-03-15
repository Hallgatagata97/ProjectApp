using ProjectApp.Context;
using ProjectApp.OtherServices;
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
    public partial class UCProjects : UserControl
    {
        ProjectContext context;
        ProjectRepository repos;
        MessageBoxes ms;
        Exporting export;
        public UCProjects()
        {
            InitializeComponent();
            this.context = new ProjectContext();
            this.repos = new ProjectRepository(context);
            this.ms = new MessageBoxes();
            this.export = new Exporting(context);

            if (!context.Projects.Any())
            {
                noDataLbl.Visible = true;
            }
            else
            {
                noDataLbl.Visible = false;
                projectDgv.DataSource = repos.GetAllProject();
                countLbl.Text = $"Találatok száma: {projectDgv.Rows.Count}";

            }
        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            NewProjectFrm frm = new NewProjectFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
            NewProjectFrm.Instance.backBtn.Visible = true;


        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(projectIdTbx.Text))
                {
                    projectDgv.DataSource = repos.GetAllProjectDataById(int.Parse(projectIdTbx.Text));

                }
                else if (!string.IsNullOrWhiteSpace(statCbx.Text))
                {
                    projectDgv.DataSource = repos.GetAllProjectDataByStatus2(statCbx.SelectedItem.ToString());
                }
                else if (!string.IsNullOrWhiteSpace(deadlineFromDtp.Value.ToString()) && !string.IsNullOrWhiteSpace(deadlineToDtp.Value.ToString()))
                {
                    projectDgv.DataSource = repos.GetAllProjectDataByDeadline(deadlineFromDtp.Value, deadlineToDtp.Value);
                }
                
            }
            catch (Exception)
            {
                ms.WarningMessage("A megadott értékekkel nincs adat a rendszerben! \nEllenőrizd le a bevitt adatokat!");
                
            }
            
            countLbl.Text = $"Találatok száma: {projectDgv.Rows.Count}";
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            export.toPdf(projectDgv, "Projektek listája", "Projektek", new[] { 1.5f, 1.5f, 3f, 4f, 4f, 0f, 0f }, !context.Projects.Any());
        }

        private void projectDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

