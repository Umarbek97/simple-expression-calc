namespace calculator
{
    partial class SimpleCalculator
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.powMinusOne = new System.Windows.Forms.Button();
            this.execute = new System.Windows.Forms.Button();
            this.openingBrace = new System.Windows.Forms.Button();
            this.closingBrace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox.Size = new System.Drawing.Size(358, 41);
            this.textBox.TabIndex = 0;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(11, 121);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(67, 43);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.Location = new System.Drawing.Point(84, 121);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(67, 43);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.Location = new System.Drawing.Point(157, 121);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(67, 43);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(11, 170);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(67, 43);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(84, 170);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(67, 43);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(157, 170);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(67, 43);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(11, 219);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(67, 43);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(84, 219);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(67, 43);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(157, 219);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(67, 43);
            this.three.TabIndex = 9;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.Location = new System.Drawing.Point(12, 266);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(139, 43);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot.Location = new System.Drawing.Point(157, 266);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(67, 43);
            this.dot.TabIndex = 11;
            this.dot.Text = ",";
            this.dot.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(230, 121);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(67, 43);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtract.Location = new System.Drawing.Point(230, 170);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(67, 43);
            this.subtract.TabIndex = 13;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(230, 219);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(67, 43);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(230, 266);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(67, 43);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // factorial
            // 
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factorial.Location = new System.Drawing.Point(303, 170);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(67, 43);
            this.factorial.TabIndex = 16;
            this.factorial.Text = "!";
            this.factorial.UseVisualStyleBackColor = true;
            // 
            // squareRoot
            // 
            this.squareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareRoot.Location = new System.Drawing.Point(303, 219);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(67, 43);
            this.squareRoot.TabIndex = 17;
            this.squareRoot.Text = "Sqrt";
            this.squareRoot.UseVisualStyleBackColor = true;
            // 
            // pow
            // 
            this.pow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pow.Location = new System.Drawing.Point(303, 121);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(67, 43);
            this.pow.TabIndex = 18;
            this.pow.Text = "^";
            this.pow.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset.Location = new System.Drawing.Point(12, 72);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(67, 43);
            this.reset.TabIndex = 19;
            this.reset.Text = "C";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(303, 72);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(67, 43);
            this.clear.TabIndex = 20;
            this.clear.Text = "<-";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // powMinusOne
            // 
            this.powMinusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powMinusOne.Location = new System.Drawing.Point(303, 266);
            this.powMinusOne.Name = "powMinusOne";
            this.powMinusOne.Size = new System.Drawing.Size(67, 43);
            this.powMinusOne.TabIndex = 21;
            this.powMinusOne.Text = "1/x";
            this.powMinusOne.UseVisualStyleBackColor = true;
            // 
            // execute
            // 
            this.execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.execute.Location = new System.Drawing.Point(85, 72);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(67, 43);
            this.execute.TabIndex = 22;
            this.execute.Text = "=";
            this.execute.UseVisualStyleBackColor = true;
            // 
            // openingBrace
            // 
            this.openingBrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openingBrace.Location = new System.Drawing.Point(158, 72);
            this.openingBrace.Name = "openingBrace";
            this.openingBrace.Size = new System.Drawing.Size(67, 43);
            this.openingBrace.TabIndex = 23;
            this.openingBrace.Text = "(";
            this.openingBrace.UseVisualStyleBackColor = true;
            // 
            // closingBrace
            // 
            this.closingBrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closingBrace.Location = new System.Drawing.Point(230, 72);
            this.closingBrace.Name = "closingBrace";
            this.closingBrace.Size = new System.Drawing.Size(67, 43);
            this.closingBrace.TabIndex = 24;
            this.closingBrace.Text = ")";
            this.closingBrace.UseVisualStyleBackColor = true;
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 321);
            this.Controls.Add(this.closingBrace);
            this.Controls.Add(this.openingBrace);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.powMinusOne);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.textBox);
            this.Name = "SimpleCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button squareRoot;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button powMinusOne;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button openingBrace;
        private System.Windows.Forms.Button closingBrace;
    }
}

