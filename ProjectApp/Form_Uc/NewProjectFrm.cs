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
    public partial class NewProjectFrm : Form
    {
        static NewProjectFrm _obj;
        public static NewProjectFrm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new NewProjectFrm();
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
        public NewProjectFrm()
        {
            InitializeComponent();
            if (!PanelContainer.Controls.ContainsKey("UCNewProject"))
            {
                UCNewProject uc = new UCNewProject();
                uc.Dock = DockStyle.Fill;
                PanelContainer.Controls.Add(uc);
            }
            PanelContainer.Controls["UCNewProject"].BringToFront();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
