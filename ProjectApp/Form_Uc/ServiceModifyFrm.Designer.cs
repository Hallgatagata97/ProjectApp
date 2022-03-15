
namespace ProjectApp.Form_Uc
{
    partial class ServiceModifyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceModifyFrm));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.servicePriceNud = new System.Windows.Forms.NumericUpDown();
            this.serviceUnitLbl = new System.Windows.Forms.Label();
            this.serviceNameLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.serviceIdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicePriceNud)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(297, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Szolgáltatás neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Szolgáltatás ára";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mennyiségi egység:";
            // 
            // servicePriceNud
            // 
            this.servicePriceNud.BackColor = System.Drawing.Color.AliceBlue;
            this.servicePriceNud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicePriceNud.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.servicePriceNud.Location = new System.Drawing.Point(145, 109);
            this.servicePriceNud.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.servicePriceNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.servicePriceNud.Name = "servicePriceNud";
            this.servicePriceNud.Size = new System.Drawing.Size(103, 19);
            this.servicePriceNud.TabIndex = 16;
            this.servicePriceNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // serviceUnitLbl
            // 
            this.serviceUnitLbl.AutoSize = true;
            this.serviceUnitLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serviceUnitLbl.ForeColor = System.Drawing.Color.AliceBlue;
            this.serviceUnitLbl.Location = new System.Drawing.Point(142, 75);
            this.serviceUnitLbl.Name = "serviceUnitLbl";
            this.serviceUnitLbl.Size = new System.Drawing.Size(32, 17);
            this.serviceUnitLbl.TabIndex = 19;
            this.serviceUnitLbl.Text = "Text";
            // 
            // serviceNameLbl
            // 
            this.serviceNameLbl.AutoSize = true;
            this.serviceNameLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serviceNameLbl.ForeColor = System.Drawing.Color.AliceBlue;
            this.serviceNameLbl.Location = new System.Drawing.Point(142, 40);
            this.serviceNameLbl.Name = "serviceNameLbl";
            this.serviceNameLbl.Size = new System.Drawing.Size(32, 17);
            this.serviceNameLbl.TabIndex = 20;
            this.serviceNameLbl.Text = "Text";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(266, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(297, 108);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(25, 25);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // serviceIdLbl
            // 
            this.serviceIdLbl.AutoSize = true;
            this.serviceIdLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serviceIdLbl.ForeColor = System.Drawing.Color.AliceBlue;
            this.serviceIdLbl.Location = new System.Drawing.Point(10, 10);
            this.serviceIdLbl.Name = "serviceIdLbl";
            this.serviceIdLbl.Size = new System.Drawing.Size(33, 16);
            this.serviceIdLbl.TabIndex = 23;
            this.serviceIdLbl.Text = "Text";
            // 
            // ServiceModifyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(330, 140);
            this.Controls.Add(this.serviceIdLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.serviceNameLbl);
            this.Controls.Add(this.serviceUnitLbl);
            this.Controls.Add(this.servicePriceNud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceModifyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceModifyFrm";
            ((System.ComponentModel.ISupportInitialize)(this.servicePriceNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label serviceNameLbl;
        private System.Windows.Forms.Label serviceUnitLbl;
        private System.Windows.Forms.NumericUpDown servicePriceNud;
        private System.Windows.Forms.Label serviceIdLbl;
    }
}