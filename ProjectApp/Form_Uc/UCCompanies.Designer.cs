
namespace ProjectApp.Form_Uc
{
    partial class UCCompanies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.companyNameTbx = new System.Windows.Forms.TextBox();
            this.noDataLbl = new System.Windows.Forms.Label();
            this.companyDgv = new System.Windows.Forms.DataGridView();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDb_ProjectAppDataSet = new ProjectApp.MyDb_ProjectAppDataSet();
            this.countLbl = new System.Windows.Forms.Label();
            this.deleteFilterBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.newCompanyBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyIdTbx = new System.Windows.Forms.TextBox();
            this.companyTableAdapter = new ProjectApp.MyDb_ProjectAppDataSetTableAdapters.CompanyTableAdapter();
            this.companyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb_ProjectAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.exportBtn);
            this.panel1.Controls.Add(this.companyNameTbx);
            this.panel1.Controls.Add(this.noDataLbl);
            this.panel1.Controls.Add(this.companyDgv);
            this.panel1.Controls.Add(this.countLbl);
            this.panel1.Controls.Add(this.deleteFilterBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.newCompanyBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.companyIdTbx);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 500);
            this.panel1.TabIndex = 2;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exportBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exportBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exportBtn.Location = new System.Drawing.Point(565, 466);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(103, 30);
            this.exportBtn.TabIndex = 23;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // companyNameTbx
            // 
            this.companyNameTbx.AccessibleDescription = "bla";
            this.companyNameTbx.AccessibleName = "bla";
            this.companyNameTbx.BackColor = System.Drawing.Color.White;
            this.companyNameTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyNameTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.companyNameTbx.Location = new System.Drawing.Point(674, 80);
            this.companyNameTbx.Name = "companyNameTbx";
            this.companyNameTbx.Size = new System.Drawing.Size(150, 23);
            this.companyNameTbx.TabIndex = 23;
            // 
            // noDataLbl
            // 
            this.noDataLbl.AutoSize = true;
            this.noDataLbl.BackColor = System.Drawing.Color.AliceBlue;
            this.noDataLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noDataLbl.Location = new System.Drawing.Point(200, 200);
            this.noDataLbl.Name = "noDataLbl";
            this.noDataLbl.Size = new System.Drawing.Size(258, 19);
            this.noDataLbl.TabIndex = 21;
            this.noDataLbl.Text = "Még nincs ügyfél a rendszerben!";
            // 
            // companyDgv
            // 
            this.companyDgv.AutoGenerateColumns = false;
            this.companyDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.companyDgv.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.companyDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIdDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Taxnumber});
            this.companyDgv.DataSource = this.companyBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.companyDgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.companyDgv.Location = new System.Drawing.Point(13, 13);
            this.companyDgv.Name = "companyDgv";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companyDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.companyDgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.companyDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.companyDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.companyDgv.Size = new System.Drawing.Size(655, 450);
            this.companyDgv.TabIndex = 22;
            this.companyDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyDgv_CellContentClick);
            this.companyDgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyDgv_CellContentDoubleClick);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.myDb_ProjectAppDataSet;
            // 
            // myDb_ProjectAppDataSet
            // 
            this.myDb_ProjectAppDataSet.DataSetName = "MyDb_ProjectAppDataSet";
            this.myDb_ProjectAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // deleteFilterBtn
            // 
            this.deleteFilterBtn.BackColor = System.Drawing.Color.Azure;
            this.deleteFilterBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.deleteFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFilterBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteFilterBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deleteFilterBtn.Location = new System.Drawing.Point(677, 230);
            this.deleteFilterBtn.Name = "deleteFilterBtn";
            this.deleteFilterBtn.Size = new System.Drawing.Size(103, 30);
            this.deleteFilterBtn.TabIndex = 11;
            this.deleteFilterBtn.Text = "Szűrés törlése";
            this.deleteFilterBtn.UseVisualStyleBackColor = false;
            this.deleteFilterBtn.Click += new System.EventHandler(this.deleteFilterBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.searchBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBtn.ForeColor = System.Drawing.Color.Azure;
            this.searchBtn.Location = new System.Drawing.Point(787, 230);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(103, 30);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Szűrés";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // newCompanyBtn
            // 
            this.newCompanyBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newCompanyBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.newCompanyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCompanyBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newCompanyBtn.ForeColor = System.Drawing.Color.Azure;
            this.newCompanyBtn.Location = new System.Drawing.Point(677, 413);
            this.newCompanyBtn.Name = "newCompanyBtn";
            this.newCompanyBtn.Size = new System.Drawing.Size(213, 50);
            this.newCompanyBtn.TabIndex = 9;
            this.newCompanyBtn.Text = "Új ügyfél";
            this.newCompanyBtn.UseVisualStyleBackColor = false;
            this.newCompanyBtn.Click += new System.EventHandler(this.newCompanyBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cégnév";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ügyfél ID";
            // 
            // companyIdTbx
            // 
            this.companyIdTbx.AccessibleDescription = "bla";
            this.companyIdTbx.AccessibleName = "bla";
            this.companyIdTbx.BackColor = System.Drawing.Color.White;
            this.companyIdTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyIdTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.companyIdTbx.Location = new System.Drawing.Point(674, 30);
            this.companyIdTbx.Name = "companyIdTbx";
            this.companyIdTbx.Size = new System.Drawing.Size(150, 23);
            this.companyIdTbx.TabIndex = 1;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // companyIdDataGridViewTextBoxColumn
            // 
            this.companyIdDataGridViewTextBoxColumn.DataPropertyName = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.companyIdDataGridViewTextBoxColumn.HeaderText = "Ügyfél ID";
            this.companyIdDataGridViewTextBoxColumn.Name = "companyIdDataGridViewTextBoxColumn";
            this.companyIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Ügyfél neve";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Telefonszám";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Taxnumber
            // 
            this.Taxnumber.DataPropertyName = "Taxnumber";
            this.Taxnumber.HeaderText = "Adószám";
            this.Taxnumber.Name = "Taxnumber";
            this.Taxnumber.ReadOnly = true;
            // 
            // UCCompanies
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Name = "UCCompanies";
            this.Size = new System.Drawing.Size(950, 550);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb_ProjectAppDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Button deleteFilterBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button newCompanyBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyIdTbx;
        private System.Windows.Forms.Label noDataLbl;
        private System.Windows.Forms.DataGridView companyDgv;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.DataGridViewButtonColumn modifyBtn;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private MyDb_ProjectAppDataSet myDb_ProjectAppDataSet;
        private MyDb_ProjectAppDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.TextBox companyNameTbx;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxnumber;
    }
}
