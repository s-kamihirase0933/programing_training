using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<MyData> allData; // 全データ
        private int pageSize = 10;    // 1ページあたりの行数
        private int currentPage = 1;  // 現在のページ

        public formHome()
        {
            InitializeComponent();
            LoadData();
            DisplayPage();
        }

        private void LoadData()
        {
            // サンプルデータの読み込み
            allData = new List<MyData>();
            for (int i = 1; i <= 100; i++)
            {
                allData.Add(new MyData { taskType = "資料作成", taskStatus = "着手中", taskName = "〇〇社プレゼン資料作成", taskProgress = 70, taskStart = "2025/04/28", taskEnd = "" });
            }
        }

        private void DisplayPage()
        {
            int skip = (currentPage - 1) * pageSize;
            var pageData = allData.Skip(skip).Take(pageSize).ToList();
            foreach(var item in allData)
            {
                tblTaskList.Rows.Add(item.taskType, item.taskStatus, item.taskName, item.taskProgress + "%", item.taskStart, item.taskEnd);
            }

            // ページ情報を表示（ラベルなど）
            lblCurrentPage.Text = $"ページ {currentPage} / {Math.Ceiling((double)allData.Count / pageSize)}";
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < (int)Math.Ceiling((double)allData.Count / pageSize))
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


        public class MyData
        {
            public string taskType { get; set; }
            public string taskStatus { get; set; }
            public string taskName { get; set; }
            public int taskProgress { get; set; }
            public string taskStart { get; set; }
            public string taskEnd { get; set; }

        }
        private void formHome_Load(object sender, EventArgs e)
        {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tblList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // ヘッダーのクリックは除外
            {
                // または、列名で判定（列に Name が設定されている場合）
                int columnIndex = e.ColumnIndex;
                string columnName = tblTaskList.Columns[columnIndex].Name;

                // 特定の列名だったら処理を実行
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に削除しますか？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
