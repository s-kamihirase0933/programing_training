using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace taskManagemetApp.src
{
    public partial class formHome : Form
    {
        private List<MyTask> taskList;   // 全データ
        private int pageSize = 10;       // 1ページあたりの行数
        private int currentPage = 1;     // 現在のページ
        



        public formHome()
        {
            InitializeComponent();
            this.dgvTaskList.CellFormatting += tblTaskList_CellFormatting;
            this.dgvTaskList.CellDoubleClick += dgvTaskList_CellDoubleClick;
            SetUpDataGridView();
            SelectAll();
            DisplayPage();
        }

        /*
         * ページ数表示
         */
        private void DisplayPage()
        {
            int skip = (currentPage - 1) * pageSize;
            var pageData = taskList.Skip(skip).Take(pageSize).ToList();

            dgvTaskList.DataSource = null;
            dgvTaskList.DataSource = pageData;

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

        /*
         * テキストボックス、コンボボックスの検索条件取得
         */
        public void GetConditions()
        {
            var conditionDict = new Dictionary<String, object>(); //検索条件を入れるDictionary

            String taskName = txtTaskName.Text;      //タスク名
            String taskType   = cboTaskType.Text;    //タスク分類
            String taskStart  = txtTaskStart.Text;   //タスク開始日
            String taskStatus = cboTaskStatus.Text;  //タスク状況
            String taskFinish = txtTaskFinish.Text;  //タスク完了日

            //検索条件が全て入っていない場合
            if (taskName == "" &&
               taskType == "" &&
               taskStart == "" &&
               taskStatus == "" &&
               taskFinish == "")
            {
                //全検索
                SelectAll();
            }
            else
            {
                //検索条件をDictionaryに追加
                //txtTaskName
                if (taskName != "")
                {
                    conditionDict["taskName"] = taskName;
                }
                //cboTaskType
                if (taskType != "")
                {
                    conditionDict["taskType"] = taskType;
                }
                //txtTaskStart
                if (taskStart != "")
                {
                    conditionDict["taskStart"] = taskStart;
                }
                //cboTaskStatus
                if (taskStatus != "")
                {
                    conditionDict["taskStatus"] = taskStatus;
                }
                //txtTaskFinish
                if (taskFinish != "")
                {
                    conditionDict["taskFinish"] = taskFinish;
                }

                SelectByCondition(conditionDict);
            }
        }

        public class MyTask
        {
            public string TaskType { get; set; }
            public string TaskStatus { get; set; }
            public string TaskName { get; set; }
            public int TaskProgress { get; set; }
            public string TaskStart { get; set; }
            public string TaskFinish { get; set; }
        }



        /*
         * 全検索
         */
        private void SelectAll()
        {
            String selectAllQuery = "SELECT task_type, task_status, task_name, task_progress, task_start, task_finish " +
                                    "FROM task_manage.task_info " +
                                    "WHERE task_holder_id = @taskHolderId";

            String loginUserId = LoginSession.LoginUserId;
            var parameters = new Dictionary<String, object>
            {
                {"@taskHolderId", loginUserId}
            };
            selectAllQuery += " ORDER BY task_type";
            LoadTasks(selectAllQuery, parameters);
        }
        
        /*
         * 条件検索
         */
        private void SelectByCondition(Dictionary<String, object> conditions)
        {
            String loginUserId = LoginSession.LoginUserId;
            String selectByConditionQuery = "SELECT task_type, task_status, task_name, task_progress, task_start, task_finish " +
                                            "FROM task_manage.task_info " +
                                            "WHERE task_holder_id = @taskHolderId";

            var parameters = new Dictionary<String, object>
            {
                {"@taskHolderId", loginUserId }
            };
            //conditionsにKeyがあれば取得してクエリに追加する
            //taskName
            if(conditions.TryGetValue("taskName", out object taskNameValue))
            {
                selectByConditionQuery += " AND task_name = @taskName";
                parameters["@taskName"] = taskNameValue;
            }
            //taskType
            if (conditions.TryGetValue("taskType", out object taskTypeValue))
            {
                selectByConditionQuery += " AND task_type = @taskType";
                parameters["@taskType"] = taskTypeValue;
            }
            //taskStart
            if (conditions.TryGetValue("taskStart", out object taskStartValue))
            {
                selectByConditionQuery  += " AND task_start = @taskStart";
                parameters["@taskStart"] = taskStartValue;
            }
            //taskStatus
            if (conditions.TryGetValue("taskStatus", out object taskStatusValue))
            {
                selectByConditionQuery   += " AND task_status = @taskStatus";
                parameters["@taskStatus"] = taskStatusValue;
            }
            //taskFinish
            if (conditions.TryGetValue("taskFinish", out object taskFinishValue))
            {
                selectByConditionQuery   += " AND task_finish = @taskFinish";
                parameters["@taskFinish"] = taskFinishValue;
            }
            selectByConditionQuery += " ORDER BY task_type";

            LoadTasks(selectByConditionQuery, parameters);
        }
        /*
         * タスク一覧表示
         */
        private void LoadTasks(String query, Dictionary<String, object> parameters)
        {
            taskList = new List<MyTask>();
            String connection = DbConfig.GetConnectionString();
            DatabaseHelper db = new DatabaseHelper(connection);
            var dt = db.ExecuteSelectQuery(query, parameters);
            if(dt == null) 
            {
                dgvTaskList.DataSource = new List<object>();
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                taskList.Add(new MyTask
                {
                    TaskType     = GetString(row, "task_type"),
                    TaskStatus   = GetString(row, "task_status"),
                    TaskName     = GetString(row, "task_name"),
                    TaskProgress = GetInt(row, "task_progress"),
                    TaskStart    = GetString(row, "task_start"),
                    TaskFinish   = GetString(row, "task_finish")
                });
            }
            BindTasksToGrid();
        }
        private string GetString(DataRow row, string column)
        {
            return row[column] != DBNull.Value ? row[column].ToString() : "";
        }

        private int GetInt(DataRow row, string column)
        {
            return row[column] != DBNull.Value ? Convert.ToInt32(row[column]) : 0;
        }

        private void SetUpDataGridView()
        {
            dgvTaskList.Columns.Clear(); // 既存の列を削除
            dgvTaskList.AutoGenerateColumns = false;

            // カラムを手動追加
            dgvTaskList.Columns.Add(CreateTextColumn("TaskType", "タスク分類"));
            dgvTaskList.Columns.Add(CreateTextColumn("TaskStatus", "タスク状況"));
            dgvTaskList.Columns.Add(CreateTextColumn("TaskName", "タスク名"));
            dgvTaskList.Columns.Add(CreateTextColumn("TaskProgress", "進捗"));
            dgvTaskList.Columns.Add(CreateTextColumn("TaskStart", "タスク開始日"));
            dgvTaskList.Columns.Add(CreateTextColumn("TaskFinish", "タスク完了日"));

            // チェックボックスカラムを作成
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";               // カラムのヘッダテキスト
            checkBoxColumn.Name = "CheckTask";         // カラム名（内部的に識別する用）
            dgvTaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            checkBoxColumn.Width = 25;                    // カラムの幅
            checkBoxColumn.TrueValue = true;
            checkBoxColumn.FalseValue = false;
            checkBoxColumn.ThreeState = false;            // チェックボックスは2状態（true/false）

            dgvTaskList.Columns.Add(checkBoxColumn);

            //
            foreach (DataGridViewColumn column in dgvTaskList.Columns)
            {
                column.ReadOnly = true;
            }

            dgvTaskList.Columns["CheckTask"].ReadOnly = false;
        }
        private void tblTaskList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTaskList.Columns[e.ColumnIndex].DataPropertyName == "TaskProgress")
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString() + " %";
                    e.FormattingApplied = true;
                }
            }

            // 日付のフォーマットをyyyy/MM/ddにする
            if (dgvTaskList.Columns[e.ColumnIndex].DataPropertyName == "TaskStart" ||
                dgvTaskList.Columns[e.ColumnIndex].DataPropertyName == "TaskFinish")
            {
                if (DateTime.TryParse(e.Value?.ToString(), out DateTime date))
                {
                    e.Value = date.ToString("yyyy/MM/dd");
                    e.FormattingApplied = true;
                }
            }
        }

        // DataGridViewにカラムを作成
        private DataGridViewTextBoxColumn CreateTextColumn(string dataPropertyName, string headerText)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = dataPropertyName,
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
        }

        private void BindTasksToGrid()
        {
            dgvTaskList.DataSource = null;
            dgvTaskList.DataSource = taskList;
        }

        /*
         * checkColumnのチェックボックスにチェックが入っている行のタスク名をListにしてDeleteTaskに渡す
         */
        private void GetcheckedRows()
        {
            List<String> selectedTaskName = new List<String>();
            foreach (DataGridViewRow row in dgvTaskList.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["colCheckTask"].Value);

                if (isChecked && row.DataBoundItem is MyTask task)
                {
                    selectedTaskName.Add(task.TaskName);
                }
            }
            if(selectedTaskName.Count == 0)
            {
                return;
            }
            DeleteTask(selectedTaskName);
        }

        /*
         * タスク削除
         */
        private void DeleteTask(List<String> deleteTask)
        {
            String deleteQuery = "DELETE FROM task_manage.task_info WHERE task_name in (";

            foreach (var item in deleteTask)
            {
                deleteQuery += "\"" + item.ToString() + "\"" + ",";
            }
            
            deleteQuery = deleteQuery.Substring(0, deleteQuery.Length - 1); //末尾の","を消す
            deleteQuery += ")";                                             //末尾に")"を付ける

            String connection = DbConfig.GetConnectionString();
            DatabaseHelper db = new DatabaseHelper(connection);
            db.ExecuteIUDQuery(deleteQuery);
        }



        private void dtpTaskStart_ValueChanged(object sender, EventArgs e)
        {
            txtTaskStart.Text = dtpTaskStart.Value.ToString("yyyy/MM/dd");
        }

        private void dtpTaskFinish_ValueChanged(object sender, EventArgs e)
        {
            txtTaskFinish.Text = dtpTaskFinish.Value.ToString("yyyy/MM/dd");
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に削除しますか？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {
                GetcheckedRows();
                SelectAll();
            }
            else
            {
                return;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetConditions();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTaskName.Text   = string.Empty;  //txtTaskNameをクリア

            cboTaskStatus.Text = string.Empty;  //cboTaskStatusをクリア
            
            txtTaskStart.Text  = string.Empty;  //txtTaskStartをクリア
            
            cboTaskType.Text   = string.Empty;  //cboTaskTypeをクリア
            
            txtTaskFinish.Text = string.Empty;  //txtTaskFinishをクリア

            //一覧のチェックボックスをクリア
            foreach (DataGridViewRow row in dgvTaskList.Rows)
            {
                row.Cells["CheckTask"].Value = false;
            }
        }

        /*
         * タスク名セル押下時イベント
         */
        private void dgvTaskList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int columnIndex = e.ColumnIndex;
                string columnName = dgvTaskList.Columns[columnIndex].Name;

                if (columnName == "TaskName")
                {
                    var formTaskEdit = new formTaskEdit(this);
                    formTaskEdit.SetClickedTaskName(dgvTaskList.Rows[e.RowIndex].Cells["TaskName"].Value?.ToString());
                    formTaskEdit.ShowDialog();
                    
                }
            }
        }

        /*
         * タスク追加ボタン押下イベント
         */
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            formTaskEdit formTaskEdit = new formTaskEdit(this);
            formTaskEdit.SetClickedTaskName(null);
            formTaskEdit.ShowDialog();
        }

        /*
         * 再ロード
         */
        public void ReloadTaskList()
        {
            SetUpDataGridView();
            SelectAll();
            DisplayPage();
        }
    }
}
