namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zero_button = new System.Windows.Forms.Button();
            this.comma_button = new System.Windows.Forms.Button();
            this.equals_button = new System.Windows.Forms.Button();
            this.one_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.subtraction_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.multiplication_button = new System.Windows.Forms.Button();
            this.division_button = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.addition_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zero_button
            // 
            this.zero_button.Location = new System.Drawing.Point(12, 469);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(166, 80);
            this.zero_button.TabIndex = 0;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            this.zero_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // comma_button
            // 
            this.comma_button.Location = new System.Drawing.Point(184, 469);
            this.comma_button.Name = "comma_button";
            this.comma_button.Size = new System.Drawing.Size(80, 80);
            this.comma_button.TabIndex = 2;
            this.comma_button.Text = ",";
            this.comma_button.UseVisualStyleBackColor = true;
            this.comma_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // equals_button
            // 
            this.equals_button.Location = new System.Drawing.Point(270, 469);
            this.equals_button.Name = "equals_button";
            this.equals_button.Size = new System.Drawing.Size(80, 80);
            this.equals_button.TabIndex = 3;
            this.equals_button.Text = "=";
            this.equals_button.UseVisualStyleBackColor = true;
            this.equals_button.Click += new System.EventHandler(this.OnClickResultButton);
            // 
            // one_button
            // 
            this.one_button.Location = new System.Drawing.Point(12, 383);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(80, 80);
            this.one_button.TabIndex = 4;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            this.one_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // two_button
            // 
            this.two_button.Location = new System.Drawing.Point(98, 383);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(80, 80);
            this.two_button.TabIndex = 5;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // three_button
            // 
            this.three_button.Location = new System.Drawing.Point(184, 383);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(80, 80);
            this.three_button.TabIndex = 6;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            this.three_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // four_button
            // 
            this.four_button.Location = new System.Drawing.Point(12, 297);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(80, 80);
            this.four_button.TabIndex = 8;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // five_button
            // 
            this.five_button.Location = new System.Drawing.Point(98, 297);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(80, 80);
            this.five_button.TabIndex = 9;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // six_button
            // 
            this.six_button.Location = new System.Drawing.Point(184, 297);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(80, 80);
            this.six_button.TabIndex = 10;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            this.six_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // subtraction_button
            // 
            this.subtraction_button.Location = new System.Drawing.Point(270, 297);
            this.subtraction_button.Name = "subtraction_button";
            this.subtraction_button.Size = new System.Drawing.Size(80, 80);
            this.subtraction_button.TabIndex = 11;
            this.subtraction_button.Text = "-";
            this.subtraction_button.UseVisualStyleBackColor = true;
            this.subtraction_button.Click += new System.EventHandler(this.OnClickOperationButton);
            // 
            // seven_button
            // 
            this.seven_button.Location = new System.Drawing.Point(12, 211);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(80, 80);
            this.seven_button.TabIndex = 12;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // eight_button
            // 
            this.eight_button.Location = new System.Drawing.Point(98, 211);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(80, 80);
            this.eight_button.TabIndex = 13;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(12, 125);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(80, 80);
            this.clear_button.TabIndex = 14;
            this.clear_button.Text = "AC";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.ClearButton);
            // 
            // nine_button
            // 
            this.nine_button.Location = new System.Drawing.Point(184, 211);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(80, 80);
            this.nine_button.TabIndex = 15;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.OnClickNumberButton);
            // 
            // multiplication_button
            // 
            this.multiplication_button.Location = new System.Drawing.Point(270, 211);
            this.multiplication_button.Name = "multiplication_button";
            this.multiplication_button.Size = new System.Drawing.Size(80, 80);
            this.multiplication_button.TabIndex = 16;
            this.multiplication_button.Text = "x";
            this.multiplication_button.UseVisualStyleBackColor = true;
            this.multiplication_button.Click += new System.EventHandler(this.OnClickOperationButton);
            // 
            // division_button
            // 
            this.division_button.Location = new System.Drawing.Point(270, 125);
            this.division_button.Name = "division_button";
            this.division_button.Size = new System.Drawing.Size(80, 80);
            this.division_button.TabIndex = 17;
            this.division_button.Text = "÷";
            this.division_button.UseVisualStyleBackColor = true;
            this.division_button.Click += new System.EventHandler(this.OnClickOperationButton);
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display.Location = new System.Drawing.Point(13, 23);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(338, 82);
            this.Display.TabIndex = 18;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addition_button
            // 
            this.addition_button.Location = new System.Drawing.Point(270, 383);
            this.addition_button.Name = "addition_button";
            this.addition_button.Size = new System.Drawing.Size(80, 80);
            this.addition_button.TabIndex = 19;
            this.addition_button.Text = "+";
            this.addition_button.UseVisualStyleBackColor = true;
            this.addition_button.Click += new System.EventHandler(this.OnClickOperationButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 561);
            this.Controls.Add(this.addition_button);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.division_button);
            this.Controls.Add(this.multiplication_button);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.seven_button);
            this.Controls.Add(this.subtraction_button);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.four_button);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.one_button);
            this.Controls.Add(this.equals_button);
            this.Controls.Add(this.comma_button);
            this.Controls.Add(this.zero_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button zero_button;
        private Button comma_button;
        private Button equals_button;
        private Button one_button;
        private Button two_button;
        private Button three_button;
        private Button four_button;
        private Button five_button;
        private Button six_button;
        private Button subtraction_button;
        private Button seven_button;
        private Button eight_button;
        private Button clear_button;
        private Button nine_button;
        private Button multiplication_button;
        private Button division_button;
        private TextBox Display;
        private Button addition_button;
    }
}