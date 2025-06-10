using System.Drawing;
using System.Windows.Forms;

namespace taskManagemetApp.src
{
    partial class formHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskStart = new System.Windows.Forms.Label();
            this.lblTaskFinish = new System.Windows.Forms.Label();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.cboTaskStatus = new System.Windows.Forms.ComboBox();
            this.cboTaskType = new System.Windows.Forms.ComboBox();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.column = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dtpTaskFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpTaskStart = new System.Windows.Forms.DateTimePicker();
            this.txtTaskStart = new System.Windows.Forms.TextBox();
            this.txtTaskFinish = new System.Windows.Forms.TextBox();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(1612, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 42);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "ログアウト";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskName.Location = new System.Drawing.Point(144, 58);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(350, 25);
            this.txtTaskName.TabIndex = 2;
            // 
            // lblTaskName
            // 
            this.lblTaskName.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaskName.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTaskName.Location = new System.Drawing.Point(33, 58);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(103, 25);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "タスク名：";
            this.lblTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaskStart
            // 
            this.lblTaskStart.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaskStart.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTaskStart.Location = new System.Drawing.Point(886, 58);
            this.lblTaskStart.Name = "lblTaskStart";
            this.lblTaskStart.Size = new System.Drawing.Size(132, 25);
            this.lblTaskStart.TabIndex = 6;
            this.lblTaskStart.Text = "タスク開始日：";
            this.lblTaskStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskFinish
            // 
            this.lblTaskFinish.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaskFinish.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTaskFinish.Location = new System.Drawing.Point(886, 116);
            this.lblTaskFinish.Name = "lblTaskFinish";
            this.lblTaskFinish.Size = new System.Drawing.Size(132, 25);
            this.lblTaskFinish.TabIndex = 8;
            this.lblTaskFinish.Text = "タスク完了日：";
            this.lblTaskFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaskStatus.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTaskStatus.Location = new System.Drawing.Point(498, 56);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Size = new System.Drawing.Size(119, 27);
            this.lblTaskStatus.TabIndex = 10;
            this.lblTaskStatus.Text = "タスク状況：";
            this.lblTaskStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTaskStatus
            // 
            this.cboTaskStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTaskStatus.FormattingEnabled = true;
            this.cboTaskStatus.Items.AddRange(new object[] {
            "",
            "未着手",
            "着手中",
            "完了"});
            this.cboTaskStatus.Location = new System.Drawing.Point(620, 58);
            this.cboTaskStatus.Name = "cboTaskStatus";
            this.cboTaskStatus.Size = new System.Drawing.Size(260, 26);
            this.cboTaskStatus.TabIndex = 11;
            // 
            // cboTaskType
            // 
            this.cboTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTaskType.FormattingEnabled = true;
            this.cboTaskType.Items.AddRange(new object[] {
            "",
            "事務作業",
            "資料作成",
            "ミーティング",
            "コーディング",
            "仕様書作成",
            "レビュー",
            "顧客対応",
            "その他"});
            this.cboTaskType.Location = new System.Drawing.Point(144, 115);
            this.cboTaskType.Name = "cboTaskType";
            this.cboTaskType.Size = new System.Drawing.Size(176, 26);
            this.cboTaskType.TabIndex = 13;
            this.cboTaskType.Tag = "";
            // 
            // lblTaskType
            // 
            this.lblTaskType.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaskType.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTaskType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTaskType.Location = new System.Drawing.Point(33, 116);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(111, 25);
            this.lblTaskType.TabIndex = 12;
            this.lblTaskType.Text = "タスク分類：";
            this.lblTaskType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1402, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 84);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.AllowUserToAddRows = false;
            this.dgvTaskList.AllowUserToDeleteRows = false;
            this.dgvTaskList.AllowUserToResizeColumns = false;
            this.dgvTaskList.AllowUserToResizeRows = false;
            this.dgvTaskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaskList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTaskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaskList.ColumnHeadersHeight = 40;
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTaskList.EnableHeadersVisualStyles = false;
            this.dgvTaskList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTaskList.Location = new System.Drawing.Point(33, 187);
            this.dgvTaskList.Name = "dgvTaskList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaskList.RowHeadersVisible = false;
            this.dgvTaskList.RowHeadersWidth = 4;
            this.dgvTaskList.RowTemplate.Height = 27;
            this.dgvTaskList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTaskList.Size = new System.Drawing.Size(1653, 497);
            this.dgvTaskList.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1271, 58);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 84);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTask.BackgroundImage")));
            this.btnAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTask.Location = new System.Drawing.Point(1636, 133);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(50, 48);
            this.btnAddTask.TabIndex = 17;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // column
            // 
            this.column.MinimumWidth = 8;
            this.column.Name = "column";
            this.column.UseColumnTextForLinkValue = true;
            this.column.Width = 150;
            // 
            // dtpTaskFinish
            // 
            this.dtpTaskFinish.Location = new System.Drawing.Point(1197, 115);
            this.dtpTaskFinish.Name = "dtpTaskFinish";
            this.dtpTaskFinish.Size = new System.Drawing.Size(26, 25);
            this.dtpTaskFinish.TabIndex = 19;
            this.dtpTaskFinish.ValueChanged += new System.EventHandler(this.dtpTaskFinish_ValueChanged);
            // 
            // dtpTaskStart
            // 
            this.dtpTaskStart.Location = new System.Drawing.Point(1197, 57);
            this.dtpTaskStart.Name = "dtpTaskStart";
            this.dtpTaskStart.Size = new System.Drawing.Size(26, 25);
            this.dtpTaskStart.TabIndex = 20;
            this.dtpTaskStart.ValueChanged += new System.EventHandler(this.dtpTaskStart_ValueChanged);
            // 
            // txtTaskStart
            // 
            this.txtTaskStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskStart.Location = new System.Drawing.Point(1018, 57);
            this.txtTaskStart.Name = "txtTaskStart";
            this.txtTaskStart.ReadOnly = true;
            this.txtTaskStart.Size = new System.Drawing.Size(205, 25);
            this.txtTaskStart.TabIndex = 21;
            // 
            // txtTaskFinish
            // 
            this.txtTaskFinish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskFinish.Location = new System.Drawing.Point(1018, 115);
            this.txtTaskFinish.Name = "txtTaskFinish";
            this.txtTaskFinish.ReadOnly = true;
            this.txtTaskFinish.Size = new System.Drawing.Size(205, 25);
            this.txtTaskFinish.TabIndex = 22;
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Location = new System.Drawing.Point(743, 741);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(216, 39);
            this.lblCurrentPage.TabIndex = 23;
            this.lblCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(981, 741);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(107, 39);
            this.btnNextPage.TabIndex = 24;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.Location = new System.Drawing.Point(616, 741);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(107, 39);
            this.btnBackPage.TabIndex = 25;
            this.btnBackPage.Text = "Back";
            this.btnBackPage.UseVisualStyleBackColor = true;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteTask.BackgroundImage")));
            this.btnDeleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteTask.Location = new System.Drawing.Point(1564, 133);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(50, 48);
            this.btnDeleteTask.TabIndex = 26;
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1750, 795);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.dtpTaskStart);
            this.Controls.Add(this.dtpTaskFinish);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvTaskList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboTaskType);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.cboTaskStatus);
            this.Controls.Add(this.lblTaskStatus);
            this.Controls.Add(this.lblTaskFinish);
            this.Controls.Add(this.lblTaskStart);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtTaskStart);
            this.Controls.Add(this.txtTaskFinish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHome";
            this.Text = "taskManager - ホーム";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblTaskStart;
        private System.Windows.Forms.Label lblTaskFinish;
        private System.Windows.Forms.Label lblTaskStatus;
        private System.Windows.Forms.ComboBox cboTaskStatus;
        private System.Windows.Forms.ComboBox cboTaskType;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.DataGridView dgvTaskList;
        private Button btnClear;
        private Button btnAddTask;
        private DataGridViewLinkColumn column;
        private DateTimePicker dtpTaskFinish;
        private DateTimePicker dtpTaskStart;
        private TextBox txtTaskStart;
        private TextBox txtTaskFinish;
        private Label lblCurrentPage;
        private Button btnNextPage;
        private Button btnBackPage;
        private Button btnDeleteTask;
        public Button btnSearch;
    }
}