using ProjectApp.Context;
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
    public partial class ServiceModifyFrm : Form
    {
        ServicesService sService;
        ProjectContext context;
        public ServiceModifyFrm()
        {
            InitializeComponent();
            this.context = new ProjectContext();
            this.sService = new ServicesService(context);
        }
        public Label idLbl
        {
            get { return serviceIdLbl; }
            set { serviceIdLbl = value; }
        }
        public Label nameLbl
        { 
            get { return serviceNameLbl; }
            set { serviceNameLbl = value; }
        }
        public Label unitLbl
        {
            get { return serviceUnitLbl; }
            set { serviceUnitLbl = value; }
        }
        public NumericUpDown priceNud
        {
            get { return servicePriceNud; }
            set { servicePriceNud = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            sService.UpdateService(int.Parse(serviceIdLbl.Text), (int)servicePriceNud.Value);
            UCServices uc = new UCServices();
            uc.RefreshDgv();
        }
    }
}
