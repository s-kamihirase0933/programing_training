using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using taskManagemetApp.src;

namespace taskManagemetApp
{
    public partial class form : Form
    {

        public form()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userId   = txtUserName.Text;
            String password = txtPassword.Text;
            if (isValidText(userId) && isValidText(password))
            {
                if (chkLoginUser(userId, password))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void lblPass_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        /*
         * ログイン時、ユーザーID/パスワード照合
         */
        private bool chkLoginUser (string userName, string password)
        {
            bool chkResult         = true;
            String userSelectQuery = "SELECT user_id FROM task_manage.user_info WHERE user_id = @userName AND user_password = @password";
            String connection      = DbConfig.GetConnectionString();
            DataTable result       = null;
            try
            {
                DatabaseHelper db = new DatabaseHelper(connection);
                var parameters = new Dictionary<String, object>
                {
                    {"@userName",userName },
                    {"@password",password }
                };
                result = db.ExecuteSelectQuery(userSelectQuery,parameters);

            }catch(Exception ex)
            {
                showError("CONNECT_FAILE");
                return false;
            }

            if (result.Rows.Count == 0)
            {
                chkResult = false;
                showError("SELECT_FAILE");
            }
            else
            {
                LoginSession.LoginUserId = result.Rows[0]["user_id"].ToString();
            }
            return chkResult;
        }
        /*
         * テキストボックスをチェックする
         * 条件：
         * ➀NULL又は空文字、スペース
         * ➁a-z,A-Z,0-9以外の文字列を含む
         */
        private bool isValidText(String text)
        {
            bool chkResult = true;
            if (string.IsNullOrWhiteSpace(text))
            {
                showError("SELECT_FAILE");
                chkResult = false;
            }

            if (Regex.IsMatch(text, @"[^a-zA-Z0-9]"))
            {
                showError("SELECT_FAILE");
                chkResult = false;
            }
            return chkResult;
        }

        /*
         * エラーメッセージ表示
         */
        private void showError(String Type)
        {
            if(Type == "SELECT_FAILE")
            {
                lblError.Text = "ユーザーID、又はパスワードが誤っています";
            }else if(Type == "CONNECT_FAILE")
            {
                lblError.Text = "データベース接続に失敗しました";
            }
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
