using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Clear_Click(object sender, EventArgs e)
        {
            TextBox_overwrite = true;
            display.Text = "0";
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
            mType = MarksType.PLUS;
            TextBox_overwrite = true;

        }
        private void Minus_Click(object sender, EventArgs e)       //"-"クリック時
        {
            mType = MarksType.MINUS;
            TextBox_overwrite = true;
        }
        private void Multiplied_Click(object sender, EventArgs e)  //"×"クリック時
        {
            mType = MarksType.MULTIPLIED;
            TextBox_overwrite = true;
        }
        private void Devided_Click(object sender, EventArgs e)     //"÷"クリック時
        {
            mType = MarksType.DEVIDED;
            TextBox_overwrite = true;
        }


    }
}
