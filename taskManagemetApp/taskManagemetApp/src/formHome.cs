using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskManagemetApp.src
{
    public partial class formHome : Form
    {
        private List<MyTask> taskList; // 全データ
        private int pageSize = 10;     // 1ページあたりの行数
        private int currentPage = 1;   // 現在のページ

        public formHome()
        {
            InitializeComponent();
            this.tblTaskList.CellFormatting += tblTaskList_CellFormatting;
            SetUpDataGridView();
            LoadTasks(); 
            BindTasksToGrid();
            DisplayPage();
        }

        private void DisplayPage()
        {
            int skip = (currentPage - 1) * pageSize;
            var pageData = taskList.Skip(skip).Take(pageSize).ToList();


            // ページ情報を表示（ラベルなど）
            lblCurrentPage.Text = $"ページ {currentPage} / {Math.Ceiling((double)taskList.Count / pageSize)}";
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < (int)Math.Ceiling((double)taskList.Count / pageSize))
            {
                currentPage++;
                DisplayPage();
            }
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayPage();
            }
        }


        public class MyTask
        {
            public string TaskType { get; set; }
            public string TaskStatus { get; set; }
            public string TaskName { get; set; }
            public int TaskProgress { get; set; }
            public string TaskStart { get; set; }
            public string TaskEnd { get; set; }
        }


        
        private void LoadTasks()
        {
            
            taskList = new List<MyTask>();
            string sql = "SELECT task_type, task_status, task_name, task_progress, task_start, task_finish FROM task_manage.task_info";
            String connection = "Server=localhost;Database=task_manage;Uid=root;Pwd=atgs0933";
            DatabaseHelper db = new DatabaseHelper(connection);

            var dt = db.ExecuteSelectQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                taskList.Add(new MyTask
                {
                    TaskType = row["task_type"].ToString(),
                    TaskStatus = row["task_status"].ToString(),
                    TaskName = row["task_name"].ToString(),
                    TaskProgress = int.Parse(row["task_progress"].ToString()),
                    TaskStart = row["task_start"].ToString(),
                    TaskEnd = row["task_finish"].ToString()
                });
            }
        }
        private void SetUpDataGridView()
        {
            tblTaskList.Columns.Clear(); // 既存の列を削除
            tblTaskList.AutoGenerateColumns = false;

            // カラムを手動追加
            tblTaskList.Columns.Add(CreateTextColumn("TaskType", "タスク分類"));
            tblTaskList.Columns.Add(CreateTextColumn("TaskStatus", "タスク状況"));
            tblTaskList.Columns.Add(CreateTextColumn("TaskName", "タスク名"));
            tblTaskList.Columns.Add(CreateTextColumn("TaskProgress", "進捗"));
            tblTaskList.Columns.Add(CreateTextColumn("TaskStart", "タスク開始日"));
            tblTaskList.Columns.Add(CreateTextColumn("TaskEnd", "タスク完了日"));

            // チェックボックスカラムを作成
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";          // カラムのヘッダテキスト
            checkBoxColumn.Name = "checkColumn";         // カラム名（内部的に識別する用）
            tblTaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            checkBoxColumn.Width = 25;                   // カラムの幅
            checkBoxColumn.TrueValue = true;
            checkBoxColumn.FalseValue = false;
            checkBoxColumn.ThreeState = false;           // チェックボックスは2状態（true/false）

            tblTaskList.Columns.Add(checkBoxColumn);
        }
        private void tblTaskList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tblTaskList.Columns[e.ColumnIndex].DataPropertyName == "TaskProgress")
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString() + " %";
                    e.FormattingApplied = true;
                }
            }

            // 日付のフォーマット（次で説明）
            if (tblTaskList.Columns[e.ColumnIndex].DataPropertyName == "TaskStart" ||
                tblTaskList.Columns[e.ColumnIndex].DataPropertyName == "TaskEnd")
            {
                if (DateTime.TryParse(e.Value?.ToString(), out DateTime date))
                {
                    e.Value = date.ToString("yyyy/MM/dd");
                    e.FormattingApplied = true;
                }
            }
        }

        // 共通のテキスト列作成メソッド
        private DataGridViewTextBoxColumn CreateTextColumn(string dataPropertyName, string headerText)
        {
            return new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName, // バインド先のプロパティ名
                HeaderText = headerText,             // 表示するカラム名（日本語）
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
        }


        private void BindTasksToGrid()
        {
            tblTaskList.DataSource = null;
            tblTaskList.DataSource = taskList;
        }

        private void tblList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int columnIndex = e.ColumnIndex;
                string columnName = tblTaskList.Columns[columnIndex].Name;

                if (columnName == "taskName")
                {
                    formTaskEdit formTaskEdit = new formTaskEdit();
                    formTaskEdit.Show();
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtTaskStart.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtTaskFinish.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に削除しますか？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        
    }
}
