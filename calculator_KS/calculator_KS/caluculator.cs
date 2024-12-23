using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_KS
{
    public partial class caluculator : Form
    {
        public caluculator()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e) { }

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

        }

        private void One_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = One.Text;
                TextBox_overwrite = false;
            }
            else
            {
                display.Text += One.Text;
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Two.Text;
                TextBox_overwrite = false;
            }
            else
            {
                display.Text += Two.Text;
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Three.Text;
                TextBox_overwrite = false;
            }
            else
            {
                display.Text += Three.Text;
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Four.Text;
                TextBox_overwrite = false;
            }
            else
            {
                display.Text += Four.Text;
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Five.Text;
                TextBox_overwrite = false;
            }
            else
            {
                display.Text += Five.Text;
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Six.Text;
                TextBox_overwrite = false;
            }
            else
            {
                display.Text += Six.Text;
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Seven.Text;
                TextBox_overwrite = false;
            }
            else
            {
                display.Text += Seven.Text;
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Eight.Text;
                TextBox_overwrite = false;
                Clear.Text = "C";s
            }
            else
            {
                display.Text += Eight.Text;
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (TextBox_overwrite == true)
            {
                display.Text = Nine.Text;
                TextBox_overwrite = false;
            }
            else
            {
                display.Text += Nine.Text;
            }
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
            DEVIDED
        }
        private MarksType mType = MarksType.NON;
        private void Num_Pool()
        {
            dNum = double.Parse(display.Text);
            switch (mType)
            {
                case MarksType.NON:   //=
                    dNum_Pool = dNum;
                    break;
                case MarksType.PLUS:  //+
                    dNum_Pool += dNum;
                    break;
                case MarksType.MINUS: //-
                    dNum_Pool -= dNum;
                    break;
                case MarksType.MULTIPLIED:  //×
                    dNum_Pool *= dNum;
                    break;
                case MarksType.DEVIDED:     //÷
                    dNum_Pool /= dNum;
                    break;
            }

            display.Text = dNum_Pool.ToString();
        }

        /*
         * 
         * 演算子ボタンクリックイベント
         * 
         */
        private void Plus_Click(object sender, EventArgs e)        //"+"クリック時
        {
            TextBox_overwrite = true;
            Num_Pool();
            mType = MarksType.PLUS;

        }
        private void Minus_Click(object sender, EventArgs e)       //"-"クリック時
        {
            TextBox_overwrite = true;
            Num_Pool();
            mType = MarksType.MINUS;
            
        }
        private void Multiplied_Click(object sender, EventArgs e)  //"×"クリック時
        {
            TextBox_overwrite = true;
            Num_Pool();
            mType = MarksType.MULTIPLIED;
            
        }
        private void Devided_Click(object sender, EventArgs e)     //"÷"クリック時
        {
            TextBox_overwrite = true;
            Num_Pool();
            mType = MarksType.DEVIDED;
            
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
                dNum = 0;

            }
            

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

        private void Divided_Click(object sender, EventArgs e)
        {

        }
    }
}
