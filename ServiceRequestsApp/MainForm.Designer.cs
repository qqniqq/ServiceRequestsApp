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
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(98)))), ((int)(((byte)(201)))));
            this.panelSidebar.Controls.Add(this.labelMenuUsers);
            this.panelSidebar.Controls.Add(this.labelMenuReports);
            this.panelSidebar.Controls.Add(this.labelMenuDepartments);
            this.panelSidebar.Controls.Add(this.labelMenuEquipment);
            this.panelSidebar.Controls.Add(this.labelMenuRequests);
            this.panelSidebar.Controls.Add(this.labelMenuDashboard);
            this.panelSidebar.Controls.Add(this.labelAppTitle);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(184, 877);
            this.panelSidebar.TabIndex = 0;
            // 
            // labelMenuUsers
            // 
            this.labelMenuUsers.AutoSize = true;
            this.labelMenuUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMenuUsers.ForeColor = System.Drawing.Color.White;
            this.labelMenuUsers.Location = new System.Drawing.Point(22, 319);
            this.labelMenuUsers.Name = "labelMenuUsers";
            this.labelMenuUsers.Size = new System.Drawing.Size(112, 23);
            this.labelMenuUsers.TabIndex = 6;
            this.labelMenuUsers.Text = "👥 Пользователи";
            // 
            // labelMenuReports
            // 
            this.labelMenuReports.AutoSize = true;
            this.labelMenuReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMenuReports.ForeColor = System.Drawing.Color.White;
            this.labelMenuReports.Location = new System.Drawing.Point(22, 279);
            this.labelMenuReports.Name = "labelMenuReports";
            this.labelMenuReports.Size = new System.Drawing.Size(79, 23);
            this.labelMenuReports.TabIndex = 5;
            this.labelMenuReports.Text = "🕒 Отчёты";
            // 
            // labelMenuDepartments
            // 
            this.labelMenuDepartments.AutoSize = true;
            this.labelMenuDepartments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMenuDepartments.ForeColor = System.Drawing.Color.White;
            this.labelMenuDepartments.Location = new System.Drawing.Point(22, 239);
            this.labelMenuDepartments.Name = "labelMenuDepartments";
            this.labelMenuDepartments.Size = new System.Drawing.Size(116, 23);
            this.labelMenuDepartments.TabIndex = 4;
            this.labelMenuDepartments.Text = "📄 Отделения";
            // 
            // labelMenuEquipment
            // 
            this.labelMenuEquipment.AutoSize = true;
            this.labelMenuEquipment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMenuEquipment.ForeColor = System.Drawing.Color.White;
            this.labelMenuEquipment.Location = new System.Drawing.Point(22, 199);
            this.labelMenuEquipment.Name = "labelMenuEquipment";
            this.labelMenuEquipment.Size = new System.Drawing.Size(134, 23);
            this.labelMenuEquipment.TabIndex = 3;
            this.labelMenuEquipment.Text = "🖥 Оборудование";
            // 
            // labelMenuRequests
            // 
            this.labelMenuRequests.AutoSize = true;
            this.labelMenuRequests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMenuRequests.ForeColor = System.Drawing.Color.White;
            this.labelMenuRequests.Location = new System.Drawing.Point(22, 159);
            this.labelMenuRequests.Name = "labelMenuRequests";
            this.labelMenuRequests.Size = new System.Drawing.Size(89, 23);
            this.labelMenuRequests.TabIndex = 2;
            this.labelMenuRequests.Text = "📋 Заявки";
            // 
            // labelMenuDashboard
            // 
            this.labelMenuDashboard.AutoSize = true;
            this.labelMenuDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMenuDashboard.ForeColor = System.Drawing.Color.White;
            this.labelMenuDashboard.Location = new System.Drawing.Point(22, 119);
            this.labelMenuDashboard.Name = "labelMenuDashboard";
            this.labelMenuDashboard.Size = new System.Drawing.Size(84, 23);
            this.labelMenuDashboard.TabIndex = 1;
            this.labelMenuDashboard.Text = "✅ Панель";
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAppTitle.ForeColor = System.Drawing.Color.White;
            this.labelAppTitle.Location = new System.Drawing.Point(22, 33);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(126, 28);
            this.labelAppTitle.TabIndex = 0;
            this.labelAppTitle.Text = "IT HelpDesk";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblUser);
            this.panelHeader.Controls.Add(this.labelPageTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(184, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1401, 73);
            this.panelHeader.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(122)))));
            this.lblUser.Location = new System.Drawing.Point(1104, 27);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 20);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "lblUser";
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.AutoSize = true;
            this.labelPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.labelPageTitle.Location = new System.Drawing.Point(18, 19);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(113, 37);
            this.labelPageTitle.TabIndex = 0;
            this.labelPageTitle.Text = "Заявки";
            // 
            // panelStatNew
            // 
            this.panelStatNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panelStatNew.Controls.Add(this.lblStatNew);
            this.panelStatNew.Location = new System.Drawing.Point(206, 90);
            this.panelStatNew.Name = "panelStatNew";
            this.panelStatNew.Size = new System.Drawing.Size(204, 60);
            this.panelStatNew.TabIndex = 2;
            // 
            // lblStatNew
            // 
            this.lblStatNew.AutoSize = true;
            this.lblStatNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatNew.ForeColor = System.Drawing.Color.White;
            this.lblStatNew.Location = new System.Drawing.Point(18, 16);
            this.lblStatNew.Name = "lblStatNew";
            this.lblStatNew.Size = new System.Drawing.Size(105, 28);
            this.lblStatNew.TabIndex = 0;
            this.lblStatNew.Text = "Новые: 0";
            // 
            // panelStatInWork
            // 
            this.panelStatInWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(165)))), ((int)(((byte)(35)))));
            this.panelStatInWork.Controls.Add(this.lblStatInWork);
            this.panelStatInWork.Location = new System.Drawing.Point(422, 90);
            this.panelStatInWork.Name = "panelStatInWork";
            this.panelStatInWork.Size = new System.Drawing.Size(204, 60);
            this.panelStatInWork.TabIndex = 3;
            // 
            // lblStatInWork
            // 
            this.lblStatInWork.AutoSize = true;
            this.lblStatInWork.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatInWork.ForeColor = System.Drawing.Color.White;
            this.lblStatInWork.Location = new System.Drawing.Point(18, 16);
            this.lblStatInWork.Name = "lblStatInWork";
            this.lblStatInWork.Size = new System.Drawing.Size(132, 28);
            this.lblStatInWork.TabIndex = 0;
            this.lblStatInWork.Text = "В работе: 0";
            // 
            // panelStatDone
            // 
            this.panelStatDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.panelStatDone.Controls.Add(this.lblStatDone);
            this.panelStatDone.Location = new System.Drawing.Point(638, 90);
            this.panelStatDone.Name = "panelStatDone";
            this.panelStatDone.Size = new System.Drawing.Size(204, 60);
            this.panelStatDone.TabIndex = 4;
            // 
            // lblStatDone
            // 
            this.lblStatDone.AutoSize = true;
            this.lblStatDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatDone.ForeColor = System.Drawing.Color.White;
            this.lblStatDone.Location = new System.Drawing.Point(18, 16);
            this.lblStatDone.Name = "lblStatDone";
            this.lblStatDone.Size = new System.Drawing.Size(142, 28);
            this.lblStatDone.TabIndex = 0;
            this.lblStatDone.Text = "Выполнено: 0";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(206, 171);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(636, 30);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(236)))));
            this.btnAddRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRequest.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddRequest.ForeColor = System.Drawing.Color.White;
            this.btnAddRequest.Location = new System.Drawing.Point(858, 167);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(196, 36);
            this.btnAddRequest.TabIndex = 6;
            this.btnAddRequest.Text = "+ Новая заявка";
            this.btnAddRequest.UseVisualStyleBackColor = false;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRequests.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.dataGridViewRequests.Location = new System.Drawing.Point(206, 215);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.ReadOnly = true;
            this.dataGridViewRequests.RowHeadersWidth = 51;
            this.dataGridViewRequests.RowTemplate.Height = 24;
            this.dataGridViewRequests.Size = new System.Drawing.Size(1363, 584);
            this.dataGridViewRequests.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(132)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(202, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск заявок";
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Новая",
            "В работе",
            "Выполнена"});
            this.comboStatus.Location = new System.Drawing.Point(1060, 171);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(156, 31);
            this.comboStatus.TabIndex = 9;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(93)))));
            this.btnUpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(1222, 167);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(165, 36);
            this.btnUpdateStatus.TabIndex = 10;
            this.btnUpdateStatus.Text = "Изменить";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(206, 815);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(115, 37);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Отчёт";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(327, 815);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(239, 37);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Выйти на форму авторизации";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1585, 877);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReport);
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
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет заявок на обслуживание техники";
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
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnLogout;
    }
}
