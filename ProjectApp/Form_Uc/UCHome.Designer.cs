
namespace ProjectApp.Form_Uc
{
    partial class UCHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.waitingBtn = new System.Windows.Forms.Button();
            this.inProgressBtn = new System.Windows.Forms.Button();
            this.newProjectsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.myDb_ProjectAppDataSet = new ProjectApp.MyDb_ProjectAppDataSet();
            this.showResultsLv = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDb_ProjectAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.waitingBtn);
            this.panel1.Controls.Add(this.inProgressBtn);
            this.panel1.Controls.Add(this.newProjectsBtn);
            this.panel1.Controls.Add(this.showResultsLv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Leszűrt rendelések száma:";
            // 
            // waitingBtn
            // 
            this.waitingBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.waitingBtn.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.waitingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waitingBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.waitingBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.waitingBtn.Location = new System.Drawing.Point(5, 262);
            this.waitingBtn.Name = "waitingBtn";
            this.waitingBtn.Size = new System.Drawing.Size(100, 100);
            this.waitingBtn.TabIndex = 5;
            this.waitingBtn.Text = "Átadásra vár";
            this.waitingBtn.UseVisualStyleBackColor = false;
            // 
            // inProgressBtn
            // 
            this.inProgressBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.inProgressBtn.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.inProgressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inProgressBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inProgressBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inProgressBtn.Location = new System.Drawing.Point(5, 156);
            this.inProgressBtn.Name = "inProgressBtn";
            this.inProgressBtn.Size = new System.Drawing.Size(100, 100);
            this.inProgressBtn.TabIndex = 4;
            this.inProgressBtn.Text = "Folyamatban";
            this.inProgressBtn.UseVisualStyleBackColor = false;
            // 
            // newProjectsBtn
            // 
            this.newProjectsBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.newProjectsBtn.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.newProjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProjectsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newProjectsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newProjectsBtn.Location = new System.Drawing.Point(5, 50);
            this.newProjectsBtn.Name = "newProjectsBtn";
            this.newProjectsBtn.Size = new System.Drawing.Size(100, 100);
            this.newProjectsBtn.TabIndex = 3;
            this.newProjectsBtn.Text = "Új";
            this.newProjectsBtn.UseVisualStyleBackColor = false;
            this.newProjectsBtn.Click += new System.EventHandler(this.newProjectsBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(5, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 5);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nyitott rendelések";
            // 
            // myDb_ProjectAppDataSet
            // 
            this.myDb_ProjectAppDataSet.DataSetName = "MyDb_ProjectAppDataSet";
            this.myDb_ProjectAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showResultsLv
            // 
            this.showResultsLv.HideSelection = false;
            this.showResultsLv.Location = new System.Drawing.Point(111, 50);
            this.showResultsLv.Name = "showResultsLv";
            this.showResultsLv.Size = new System.Drawing.Size(736, 312);
            this.showResultsLv.TabIndex = 2;
            this.showResultsLv.UseCompatibleStateImageBehavior = false;
            this.showResultsLv.View = System.Windows.Forms.View.Details;
            // 
            // UCHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(950, 550);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDb_ProjectAppDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button waitingBtn;
        private System.Windows.Forms.Button inProgressBtn;
        private System.Windows.Forms.Button newProjectsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView showResultsLv;
        private MyDb_ProjectAppDataSet myDb_ProjectAppDataSet;
    }
}
