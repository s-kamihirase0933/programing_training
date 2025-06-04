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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLogout = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblTaskList = new System.Windows.Forms.DataGridView();
            this.taskType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.column = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtTaskStart = new System.Windows.Forms.TextBox();
            this.txtTaskFinish = new System.Windows.Forms.TextBox();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaskList)).BeginInit();
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
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(144, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "タスク名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(886, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "タスク開始日：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(886, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "タスク完了日：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(498, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "タスク状況：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "(未選択)",
            "未着手",
            "着手中",
            "完了"});
            this.comboBox2.Location = new System.Drawing.Point(620, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(260, 26);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "(未選択)",
            "製造",
            "単体試験仕様書",
            "単体試験実施",
            "結合試験",
            "その他"});
            this.comboBox3.Location = new System.Drawing.Point(144, 115);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(176, 26);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.Tag = "";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(33, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "タスク分類：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1402, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 84);
            this.button1.TabIndex = 14;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tblTaskList
            // 
            this.tblTaskList.AllowUserToAddRows = false;
            this.tblTaskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTaskList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblTaskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblTaskList.ColumnHeadersHeight = 40;
            this.tblTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskType,
            this.taskStatus,
            this.taskName,
            this.taskProgress,
            this.taskStart,
            this.taskFinish});
            this.tblTaskList.EnableHeadersVisualStyles = false;
            this.tblTaskList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblTaskList.Location = new System.Drawing.Point(33, 187);
            this.tblTaskList.Name = "tblTaskList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTaskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblTaskList.RowHeadersVisible = false;
            this.tblTaskList.RowHeadersWidth = 4;
            this.tblTaskList.RowTemplate.Height = 27;
            this.tblTaskList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tblTaskList.Size = new System.Drawing.Size(1653, 587);
            this.tblTaskList.TabIndex = 15;
            this.tblTaskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblList_CellContentClick);
            // 
            // taskType
            // 
            this.taskType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskType.FillWeight = 70F;
            this.taskType.HeaderText = "分類";
            this.taskType.MinimumWidth = 8;
            this.taskType.Name = "taskType";
            this.taskType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // taskStatus
            // 
            this.taskStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskStatus.FillWeight = 50F;
            this.taskStatus.HeaderText = "タスク状況";
            this.taskStatus.MinimumWidth = 8;
            this.taskStatus.Name = "taskStatus";
            this.taskStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // taskName
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.taskName.DefaultCellStyle = dataGridViewCellStyle2;
            this.taskName.HeaderText = "タスク名";
            this.taskName.MinimumWidth = 8;
            this.taskName.Name = "taskName";
            this.taskName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // taskProgress
            // 
            this.taskProgress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskProgress.FillWeight = 66F;
            this.taskProgress.HeaderText = "進捗";
            this.taskProgress.MinimumWidth = 8;
            this.taskProgress.Name = "taskProgress";
            this.taskProgress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // taskStart
            // 
            this.taskStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskStart.FillWeight = 80F;
            this.taskStart.HeaderText = "タスク開始日";
            this.taskStart.MinimumWidth = 8;
            this.taskStart.Name = "taskStart";
            this.taskStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // taskFinish
            // 
            this.taskFinish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskFinish.FillWeight = 80F;
            this.taskFinish.HeaderText = "タスク完了日";
            this.taskFinish.MinimumWidth = 8;
            this.taskFinish.Name = "taskFinish";
            this.taskFinish.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1271, 58);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 84);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(1636, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 48);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // column
            // 
            this.column.MinimumWidth = 8;
            this.column.Name = "column";
            this.column.UseColumnTextForLinkValue = true;
            this.column.Width = 150;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1197, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(26, 25);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1197, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(26, 25);
            this.dateTimePicker2.TabIndex = 20;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtTaskStart
            // 
            this.txtTaskStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskStart.Location = new System.Drawing.Point(1018, 57);
            this.txtTaskStart.Name = "txtTaskStart";
            this.txtTaskStart.Size = new System.Drawing.Size(205, 25);
            this.txtTaskStart.TabIndex = 21;
            // 
            // txtTaskFinish
            // 
            this.txtTaskFinish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskFinish.Location = new System.Drawing.Point(1018, 115);
            this.txtTaskFinish.Name = "txtTaskFinish";
            this.txtTaskFinish.Size = new System.Drawing.Size(205, 25);
            this.txtTaskFinish.TabIndex = 22;
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Location = new System.Drawing.Point(742, 802);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(216, 39);
            this.lblCurrentPage.TabIndex = 23;
            this.lblCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(980, 802);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(107, 39);
            this.btnNextPage.TabIndex = 24;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.Location = new System.Drawing.Point(615, 802);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(107, 39);
            this.btnBackPage.TabIndex = 25;
            this.btnBackPage.Text = "Back";
            this.btnBackPage.UseVisualStyleBackColor = true;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(1564, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 48);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1750, 869);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tblTaskList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtTaskStart);
            this.Controls.Add(this.txtTaskFinish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHome";
            this.Text = "taskManager - ホーム";
            ((System.ComponentModel.ISupportInitialize)(this.tblTaskList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tblTaskList;
        private Button btnClear;
        private Button button2;
        private DataGridViewLinkColumn column;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox txtTaskStart;
        private TextBox txtTaskFinish;
        private Label lblCurrentPage;
        private Button btnNextPage;
        private Button btnBackPage;
        private DataGridViewTextBoxColumn taskType;
        private DataGridViewTextBoxColumn taskStatus;
        private DataGridViewTextBoxColumn taskName;
        private DataGridViewTextBoxColumn taskProgress;
        private DataGridViewTextBoxColumn taskStart;
        private DataGridViewTextBoxColumn taskFinish;
        private Button button3;
    }
}