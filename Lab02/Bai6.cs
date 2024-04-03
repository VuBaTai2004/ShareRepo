using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Lab02
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }
        private void Bai6_Load(object sender, EventArgs e)
        {
            DisplayDriveContents();
        }
        private void DisplayDriveContents()
        {
            TreeNode treeNode = new TreeNode();
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in driveInfos)
            {
                string Node = driveInfo.Name;
                treeView1.Nodes.Add(Node);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void treeView1_DoubleClickNode(object sender, TreeNodeMouseClickEventArgs e)
        {
            string[] folders;
            string[] files;
            try
            {
                folders = Directory.GetDirectories(treeView1.SelectedNode.FullPath);
                files = Directory.GetFiles(treeView1.SelectedNode.FullPath);
            }
            catch(Exception)
            {
                return;
            }
            foreach (string folder in folders)
            {
                TreeNode SubNode = new TreeNode();
                string rmPath = treeView1.SelectedNode.FullPath;
                string sn = folder.Remove(0, rmPath.Length);
                treeView1.SelectedNode.Nodes.Add(sn);
            }
            foreach (string file in files)
            {
                TreeNode SubNode = new TreeNode();
                string rmPath = treeView1.SelectedNode.FullPath;
                string sn = file.Remove(0, rmPath.Length);
                treeView1.SelectedNode.Nodes.Add(sn);
            }
            treeView1.SelectedNode.Expand();
        }

        private void treeView1_ClickNode(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            FileAttributes attb = File.GetAttributes(node.FullPath);
            //kiểm tra file có phải thư mục k
            if(!attb.HasFlag(FileAttributes.Directory))
            {
                FileInfo fi = new FileInfo(node.FullPath);
                try
                {
                    FileInfo fileInfo = new FileInfo(node.FullPath);
                    if (fileInfo.Extension == ".png" || fileInfo.Extension == ".jpg")
                    {
                        pictureBox1.Visible = true;
                        pictureBox1.ImageLocation = node.FullPath;
                        pictureBox1.Load(node.FullPath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else if (fileInfo.Extension == ".txt")
                    {
                        pictureBox1.Visible = false;
                        FileStream fs = new FileStream(node.FullPath, FileMode.Open, FileAccess.Read);
                        StreamReader reader = new StreamReader(fs);
                        groupBox1.Text = "File Content\n";
                        groupBox1.Text += reader.ReadToEnd();
                        reader.Close();
                        fs.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hiện chương trình chưa hỗ trợ các loại file khác ngoài .txt, .png, .jpg");
                        return;
                    }
                }
                catch (System.ArgumentException)
                {
                    /*MessageBox.Show("Không phải ", "Notice");*/
                    return;
                }
            }
        }
    }
}
