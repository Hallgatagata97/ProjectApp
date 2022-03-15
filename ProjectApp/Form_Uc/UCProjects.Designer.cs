
namespace ProjectApp.Form_Uc
{
    partial class UCProjects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.noDataLbl = new System.Windows.Forms.Label();
            this.projectDgv = new System.Windows.Forms.DataGridView();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companiesCompanyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modifyBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDb_ProjectAppDataSet = new ProjectApp.MyDb_ProjectAppDataSet();
            this.countLbl = new System.Windows.Forms.Label();
            this.deleteFiltersBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.newProjectBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deadlineFromDtp = new System.Windows.Forms.DateTimePicker();
            this.deadlineToDtp = new System.Windows.Forms.DateTimePicker();
            this.statCbx = new System.Windows.Forms.ComboBox();
            this.projectIdTbx = new System.Windows.Forms.TextBox();
            this.projectsTableAdapter = new ProjectApp.MyDb_ProjectAppDataSetTableAdapters.ProjectsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb_ProjectAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.exportBtn);
            this.panel1.Controls.Add(this.noDataLbl);
            this.panel1.Controls.Add(this.projectDgv);
            this.panel1.Controls.Add(this.countLbl);
            this.panel1.Controls.Add(this.deleteFiltersBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.newProjectBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deadlineFromDtp);
            this.panel1.Controls.Add(this.deadlineToDtp);
            this.panel1.Controls.Add(this.statCbx);
            this.panel1.Controls.Add(this.projectIdTbx);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 500);
            this.panel1.TabIndex = 0;
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
            this.exportBtn.TabIndex = 24;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // noDataLbl
            // 
            this.noDataLbl.AutoSize = true;
            this.noDataLbl.BackColor = System.Drawing.Color.AliceBlue;
            this.noDataLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noDataLbl.Location = new System.Drawing.Point(200, 200);
            this.noDataLbl.Name = "noDataLbl";
            this.noDataLbl.Size = new System.Drawing.Size(263, 19);
            this.noDataLbl.TabIndex = 19;
            this.noDataLbl.Text = "Még nincs projekt a rendszerben!";
            // 
            // projectDgv
            // 
            this.projectDgv.AutoGenerateColumns = false;
            this.projectDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectDgv.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.projectDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.projectDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIdDataGridViewTextBoxColumn,
            this.companiesCompanyIdDataGridViewTextBoxColumn,
            this.status2DataGridViewTextBoxColumn,
            this.deadLineDataGridViewTextBoxColumn,
            this.creationdateDataGridViewTextBoxColumn,
            this.deleteBtn,
            this.modifyBtn});
            this.projectDgv.DataSource = this.projectsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.projectDgv.Location = new System.Drawing.Point(13, 13);
            this.projectDgv.Name = "projectDgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.projectDgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.projectDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.projectDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectDgv.Size = new System.Drawing.Size(655, 450);
            this.projectDgv.TabIndex = 20;
            this.projectDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectDgv_CellContentClick);
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "Rendelés ID";
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companiesCompanyIdDataGridViewTextBoxColumn
            // 
            this.companiesCompanyIdDataGridViewTextBoxColumn.DataPropertyName = "Companies_CompanyId";
            this.companiesCompanyIdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.companiesCompanyIdDataGridViewTextBoxColumn.HeaderText = "Ügyfél Id";
            this.companiesCompanyIdDataGridViewTextBoxColumn.Name = "companiesCompanyIdDataGridViewTextBoxColumn";
            // 
            // status2DataGridViewTextBoxColumn
            // 
            this.status2DataGridViewTextBoxColumn.DataPropertyName = "Status2";
            this.status2DataGridViewTextBoxColumn.FillWeight = 70F;
            this.status2DataGridViewTextBoxColumn.HeaderText = "Státusz";
            this.status2DataGridViewTextBoxColumn.Name = "status2DataGridViewTextBoxColumn";
            // 
            // deadLineDataGridViewTextBoxColumn
            // 
            this.deadLineDataGridViewTextBoxColumn.DataPropertyName = "DeadLine";
            this.deadLineDataGridViewTextBoxColumn.FillWeight = 80F;
            this.deadLineDataGridViewTextBoxColumn.HeaderText = "Lejárati határidő";
            this.deadLineDataGridViewTextBoxColumn.Name = "deadLineDataGridViewTextBoxColumn";
            // 
            // creationdateDataGridViewTextBoxColumn
            // 
            this.creationdateDataGridViewTextBoxColumn.DataPropertyName = "Creation_date";
            this.creationdateDataGridViewTextBoxColumn.FillWeight = 80F;
            this.creationdateDataGridViewTextBoxColumn.HeaderText = "Létrehozás dátuma";
            this.creationdateDataGridViewTextBoxColumn.Name = "creationdateDataGridViewTextBoxColumn";
            // 
            // deleteBtn
            // 
            this.deleteBtn.DataPropertyName = "ServiceId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            this.deleteBtn.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GhostWhite;
            this.modifyBtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.modifyBtn.FillWeight = 30F;
            this.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyBtn.HeaderText = "Mód.";
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.ReadOnly = true;
            this.modifyBtn.Text = "";
            this.modifyBtn.UseColumnTextForButtonValue = true;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.myDb_ProjectAppDataSet;
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
            // newProjectBtn
            // 
            this.newProjectBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newProjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.newProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProjectBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newProjectBtn.ForeColor = System.Drawing.Color.Azure;
            this.newProjectBtn.Location = new System.Drawing.Point(677, 413);
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(213, 50);
            this.newProjectBtn.TabIndex = 9;
            this.newProjectBtn.Text = "Új rendelés";
            this.newProjectBtn.UseVisualStyleBackColor = false;
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Határidő-ig";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Határidő-től";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Státusz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Projekt ID";
            // 
            // deadlineFromDtp
            // 
            this.deadlineFromDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deadlineFromDtp.Location = new System.Drawing.Point(677, 130);
            this.deadlineFromDtp.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.deadlineFromDtp.Name = "deadlineFromDtp";
            this.deadlineFromDtp.Size = new System.Drawing.Size(213, 21);
            this.deadlineFromDtp.TabIndex = 4;
            // 
            // deadlineToDtp
            // 
            this.deadlineToDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deadlineToDtp.Location = new System.Drawing.Point(677, 180);
            this.deadlineToDtp.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.deadlineToDtp.Name = "deadlineToDtp";
            this.deadlineToDtp.Size = new System.Drawing.Size(213, 21);
            this.deadlineToDtp.TabIndex = 3;
            // 
            // statCbx
            // 
            this.statCbx.BackColor = System.Drawing.Color.White;
            this.statCbx.FormattingEnabled = true;
            this.statCbx.Location = new System.Drawing.Point(677, 80);
            this.statCbx.Name = "statCbx";
            this.statCbx.Size = new System.Drawing.Size(213, 24);
            this.statCbx.TabIndex = 2;
            // 
            // projectIdTbx
            // 
            this.projectIdTbx.AccessibleDescription = "bla";
            this.projectIdTbx.AccessibleName = "bla";
            this.projectIdTbx.BackColor = System.Drawing.Color.White;
            this.projectIdTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectIdTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.projectIdTbx.Location = new System.Drawing.Point(677, 30);
            this.projectIdTbx.Name = "projectIdTbx";
            this.projectIdTbx.Size = new System.Drawing.Size(213, 23);
            this.projectIdTbx.TabIndex = 1;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // UCProjects
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCProjects";
            this.Size = new System.Drawing.Size(950, 550);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDb_ProjectAppDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox statCbx;
        private System.Windows.Forms.TextBox projectIdTbx;
        private System.Windows.Forms.Button deleteFiltersBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button newProjectBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker deadlineFromDtp;
        private System.Windows.Forms.DateTimePicker deadlineToDtp;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private MyDb_ProjectAppDataSet myDb_ProjectAppDataSet;
        private MyDb_ProjectAppDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.Label noDataLbl;
        private System.Windows.Forms.DataGridView projectDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companiesCompanyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.DataGridViewButtonColumn modifyBtn;
        private System.Windows.Forms.Button exportBtn;
    }
}
