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
    
    public partial class NewCompanyFrm : Form
    {
        static NewCompanyFrm _obj;
        public static NewCompanyFrm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new NewCompanyFrm();
                }
                return _obj;
            }
        }
        public Panel PanelContainer
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }

        public Button backBtn
        {
            get { return backButton; }
            set { backButton = value; }
        }
        public NewCompanyFrm()
        {
            InitializeComponent();
            if (!PanelContainer.Controls.ContainsKey("UCNewCompany"))
            {
                UCNewCompany uc = new UCNewCompany();
                uc.Dock = DockStyle.Fill;
                PanelContainer.Controls.Add(uc);
            }
            PanelContainer.Controls["UCNewCompany"].BringToFront();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
