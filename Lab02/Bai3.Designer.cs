namespace Lab02
{
    partial class Bai3
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
            textOutput = new RichTextBox();
            btn_WriteFile = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // btn_ReadFile
            // 
            btn_ReadFile.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ReadFile.Location = new Point(16, 14);
            btn_ReadFile.Margin = new Padding(4, 3, 4, 3);
            btn_ReadFile.Name = "btn_ReadFile";
            btn_ReadFile.Size = new Size(550, 46);
            btn_ReadFile.TabIndex = 0;
            btn_ReadFile.Text = "CHỌN FILE MUỐN TÍNH TOÁN";
            btn_ReadFile.UseVisualStyleBackColor = true;
            btn_ReadFile.Click += btn_ReadFile_Click;
            // 
            // textOutput
            // 
            textOutput.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textOutput.Location = new Point(16, 67);
            textOutput.Margin = new Padding(4, 3, 4, 3);
            textOutput.Name = "textOutput";
            textOutput.ReadOnly = true;
            textOutput.Size = new Size(548, 478);
            textOutput.TabIndex = 1;
            textOutput.Text = "";
            // 
            // btn_WriteFile
            // 
            btn_WriteFile.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_WriteFile.Location = new Point(16, 552);
            btn_WriteFile.Margin = new Padding(4, 3, 4, 3);
            btn_WriteFile.Name = "btn_WriteFile";
            btn_WriteFile.Size = new Size(275, 46);
            btn_WriteFile.TabIndex = 2;
            btn_WriteFile.Text = "XUẤT FILE";
            btn_WriteFile.UseVisualStyleBackColor = true;
            btn_WriteFile.Click += btn_WriteFile_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(292, 552);
            btn_Exit.Margin = new Padding(4, 3, 4, 3);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(275, 46);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "THOÁT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 612);
            Controls.Add(btn_Exit);
            Controls.Add(btn_WriteFile);
            Controls.Add(textOutput);
            Controls.Add(btn_ReadFile);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ReadFile;
        private RichTextBox textOutput;
        private Button btn_WriteFile;
        private Button btn_Exit;
    }
}