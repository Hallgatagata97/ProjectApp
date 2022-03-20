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
    
    public partial class CompanyModifyFrm : Form
    {
        CompanyService cService;
        ProjectContext context;
        UCCompanies uc; 
        public CompanyModifyFrm()
        {
            InitializeComponent();
            this.context = new ProjectContext();
            this.cService = new CompanyService(context);
            this.uc = new UCCompanies();
        }
        public Label idLbl
        {
            get { return companyIdLbl; }
            set { companyIdLbl = value; }
        }

        public Label nameLbl
        {
            get { return companyNameLbl; }
            set { companyNameLbl = value; }
        }

        public Label taxLbl
        {
            get { return taxNumberLbl; }
            set { taxNumberLbl = value; }
        }

        public TextBox addressTbx
        {
            get { return companyAddressTbx; }
            set { companyAddressTbx = value; }
        }

        public TextBox phoneTbx
        {
            get { return phoneNoTbx; }
            set { phoneNoTbx = value; }
        }

        public TextBox emailAddressTbx
        {
            get { return emailTbx; }
            set { emailTbx = value; }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            cService.UpdateCompany(int.Parse(companyIdLbl.Text), companyAddressTbx.Text, phoneNoTbx.Text, emailTbx.Text);
            
            uc.RefreshDgv();
        }
    }
}
