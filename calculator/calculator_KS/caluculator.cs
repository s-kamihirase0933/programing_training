using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            if (TextBox_overwrite == true)
            {
                display.Text = Zero.Text;
                TextBox_overwrite = false;
                if(display.Text == "0")
                {
                    TextBox_overwrite = true;
                }
            }
            else
            {
                display.Text += Zero.Text;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            Plus.Enabled     = true;
            Minus.Enabled    = true;
            Multiple.Enabled = true;
            Divide.Enabled   = true;
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = One.Text;
                TextBox_overwrite = false;
                Clear.Text = "C";
            }
            else
            {
                display.Text += One.Text;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            Plus.Enabled     = true;
            Minus.Enabled    = true;
            Multiple.Enabled = true;
            Divide.Enabled   = true;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Two.Text;
                TextBox_overwrite = false;
                Clear.Text = "C";
            }
            else
            {
                display.Text += Two.Text;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            Plus.Enabled     = true;
            Minus.Enabled    = true;
            Multiple.Enabled = true;
            Divide.Enabled   = true;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Three.Text;
                TextBox_overwrite = false;
                Clear.Text = "C";
            }
            else
            {
                display.Text += Three.Text;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            Plus.Enabled     = true;
            Minus.Enabled    = true;
            Multiple.Enabled = true;
            Divide.Enabled   = true;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Four.Text;
                TextBox_overwrite = false;
                Clear.Text = "C";
            }
            else
            {
                display.Text += Four.Text;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            Plus.Enabled     = true;
            Minus.Enabled    = true;
            Multiple.Enabled = true;
            Divide.Enabled   = true;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Five.Text;
                TextBox_overwrite = false;
                Clear.Text = "C";
            }
            else
            {
                display.Text += Five.Text;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            Plus.Enabled     = true;
            Minus.Enabled    = true;
            Multiple.Enabled = true;
            Divide.Enabled   = true;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Six.Text;
                TextBox_overwrite = false;
                Clear.Text = "C";
            }
            else
            {
                display.Text += Six.Text;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            Plus.Enabled     = true;
            Minus.Enabled    = true;
            Multiple.Enabled = true;
            Divide.Enabled   = true;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Seven.Text;
                TextBox_overwrite = false;
                Clear.Text = "C";
            }
            else
            {
                display.Text += Seven.Text;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            Plus.Enabled     = true;
            Minus.Enabled    = true;
            Multiple.Enabled = true;
            Divide.Enabled   = true;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Eight.Text;
                TextBox_overwrite = false;
                Clear.Text = "C";
            }
            else
            {
                display.Text += Eight.Text;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            Plus.Enabled     = true;
            Minus.Enabled    = true;
            Multiple.Enabled = true;
            Divide.Enabled   = true;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Nine.Text;
                TextBox_overwrite = false;
                Clear.Text = "C";
            }
            else
            {
                display.Text += Nine.Text;
            }
            BtnColorChange("PLUS", "DEFAULT");
            BtnColorChange("MINUS", "DEFAULT");
            BtnColorChange("MULTIPLE", "DEFAULT");
            BtnColorChange("DIVIDE", "DEFAULT");
            Plus.Enabled     = true;
            Minus.Enabled    = true;
            Multiple.Enabled = true;
            Divide.Enabled   = true;
        }

        private void Point_Click(object sender, EventArgs e)
        {
            display.Text += Point.Text;
            TextBox_overwrite = false;
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
            
            display.Text = dNum_Pool.ToString();
        }

        /*
         * 
         * 演算子ボタンクリックイベント
         * 
         */
        private int numCnt = 0;   //テキストボックスの数値のみカウント
        private void Plus_Click(object sender, EventArgs e)        //"+"クリック時
        {
            TextBox_overwrite = true;
            Num_Pool();
            mType = MarksType.PLUS;
            BtnColorChange("PLUS", "ACTIVE");
            Minus.Enabled    = false;
            Multiple.Enabled = false;
            Divide.Enabled   = false;

        }
        private void Minus_Click(object sender, EventArgs e)       //"-"クリック時
        {
            TextBox_overwrite = true;
            Num_Pool();
            mType = MarksType.MINUS;
            BtnColorChange("MINUS", "ACTIVE");
            Plus.Enabled     = false;
            Multiple.Enabled = false;
            Divide.Enabled   = false;

        }
        private void Multiplied_Click(object sender, EventArgs e)  //"×"クリック時
        {
            TextBox_overwrite = true;
            Num_Pool();
            mType = MarksType.MULTIPLIED;
            BtnColorChange("MULTIPLE", "ACTIVE");
            Minus.Enabled    = false;
            Plus.Enabled     = false;
            Divide.Enabled   = false;

        }
        private void Divided_Click(object sender, EventArgs e)     //"÷"クリック時
        {
            TextBox_overwrite = true;
            Num_Pool();
            mType = MarksType.DIVIDED;
            BtnColorChange("DIVIDE", "ACTIVE");
            Minus.Enabled    = false;
            Multiple.Enabled = false;
            Plus.Enabled     = false;

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            TextBox_overwrite = true;
            Num_Pool();
            mType = MarksType.NON;
        }

        /*
         * 
         * クリアボタンクリックイベント
         * 
         */

        private void Clear_Click(object sender, EventArgs e)//本メソッド製造中にエラー
        {
            if(Clear.Text == "C")
            {
                TextBox_overwrite = true;
                display.Text = "0";
                Clear.Text = "AC";
            }
            else if(Clear.Text == "AC")
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
            Plus.Enabled = true;
            Minus.Enabled = true;
            Multiple.Enabled = true;
            Divide.Enabled = true;

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
            if(display.Text.Length > 13)
            {
                Error("digit");
                BtnActivation(false);
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
            String ErrorMsg = "Error\nクリアしてください";

            if(errorType.Equals("formula"))
            {
                ErrorMsg = "数式" + ErrorMsg;
            }
            else if(errorType.Equals("digit"))
            {
                ErrorMsg = "桁数上限" + ErrorMsg;
            }

            display.Text = ErrorMsg;
            Clear.Text = "AC";
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
                        Plus.BackColor = Color.FromArgb(55, 203, 255);
                    }else if (BtnParam.Equals("DEFAULT"))
                    {
                        Plus.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    break;

                case "MINUS":
                    if (BtnParam.Equals("ACTIVE"))
                    {
                        Minus.BackColor = Color.FromArgb(55, 203, 255);
                    }
                    else if (BtnParam.Equals("DEFAULT"))
                    {
                        Minus.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    break;

                case "DIVIDE":
                    if (BtnParam.Equals("ACTIVE"))
                    {
                        Divide.BackColor = Color.FromArgb(55, 203, 255);
                    }
                    else if (BtnParam.Equals("DEFAULT"))
                    {
                        Divide.BackColor = Color.FromArgb(185, 209, 234);
                    }
                    break;

                case "MULTIPLE":
                    if (BtnParam.Equals("ACTIVE"))
                    {
                        Multiple.BackColor = Color.FromArgb(55, 203, 255);
                    }
                    else if (BtnParam.Equals("DEFAULT"))
                    {
                        Multiple.BackColor = Color.FromArgb(185, 209, 234);
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
                Zero.Enabled      = true;
                One.Enabled       = true;
                Two.Enabled       = true;
                Three.Enabled     = true;
                Four.Enabled      = true;
                Five.Enabled      = true;
                Six.Enabled       = true;
                Seven.Enabled     = true;
                Eight.Enabled     = true;
                Nine.Enabled      = true;
                Plus.Enabled      = true;
                Minus.Enabled     = true;
                Multiple.Enabled  = true;
                Divide.Enabled    = true;
                Point.Enabled     = true;
                Sign.Enabled      = true;
                Equal.Enabled     = true;

            }
            else if(btnSwitch == false)
            {
                Zero.Enabled      = false;
                One.Enabled       = false;
                Two.Enabled       = false;
                Three.Enabled     = false;
                Four.Enabled      = false;
                Five.Enabled      = false;
                Six.Enabled       = false;
                Seven.Enabled     = false;
                Eight.Enabled     = false;
                Nine.Enabled      = false;
                Plus.Enabled      = false;
                Minus.Enabled     = false;
                Multiple.Enabled = false;
                Divide.Enabled    = false;
                Point.Enabled     = false;
                Sign.Enabled      = false;
                Equal.Enabled     = false;
            }
        }
          
    }
}
