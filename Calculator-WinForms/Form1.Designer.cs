namespace Calculator_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_division = new System.Windows.Forms.Button();
            this.button_percent = new System.Windows.Forms.Button();
            this.button_bracket = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_nine = new System.Windows.Forms.Button();
            this.button_eight = new System.Windows.Forms.Button();
            this.button_seven = new System.Windows.Forms.Button();
            this.button_subtraction = new System.Windows.Forms.Button();
            this.button_six = new System.Windows.Forms.Button();
            this.button_five = new System.Windows.Forms.Button();
            this.button_four = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_three = new System.Windows.Forms.Button();
            this.button_two = new System.Windows.Forms.Button();
            this.button_one = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.button_zero = new System.Windows.Forms.Button();
            this.change_symbols = new System.Windows.Forms.Button();
            this.DarkTheme = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_division
            // 
            this.button_division.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_division.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_division.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_division.Location = new System.Drawing.Point(219, 106);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(62, 62);
            this.button_division.TabIndex = 40;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = false;
            this.button_division.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_percent
            // 
            this.button_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_percent.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_percent.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_percent.Location = new System.Drawing.Point(151, 106);
            this.button_percent.Name = "button_percent";
            this.button_percent.Size = new System.Drawing.Size(62, 62);
            this.button_percent.TabIndex = 39;
            this.button_percent.Text = "%";
            this.button_percent.UseVisualStyleBackColor = false;
            this.button_percent.Click += new System.EventHandler(this.button_percent_Click);
            // 
            // button_bracket
            // 
            this.button_bracket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_bracket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bracket.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_bracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bracket.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bracket.Location = new System.Drawing.Point(83, 106);
            this.button_bracket.Name = "button_bracket";
            this.button_bracket.Size = new System.Drawing.Size(62, 62);
            this.button_bracket.TabIndex = 38;
            this.button_bracket.Text = "<-";
            this.button_bracket.UseVisualStyleBackColor = false;
            this.button_bracket.Click += new System.EventHandler(this.button_bracket_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(15, 106);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(62, 62);
            this.button_clear.TabIndex = 37;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_multiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_multiplication.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_multiplication.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiplication.Location = new System.Drawing.Point(219, 174);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(62, 62);
            this.button_multiplication.TabIndex = 36;
            this.button_multiplication.Text = "x";
            this.button_multiplication.UseVisualStyleBackColor = false;
            this.button_multiplication.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_nine
            // 
            this.button_nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_nine.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nine.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nine.Location = new System.Drawing.Point(151, 174);
            this.button_nine.Name = "button_nine";
            this.button_nine.Size = new System.Drawing.Size(62, 62);
            this.button_nine.TabIndex = 35;
            this.button_nine.Text = "9";
            this.button_nine.UseVisualStyleBackColor = true;
            this.button_nine.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_eight
            // 
            this.button_eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_eight.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eight.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eight.Location = new System.Drawing.Point(83, 174);
            this.button_eight.Name = "button_eight";
            this.button_eight.Size = new System.Drawing.Size(62, 62);
            this.button_eight.TabIndex = 34;
            this.button_eight.Text = "8";
            this.button_eight.UseVisualStyleBackColor = true;
            this.button_eight.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_seven
            // 
            this.button_seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_seven.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_seven.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seven.Location = new System.Drawing.Point(15, 174);
            this.button_seven.Name = "button_seven";
            this.button_seven.Size = new System.Drawing.Size(62, 62);
            this.button_seven.TabIndex = 33;
            this.button_seven.Text = "7";
            this.button_seven.UseVisualStyleBackColor = true;
            this.button_seven.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_subtraction
            // 
            this.button_subtraction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_subtraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_subtraction.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subtraction.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subtraction.Location = new System.Drawing.Point(219, 242);
            this.button_subtraction.Name = "button_subtraction";
            this.button_subtraction.Size = new System.Drawing.Size(62, 62);
            this.button_subtraction.TabIndex = 32;
            this.button_subtraction.Text = "-";
            this.button_subtraction.UseVisualStyleBackColor = false;
            this.button_subtraction.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_six
            // 
            this.button_six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_six.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_six.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_six.Location = new System.Drawing.Point(151, 242);
            this.button_six.Name = "button_six";
            this.button_six.Size = new System.Drawing.Size(62, 62);
            this.button_six.TabIndex = 31;
            this.button_six.Text = "6";
            this.button_six.UseVisualStyleBackColor = true;
            this.button_six.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_five
            // 
            this.button_five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_five.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_five.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_five.Location = new System.Drawing.Point(83, 242);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(62, 62);
            this.button_five.TabIndex = 30;
            this.button_five.Text = "5";
            this.button_five.UseVisualStyleBackColor = true;
            this.button_five.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_four
            // 
            this.button_four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_four.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_four.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_four.Location = new System.Drawing.Point(15, 242);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(62, 62);
            this.button_four.TabIndex = 29;
            this.button_four.Text = "4";
            this.button_four.UseVisualStyleBackColor = true;
            this.button_four.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_plus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(219, 310);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(62, 62);
            this.button_plus.TabIndex = 28;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_three
            // 
            this.button_three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_three.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_three.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_three.Location = new System.Drawing.Point(151, 310);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(62, 62);
            this.button_three.TabIndex = 27;
            this.button_three.Text = "3";
            this.button_three.UseVisualStyleBackColor = true;
            this.button_three.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_two
            // 
            this.button_two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_two.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_two.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_two.Location = new System.Drawing.Point(83, 310);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(62, 62);
            this.button_two.TabIndex = 26;
            this.button_two.Text = "2";
            this.button_two.UseVisualStyleBackColor = true;
            this.button_two.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_one
            // 
            this.button_one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_one.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_one.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_one.Location = new System.Drawing.Point(15, 310);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(62, 62);
            this.button_one.TabIndex = 25;
            this.button_one.Text = "1";
            this.button_one.UseVisualStyleBackColor = true;
            this.button_one.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.RosyBrown;
            this.equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(219, 378);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(62, 62);
            this.equal.TabIndex = 24;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // dot
            // 
            this.dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dot.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(151, 378);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(62, 62);
            this.dot.TabIndex = 23;
            this.dot.Text = ",";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_zero
            // 
            this.button_zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zero.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zero.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_zero.Location = new System.Drawing.Point(83, 378);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(62, 62);
            this.button_zero.TabIndex = 22;
            this.button_zero.Text = "0";
            this.button_zero.UseVisualStyleBackColor = true;
            this.button_zero.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // change_symbols
            // 
            this.change_symbols.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_symbols.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.change_symbols.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_symbols.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_symbols.Location = new System.Drawing.Point(15, 378);
            this.change_symbols.Name = "change_symbols";
            this.change_symbols.Size = new System.Drawing.Size(62, 62);
            this.change_symbols.TabIndex = 21;
            this.change_symbols.Text = "+/-";
            this.change_symbols.UseVisualStyleBackColor = true;
            this.change_symbols.Click += new System.EventHandler(this.change_symbols_Click);
            // 
            // DarkTheme
            // 
            this.DarkTheme.AutoSize = true;
            this.DarkTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DarkTheme.Location = new System.Drawing.Point(11, 4);
            this.DarkTheme.Name = "DarkTheme";
            this.DarkTheme.Size = new System.Drawing.Size(101, 20);
            this.DarkTheme.TabIndex = 0;
            this.DarkTheme.Text = "DarkTheme";
            this.DarkTheme.UseVisualStyleBackColor = true;
            this.DarkTheme.CheckedChanged += new System.EventHandler(this.DarkTheme_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(4, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 67);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DarkTheme);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 98);
            this.panel1.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(297, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_percent);
            this.Controls.Add(this.button_bracket);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_nine);
            this.Controls.Add(this.button_eight);
            this.Controls.Add(this.button_seven);
            this.Controls.Add(this.button_subtraction);
            this.Controls.Add(this.button_six);
            this.Controls.Add(this.button_five);
            this.Controls.Add(this.button_four);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_three);
            this.Controls.Add(this.button_two);
            this.Controls.Add(this.button_one);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.button_zero);
            this.Controls.Add(this.change_symbols);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.button_zero_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_percent;
        private System.Windows.Forms.Button button_bracket;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_nine;
        private System.Windows.Forms.Button button_eight;
        private System.Windows.Forms.Button button_seven;
        private System.Windows.Forms.Button button_subtraction;
        private System.Windows.Forms.Button button_six;
        private System.Windows.Forms.Button button_five;
        private System.Windows.Forms.Button button_four;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_three;
        private System.Windows.Forms.Button button_two;
        private System.Windows.Forms.Button button_one;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button button_zero;
        private System.Windows.Forms.Button change_symbols;
        private System.Windows.Forms.CheckBox DarkTheme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

