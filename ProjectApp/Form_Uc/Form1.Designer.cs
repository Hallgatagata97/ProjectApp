
namespace ProjectApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.companiesBtn = new System.Windows.Forms.Button();
            this.servicesBtn = new System.Windows.Forms.Button();
            this.projectsBtn = new System.Windows.Forms.Button();
            this.mainPageBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.companiesBtn);
            this.panel1.Controls.Add(this.servicesBtn);
            this.panel1.Controls.Add(this.projectsBtn);
            this.panel1.Controls.Add(this.mainPageBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 600);
            this.panel1.TabIndex = 0;
            // 
            // companiesBtn
            // 
            this.companiesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.companiesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.companiesBtn.FlatAppearance.BorderSize = 0;
            this.companiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companiesBtn.Image = ((System.Drawing.Image)(resources.GetObject("companiesBtn.Image")));
            this.companiesBtn.Location = new System.Drawing.Point(0, 200);
            this.companiesBtn.Name = "companiesBtn";
            this.companiesBtn.Size = new System.Drawing.Size(50, 50);
            this.companiesBtn.TabIndex = 4;
            this.companiesBtn.UseVisualStyleBackColor = true;
            this.companiesBtn.Click += new System.EventHandler(this.companiesBtn_Click);
            // 
            // servicesBtn
            // 
            this.servicesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.servicesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.servicesBtn.FlatAppearance.BorderSize = 0;
            this.servicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesBtn.Image = ((System.Drawing.Image)(resources.GetObject("servicesBtn.Image")));
            this.servicesBtn.Location = new System.Drawing.Point(0, 150);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(50, 50);
            this.servicesBtn.TabIndex = 3;
            this.servicesBtn.UseVisualStyleBackColor = true;
            this.servicesBtn.Click += new System.EventHandler(this.servicesBtn_Click);
            // 
            // projectsBtn
            // 
            this.projectsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.projectsBtn.FlatAppearance.BorderSize = 0;
            this.projectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsBtn.Image = global::ProjectApp.Properties.Resources.projects;
            this.projectsBtn.Location = new System.Drawing.Point(0, 100);
            this.projectsBtn.Name = "projectsBtn";
            this.projectsBtn.Size = new System.Drawing.Size(50, 50);
            this.projectsBtn.TabIndex = 2;
            this.projectsBtn.UseVisualStyleBackColor = true;
            this.projectsBtn.Click += new System.EventHandler(this.projectsBtn_Click);
            // 
            // mainPageBtn
            // 
            this.mainPageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.mainPageBtn.FlatAppearance.BorderSize = 0;
            this.mainPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPageBtn.Image = global::ProjectApp.Properties.Resources.Főoldal;
            this.mainPageBtn.Location = new System.Drawing.Point(0, 50);
            this.mainPageBtn.Name = "mainPageBtn";
            this.mainPageBtn.Size = new System.Drawing.Size(50, 50);
            this.mainPageBtn.TabIndex = 0;
            this.mainPageBtn.UseVisualStyleBackColor = true;
            this.mainPageBtn.Click += new System.EventHandler(this.mainPageBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 50);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(50, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 50);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProjectApp.Properties.Resources.cancel;
            this.button1.Location = new System.Drawing.Point(900, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sinter Project Manager";
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::ProjectApp.Properties.Resources.back;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(50, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(950, 550);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mainPageBtn;
        private System.Windows.Forms.Button companiesBtn;
        private System.Windows.Forms.Button servicesBtn;
        private System.Windows.Forms.Button projectsBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

