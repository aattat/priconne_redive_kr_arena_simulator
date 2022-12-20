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
    public partial class SubForm3 : Form
    {
        MainForm mf;
        int ct;
        bool def;
        string inp;

        public SubForm3(MainForm main, int counter, bool defence, string inputsname)
        {
            InitializeComponent();
            mf = main;
            ct = counter;
            def = defence;
            inp = inputsname;
        }

        private void SubForm3_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button1;

            if(def == true)
            {
                switch (ct)
                {
                    case 2:
                        this.label1.Text = "입력하신 약어, \"" + inp + "\"는\r\n\r\n" +
                            "\" " + MainForm.select_defence_temp[MainForm.select_count_temp - ct] + " \", " + "\" " + MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] + " \"\r\n\r\n" +
                            "중 어느 것입니까?";
                        this.button1.Text = MainForm.select_defence_temp[MainForm.select_count_temp - ct];
                        this.button2.Text = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1];
                        break;
                    case 3:
                        this.label1.Text = "입력하신 약어, \"" + inp + "\"는\r\n\r\n" +
                            "\" " + MainForm.select_defence_temp[MainForm.select_count_temp - ct] + " \", " + "\" " + MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] + " \", " + "\" " + MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2] + " \"\r\n\r\n" +
                            "중 어느 것입니까?";
                        this.button1.Text = MainForm.select_defence_temp[MainForm.select_count_temp - ct];
                        this.button2.Text = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1];
                        this.button3.Text = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2];
                        break;
                    case 4:
                        this.label1.Text = "입력하신 약어, \"" + inp + "\"는\r\n\r\n" +
                            "\" " + MainForm.select_defence_temp[MainForm.select_count_temp - ct] + " \", " + "\" " + MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] + " \", " + "\" " + MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2] + " \", " + "\" " + MainForm.select_defence_temp[MainForm.select_count_temp - ct + 3] + " \"\r\n\r\n" +
                            "중 어느 것입니까?";
                        this.button1.Text = MainForm.select_defence_temp[MainForm.select_count_temp - ct];
                        this.button2.Text = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1];
                        this.button3.Text = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2];
                        this.button4.Text = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 3];
                        break;
                }
            }
            else
            {
                switch (ct)
                {
                    case 2:
                        this.label1.Text = "입력하신 약어, \"" + inp + "\"는\r\n\r\n" +
                            "\" " + MainForm.select_offence_temp[MainForm.select_count2_temp - ct] + " \", " + "\" " + MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] + " \"\r\n\r\n" +
                            "중 어느 것입니까?";
                        this.button1.Text = MainForm.select_offence_temp[MainForm.select_count2_temp - ct];
                        this.button2.Text = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1];
                        break;
                    case 3:
                        this.label1.Text = "입력하신 약어, \"" + inp + "\"는\r\n\r\n" +
                            "\" " + MainForm.select_offence_temp[MainForm.select_count2_temp - ct] + " \", " + "\" " + MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] + " \", " + "\" " + MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2] + " \"\r\n\r\n" +
                            "중 어느 것입니까?";
                        this.button1.Text = MainForm.select_offence_temp[MainForm.select_count2_temp - ct];
                        this.button2.Text = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1];
                        this.button3.Text = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2];
                        break;
                    case 4:
                        this.label1.Text = "입력하신 약어, \"" + inp + "\"는\r\n\r\n" +
                            "\" " + MainForm.select_offence_temp[MainForm.select_count2_temp - ct] + " \", " + "\" " + MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] + " \", " + "\" " + MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2] + " \", " + "\" " + MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 3] + " \"\r\n\r\n" +
                            "중 어느 것입니까?";
                        this.button1.Text = MainForm.select_offence_temp[MainForm.select_count2_temp - ct];
                        this.button2.Text = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1];
                        this.button3.Text = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2];
                        this.button4.Text = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 3];
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (def == true)
            {
                switch (ct)
                {
                    case 2:
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_count_temp -= 1;
                        break;
                    case 3:
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_count_temp -= 2;
                        break;
                    case 4:
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 3] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 3] = "";
                        MainForm.select_count_temp -= 3;
                        break;
                }
            }
            else
            {
                switch (ct)
                {
                    case 2:
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_count2_temp -= 1;
                        break;
                    case 3:
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_count2_temp -= 2;
                        break;
                    case 4:
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 3] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 3] = "";
                        MainForm.select_count2_temp -= 3;
                        break;
                }
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (def == true)
            {
                switch (ct)
                {
                    case 2:
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct] = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1];
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct] = MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1];
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_count_temp -= 1;
                        break;
                    case 3:
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct] = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1];
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct] = MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1];
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_count_temp -= 2;
                        break;
                    case 4:
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct] = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1];
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct] = MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1];
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 3] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 3] = "";
                        MainForm.select_count_temp -= 3;
                        break;
                }
            }
            else
            {
                switch (ct)
                {
                    case 2:
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1];
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1];
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_count2_temp -= 1;
                        break;
                    case 3:
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1];
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1];
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_count2_temp -= 2;
                        break;
                    case 4:
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1];
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1];
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 3] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 3] = "";
                        MainForm.select_count2_temp -= 3;
                        break;
                }
            }

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (def == true)
            {
                switch (ct)
                {
                    case 2:
                        break;
                    case 3:
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct] = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2];
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct] = MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 2];
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_count_temp -= 2;
                        
                        this.Close();
                        break;
                    case 4:
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct] = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2];
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct] = MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 2];
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 3] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 3] = "";
                        MainForm.select_count_temp -= 3;

                        this.Close();
                        break;
                }
            }
            else
            {
                switch (ct)
                {
                    case 2:
                        break;
                    case 3:
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2];
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 2];
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_count2_temp -= 2;

                        this.Close();
                        break;
                    case 4:
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2];
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 2];
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 3] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 3] = "";
                        MainForm.select_count2_temp -= 3;

                        this.Close();
                        break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (def == true)
            {
                switch (ct)
                {
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct] = MainForm.select_defence_temp[MainForm.select_count_temp - ct + 3];
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct] = MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 3];
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 1] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 2] = "";
                        MainForm.select_defence_temp[MainForm.select_count_temp - ct + 3] = "";
                        MainForm.select_defence_temp_eng[MainForm.select_count_temp - ct + 3] = "";
                        MainForm.select_count_temp -= 3;

                        this.Close();
                        break;
                }
            }
            else
            {
                switch (ct)
                {
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 3];
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct] = MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 3];
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 1] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 2] = "";
                        MainForm.select_offence_temp[MainForm.select_count2_temp - ct + 3] = "";
                        MainForm.select_offence_temp_eng[MainForm.select_count2_temp - ct + 3] = "";
                        MainForm.select_count2_temp -= 3;

                        this.Close();
                        break;
                }
            }
        }
    }
}
