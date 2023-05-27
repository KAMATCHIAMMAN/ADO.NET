namespace Windowsforms
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
            label1 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            Addition = new Label();
            Input = new Label();
            textBox = new TextBox();
            number1 = new Button();
            number2 = new Button();
            number3 = new Button();
            number4 = new Button();
            number5 = new Button();
            number6 = new Button();
            number7 = new Button();
            number8 = new Button();
            number9 = new Button();
            number0 = new Button();
            dot = new Button();
            clear = new Button();
            addnumbers = new Button();
            subnumbers = new Button();
            mulnumbers = new Button();
            divnumbers = new Button();
            equal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "valueone";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(462, 24);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(288, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 28);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "valuetwo";
            label2.Click += label2_Click;
            // 
            // Addition
            // 
            Addition.AutoSize = true;
            Addition.Location = new Point(264, 135);
            Addition.Name = "Addition";
            Addition.Size = new Size(0, 15);
            Addition.TabIndex = 7;
            // 
            // Input
            // 
            Input.AutoSize = true;
            Input.Location = new Point(122, 112);
            Input.Name = "Input";
            Input.Size = new Size(63, 15);
            Input.TabIndex = 8;
            Input.Text = "Inputvalue";
            Input.Click += Result_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(276, 109);
            textBox.Name = "textBox";
            textBox.Size = new Size(100, 23);
            textBox.TabIndex = 9;
            // 
            // number1
            // 
            number1.BackColor = Color.Blue;
            number1.Location = new Point(237, 161);
            number1.Name = "number1";
            number1.Size = new Size(51, 23);
            number1.TabIndex = 10;
            number1.Text = "1";
            number1.UseVisualStyleBackColor = false;
            number1.Click += number1_Click;
            // 
            // number2
            // 
            number2.BackColor = Color.Blue;
            number2.Location = new Point(308, 161);
            number2.Name = "number2";
            number2.Size = new Size(55, 23);
            number2.TabIndex = 11;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = false;
            number2.Click += number2_Click;
            // 
            // number3
            // 
            number3.BackColor = Color.Blue;
            number3.Location = new Point(384, 161);
            number3.Name = "number3";
            number3.Size = new Size(61, 23);
            number3.TabIndex = 12;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = false;
            number3.Click += number3_Click;
            // 
            // number4
            // 
            number4.BackColor = Color.Blue;
            number4.Location = new Point(237, 200);
            number4.Name = "number4";
            number4.Size = new Size(51, 23);
            number4.TabIndex = 13;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = false;
            number4.Click += number4_Click;
            // 
            // number5
            // 
            number5.BackColor = Color.Blue;
            number5.Location = new Point(308, 202);
            number5.Name = "number5";
            number5.Size = new Size(55, 23);
            number5.TabIndex = 14;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = false;
            number5.Click += number5_Click;
            // 
            // number6
            // 
            number6.BackColor = Color.Blue;
            number6.Location = new Point(384, 204);
            number6.Name = "number6";
            number6.Size = new Size(61, 23);
            number6.TabIndex = 15;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = false;
            number6.Click += number6_Click;
            // 
            // number7
            // 
            number7.BackColor = Color.Blue;
            number7.Location = new Point(237, 239);
            number7.Name = "number7";
            number7.Size = new Size(51, 23);
            number7.TabIndex = 16;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = false;
            number7.Click += number7_Click;
            // 
            // number8
            // 
            number8.BackColor = Color.Blue;
            number8.Location = new Point(308, 239);
            number8.Name = "number8";
            number8.Size = new Size(51, 23);
            number8.TabIndex = 17;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = false;
            number8.Click += number8_Click;
            // 
            // number9
            // 
            number9.BackColor = Color.Blue;
            number9.Location = new Point(384, 239);
            number9.Name = "number9";
            number9.Size = new Size(61, 23);
            number9.TabIndex = 18;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = false;
            number9.Click += number9_Click;
            // 
            // number0
            // 
            number0.BackColor = Color.Blue;
            number0.Location = new Point(237, 278);
            number0.Name = "number0";
            number0.Size = new Size(51, 23);
            number0.TabIndex = 19;
            number0.Text = "0";
            number0.UseVisualStyleBackColor = false;
            number0.Click += number0_Click;
            // 
            // dot
            // 
            dot.BackColor = Color.Blue;
            dot.Location = new Point(311, 277);
            dot.Name = "dot";
            dot.Size = new Size(48, 23);
            dot.TabIndex = 20;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.Red;
            clear.Location = new Point(384, 277);
            clear.Name = "clear";
            clear.Size = new Size(61, 23);
            clear.TabIndex = 21;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // addnumbers
            // 
            addnumbers.BackColor = Color.Yellow;
            addnumbers.Location = new Point(462, 161);
            addnumbers.Name = "addnumbers";
            addnumbers.Size = new Size(54, 23);
            addnumbers.TabIndex = 22;
            addnumbers.Text = "+";
            addnumbers.UseVisualStyleBackColor = false;
            addnumbers.Click += addnumbers_Click;
            // 
            // subnumbers
            // 
            subnumbers.BackColor = Color.Yellow;
            subnumbers.Location = new Point(462, 204);
            subnumbers.Name = "subnumbers";
            subnumbers.Size = new Size(54, 23);
            subnumbers.TabIndex = 23;
            subnumbers.Text = "-";
            subnumbers.UseVisualStyleBackColor = false;
            subnumbers.Click += subnumbers_Click;
            // 
            // mulnumbers
            // 
            mulnumbers.BackColor = Color.Yellow;
            mulnumbers.Location = new Point(462, 239);
            mulnumbers.Name = "mulnumbers";
            mulnumbers.Size = new Size(54, 23);
            mulnumbers.TabIndex = 24;
            mulnumbers.Text = "*";
            mulnumbers.UseVisualStyleBackColor = false;
            mulnumbers.Click += mulnumbers_Click;
            // 
            // divnumbers
            // 
            divnumbers.BackColor = Color.Yellow;
            divnumbers.Location = new Point(462, 278);
            divnumbers.Name = "divnumbers";
            divnumbers.Size = new Size(54, 23);
            divnumbers.TabIndex = 25;
            divnumbers.Text = "/";
            divnumbers.UseVisualStyleBackColor = false;
            divnumbers.Click += divnumbers_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.Green;
            equal.Location = new Point(342, 317);
            equal.Name = "equal";
            equal.Size = new Size(75, 23);
            equal.TabIndex = 26;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(equal);
            Controls.Add(divnumbers);
            Controls.Add(mulnumbers);
            Controls.Add(subnumbers);
            Controls.Add(addnumbers);
            Controls.Add(clear);
            Controls.Add(dot);
            Controls.Add(number0);
            Controls.Add(number9);
            Controls.Add(number8);
            Controls.Add(number7);
            Controls.Add(number6);
            Controls.Add(number5);
            Controls.Add(number4);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(textBox);
            Controls.Add(Input);
            Controls.Add(Addition);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label Addition;
        private Label Input;
        private TextBox textBox;
        private Button number1;
        private Button number2;
        private Button number3;
        private Button number4;
        private Button number5;
        private Button number6;
        private Button number7;
        private Button number8;
        private Button number9;
        private Button number0;
        private Button dot;
        private Button clear;
        private Button addnumbers;
        private Button subnumbers;
        private Button mulnumbers;
        private Button divnumbers;
        private Button equal;
    }
}