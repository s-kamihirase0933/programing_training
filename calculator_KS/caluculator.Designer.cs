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
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Multiple = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.Sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Nine.Location = new System.Drawing.Point(306, 206);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(92, 73);
            this.Nine.TabIndex = 0;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Eight.Location = new System.Drawing.Point(208, 206);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(92, 73);
            this.Eight.TabIndex = 1;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Seven.Location = new System.Drawing.Point(110, 206);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(92, 73);
            this.Seven.TabIndex = 2;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Four.Location = new System.Drawing.Point(110, 285);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(92, 73);
            this.Four.TabIndex = 3;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Five.Location = new System.Drawing.Point(208, 285);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(92, 73);
            this.Five.TabIndex = 4;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Six.Location = new System.Drawing.Point(306, 285);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(92, 73);
            this.Six.TabIndex = 5;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.One.Location = new System.Drawing.Point(110, 364);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(92, 73);
            this.One.TabIndex = 6;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Two.Location = new System.Drawing.Point(208, 364);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(92, 73);
            this.Two.TabIndex = 7;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Three.Location = new System.Drawing.Point(306, 364);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(92, 73);
            this.Three.TabIndex = 8;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Multiple
            // 
            this.Multiple.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Multiple.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Multiple.Location = new System.Drawing.Point(404, 206);
            this.Multiple.Name = "Multiple";
            this.Multiple.Size = new System.Drawing.Size(92, 73);
            this.Multiple.TabIndex = 9;
            this.Multiple.Text = "×";
            this.Multiple.UseVisualStyleBackColor = false;
            this.Multiple.Click += new System.EventHandler(this.Multiplied_Click);
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Point.Location = new System.Drawing.Point(306, 443);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(92, 73);
            this.Point.TabIndex = 10;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Zero.Location = new System.Drawing.Point(110, 443);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(190, 73);
            this.Zero.TabIndex = 11;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Plus.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Plus.Location = new System.Drawing.Point(404, 285);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(92, 73);
            this.Plus.TabIndex = 12;
            this.Plus.Text = "＋";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Minus.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Minus.Location = new System.Drawing.Point(404, 364);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(92, 73);
            this.Minus.TabIndex = 13;
            this.Minus.Text = "ー";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Equal.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Equal.Location = new System.Drawing.Point(404, 443);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(92, 73);
            this.Equal.TabIndex = 14;
            this.Equal.Text = "＝";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Divide.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Divide.Location = new System.Drawing.Point(404, 127);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(92, 73);
            this.Divide.TabIndex = 15;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divided_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Clear.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Clear.Location = new System.Drawing.Point(110, 127);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(175, 73);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "AC";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
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
            // Sign
            // 
            this.Sign.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Sign.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Sign.Location = new System.Drawing.Point(291, 127);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(107, 73);
            this.Sign.TabIndex = 18;
            this.Sign.Text = "+/-";
            this.Sign.UseVisualStyleBackColor = false;
            this.Sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // caluculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 641);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.display);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Multiple);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Nine);
            this.Name = "caluculator";
            this.Text = "計算機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Multiple;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button Sign;
    }
}

