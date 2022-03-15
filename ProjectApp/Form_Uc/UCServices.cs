using iTextSharp.text;
using iTextSharp.text.pdf;
using ProjectApp.Context;
using ProjectApp.OtherServices;
using ProjectApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProjectApp.Form_Uc
{
    public partial class UCServices : UserControl
    {
        ProjectContext context;
        ServiceRepository repos;
        MessageBoxes ms;
        Exporting export;
        VisualServices vs;
        public UCServices()
        {
            InitializeComponent();
            this.context = new ProjectContext();
            this.repos = new ServiceRepository(context);
            this.ms = new MessageBoxes();
            this.export = new Exporting(context);
            this.vs = new VisualServices();
            if (!context.Services.Any())
            {
                noDataLbl.Visible = true;
            }
            else
            {
                noDataLbl.Visible = false;
                RefreshDgv();
                vs.resultCountLblText(countLbl, serviceDgv);
            }

        }

       public void RefreshDgv()
        {
            serviceDgv.DataSource = repos.GetAllService();
        }

        public DataGridView dgv
        {
            get { return serviceDgv; }
            set { serviceDgv.DataSource = repos.GetAllService(); }
        }

        private void newServiceBtn_Click(object sender, EventArgs e)
        {
            NewServiceFrm frm = new NewServiceFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //dgv.Rows.Add(frm.Service)
                RefreshDgv();
            }
            NewServiceFrm.Instance.backBtn.Visible = true;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(serviceIdTbx.Text))
            {
                serviceDgv.DataSource = repos.GetAllServiceDataById(int.Parse(serviceIdTbx.Text));

            }
            else if (!string.IsNullOrWhiteSpace(serviceNameTbx.Text))
            {
                serviceDgv.DataSource = repos.GetAllServiceDataByName(serviceNameTbx.Text);
            }
            else if (!string.IsNullOrWhiteSpace(priceFromNud.Value.ToString()) && !string.IsNullOrWhiteSpace(priceToNud.Value.ToString()))
            {
                serviceDgv.DataSource = repos.GetServicesByPriceInterval((float)priceFromNud.Value, (float)priceToNud.Value);
            }

            vs.resultCountLblText(countLbl, serviceDgv);
        }

        private void deleteFiltersBtn_Click(object sender, EventArgs e)
        {
            repos.DeleteFilters(serviceIdTbx, serviceNameTbx, priceFromNud, priceToNud, serviceDgv);



        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            export.toPdf(serviceDgv, "Szolgáltatások árlista", "Szolgáltatások", new[] { 2f, 5f, 2f, 2f, 0f, 0f }, !context.Services.Any());
        }

        private void serviceDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            serviceDgv.CurrentRow.Selected = true;

            

        }

        private void serviceDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceModifyFrm frm = new ServiceModifyFrm();
            frm.idLbl.Text = this.serviceDgv.CurrentRow.Cells[0].Value.ToString();
            frm.nameLbl.Text = this.serviceDgv.CurrentRow.Cells[1].Value.ToString();
            frm.unitLbl.Text = this.serviceDgv.CurrentRow.Cells[2].Value.ToString();
            frm.priceNud.Value = Convert.ToDecimal(this.serviceDgv.CurrentRow.Cells[3].Value) ;
            frm.ShowDialog();
               
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
            //FromChildHandle().

        }
    }

}

