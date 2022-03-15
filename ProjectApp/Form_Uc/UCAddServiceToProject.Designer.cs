
namespace ProjectApp.Form_Uc
{
    partial class UCAddServiceToProject
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
            this.serviceLv = new System.Windows.Forms.ListView();
            this.LvServiceId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvQuantityPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serviceIdTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.addServiceToLv = new System.Windows.Forms.Button();
            this.SaveProjectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNud)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceLv
            // 
            this.serviceLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LvServiceId,
            this.LvServiceName,
            this.LvUnitPrice,
            this.LvUnit,
            this.LvQuantityPrice,
            this.LvQuantity});
            this.serviceLv.HideSelection = false;
            this.serviceLv.Location = new System.Drawing.Point(3, 3);
            this.serviceLv.Name = "serviceLv";
            this.serviceLv.Size = new System.Drawing.Size(924, 205);
            this.serviceLv.TabIndex = 0;
            this.serviceLv.UseCompatibleStateImageBehavior = false;
            this.serviceLv.View = System.Windows.Forms.View.Details;
            // 
            // LvServiceId
            // 
            this.LvServiceId.Text = "Szolgáltatás ID";
            this.LvServiceId.Width = 159;
            // 
            // LvServiceName
            // 
            this.LvServiceName.Text = "Szolgáltatás Neve";
            this.LvServiceName.Width = 296;
            // 
            // LvUnitPrice
            // 
            this.LvUnitPrice.Text = "Egységár";
            this.LvUnitPrice.Width = 103;
            // 
            // LvUnit
            // 
            this.LvUnit.Text = "Mennyiségi egység";
            this.LvUnit.Width = 117;
            // 
            // LvQuantityPrice
            // 
            this.LvQuantityPrice.Text = "Össz. ár";
            this.LvQuantityPrice.Width = 124;
            // 
            // LvQuantity
            // 
            this.LvQuantity.Text = "Mennyiség";
            this.LvQuantity.Width = 121;
            // 
            // serviceIdTbx
            // 
            this.serviceIdTbx.Location = new System.Drawing.Point(3, 270);
            this.serviceIdTbx.Name = "serviceIdTbx";
            this.serviceIdTbx.Size = new System.Drawing.Size(184, 20);
            this.serviceIdTbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szolgáltatás ID";
            // 
            // quantityNud
            // 
            this.quantityNud.Location = new System.Drawing.Point(240, 270);
            this.quantityNud.Name = "quantityNud";
            this.quantityNud.Size = new System.Drawing.Size(142, 20);
            this.quantityNud.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mennyiség";
            // 
            // addServiceToLv
            // 
            this.addServiceToLv.FlatAppearance.BorderSize = 0;
            this.addServiceToLv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addServiceToLv.Image = global::ProjectApp.Properties.Resources.add2;
            this.addServiceToLv.Location = new System.Drawing.Point(407, 259);
            this.addServiceToLv.Name = "addServiceToLv";
            this.addServiceToLv.Size = new System.Drawing.Size(40, 40);
            this.addServiceToLv.TabIndex = 5;
            this.addServiceToLv.UseVisualStyleBackColor = true;
            this.addServiceToLv.Click += new System.EventHandler(this.addServiceToLv_Click);
            // 
            // SaveProjectBtn
            // 
            this.SaveProjectBtn.FlatAppearance.BorderSize = 0;
            this.SaveProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProjectBtn.Image = global::ProjectApp.Properties.Resources.next;
            this.SaveProjectBtn.Location = new System.Drawing.Point(887, 312);
            this.SaveProjectBtn.Name = "SaveProjectBtn";
            this.SaveProjectBtn.Size = new System.Drawing.Size(40, 40);
            this.SaveProjectBtn.TabIndex = 9;
            this.SaveProjectBtn.UseVisualStyleBackColor = true;
            this.SaveProjectBtn.Click += new System.EventHandler(this.SaveProjectBtn_Click);
            // 
            // UCAddServiceToProject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.SaveProjectBtn);
            this.Controls.Add(this.addServiceToLv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityNud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serviceIdTbx);
            this.Controls.Add(this.serviceLv);
            this.Name = "UCAddServiceToProject";
            this.Size = new System.Drawing.Size(930, 355);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView serviceLv;
        private System.Windows.Forms.ColumnHeader LvServiceId;
        private System.Windows.Forms.ColumnHeader LvServiceName;
        private System.Windows.Forms.ColumnHeader LvUnitPrice;
        private System.Windows.Forms.ColumnHeader LvUnit;
        private System.Windows.Forms.ColumnHeader LvQuantity;
        private System.Windows.Forms.ColumnHeader LvQuantityPrice;
        private System.Windows.Forms.TextBox serviceIdTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown quantityNud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addServiceToLv;
        private System.Windows.Forms.Button SaveProjectBtn;
    }
}
