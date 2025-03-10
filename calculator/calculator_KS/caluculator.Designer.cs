namespace calculator_KS
{
    partial class caluculator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.nine.Location = new System.Drawing.Point(306, 206);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(92, 73);
            this.nine.TabIndex = 0;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.eight.Location = new System.Drawing.Point(208, 206);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(92, 73);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.seven.Location = new System.Drawing.Point(110, 206);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(92, 73);
            this.seven.TabIndex = 2;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.four.Location = new System.Drawing.Point(110, 285);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(92, 73);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.five.Location = new System.Drawing.Point(208, 285);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(92, 73);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.six.Location = new System.Drawing.Point(306, 285);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(92, 73);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Six_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.one.Location = new System.Drawing.Point(110, 364);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(92, 73);
            this.one.TabIndex = 6;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.One_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.two.Location = new System.Drawing.Point(208, 364);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(92, 73);
            this.two.TabIndex = 7;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.three.Location = new System.Drawing.Point(306, 364);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(92, 73);
            this.three.TabIndex = 8;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Three_Click);
            // 
            // multiple
            // 
            this.multiple.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.multiple.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.multiple.Location = new System.Drawing.Point(404, 206);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(92, 73);
            this.multiple.TabIndex = 9;
            this.multiple.Text = "×";
            this.multiple.UseVisualStyleBackColor = false;
            this.multiple.Click += new System.EventHandler(this.Multiple_Click);
            // 
            // point
            // 
            this.point.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.point.Location = new System.Drawing.Point(306, 443);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(92, 73);
            this.point.TabIndex = 10;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.Point_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.zero.Location = new System.Drawing.Point(110, 443);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(190, 73);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plus.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.plus.Location = new System.Drawing.Point(404, 285);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(92, 73);
            this.plus.TabIndex = 12;
            this.plus.Text = "＋";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.minus.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.minus.Location = new System.Drawing.Point(404, 364);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(92, 73);
            this.minus.TabIndex = 13;
            this.minus.Text = "ー";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.equal.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.equal.Location = new System.Drawing.Point(404, 443);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(92, 73);
            this.equal.TabIndex = 14;
            this.equal.Text = "＝";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.divide.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.divide.Location = new System.Drawing.Point(404, 127);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(92, 73);
            this.divide.TabIndex = 15;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clear.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.clear.Location = new System.Drawing.Point(110, 127);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(175, 73);
            this.clear.TabIndex = 16;
            this.clear.Text = "AC";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.display.Location = new System.Drawing.Point(110, 74);
            this.display.MaxLength = 13;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(386, 47);
            this.display.TabIndex = 1;
            this.display.Text = "0";
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sign.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.sign.Location = new System.Drawing.Point(291, 127);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(107, 73);
            this.sign.TabIndex = 18;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // caluculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 601);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.display);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.point);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Name = "caluculator";
            this.Text = "計算機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button sign;
    }
}

