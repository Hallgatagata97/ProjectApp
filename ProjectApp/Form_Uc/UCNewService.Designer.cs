
namespace ProjectApp.Form_Uc
{
    partial class UCNewService
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
            this.serviceNameTbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serviceUnitCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.servicePriceNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicePriceNud)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceNameTbx
            // 
            this.serviceNameTbx.BackColor = System.Drawing.Color.AliceBlue;
            this.serviceNameTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceNameTbx.Location = new System.Drawing.Point(15, 123);
            this.serviceNameTbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serviceNameTbx.Name = "serviceNameTbx";
            this.serviceNameTbx.Size = new System.Drawing.Size(200, 14);
            this.serviceNameTbx.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.modifyBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.serviceUnitCbx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.servicePriceNud);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.serviceNameTbx);
            this.panel1.Location = new System.Drawing.Point(225, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 1;
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.modifyBtn.FlatAppearance.BorderSize = 0;
            this.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyBtn.Image = global::ProjectApp.Properties.Resources.next;
            this.modifyBtn.Location = new System.Drawing.Point(15, 228);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(468, 50);
            this.modifyBtn.TabIndex = 17;
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Image = global::ProjectApp.Properties.Resources.next;
            this.saveBtn.Location = new System.Drawing.Point(15, 228);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(468, 50);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Location = new System.Drawing.Point(283, 199);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 3);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Location = new System.Drawing.Point(15, 141);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 3);
            this.panel4.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(15, 199);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 3);
            this.panel2.TabIndex = 9;
            // 
            // serviceUnitCbx
            // 
            this.serviceUnitCbx.BackColor = System.Drawing.Color.AliceBlue;
            this.serviceUnitCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceUnitCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceUnitCbx.FormattingEnabled = true;
            this.serviceUnitCbx.Items.AddRange(new object[] {
            "M",
            "M2",
            "Fm"});
            this.serviceUnitCbx.Location = new System.Drawing.Point(283, 178);
            this.serviceUnitCbx.Name = "serviceUnitCbx";
            this.serviceUnitCbx.Size = new System.Drawing.Size(200, 24);
            this.serviceUnitCbx.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mennyiségi egység*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Szolgáltatás ára*";
            // 
            // servicePriceNud
            // 
            this.servicePriceNud.BackColor = System.Drawing.Color.AliceBlue;
            this.servicePriceNud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicePriceNud.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.servicePriceNud.Location = new System.Drawing.Point(15, 181);
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
            this.servicePriceNud.Size = new System.Drawing.Size(200, 19);
            this.servicePriceNud.TabIndex = 11;
            this.servicePriceNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Szolgáltatás neve*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Szolgáltatás adatai";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(15, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 6);
            this.panel3.TabIndex = 8;
            // 
            // UCNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCNewService";
            this.Size = new System.Drawing.Size(950, 550);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicePriceNud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox serviceNameTbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown servicePriceNud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox serviceUnitCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button modifyBtn;
    }
}
