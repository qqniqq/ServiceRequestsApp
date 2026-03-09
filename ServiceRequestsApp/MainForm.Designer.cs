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
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(230, 1096);
            this.panelSidebar.TabIndex = 0;
            // 
            // labelMenuUsers
            // 
            this.labelMenuUsers.AutoSize = true;
            this.labelMenuUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMenuUsers.ForeColor = System.Drawing.Color.White;
            this.labelMenuUsers.Location = new System.Drawing.Point(28, 399);
            this.labelMenuUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenuUsers.Name = "labelMenuUsers";
            this.labelMenuUsers.Size = new System.Drawing.Size(149, 23);
            this.labelMenuUsers.TabIndex = 6;
            this.labelMenuUsers.Text = "👥 Пользователи";
            // 
            // labelMenuReports
            // 
            this.labelMenuReports.AutoSize = true;
            this.labelMenuReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMenuReports.ForeColor = System.Drawing.Color.White;
            this.labelMenuReports.Location = new System.Drawing.Point(28, 349);
            this.labelMenuReports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenuReports.Name = "labelMenuReports";
            this.labelMenuReports.Size = new System.Drawing.Size(96, 23);
            this.labelMenuReports.TabIndex = 5;
            this.labelMenuReports.Text = "🕒 Отчёты";
            // 
            // labelMenuDepartments
            // 
            this.labelMenuDepartments.AutoSize = true;
            this.labelMenuDepartments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMenuDepartments.ForeColor = System.Drawing.Color.White;
            this.labelMenuDepartments.Location = new System.Drawing.Point(28, 299);
            this.labelMenuDepartments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenuDepartments.Name = "labelMenuDepartments";
            this.labelMenuDepartments.Size = new System.Drawing.Size(123, 23);
            this.labelMenuDepartments.TabIndex = 4;
            this.labelMenuDepartments.Text = "📄 Отделения";
            // 
            // labelMenuEquipment
            // 
            this.labelMenuEquipment.AutoSize = true;
            this.labelMenuEquipment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMenuEquipment.ForeColor = System.Drawing.Color.White;
            this.labelMenuEquipment.Location = new System.Drawing.Point(28, 249);
            this.labelMenuEquipment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenuEquipment.Name = "labelMenuEquipment";
            this.labelMenuEquipment.Size = new System.Drawing.Size(155, 23);
            this.labelMenuEquipment.TabIndex = 3;
            this.labelMenuEquipment.Text = "🖥 Оборудование";
            // 
            // labelMenuRequests
            // 
            this.labelMenuRequests.AutoSize = true;
            this.labelMenuRequests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMenuRequests.ForeColor = System.Drawing.Color.White;
            this.labelMenuRequests.Location = new System.Drawing.Point(28, 199);
            this.labelMenuRequests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenuRequests.Name = "labelMenuRequests";
            this.labelMenuRequests.Size = new System.Drawing.Size(99, 23);
            this.labelMenuRequests.TabIndex = 2;
            this.labelMenuRequests.Text = "📋 Заявки";
            // 
            // labelMenuDashboard
            // 
            this.labelMenuDashboard.AutoSize = true;
            this.labelMenuDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMenuDashboard.ForeColor = System.Drawing.Color.White;
            this.labelMenuDashboard.Location = new System.Drawing.Point(28, 149);
            this.labelMenuDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenuDashboard.Name = "labelMenuDashboard";
            this.labelMenuDashboard.Size = new System.Drawing.Size(96, 23);
            this.labelMenuDashboard.TabIndex = 1;
            this.labelMenuDashboard.Text = "✅ Панель";
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAppTitle.ForeColor = System.Drawing.Color.White;
            this.labelAppTitle.Location = new System.Drawing.Point(28, 41);
            this.labelAppTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.panelHeader.Location = new System.Drawing.Point(230, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1694, 91);
            this.panelHeader.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(122)))));
            this.lblUser.Location = new System.Drawing.Point(1323, 34);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 20);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "lblUser";
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.AutoSize = true;
            this.labelPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.labelPageTitle.Location = new System.Drawing.Point(22, 24);
            this.labelPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(110, 37);
            this.labelPageTitle.TabIndex = 0;
            this.labelPageTitle.Text = "Заявки";
            // 
            // panelStatNew
            // 
            this.panelStatNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panelStatNew.Controls.Add(this.lblStatNew);
            this.panelStatNew.Location = new System.Drawing.Point(258, 112);
            this.panelStatNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStatNew.Name = "panelStatNew";
            this.panelStatNew.Size = new System.Drawing.Size(255, 75);
            this.panelStatNew.TabIndex = 2;
            // 
            // lblStatNew
            // 
            this.lblStatNew.AutoSize = true;
            this.lblStatNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatNew.ForeColor = System.Drawing.Color.White;
            this.lblStatNew.Location = new System.Drawing.Point(22, 20);
            this.lblStatNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatNew.Name = "lblStatNew";
            this.lblStatNew.Size = new System.Drawing.Size(101, 28);
            this.lblStatNew.TabIndex = 0;
            this.lblStatNew.Text = "Новые: 0";
            // 
            // panelStatInWork
            // 
            this.panelStatInWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(137)))), ((int)(((byte)(245)))));
            this.panelStatInWork.Controls.Add(this.lblStatInWork);
            this.panelStatInWork.Location = new System.Drawing.Point(528, 112);
            this.panelStatInWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStatInWork.Name = "panelStatInWork";
            this.panelStatInWork.Size = new System.Drawing.Size(255, 75);
            this.panelStatInWork.TabIndex = 3;
            // 
            // lblStatInWork
            // 
            this.lblStatInWork.AutoSize = true;
            this.lblStatInWork.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatInWork.ForeColor = System.Drawing.Color.White;
            this.lblStatInWork.Location = new System.Drawing.Point(22, 20);
            this.lblStatInWork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatInWork.Name = "lblStatInWork";
            this.lblStatInWork.Size = new System.Drawing.Size(121, 28);
            this.lblStatInWork.TabIndex = 0;
            this.lblStatInWork.Text = "В работе: 0";
            // 
            // panelStatDone
            // 
            this.panelStatDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.panelStatDone.Controls.Add(this.lblStatDone);
            this.panelStatDone.Location = new System.Drawing.Point(798, 112);
            this.panelStatDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStatDone.Name = "panelStatDone";
            this.panelStatDone.Size = new System.Drawing.Size(255, 75);
            this.panelStatDone.TabIndex = 4;
            // 
            // lblStatDone
            // 
            this.lblStatDone.AutoSize = true;
            this.lblStatDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatDone.ForeColor = System.Drawing.Color.White;
            this.lblStatDone.Location = new System.Drawing.Point(22, 20);
            this.lblStatDone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatDone.Name = "lblStatDone";
            this.lblStatDone.Size = new System.Drawing.Size(147, 28);
            this.lblStatDone.TabIndex = 0;
            this.lblStatDone.Text = "Выполнено: 0";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(258, 214);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(794, 30);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(236)))));
            this.btnAddRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(92)))), ((int)(((byte)(193)))));
            this.btnAddRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.btnAddRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(248)))));
            this.btnAddRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRequest.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddRequest.ForeColor = System.Drawing.Color.White;
            this.btnAddRequest.Location = new System.Drawing.Point(1072, 209);
            this.btnAddRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(245, 45);
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
            this.dataGridViewRequests.Location = new System.Drawing.Point(258, 269);
            this.dataGridViewRequests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.ReadOnly = true;
            this.dataGridViewRequests.RowHeadersWidth = 51;
            this.dataGridViewRequests.RowTemplate.Height = 24;
            this.dataGridViewRequests.Size = new System.Drawing.Size(1704, 730);
            this.dataGridViewRequests.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(132)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(252, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
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
            this.comboStatus.Location = new System.Drawing.Point(1325, 214);
            this.comboStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(194, 31);
            this.comboStatus.TabIndex = 9;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(236)))));
            this.btnUpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(92)))), ((int)(((byte)(193)))));
            this.btnUpdateStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.btnUpdateStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(248)))));
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(1512, 209);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(188, 45);
            this.btnUpdateStatus.TabIndex = 10;
            this.btnUpdateStatus.Text = "Изменить статус";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(136)))), ((int)(((byte)(157)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1708, 209);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 45);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Правка";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.White;
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(193)))), ((int)(((byte)(207)))));
            this.btnDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(86)))), ((int)(((byte)(112)))));
            this.btnDetails.Location = new System.Drawing.Point(1812, 209);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(98, 45);
            this.btnDetails.TabIndex = 12;
            this.btnDetails.Text = "Детали";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1918, 209);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "✕";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.lblDateFrom.Location = new System.Drawing.Point(716, 1029);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(21, 23);
            this.lblDateFrom.TabIndex = 13;
            this.lblDateFrom.Text = "С";
            // 
            // dateFrom
            // 
            this.dateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(754, 1024);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(162, 30);
            this.dateFrom.TabIndex = 14;
            // 
            // lblDateTo
            // 
            this.lblDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.lblDateTo.Location = new System.Drawing.Point(924, 1029);
            this.lblDateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(32, 23);
            this.lblDateTo.TabIndex = 15;
            this.lblDateTo.Text = "По";
            // 
            // dateTo
            // 
            this.dateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(971, 1024);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(162, 30);
            this.dateTo.TabIndex = 16;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(136)))), ((int)(((byte)(157)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(1141, 1019);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(144, 46);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "Отчёт";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1292, 1019);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(299, 46);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Выйти на форму авторизации";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1924, 1096);
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
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
