namespace Lab02
{
    partial class Bai2
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
            btn_ReadFile = new Button();
            lbl_FileName = new Label();
            txB_NameFile = new TextBox();
            txB_SizeFile = new TextBox();
            label1 = new Label();
            txB_URL = new TextBox();
            label2 = new Label();
            txB_LineOfFile = new TextBox();
            label3 = new Label();
            txB_WordOfFile = new TextBox();
            label4 = new Label();
            txB_CharacterOfFile = new TextBox();
            label5 = new Label();
            rTB_Output = new RichTextBox();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // btn_ReadFile
            // 
            btn_ReadFile.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            btn_ReadFile.Location = new Point(12, 12);
            btn_ReadFile.Name = "btn_ReadFile";
            btn_ReadFile.Size = new Size(400, 40);
            btn_ReadFile.TabIndex = 0;
            btn_ReadFile.Text = "ĐỌC FILE";
            btn_ReadFile.UseVisualStyleBackColor = true;
            btn_ReadFile.Click += btn_ReadFile_Click;
            // 
            // lbl_FileName
            // 
            lbl_FileName.AutoSize = true;
            lbl_FileName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FileName.Location = new Point(12, 61);
            lbl_FileName.Name = "lbl_FileName";
            lbl_FileName.Size = new Size(94, 23);
            lbl_FileName.TabIndex = 1;
            lbl_FileName.Text = "TÊN FILE";
            // 
            // txB_NameFile
            // 
            txB_NameFile.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txB_NameFile.Location = new Point(193, 58);
            txB_NameFile.Name = "txB_NameFile";
            txB_NameFile.ReadOnly = true;
            txB_NameFile.Size = new Size(219, 31);
            txB_NameFile.TabIndex = 2;
            txB_NameFile.TextChanged += textBox1_TextChanged;
            // 
            // txB_SizeFile
            // 
            txB_SizeFile.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txB_SizeFile.Location = new Point(193, 91);
            txB_SizeFile.Name = "txB_SizeFile";
            txB_SizeFile.ReadOnly = true;
            txB_SizeFile.Size = new Size(219, 31);
            txB_SizeFile.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 3;
            label1.Text = "KÍCH THƯỚC FILE";
            // 
            // txB_URL
            // 
            txB_URL.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txB_URL.Location = new Point(193, 124);
            txB_URL.Name = "txB_URL";
            txB_URL.ReadOnly = true;
            txB_URL.Size = new Size(219, 31);
            txB_URL.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 5;
            label2.Text = "URL";
            // 
            // txB_LineOfFile
            // 
            txB_LineOfFile.Font = new Font("Cambria", 12F);
            txB_LineOfFile.Location = new Point(193, 157);
            txB_LineOfFile.Name = "txB_LineOfFile";
            txB_LineOfFile.ReadOnly = true;
            txB_LineOfFile.Size = new Size(219, 31);
            txB_LineOfFile.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 7;
            label3.Text = "SỐ DÒNG";
            // 
            // txB_WordOfFile
            // 
            txB_WordOfFile.Font = new Font("Cambria", 12F);
            txB_WordOfFile.Location = new Point(193, 190);
            txB_WordOfFile.Name = "txB_WordOfFile";
            txB_WordOfFile.ReadOnly = true;
            txB_WordOfFile.Size = new Size(219, 31);
            txB_WordOfFile.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 193);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 9;
            label4.Text = "SỐ TỪ";
            // 
            // txB_CharacterOfFile
            // 
            txB_CharacterOfFile.Font = new Font("Cambria", 12F);
            txB_CharacterOfFile.Location = new Point(193, 223);
            txB_CharacterOfFile.Name = "txB_CharacterOfFile";
            txB_CharacterOfFile.ReadOnly = true;
            txB_CharacterOfFile.Size = new Size(219, 31);
            txB_CharacterOfFile.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 226);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 11;
            label5.Text = "SỐ KÝ TỰ";
            // 
            // rTB_Output
            // 
            rTB_Output.Font = new Font("Cambria", 12F);
            rTB_Output.Location = new Point(418, 12);
            rTB_Output.Name = "rTB_Output";
            rTB_Output.ReadOnly = true;
            rTB_Output.Size = new Size(400, 288);
            rTB_Output.TabIndex = 13;
            rTB_Output.Text = "";
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            btn_Exit.Location = new Point(12, 260);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(400, 40);
            btn_Exit.TabIndex = 14;
            btn_Exit.Text = "THOÁT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 311);
            Controls.Add(btn_Exit);
            Controls.Add(rTB_Output);
            Controls.Add(txB_CharacterOfFile);
            Controls.Add(label5);
            Controls.Add(txB_WordOfFile);
            Controls.Add(label4);
            Controls.Add(txB_LineOfFile);
            Controls.Add(label3);
            Controls.Add(txB_URL);
            Controls.Add(label2);
            Controls.Add(txB_SizeFile);
            Controls.Add(label1);
            Controls.Add(txB_NameFile);
            Controls.Add(lbl_FileName);
            Controls.Add(btn_ReadFile);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ReadFile;
        private Label lbl_FileName;
        private TextBox txB_NameFile;
        private TextBox txB_SizeFile;
        private Label label1;
        private TextBox txB_URL;
        private Label label2;
        private TextBox txB_LineOfFile;
        private Label label3;
        private TextBox txB_WordOfFile;
        private Label label4;
        private TextBox txB_CharacterOfFile;
        private Label label5;
        private RichTextBox rTB_Output;
        private Button btn_Exit;
    }
}