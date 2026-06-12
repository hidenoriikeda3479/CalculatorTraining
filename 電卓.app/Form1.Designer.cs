namespace 電卓.app
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
            buttonS = new Button();
            buttonA = new Button();
            button7 = new Button();
            button8 = new Button();
            buttonNumber = new Button();
            buttonM = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonOperator = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonE = new Button();
            buttonC = new Button();
            button0 = new Button();
            buttonD = new Button();
            textBox1 = new TextBox();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // buttonS
            // 
            buttonS.Font = new Font("UD デジタル 教科書体 NP", 12F);
            buttonS.Location = new Point(407, 102);
            buttonS.Name = "buttonS";
            buttonS.Size = new Size(150, 150);
            buttonS.TabIndex = 0;
            buttonS.Text = "/";
            buttonS.UseVisualStyleBackColor = true;
            buttonS.Click += buttonOperator_Click;
            // 
            // buttonA
            // 
            buttonA.Font = new Font("UD デジタル 教科書体 NP", 12F);
            buttonA.Location = new Point(553, 102);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(150, 150);
            buttonA.TabIndex = 1;
            buttonA.Text = "*";
            buttonA.UseVisualStyleBackColor = true;
            buttonA.Click += buttonOperator_Click;
            // 
            // button7
            // 
            button7.Font = new Font("UD デジタル 教科書体 NP", 12F);
            button7.Location = new Point(111, 245);
            button7.Name = "button7";
            button7.Size = new Size(150, 150);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonNumber_Click;
            // 
            // button8
            // 
            button8.Font = new Font("UD デジタル 教科書体 NP", 12F);
            button8.Location = new Point(257, 245);
            button8.Name = "button8";
            button8.Size = new Size(150, 150);
            button8.TabIndex = 3;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonNumber_Click;
            // 
            // buttonNumber
            // 
            buttonNumber.Font = new Font("UD デジタル 教科書体 NP", 12F);
            buttonNumber.Location = new Point(407, 245);
            buttonNumber.Name = "buttonNumber";
            buttonNumber.Size = new Size(150, 150);
            buttonNumber.TabIndex = 4;
            buttonNumber.Text = "9";
            buttonNumber.UseVisualStyleBackColor = true;
            buttonNumber.Click += buttonNumber_Click;
            // 
            // buttonM
            // 
            buttonM.Font = new Font("UD デジタル 教科書体 NP", 12F);
            buttonM.Location = new Point(553, 245);
            buttonM.Name = "buttonM";
            buttonM.Size = new Size(150, 150);
            buttonM.TabIndex = 5;
            buttonM.Text = "-";
            buttonM.UseVisualStyleBackColor = true;
            buttonM.Click += buttonOperator_Click;
            // 
            // button4
            // 
            button4.Font = new Font("UD デジタル 教科書体 NP", 12F);
            button4.Location = new Point(111, 393);
            button4.Name = "button4";
            button4.Size = new Size(150, 150);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonNumber_Click;
            // 
            // button5
            // 
            button5.Font = new Font("UD デジタル 教科書体 NP", 12F);
            button5.Location = new Point(257, 393);
            button5.Name = "button5";
            button5.Size = new Size(150, 150);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonNumber_Click;
            // 
            // button6
            // 
            button6.Font = new Font("UD デジタル 教科書体 NP", 12F);
            button6.Location = new Point(407, 393);
            button6.Name = "button6";
            button6.Size = new Size(150, 150);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonNumber_Click;
            // 
            // buttonOperator
            // 
            buttonOperator.Font = new Font("UD デジタル 教科書体 NP", 12F);
            buttonOperator.Location = new Point(553, 393);
            buttonOperator.Name = "buttonOperator";
            buttonOperator.Size = new Size(150, 150);
            buttonOperator.TabIndex = 9;
            buttonOperator.Text = "+";
            buttonOperator.UseVisualStyleBackColor = true;
            buttonOperator.Click += buttonOperator_Click;
            // 
            // button1
            // 
            button1.Font = new Font("UD デジタル 教科書体 NP", 12F);
            button1.Location = new Point(111, 539);
            button1.Name = "button1";
            button1.Size = new Size(150, 150);
            button1.TabIndex = 10;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonNumber_Click;
            // 
            // button2
            // 
            button2.Font = new Font("UD デジタル 教科書体 NP", 12F);
            button2.Location = new Point(257, 539);
            button2.Name = "button2";
            button2.Size = new Size(150, 150);
            button2.TabIndex = 11;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonNumber_Click;
            // 
            // button3
            // 
            button3.Font = new Font("UD デジタル 教科書体 NP", 12F);
            button3.Location = new Point(407, 539);
            button3.Name = "button3";
            button3.Size = new Size(150, 150);
            button3.TabIndex = 12;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonNumber_Click;
            // 
            // buttonE
            // 
            buttonE.Font = new Font("UD デジタル 教科書体 NP", 12F);
            buttonE.Location = new Point(553, 539);
            buttonE.Name = "buttonE";
            buttonE.Size = new Size(150, 150);
            buttonE.TabIndex = 13;
            buttonE.Text = "=";
            buttonE.UseVisualStyleBackColor = true;
            buttonE.Click += buttonE_Click;
            // 
            // buttonC
            // 
            buttonC.Font = new Font("UD デジタル 教科書体 NP", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonC.Location = new Point(111, 684);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(150, 150);
            buttonC.TabIndex = 14;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // button0
            // 
            button0.Font = new Font("UD デジタル 教科書体 NP", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button0.Location = new Point(257, 684);
            button0.Name = "button0";
            button0.Size = new Size(300, 150);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += buttonNumber_Click;
            // 
            // buttonD
            // 
            buttonD.Font = new Font("UD デジタル 教科書体 NP", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonD.Location = new Point(553, 684);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(150, 150);
            buttonD.TabIndex = 16;
            buttonD.Text = ".";
            buttonD.UseVisualStyleBackColor = true;
            buttonD.Click += buttonD_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(681, 75);
            textBox1.TabIndex = 18;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(257, 102);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 150);
            buttonDelete.TabIndex = 19;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 857);
            Controls.Add(textBox1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonD);
            Controls.Add(button0);
            Controls.Add(buttonC);
            Controls.Add(buttonE);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonOperator);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonM);
            Controls.Add(buttonNumber);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(buttonA);
            Controls.Add(buttonS);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonS;
        private Button buttonA;
        private Button button7;
        private Button button8;
        private Button buttonNumber;
        private Button buttonM;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonOperator;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonE;
        private Button buttonC;
        private Button button0;
        private Button buttonD;
        private TextBox textBox1;
        private Button buttonDelete;
    }
}
