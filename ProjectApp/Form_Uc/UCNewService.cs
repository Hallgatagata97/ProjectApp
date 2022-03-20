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
        UCServices _owner;
      
        ServiceRepository repos;
        ProjectContext context;
        ServicesService sService;
        MessageBoxes ms;
        public UCNewService(UCServices owner)
        {
            _owner = owner;
            
            InitializeComponent();
           
      
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
                    Service service = new Service()
                    {
                        Name = serviceNameTbx.Text,
                        Unit = serviceUnitCbx.Text,
                        UnitPrice = float.Parse(servicePriceNud.Text)
                    };
                    using (context = new ProjectContext())
                    {
                        

                        sService.AddService(service);
                        context.SaveChanges();

                        // _owner.services.Add(service);

                        _owner.dgv.DataSource = repos.GetAllService();
                        //_owner.dgv.DataSource = null;
                        //repos.GetAllService();

                    };

                    

                   //_owner.serviceDgv.DataSource = repos.GetAllService();
                    //_owner.dgv.DataSource = repos.GetAllService();
                    // _owner.RefreshDgv();
                   // _owner.dgv.Refresh();


                    // _owner.RefreshDgv();
                    //_owner.dgv.DataSource = //repos.GetAllService();




                    ((NewServiceFrm)this.TopLevelControl).Close();
                }
                else
                {
                    ms.WarningMessage("Minden adat kitöltése kötelező!");
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                ms.WarningMessage(ex.ToString());//"Minden adat kitöltése kötelező!");
            } 
           
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

