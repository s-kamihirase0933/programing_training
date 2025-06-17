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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace taskManagemetApp.src
{
    public partial class frmTaskList : Form
    {
        private List<myTask> taskList;   // 全データ
        private int pageSize = 10;       // 1ページあたりの行数
        private int currentPage = 1;     // 現在のページ
        



        public frmTaskList()
        {
            InitializeComponent();
            this.dgvTaskList.CellFormatting += tblTaskList_CellFormatting;
            this.dgvTaskList.CellDoubleClick += dgvTaskList_CellDoubleClick;
            setUpDataGridView();
            selectAll();
            displayPage();
        }

        /*
         * ページ数表示
         */
        private void displayPage()
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
                displayPage();
            }
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                displayPage();
            }
        }

        /*
         * テキストボックス、コンボボックスの検索条件取得
         */
        public void getConditions()
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
                selectAll();
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

                selectByCondition(conditionDict);
            }
        }

        public class myTask
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
        private void selectAll()
        {
            String selectAllQuery = "SELECT task_type, task_status, task_name, task_progress, task_start, task_finish " +
                                    "FROM task_manage.task_info " +
                                    "WHERE task_holder_id = @taskHolderId ";

            String loginUserId = LoginSession.LoginUserId;
            var parameters = new Dictionary<String, object>
            {
                {"@taskHolderId", loginUserId}
            };
            selectAllQuery += "ORDER BY " +
                              "CASE " +
                              "WHEN LOWER(TRIM(task_status)) = '完了' THEN 2 " +
                              "WHEN task_start IS NULL THEN 1 " +
                              "ELSE 0 " +
                              "END, " +
                              "task_start ASC";
            loadTasks(selectAllQuery, parameters);
        }
        
        /*
         * 条件検索
         */
        private void selectByCondition(Dictionary<String, object> conditions)
        {
            String loginUserId = LoginSession.LoginUserId;
            String selectByConditionQuery = "SELECT task_type, task_status, task_name, task_progress, task_start, task_finish " +
                                            "FROM task_manage.task_info " +
                                            "WHERE task_holder_id = @taskHolderId ";

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
            selectByConditionQuery += " ORDER BY task_start IS NULL ASC, task_start ASC";

            loadTasks(selectByConditionQuery, parameters);
        }
        /*
         * タスク一覧表示
         */
        private void loadTasks(String query, Dictionary<String, object> parameters)
        {
            taskList = new List<myTask>();
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
                taskList.Add(new myTask
                {
                    TaskType     = getString(row, "task_type"),
                    TaskStatus   = getString(row, "task_status"),
                    TaskName     = getString(row, "task_name"),
                    TaskProgress = getInt(row, "task_progress"),
                    TaskStart    = getString(row, "task_start"),
                    TaskFinish   = getString(row, "task_finish")
                });
            }
            bindTasksToGrid();
        }
        private string getString(DataRow row, string column)
        {
            return row[column] != DBNull.Value ? row[column].ToString() : "";
        }

        private int getInt(DataRow row, string column)
        {
            return row[column] != DBNull.Value ? Convert.ToInt32(row[column]) : 0;
        }

        private void setUpDataGridView()
        {
            dgvTaskList.Columns.Clear(); // 既存の列を削除
            dgvTaskList.AutoGenerateColumns = false;

            // カラムを手動追加
            dgvTaskList.Columns.Add(createTextColumn("TaskType", "タスク分類"));
            dgvTaskList.Columns.Add(createTextColumn("TaskStatus", "タスク状況"));
            dgvTaskList.Columns.Add(createTextColumn("TaskName", "タスク名"));
            dgvTaskList.Columns.Add(createTextColumn("TaskProgress", "進捗"));
            dgvTaskList.Columns.Add(createTextColumn("TaskStart", "タスク開始日"));
            dgvTaskList.Columns.Add(createTextColumn("TaskFinish", "タスク完了日"));

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

            //dgvTaskListを読み取り専用に
            foreach (DataGridViewColumn column in dgvTaskList.Columns)
            {
                column.ReadOnly = true;
            }
            //checkTaskカラムのみ編集可に
            dgvTaskList.Columns["CheckTask"].ReadOnly = false;

            //TaskNameカラムのテキストを青色、アンダーバーにする
            dgvTaskList.Columns["TaskName"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvTaskList.Columns["TaskName"].DefaultCellStyle.Font = new Font(dgvTaskList.Font, FontStyle.Underline);
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
        private DataGridViewTextBoxColumn createTextColumn(string dataPropertyName, string headerText)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = dataPropertyName,
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
        }

        private void bindTasksToGrid()
        {
            dgvTaskList.DataSource = null;
            dgvTaskList.DataSource = taskList;
        }

        /*
         * checkColumnのチェックボックスにチェックが入っている行のタスク名をListにしてDeleteTaskに渡す
         */
        private void getcheckedRows()
        {
            List<String> selectedTaskName = new List<String>();
            foreach (DataGridViewRow row in dgvTaskList.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["CheckTask"].Value);

                if (isChecked && row.DataBoundItem is myTask task)
                {
                    selectedTaskName.Add(task.TaskName);
                }
            }
            if(selectedTaskName.Count == 0)
            {
                return;
            }
            deleteTask(selectedTaskName);
        }

        /*
         * タスク削除
         */
        private void deleteTask(List<String> deleteTask)
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
                getcheckedRows();
                selectAll();
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
            getConditions();
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
                    var formTaskEdit = new frmTaskEdit(this);
                    formTaskEdit.setClickedTaskName(dgvTaskList.Rows[e.RowIndex].Cells["TaskName"].Value?.ToString());
                    formTaskEdit.ShowDialog();
                    
                }
            }
        }

        /*
         * タスク追加ボタン押下イベント
         */
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            frmTaskEdit formTaskEdit = new frmTaskEdit(this);
            formTaskEdit.setClickedTaskName(null);
            formTaskEdit.ShowDialog();
        }

        /*
         * 再ロード
         */
        public void searchTasks()
        {
            btnSearch.PerformClick();
        }

        /*
         * ↓ラベルクリックイベント
         */
        private void lblTaskName_Click(object sender, EventArgs e)
        {
            txtTaskName.Focus();
        }

        private void lblTaskStatus_Click(object sender, EventArgs e)
        {
            cboTaskStatus.DroppedDown = true;
        }

        private void lblTaskStart_Click(object sender, EventArgs e)
        {
            dtpTaskStart.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void lblTaskType_Click(object sender, EventArgs e)
        {
            cboTaskType.DroppedDown = true;
        }

        private void lblTaskFinish_Click(object sender, EventArgs e)
        {
            dtpTaskFinish.Focus();
            SendKeys.Send("%{DOWN}");

        }
        /*
         * 日付の削除のみを許可
         */
        //削除のみ許可
        private void permitDeleteOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTaskStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitDeleteOnly(e);
        }

        private void txtTaskFinish_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitDeleteOnly(e);
        }

        //Ctrl + Vをブロック
        private void blockPasteShortCut(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void txtTaskStart_KeyDown(object sender, KeyEventArgs e)
        {
            blockPasteShortCut(e);
        }

        private void txtTaskFinish_KeyDown(object sender, KeyEventArgs e)
        {
            blockPasteShortCut(e);
        }

        //右クリック→貼り付けをブロック
        private void txtTaskStart_ContextMenuStripChanged(object sender, EventArgs e)
        {
            txtTaskStart.ContextMenuStrip = null;
        }

        private void txtTaskFinish_ContextMenuStripChanged(object sender, EventArgs e)
        {
            txtTaskFinish.ContextMenuStrip = null;
        }

    }
}
