using ProjectApp.Form_Uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Button backBtn
        {
            get { return backButton; }
            set { backButton = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backBtn.Visible = false;
            _obj = this;

            UCHome uc = new UCHome();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

       

        private void backButton_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["UCHome"].BringToFront();
            backBtn.Visible = false;
        }

        private void projectsBtn_Click(object sender, EventArgs e)
        {
            UCProjects uc = new UCProjects();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
          

            panelContainer.Controls["UCProjects"].BringToFront();

        }
        private void servicesBtn_Click(object sender, EventArgs e)
        {
            UCServices uc = new UCServices();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);

            panelContainer.Controls["UCServices"].BringToFront();
        }

        private void mainPageBtn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["UCHome"].BringToFront();
        }

        private void companiesBtn_Click(object sender, EventArgs e)
        {
            UCCompanies uc = new UCCompanies();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            

            panelContainer.Controls["UCCompanies"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
