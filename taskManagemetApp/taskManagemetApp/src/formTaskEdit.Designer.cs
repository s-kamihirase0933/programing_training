namespace taskManagemetApp.src
{
    partial class formTaskEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTaskEdit));
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.lblTaskStart = new System.Windows.Forms.Label();
            this.lblTaskFinish = new System.Windows.Forms.Label();
            this.cboTaskType = new System.Windows.Forms.ComboBox();
            this.cboTaskStatus = new System.Windows.Forms.ComboBox();
            this.dtpTaskStart = new System.Windows.Forms.DateTimePicker();
            this.dtpTaskFinish = new System.Windows.Forms.DateTimePicker();
            this.txtTaskStart = new System.Windows.Forms.TextBox();
            this.txtTaskFinish = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTaskName
            // 
            resources.ApplyResources(this.lblTaskName, "lblTaskName");
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtTaskName, "txtTaskName");
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.TextChanged += new System.EventHandler(this.txtTaskName_TextChanged);
            this.txtTaskName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaskName_KeyPress);
            // 
            // lblTaskType
            // 
            resources.ApplyResources(this.lblTaskType, "lblTaskType");
            this.lblTaskType.Name = "lblTaskType";
            // 
            // lblTaskStatus
            // 
            resources.ApplyResources(this.lblTaskStatus, "lblTaskStatus");
            this.lblTaskStatus.Name = "lblTaskStatus";
            // 
            // lblTaskStart
            // 
            resources.ApplyResources(this.lblTaskStart, "lblTaskStart");
            this.lblTaskStart.Name = "lblTaskStart";
            // 
            // lblTaskFinish
            // 
            resources.ApplyResources(this.lblTaskFinish, "lblTaskFinish");
            this.lblTaskFinish.Name = "lblTaskFinish";
            // 
            // cboTaskType
            // 
            this.cboTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboTaskType, "cboTaskType");
            this.cboTaskType.FormattingEnabled = true;
            this.cboTaskType.Items.AddRange(new object[] {
            resources.GetString("cboTaskType.Items"),
            resources.GetString("cboTaskType.Items1"),
            resources.GetString("cboTaskType.Items2"),
            resources.GetString("cboTaskType.Items3"),
            resources.GetString("cboTaskType.Items4"),
            resources.GetString("cboTaskType.Items5"),
            resources.GetString("cboTaskType.Items6"),
            resources.GetString("cboTaskType.Items7"),
            resources.GetString("cboTaskType.Items8")});
            this.cboTaskType.Name = "cboTaskType";
            // 
            // cboTaskStatus
            // 
            this.cboTaskStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboTaskStatus, "cboTaskStatus");
            this.cboTaskStatus.FormattingEnabled = true;
            this.cboTaskStatus.Items.AddRange(new object[] {
            resources.GetString("cboTaskStatus.Items"),
            resources.GetString("cboTaskStatus.Items1"),
            resources.GetString("cboTaskStatus.Items2"),
            resources.GetString("cboTaskStatus.Items3")});
            this.cboTaskStatus.Name = "cboTaskStatus";
            // 
            // dtpTaskStart
            // 
            resources.ApplyResources(this.dtpTaskStart, "dtpTaskStart");
            this.dtpTaskStart.Name = "dtpTaskStart";
            this.dtpTaskStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpTaskFinish
            // 
            resources.ApplyResources(this.dtpTaskFinish, "dtpTaskFinish");
            this.dtpTaskFinish.Name = "dtpTaskFinish";
            this.dtpTaskFinish.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtTaskStart
            // 
            this.txtTaskStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtTaskStart, "txtTaskStart");
            this.txtTaskStart.Name = "txtTaskStart";
            this.txtTaskStart.ReadOnly = true;
            // 
            // txtTaskFinish
            // 
            this.txtTaskFinish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtTaskFinish, "txtTaskFinish");
            this.txtTaskFinish.Name = "txtTaskFinish";
            this.txtTaskFinish.ReadOnly = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblProgress
            // 
            resources.ApplyResources(this.lblProgress, "lblProgress");
            this.lblProgress.Name = "lblProgress";
            // 
            // txtProgress
            // 
            this.txtProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtProgress, "txtProgress");
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.TextChanged += new System.EventHandler(this.txtProgress_TextChanged);
            this.txtProgress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProgress_KeyPress);
            // 
            // lblPercent
            // 
            resources.ApplyResources(this.lblPercent, "lblPercent");
            this.lblPercent.Name = "lblPercent";
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Name = "lblError";
            // 
            // formTaskEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpTaskFinish);
            this.Controls.Add(this.dtpTaskStart);
            this.Controls.Add(this.cboTaskStatus);
            this.Controls.Add(this.cboTaskType);
            this.Controls.Add(this.lblTaskFinish);
            this.Controls.Add(this.lblTaskStart);
            this.Controls.Add(this.lblTaskStatus);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.txtTaskStart);
            this.Controls.Add(this.txtTaskFinish);
            this.Name = "formTaskEdit";
            this.Load += new System.EventHandler(this.formTaskEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.Label lblTaskStatus;
        private System.Windows.Forms.Label lblTaskStart;
        private System.Windows.Forms.Label lblTaskFinish;
        private System.Windows.Forms.ComboBox cboTaskType;
        private System.Windows.Forms.ComboBox cboTaskStatus;
        private System.Windows.Forms.DateTimePicker dtpTaskStart;
        private System.Windows.Forms.DateTimePicker dtpTaskFinish;
        private System.Windows.Forms.TextBox txtTaskStart;
        private System.Windows.Forms.TextBox txtTaskFinish;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblError;
    }
}