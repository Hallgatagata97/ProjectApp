using ProjectApp.Context;
using ProjectApp.Models;
using ProjectApp.OtherServices;
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
    public partial class UCNewCompany : UserControl
    {
        CompanyService cService;
        ProjectContext context;
        MessageBoxes ms;
        public UCNewCompany()
        {
            InitializeComponent();
            this.context = new ProjectContext();
            this.cService = new CompanyService(context);
            this.ms = new MessageBoxes();
        }

        public DialogResult DialogResult { get; private set; }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(companyNameTbx.Text) && !string.IsNullOrWhiteSpace(phoneNoTbx.Text) && !string.IsNullOrWhiteSpace(taxNoTbx.Text) && !string.IsNullOrWhiteSpace(emailTbx.Text) && !string.IsNullOrWhiteSpace(addressTbx.Text))
            {
                using (ProjectContext context = new ProjectContext())
                {
                    Company company = new Company()
                    {
                        Taxnumber = taxNoTbx.Text,
                        CompanyName = companyNameTbx.Text,
                        Address = addressTbx.Text,
                        PhoneNumber = phoneNoTbx.Text,
                        Email = emailTbx.Text,
                        
                    };
                    cService.AddCompany(company);

                };
               
                ((NewCompanyFrm)this.TopLevelControl).Close();
            }
            else
            {
                ms.WarningMessage("Minden adat kitöltése kötelező!");
             
            }

      
        }
    }
}
