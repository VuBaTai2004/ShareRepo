namespace Lab02
{
    partial class Bai6
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
            treeView1 = new TreeView();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            treeView1.HideSelection = false;
            treeView1.Location = new Point(18, 13);
            treeView1.Margin = new Padding(4);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(295, 561);
            treeView1.TabIndex = 2;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.NodeMouseClick += treeView1_ClickNode;
            treeView1.NodeMouseDoubleClick += treeView1_DoubleClickNode;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Cambria", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(320, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1081, 561);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Content";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(0, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1075, 523);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 590);
            Controls.Add(groupBox1);
            Controls.Add(treeView1);
            Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Bai6";
            Text = "Bai6";
            Activated += Bai6_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TreeView treeView1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}