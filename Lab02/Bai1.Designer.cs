namespace Lab02
{
    partial class Bai1
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
            btn_Read = new Button();
            btn_Write = new Button();
            Output = new RichTextBox();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // btn_Read
            // 
            btn_Read.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Read.Location = new Point(11, 13);
            btn_Read.Margin = new Padding(4, 3, 4, 3);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(161, 57);
            btn_Read.TabIndex = 0;
            btn_Read.Text = "Đọc file";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Write
            // 
            btn_Write.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Write.Location = new Point(11, 76);
            btn_Write.Margin = new Padding(4, 3, 4, 3);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(161, 60);
            btn_Write.TabIndex = 1;
            btn_Write.Text = "Ghi file";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // Output
            // 
            Output.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Output.ImeMode = ImeMode.Off;
            Output.Location = new Point(180, 13);
            Output.Margin = new Padding(4, 3, 4, 3);
            Output.Name = "Output";
            Output.ReadOnly = true;
            Output.Size = new Size(808, 447);
            Output.TabIndex = 2;
            Output.Text = "";
            Output.TextChanged += Output_TextChanged;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(11, 402);
            btn_Exit.Margin = new Padding(4, 3, 4, 3);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(161, 58);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += button_Exit_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 472);
            Controls.Add(btn_Exit);
            Controls.Add(Output);
            Controls.Add(btn_Write);
            Controls.Add(btn_Read);
            Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bai1";
            Text = "Bài 01";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Read;
        private Button btn_Write;
        private RichTextBox Output;
        private Button btn_Exit;
    }
}
