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

        public void Form1_Load(object sender, EventArgs e) { }

        int inputCnt = 0;

        /*
         * 
         * 数値、小数点ボタンクリックイベント
         * 
         */
        private bool TextBox_overwrite = true;  //テキストボックスの上書きをする場合はtrue
        private void Zero_Click(object sender, EventArgs e)
        {
            Number_Click(zero.Text);
        }

        private void One_Click(object sender, EventArgs e)
        {
            Number_Click(one.Text);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Number_Click(two.Text);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Number_Click(three.Text);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Number_Click(four.Text);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Number_Click(five.Text);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Number_Click(six.Text);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Number_Click(seven.Text);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Number_Click(eight.Text);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Number_Click(nine.Text);
        }

        private void Point_Click(object sender, EventArgs e)
        {
            display.Text += point.Text;
            TextBox_overwrite = false;
        }

        private void Number_Click(String number)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = number;
                TextBox_overwrite = false;
                clear.Text = "C";
            }
            else
            {
                display.Text += number;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            plus.Enabled = true;
            minus.Enabled = true;
            multiple.Enabled = true;
            divide.Enabled = true;
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

        private void Num_Pool()
        {
            try
            {
                dNum = double.Parse(display.Text);
            }catch(Exception ex)
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
                    dNum_Pool /= dNum;
                    if(dNum == 0)
                    {
                        dNum_Pool = 0;
                        Error("formula");
                        return;
                    }
                    break;
            }
            
            display.Text = Math.Round(dNum_Pool,8, MidpointRounding.AwayFromZero).ToString();
        }

        /*
         * 
         * 演算子ボタンクリックイベント
         * 
         */
        private int numCnt = 0;   //テキストボックスの数値のみカウント
        private void Plus_Click(object sender, EventArgs e)        //"+"クリック時
        {
            Operator_Click(plus.Text);
        }
        private void Minus_Click(object sender, EventArgs e)       //"-"クリック時
        {
            Operator_Click(minus.Text);
        }
        private void Multiple_Click(object sender, EventArgs e)  //"×"クリック時
        {
            Operator_Click(multiple.Text);
        }
        private void Divide_Click(object sender, EventArgs e)     //"÷"クリック時
        {
            Operator_Click(divide.Text);
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            Operator_Click(equal.Text);
        }
        private void Operator_Click(String ope)
        {
            TextBox_overwrite = true;
            Num_Pool();
            switch (ope){
                case "+":
                    mType = MarksType.PLUS;
                    BtnColorChange("PLUS", "ACTIVE");
                    minus.Enabled = false;
                    multiple.Enabled = false;
                    divide.Enabled = false;
                    break;
                case "-":
                    mType = MarksType.MINUS;
                    BtnColorChange("MINUS", "ACTIVE");
                    plus.Enabled = false;
                    multiple.Enabled = false;
                    divide.Enabled = false;
                    break;
                case "×":
                    mType = MarksType.MULTIPLIED;
                    BtnColorChange("MULTIPLE", "ACTIVE");
                    minus.Enabled = false;
                    plus.Enabled = false;
                    divide.Enabled = false;
                    break;
                case "÷":
                    mType = MarksType.DIVIDED;
                    BtnColorChange("DIVIDE", "ACTIVE");
                    minus.Enabled = false;
                    multiple.Enabled = false;
                    plus.Enabled = false;
                    break;
                case "=":
                    mType = MarksType.NON;
                    break;
            }   
        }
        /*
         * 
         * クリアボタンクリックイベント
         * 
         */

        private void Clear_Click(object sender, EventArgs e)
        {
            if(clear.Text == "C")
            {
                TextBox_overwrite = true;
                display.Text = "0";
                clear.Text = "AC";
            }
            else if(clear.Text == "AC")
            {
                TextBox_overwrite = true;
                display.Text = "0";
                dNum_Pool = 0;
                BtnActivation(true);

            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            plus.Enabled = true;
            minus.Enabled = true;
            multiple.Enabled = true;
            divide.Enabled = true;

        }

        /*
         * 
         * 符号ボタンクリックイベント
         * 
         */
        private void Sign_Click(object sender, EventArgs e)
        {
            if(display.Text == "0") {
                return;
            }
            if (display.Text.Contains("-"))
            {
                display.Text = display.Text.Replace("-", "");
            }
            else
            {
                display.Text = "-" + display.Text;
            }
        }

        String input_str = "";

        private void display_TextChanged(object sender, EventArgs e)
        {
            if (NumCheck(display.Text) == true)
            {
                if (display.Text.Length > 13)
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

            if(errorType.Equals("formula"))
            {
                ErrorMsg = "数式" + ErrorMsg;
            }
            else if(errorType.Equals("digit"))
            {
                ErrorMsg = "桁数上限" + ErrorMsg;
            }

            display.Text = ErrorMsg;
            clear.Text = "AC";
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
                    if(BtnParam.Equals("ACTIVE")){
                        plus.BackColor = Color.FromArgb(55, 203, 255);
                    }else if (BtnParam.Equals("DEFAULT"))
                    {
                        plus.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    break;

                case "MINUS":
                    if (BtnParam.Equals("ACTIVE"))
                    {
                        minus.BackColor = Color.FromArgb(55, 203, 255);
                    }
                    else if (BtnParam.Equals("DEFAULT"))
                    {
                        minus.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    break;

                case "DIVIDE":
                    if (BtnParam.Equals("ACTIVE"))
                    {
                        divide.BackColor = Color.FromArgb(55, 203, 255);
                    }
                    else if (BtnParam.Equals("DEFAULT"))
                    {
                        divide.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    break;

                case "MULTIPLE":
                    if (BtnParam.Equals("ACTIVE"))
                    {
                        multiple.BackColor = Color.FromArgb(55, 203, 255);
                    }
                    else if (BtnParam.Equals("DEFAULT"))
                    {
                        multiple.BackColor = Color.FromArgb(185, 209, 234);
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
            if(btnSwitch == true)
            {
                zero.Enabled      = true;
                one.Enabled       = true;
                two.Enabled       = true;
                three.Enabled     = true;
                four.Enabled      = true;
                five.Enabled      = true;
                six.Enabled       = true;
                seven.Enabled     = true;
                eight.Enabled     = true;
                nine.Enabled      = true;
                plus.Enabled      = true;
                minus.Enabled     = true;
                multiple.Enabled  = true;
                divide.Enabled    = true;
                point.Enabled     = true;
                sign.Enabled      = true;
                equal.Enabled     = true;

            }
            else if(btnSwitch == false)
            {
                zero.Enabled      = false;
                one.Enabled       = false;
                two.Enabled       = false;
                three.Enabled     = false;
                four.Enabled      = false;
                five.Enabled      = false;
                six.Enabled       = false;
                seven.Enabled     = false;
                eight.Enabled     = false;
                nine.Enabled      = false;
                plus.Enabled      = false;
                minus.Enabled     = false;
                multiple.Enabled = false;
                divide.Enabled    = false;
                point.Enabled     = false;
                sign.Enabled      = false;
                equal.Enabled     = false;
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
                double.Parse(display.Text);
            }
            catch(Exception e)
            {
                chkResult = false;
            }
            return chkResult;
        }

    }
}
