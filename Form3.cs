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

        private void search_Click(object sender, EventArgs e)
        {
            string input = searchbox.Text;
            int inputcharacter = searchbox.TextLength;
            string output = battle.Text;
            int outputcharacter = battle.TextLength;

            int cursor = battle.SelectionStart;
            if(cursor != outputcharacter)
            {
                cursor += 1;
            }

            if (output.IndexOf(input, cursor) >= 0)
            {
                battle.Focus();
                battle.Select(output.IndexOf(input, cursor), inputcharacter);
                battle.ScrollToCaret();
            }
            else if (output.IndexOf(input, 0, cursor) >= 0)
            {
                battle.Focus();
                battle.Select(output.IndexOf(input, 0, cursor), inputcharacter);
                battle.ScrollToCaret();
            }
            else if (output.IndexOf(input) >= 0) 
            {
                battle.Focus();
                battle.Select(output.IndexOf(input), inputcharacter);
                battle.ScrollToCaret();
            }
            else
            {
                string a = "\"" + input + "\"" + "(을)를 찾을 수 없습니다.";
                MessageBox.Show(a, "오류");
            }
            //string linetext = battle.Lines[0];
            //linetext.IndexOf(input);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void battle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
