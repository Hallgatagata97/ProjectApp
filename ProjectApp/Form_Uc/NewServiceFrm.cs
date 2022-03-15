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
    public partial class NewServiceFrm : Form
    {
        static NewServiceFrm _obj;
        public static NewServiceFrm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new NewServiceFrm();
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
        public NewServiceFrm()
        {
            InitializeComponent();
            if(!PanelContainer.Controls.ContainsKey("UCNewService"))
            {
                UCNewService uc = new UCNewService();
                uc.Dock = DockStyle.Fill;
                PanelContainer.Controls.Add(uc);
                //PanelContainer.Controls.Add(uc);
            }
            PanelContainer.Controls["UCNewService"].BringToFront();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
