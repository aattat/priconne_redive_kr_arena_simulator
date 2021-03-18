using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class SubForm2 : Form
    {
        public SubForm2()
        {
            InitializeComponent();
        }

        private void SubForm2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("temp.txt");
            int line = 1;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                if (line > 1)
                {
                    battle.AppendText(s + Environment.NewLine);
                }
                else
                {
                    string[] temp = s.Split(',');        // Split() 메서드를 이용하여 ',' 구분하여 잘라냄
                    a1.Text = temp[0];
                    a2.Text = temp[1];
                    a3.Text = temp[2];
                    a4.Text = temp[3];
                    a5.Text = temp[4];
                    b1.Text = temp[5];
                    b2.Text = temp[6];
                    b3.Text = temp[7];
                    b4.Text = temp[8];
                    b5.Text = temp[9];
                }

                line += 1;
            }
            sr.Close();
        }
    }
}
