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
    public partial class UCAddServiceToProject : UserControl
    {
        ProjectContext context;
        ServiceRepository sRepos;
        MessageBoxes ms;
        public UCAddServiceToProject()
        {
            InitializeComponent();
            this.context = new ProjectContext();
            this.sRepos = new ServiceRepository(context);
            this.ms = new MessageBoxes();
        }

        private void addServiceToLv_Click(object sender, EventArgs e)
        {
            
            var id = int.Parse(serviceIdTbx.Text);
            using (var context = new ProjectContext())
            {
                try
                {
                    ListViewItem item = new ListViewItem($"{serviceIdTbx.Text}");

                    var service = sRepos.GetServiceById(id);
                    //item.SubItems.Add(company.CompanyId.ToString());
                    item.SubItems.Add(service.Name.ToString());
                    item.SubItems.Add(service.UnitPrice.ToString());
                    item.SubItems.Add(service.Unit.ToString());
                    item.SubItems.Add((service.UnitPrice * (float)quantityNud.Value).ToString());
                    item.SubItems.Add(quantityNud.Value.ToString());
                    serviceLv.Items.AddRange(new ListViewItem[] { item });
                }
                catch (Exception)
                {
                    ms.WarningMessage("A megadott Id-val nem találhatók adatok. Kérlek ellenőrizd le a megadott Id-t!");
                  
                }
                
            }
        }

        private void SaveProjectBtn_Click(object sender, EventArgs e)
        {
            

        }
    }
}
