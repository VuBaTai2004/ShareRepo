namespace Lab02
{
    partial class Lab2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bai01 = new Button();
            Bai02 = new Button();
            Bai03 = new Button();
            Bai04 = new Button();
            Bai05 = new Button();
            Bai06 = new Button();
            SuspendLayout();
            // 
            // Bai01
            // 
            Bai01.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bai01.Location = new Point(12, 12);
            Bai01.Name = "Bai01";
            Bai01.Size = new Size(118, 37);
            Bai01.TabIndex = 0;
            Bai01.Text = "Bài 1";
            Bai01.UseVisualStyleBackColor = true;
            Bai01.Click += Bai01_Click;
            // 
            // Bai02
            // 
            Bai02.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bai02.Location = new Point(136, 12);
            Bai02.Name = "Bai02";
            Bai02.Size = new Size(118, 37);
            Bai02.TabIndex = 1;
            Bai02.Text = "Bài 2";
            Bai02.UseVisualStyleBackColor = true;
            Bai02.Click += Bai02_Click;
            // 
            // Bai03
            // 
            Bai03.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bai03.Location = new Point(260, 12);
            Bai03.Name = "Bai03";
            Bai03.Size = new Size(102, 37);
            Bai03.TabIndex = 2;
            Bai03.Text = "Bài 3";
            Bai03.UseVisualStyleBackColor = true;
            Bai03.Click += Bai3_Click;
            // 
            // Bai04
            // 
            Bai04.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bai04.Location = new Point(368, 12);
            Bai04.Name = "Bai04";
            Bai04.Size = new Size(102, 37);
            Bai04.TabIndex = 3;
            Bai04.Text = "Bài 4";
            Bai04.UseVisualStyleBackColor = true;
            Bai04.Click += Bai04_Click;
            // 
            // Bai05
            // 
            Bai05.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bai05.Location = new Point(476, 12);
            Bai05.Name = "Bai05";
            Bai05.Size = new Size(102, 37);
            Bai05.TabIndex = 4;
            Bai05.Text = "Bài 5";
            Bai05.UseVisualStyleBackColor = true;
            Bai05.Click += Bai05_Click;
            // 
            // Bai06
            // 
            Bai06.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bai06.Location = new Point(584, 12);
            Bai06.Name = "Bai06";
            Bai06.Size = new Size(102, 37);
            Bai06.TabIndex = 5;
            Bai06.Text = "Bài 6";
            Bai06.UseVisualStyleBackColor = true;
            Bai06.Click += Bai06_Click;
            // 
            // Lab2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Bai06);
            Controls.Add(Bai05);
            Controls.Add(Bai04);
            Controls.Add(Bai03);
            Controls.Add(Bai02);
            Controls.Add(Bai01);
            Name = "Lab2";
            Text = "Lab2";
            ResumeLayout(false);
        }

        #endregion

        private Button Bai01;
        private Button Bai02;
        private Button Bai03;
        private Button Bai04;
        private Button Bai05;
        private Button Bai06;
    }
}