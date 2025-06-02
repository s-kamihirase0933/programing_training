using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace calculator_KS
{
    public partial class caluculator : Form
    {
        public caluculator()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            InitializeOperatorButtons();
        }

        int inputCnt = 0;

        /*
         * 
         * 数値、小数点ボタンクリックイベント
         * 
         */
        private bool TextBox_overwrite = true;  //テキストボックスの上書きをする場合はtrue
        private void Zero_Click(object sender, EventArgs e)
        {
            Number_Click(btnZero.Text);
        }

        private void One_Click(object sender, EventArgs e)
        {
            Number_Click(btnOne.Text);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Number_Click(btnTwo.Text);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Number_Click(btnThree.Text);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Number_Click(btnFour.Text);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Number_Click(btnFive.Text);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Number_Click(btnSix.Text);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Number_Click(btnSeven.Text);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Number_Click(btnEight.Text);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Number_Click(btnNine.Text);
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("."))
            {
                return;
            }
            else if (txtDisplay.Text.Length >= 13)
            {
                return;
            }
                
            txtDisplay.Text += btnPoint.Text;
            TextBox_overwrite = false;
        }

        private void Number_Click(String number)
        {
            

            if (TextBox_overwrite == true)
            {
                txtDisplay.Text = number;
                TextBox_overwrite = false;
                btnClear.Text = "C";
            }
            else
            {
                if (txtDisplay.Text.Length >= 13)
                {
                    return;
                }
                txtDisplay.Text += number;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMultiple.Enabled = true;
            btnDivide.Enabled = true;
        }


        /*
         * 
         * 結果をプールするメソッド
         * 
         */
        private double dNum;       //ラベルをdouble型に格納する変数
        private double dNum_Pool;  //ラベルの数字をプール
        private enum MarksType     //列挙子
        {
            NON,
            PLUS,
            MINUS,
            MULTIPLIED,
            DIVIDED
        }
        private MarksType mType = MarksType.NON;

        private bool Num_Pool()
        {
            try
            {
                dNum = double.Parse(txtDisplay.Text);
            }
            catch (Exception ex)
            {
                Error("others");
            }

            switch (mType)
            {
                case MarksType.NON:         //=
                    dNum_Pool = dNum;
                    break;
                case MarksType.PLUS:        //+
                    dNum_Pool += dNum;
                    break;
                case MarksType.MINUS:       //-
                    dNum_Pool -= dNum;
                    break;
                case MarksType.MULTIPLIED:  //×
                    dNum_Pool *= dNum;
                    break;
                case MarksType.DIVIDED:     //÷
                    if (dNum == 0)
                    {
                        dNum_Pool = 0;
                        Error("formula");
                        
                        return false;
                    }
                    dNum_Pool /= dNum;
                    break;
            }
            double rounded = RoundToTotalDigits(dNum_Pool, 11);
            String result =rounded.ToString();
            int digitOnlyLength = result.Replace(".", "").Replace("-", "").Replace("E", "").Replace("+", "").Length;
            if(digitOnlyLength > 13)
            {
                Error("digit");
                return false;
            }

            txtDisplay.Text = result;
            return true;
        }

        /*
         * 
         * 演算子ボタン
         * 
         */
        private int numCnt = 0;   //テキストボックスの数値のみカウント
        private void Plus_Click(object sender, EventArgs e)        //"+"クリック時
        {
            Operator_Click(btnPlus.Text);
        }
        private void Minus_Click(object sender, EventArgs e)       //"-"クリック時
        {
            Operator_Click(btnMinus.Text);
        }
        private void Multiple_Click(object sender, EventArgs e)    //"×"クリック時
        {
            Operator_Click(btnMultiple.Text);
        }
        private void Divide_Click(object sender, EventArgs e)      //"÷"クリック時
        {
            Operator_Click(btnDivide.Text);
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            Operator_Click(btnEqual.Text);
        }

        /*
         * 
         * 演算子をマッピング
         *
         */
        private readonly Dictionary<string, MarksType> OperatorMap = new Dictionary<string, MarksType>
        {
            { "＋", MarksType.PLUS },
            { "ー", MarksType.MINUS },
            { "×", MarksType.MULTIPLIED },
            { "÷", MarksType.DIVIDED },
            { "＝", MarksType.NON }
};

        /*
         * 
         * ボタンとの対応をマッピング
         * 
         */
        private Dictionary<MarksType, Button> OperatorButtons;

        private void InitializeOperatorButtons()
        {
            OperatorButtons = new Dictionary<MarksType, Button>
            {
              { MarksType.PLUS, btnPlus },
              { MarksType.MINUS, btnMinus },
              { MarksType.MULTIPLIED, btnMultiple },
              { MarksType.DIVIDED, btnDivide }
            };
        }

        /*
         * 
         * 演算子クリックイベント
         * 
         */
        private void Operator_Click(string ope)
        {
            TextBox_overwrite = true;

            if (!Num_Pool())
            {
                return;
            }
            if (ope == "=")
            {
                mType = MarksType.NON;
                ResetOperatorButtonState();
                return;
            }

            if (OperatorMap.TryGetValue(ope, out MarksType newType))
            {
                mType = newType;
                HighlightOperatorButton(newType);
                DisableOtherOperatorButtons(newType);
            }
        }

        //演算子ボタン状態制御
        private void HighlightOperatorButton(MarksType activeType)
        {
            foreach (var pair in OperatorButtons)
            {
                pair.Value.BackColor = pair.Key == activeType ? Color.FromArgb(55, 203, 255) : Color.FromArgb(185, 209, 234);
            }
        }
        /*
         * 
         * 演算子ボタン非活性化
         * 
         */
        private void DisableOtherOperatorButtons(MarksType activeType)
        {
            foreach (var pair in OperatorButtons)
            {
                pair.Value.Enabled = pair.Key == activeType;
            }
        }

        /*
         * 
         * 演算子ボタン非活性化リセット
         * 
         */
        private void ResetOperatorButtonState()
        {
            foreach (var btn in OperatorButtons.Values)
            {
                btn.BackColor = Color.FromArgb(185, 209, 234);
                btn.Enabled = true;
            }
        }

        /*
         * 
         * クリアボタンクリックイベント
         * 
         */

        private void Clear_Click(object sender, EventArgs e)
        {
            if (btnClear.Text == "C")
            {
                TextBox_overwrite = true;
                txtDisplay.Text = "0";
                btnClear.Text = "AC";
            }
            else if (btnClear.Text == "AC")
            {
                TextBox_overwrite = true;
                BtnActivation(true);
                dNum_Pool = 0;
                mType = MarksType.NON;
                txtDisplay.Text = "0";
                BtnActivation(true);

            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMultiple.Enabled = true;
            btnDivide.Enabled = true;

        }

        /*
         * 
         * 符号ボタンクリックイベント
         * 
         */
        private void Sign_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                return;
            }else if (txtDisplay.Text.Length >= 13)
            {
                return;
            }
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Replace("-", "");
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        String input_str = "";

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            if (NumCheck(txtDisplay.Text) == true)
            {
                if (txtDisplay.Text.Length > 13)
                {
                    Error("digit");
                    BtnActivation(false);
                }
            }
        }

        /*
         * 
         * エラーメッセージ
         * 
         * 引数に設定する値
         * 数式エラー   ："formula"
         * 桁数エラー   ："digit"
         * その他エラー ："others"
         * 
         */
        private void Error(String errorType)
        {
            String ErrorMsg = "Errorクリアしてください";

            if (errorType.Equals("formula"))
            {
                ErrorMsg = "数式" + ErrorMsg;
            }
            else if (errorType.Equals("digit"))
            {
                ErrorMsg = "桁数上限" + ErrorMsg;
            }
            BtnActivation(false);
            txtDisplay.Text = ErrorMsg;
            btnClear.Text = "AC";
            return;
        }

        /*
         * 
         * 演算子ボタンカラー変更
         * 第1引数：演算子
         * ・PLUS
         * ・MINUS
         * ・DIVIDE
         * ・MULTIPLE
         * 第2引数：ボタンの色
         * ・ACTIVE
         * ・DEFAULT
         * 
         */
        private void BtnColorChange(String BtnType, String BtnParam)
        {
            switch (BtnType)
            {
                case "PLUS":
                    if (BtnParam.Equals("ACTIVE"))
                    {
                        btnPlus.BackColor = Color.FromArgb(55, 203, 255);
                    }
                    else if (BtnParam.Equals("DEFAULT"))
                    {
                        btnPlus.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    break;

                case "MINUS":
                    if (BtnParam.Equals("ACTIVE"))
                    {
                        btnMinus.BackColor = Color.FromArgb(55, 203, 255);
                    }
                    else if (BtnParam.Equals("DEFAULT"))
                    {
                        btnMinus.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    break;

                case "DIVIDE":
                    if (BtnParam.Equals("ACTIVE"))
                    {
                        btnDivide.BackColor = Color.FromArgb(55, 203, 255);
                    }
                    else if (BtnParam.Equals("DEFAULT"))
                    {
                        btnDivide.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    break;

                case "MULTIPLE":
                    if (BtnParam.Equals("ACTIVE"))
                    {
                        btnMultiple.BackColor = Color.FromArgb(55, 203, 255);
                    }
                    else if (BtnParam.Equals("DEFAULT"))
                    {
                        btnMultiple.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    break;


            }
        }

        /*
         * 
         * ボタン非活性切替(クリアボタン以外)
         * 
         */
        private void BtnActivation(Boolean btnSwitch)
        {
            if (btnSwitch == true)
            {
                btnZero.Enabled = true;
                btnOne.Enabled = true;
                btnTwo.Enabled = true;
                btnThree.Enabled = true;
                btnFour.Enabled = true;
                btnFive.Enabled = true;
                btnSix.Enabled = true;
                btnSeven.Enabled = true;
                btnEight.Enabled = true;
                btnNine.Enabled = true;
                btnPlus.Enabled = true;
                btnMinus.Enabled = true;
                btnMultiple.Enabled = true;
                btnDivide.Enabled = true;
                btnPoint.Enabled = true;
                btnSign.Enabled = true;
                btnEqual.Enabled = true;

            }
            else if (btnSwitch == false)
            {
                btnZero.Enabled = false;
                btnOne.Enabled = false;
                btnTwo.Enabled = false;
                btnThree.Enabled = false;
                btnFour.Enabled = false;
                btnFive.Enabled = false;
                btnSix.Enabled = false;
                btnSeven.Enabled = false;
                btnEight.Enabled = false;
                btnNine.Enabled = false;
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnMultiple.Enabled = false;
                btnDivide.Enabled = false;
                btnPoint.Enabled = false;
                btnSign.Enabled = false;
                btnEqual.Enabled = false;
            }
        }

        /*
         * 
         * 数値 or 文字列チェック
         * 
         */
        private bool NumCheck(String chkText)
        {
            bool chkResult = true;
            try
            {
                double.Parse(txtDisplay.Text);
            }
            catch (Exception e)
            {
                chkResult = false;
            }
            return chkResult;
        }

        /*
         * 
         * 計算結果を四捨五入
         * 
         */
        public static double RoundToTotalDigits(double num, int digits)
        {
            if (num == 0)
                return 0;

            double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(num))) - digits + 1);
            return Math.Round(num / scale) * scale;
        }

    }
}
