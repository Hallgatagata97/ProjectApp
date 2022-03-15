
namespace ProjectApp.Form_Uc
{
    partial class UCNewProject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.projectPanelContainer = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.headPnl = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.companyLv = new System.Windows.Forms.ListView();
            this.companyId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taxNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyIdTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCompanyBtn = new System.Windows.Forms.Button();
            this.companyPanel = new System.Windows.Forms.Panel();
            this.projectPanelContainer.SuspendLayout();
            this.headPnl.SuspendLayout();
            this.companyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectPanelContainer
            // 
            this.projectPanelContainer.Controls.Add(this.panelContainer);
            this.projectPanelContainer.Controls.Add(this.headPnl);
            this.projectPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectPanelContainer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.projectPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.projectPanelContainer.Name = "projectPanelContainer";
            this.projectPanelContainer.Size = new System.Drawing.Size(950, 550);
            this.projectPanelContainer.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(10, 174);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(930, 355);
            this.panelContainer.TabIndex = 7;
            // 
            // headPnl
            // 
            this.headPnl.AutoSize = true;
            this.headPnl.BackColor = System.Drawing.Color.White;
            this.headPnl.Controls.Add(this.companyPanel);
            this.headPnl.Controls.Add(this.panel3);
            this.headPnl.Controls.Add(this.label3);
            this.headPnl.Controls.Add(this.companyLv);
            this.headPnl.Location = new System.Drawing.Point(10, 10);
            this.headPnl.Name = "headPnl";
            this.headPnl.Size = new System.Drawing.Size(930, 158);
            this.headPnl.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel4.Location = new System.Drawing.Point(3, 46);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 3);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(20, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 5);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fejadatok";
            // 
            // companyLv
            // 
            this.companyLv.BackColor = System.Drawing.Color.White;
            this.companyLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.companyId,
            this.companyName,
            this.taxNumber,
            this.address,
            this.phoneNumber,
            this.email});
            this.companyLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.companyLv.HideSelection = false;
            this.companyLv.Location = new System.Drawing.Point(3, 107);
            this.companyLv.Name = "companyLv";
            this.companyLv.ShowItemToolTips = true;
            this.companyLv.Size = new System.Drawing.Size(920, 48);
            this.companyLv.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.companyLv.TabIndex = 0;
            this.companyLv.UseCompatibleStateImageBehavior = false;
            this.companyLv.View = System.Windows.Forms.View.Details;
            // 
            // companyId
            // 
            this.companyId.Text = "Cég ID";
            this.companyId.Width = 79;
            // 
            // companyName
            // 
            this.companyName.Text = "Cég neve";
            this.companyName.Width = 190;
            // 
            // taxNumber
            // 
            this.taxNumber.Text = "Adószám";
            this.taxNumber.Width = 125;
            // 
            // address
            // 
            this.address.Text = "Cím";
            this.address.Width = 233;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Telefonszám";
            this.phoneNumber.Width = 144;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 147;
            // 
            // companyIdTbx
            // 
            this.companyIdTbx.BackColor = System.Drawing.Color.AliceBlue;
            this.companyIdTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyIdTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.companyIdTbx.Location = new System.Drawing.Point(3, 33);
            this.companyIdTbx.Name = "companyIdTbx";
            this.companyIdTbx.Size = new System.Drawing.Size(150, 16);
            this.companyIdTbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CéID";
            // 
            // addCompanyBtn
            // 
            this.addCompanyBtn.FlatAppearance.BorderSize = 0;
            this.addCompanyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCompanyBtn.Image = global::ProjectApp.Properties.Resources.add2;
            this.addCompanyBtn.Location = new System.Drawing.Point(158, 22);
            this.addCompanyBtn.Name = "addCompanyBtn";
            this.addCompanyBtn.Size = new System.Drawing.Size(40, 40);
            this.addCompanyBtn.TabIndex = 3;
            this.addCompanyBtn.UseVisualStyleBackColor = true;
            this.addCompanyBtn.Click += new System.EventHandler(this.addCompanyBtn_Click);
            // 
            // companyPanel
            // 
            this.companyPanel.Controls.Add(this.panel4);
            this.companyPanel.Controls.Add(this.addCompanyBtn);
            this.companyPanel.Controls.Add(this.label1);
            this.companyPanel.Controls.Add(this.companyIdTbx);
            this.companyPanel.Location = new System.Drawing.Point(13, 41);
            this.companyPanel.Name = "companyPanel";
            this.companyPanel.Size = new System.Drawing.Size(228, 67);
            this.companyPanel.TabIndex = 0;
            // 
            // UCNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.projectPanelContainer);
            this.Name = "UCNewProject";
            this.Size = new System.Drawing.Size(950, 550);
            this.projectPanelContainer.ResumeLayout(false);
            this.projectPanelContainer.PerformLayout();
            this.headPnl.ResumeLayout(false);
            this.headPnl.PerformLayout();
            this.companyPanel.ResumeLayout(false);
            this.companyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel projectPanelContainer;
        private System.Windows.Forms.ListView companyLv;
        private System.Windows.Forms.ColumnHeader companyId;
        private System.Windows.Forms.ColumnHeader companyName;
        private System.Windows.Forms.ColumnHeader taxNumber;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyIdTbx;
        private System.Windows.Forms.Button addCompanyBtn;
        private System.Windows.Forms.Panel headPnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel companyPanel;
    }
}
