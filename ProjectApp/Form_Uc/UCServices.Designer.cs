
namespace ProjectApp.Form_Uc
{
    partial class UCServices
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.serviceNameTbx = new System.Windows.Forms.TextBox();
            this.noDataLbl = new System.Windows.Forms.Label();
            this.serviceDgv = new System.Windows.Forms.DataGridView();
            this.serviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modifyBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.servicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDb_ProjectAppDataSet = new ProjectApp.MyDb_ProjectAppDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceToNud = new System.Windows.Forms.NumericUpDown();
            this.priceFromNud = new System.Windows.Forms.NumericUpDown();
            this.countLbl = new System.Windows.Forms.Label();
            this.deleteFiltersBtn = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.newServiceBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceIdTbx = new System.Windows.Forms.TextBox();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new ProjectApp.MyDb_ProjectAppDataSetTableAdapters.ProjectsTableAdapter();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new ProjectApp.MyDb_ProjectAppDataSetTableAdapters.ServicesTableAdapter();
            this.servicesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb_ProjectAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceToNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFromNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.exportBtn);
            this.panel1.Controls.Add(this.serviceNameTbx);
            this.panel1.Controls.Add(this.noDataLbl);
            this.panel1.Controls.Add(this.serviceDgv);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.priceToNud);
            this.panel1.Controls.Add(this.priceFromNud);
            this.panel1.Controls.Add(this.countLbl);
            this.panel1.Controls.Add(this.deleteFiltersBtn);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.newServiceBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.serviceIdTbx);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 500);
            this.panel1.TabIndex = 1;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exportBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exportBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exportBtn.Location = new System.Drawing.Point(565, 467);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(103, 30);
            this.exportBtn.TabIndex = 22;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // serviceNameTbx
            // 
            this.serviceNameTbx.AccessibleDescription = "bla";
            this.serviceNameTbx.AccessibleName = "bla";
            this.serviceNameTbx.BackColor = System.Drawing.Color.White;
            this.serviceNameTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceNameTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serviceNameTbx.Location = new System.Drawing.Point(677, 80);
            this.serviceNameTbx.Name = "serviceNameTbx";
            this.serviceNameTbx.Size = new System.Drawing.Size(213, 23);
            this.serviceNameTbx.TabIndex = 21;
            // 
            // noDataLbl
            // 
            this.noDataLbl.AutoSize = true;
            this.noDataLbl.BackColor = System.Drawing.Color.AliceBlue;
            this.noDataLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noDataLbl.Location = new System.Drawing.Point(200, 200);
            this.noDataLbl.Name = "noDataLbl";
            this.noDataLbl.Size = new System.Drawing.Size(299, 19);
            this.noDataLbl.TabIndex = 20;
            this.noDataLbl.Text = "Még nincs szolgáltatás a rendszerben!";
            // 
            // serviceDgv
            // 
            this.serviceDgv.AutoGenerateColumns = false;
            this.serviceDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceDgv.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.serviceDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.deleteBtn,
            this.modifyBtn});
            this.serviceDgv.DataSource = this.servicesBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceDgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.serviceDgv.Location = new System.Drawing.Point(13, 13);
            this.serviceDgv.Name = "serviceDgv";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.serviceDgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.serviceDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serviceDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceDgv.Size = new System.Drawing.Size(655, 450);
            this.serviceDgv.TabIndex = 17;
            this.serviceDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceDgv_CellContentClick);
            this.serviceDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceDgv_CellDoubleClick);
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            this.serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            dataGridViewCellStyle1.NullValue = " ";
            this.serviceIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.serviceIdDataGridViewTextBoxColumn.FillWeight = 60F;
            this.serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            this.serviceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 95F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.FillWeight = 40F;
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.FillWeight = 40F;
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.DataPropertyName = "ServiceId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            this.deleteBtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.deleteBtn.FillWeight = 30F;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.HeaderText = "Törlés";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ReadOnly = true;
            this.deleteBtn.Text = "";
            this.deleteBtn.UseColumnTextForButtonValue = true;
            // 
            // modifyBtn
            // 
            this.modifyBtn.DataPropertyName = "ServiceId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.GhostWhite;
            this.modifyBtn.DefaultCellStyle = dataGridViewCellStyle3;
            this.modifyBtn.FillWeight = 30F;
            this.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyBtn.HeaderText = "Mód.";
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.ReadOnly = true;
            this.modifyBtn.Text = "";
            this.modifyBtn.UseColumnTextForButtonValue = true;
            // 
            // servicesBindingSource1
            // 
            this.servicesBindingSource1.DataMember = "Services";
            this.servicesBindingSource1.DataSource = this.myDb_ProjectAppDataSet;
            // 
            // myDb_ProjectAppDataSet
            // 
            this.myDb_ProjectAppDataSet.DataSetName = "MyDb_ProjectAppDataSet";
            this.myDb_ProjectAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ár-ig";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ár-tól";
            // 
            // priceToNud
            // 
            this.priceToNud.Location = new System.Drawing.Point(677, 180);
            this.priceToNud.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.priceToNud.Name = "priceToNud";
            this.priceToNud.Size = new System.Drawing.Size(213, 21);
            this.priceToNud.TabIndex = 14;
            // 
            // priceFromNud
            // 
            this.priceFromNud.Location = new System.Drawing.Point(677, 130);
            this.priceFromNud.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.priceFromNud.Name = "priceFromNud";
            this.priceFromNud.Size = new System.Drawing.Size(213, 21);
            this.priceFromNud.TabIndex = 13;
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(13, 475);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(101, 16);
            this.countLbl.TabIndex = 12;
            this.countLbl.Text = "Találatok száma: ";
            // 
            // deleteFiltersBtn
            // 
            this.deleteFiltersBtn.BackColor = System.Drawing.Color.Azure;
            this.deleteFiltersBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.deleteFiltersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFiltersBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteFiltersBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deleteFiltersBtn.Location = new System.Drawing.Point(677, 230);
            this.deleteFiltersBtn.Name = "deleteFiltersBtn";
            this.deleteFiltersBtn.Size = new System.Drawing.Size(103, 30);
            this.deleteFiltersBtn.TabIndex = 11;
            this.deleteFiltersBtn.Text = "Szűrés törlése";
            this.deleteFiltersBtn.UseVisualStyleBackColor = false;
            this.deleteFiltersBtn.Click += new System.EventHandler(this.deleteFiltersBtn_Click);
            // 
            // searchButton
            // 
            this.searchButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.searchButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.ForeColor = System.Drawing.Color.Azure;
            this.searchButton.Location = new System.Drawing.Point(787, 230);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 30);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Szűrés";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // newServiceBtn
            // 
            this.newServiceBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newServiceBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.newServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newServiceBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newServiceBtn.ForeColor = System.Drawing.Color.Azure;
            this.newServiceBtn.Location = new System.Drawing.Point(677, 413);
            this.newServiceBtn.Name = "newServiceBtn";
            this.newServiceBtn.Size = new System.Drawing.Size(213, 50);
            this.newServiceBtn.TabIndex = 9;
            this.newServiceBtn.Text = "Új szolgáltatás";
            this.newServiceBtn.UseVisualStyleBackColor = false;
            this.newServiceBtn.Click += new System.EventHandler(this.newServiceBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Szolgáltatás neve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szolgáltatás ID";
            // 
            // serviceIdTbx
            // 
            this.serviceIdTbx.AccessibleDescription = "bla";
            this.serviceIdTbx.AccessibleName = "bla";
            this.serviceIdTbx.BackColor = System.Drawing.Color.White;
            this.serviceIdTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceIdTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serviceIdTbx.Location = new System.Drawing.Point(677, 30);
            this.serviceIdTbx.Name = "serviceIdTbx";
            this.serviceIdTbx.Size = new System.Drawing.Size(213, 23);
            this.serviceIdTbx.TabIndex = 1;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.myDb_ProjectAppDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.myDb_ProjectAppDataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // servicesBindingSource2
            // 
            this.servicesBindingSource2.DataMember = "Services";
            this.servicesBindingSource2.DataSource = this.myDb_ProjectAppDataSet;
            // 
            // UCServices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "UCServices";
            this.Size = new System.Drawing.Size(950, 550);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb_ProjectAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceToNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFromNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown priceFromNud;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Button deleteFiltersBtn;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button newServiceBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serviceIdTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown priceToNud;
        private System.Windows.Forms.DataGridView serviceDgv;
        private System.Windows.Forms.Label noDataLbl;
        private MyDb_ProjectAppDataSet myDb_ProjectAppDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private MyDb_ProjectAppDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private MyDb_ProjectAppDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource1;
        private System.Windows.Forms.BindingSource servicesBindingSource2;
        private System.Windows.Forms.TextBox serviceNameTbx;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.DataGridViewButtonColumn modifyBtn;
    }
}
