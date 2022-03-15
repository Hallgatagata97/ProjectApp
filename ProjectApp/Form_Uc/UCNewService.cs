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
    public partial class UCNewService : UserControl
    {
        UCServices servicesUc;
        ServiceRepository repos;
        ProjectContext context;
        ServicesService sService;
        MessageBoxes ms;
        public UCNewService()
        {
            InitializeComponent();
           
            this.servicesUc = new UCServices();
            this.context = new ProjectContext();
            this.repos = new ServiceRepository(context);
            this.sService = new ServicesService(context);
            this.ms = new MessageBoxes();
            modifyBtn.Enabled = false;
            modifyBtn.Visible = false;
        }

        public DialogResult DialogResult { get; private set; }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(serviceNameTbx.Text) && !string.IsNullOrWhiteSpace(serviceUnitCbx.Text) && !string.IsNullOrWhiteSpace((servicePriceNud.Text)))
                {
                    using (context = new ProjectContext())
                    {
                        Service service = new Service()
                        {
                            Name = serviceNameTbx.Text,
                            Unit = serviceUnitCbx.Text,
                            UnitPrice = float.Parse(servicePriceNud.Text)
                        };

                        sService.AddService(service);

                    };
                   
                   
                    ((NewServiceFrm)this.TopLevelControl).Close();
                }
                else
                {
                    ms.WarningMessage("Minden adat kitöltése kötelező!");
                   
                }
            }
            catch (Exception)
            {
                ms.WarningMessage("Minden adat kitöltése kötelező!");
            } 
           
        }
    }
}

