using Microsoft.JScript;
using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows;

namespace Everyone_With_Math.Class
{
    public partial class Math_01 : Window
    {
        //1�w�N�̖����`����N���X
        SRTTbacon_Anser Answer = new SRTTbacon_Anser();
        string Question_Word;
        bool IsImageUse;
        bool Question_01_01_Answer;
        bool Question_01_02_Answer;
        bool Question_01_03_Answer;
        bool Question_01_04_Answer;
        bool Question_01_05_Answer;
        bool Question_01_06_Answer;
        bool Question_01_07_Answer;
        bool Question_01_08_Answer;
        bool Question_01_09_Answer;
        bool Question_01_10_Answer;
        bool Question_01_11_Answer;
        bool Question_01_12_Answer;
        bool Question_01_13_Answer;
        bool Question_01_14_Answer;
        bool Question_01_15_Answer;
        bool Question_01_16_Answer;
        bool Question_01_17_Answer;
        bool Question_01_18_Answer;
        bool Question_01_19_Answer;
        bool Question_01_20_Answer;
        bool Question_01_21_Answer;
        bool Question_01_22_Answer;
        bool Question_01_23_Answer;
        bool Question_01_24_Answer;
        bool Question_01_25_Answer;
        bool Question_01_26_Answer;
        bool Question_01_27_Answer;
        bool Question_01_28_Answer;
        bool Question_01_29_Answer;
        bool Question_01_30_Answer;
        string Definition_Word;
        string Button_Answer_Word_01;
        string Button_Answer_Word_02;
        string Button_Answer_Word_03;
        string Button_Answer_Word_04;
        //1��S�������Aexe�t�@�C�����畜���������߃R�[�h���킩��ɂ����Ȃ��Ă���(Question_Number_09�܂�)
        void Question_Grade_01_Number_01()
        {
            Random random = new Random();
            int num = random.Next(-19823, 20000);
            string str = "";
            if (num >= 0)
            {
                if (num == 0)
                {
                    Question_Grade_01_Number_01();
                    return;
                }
                if (num > 0)
                {
                    int num1 = random.Next(-19823, 20000);
                    Question_Word = string.Concat(new object[] { num1, " - ", num, " =  ��" });
                    Definition_Word = string.Concat(new object[] { num1, " - (", num, ")" });
                    str = string.Concat(new object[] { num1, " + (", num, ")" });
                }
            }
            else
            {
                int num2 = random.Next(-19823, 20000);
                Question_Word = string.Concat(new object[] { num2, " - (", num, ") =  ��" });
                Definition_Word = string.Concat(new object[] { num2, " - (", num, ")" });
                str = string.Concat(new object[] { num2, " + (", num, ")" });
            }
            string str1 = Answer.Eval(Definition_Word).ToString();
            int num3 = -(int)Answer.Eval(Definition_Word);
            string str2 = num3.ToString();
            string str3 = Answer.Eval(str).ToString();
            num3 = -(int)Answer.Eval(str);
            Answer_Question(str1, str2, str3, num3.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_02()
        {
            Random random = new Random();
            int num = random.Next(-39, 39);
            if (num >= 0)
            {
                if (num == 0)
                {
                    Question_Grade_01_Number_02();
                    return;
                }
                int num1 = random.Next(-39, 39);
                Question_Word = string.Concat(new object[] { num1, " x ", num, " =  ��" });
                Definition_Word = string.Concat(new object[] { num1, " * (", num, ")" });
            }
            else
            {
                int num2 = random.Next(-39, 39);
                Question_Word = string.Concat(new object[] { num2, " x (", num, ") =  ��" });
                Definition_Word = string.Concat(new object[] { num2, " * (", num, ")" });
            }
            string str = Answer.Eval(Definition_Word).ToString();
            int num3 = -(int)Answer.Eval(Definition_Word);
            string str1 = num3.ToString();
            num3 = (int)Answer.Eval(Definition_Word) + num;
            string str2 = num3.ToString();
            num3 = -(int)Answer.Eval(Definition_Word) - num;
            Answer_Question(str, str1, str2, num3.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_03()
        {
            int num = new Random().Next(10, 100);
            string str = "";
            Question_Word = string.Concat(num, "���t���ɂ���");
            Definition_Word = string.Concat("1/", num);
            str = num.ToString();
            str = string.Concat(new string[] { str });
            string definitionWord = Definition_Word;
            string str1 = string.Concat("-", Definition_Word);
            int num1 = -int.Parse(str);
            Answer_Question(definitionWord, str1, str, num1.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_04()
        {
            double num = 0;
            string str = "";
            int num1 = new Random().Next(-20, 20);
            int num2 = new Random().Next(1, 6);
            if (num2 == 1)
            {
                Question_Word = "72 �� (-3) = ��";
                Definition_Word = "-24";
                num = -24;
            }
            if (num2 == 2)
            {
                Question_Word = "125 �� (-5) = ��";
                Definition_Word = "-25";
                num = -25;
            }
            if (num2 == 3)
            {
                Question_Word = "504 �� (-8) = ��";
                Definition_Word = "-63";
                num = -63;
            }
            if (num2 == 4)
            {
                Question_Word = "1170 �� 18 = ��";
                Definition_Word = "65";
                num = 65;
            }
            if (num2 == 5)
            {
                Question_Word = "-194 �� 5 = ��";
                Definition_Word = "-194/5";
                num = -194/5;
            }
            num += num1;
            str = !Definition_Word.Contains("-") ? string.Concat("-", Definition_Word) : Definition_Word.Replace("-", "");
            double num3 = -num;
            Answer_Question(Definition_Word, str, num.ToString(), num3.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_05()
        {
            int num = new Random().Next(1, 6);
            string str = "";
            string str1 = "";
            if (num == 1)
            {
                Question_Word = "194 �� 8 = ��";
                Definition_Word = "97/4";
                str1 = "194/8";
            }
            if (num == 2)
            {
                Question_Word = "-357 �� 9 = ��";
                Definition_Word = "-119/3";
                str1 = "357/9";
            }
            if (num == 3)
            {
                Question_Word = "-164 �� 6 = ��";
                Definition_Word = "82/3";
                str1 = "164/6";
            }
            if (num == 4)
            {
                Question_Word = "12 �� 28 = ��";
                Definition_Word = "3/7";
                str1 = "6/14";
            }
            if (num == 5)
            {
                Question_Word = "16 �� 64 = ��";
                Definition_Word = "1/4";
                str1 = "4";
            }
            str = !Definition_Word.Contains("-") ? string.Concat("-", Definition_Word) : Definition_Word.Replace("-", "");
            Answer_Question(Definition_Word, str, str1, string.Concat("-", str1));
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_06()
        {
            Random random = new Random();
            int num = random.Next(-1000, 1000);
            int num1 = random.Next(-1000, 1000);
            string str = "";
            if (num1 >= 0)
            {
                if ((num == 0 ? true : num1 == 0))
                {
                    Question_Grade_01_Number_06();
                    return;
                }
                if (num1 > 0)
                {
                    Question_Word = string.Concat(new object[] { num, "x + ", num1, "x = ��" });
                }
            }
            else
            {
                Question_Word = string.Concat(new object[] { num, "x + (", num1, "x ) = ��" });
            }
            str = string.Concat(new object[] { num, "-(", num1, ")" });
            Definition_Word = string.Concat(num, "+", num1);
            string str1 = string.Concat(Answer.Eval(Definition_Word).ToString(), "x");
            int num2 = -(int)Answer.Eval(Definition_Word);
            string str2 = string.Concat(num2.ToString(), "x");
            string str3 = string.Concat(Answer.Eval(str).ToString(), "x");
            num2 = -(int)Answer.Eval(str);
            Answer_Question(str1, str2, str3, string.Concat(num2.ToString(), "x"));
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_07()
        {
            Random random = new Random();
            int num = random.Next(-50, 50);
            int num1 = random.Next(-50, 50);
            string str = "";
            if (num1 >= 0)
            {
                if (num == 0 ? true : num1 == 0)
                {
                    Question_Grade_01_Number_06();
                    return;
                }
                if (num1 > 0)
                {
                    Question_Word = string.Concat(new object[] { num, "x X ", num1, "x = ��" });
                }
            }
            else
            {
                Question_Word = string.Concat(new object[] { num, "x X (", num1, "x ) = ��" });
            }
            str = string.Concat(new object[] { num, "-(", num1, ")" });
            Definition_Word = string.Concat(num, "*", num1);
            string str1 = string.Concat(Answer.Eval(Definition_Word).ToString(), "x^2");
            int num2 = -(int)Answer.Eval(Definition_Word);
            string str2 = string.Concat(num2.ToString(), "x");
            string str3 = string.Concat(Answer.Eval(str).ToString(), "x^2");
            num2 = -(int)Answer.Eval(str);
            Answer_Question(str1, str2, str3, string.Concat(num2.ToString(), "x"));
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_08()
        {
            int num = new Random().Next(1, 6);
            string str = "";
            string str1 = "";
            if (num == 1)
            {
                Question_Word = "1428x^2 �� 8x = ��";
                Definition_Word = "357x/2";
                str1 = "179";
            }
            if (num == 2)
            {
                Question_Word = "-983 �� 9 = ��";
                Definition_Word = "-983/9";
                str1 = "328";
            }
            if (num == 3)
            {
                Question_Word = "-164 �� 6 = ��";
                Definition_Word = "-82/3";
                str1 = "164/6";
            }
            if (num == 4)
            {
                Question_Word = "12x �� 28x^2 = ��";
                Definition_Word = "3/7x";
                str1 = "3x/7";
            }
            if (num == 5)
            {
                Question_Word = "16x^5 �� 64x^2 = ��";
                Definition_Word = "1x^3/4";
                str1 = "4x^3";
            }
            str = !Definition_Word.Contains("-") ? string.Concat("-", Definition_Word) : Definition_Word.Replace("-", "");
            Answer_Question(Definition_Word, str, str1, string.Concat("-", str1));
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_09()
        {
            string str = "";
            string str1 = "";
            string str2 = "";
            int num = new Random().Next(1, 6);
            if (num == 1)
            {
                Definition_Word = "8��cm^2, 14�� + 4cm";
                str = "16��cm^2, 4�� + 4cm";
                str1 = "8��cm^2, 8��cm";
                str2 = "16��cm^2, 8��cm";
                Math_Image_Source = string.Concat(Path, "/Resources/BG/Math/Grade_01/Number_09_01.png");
            }
            if (num == 2)
            {
                Definition_Word = "12��cm^2, 4�� + 12cm";
                str = "12��cm^2, 12��cm";
                str1 = "36��cm^2, 4�� + 12cm";
                str2 = "36��cm^2, 12��cm";
                Math_Image_Source = string.Concat(Path, "/Resources/BG/Math/Grade_01/Number_09_02.png");
            }
            if (num == 3)
            {
                Definition_Word = "8��cm^2, 4�� + 8cm";
                str = "16��cm^2, 4�� + 8cm";
                str1 = "8��cm^2, 8��cm";
                str2 = "16��cm^2, 8��cm";
                Math_Image_Source = string.Concat(Path, "/Resources/BG/Math/Grade_01/Number_09_03.png");
            }
            if (num == 4)
            {
                Definition_Word = "5��cm^2, 2�� + 10cm";
                str = "5��cm^2, 2��cm";
                str1 = "25��cm^2, 2�� + 10cm";
                str2 = "25��cm^2, 2��cm";
                Math_Image_Source = string.Concat(Path, "/Resources/BG/Math/Grade_01/Number_09_04.png");
            }
            if (num == 5)
            {
                Definition_Word = "72��cm^2, 12�� + 24cm";
                str = "72��cm^2, 12��cm";
                str1 = "144��cm^2, 12�� + 24cm";
                str2 = "144��cm^2, 12��cm";
                Math_Image_Source = string.Concat(Path, "/Resources/BG/Math/Grade_01/Number_09_05.png");
            }
            Question_Word = "���̉~�̖ʐςƎ��̒��������߂�";
            Answer_Question(Definition_Word, str, str1, str2);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_10()
        {
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            int num = new Random().Next(1, 6);
            string str = "";
            string str1 = "";
            string str2 = "";
            if (num == 1)
            {
                Question_Word = "�u719��9�Ŋ���Ə���79�ł��܂肪8�v�����ŕ\�킹";
                Definition_Word = "719 = 9 x 79 + 8";
                str = "711 = 9 x 79 + 8";
                str1 = "79 = 719 �� 9";
                str2 = "727 = 9 x 79";
            }
            if (num == 2)
            {
                Question_Word = "�u1981��3�Ŋ���Ə���660�ł��܂肪1�v�����ŕ\�킹";
                Definition_Word = "1981 = 3 x 660 + 1";
                str = "1980 = 3 x 660 + 1";
                str1 = "660 = 1981 �� 3";
                str2 = "1982 = 3 x 660";
            }
            if (num == 3)
            {
                Question_Word = "�u914��5�Ŋ���Ə���182��4����Ȃ��v�����ŕ\�킹";
                Definition_Word = "914 = 5 x 182 - 4";
                str = "918 = 5 x 182 - 4";
                str1 = "182 = 914 �� 5";
                str2 = "910 = 5 x 182";
            }
            if (num == 4)
            {
                Question_Word = "�u285��6�Ŋ���Ə���48��3����Ȃ��v�����ŕ\�킹";
                Definition_Word = "285 = 6 x 48 - 3";
                str = "288 = 6 x 48 - 3";
                str1 = "48 = 285 �� 6";
                str2 = "282 = 6 x 48";
            }
            if (num == 5)
            {
                Question_Word = "�u1779��12�Ŋ���Ə���148�ł��܂肪3�v�����ŕ\�킹";
                Definition_Word = "1779 = 12 x 148 + 3";
                str = "1776 = 148 x 12 + 3";
                str1 = "1779 = 12 x 148 - 3";
                str2 = "1782 = 148 x 12";
            }
            Answer_Question(Definition_Word, str, str1, str2);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_11()
        {
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Question_Word = "4x + 12 = 8x - 24";
                Definition_Word = "x = 9";
                Miss_01 = "x = -9";
                Miss_02 = "x = 3";
                Miss_03 = "x = -3";

            }
            if (r2 == 2)
            {
                Question_Word = "5x - 3 = 3x - 15";
                Definition_Word = "x = -6";
                Miss_01 = "x = 6";
                Miss_02 = "x = 9";
                Miss_03 = "x = -9";
            }
            if (r2 == 3)
            {
                Question_Word = "16x + 7 = 9x + 55";
                Definition_Word = "x = 7";
                Miss_01 = "x = -7";
                Miss_02 = "x = 62/7";
                Miss_03 = "x = -62/7";
            }
            if (r2 == 4)
            {
                Question_Word = "11x + 59 = 3x + 35";
                Definition_Word = "x = -3";
                Miss_01 = "x = 3";
                Miss_02 = "x = 47/4";
                Miss_03 = "x = -47/4";
            }
            if (r2 == 5)
            {
                Question_Word = "46x - 52 = 13x - 316";
                Definition_Word = "x = -8";
                Miss_01 = "x = 8";
                Miss_02 = "x = 368/33";
                Miss_03 = "x = -368/33";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_12()
        {
            Random equation = new Random();
            int equation_rnd = equation.Next(1,6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (equation_rnd == 1)
            {
                Question_Word = "3(2x - 4) = 2x - 8";
                Definition_Word = "x = 1";
                Miss_01 = "x = -5";
                Miss_02 = "x = 5/2";
                Miss_03 = "x = 3/2";
            }
            if (equation_rnd == 2)
            {
                Question_Word = "0.4x + 3 = 0.3x +8";
                Definition_Word = "x = 50";
                Miss_01 = "x = 5";
                Miss_02 = "x = -5";
                Miss_03 = "x = 11/7";
            }
            if (equation_rnd == 3)
            {
                Question_Word = "3x/2 + 5/3 = 2x/3 + 6";
                Definition_Word = "x = 26/5";
                Miss_01 = "x = 2";
                Miss_02 = "x = 46/13";
                Miss_03 = "x = 46/5";
            }
            if (equation_rnd == 4)
            {
                Question_Word = "0.6(4x + 6x) = 0.6x - 3";
                Definition_Word = "x = -5/9";
                Miss_01 = "x = 5/9";
                Miss_02 = "9";
                Miss_03 = "-9";
            }
            if (equation_rnd == 5)
            {
                Question_Word = "2(3x - 5) = 3x + 5";
                Definition_Word = "x = 5";
                Miss_01 = "x = -5";
                Miss_02 = "x = 5/3";
                Miss_03 = "x = -5/3";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_13()
        {
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Question_Word = "4x : 11 = 16 : 4";
                Definition_Word = "x = 11";
                Miss_01 = "x = -11";
                Miss_02 = "11/16";
                Miss_03 = "-11/16";
            }
            if (r2 == 2)
            {
                Question_Word = "4 : 8 = 12 : (12+x)";
                Definition_Word = "x = 12";
                Miss_01 = "x = -12";
                Miss_02 = "12/5";
                Miss_03 = "-12/5";
            }
            if (r2 == 3)
            {
                Question_Word = "2x : 4 = (4x-7) : 9";
                Definition_Word = "x = -14";
                Miss_01 = "x = 14";
                Miss_02 = "3/2";
                Miss_03 = "-3/2";
            }
            if (r2 == 4)
            {
                Question_Word = "8x : 21 = (3x+9) : 8";
                Definition_Word = "x = 189";
                Miss_01 = "x = -189";
                Miss_02 = "21/12";
                Miss_03 = "-21/12";
            }
            if (r2 == 5)
            {
                Question_Word = "4x : (7x-18) = 8 : 9";
                Definition_Word = "x = 36/5";
                Miss_01 = "x = -36/5";
                Miss_02 = "162/31";
                Miss_03 = "-162/31";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_14()
        {
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            if (r2 == 1)
            {
                Question_Word = "����w�Z�̍Z�ɂ̒���120�l�̐��k�����܂��B\n���q���k�͒j�q���k����8�l�����ꍇ�̒j�q���k�̐l�������߂�";
                Definition_Word = "�j�q���k 56�l";
                Miss_01 = "�j�q���k 64�l";
                Miss_02 = "�j�q���k 61�l";
                Miss_03 = "�j�q���k 58�l";
            }
            if (r2 == 2)
            {
                Question_Word = City_Random() + "�ɏZ�ނ�����N�͋߂��̓X�ɕ��[��𔃂��ɍs���܂��B���M1��x�~�őS����7�����A���v��350�~�ł����B���M1�͂�����H";
                Definition_Word = "x = 50";
                Miss_01 = "x = 5";
                Miss_02 = "x = 350";
                Random r3 = new Random();
                int r3_01 = r3.Next(40, 61);
                if (r3_01 == 50)
                {
                    Miss_03 = "x = 49";
                }
                else
                {
                    Miss_03 = "x = " + r3_01;
                }
            }
            if (r2 == 3)
            {
                Question_Word = "���鐔x��3�{����7���������͂��Ƃ̐����3�������B\n���鐔x�����߂�";
                Definition_Word = "x = 2";
                Miss_01 = "x = 5";
                Miss_02 = "x = 1";
                Miss_03 = "x = 5/2";
            }
            if (r2 == 4)
            {
                Text_01_T.FontSize = 30;
                Text_02_T.FontSize = 30;
                string City_Name = City_Random();
                Question_Word = "��ނ�����" + City_Name + "�֗��s�ɍs�����ƂɂȂ�܂����B������ꏊ����" + City_Name + "�܂ł̓��̂�͖�200km����A����40km�ł��̏ꏊ�֌������܂��B�񉽎��Ԍ�ɓ�������H";
                Definition_Word = "��5���Ԍ�";
                Miss_01 = "��3����30����";
                Miss_02 = "��6���Ԍ�";
                Miss_03 = "���ǂ蒅���Ȃ�";
            }
            if (r2 == 5)
            {
                Question_Word = "�N���X��40�l�̐��k�����܂��B\n���q�͒j�q���6�l���Ȃ��B\n���q�̐l�������߂�";
                Definition_Word = "���q���k 17�l";
                Miss_01 = "���q���k 23�l";
                Miss_02 = "���q���k 34�l";
                Miss_03 = "���q���k 19�l";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_15()
        {
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "x(km)�̓��̂��4���Ԃ����ĕ������Ƃ��̑����͉�km/h��";
                Definition_Word = "x/4 km/h";
                Miss_01 = "4/x km/h";
                Miss_02 = "x/240 km/h";
                Miss_03 = "240/x km/h";
            }
            if (r2 == 2)
            {
                Question_Word = "x(m)�̓��̂���A180(m/��)�Ői�ނƂ��ɂ����鎞�Ԃ͉�����";
                Definition_Word = "x/180��";
                Miss_01 = "180/x��";
                Miss_02 = "x/3��";
                Miss_03 = "3/x��";
            }
            if (r2 == 3)
            {
                Question_Word = "x(km/��)�̑�����5���ԑ������Ƃ��ɐi�񂾓��̂�͉�km��";
                Definition_Word = "5x km";
                Miss_01 = "x/5 km";
                Miss_02 = "5/x km";
                Miss_03 = "0.5x km";
            }
            if (r2 == 4)
            {
                Question_Word = "6���Ԃ͉������\��";
                Definition_Word = "360��";
                Miss_01 = "60��";
                Miss_02 = "120��";
                Miss_03 = "21600�b";
            }
            if (r2 == 5)
            {
                Question_Word = "1����20���͉����ԕ\��";
                Definition_Word = "4/3����";
                Miss_01 = "3/4����";
                Miss_02 = "1����20��";
                Miss_03 = "1/20����";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_16()
        {
            Random rnd = new Random();
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            int r2 = rnd.Next(1,6);
            if (r2 == 1)
            {
                Question_Word = "2000��4��";
                Definition_Word = "800";
                Miss_01 = "80";
                Miss_02 = "500";
                Miss_03 = "200";
            }
            if (r2 == 2)
            {
                Question_Word = "500��10%����";
                Definition_Word = "450";
                Miss_01 = "400";
                Miss_02 = "50";
                Miss_03 = "550";
            }
            if (r2 == 3)
            {
                Question_Word = "x��3������";
                Definition_Word = "13x/10";
                Miss_01 = "400";
                Miss_02 = "50";
                Miss_03 = "550";
            }
            if (r2 == 4)
            {
                Question_Word = "y��3%";
                Definition_Word = "3y/100";
                Miss_01 = "3y";
                Miss_02 = "3/y";
                Miss_03 = "y-3";
            }
            if (r2 == 5)
            {
                Question_Word = "200��v%����";
                Definition_Word = "200-2v";
                Miss_01 = "200/v";
                Miss_02 = "200-v";
                Miss_03 = "200v-2v";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_17()
        {
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Text_01_T.FontSize = 32;
            Text_02_T.FontSize = 32;
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "���̕��͂�y=�̌`�ɂ���\n1�{x�~�̏����S����8�������Ƃ��̑����y�~�ł���";
                Definition_Word = "y = 8x";
                Miss_01 = "y = 1/8x";
                Miss_02 = "x = 8y";
                Miss_03 = "x = 1/8y";
            }
            if (r2 == 2)
            {
                Question_Word = "���̕��͂�y=�̌`�ɂ���\n�P�ӂ̒�����xcm�̐����`�̖ʐς�ycm^2�ł���";
                Definition_Word = "y = x^2";
                Miss_01 = "x = y^2";
                Miss_02 = "y = 2x";
                Miss_03 = "x = 2y";
            }
            if (r2 == 3)
            {
                Question_Word = "����s�������g���ĕ\��\nx��8���傫��13��菬����";
                Definition_Word = "8 < x < 13";
                Miss_01 = "8 �� x �� 13";
                Miss_02 = "8 < x �� 13";
                Miss_03 = "8 �� x < 13";
            }
            if (r2 == 4)
            {
                Question_Word = "����s�������g���ĕ\��\nx��-2��菬����-9����������";
                Definition_Word = "x < -2";
                Miss_01 = "-9 < x < -2";
                Miss_02 = "-9 < -2 < x";
                Miss_03 = "x �� -9 �� -2";
            }
            if (r2 == 5)
            {
                Question_Word = "����s�������g���ĕ\��\nx��y�ȏ�13����\n�܂��Ay��5�ȉ��Ƃ���";
                Definition_Word = "y �� x <13";
                Miss_01 = "x �� y <13";
                Miss_02 = "y �� x �� 13";
                Miss_03 = "y �� 5 �� x";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_18()
        {
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            if (r2 == 1)
            {
                Question_Word = "y=14x�ɂ���\nx=-7�̂Ƃ���y�̒l�����߂�";
                Definition_Word = "y = -98";
                Miss_01 = "y = -2";
                Miss_02 = "y = 98";
                Miss_03 = "y = 2";
            }
            if (r2 == 2)
            {
                Question_Word = "y=13x�ɂ���\ny=338�̂Ƃ���x�̒l�����߂�";
                Definition_Word = "x = 26";
                Miss_01 = "x = 25";
                Miss_02 = "x = 27";
                Miss_03 = "y = 338";
            }
            if (r2 == 3)
            {
                Question_Word = "y��x�ɔ�Ⴕ�Ax=3�̂Ƃ���y=21�ł���B���萔�����߂�";
                Definition_Word = "7";
                Miss_01 = "3";
                Miss_02 = "21";
                Miss_03 = "63";
            }
            if (r2 == 4)
            {
                Question_Word = "y��x�ɔ�Ⴕ�Ax=15�̂Ƃ���y=-5�ł���By��x�̎��ŕ\�킹";
                Definition_Word = "y = -x/3";
                Miss_01 = "y = -3/x";
                Miss_02 = "y = x/3";
                Miss_03 = "y = 3/x";
            }
            if (r2 == 5)
            {
                Question_Word = "y��x�ɔ�Ⴕ�Ax=15�̂Ƃ���y=-15�ł���By��x�̎��ŕ\�킹";
                Definition_Word = "y = -x";
                Miss_01 = "y = x";
                Miss_02 = "y = x/15";
                Miss_03 = "y = -x/15";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }

        void Question_Grade_01_Number_19()
        {
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "y��x�ɔ���Ⴕ�Ax = 3, y = 9�̂Ƃ��B\ny��x�̎��ŕ\��";
                Definition_Word = "y = 27/x";
                Miss_01 = "y = 3x";
                Miss_02 = "y = 3/x";
                Miss_03 = "y = 27x";
            }
            if (r2 == 2)
            {
                Question_Word = "y��x�ɔ���Ⴕ�Ax = 2, y = -5�̂Ƃ��B\ny��x�̎��ŕ\��";
                Definition_Word = "y = -10/x";
                Miss_01 = "y = 10/x";
                Miss_02 = "y = 10x";
                Miss_03 = "y = -10x";
            }
            if (r2 == 3)
            {
                Question_Word = "y��x�ɔ���Ⴕ�Ax = -3, y = -1�̂Ƃ��B\ny��x�̎��ŕ\��";
                Definition_Word = "y = 3/x";
                Miss_01 = "y = 3x";
                Miss_02 = "y = -3x";
                Miss_03 = "y = -3/x";
            }
            if (r2 == 4)
            {
                Question_Word = "y��x�ɔ���Ⴕ�Ax = 4, y = -3�̂Ƃ��B\ny��x�̎��ŕ\��";
                Definition_Word = "y = -12/x";
                Miss_01 = "y = 12x";
                Miss_02 = "y = -12x";
                Miss_03 = "y = 12/x";
            }
            if (r2 == 5)
            {
                Question_Word = "y��x�ɔ���Ⴕ�Ax = 1, y = 7�̂Ƃ��B\ny��x�̎��ŕ\��";
                Definition_Word = "y = 7/x";
                Miss_01 = "y = -7/x";
                Miss_02 = "y = 7x";
                Miss_03 = "y = -7x";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_20()
        {
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "�_A�̍��W�𓚂���";
                Definition_Word = "-9,9";
                Miss_01 = "9,-9";
                Miss_02 = "-9,-9";
                Miss_03 = "9,9";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_20_01.png";
            }
            if (r2 == 2)
            {
                Question_Word = "�_A�̍��W�𓚂���";
                Definition_Word = "4,2";
                Miss_01 = "4,-2";
                Miss_02 = "-4,-2";
                Miss_03 = "-4,2";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_20_02.png";
            }
            if (r2 == 3)
            {
                Question_Word = "�_A�̍��W�𓚂���";
                Definition_Word = "-6,-8";
                Miss_01 = "6,-8";
                Miss_02 = "-6,8";
                Miss_03 = "6,8";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_20_03.png";
            }
            if (r2 == 4)
            {
                Question_Word = "�_A�̍��W�𓚂���";
                Definition_Word = "11,-11";
                Miss_01 = "11,11";
                Miss_02 = "-11,-11";
                Miss_03 = "-11,11";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_20_04.png";
            }
            if (r2 == 5)
            {
                Question_Word = "�_A�̍��W�𓚂���";
                Definition_Word = "6,0";
                Miss_01 = "-6,0";
                Miss_02 = "0,6";
                Miss_03 = "0,-6";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_20_05.png";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_21()
        {
            //���S�p
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                //72��
                Question_Word = "���̉~�̒��S�p�����߂�\n�������摜�͉~��5����1�̃T�C�Y�Ƃ���";
                Definition_Word = "72��";
                Miss_01 = "60��";
                Miss_02 = "70��";
                Miss_03 = "62��";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_21_01.png";
            }
            if (r2 == 2)
            {
                //120��
                Question_Word = "���̉~�̒��S�p�����߂�\n�������摜�͉~��3����1�̃T�C�Y�Ƃ���";
                Definition_Word = "120��";
                Miss_01 = "180��";
                Miss_02 = "140��";
                Miss_03 = "110��";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_21_02.png";
            }
            if (r2 == 3)
            {
                //90��
                Question_Word = "���̉~�̒��S�p�����߂�\n�������摜�͉~��4����1�̃T�C�Y�Ƃ���";
                Definition_Word = "90��";
                Miss_01 = "100��";
                Miss_02 = "180��";
                Miss_03 = "���߂��Ȃ�";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_21_03.png";
            }
            if (r2 == 4)
            {
                //180��
                Question_Word = "���̉~�̒��S�p�����߂�\n�������摜�͉~��2����1�̃T�C�Y�Ƃ���";
                Definition_Word = "180��";
                Miss_01 = "90��";
                Miss_02 = "170��";
                Miss_03 = "190��";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_21_04.png";
            }
            if (r2 == 5)
            {
                //45��
                Question_Word = "���̉~�̒��S�p�����߂�\n�������摜�͉~��8����1�̃T�C�Y�Ƃ���";
                Definition_Word = "45��";
                Miss_01 = "90��";
                Miss_02 = "50��";
                Miss_03 = "40��";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_21_05.png";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_22()
        {
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "��AB�Ƃ˂���̈ʒu�ɂ���ӂ͉���";
                Definition_Word = "4��";
                Miss_01 = "3��";
                Miss_02 = "5��";
                Miss_03 = "�Ȃ�";
            }
            if (r2 == 2)
            {
                Question_Word = "��BC�ɕ��s�ȕӂ͉���";
                Definition_Word = "3��";
                Miss_01 = "2��";
                Miss_02 = "4��";
                Miss_03 = "�Ȃ�";
            }
            if (r2 == 3)
            {
                Question_Word = "��HG�Ɍ����ӂ͉���";
                Definition_Word = "4��";
                Miss_01 = "3��";
                Miss_02 = "5��";
                Miss_03 = "�Ȃ�";
            }
            if (r2 == 4)
            {
                Question_Word = "�摜�̐}�`�͐��l�p�`�ł�\n��AB��8cm�������ꍇ��HG�͉�cm��";
                Definition_Word = "8cm";
                Miss_01 = "12cm";
                Miss_02 = "4cm";
                Miss_03 = "���߂��Ȃ�";
            }
            if (r2 == 5)
            {
                Question_Word = "�摜�̐}�`�͐��l�p�`�ł�\n��BAE�͉��x�����߂�";
                Definition_Word = "90��";
                Miss_01 = "180��";
                Miss_02 = "45��";
                Miss_03 = "���߂��Ȃ�";
            }
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_22_01.png";
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_23()
        {
            //�l�p��
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            Random r = new Random();
            int r2 = r.Next(2, 21);
            int r3 = r.Next(2, 21);
            int r4 = r.Next(2, 21);
            Question_Word = "�l�p���̑̐ς����߂�\n�c" + r2 + "cm,��" + r3 + "cm,����" + r4 + "cm";
            int Answer = r2 * r3 * r4 ;
            Answer_Question(Answer + "cm^3", Answer - 2 + "cm^3", Answer - 4 + "cm^3", Answer + 2 + "cm^3");
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_24()
        {
            //�O�p��
            Random r = new Random();
            int r1 = r.Next(3, 15);
            int r2 = r.Next(3, 15);
            int r3 = r.Next(3, 15);
            Text_01_T.FontSize = 32;
            Text_02_T.FontSize = 32;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_24_01.png";
            Question_Word = "�摜�̎O�p���ɂ��āAa = " + r1 + "cm,b = " + r2 + "cm,c = " + r3 + "cm�̏ꍇ�̑̐ς����߂�\n�܂��A�摜�̌����ڂ͍l�����Ȃ����ƁB";
            int Answer = r2 * r3 / 2 * r1;
            Answer_Question(Answer + "cm^3", Answer - 2 + "cm^3", Answer - 4 + "cm^3", Answer + 2 + "cm^3");
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_25()
        {
            //�~��
            Random r = new Random();
            int r1 = r.Next(3, 10);
            int r2 = r.Next(3, 14);
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Question_Word = "���̏ꍇ�̉摜�̉~���̑̐ς����߂�\n���a" + r1 + "cm,����" + r2 + "cm";
            int Answer = r1 * r1 * r2;
            Answer_Question(Answer + "��cm^3", Answer - 3 + "��cm^3", Answer - 6 + "��cm^3", Answer + 3 + "��cm^3");
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_26()
        {
            //�~���̕\�ʐς̌v�Z
            Random r = new Random();
            int r2 = r.Next(3, 18);
            int r3 = r.Next(3, 18);
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Question_Word = "���a" + r2 + "cm,����" + r3 + "cm�̉~���̕\�ʐς����߂�";
            int Answer = 2 * r2 * r2 + 2 * r2 * r3;
            Definition_Word = Answer + "��";
            Answer_Question(Definition_Word, Answer - 2 + "��", Answer - 1 + "��", Answer + 1 + "��");
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_27()
        {
            //���p�O�p�`�̓W�J�}�̑̐�
            Random r = new Random();
            int r1 = r.Next(3, 10);
            int r2 = r.Next(3, 10);
            int r3 = r.Next(3, 18);
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            Question_Word = "a = " + r1 + "cm,b = " + r2 + "cm,c = " + r3 + "cm�̂Ƃ��A�摜�̓W�J�}��g�ݗ��ĂĂł��钼�p�O�p�`�̑̐ς����߂�";
            int Answer = r1 * r2 / 2 * r3;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_27_01.png";
            Answer_Question(Answer + "cm^3", Answer - 4 + "cm^3", Answer - 1 + "cm^3", Answer + 3 + "cm^3");
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_28()
        {
            //���l�p���̓W�J�}�̑̐�
            Random r = new Random();
            int r1 = r.Next(3, 18) * 3;
            int r2 = r.Next(3, 18) * 3;
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            Question_Word = "a = " + r1 + "cm,b = " + r2 + "cm�̂Ƃ��A�摜�̓W�J�}��g�ݗ��ĂĂł��鐳�l�p���̑̐ς����߂�";
            int Answer = r1 * r2 / 3;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_28_01.png";
            Answer_Question(Answer + "cm^3", Answer - 4 + "cm^3", Answer - 1 + "cm^3", Answer + 3 + "cm^3");
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_29()
        {
            //�~���̓W�J�}�̑̐�
            Random r = new Random();
            int r1 = r.Next(3, 10);
            int r2 = r.Next(3, 18);
            Question_Word = "a = " + r1 + "cm,b = " + r2 + "cm�̂Ƃ��A�摜�̓W�J�}��g�ݗ��ĂĂł���~���̑̐ς����߂�";
            int Answer = (int)Math.Pow(r1, 2) * r2;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_29_01.png";
            Answer_Question(Answer + "��cm^3", Answer - 4 + "��cm^3", Answer - 1 + "��cm^3", Answer + 3 + "��cm^3");
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_30()
        {
            //�~���̓W�J�}�̕\�ʐ�
            Random r = new Random();
            int r1 = r.Next(3, 10) * 3;
            int r2 = r.Next(3, 18) * 3;
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            Question_Word = "a = " + r1 + "cm,b = " + r2 + "cm�̂Ƃ��A�摜�̓W�J�}��g�ݗ��ĂĂł���~���̕\�ʐς����߂�";
            int Answer = (int)Math.Pow(r1, 2) * 2 + r1 * 2 * r2;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_29_01.png";
            Answer_Question(Answer + "��cm^2", Answer - 4 + "��cm^2", Answer - 1 + "��cm^2", Answer + 3 + "��cm^2");
            Button_Text_Change();
            IsImageUse = true;
        }
        void Answer_Question(string One, string Two, string Three, string Four)
        {
            Button_Answer_Word_01 = One;
            Button_Answer_Word_02 = Two;
            Button_Answer_Word_03 = Three;
            Button_Answer_Word_04 = Four;
        }
        string City_Random()
        {
            //�����_���œs���{�����擾(�Ԃ����Ⴏ����Ȃ�)
            Random r = new Random();
            int r2 = r.Next(1, 48);
            if (r2 == 1)
            {
                return "�k�C��";
            }
            else if (r2 == 2)
            {
                return "�X��";
            }
            else if (r2 == 3)
            {
                return "��茧";
            }
            else if (r2 == 4)
            {
                return "�{�錧";
            }
            else if (r2 == 5)
            {
                return "�H�c��";
            }
            else if (r2 == 6)
            {
                return "�R�`��";
            }
            else if (r2 == 7)
            {
                return "������";
            }
            else if (r2 == 8)
            {
                return "��錧";
            }
            else if (r2 == 9)
            {
                return "�Ȗ،�";
            }
            else if (r2 == 10)
            {
                return "�Q�n��";
            }
            else if (r2 == 11)
            {
                return "��ʌ�";
            }
            else if (r2 == 12)
            {
                return "��t��";
            }
            else if (r2 == 13)
            {
                return "�����s";
            }
            else if (r2 == 14)
            {
                return "�_�ސ쌧";
            }
            else if (r2 == 15)
            {
                return "�V����";
            }
            else if (r2 == 16)
            {
                return "�x�R��";
            }
            else if (r2 == 17)
            {
                return "�ΐ쌧";
            }
            else if (r2 == 18)
            {
                return "���䌧";
            }
            else if (r2 == 19)
            {
                return "�R����";
            }
            else if (r2 == 20)
            {
                return "���쌧";
            }
            else if (r2 == 21)
            {
                return "�򕌌�";
            }
            else if (r2 == 22)
            {
                return "�É���";
            }
            else if (r2 == 23)
            {
                return "���m��";
            }
            else if (r2 == 24)
            {
                return "�O�d��";
            }
            else if (r2 == 25)
            {
                return "���ꌧ";
            }
            else if (r2 == 26)
            {
                return "���s�{";
            }
            else if (r2 == 27)
            {
                return "���{";
            }
            else if (r2 == 28)
            {
                return "���Ɍ�";
            }
            else if (r2 == 29)
            {
                return "�ޗǌ�";
            }
            else if (r2 == 30)
            {
                return "�a�̎R��";
            }
            else if (r2 == 31)
            {
                return "���挧";
            }
            else if (r2 == 32)
            {
                return "������";
            }
            else if (r2 == 33)
            {
                return "���R��";
            }
            else if (r2 == 34)
            {
                return "�L����";
            }
            else if (r2 == 35)
            {
                return "�R����";
            }
            else if (r2 == 36)
            {
                return "������";
            }
            else if (r2 == 37)
            {
                return "���쌧";
            }
            else if (r2 == 38)
            {
                return "���Q��";
            }
            else if (r2 == 39)
            {
                return "���m��";
            }
            else if (r2 == 40)
            {
                return "������";
            }
            else if (r2 == 41)
            {
                return "���ꌧ";
            }
            else if (r2 == 42)
            {
                return "���茧";
            }
            else if (r2 == 43)
            {
                return "�F�{��";
            }
            else if (r2 == 44)
            {
                return "�啪��";
            }
            else if (r2 == 45)
            {
                return "�{�茧";
            }
            else if (r2 == 46)
            {
                return "��������";
            }
            else if (r2 == 47)
            {
                return "���ꌧ";
            }
            else
            {
                return "";
            }
        }
        static bool IsDecimal(double dValue)
        {
            //���������݂��邩  ����=ture ���Ȃ�=false��Ԃ�
            if (dValue - Math.Floor(dValue) != 0)
            {
                return true;
            }
            return false;
        }
    }
}
public class SRTTbacon_Anser
{
    private readonly dynamic Ans = null;
    public SRTTbacon_Anser()
    {
        string str = "package Evaluator{class Evaluator{public function MyEval(expr:String){return eval(expr);}}}";
        CodeDomProvider jScriptCodeProvider = new JScriptCodeProvider();
        CompilerParameters compilerParameter = new CompilerParameters()
        {
            GenerateInMemory = true
        };
        Assembly compiledAssembly = jScriptCodeProvider.CompileAssemblyFromSource(compilerParameter, new string[] { str }).CompiledAssembly;
        Ans = Activator.CreateInstance(compiledAssembly.GetType("Evaluator.Evaluator"));
    }
    public object Eval(string exp)
    {
        object ans;
        try
        {
            ans = ((dynamic)Ans).MyEval(exp);
            return ans;
        }
        catch
        {
            return "Errer";
        }
    }
}