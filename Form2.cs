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
    public partial class SubForm1 : Form
    {
        MainForm mf;
        
        public SubForm1(MainForm main)
        {
            InitializeComponent();
            mf = main;
            this.equip1check.Checked = false;
            this.equip1check.Checked = true;
            this.equip2check.Checked = false;
            this.equip2check.Checked = true;
            this.equip3check.Checked = false;
            this.equip3check.Checked = true;
            this.equip4check.Checked = false;
            this.equip4check.Checked = true;
            this.equip5check.Checked = false;
            this.equip5check.Checked = true;
            this.equip6check.Checked = false;
            this.equip6check.Checked = true;
            this.uniqcheck.Checked = false;
            this.uniqcheck.Checked = true;
        }

        private void SubForm1_Load(object sender, EventArgs e)
        {
            if (MainForm._index < 15)
            {
                //초기 정보
                {
                    this.character.Text = MainForm.select_defence[MainForm._index];
                    this.Star.Text = Convert.ToString(Level_variable.star[MainForm._index]);
                    this.Level.Text = Convert.ToString(Level_variable.Lv[MainForm._index]);
                    this.Rank.Text = Convert.ToString(Level_variable.Rank[MainForm._index]);

                    Equipment Eq = new Equipment();
                    Unit_equip Ue = new Unit_equip();
                    Unique_equipment Unieq = new Unique_equipment();
                    double[] array1;
                    string eq1, eq2, eq3, eq4, eq5, eq6;
                    string string1 = "";

                    FieldInfo dummy1 = Ue.GetType().GetField(string.Format("{0}_{1:D2}", MainForm.select_defence_eng[MainForm._index], Level_variable.Rank[MainForm._index]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    array1 = (double[])dummy1.GetValue(Ue);
                    FieldInfo dummy_1 = Eq.GetType().GetField(string.Format("E{0}_name", array1[0]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq1 = (string)dummy_1.GetValue(Eq);
                    FieldInfo dummy_2 = Eq.GetType().GetField(string.Format("E{0}_name", array1[1]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq2 = (string)dummy_2.GetValue(Eq);
                    FieldInfo dummy_3 = Eq.GetType().GetField(string.Format("E{0}_name", array1[2]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq3 = (string)dummy_3.GetValue(Eq);
                    FieldInfo dummy_4 = Eq.GetType().GetField(string.Format("E{0}_name", array1[3]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq4 = (string)dummy_4.GetValue(Eq);
                    FieldInfo dummy_5 = Eq.GetType().GetField(string.Format("E{0}_name", array1[4]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq5 = (string)dummy_5.GetValue(Eq);
                    FieldInfo dummy_6 = Eq.GetType().GetField(string.Format("E{0}_name", array1[5]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq6 = (string)dummy_6.GetValue(Eq);

                    this.equip1.Text = eq1;
                    this.equip2.Text = eq2;
                    this.equip3.Text = eq3;
                    this.equip4.Text = eq4;
                    this.equip5.Text = eq5;
                    this.equip6.Text = eq6;

                    this.equip1check.Checked = Level_variable.equip1[MainForm._index];
                    this.equip2check.Checked = Level_variable.equip2[MainForm._index];
                    this.equip3check.Checked = Level_variable.equip3[MainForm._index];
                    this.equip4check.Checked = Level_variable.equip4[MainForm._index];
                    this.equip5check.Checked = Level_variable.equip5[MainForm._index];
                    this.equip6check.Checked = Level_variable.equip6[MainForm._index];

                    {
                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 5;
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 5;
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 5;
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 5;
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 5;
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 5;
                        }
                    }
                    this.rf1.Value = Convert.ToDecimal(Level_variable.rf1[MainForm._index]);
                    this.rf2.Value = Convert.ToDecimal(Level_variable.rf2[MainForm._index]);
                    this.rf3.Value = Convert.ToDecimal(Level_variable.rf3[MainForm._index]);
                    this.rf4.Value = Convert.ToDecimal(Level_variable.rf4[MainForm._index]);
                    this.rf5.Value = Convert.ToDecimal(Level_variable.rf5[MainForm._index]);
                    this.rf6.Value = Convert.ToDecimal(Level_variable.rf6[MainForm._index]);

                    FieldInfo? uniq_dummy = Unieq.GetType().GetField(string.Format("{0}_name", MainForm.select_defence_eng[MainForm._index]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    if (uniq_dummy != null)
                    {
                        string1 = (string)uniq_dummy.GetValue(Unieq);
                        this.uniqequip.Text = string1;
                        this.uniqcheck.Checked = Level_variable.equip[MainForm._index];
                        this.uniqlevel.Text = Convert.ToString(Level_variable.UE_Lv[MainForm._index]);
                    }
                    else
                    {
                        this.uniqequip.Text = "없음";
                        this.uniqcheck.Checked = false;
                        this.uniqcheck.Enabled = false;
                        this.uniqlevel.Text = "1";
                    }
                }

                //초기 스탯
                {
                    this.HP.Text = String.Format("{0}", Stat_variable.HP[MainForm._index]);
                    this.PA.Text = String.Format("{0}", Stat_variable.PA[MainForm._index]);
                    this.MA.Text = String.Format("{0}", Stat_variable.MA[MainForm._index]);
                    this.PD.Text = String.Format("{0}", Stat_variable.PD[MainForm._index]);
                    this.MD.Text = String.Format("{0}", Stat_variable.MD[MainForm._index]);
                    this.PC.Text = String.Format("{0}", Stat_variable.PC[MainForm._index]);
                    this.MC.Text = String.Format("{0}", Stat_variable.MC[MainForm._index]);
                    this.Dodge.Text = String.Format("{0}", Stat_variable.Dodge[MainForm._index]);
                    this.Acc.Text = String.Format("{0}", Stat_variable.acc[MainForm._index]);
                    this.HPauto.Text = String.Format("{0}", Stat_variable.HPauto[MainForm._index]);
                    this.TPauto.Text = String.Format("{0}", Stat_variable.TPauto[MainForm._index]);
                    this.HPabs.Text = String.Format("{0}", Stat_variable.HPabs[MainForm._index]);
                    this.HPup.Text = String.Format("{0}", Stat_variable.HPup[MainForm._index]);
                    this.TPup.Text = String.Format("{0}", Stat_variable.TPup[MainForm._index]);
                    this.TPdec.Text = String.Format("{0}", Stat_variable.TPdec[MainForm._index]);
                    this.Power.Text = String.Format("{0:F2}", Level_variable.power[MainForm._index]);
                }
            }
            else
            {
                //초기 정보
                {
                    this.character.Text = MainForm.select_offence[MainForm._index - 15];
                    this.Star.Text = Convert.ToString(Level_variable.star[MainForm._index]);
                    this.Level.Text = Convert.ToString(Level_variable.Lv[MainForm._index]);
                    this.Rank.Text = Convert.ToString(Level_variable.Rank[MainForm._index]);

                    Equipment Eq = new Equipment();
                    Unit_equip Ue = new Unit_equip();
                    Unique_equipment Unieq = new Unique_equipment();
                    double[] array1;
                    string eq1, eq2, eq3, eq4, eq5, eq6;
                    string string1 = "";

                    FieldInfo dummy1 = Ue.GetType().GetField(string.Format("{0}_{1:D2}", MainForm.select_offence_eng[MainForm._index - 15], Level_variable.Rank[MainForm._index]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    array1 = (double[])dummy1.GetValue(Ue);
                    FieldInfo dummy_1 = Eq.GetType().GetField(string.Format("E{0}_name", array1[0]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq1 = (string)dummy_1.GetValue(Eq);
                    FieldInfo dummy_2 = Eq.GetType().GetField(string.Format("E{0}_name", array1[1]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq2 = (string)dummy_2.GetValue(Eq);
                    FieldInfo dummy_3 = Eq.GetType().GetField(string.Format("E{0}_name", array1[2]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq3 = (string)dummy_3.GetValue(Eq);
                    FieldInfo dummy_4 = Eq.GetType().GetField(string.Format("E{0}_name", array1[3]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq4 = (string)dummy_4.GetValue(Eq);
                    FieldInfo dummy_5 = Eq.GetType().GetField(string.Format("E{0}_name", array1[4]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq5 = (string)dummy_5.GetValue(Eq);
                    FieldInfo dummy_6 = Eq.GetType().GetField(string.Format("E{0}_name", array1[5]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq6 = (string)dummy_6.GetValue(Eq);

                    this.equip1.Text = eq1;
                    this.equip2.Text = eq2;
                    this.equip3.Text = eq3;
                    this.equip4.Text = eq4;
                    this.equip5.Text = eq5;
                    this.equip6.Text = eq6;

                    this.equip1check.Checked = Level_variable.equip1[MainForm._index];
                    this.equip2check.Checked = Level_variable.equip2[MainForm._index];
                    this.equip3check.Checked = Level_variable.equip3[MainForm._index];
                    this.equip4check.Checked = Level_variable.equip4[MainForm._index];
                    this.equip5check.Checked = Level_variable.equip5[MainForm._index];
                    this.equip6check.Checked = Level_variable.equip6[MainForm._index];

                    {
                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 5;
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 5;
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 5;
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 5;
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 5;
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 0;
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 1;
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 3;
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 5;
                        }
                    }
                    this.rf1.Value = Convert.ToDecimal(Level_variable.rf1[MainForm._index]);
                    this.rf2.Value = Convert.ToDecimal(Level_variable.rf2[MainForm._index]);
                    this.rf3.Value = Convert.ToDecimal(Level_variable.rf3[MainForm._index]);
                    this.rf4.Value = Convert.ToDecimal(Level_variable.rf4[MainForm._index]);
                    this.rf5.Value = Convert.ToDecimal(Level_variable.rf5[MainForm._index]);
                    this.rf6.Value = Convert.ToDecimal(Level_variable.rf6[MainForm._index]);

                    FieldInfo? uniq_dummy = Unieq.GetType().GetField(string.Format("{0}_name", MainForm.select_offence_eng[MainForm._index - 15]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    if (uniq_dummy != null)
                    {
                        string1 = (string)uniq_dummy.GetValue(Unieq);
                        this.uniqequip.Text = string1;
                        this.uniqcheck.Checked = Level_variable.equip[MainForm._index];
                        this.uniqlevel.Text = Convert.ToString(Level_variable.UE_Lv[MainForm._index]);
                    }
                    else
                    {
                        this.uniqequip.Text = "없음";
                        this.uniqcheck.Checked = false;
                        this.uniqcheck.Enabled = false;
                        this.uniqlevel.Text = "1";
                    }
                }

                //초기 스탯
                {
                    this.HP.Text = String.Format("{0}", Stat_variable.HP[MainForm._index]);
                    this.PA.Text = String.Format("{0}", Stat_variable.PA[MainForm._index]);
                    this.MA.Text = String.Format("{0}", Stat_variable.MA[MainForm._index]);
                    this.PD.Text = String.Format("{0}", Stat_variable.PD[MainForm._index]);
                    this.MD.Text = String.Format("{0}", Stat_variable.MD[MainForm._index]);
                    this.PC.Text = String.Format("{0}", Stat_variable.PC[MainForm._index]);
                    this.MC.Text = String.Format("{0}", Stat_variable.MC[MainForm._index]);
                    this.Dodge.Text = String.Format("{0}", Stat_variable.Dodge[MainForm._index]);
                    this.Acc.Text = String.Format("{0}", Stat_variable.acc[MainForm._index]);
                    this.HPauto.Text = String.Format("{0}", Stat_variable.HPauto[MainForm._index]);
                    this.TPauto.Text = String.Format("{0}", Stat_variable.TPauto[MainForm._index]);
                    this.HPabs.Text = String.Format("{0}", Stat_variable.HPabs[MainForm._index]);
                    this.HPup.Text = String.Format("{0}", Stat_variable.HPup[MainForm._index]);
                    this.TPup.Text = String.Format("{0}", Stat_variable.TPup[MainForm._index]);
                    this.TPdec.Text = String.Format("{0}", Stat_variable.TPdec[MainForm._index]);
                    this.Power.Text = String.Format("{0:F2}", Level_variable.power[MainForm._index]);
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (MainForm._index < 15)
            {
                //변경점 적용
                {
                    if (MainForm.select_defence[MainForm._index] == "리노" || MainForm.select_defence[MainForm._index] == "페코린느" || MainForm.select_defence[MainForm._index] == "콧코로" ||
                        MainForm.select_defence[MainForm._index] == "캬루" || MainForm.select_defence[MainForm._index] == "리마" || MainForm.select_defence[MainForm._index] == "이오" ||
                        MainForm.select_defence[MainForm._index] == "유카리" || MainForm.select_defence[MainForm._index] == "마호" || MainForm.select_defence[MainForm._index] == "히요리" ||
                        MainForm.select_defence[MainForm._index] == "유이" || MainForm.select_defence[MainForm._index] == "레이")//
                    {
                        try
                        {
                            if (Convert.ToInt32(this.Star.Text) >= 1 && Convert.ToInt32(this.Star.Text) <= 6)
                            {
                                Level_variable.star[MainForm._index] = Convert.ToInt32(this.Star.Text);
                            }
                            else
                            {
                                MessageBox.Show("성급에 1과 6 사이의 숫자를 입력해주세요", "범위 오류");
                                this.Star.Text = Convert.ToString(Level_variable.star[MainForm._index]);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("성급에 숫자를 입력해주세요", "숫자 오류");
                            this.Star.Text = Convert.ToString(Level_variable.star[MainForm._index]);
                        }
                    }
                    else
                    {
                        try
                        {
                            if (Convert.ToInt32(this.Star.Text) >= 1 && Convert.ToInt32(this.Star.Text) <= 5)
                            {
                                Level_variable.star[MainForm._index] = Convert.ToInt32(this.Star.Text);
                            }
                            else
                            {
                                MessageBox.Show("성급에 1과 5 사이의 숫자를 입력해주세요", "범위 오류");
                                this.Star.Text = Convert.ToString(Level_variable.star[MainForm._index]);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("성급에 숫자를 입력해주세요", "숫자 오류");
                            this.Star.Text = Convert.ToString(Level_variable.star[MainForm._index]);
                        }
                    }
                    
                    try
                    {
                        if (Convert.ToInt32(this.Level.Text) >= 1 && Convert.ToInt32(this.Level.Text) <= 157)
                        {
                            Level_variable.Lv[MainForm._index] = Convert.ToInt32(this.Level.Text);
                        }
                        else
                        {
                            MessageBox.Show("레벨에 1과 157 사이의 숫자를 입력해주세요", "범위 오류");
                            this.Level.Text = Convert.ToString(Level_variable.Lv[MainForm._index]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("레벨에 숫자를 입력해주세요", "숫자 오류");
                        this.Level.Text = Convert.ToString(Level_variable.Lv[MainForm._index]);
                    }

                    try
                    {
                        if (Convert.ToInt32(this.Rank.Text) >= 1 && Convert.ToInt32(this.Rank.Text) <= 16)
                        {
                            Level_variable.Rank[MainForm._index] = Convert.ToInt32(this.Rank.Text);
                        }
                        else
                        {
                            MessageBox.Show("랭크에 1과 16 사이의 숫자를 입력해주세요", "범위 오류");
                            this.Rank.Text = Convert.ToString(Level_variable.Rank[MainForm._index]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("랭크에 숫자를 입력해주세요", "숫자 오류");
                        this.Rank.Text = Convert.ToString(Level_variable.Rank[MainForm._index]);
                    }

                    Level_variable.equip1[MainForm._index] = this.equip1check.Checked;
                    Level_variable.equip2[MainForm._index] = this.equip2check.Checked;
                    Level_variable.equip3[MainForm._index] = this.equip3check.Checked;
                    Level_variable.equip4[MainForm._index] = this.equip4check.Checked;
                    Level_variable.equip5[MainForm._index] = this.equip5check.Checked;
                    Level_variable.equip6[MainForm._index] = this.equip6check.Checked;

                    Level_variable.rf1[MainForm._index] = Convert.ToInt32(this.rf1.Value);
                    Level_variable.rf2[MainForm._index] = Convert.ToInt32(this.rf2.Value);
                    Level_variable.rf3[MainForm._index] = Convert.ToInt32(this.rf3.Value);
                    Level_variable.rf4[MainForm._index] = Convert.ToInt32(this.rf4.Value);
                    Level_variable.rf5[MainForm._index] = Convert.ToInt32(this.rf5.Value);
                    Level_variable.rf6[MainForm._index] = Convert.ToInt32(this.rf6.Value);

                    Level_variable.equip[MainForm._index] = this.uniqcheck.Checked;
                    try
                    {
                        if (Convert.ToInt32(this.uniqlevel.Text) >= 1 && Convert.ToInt32(this.uniqlevel.Text) <= 160)
                        {
                            Level_variable.UE_Lv[MainForm._index] = Convert.ToInt32(this.uniqlevel.Text);
                        }
                        else
                        {
                            MessageBox.Show("전용장비 레벨에 1과 160 사이의 숫자를 입력해주세요", "범위 오류");
                            this.uniqlevel.Text = Convert.ToString(Level_variable.UE_Lv[MainForm._index]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("랭크에 숫자를 입력해주세요", "숫자 오류");
                        this.uniqlevel.Text = Convert.ToString(Level_variable.UE_Lv[MainForm._index]);
                    }
                }

                //스탯 변수 변경
                {
                    MainForm.status_cal(MainForm.select_defence_eng[MainForm._index], Level_variable.star[MainForm._index], Level_variable.Lv[MainForm._index], Level_variable.Rank[MainForm._index], MainForm._index);
                    MainForm.status_equip(MainForm.select_defence_eng[MainForm._index], Level_variable.Rank[MainForm._index], Level_variable.equip1[MainForm._index], Level_variable.equip2[MainForm._index], Level_variable.equip3[MainForm._index], Level_variable.equip4[MainForm._index], Level_variable.equip5[MainForm._index], Level_variable.equip6[MainForm._index], Level_variable.rf1[MainForm._index], Level_variable.rf2[MainForm._index], Level_variable.rf3[MainForm._index], Level_variable.rf4[MainForm._index], Level_variable.rf5[MainForm._index], Level_variable.rf6[MainForm._index], MainForm._index);
                    MainForm.status_unique_equip(MainForm.select_defence_eng[MainForm._index], ref Level_variable.equip[MainForm._index], Level_variable.UE_Lv[MainForm._index], MainForm._index);
                    MainForm.status_destiny(MainForm.select_defence_eng[MainForm._index], MainForm._index);


                    Level_variable.power[MainForm._index] = Stat_variable.HP[MainForm._index] * 0.1 + Stat_variable.PA[MainForm._index] * 1 + Stat_variable.MA[MainForm._index] * 1 + Stat_variable.PD[MainForm._index] * 4.5 + Stat_variable.MD[MainForm._index] * 4.5 + Stat_variable.PC[MainForm._index] * 0.5 +
                        Stat_variable.MC[MainForm._index] * 0.5 + Stat_variable.HPauto[MainForm._index] * 0.1 + Stat_variable.TPauto[MainForm._index] * 0.3 + Stat_variable.Dodge[MainForm._index] * 6 + Stat_variable.HPabs[MainForm._index] * 4.5 + Stat_variable.HPup[MainForm._index] * 1 +
                        Stat_variable.TPup[MainForm._index] * 1.5 + Stat_variable.TPdec[MainForm._index] * 3 + Stat_variable.acc[MainForm._index] * 2;

                    Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10;

                    if (Level_variable.equip[MainForm._index] == true)
                    {
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1.2 * 10 + 100;
                    }
                    else
                    {
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10;
                    }

                    if (Level_variable.star[MainForm._index] >= 6)
                    {
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1.5 * 10 + 2000;
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10 + 150;
                    }
                    else if (Level_variable.star[MainForm._index] >= 5)
                    {
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10;
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10 + 150;
                    }
                    else
                    {
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10;
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10;
                    }
                }

                //스탯 레이블 변경
                {
                    this.HP.Text = String.Format("{0}", Stat_variable.HP[MainForm._index]);
                    this.PA.Text = String.Format("{0}", Stat_variable.PA[MainForm._index]);
                    this.MA.Text = String.Format("{0}", Stat_variable.MA[MainForm._index]);
                    this.PD.Text = String.Format("{0}", Stat_variable.PD[MainForm._index]);
                    this.MD.Text = String.Format("{0}", Stat_variable.MD[MainForm._index]);
                    this.PC.Text = String.Format("{0}", Stat_variable.PC[MainForm._index]);
                    this.MC.Text = String.Format("{0}", Stat_variable.MC[MainForm._index]);
                    this.Dodge.Text = String.Format("{0}", Stat_variable.Dodge[MainForm._index]);
                    this.Acc.Text = String.Format("{0}", Stat_variable.acc[MainForm._index]);
                    this.HPauto.Text = String.Format("{0}", Stat_variable.HPauto[MainForm._index]);
                    this.TPauto.Text = String.Format("{0}", Stat_variable.TPauto[MainForm._index]);
                    this.HPabs.Text = String.Format("{0}", Stat_variable.HPabs[MainForm._index]);
                    this.HPup.Text = String.Format("{0}", Stat_variable.HPup[MainForm._index]);
                    this.TPup.Text = String.Format("{0}", Stat_variable.TPup[MainForm._index]);
                    this.TPdec.Text = String.Format("{0}", Stat_variable.TPdec[MainForm._index]);
                    this.Power.Text = String.Format("{0:F2}", Level_variable.power[MainForm._index]);
                }

                //장비 레이블 변경
                {
                    Equipment Eq = new Equipment();
                    Unit_equip Ue = new Unit_equip();
                    double[] array1;
                    string eq1, eq2, eq3, eq4, eq5, eq6;

                    FieldInfo dummy1 = Ue.GetType().GetField(string.Format("{0}_{1:D2}", MainForm.select_defence_eng[MainForm._index], Level_variable.Rank[MainForm._index]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    array1 = (double[])dummy1.GetValue(Ue);
                    FieldInfo dummy_1 = Eq.GetType().GetField(string.Format("E{0}_name", array1[0]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq1 = (string)dummy_1.GetValue(Eq);
                    FieldInfo dummy_2 = Eq.GetType().GetField(string.Format("E{0}_name", array1[1]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq2 = (string)dummy_2.GetValue(Eq);
                    FieldInfo dummy_3 = Eq.GetType().GetField(string.Format("E{0}_name", array1[2]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq3 = (string)dummy_3.GetValue(Eq);
                    FieldInfo dummy_4 = Eq.GetType().GetField(string.Format("E{0}_name", array1[3]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq4 = (string)dummy_4.GetValue(Eq);
                    FieldInfo dummy_5 = Eq.GetType().GetField(string.Format("E{0}_name", array1[4]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq5 = (string)dummy_5.GetValue(Eq);
                    FieldInfo dummy_6 = Eq.GetType().GetField(string.Format("E{0}_name", array1[5]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq6 = (string)dummy_6.GetValue(Eq);

                    this.equip1.Text = eq1;
                    this.equip2.Text = eq2;
                    this.equip3.Text = eq3;
                    this.equip4.Text = eq4;
                    this.equip5.Text = eq5;
                    this.equip6.Text = eq6;

                    {
                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 0;
                            if (this.rf1.Maximum < this.rf1.Value)
                            {
                                this.rf1.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 1;
                            if (this.rf1.Maximum < this.rf1.Value)
                            {
                                this.rf1.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 3;
                            if (this.rf1.Maximum < this.rf1.Value)
                            {
                                this.rf1.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 5;
                            if (this.rf1.Maximum < this.rf1.Value)
                            {
                                this.rf1.Value = 5;
                            }
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 0;
                            if (this.rf2.Maximum < this.rf2.Value)
                            {
                                this.rf2.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 1;
                            if (this.rf2.Maximum < this.rf2.Value)
                            {
                                this.rf2.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 3;
                            if (this.rf2.Maximum < this.rf2.Value)
                            {
                                this.rf2.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 5;
                            if (this.rf2.Maximum < this.rf2.Value)
                            {
                                this.rf2.Value = 5;
                            }
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 0;
                            if (this.rf3.Maximum < this.rf3.Value)
                            {
                                this.rf3.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 1;
                            if (this.rf3.Maximum < this.rf3.Value)
                            {
                                this.rf3.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 3;
                            if (this.rf3.Maximum < this.rf3.Value)
                            {
                                this.rf3.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 5;
                            if (this.rf3.Maximum < this.rf3.Value)
                            {
                                this.rf3.Value = 5;
                            }
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 0;
                            if (this.rf4.Maximum < this.rf4.Value)
                            {
                                this.rf4.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 1;
                            if (this.rf4.Maximum < this.rf4.Value)
                            {
                                this.rf4.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 3;
                            if (this.rf4.Maximum < this.rf4.Value)
                            {
                                this.rf4.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 5;
                            if (this.rf4.Maximum < this.rf4.Value)
                            {
                                this.rf4.Value = 5;
                            }
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 0;
                            if (this.rf5.Maximum < this.rf5.Value)
                            {
                                this.rf5.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 1;
                            if (this.rf5.Maximum < this.rf5.Value)
                            {
                                this.rf5.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 3;
                            if (this.rf5.Maximum < this.rf5.Value)
                            {
                                this.rf5.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 5;
                            if (this.rf5.Maximum < this.rf5.Value)
                            {
                                this.rf5.Value = 5;
                            }
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 0;
                            if (this.rf6.Maximum < this.rf6.Value)
                            {
                                this.rf6.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 1;
                            if (this.rf6.Maximum < this.rf6.Value)
                            {
                                this.rf6.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 3;
                            if (this.rf6.Maximum < this.rf6.Value)
                            {
                                this.rf6.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 5;
                            if (this.rf6.Maximum < this.rf6.Value)
                            {
                                this.rf6.Value = 5;
                            }
                        }
                    }
                }

                //Mainform 리스트뷰 변경
                {
                    int i = 4 - MainForm._index;

                    mf.defchar.Items[i].SubItems[2].Text = MainForm.select_defence[MainForm._index];
                    mf.defchar.Items[i].SubItems[3].Text = string.Format("{0}", Level_variable.Lv[MainForm._index]);
                    mf.defchar.Items[i].SubItems[4].Text = string.Format("{0}", Level_variable.star[MainForm._index]);
                    mf.defchar.Items[i].SubItems[5].Text = string.Format("{0}", Level_variable.Rank[MainForm._index]);
                    mf.defchar.Items[i].SubItems[6].Text = string.Format("{0:F2}", Level_variable.power[MainForm._index]);

                    double power_sum_def = Level_variable.power[0] + Level_variable.power[1] + Level_variable.power[2] + Level_variable.power[3] + Level_variable.power[4];
                    mf.defpower.Text = string.Format("{0:F2}", power_sum_def);
                }
            }
            else
            {
                //변경점 적용
                {
                    if (MainForm.select_offence[MainForm._index - 15] == "리노" || MainForm.select_offence[MainForm._index - 15] == "페코린느" || MainForm.select_offence[MainForm._index - 15] == "콧코로" || 
                        MainForm.select_offence[MainForm._index - 15] == "캬루" || MainForm.select_offence[MainForm._index - 15] == "리마" || MainForm.select_offence[MainForm._index - 15] == "이오" || 
                        MainForm.select_offence[MainForm._index - 15] == "유카리" || MainForm.select_offence[MainForm._index - 15] == "마호" || MainForm.select_offence[MainForm._index - 15] == "히요리" ||
                        MainForm.select_offence[MainForm._index - 15] == "유이" || MainForm.select_offence[MainForm._index - 15] == "레이")//
                    {
                        try
                        {
                            if (Convert.ToInt32(this.Star.Text) >= 1 && Convert.ToInt32(this.Star.Text) <= 6)
                            {
                                Level_variable.star[MainForm._index] = Convert.ToInt32(this.Star.Text);
                            }
                            else
                            {
                                MessageBox.Show("성급에 1과 6 사이의 숫자를 입력해주세요", "범위 오류");
                                this.Star.Text = Convert.ToString(Level_variable.star[MainForm._index]);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("성급에 숫자를 입력해주세요", "숫자 오류");
                            this.Star.Text = Convert.ToString(Level_variable.star[MainForm._index]);
                        }
                    }
                    else
                    {
                        try
                        {
                            if (Convert.ToInt32(this.Star.Text) >= 1 && Convert.ToInt32(this.Star.Text) <= 5)
                            {
                                Level_variable.star[MainForm._index] = Convert.ToInt32(this.Star.Text);
                            }
                            else
                            {
                                MessageBox.Show("성급에 1과 5 사이의 숫자를 입력해주세요", "범위 오류");
                                this.Star.Text = Convert.ToString(Level_variable.star[MainForm._index]);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("성급에 숫자를 입력해주세요", "숫자 오류");
                            this.Star.Text = Convert.ToString(Level_variable.star[MainForm._index]);
                        }
                    }

                    try
                    {
                        if (Convert.ToInt32(this.Level.Text) >= 1 && Convert.ToInt32(this.Level.Text) <= 157)
                        {
                            Level_variable.Lv[MainForm._index] = Convert.ToInt32(this.Level.Text);
                        }
                        else
                        {
                            MessageBox.Show("레벨에 1과 157 사이의 숫자를 입력해주세요", "범위 오류");
                            this.Level.Text = Convert.ToString(Level_variable.Lv[MainForm._index]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("레벨에 숫자를 입력해주세요", "숫자 오류");
                        this.Level.Text = Convert.ToString(Level_variable.Lv[MainForm._index]);
                    }

                    try
                    {
                        if (Convert.ToInt32(this.Rank.Text) >= 1 && Convert.ToInt32(this.Rank.Text) <= 16)
                        {
                            Level_variable.Rank[MainForm._index] = Convert.ToInt32(this.Rank.Text);
                        }
                        else
                        {
                            MessageBox.Show("랭크에 1과 16 사이의 숫자를 입력해주세요", "범위 오류");
                            this.Rank.Text = Convert.ToString(Level_variable.Rank[MainForm._index]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("랭크에 숫자를 입력해주세요", "숫자 오류");
                        this.Rank.Text = Convert.ToString(Level_variable.Rank[MainForm._index]);
                    }

                    Level_variable.equip1[MainForm._index] = this.equip1check.Checked;
                    Level_variable.equip2[MainForm._index] = this.equip2check.Checked;
                    Level_variable.equip3[MainForm._index] = this.equip3check.Checked;
                    Level_variable.equip4[MainForm._index] = this.equip4check.Checked;
                    Level_variable.equip5[MainForm._index] = this.equip5check.Checked;
                    Level_variable.equip6[MainForm._index] = this.equip6check.Checked;

                    Level_variable.rf1[MainForm._index] = Convert.ToInt32(this.rf1.Value);
                    Level_variable.rf2[MainForm._index] = Convert.ToInt32(this.rf2.Value);
                    Level_variable.rf3[MainForm._index] = Convert.ToInt32(this.rf3.Value);
                    Level_variable.rf4[MainForm._index] = Convert.ToInt32(this.rf4.Value);
                    Level_variable.rf5[MainForm._index] = Convert.ToInt32(this.rf5.Value);
                    Level_variable.rf6[MainForm._index] = Convert.ToInt32(this.rf6.Value);

                    Level_variable.equip[MainForm._index] = this.uniqcheck.Checked;
                    try
                    {
                        if (Convert.ToInt32(this.uniqlevel.Text) >= 1 && Convert.ToInt32(this.uniqlevel.Text) <= 160)
                        {
                            Level_variable.UE_Lv[MainForm._index] = Convert.ToInt32(this.uniqlevel.Text);
                        }
                        else
                        {
                            MessageBox.Show("전용장비 레벨에 1과 160 사이의 숫자를 입력해주세요", "범위 오류");
                            this.uniqlevel.Text = Convert.ToString(Level_variable.UE_Lv[MainForm._index]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("랭크에 숫자를 입력해주세요", "숫자 오류");
                        this.uniqlevel.Text = Convert.ToString(Level_variable.UE_Lv[MainForm._index]);
                    }
                }

                //스탯 변수 변경
                {
                    MainForm.status_cal(MainForm.select_offence_eng[MainForm._index - 15], Level_variable.star[MainForm._index], Level_variable.Lv[MainForm._index], Level_variable.Rank[MainForm._index], MainForm._index);
                    MainForm.status_equip(MainForm.select_offence_eng[MainForm._index - 15], Level_variable.Rank[MainForm._index], Level_variable.equip1[MainForm._index], Level_variable.equip2[MainForm._index], Level_variable.equip3[MainForm._index], Level_variable.equip4[MainForm._index], Level_variable.equip5[MainForm._index], Level_variable.equip6[MainForm._index], Level_variable.rf1[MainForm._index], Level_variable.rf2[MainForm._index], Level_variable.rf3[MainForm._index], Level_variable.rf4[MainForm._index], Level_variable.rf5[MainForm._index], Level_variable.rf6[MainForm._index], MainForm._index);
                    MainForm.status_unique_equip(MainForm.select_offence_eng[MainForm._index - 15], ref Level_variable.equip[MainForm._index], Level_variable.UE_Lv[MainForm._index], MainForm._index);
                    MainForm.status_destiny(MainForm.select_offence_eng[MainForm._index - 15], MainForm._index);


                    Level_variable.power[MainForm._index] = Stat_variable.HP[MainForm._index] * 0.1 + Stat_variable.PA[MainForm._index] * 1 + Stat_variable.MA[MainForm._index] * 1 + Stat_variable.PD[MainForm._index] * 4.5 + Stat_variable.MD[MainForm._index] * 4.5 + Stat_variable.PC[MainForm._index] * 0.5 +
                        Stat_variable.MC[MainForm._index] * 0.5 + Stat_variable.HPauto[MainForm._index] * 0.1 + Stat_variable.TPauto[MainForm._index] * 0.3 + Stat_variable.Dodge[MainForm._index] * 6 + Stat_variable.HPabs[MainForm._index] * 4.5 + Stat_variable.HPup[MainForm._index] * 1 +
                        Stat_variable.TPup[MainForm._index] * 1.5 + Stat_variable.TPdec[MainForm._index] * 3 + Stat_variable.acc[MainForm._index] * 2;

                    Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10;

                    if (Level_variable.equip[MainForm._index] == true)
                    {
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1.2 * 10 + 100;
                    }
                    else
                    {
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10;
                    }

                    if (Level_variable.star[MainForm._index] >= 6)
                    {
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1.5 * 10 + 2000;
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10 + 150;
                    }
                    else if (Level_variable.star[MainForm._index] >= 5)
                    {
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10;
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10 + 150;
                    }
                    else
                    {
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10;
                        Level_variable.power[MainForm._index] += Level_variable.Lv[MainForm._index] * 1 * 10;
                    }
                }

                //스탯 레이블 변경
                {
                    this.HP.Text = String.Format("{0}", Stat_variable.HP[MainForm._index]);
                    this.PA.Text = String.Format("{0}", Stat_variable.PA[MainForm._index]);
                    this.MA.Text = String.Format("{0}", Stat_variable.MA[MainForm._index]);
                    this.PD.Text = String.Format("{0}", Stat_variable.PD[MainForm._index]);
                    this.MD.Text = String.Format("{0}", Stat_variable.MD[MainForm._index]);
                    this.PC.Text = String.Format("{0}", Stat_variable.PC[MainForm._index]);
                    this.MC.Text = String.Format("{0}", Stat_variable.MC[MainForm._index]);
                    this.Dodge.Text = String.Format("{0}", Stat_variable.Dodge[MainForm._index]);
                    this.Acc.Text = String.Format("{0}", Stat_variable.acc[MainForm._index]);
                    this.HPauto.Text = String.Format("{0}", Stat_variable.HPauto[MainForm._index]);
                    this.TPauto.Text = String.Format("{0}", Stat_variable.TPauto[MainForm._index]);
                    this.HPabs.Text = String.Format("{0}", Stat_variable.HPabs[MainForm._index]);
                    this.HPup.Text = String.Format("{0}", Stat_variable.HPup[MainForm._index]);
                    this.TPup.Text = String.Format("{0}", Stat_variable.TPup[MainForm._index]);
                    this.TPdec.Text = String.Format("{0}", Stat_variable.TPdec[MainForm._index]);
                    this.Power.Text = String.Format("{0:F2}", Level_variable.power[MainForm._index]);
                }

                //장비 레이블 변경
                {
                    Equipment Eq = new Equipment();
                    Unit_equip Ue = new Unit_equip();
                    double[] array1;
                    string eq1, eq2, eq3, eq4, eq5, eq6;

                    FieldInfo dummy1 = Ue.GetType().GetField(string.Format("{0}_{1:D2}", MainForm.select_offence_eng[MainForm._index - 15], Level_variable.Rank[MainForm._index]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    array1 = (double[])dummy1.GetValue(Ue);
                    FieldInfo dummy_1 = Eq.GetType().GetField(string.Format("E{0}_name", array1[0]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq1 = (string)dummy_1.GetValue(Eq);
                    FieldInfo dummy_2 = Eq.GetType().GetField(string.Format("E{0}_name", array1[1]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq2 = (string)dummy_2.GetValue(Eq);
                    FieldInfo dummy_3 = Eq.GetType().GetField(string.Format("E{0}_name", array1[2]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq3 = (string)dummy_3.GetValue(Eq);
                    FieldInfo dummy_4 = Eq.GetType().GetField(string.Format("E{0}_name", array1[3]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq4 = (string)dummy_4.GetValue(Eq);
                    FieldInfo dummy_5 = Eq.GetType().GetField(string.Format("E{0}_name", array1[4]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq5 = (string)dummy_5.GetValue(Eq);
                    FieldInfo dummy_6 = Eq.GetType().GetField(string.Format("E{0}_name", array1[5]), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    eq6 = (string)dummy_6.GetValue(Eq);

                    this.equip1.Text = eq1;
                    this.equip2.Text = eq2;
                    this.equip3.Text = eq3;
                    this.equip4.Text = eq4;
                    this.equip5.Text = eq5;
                    this.equip6.Text = eq6;

                    {
                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 0;
                            if (this.rf1.Maximum < this.rf1.Value)
                            {
                                this.rf1.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 1;
                            if (this.rf1.Maximum < this.rf1.Value)
                            {
                                this.rf1.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 3;
                            if (this.rf1.Maximum < this.rf1.Value)
                            {
                                this.rf1.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[0]))) == true)
                        {
                            this.rf1.Maximum = 5;
                            if (this.rf1.Maximum < this.rf1.Value)
                            {
                                this.rf1.Value = 5;
                            }
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 0;
                            if (this.rf2.Maximum < this.rf2.Value)
                            {
                                this.rf2.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 1;
                            if (this.rf2.Maximum < this.rf2.Value)
                            {
                                this.rf2.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 3;
                            if (this.rf2.Maximum < this.rf2.Value)
                            {
                                this.rf2.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[1]))) == true)
                        {
                            this.rf2.Maximum = 5;
                            if (this.rf2.Maximum < this.rf2.Value)
                            {
                                this.rf2.Value = 5;
                            }
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 0;
                            if (this.rf3.Maximum < this.rf3.Value)
                            {
                                this.rf3.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 1;
                            if (this.rf3.Maximum < this.rf3.Value)
                            {
                                this.rf3.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 3;
                            if (this.rf3.Maximum < this.rf3.Value)
                            {
                                this.rf3.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[2]))) == true)
                        {
                            this.rf3.Maximum = 5;
                            if (this.rf3.Maximum < this.rf3.Value)
                            {
                                this.rf3.Value = 5;
                            }
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 0;
                            if (this.rf4.Maximum < this.rf4.Value)
                            {
                                this.rf4.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 1;
                            if (this.rf4.Maximum < this.rf4.Value)
                            {
                                this.rf4.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 3;
                            if (this.rf4.Maximum < this.rf4.Value)
                            {
                                this.rf4.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[3]))) == true)
                        {
                            this.rf4.Maximum = 5;
                            if (this.rf4.Maximum < this.rf4.Value)
                            {
                                this.rf4.Value = 5;
                            }
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 0;
                            if (this.rf5.Maximum < this.rf5.Value)
                            {
                                this.rf5.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 1;
                            if (this.rf5.Maximum < this.rf5.Value)
                            {
                                this.rf5.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 3;
                            if (this.rf5.Maximum < this.rf5.Value)
                            {
                                this.rf5.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[4]))) == true)
                        {
                            this.rf5.Maximum = 5;
                            if (this.rf5.Maximum < this.rf5.Value)
                            {
                                this.rf5.Value = 5;
                            }
                        }

                        if (Array.Exists(Eq.reinforce_0, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 0;
                            if (this.rf6.Maximum < this.rf6.Value)
                            {
                                this.rf6.Value = 0;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_1, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 1;
                            if (this.rf6.Maximum < this.rf6.Value)
                            {
                                this.rf6.Value = 1;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_3, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 3;
                            if (this.rf6.Maximum < this.rf6.Value)
                            {
                                this.rf6.Value = 3;
                            }
                        }
                        else if (Array.Exists(Eq.reinforce_5, i => i.Equals(string.Format("E{0}", array1[5]))) == true)
                        {
                            this.rf6.Maximum = 5;
                            if (this.rf6.Maximum < this.rf6.Value)
                            {
                                this.rf6.Value = 5;
                            }
                        }
                    }
                }

                //Mainform 리스트뷰 변경
                {
                    int i = 19 - MainForm._index;

                    mf.offchar.Items[i].SubItems[2].Text = MainForm.select_offence[MainForm._index - 15];
                    mf.offchar.Items[i].SubItems[3].Text = string.Format("{0}", Level_variable.Lv[MainForm._index]);
                    mf.offchar.Items[i].SubItems[4].Text = string.Format("{0}", Level_variable.star[MainForm._index]);
                    mf.offchar.Items[i].SubItems[5].Text = string.Format("{0}", Level_variable.Rank[MainForm._index]);
                    mf.offchar.Items[i].SubItems[6].Text = string.Format("{0:F2}", Level_variable.power[MainForm._index]);

                    double power_sum_off = Level_variable.power[15] + Level_variable.power[16] + Level_variable.power[17] + Level_variable.power[18] + Level_variable.power[19];
                    mf.offpower.Text = string.Format("{0:F2}", power_sum_off);
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void number_only(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        
        private void equip1check_CheckedChanged(object sender, EventArgs e)
        {
            if(this.equip1check.Checked == true)
            {
                this.rf1.Enabled = true;
            }
            else
            {
                this.rf1.Enabled = false;
            }
        }

        private void equip2check_CheckedChanged(object sender, EventArgs e)
        {
            if (this.equip2check.Checked == true)
            {
                this.rf2.Enabled = true;
            }
            else
            {
                this.rf2.Enabled = false;
            }
        }

        private void equip3check_CheckedChanged(object sender, EventArgs e)
        {
            if (this.equip3check.Checked == true)
            {
                this.rf3.Enabled = true;
            }
            else
            {
                this.rf3.Enabled = false;
            }
        }

        private void equip4check_CheckedChanged(object sender, EventArgs e)
        {
            if (this.equip4check.Checked == true)
            {
                this.rf4.Enabled = true;
            }
            else
            {
                this.rf4.Enabled = false;
            }
        }

        private void equip5check_CheckedChanged(object sender, EventArgs e)
        {
            if (this.equip5check.Checked == true)
            {
                this.rf5.Enabled = true;
            }
            else
            {
                this.rf5.Enabled = false;
            }
        }

        private void equip6check_CheckedChanged(object sender, EventArgs e)
        {
            if (this.equip6check.Checked == true)
            {
                this.rf6.Enabled = true;
            }
            else
            {
                this.rf6.Enabled = false;
            }
        }

        private void uniqcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (this.uniqcheck.Checked == true)
            {
                this.uniqlevel.Enabled = true;
            }
            else
            {
                this.uniqlevel.Enabled = false;
            }
        }
    }
}
