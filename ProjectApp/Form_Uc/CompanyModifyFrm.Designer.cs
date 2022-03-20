
namespace ProjectApp.Form_Uc
{
    partial class CompanyModifyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyModifyFrm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.companyAddressTbx = new System.Windows.Forms.TextBox();
            this.phoneNoTbx = new System.Windows.Forms.TextBox();
            this.emailTbx = new System.Windows.Forms.TextBox();
            this.companyNameLbl = new System.Windows.Forms.Label();
            this.taxNumberLbl = new System.Windows.Forms.Label();
            this.companyIdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(475, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(464, 196);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(25, 25);
            this.saveBtn.TabIndex = 24;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(433, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cég neve";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(26, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Adószám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cím*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(26, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Telefonszám*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(26, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Email cím*";
            // 
            // companyAddressTbx
            // 
            this.companyAddressTbx.BackColor = System.Drawing.Color.AliceBlue;
            this.companyAddressTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyAddressTbx.Location = new System.Drawing.Point(126, 117);
            this.companyAddressTbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyAddressTbx.Name = "companyAddressTbx";
            this.companyAddressTbx.Size = new System.Drawing.Size(276, 14);
            this.companyAddressTbx.TabIndex = 30;
            // 
            // phoneNoTbx
            // 
            this.phoneNoTbx.BackColor = System.Drawing.Color.AliceBlue;
            this.phoneNoTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNoTbx.Location = new System.Drawing.Point(126, 158);
            this.phoneNoTbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneNoTbx.Name = "phoneNoTbx";
            this.phoneNoTbx.Size = new System.Drawing.Size(276, 14);
            this.phoneNoTbx.TabIndex = 31;
            // 
            // emailTbx
            // 
            this.emailTbx.BackColor = System.Drawing.Color.AliceBlue;
            this.emailTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTbx.Location = new System.Drawing.Point(126, 198);
            this.emailTbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(276, 14);
            this.emailTbx.TabIndex = 32;
            // 
            // companyNameLbl
            // 
            this.companyNameLbl.AutoSize = true;
            this.companyNameLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.companyNameLbl.ForeColor = System.Drawing.Color.AliceBlue;
            this.companyNameLbl.Location = new System.Drawing.Point(123, 44);
            this.companyNameLbl.Name = "companyNameLbl";
            this.companyNameLbl.Size = new System.Drawing.Size(32, 17);
            this.companyNameLbl.TabIndex = 34;
            this.companyNameLbl.Text = "Text";
            // 
            // taxNumberLbl
            // 
            this.taxNumberLbl.AutoSize = true;
            this.taxNumberLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taxNumberLbl.ForeColor = System.Drawing.Color.AliceBlue;
            this.taxNumberLbl.Location = new System.Drawing.Point(123, 79);
            this.taxNumberLbl.Name = "taxNumberLbl";
            this.taxNumberLbl.Size = new System.Drawing.Size(32, 17);
            this.taxNumberLbl.TabIndex = 33;
            this.taxNumberLbl.Text = "Text";
            // 
            // companyIdLbl
            // 
            this.companyIdLbl.AutoSize = true;
            this.companyIdLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.companyIdLbl.ForeColor = System.Drawing.Color.AliceBlue;
            this.companyIdLbl.Location = new System.Drawing.Point(26, 9);
            this.companyIdLbl.Name = "companyIdLbl";
            this.companyIdLbl.Size = new System.Drawing.Size(33, 16);
            this.companyIdLbl.TabIndex = 35;
            this.companyIdLbl.Text = "Text";
            // 
            // CompanyModifyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(500, 234);
            this.Controls.Add(this.companyIdLbl);
            this.Controls.Add(this.companyNameLbl);
            this.Controls.Add(this.taxNumberLbl);
            this.Controls.Add(this.emailTbx);
            this.Controls.Add(this.phoneNoTbx);
            this.Controls.Add(this.companyAddressTbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompanyModifyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyModifyFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox companyAddressTbx;
        private System.Windows.Forms.TextBox phoneNoTbx;
        private System.Windows.Forms.TextBox emailTbx;
        private System.Windows.Forms.Label companyNameLbl;
        private System.Windows.Forms.Label taxNumberLbl;
        private System.Windows.Forms.Label companyIdLbl;
    }
}