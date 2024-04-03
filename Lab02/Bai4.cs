using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab02
{
    public partial class Bai4 : Form
    {
        List<SV> lsv = new List<SV>();
        List<int> pages = new List<int>();
        public Bai4()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (CheckProperty() == true)
            {
                SV student = new SV();
                student.name = text_Name.Text;
                student.id = Convert.ToInt32(text_ID.Text);
                student.phone = text_Phone.Text;
                student.course1 = Convert.ToSingle(text_Course1.Text);
                student.course2 = Convert.ToSingle(text_Course2.Text);
                student.course3 = Convert.ToSingle(text_Course3.Text);
                student.avg = (student.course1 + student.course2 + student.course3) / 3;
                student.avg = (float)Math.Round(student.avg, 2);
                text_Output.Text += student.name + "\r\n"
                                  + student.id + "\r\n"
                                  + student.phone + "\r\n"
                                  + student.course1 + "\r\n"
                                  + student.course2 + "\r\n"
                                  + student.course3 + "\r\n"
                                  + "\r\n";
                lsv.Add(student);
                pages.Add(pages.Count + 1);
                FileStream fs = new FileStream("E:\\GitHub\\GitRepo\\22521289-VuBaTai\\Lab02\\input4.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter wr = new StreamWriter(fs);
                string[] strings = text_Output.Text.Split('\n');
                for (int i = 0; i < strings.Length; i++)
                {
                    wr.WriteLine(strings[i]);
                }
                wr.Close();
            }
            else
            {
                MessageBox.Show("Invalid Input.", "Notice");
                text_Name.Text = "";
                text_ID.Text = "";
                text_Phone.Text = "";
                text_Course1.Text = "";
                text_Course2.Text = "";
                text_Course3.Text = "";
            }
        }

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("E:\\GitHub\\GitRepo\\22521289-VuBaTai\\Lab02\\input4.txt", FileMode.Open, FileAccess.Read);
            }
            catch (Exception)
            {
                return;
            }
            StreamReader rd = new StreamReader(fs);
            text_Output.Text = rd.ReadToEnd();
            string[] strings = text_Output.Text.Split('\n');
            int id, countpagenumber = 1;
            float c1, c2, c3;
            for (int i = 0; i < strings.Length; i += 7)
            {
                try
                {
                    if (i + 5 >= strings.Length) throw new IndexOutOfRangeException();
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Invalid Input!", "Error");
                    return;
                }
                SV sv = new SV();
                sv.name = strings[i];
                //Kt ngoai le nhap k phai so!!//     
                if (Int32.TryParse(strings[i + 1], out id)) sv.id = id;
                sv.phone = strings[i + 2];
                if (float.TryParse(strings[i + 3], out c1)) sv.course1 = c1;
                if (float.TryParse(strings[i + 4], out c2)) sv.course2 = c2;
                if (float.TryParse(strings[i + 5], out c3)) sv.course3 = c3;
                sv.avg = (c1 + c2 + c3) / 3;
                lsv.Add(sv);
                pages.Add(countpagenumber);
                countpagenumber++;
            }
            textO_Name.Text = lsv[0].name;
            textO_ID.Text = lsv[0].id.ToString();
            textO_Phone.Text = lsv[0].phone;
            textO_Course1.Text = lsv[0].course1.ToString();
            textO_Course2.Text = lsv[0].course2.ToString();
            textO_Course3.Text = lsv[0].course3.ToString();
            textO_Avg.Text = ((lsv[0].course1 + lsv[0].course2 + lsv[0].course3) / 3).ToString();
            rd.Close();
        }

        private void btn_WriteFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("E:\\GitHub\\GitRepo\\22521289-VuBaTai\\Lab02\\output4.txt", FileMode.CreateNew, FileAccess.Write);
            StreamWriter wr = new StreamWriter(fs);
            for (int i = 0; i < lsv.Count(); i++)
            {
                wr.WriteLine(lsv[i].name);
                wr.WriteLine(lsv[i].id);
                wr.WriteLine(lsv[i].phone);
                wr.WriteLine(lsv[i].course1);
                wr.WriteLine(lsv[i].course2);
                wr.WriteLine(lsv[i].course3);
                wr.WriteLine(lsv[i].avg);
                wr.WriteLine();
            }
            wr.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if(pages.Count() == Int32.Parse(lb_Page.Text))
            {
                lb_Page.Text = "1";
                textO_Name.Text = lsv[0].name;
                textO_ID.Text = lsv[0].id.ToString();
                textO_Phone.Text = lsv[0].phone;
                textO_Course1.Text = lsv[0].course1.ToString();
                textO_Course2.Text = lsv[0].course2.ToString();
                textO_Course3.Text = lsv[0].course3.ToString();
                textO_Avg.Text = lsv[0].avg.ToString();
            }
            else
            {
                int page = Int32.Parse(lb_Page.Text) + 1;
                lb_Page.Text = page.ToString();
                textO_Name.Text = lsv[page - 1].name;
                textO_ID.Text = lsv[page - 1].id.ToString();
                textO_Phone.Text = lsv[page - 1].phone;
                textO_Course1.Text = lsv[page - 1].course1.ToString();
                textO_Course2.Text = lsv[page - 1].course2.ToString();
                textO_Course3.Text = lsv[page - 1].course3.ToString();
                textO_Avg.Text = lsv[page - 1].avg.ToString();
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lb_Page.Text) == 1)
            {
                lb_Page.Text = (pages.Count).ToString();
                textO_Name.Text = lsv[pages.Count - 1].name;
                textO_ID.Text = lsv[pages.Count - 1].id.ToString();
                textO_Phone.Text = lsv[pages.Count - 1].phone;
                textO_Course1.Text = lsv[pages.Count - 1].course1.ToString();
                textO_Course2.Text = lsv[pages.Count - 1].course2.ToString();
                textO_Course3.Text = lsv[pages.Count - 1].course3.ToString();
                textO_Avg.Text = lsv[pages.Count - 1].avg.ToString();
            }
            else
            {
                int page = Int32.Parse(lb_Page.Text) - 1;
                lb_Page.Text = page.ToString();
                textO_Name.Text = lsv[page - 1].name;
                textO_ID.Text = lsv[page - 1].id.ToString();
                textO_Phone.Text = lsv[page - 1].phone;
                textO_Course1.Text = lsv[page - 1].course1.ToString();
                textO_Course2.Text = lsv[page - 1].course2.ToString();
                textO_Course3.Text = lsv[page - 1].course3.ToString();
                textO_Avg.Text = lsv[page - 1].avg.ToString();
            }
        }
        bool CheckProperty()
        {
            if ((Convert.ToInt32(text_ID.Text) < 10000000) || (Convert.ToInt64(text_ID.Text) > 99999999))
            {
                return false;
            }
            else if ((Convert.ToSingle(text_Course1.Text) < 0) || (Convert.ToSingle(text_Course1.Text) > 10))
            {
                return false;
            }
            else if ((Convert.ToSingle(text_Course2.Text) < 0) || (Convert.ToSingle(text_Course2.Text) > 10))
            {
                return false;
            }
            else if ((Convert.ToSingle(text_Course3.Text) < 0) || (Convert.ToSingle(text_Course3.Text) > 10))
            {
                return false;
            }
            else if ((text_Phone.Text.Length != 10) || (text_Phone.Text[0] != '0'))
            {
                char a = text_Phone.Text[0];
                return false;
            }
            else
            {
                return true;
            }
        }

        class SV
        {
            public string name { get; set; }
            public int id { get; set; }
            public string phone { get; set; }
            public float course1 { get; set; }
            public float course2 { get; set; }
            public float course3 { get; set; }
            public float avg { get; set; }
        }

        
    }
}
