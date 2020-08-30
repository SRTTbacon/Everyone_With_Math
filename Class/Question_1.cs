using Microsoft.JScript;
using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows;

namespace Everyone_With_Math.Class
{
    public partial class Math_01 : Window
    {
        //1学年の問題を定義するクラス
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
        //1回全部消え、exeファイルから復元したためコードがわかりにくくなっている(Question_Number_09まで)
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
                    Question_Word = string.Concat(new object[] { num1, " - ", num, " =  □" });
                    Definition_Word = string.Concat(new object[] { num1, " - (", num, ")" });
                    str = string.Concat(new object[] { num1, " + (", num, ")" });
                }
            }
            else
            {
                int num2 = random.Next(-19823, 20000);
                Question_Word = string.Concat(new object[] { num2, " - (", num, ") =  □" });
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
                Question_Word = string.Concat(new object[] { num1, " x ", num, " =  □" });
                Definition_Word = string.Concat(new object[] { num1, " * (", num, ")" });
            }
            else
            {
                int num2 = random.Next(-39, 39);
                Question_Word = string.Concat(new object[] { num2, " x (", num, ") =  □" });
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
            Question_Word = string.Concat(num, "を逆数にせよ");
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
                Question_Word = "72 ÷ (-3) = □";
                Definition_Word = "-24";
                num = -24;
            }
            if (num2 == 2)
            {
                Question_Word = "125 ÷ (-5) = □";
                Definition_Word = "-25";
                num = -25;
            }
            if (num2 == 3)
            {
                Question_Word = "504 ÷ (-8) = □";
                Definition_Word = "-63";
                num = -63;
            }
            if (num2 == 4)
            {
                Question_Word = "1170 ÷ 18 = □";
                Definition_Word = "65";
                num = 65;
            }
            if (num2 == 5)
            {
                Question_Word = "-194 ÷ 5 = □";
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
                Question_Word = "194 ÷ 8 = □";
                Definition_Word = "97/4";
                str1 = "194/8";
            }
            if (num == 2)
            {
                Question_Word = "-357 ÷ 9 = □";
                Definition_Word = "-119/3";
                str1 = "357/9";
            }
            if (num == 3)
            {
                Question_Word = "-164 ÷ 6 = □";
                Definition_Word = "82/3";
                str1 = "164/6";
            }
            if (num == 4)
            {
                Question_Word = "12 ÷ 28 = □";
                Definition_Word = "3/7";
                str1 = "6/14";
            }
            if (num == 5)
            {
                Question_Word = "16 ÷ 64 = □";
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
                    Question_Word = string.Concat(new object[] { num, "x + ", num1, "x = □" });
                }
            }
            else
            {
                Question_Word = string.Concat(new object[] { num, "x + (", num1, "x ) = □" });
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
                    Question_Word = string.Concat(new object[] { num, "x X ", num1, "x = □" });
                }
            }
            else
            {
                Question_Word = string.Concat(new object[] { num, "x X (", num1, "x ) = □" });
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
                Question_Word = "1428x^2 ÷ 8x = □";
                Definition_Word = "357x/2";
                str1 = "179";
            }
            if (num == 2)
            {
                Question_Word = "-983 ÷ 9 = □";
                Definition_Word = "-983/9";
                str1 = "328";
            }
            if (num == 3)
            {
                Question_Word = "-164 ÷ 6 = □";
                Definition_Word = "-82/3";
                str1 = "164/6";
            }
            if (num == 4)
            {
                Question_Word = "12x ÷ 28x^2 = □";
                Definition_Word = "3/7x";
                str1 = "3x/7";
            }
            if (num == 5)
            {
                Question_Word = "16x^5 ÷ 64x^2 = □";
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
                Definition_Word = "8πcm^2, 14π + 4cm";
                str = "16πcm^2, 4π + 4cm";
                str1 = "8πcm^2, 8πcm";
                str2 = "16πcm^2, 8πcm";
                Math_Image_Source = string.Concat(Path, "/Resources/BG/Math/Grade_01/Number_09_01.png");
            }
            if (num == 2)
            {
                Definition_Word = "12πcm^2, 4π + 12cm";
                str = "12πcm^2, 12πcm";
                str1 = "36πcm^2, 4π + 12cm";
                str2 = "36πcm^2, 12πcm";
                Math_Image_Source = string.Concat(Path, "/Resources/BG/Math/Grade_01/Number_09_02.png");
            }
            if (num == 3)
            {
                Definition_Word = "8πcm^2, 4π + 8cm";
                str = "16πcm^2, 4π + 8cm";
                str1 = "8πcm^2, 8πcm";
                str2 = "16πcm^2, 8πcm";
                Math_Image_Source = string.Concat(Path, "/Resources/BG/Math/Grade_01/Number_09_03.png");
            }
            if (num == 4)
            {
                Definition_Word = "5πcm^2, 2π + 10cm";
                str = "5πcm^2, 2πcm";
                str1 = "25πcm^2, 2π + 10cm";
                str2 = "25πcm^2, 2πcm";
                Math_Image_Source = string.Concat(Path, "/Resources/BG/Math/Grade_01/Number_09_04.png");
            }
            if (num == 5)
            {
                Definition_Word = "72πcm^2, 12π + 24cm";
                str = "72πcm^2, 12πcm";
                str1 = "144πcm^2, 12π + 24cm";
                str2 = "144πcm^2, 12πcm";
                Math_Image_Source = string.Concat(Path, "/Resources/BG/Math/Grade_01/Number_09_05.png");
            }
            Question_Word = "この円の面積と周の長さを求めよ";
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
                Question_Word = "「719を9で割ると商が79であまりが8」を式で表わせ";
                Definition_Word = "719 = 9 x 79 + 8";
                str = "711 = 9 x 79 + 8";
                str1 = "79 = 719 ÷ 9";
                str2 = "727 = 9 x 79";
            }
            if (num == 2)
            {
                Question_Word = "「1981を3で割ると商が660であまりが1」を式で表わせ";
                Definition_Word = "1981 = 3 x 660 + 1";
                str = "1980 = 3 x 660 + 1";
                str1 = "660 = 1981 ÷ 3";
                str2 = "1982 = 3 x 660";
            }
            if (num == 3)
            {
                Question_Word = "「914を5で割ると商が182で4足りない」を式で表わせ";
                Definition_Word = "914 = 5 x 182 - 4";
                str = "918 = 5 x 182 - 4";
                str1 = "182 = 914 ÷ 5";
                str2 = "910 = 5 x 182";
            }
            if (num == 4)
            {
                Question_Word = "「285を6で割ると商が48で3足りない」を式で表わせ";
                Definition_Word = "285 = 6 x 48 - 3";
                str = "288 = 6 x 48 - 3";
                str1 = "48 = 285 ÷ 6";
                str2 = "282 = 6 x 48";
            }
            if (num == 5)
            {
                Question_Word = "「1779を12で割ると商が148であまりが3」を式で表わせ";
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
                Question_Word = "ある学校の校舎の中に120人の生徒がいます。\n女子生徒は男子生徒よりも8人多い場合の男子生徒の人数を求めよ";
                Definition_Word = "男子生徒 56人";
                Miss_01 = "男子生徒 64人";
                Miss_02 = "男子生徒 61人";
                Miss_03 = "男子生徒 58人";
            }
            if (r2 == 2)
            {
                Question_Word = City_Random() + "に住むたける君は近くの店に文房具を買いに行きます。鉛筆1つx円で全部で7個買い、合計で350円でした。鉛筆1つはいくら？";
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
                Question_Word = "ある数xを3倍して7引いた数はもとの数より3小さい。\nある数xを求めよ";
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
                Question_Word = "若奈ちゃんは" + City_Name + "へ旅行に行くことになりました。今いる場所から" + City_Name + "までの道のりは約200kmあり、時速40kmでその場所へ向かいます。約何時間後に到着する？";
                Definition_Word = "約5時間後";
                Miss_01 = "約3時間30分後";
                Miss_02 = "約6時間後";
                Miss_03 = "たどり着けない";
            }
            if (r2 == 5)
            {
                Question_Word = "クラスに40人の生徒がいます。\n女子は男子より6人少ない。\n女子の人数を求めよ";
                Definition_Word = "女子生徒 17人";
                Miss_01 = "女子生徒 23人";
                Miss_02 = "女子生徒 34人";
                Miss_03 = "女子生徒 19人";
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
                Question_Word = "x(km)の道のりを4時間かけて歩いたときの速さは何km/hか";
                Definition_Word = "x/4 km/h";
                Miss_01 = "4/x km/h";
                Miss_02 = "x/240 km/h";
                Miss_03 = "240/x km/h";
            }
            if (r2 == 2)
            {
                Question_Word = "x(m)の道のりを、180(m/分)で進むときにかかる時間は何分か";
                Definition_Word = "x/180分";
                Miss_01 = "180/x分";
                Miss_02 = "x/3分";
                Miss_03 = "3/x分";
            }
            if (r2 == 3)
            {
                Question_Word = "x(km/時)の速さで5時間走ったときに進んだ道のりは何kmか";
                Definition_Word = "5x km";
                Miss_01 = "x/5 km";
                Miss_02 = "5/x km";
                Miss_03 = "0.5x km";
            }
            if (r2 == 4)
            {
                Question_Word = "6時間は何分か表せ";
                Definition_Word = "360分";
                Miss_01 = "60分";
                Miss_02 = "120分";
                Miss_03 = "21600秒";
            }
            if (r2 == 5)
            {
                Question_Word = "1時間20分は何時間表せ";
                Definition_Word = "4/3時間";
                Miss_01 = "3/4時間";
                Miss_02 = "1時間20分";
                Miss_03 = "1/20時間";
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
                Question_Word = "2000の4割";
                Definition_Word = "800";
                Miss_01 = "80";
                Miss_02 = "500";
                Miss_03 = "200";
            }
            if (r2 == 2)
            {
                Question_Word = "500の10%引き";
                Definition_Word = "450";
                Miss_01 = "400";
                Miss_02 = "50";
                Miss_03 = "550";
            }
            if (r2 == 3)
            {
                Question_Word = "xの3割増し";
                Definition_Word = "13x/10";
                Miss_01 = "400";
                Miss_02 = "50";
                Miss_03 = "550";
            }
            if (r2 == 4)
            {
                Question_Word = "yの3%";
                Definition_Word = "3y/100";
                Miss_01 = "3y";
                Miss_02 = "3/y";
                Miss_03 = "y-3";
            }
            if (r2 == 5)
            {
                Question_Word = "200のv%引き";
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
                Question_Word = "次の文章をy=の形にせよ\n1本x円の消しゴムを8個買ったときの代金はy円である";
                Definition_Word = "y = 8x";
                Miss_01 = "y = 1/8x";
                Miss_02 = "x = 8y";
                Miss_03 = "x = 1/8y";
            }
            if (r2 == 2)
            {
                Question_Word = "次の文章をy=の形にせよ\n１辺の長さがxcmの正方形の面積がycm^2である";
                Definition_Word = "y = x^2";
                Miss_01 = "x = y^2";
                Miss_02 = "y = 2x";
                Miss_03 = "x = 2y";
            }
            if (r2 == 3)
            {
                Question_Word = "次を不等号を使って表せ\nxは8より大きく13より小さい";
                Definition_Word = "8 < x < 13";
                Miss_01 = "8 ≦ x ≦ 13";
                Miss_02 = "8 < x ≦ 13";
                Miss_03 = "8 ≦ x < 13";
            }
            if (r2 == 4)
            {
                Question_Word = "次を不等号を使って表せ\nxは-2より小さく-9よりも小さい";
                Definition_Word = "x < -2";
                Miss_01 = "-9 < x < -2";
                Miss_02 = "-9 < -2 < x";
                Miss_03 = "x ≦ -9 ≦ -2";
            }
            if (r2 == 5)
            {
                Question_Word = "次を不等号を使って表せ\nxはy以上13未満\nまた、yは5以下とする";
                Definition_Word = "y ≦ x <13";
                Miss_01 = "x ≦ y <13";
                Miss_02 = "y ≦ x ≦ 13";
                Miss_03 = "y ≦ 5 ≦ x";
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
                Question_Word = "y=14xについて\nx=-7のときのyの値を求めよ";
                Definition_Word = "y = -98";
                Miss_01 = "y = -2";
                Miss_02 = "y = 98";
                Miss_03 = "y = 2";
            }
            if (r2 == 2)
            {
                Question_Word = "y=13xについて\ny=338のときのxの値を求めよ";
                Definition_Word = "x = 26";
                Miss_01 = "x = 25";
                Miss_02 = "x = 27";
                Miss_03 = "y = 338";
            }
            if (r2 == 3)
            {
                Question_Word = "yがxに比例し、x=3のときにy=21である。比例定数を求めよ";
                Definition_Word = "7";
                Miss_01 = "3";
                Miss_02 = "21";
                Miss_03 = "63";
            }
            if (r2 == 4)
            {
                Question_Word = "yがxに比例し、x=15のときにy=-5である。yをxの式で表わせ";
                Definition_Word = "y = -x/3";
                Miss_01 = "y = -3/x";
                Miss_02 = "y = x/3";
                Miss_03 = "y = 3/x";
            }
            if (r2 == 5)
            {
                Question_Word = "yがxに比例し、x=15のときにy=-15である。yをxの式で表わせ";
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
                Question_Word = "yがxに反比例し、x = 3, y = 9のとき。\nyをxの式で表せ";
                Definition_Word = "y = 27/x";
                Miss_01 = "y = 3x";
                Miss_02 = "y = 3/x";
                Miss_03 = "y = 27x";
            }
            if (r2 == 2)
            {
                Question_Word = "yがxに反比例し、x = 2, y = -5のとき。\nyをxの式で表せ";
                Definition_Word = "y = -10/x";
                Miss_01 = "y = 10/x";
                Miss_02 = "y = 10x";
                Miss_03 = "y = -10x";
            }
            if (r2 == 3)
            {
                Question_Word = "yがxに反比例し、x = -3, y = -1のとき。\nyをxの式で表せ";
                Definition_Word = "y = 3/x";
                Miss_01 = "y = 3x";
                Miss_02 = "y = -3x";
                Miss_03 = "y = -3/x";
            }
            if (r2 == 4)
            {
                Question_Word = "yがxに反比例し、x = 4, y = -3のとき。\nyをxの式で表せ";
                Definition_Word = "y = -12/x";
                Miss_01 = "y = 12x";
                Miss_02 = "y = -12x";
                Miss_03 = "y = 12/x";
            }
            if (r2 == 5)
            {
                Question_Word = "yがxに反比例し、x = 1, y = 7のとき。\nyをxの式で表せ";
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
                Question_Word = "点Aの座標を答えよ";
                Definition_Word = "-9,9";
                Miss_01 = "9,-9";
                Miss_02 = "-9,-9";
                Miss_03 = "9,9";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_20_01.png";
            }
            if (r2 == 2)
            {
                Question_Word = "点Aの座標を答えよ";
                Definition_Word = "4,2";
                Miss_01 = "4,-2";
                Miss_02 = "-4,-2";
                Miss_03 = "-4,2";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_20_02.png";
            }
            if (r2 == 3)
            {
                Question_Word = "点Aの座標を答えよ";
                Definition_Word = "-6,-8";
                Miss_01 = "6,-8";
                Miss_02 = "-6,8";
                Miss_03 = "6,8";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_20_03.png";
            }
            if (r2 == 4)
            {
                Question_Word = "点Aの座標を答えよ";
                Definition_Word = "11,-11";
                Miss_01 = "11,11";
                Miss_02 = "-11,-11";
                Miss_03 = "-11,11";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_20_04.png";
            }
            if (r2 == 5)
            {
                Question_Word = "点Aの座標を答えよ";
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
            //中心角
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                //72°
                Question_Word = "この円の中心角を求めよ\nただし画像は円の5分の1のサイズとする";
                Definition_Word = "72°";
                Miss_01 = "60°";
                Miss_02 = "70°";
                Miss_03 = "62°";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_21_01.png";
            }
            if (r2 == 2)
            {
                //120°
                Question_Word = "この円の中心角を求めよ\nただし画像は円の3分の1のサイズとする";
                Definition_Word = "120°";
                Miss_01 = "180°";
                Miss_02 = "140°";
                Miss_03 = "110°";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_21_02.png";
            }
            if (r2 == 3)
            {
                //90°
                Question_Word = "この円の中心角を求めよ\nただし画像は円の4分の1のサイズとする";
                Definition_Word = "90°";
                Miss_01 = "100°";
                Miss_02 = "180°";
                Miss_03 = "求められない";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_21_03.png";
            }
            if (r2 == 4)
            {
                //180°
                Question_Word = "この円の中心角を求めよ\nただし画像は円の2分の1のサイズとする";
                Definition_Word = "180°";
                Miss_01 = "90°";
                Miss_02 = "170°";
                Miss_03 = "190°";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_21_04.png";
            }
            if (r2 == 5)
            {
                //45°
                Question_Word = "この円の中心角を求めよ\nただし画像は円の8分の1のサイズとする";
                Definition_Word = "45°";
                Miss_01 = "90°";
                Miss_02 = "50°";
                Miss_03 = "40°";
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
                Question_Word = "辺ABとねじれの位置にある辺は何個か";
                Definition_Word = "4個";
                Miss_01 = "3個";
                Miss_02 = "5個";
                Miss_03 = "なし";
            }
            if (r2 == 2)
            {
                Question_Word = "辺BCに平行な辺は何個か";
                Definition_Word = "3個";
                Miss_01 = "2個";
                Miss_02 = "4個";
                Miss_03 = "なし";
            }
            if (r2 == 3)
            {
                Question_Word = "辺HGに交わる辺は何個か";
                Definition_Word = "4個";
                Miss_01 = "3個";
                Miss_02 = "5個";
                Miss_03 = "なし";
            }
            if (r2 == 4)
            {
                Question_Word = "画像の図形は正四角形です\n辺ABが8cmだった場合辺HGは何cmか";
                Definition_Word = "8cm";
                Miss_01 = "12cm";
                Miss_02 = "4cm";
                Miss_03 = "求められない";
            }
            if (r2 == 5)
            {
                Question_Word = "画像の図形は正四角形です\n∠BAEは何度か求めよ";
                Definition_Word = "90°";
                Miss_01 = "180°";
                Miss_02 = "45°";
                Miss_03 = "求められない";
            }
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_22_01.png";
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_23()
        {
            //四角柱
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            Random r = new Random();
            int r2 = r.Next(2, 21);
            int r3 = r.Next(2, 21);
            int r4 = r.Next(2, 21);
            Question_Word = "四角柱の体積を求めよ\n縦" + r2 + "cm,横" + r3 + "cm,高さ" + r4 + "cm";
            int Answer = r2 * r3 * r4 ;
            Answer_Question(Answer + "cm^3", Answer - 2 + "cm^3", Answer - 4 + "cm^3", Answer + 2 + "cm^3");
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_24()
        {
            //三角柱
            Random r = new Random();
            int r1 = r.Next(3, 15);
            int r2 = r.Next(3, 15);
            int r3 = r.Next(3, 15);
            Text_01_T.FontSize = 32;
            Text_02_T.FontSize = 32;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_24_01.png";
            Question_Word = "画像の三角柱について、a = " + r1 + "cm,b = " + r2 + "cm,c = " + r3 + "cmの場合の体積を求めよ\nまた、画像の見た目は考慮しないこと。";
            int Answer = r2 * r3 / 2 * r1;
            Answer_Question(Answer + "cm^3", Answer - 2 + "cm^3", Answer - 4 + "cm^3", Answer + 2 + "cm^3");
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_25()
        {
            //円柱
            Random r = new Random();
            int r1 = r.Next(3, 10);
            int r2 = r.Next(3, 14);
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Question_Word = "次の場合の画像の円柱の体積を求めよ\n半径" + r1 + "cm,高さ" + r2 + "cm";
            int Answer = r1 * r1 * r2;
            Answer_Question(Answer + "πcm^3", Answer - 3 + "πcm^3", Answer - 6 + "πcm^3", Answer + 3 + "πcm^3");
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_26()
        {
            //円柱の表面積の計算
            Random r = new Random();
            int r2 = r.Next(3, 18);
            int r3 = r.Next(3, 18);
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Question_Word = "半径" + r2 + "cm,高さ" + r3 + "cmの円柱の表面積を求めよ";
            int Answer = 2 * r2 * r2 + 2 * r2 * r3;
            Definition_Word = Answer + "π";
            Answer_Question(Definition_Word, Answer - 2 + "π", Answer - 1 + "π", Answer + 1 + "π");
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_01_Number_27()
        {
            //直角三角形の展開図の体積
            Random r = new Random();
            int r1 = r.Next(3, 10);
            int r2 = r.Next(3, 10);
            int r3 = r.Next(3, 18);
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            Question_Word = "a = " + r1 + "cm,b = " + r2 + "cm,c = " + r3 + "cmのとき、画像の展開図を組み立ててできる直角三角形の体積を求めよ";
            int Answer = r1 * r2 / 2 * r3;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_27_01.png";
            Answer_Question(Answer + "cm^3", Answer - 4 + "cm^3", Answer - 1 + "cm^3", Answer + 3 + "cm^3");
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_28()
        {
            //正四角錐の展開図の体積
            Random r = new Random();
            int r1 = r.Next(3, 18) * 3;
            int r2 = r.Next(3, 18) * 3;
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            Question_Word = "a = " + r1 + "cm,b = " + r2 + "cmのとき、画像の展開図を組み立ててできる正四角錐の体積を求めよ";
            int Answer = r1 * r2 / 3;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_28_01.png";
            Answer_Question(Answer + "cm^3", Answer - 4 + "cm^3", Answer - 1 + "cm^3", Answer + 3 + "cm^3");
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_29()
        {
            //円柱の展開図の体積
            Random r = new Random();
            int r1 = r.Next(3, 10);
            int r2 = r.Next(3, 18);
            Question_Word = "a = " + r1 + "cm,b = " + r2 + "cmのとき、画像の展開図を組み立ててできる円柱の体積を求めよ";
            int Answer = (int)Math.Pow(r1, 2) * r2;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_29_01.png";
            Answer_Question(Answer + "πcm^3", Answer - 4 + "πcm^3", Answer - 1 + "πcm^3", Answer + 3 + "πcm^3");
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_01_Number_30()
        {
            //円柱の展開図の表面積
            Random r = new Random();
            int r1 = r.Next(3, 10) * 3;
            int r2 = r.Next(3, 18) * 3;
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            Question_Word = "a = " + r1 + "cm,b = " + r2 + "cmのとき、画像の展開図を組み立ててできる円柱の表面積を求めよ";
            int Answer = (int)Math.Pow(r1, 2) * 2 + r1 * 2 * r2;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_01/Number_29_01.png";
            Answer_Question(Answer + "πcm^2", Answer - 4 + "πcm^2", Answer - 1 + "πcm^2", Answer + 3 + "πcm^2");
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
            //ランダムで都道府県を取得(ぶっちゃけいらない)
            Random r = new Random();
            int r2 = r.Next(1, 48);
            if (r2 == 1)
            {
                return "北海道";
            }
            else if (r2 == 2)
            {
                return "青森県";
            }
            else if (r2 == 3)
            {
                return "岩手県";
            }
            else if (r2 == 4)
            {
                return "宮城県";
            }
            else if (r2 == 5)
            {
                return "秋田県";
            }
            else if (r2 == 6)
            {
                return "山形県";
            }
            else if (r2 == 7)
            {
                return "福島県";
            }
            else if (r2 == 8)
            {
                return "茨城県";
            }
            else if (r2 == 9)
            {
                return "栃木県";
            }
            else if (r2 == 10)
            {
                return "群馬県";
            }
            else if (r2 == 11)
            {
                return "埼玉県";
            }
            else if (r2 == 12)
            {
                return "千葉県";
            }
            else if (r2 == 13)
            {
                return "東京都";
            }
            else if (r2 == 14)
            {
                return "神奈川県";
            }
            else if (r2 == 15)
            {
                return "新潟県";
            }
            else if (r2 == 16)
            {
                return "富山県";
            }
            else if (r2 == 17)
            {
                return "石川県";
            }
            else if (r2 == 18)
            {
                return "福井県";
            }
            else if (r2 == 19)
            {
                return "山梨県";
            }
            else if (r2 == 20)
            {
                return "長野県";
            }
            else if (r2 == 21)
            {
                return "岐阜県";
            }
            else if (r2 == 22)
            {
                return "静岡県";
            }
            else if (r2 == 23)
            {
                return "愛知県";
            }
            else if (r2 == 24)
            {
                return "三重県";
            }
            else if (r2 == 25)
            {
                return "滋賀県";
            }
            else if (r2 == 26)
            {
                return "京都府";
            }
            else if (r2 == 27)
            {
                return "大阪府";
            }
            else if (r2 == 28)
            {
                return "兵庫県";
            }
            else if (r2 == 29)
            {
                return "奈良県";
            }
            else if (r2 == 30)
            {
                return "和歌山県";
            }
            else if (r2 == 31)
            {
                return "鳥取県";
            }
            else if (r2 == 32)
            {
                return "島根県";
            }
            else if (r2 == 33)
            {
                return "岡山県";
            }
            else if (r2 == 34)
            {
                return "広島県";
            }
            else if (r2 == 35)
            {
                return "山口県";
            }
            else if (r2 == 36)
            {
                return "徳島県";
            }
            else if (r2 == 37)
            {
                return "香川県";
            }
            else if (r2 == 38)
            {
                return "愛媛県";
            }
            else if (r2 == 39)
            {
                return "高知県";
            }
            else if (r2 == 40)
            {
                return "福岡県";
            }
            else if (r2 == 41)
            {
                return "佐賀県";
            }
            else if (r2 == 42)
            {
                return "長崎県";
            }
            else if (r2 == 43)
            {
                return "熊本県";
            }
            else if (r2 == 44)
            {
                return "大分県";
            }
            else if (r2 == 45)
            {
                return "宮崎県";
            }
            else if (r2 == 46)
            {
                return "鹿児島県";
            }
            else if (r2 == 47)
            {
                return "沖縄県";
            }
            else
            {
                return "";
            }
        }
        static bool IsDecimal(double dValue)
        {
            //小数が存在するか  する=ture しない=falseを返す
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