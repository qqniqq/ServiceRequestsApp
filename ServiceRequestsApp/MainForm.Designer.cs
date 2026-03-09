namespace ServiceRequestsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelMenuUsers = new System.Windows.Forms.Label();
            this.labelMenuReports = new System.Windows.Forms.Label();
            this.labelMenuDepartments = new System.Windows.Forms.Label();
            this.labelMenuEquipment = new System.Windows.Forms.Label();
            this.labelMenuRequests = new System.Windows.Forms.Label();
            this.labelMenuDashboard = new System.Windows.Forms.Label();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.panelStatNew = new System.Windows.Forms.Panel();
            this.lblStatNew = new System.Windows.Forms.Label();
            this.panelStatInWork = new System.Windows.Forms.Panel();
            this.lblStatInWork = new System.Windows.Forms.Label();
            this.panelStatDone = new System.Windows.Forms.Panel();
            this.lblStatDone = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelStatNew.SuspendLayout();
            this.panelStatInWork.SuspendLayout();
            this.panelStatDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            resources.ApplyResources(this.panelSidebar, "panelSidebar");
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(98)))), ((int)(((byte)(201)))));
            this.panelSidebar.Controls.Add(this.labelMenuUsers);
            this.panelSidebar.Controls.Add(this.labelMenuReports);
            this.panelSidebar.Controls.Add(this.labelMenuDepartments);
            this.panelSidebar.Controls.Add(this.labelMenuEquipment);
            this.panelSidebar.Controls.Add(this.labelMenuRequests);
            this.panelSidebar.Controls.Add(this.labelMenuDashboard);
            this.panelSidebar.Controls.Add(this.labelAppTitle);
            this.panelSidebar.Name = "panelSidebar";
            // 
            // labelMenuUsers
            // 
            resources.ApplyResources(this.labelMenuUsers, "labelMenuUsers");
            this.labelMenuUsers.ForeColor = System.Drawing.Color.White;
            this.labelMenuUsers.Name = "labelMenuUsers";
            // 
            // labelMenuReports
            // 
            resources.ApplyResources(this.labelMenuReports, "labelMenuReports");
            this.labelMenuReports.ForeColor = System.Drawing.Color.White;
            this.labelMenuReports.Name = "labelMenuReports";
            // 
            // labelMenuDepartments
            // 
            resources.ApplyResources(this.labelMenuDepartments, "labelMenuDepartments");
            this.labelMenuDepartments.ForeColor = System.Drawing.Color.White;
            this.labelMenuDepartments.Name = "labelMenuDepartments";
            // 
            // labelMenuEquipment
            // 
            resources.ApplyResources(this.labelMenuEquipment, "labelMenuEquipment");
            this.labelMenuEquipment.ForeColor = System.Drawing.Color.White;
            this.labelMenuEquipment.Name = "labelMenuEquipment";
            // 
            // labelMenuRequests
            // 
            resources.ApplyResources(this.labelMenuRequests, "labelMenuRequests");
            this.labelMenuRequests.ForeColor = System.Drawing.Color.White;
            this.labelMenuRequests.Name = "labelMenuRequests";
            // 
            // labelMenuDashboard
            // 
            resources.ApplyResources(this.labelMenuDashboard, "labelMenuDashboard");
            this.labelMenuDashboard.ForeColor = System.Drawing.Color.White;
            this.labelMenuDashboard.Name = "labelMenuDashboard";
            // 
            // labelAppTitle
            // 
            resources.ApplyResources(this.labelAppTitle, "labelAppTitle");
            this.labelAppTitle.ForeColor = System.Drawing.Color.White;
            this.labelAppTitle.Name = "labelAppTitle";
            // 
            // panelHeader
            // 
            resources.ApplyResources(this.panelHeader, "panelHeader");
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblUser);
            this.panelHeader.Controls.Add(this.labelPageTitle);
            this.panelHeader.Name = "panelHeader";
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(122)))));
            this.lblUser.Name = "lblUser";
            // 
            // labelPageTitle
            // 
            resources.ApplyResources(this.labelPageTitle, "labelPageTitle");
            this.labelPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.labelPageTitle.Name = "labelPageTitle";
            // 
            // panelStatNew
            // 
            resources.ApplyResources(this.panelStatNew, "panelStatNew");
            this.panelStatNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panelStatNew.Controls.Add(this.lblStatNew);
            this.panelStatNew.Name = "panelStatNew";
            // 
            // lblStatNew
            // 
            resources.ApplyResources(this.lblStatNew, "lblStatNew");
            this.lblStatNew.ForeColor = System.Drawing.Color.White;
            this.lblStatNew.Name = "lblStatNew";
            // 
            // panelStatInWork
            // 
            resources.ApplyResources(this.panelStatInWork, "panelStatInWork");
            this.panelStatInWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(137)))), ((int)(((byte)(245)))));
            this.panelStatInWork.Controls.Add(this.lblStatInWork);
            this.panelStatInWork.Name = "panelStatInWork";
            // 
            // lblStatInWork
            // 
            resources.ApplyResources(this.lblStatInWork, "lblStatInWork");
            this.lblStatInWork.ForeColor = System.Drawing.Color.White;
            this.lblStatInWork.Name = "lblStatInWork";
            // 
            // panelStatDone
            // 
            resources.ApplyResources(this.panelStatDone, "panelStatDone");
            this.panelStatDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.panelStatDone.Controls.Add(this.lblStatDone);
            this.panelStatDone.Name = "panelStatDone";
            // 
            // lblStatDone
            // 
            resources.ApplyResources(this.lblStatDone, "lblStatDone");
            this.lblStatDone.ForeColor = System.Drawing.Color.White;
            this.lblStatDone.Name = "lblStatDone";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddRequest
            // 
            resources.ApplyResources(this.btnAddRequest, "btnAddRequest");
            this.btnAddRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(236)))));
            this.btnAddRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(92)))), ((int)(((byte)(193)))));
            this.btnAddRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.btnAddRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(248)))));
            this.btnAddRequest.ForeColor = System.Drawing.Color.White;
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.UseVisualStyleBackColor = false;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // dataGridViewRequests
            // 
            resources.ApplyResources(this.dataGridViewRequests, "dataGridViewRequests");
            this.dataGridViewRequests.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.ReadOnly = true;
            this.dataGridViewRequests.RowTemplate.Height = 24;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(132)))), ((int)(((byte)(147)))));
            this.label1.Name = "label1";
            // 
            // comboStatus
            // 
            resources.ApplyResources(this.comboStatus, "comboStatus");
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            resources.GetString("comboStatus.Items"),
            resources.GetString("comboStatus.Items1"),
            resources.GetString("comboStatus.Items2")});
            this.comboStatus.Name = "comboStatus";
            // 
            // btnUpdateStatus
            // 
            resources.ApplyResources(this.btnUpdateStatus, "btnUpdateStatus");
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(236)))));
            this.btnUpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(92)))), ((int)(((byte)(193)))));
            this.btnUpdateStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.btnUpdateStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(248)))));
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(136)))), ((int)(((byte)(157)))));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetails
            // 
            resources.ApplyResources(this.btnDetails, "btnDetails");
            this.btnDetails.BackColor = System.Drawing.Color.White;
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(193)))), ((int)(((byte)(207)))));
            this.btnDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.btnDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(86)))), ((int)(((byte)(112)))));
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDateFrom
            // 
            resources.ApplyResources(this.lblDateFrom, "lblDateFrom");
            this.lblDateFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.lblDateFrom.Name = "lblDateFrom";
            // 
            // dateFrom
            // 
            resources.ApplyResources(this.dateFrom, "dateFrom");
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Name = "dateFrom";
            // 
            // lblDateTo
            // 
            resources.ApplyResources(this.lblDateTo, "lblDateTo");
            this.lblDateTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.lblDateTo.Name = "lblDateTo";
            // 
            // dateTo
            // 
            resources.ApplyResources(this.dateTo, "dateTo");
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Name = "dateTo";
            // 
            // btnReport
            // 
            resources.ApplyResources(this.btnReport, "btnReport");
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(136)))), ((int)(((byte)(157)))));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Name = "btnReport";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRequests);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panelStatDone);
            this.Controls.Add(this.panelStatInWork);
            this.Controls.Add(this.panelStatNew);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelStatNew.ResumeLayout(false);
            this.panelStatNew.PerformLayout();
            this.panelStatInWork.ResumeLayout(false);
            this.panelStatInWork.PerformLayout();
            this.panelStatDone.ResumeLayout(false);
            this.panelStatDone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.Label labelMenuDashboard;
        private System.Windows.Forms.Label labelMenuRequests;
        private System.Windows.Forms.Label labelMenuEquipment;
        private System.Windows.Forms.Label labelMenuDepartments;
        private System.Windows.Forms.Label labelMenuReports;
        private System.Windows.Forms.Label labelMenuUsers;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelStatNew;
        private System.Windows.Forms.Label lblStatNew;
        private System.Windows.Forms.Panel panelStatInWork;
        private System.Windows.Forms.Label lblStatInWork;
        private System.Windows.Forms.Panel panelStatDone;
        private System.Windows.Forms.Label lblStatDone;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnLogout;
    }
}
