using System.Security.Cryptography;

namespace Lab02
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs;
            try
            {
                fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            }
            catch (Exception)
            {
                return;
            }
            StreamReader sr = new StreamReader(fs);
            Output.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(Output.Text.ToUpper());
            sw.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
