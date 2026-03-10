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
            SideA = new TextBox();
            SideB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SideC = new TextBox();
            SideD = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // SideA
            // 
            SideA.Location = new Point(106, 71);
            SideA.Name = "SideA";
            SideA.Size = new Size(125, 27);
            SideA.TabIndex = 0;
            // 
            // SideB
            // 
            SideB.Location = new Point(106, 125);
            SideB.Name = "SideB";
            SideB.Size = new Size(125, 27);
            SideB.TabIndex = 1;
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
            // SideC
            // 
            SideC.Location = new Point(322, 71);
            SideC.Name = "SideC";
            SideC.Size = new Size(125, 27);
            SideC.TabIndex = 4;
            // 
            // SideD
            // 
            SideD.Location = new Point(322, 125);
            SideD.Name = "SideD";
            SideD.Size = new Size(125, 27);
            SideD.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 74);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 6;
            label3.Text = "Сторона a";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 128);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 7;
            label4.Text = "Сторона b";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 74);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 8;
            label5.Text = "Сторона c";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 128);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 9;
            label6.Text = "Сторона d";
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
            button1.Location = new Point(197, 200);
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
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SideD);
            Controls.Add(SideC);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SideB);
            Controls.Add(SideA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SideA;
        private TextBox SideB;
        private Label label1;
        private Label label2;
        private TextBox SideC;
        private TextBox SideD;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}
