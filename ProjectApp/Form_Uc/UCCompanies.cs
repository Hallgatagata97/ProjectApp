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
    public partial class UCCompanies : UserControl
    {
        ProjectContext context;
        CompanyRepository repos;
        Exporting export;
        VisualServices vs;
        public UCCompanies()
        {
            InitializeComponent();
            this.context = new ProjectContext();
            this.repos = new CompanyRepository(context);
            this.export = new Exporting(context);
            vs = new VisualServices();
            if (!context.Companies.Any())
            {
                noDataLbl.Visible = true;
            }
            else
            {
                noDataLbl.Visible = false;
                RefreshDgv();
                vs.resultCountLblText(countLbl, companyDgv);
                //countLbl.Text = $"Találatok száma: {companyDgv.Rows.Count}";
            }
        }

        public void RefreshDgv()
        {
            companyDgv.DataSource = repos.GetAllCompany();
        }
        private void newCompanyBtn_Click(object sender, EventArgs e)
        {
            NewCompanyFrm frm = new NewCompanyFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshDgv();
            }
            NewCompanyFrm.Instance.backBtn.Visible = true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(companyIdTbx.Text))
            {
                companyDgv.DataSource = repos.GetAllCompanyDataById(int.Parse(companyIdTbx.Text));
            }
            else if (!string.IsNullOrWhiteSpace(companyNameTbx.Text))
            {
                companyDgv.DataSource = repos.GetAllCompanyDataByName(companyNameTbx.Text);
            }
            vs.resultCountLblText(countLbl, companyDgv);
            //countLbl.Text = $"Találatok száma: {companyDgv.Rows.Count}";
        }

        private void deleteFilterBtn_Click(object sender, EventArgs e)
        {
            repos.DeleteFilters(companyIdTbx, companyNameTbx, companyDgv);
            vs.resultCountLblText(countLbl, companyDgv);
            //countLbl.Text = $"Találatok száma: {companyDgv.Rows.Count}";
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            export.toPdf(companyDgv, "Ügyfél lista", "Ügyfelek", new[] { 1.5f, 4f, 4f, 4f, 0f, 0f }, !context.Companies.Any());
        }

        private void companyDgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CompanyModifyFrm frm = new CompanyModifyFrm();
            frm.idLbl.Text = this.companyDgv.CurrentRow.Cells[0].Value.ToString();
            frm.nameLbl.Text = this.companyDgv.CurrentRow.Cells[1].Value.ToString();
            frm.phoneTbx.Text = this.companyDgv.CurrentRow.Cells[2].Value.ToString();
            frm.emailAddressTbx.Text = this.companyDgv.CurrentRow.Cells[3].Value.ToString();
            frm.taxLbl.Text = this.companyDgv.CurrentRow.Cells[4].Value.ToString();
            
            frm.ShowDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void companyDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
