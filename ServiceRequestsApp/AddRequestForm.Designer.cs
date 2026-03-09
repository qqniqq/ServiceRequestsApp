namespace ServiceRequestsApp
{
    partial class AddRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRequestForm));
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboProblemType = new System.Windows.Forms.ComboBox();
            this.comboSpecialist = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            resources.ApplyResources(this.txtFullName, "txtFullName");
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Tag = "";
            // 
            // txtContact
            // 
            resources.ApplyResources(this.txtContact, "txtContact");
            this.txtContact.Name = "txtContact";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // comboPriority
            // 
            this.comboPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Items.AddRange(new object[] {
            resources.GetString("comboPriority.Items"),
            resources.GetString("comboPriority.Items1"),
            resources.GetString("comboPriority.Items2")});
            resources.ApplyResources(this.comboPriority, "comboPriority");
            this.comboPriority.Name = "comboPriority";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(236)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(92)))), ((int)(((byte)(193)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(248)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // comboDepartment
            // 
            this.comboDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Items.AddRange(new object[] {
            resources.GetString("comboDepartment.Items"),
            resources.GetString("comboDepartment.Items1"),
            resources.GetString("comboDepartment.Items2"),
            resources.GetString("comboDepartment.Items3"),
            resources.GetString("comboDepartment.Items4"),
            resources.GetString("comboDepartment.Items5"),
            resources.GetString("comboDepartment.Items6"),
            resources.GetString("comboDepartment.Items7")});
            resources.ApplyResources(this.comboDepartment, "comboDepartment");
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.SelectedIndexChanged += new System.EventHandler(this.comboDepartment_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // comboProblemType
            // 
            this.comboProblemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProblemType.FormattingEnabled = true;
            this.comboProblemType.Items.AddRange(new object[] {
            resources.GetString("comboProblemType.Items"),
            resources.GetString("comboProblemType.Items1"),
            resources.GetString("comboProblemType.Items2"),
            resources.GetString("comboProblemType.Items3"),
            resources.GetString("comboProblemType.Items4"),
            resources.GetString("comboProblemType.Items5"),
            resources.GetString("comboProblemType.Items6")});
            resources.ApplyResources(this.comboProblemType, "comboProblemType");
            this.comboProblemType.Name = "comboProblemType";
            this.comboProblemType.SelectedIndexChanged += new System.EventHandler(this.comboProblemType_SelectedIndexChanged);
            // 
            // comboSpecialist
            // 
            this.comboSpecialist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpecialist.FormattingEnabled = true;
            this.comboSpecialist.Items.AddRange(new object[] {
            resources.GetString("comboSpecialist.Items"),
            resources.GetString("comboSpecialist.Items1"),
            resources.GetString("comboSpecialist.Items2")});
            resources.ApplyResources(this.comboSpecialist, "comboSpecialist");
            this.comboSpecialist.Name = "comboSpecialist";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(193)))), ((int)(((byte)(207)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(106)))));
            this.btnCancel.Location = new System.Drawing.Point(251, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 37);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddRequestForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboSpecialist);
            this.Controls.Add(this.comboProblemType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboDepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtFullName);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddRequestForm";
            this.Load += new System.EventHandler(this.AddRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox comboPriority;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboProblemType;
        private System.Windows.Forms.ComboBox comboSpecialist;
        private System.Windows.Forms.Button btnCancel;
    }
}