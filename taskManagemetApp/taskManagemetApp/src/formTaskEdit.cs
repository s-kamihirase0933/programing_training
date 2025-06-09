using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace taskManagemetApp.src
{
    public partial class formTaskEdit : Form
    {
        private String clickedTaskName;  // クリックされたタスク
        public void SetClickedTaskName(String clickedTaskName)
        {
            this.clickedTaskName = clickedTaskName;
        }
        public String GetClickedTaskName()
        {
            return clickedTaskName;
        }
        public formTaskEdit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtTaskStart.Text = dtpTaskStart.Value.ToString("yyyy/MM/dd");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtTaskFinish.Text = dtpTaskStart.Value.ToString("yyyy/MM/dd");
        }

        private void formTaskEdit_Load(object sender, EventArgs e)
        {
            ClickedContent(this.clickedTaskName);
        }

        /*
         * タスク編集モードorタスク追加モード
         * 条件：
         * taskNameがNULL　　　→タスク追加モード
         * taskNameがNULLでない→タスク編集モード
         */
        private void ClickedContent(String taskName)
        {
            if(taskName != null)
            {
                showTaskInfo();
            }
            else
            {

            }
        }

        /*
         * 両モード共通
         */

        private String taskName;      //タスク名
        private String taskType;      //タスク分類
        private String taskStatus;    //タスク状況
        private String taskProgress;  //タスク進捗
        private String taskStart;     //タスク開始日
        private String taskFinish;    //タスク完了日

        //入力されたタスク情報を取得し、チェック/変換
        private bool GetTaskInfo_Check_Convert()
        {
            bool chkResult = true;
            //入力されたタスク情報を取得
            taskName = txtTaskName.Text;   //タスク名
            taskType = cboTaskType.Text;   //タスク分類
            taskStatus = cboTaskStatus.Text; //タスク状況
            taskProgress = txtProgress.Text;   //タスク進捗
            taskStart = txtTaskStart.Text;  //タスク開始日
            taskFinish = txtTaskFinish.Text; //タスク完了日

            /*
             * 各項目のチェック/変換
             */
            //タスク名
            if (taskName == "")
            {
                showErrorMsg("NAME_NULL");
                chkResult = false;
            }

            //タスク状況
            if(taskProgress == "100")
            {
                taskStatus = "完了";
            }

            if(taskStatus == "完了" && taskFinish == "")
            {
                showErrorMsg("TASK_FINISH_NULL");
                chkResult = false;
            }

            DateTime taskStartDate;   //タスク開始日(DateTime型)
            DateTime taskFinishDate;  //タスク完了日(DateTime型)
            //タスク開始日、完了日
            if(taskStart != "" && taskFinish != "")
            {
                DateTime.TryParse(taskStart, out taskStartDate);
                DateTime.TryParse(taskFinish, out taskFinishDate);

                if(taskStartDate > taskFinishDate)
                {
                    taskFinish = ""; //タスク開始日がタスク完了日の後の場合、タスク完了日を消す
                }
            }
            
            return chkResult;
        }

        /*
         * txtProgressに入力された数値以外の文字をブロック
         */
        private void txtProgress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*
         * txtProgressに入力された全角数値をリアルタイムで半角数値に変換
         */
        private void txtProgress_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as System.Windows.Forms.TextBox;
            if (tb == null) return;

            int selectionStart = tb.SelectionStart;
            string originalText = tb.Text;

            string converted = ToHalfWidthNumbers(originalText);

            if (converted != originalText)
            {
                tb.Text = converted;

                tb.SelectionStart = selectionStart > tb.Text.Length ? tb.Text.Length : selectionStart;
            }

            //txtProgressが100より大きい場合は100、0より小さい場合は0に変換
            if(int.TryParse(txtProgress.Text, out int number))
            {
                if(number > 100)
                {
                    txtProgress.Text = "100";
                }else if(number < 0)
                {
                    txtProgress.Text = "0";
                }
            }
            else
            {
                txtProgress.Text = "";
            }
        }
        private string ToHalfWidthNumbers(string input)
        {
            var sb = new System.Text.StringBuilder();
            foreach (char c in input)
            {
                if (c >= '０' && c <= '９')
                {
                    sb.Append((char)(c - '０' + '0'));
                }
                else if (c >= '0' && c <= '9')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        /*
         * txtTaskNameで登録不可文字をリアルタイムでブロック
         * （キーボード入力のみ）
         * 登録不可文字：
         * サロゲート文字(例：絵文字等)
         */
        private void txtTaskName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputChar = e.KeyChar;

            if (char.IsControl(inputChar) && inputChar != '\b') // バックスペースは許可
            {
                e.Handled = true;
                return;
            }

            if (char.IsSurrogate(inputChar))
            {
                e.Handled = true;
                return;
            }
        }

        //ペースト対策
        private void txtTaskName_TextChanged(object sender, EventArgs e)
        {
            string original = txtTaskName.Text;
            string filtered = FilterInvalidMySQLChars(original);

            if (original != filtered)
            {
                int pos = txtTaskName.SelectionStart;
                txtTaskName.Text = filtered;
                txtTaskName.SelectionStart = Math.Min(pos, txtTaskName.Text.Length);
            }
        }
        private string FilterInvalidMySQLChars(string input)
        {
            return new string(input.Where(c =>
                !char.IsControl(c) || c == '\b' // バックスペース許可
            ).Where(c =>
                !char.IsSurrogate(c)
            ).ToArray());
        }
        /*
         * タスク編集モード==============================================================================
         */

        //選択されたタスクの情報を表示する
        private void showTaskInfo()
        {
            String clickedTaskSelectQuery = "SELECT task_type, task_status, task_name, task_progress, task_start, task_finish " +
                                            "FROM task_manage.task_info " +
                                            "WHERE task_holder_id = @taskHolderId " +
                                            "AND task_name = @taskName";

            String connection = DbConfig.GetConnectionString();

            DatabaseHelper db = new DatabaseHelper(connection);
            var parameters = new Dictionary<String, object>
            {
                    {"taskHolderId",LoginSession.LoginUserId },
                    {"taskName", this.clickedTaskName},
            };
            DataTable result = db.ExecuteSelectQuery(clickedTaskSelectQuery, parameters);

            DataRow row = result.Rows[0];

            cboTaskType.Text = row["task_type"] != DBNull.Value ? row["task_type"].ToString() : "";
            cboTaskStatus.Text = row["task_status"] != DBNull.Value ? row["task_status"].ToString() : "";
            txtTaskName.Text = row["task_name"] != DBNull.Value ? row["task_name"].ToString() : "";
            txtProgress.Text = row["task_progress"] != DBNull.Value ? row["task_progress"].ToString() : "";
            txtTaskStart.Text = row["task_start"] != DBNull.Value ? Convert.ToDateTime(row["task_start"]).ToString("yyyy/MM/dd") : "";
            txtTaskFinish.Text = row["task_finish"] != DBNull.Value ? Convert.ToDateTime(row["task_finish"]).ToString("yyyy/MM/dd") : "";

        }

        //入力された情報で更新する
        private void updateTaskInfo()
        {
            //重複チェックがfalseの場合、エラーメッセージを表示して処理終了
            if (!CheckTaskNameExist())
            {
                showErrorMsg("NAME_EXISTS");
                return;
            }

            String updateQuery = "UPDATE task_manage.task_info SET " +
                                 "task_type     = @taskType, " +
                                 "task_status   = @taskStatus, " +
                                 "task_name     = @taskName, " +
                                 "task_progress = @taskProgress, " +
                                 "task_start    = @taskStart, " +
                                 "task_finish   = @taskFinish " +
                                 "WHERE task_holder_id = @taskHolderId " +
                                 "AND task_name        = @taskName";


            var parameters = new Dictionary<String, object>
            {
                {"taskType", this.taskType},
                {"taskStatus", this.taskStatus},
                {"taskName", this.taskName},
                {"taskProgress", this.taskProgress},
                {"taskStart", DateTime.Parse(this.taskStart)},
                {"taskFinish", DateTime.Parse(this.taskFinish)},
                {"taskHolderId", LoginSession.LoginUserId},
                {"taskName", this.clickedTaskName}
            };

            String connection = DbConfig.GetConnectionString();
            DatabaseHelper db = new DatabaseHelper(connection);
            db.ExecuteIUDQuery(updateQuery);
        }

        //重複チェック
        private bool CheckTaskNameExist()
        {
            bool chkResult = true;
            String taskNameSelect = "SELECT COUNT(*) " +
                                    "FROM task_manage.task_info " +
                                    "WHERE task_holder_id = @taskHolderId " +
                                    "AND task_name = @newTaskName " +
                                    "AND task_name <> @oldTaskName";

            String connection = DbConfig.GetConnectionString();

            DatabaseHelper db = new DatabaseHelper(connection);
            var parameters = new Dictionary<String, object>
            {
                    {"taskHolderId",LoginSession.LoginUserId },
                    {"newTaskName", this.taskName},
                    {"oldTaskName", clickedTaskName}
            };
            DataTable result = db.ExecuteSelectQuery(taskNameSelect, parameters);
            int count = Convert.ToInt32(result.Rows[0][0]);

            if (count > 0)
            {
                chkResult = false;
            }
            return chkResult;
        }
      

        /*
         * タスク追加モード==============================================================================
         */

        //入力されたタスク情報を登録する
        private void insertTaskInfo()
        {

        }


        /*
         * ==============================================================================================
         */

        /*
         * エラー時処理
         * 引数：
         * "NAME_NULL"         →「タスク名は必須項目です。」
         * "NAME_EXISTS"       →「そのタスク名は既に登録されています。」
         * "TASK_FINISH_NULL"  →「タスク完了日を入力してください。」
         */
        private void showErrorMsg(String msgType)
        {
            switch (msgType)
            {
                case "NAME_NULL":
                    lblError.Text = "タスク名は必須項目です。";
                    break;
                case "NAME_EXISTS":
                    lblError.Text = "そのタスク名は既に登録されています。";
                    break;
                case "TASK_FINISH_NULL":
                    lblError.Text = "タスク完了日を入力してください。";
                    break;
            }
        }

    }
}
