using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs;
            FileInfo fi;
            StreamReader sr;
            string filename, url, filelenght, line;
            int amountOfWords = 0, amountOfLine = 0, amountOfCharacter = 0;
            try
            {
                fs = new FileStream(ofd.FileName, FileMode.Open);
                fi = new FileInfo(ofd.FileName);
                sr = new StreamReader(fs);
                filename = ofd.SafeFileName.ToString();
                url = ofd.FileName.ToString();
                filelenght = fi.Length.ToString();
            }
            catch (Exception)
            {
                return;
            }

            do
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    string[] words = line.Split(' ');
                    amountOfWords += words.Length;
                    if (words.Length == 1 && words[0] == "") amountOfWords -= 1;
                    amountOfLine++;
                    amountOfCharacter += line.Length;
                }
            }
            while (line != null);
            amountOfCharacter += amountOfLine;

            txB_NameFile.Text = filename;
            txB_URL.Text = url;
            txB_SizeFile.Text = filelenght;
            txB_WordOfFile.Text = amountOfWords.ToString();
            txB_LineOfFile.Text = amountOfLine.ToString();
            txB_CharacterOfFile.Text = amountOfCharacter.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
