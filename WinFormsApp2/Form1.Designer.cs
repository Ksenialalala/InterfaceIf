namespace WinFormsApp2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SideA = new Label();
            SideB = new Label();
            SideC = new Label();
            SideD = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 31);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 2;
            label1.Text = "Прямоугольник 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 31);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 3;
            label2.Text = "Прямоугольник 2";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(322, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(322, 125);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // SideA
            // 
            SideA.AutoSize = true;
            SideA.Location = new Point(20, 74);
            SideA.Name = "SideA";
            SideA.Size = new Size(80, 20);
            SideA.TabIndex = 6;
            SideA.Text = "Сторона a";
            // 
            // SideB
            // 
            SideB.AutoSize = true;
            SideB.Location = new Point(20, 128);
            SideB.Name = "SideB";
            SideB.Size = new Size(81, 20);
            SideB.TabIndex = 7;
            SideB.Text = "Сторона b";
            // 
            // SideC
            // 
            SideC.AutoSize = true;
            SideC.Location = new Point(237, 74);
            SideC.Name = "SideC";
            SideC.Size = new Size(79, 20);
            SideC.TabIndex = 8;
            SideC.Text = "Сторона c";
            // 
            // SideD
            // 
            SideD.AutoSize = true;
            SideD.Location = new Point(237, 128);
            SideD.Name = "SideD";
            SideD.Size = new Size(81, 20);
            SideD.TabIndex = 9;
            SideD.Text = "Сторона d";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 177);
            label7.Name = "label7";
            label7.Size = new Size(427, 20);
            label7.TabIndex = 10;
            label7.Text = "Можно ли поместить прямоугольник 1 в прямоугольник 2?";
            // 
            // button1
            // 
            button1.Location = new Point(202, 200);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Проверить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 241);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(SideD);
            Controls.Add(SideC);
            Controls.Add(SideB);
            Controls.Add(SideA);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label SideA;
        private Label SideB;
        private Label SideC;
        private Label SideD;
        private Label label7;
        private Button button1;
    }
}
