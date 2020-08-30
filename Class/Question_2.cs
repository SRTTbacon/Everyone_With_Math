using System;
using System.Windows;

namespace Everyone_With_Math.Class
{
    public partial class Math_01 : Window
    {
        //2学年の問題を定義
        bool Question_02_01_Answer;
        bool Question_02_02_Answer;
        bool Question_02_03_Answer;
        bool Question_02_04_Answer;
        bool Question_02_05_Answer;
        bool Question_02_06_Answer;
        bool Question_02_07_Answer;
        bool Question_02_08_Answer;
        bool Question_02_09_Answer;
        bool Question_02_10_Answer;
        bool Question_02_11_Answer;
        bool Question_02_12_Answer;
        bool Question_02_13_Answer;
        bool Question_02_14_Answer;
        bool Question_02_15_Answer;
        bool Question_02_16_Answer;
        bool Question_02_17_Answer;
        bool Question_02_18_Answer;
        bool Question_02_19_Answer;
        bool Question_02_20_Answer;
        bool Question_02_21_Answer;
        bool Question_02_22_Answer;
        bool Question_02_23_Answer;
        bool Question_02_24_Answer;
        bool Question_02_25_Answer;
        bool Question_02_26_Answer;
        bool Question_02_27_Answer;
        bool Question_02_28_Answer;
        bool Question_02_29_Answer;
        bool Question_02_30_Answer;
        void Question_Grade_02_Number_01()
        {
            Text_01_T.FontSize = 30;
            Text_02_T.FontSize = 30;
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Question_Word = "単項式はいくつあるか\n・−4ax^3y      ・234\n・9a-8      ・8x^3−x";
                Definition_Word = "2つ";
                Miss_01 = "1つ";
                Miss_02 = "3つ";
                Miss_03 = "4つ";
            }
            else if (r2 == 2)
            {
                Question_Word = "単項式はいくつあるか\n・9abx^8y      ・8129x^9\n・9a-8b      ・x^7";
                Definition_Word = "3つ";
                Miss_01 = "1つ";
                Miss_02 = "2つ";
                Miss_03 = "4つ";
            }
            else if (r2 == 3)
            {
                Question_Word = "単項式はいくつあるか\n・9abx^8y+6ab      ・3b-b^2\n・8a-4a-2      ・9b-b^2";
                Definition_Word = "なし";
                Miss_01 = "1つ";
                Miss_02 = "2つ";
                Miss_03 = "3つ";
            }
            else if (r2 == 4)
            {
                Question_Word = "単項式はいくつあるか\n・6abx^2y+3ab      ・9b-b^7\n・8a-5b-2      ・9b";
                Definition_Word = "1つ";
                Miss_01 = "2つ";
                Miss_02 = "3つ";
                Miss_03 = "4つ";
            }
            else if (r2 == 5)
            {
                Question_Word = "単項式はいくつあるか\n・2abc^4y      ・91^2\n・8a      ・2";
                Definition_Word = "4つ";
                Miss_01 = "1つ";
                Miss_02 = "2つ";
                Miss_03 = "3つ";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_02()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Random r = new Random();
            int r1 = r.Next(-50, 61);
            int r2 = r.Next(2, 61);
            int r3 = r.Next(-50, -1);
            int r4 = r.Next(2, 61);
            int r5 = r.Next(-50, -1);
            int r6 = r.Next(-50, 61);
            if (r1 == 0 || r1 == 1 || r1 == -1 || r2 == 1 || r3 == 0 || r3 == 1 || r4 == 0 || r4 == 1 || r5 == 0 || r5 == 1 || r6 == 0 || r6 == 1)
            {
                Question_Grade_02_Number_02();
                return;
            }
            if (r6 > 0)
            {
                Question_Word = r1 + "x^2 + " + r2 + "x " + r3 + " + " + r4 + "x^2 " + r5 + "x + " + r6 + "を解け";
            }
            else
            {
                Question_Word = r1 + "x^2 + " + r2 + "x " + r3 + " + " + r4 + "x^2 " + r5 + "x " + r6 + "を解け";
            }
            int Answer_01 = r1 + r4;
            int Answer_02 = r2 + r5;
            int Answer_03 = r3 + r6;
            int Miss_Minus_01 = r1 - r4;
            int Miss_Minus_02 = r2 - r5;
            int Miss_Minus_03 = r3 - r6;
            string Answer_02_T;
            if (Answer_02 >= 0)
            {
                Answer_02_T = "+" + Answer_02;
            }
            else
            {
                Answer_02_T = Answer_02.ToString();
            }
            string Answer_03_T;
            if (Answer_03 > 0)
            {
                Answer_03_T = "+" + Answer_03;
            }
            else
            {
                Answer_03_T = Answer_03.ToString();
            }
            string Miss_Minus_02_T;
            if (Miss_Minus_02 > 0)
            {
                Miss_Minus_02_T = "+" + Miss_Minus_02;
            }
            else
            {
                Miss_Minus_02_T = Miss_Minus_02.ToString();
            }
            string Miss_Minus_03_T;
            if (Miss_Minus_03 > 0)
            {
                Miss_Minus_03_T = "+" + Miss_Minus_03;
            }
            else
            {
                Miss_Minus_03_T = Miss_Minus_03.ToString();
            }
            Definition_Word = Answer_01 + "x^2" + Answer_02_T + "x" + Answer_03_T;
            string Miss_01 = Answer_01 + "x^2" + Miss_Minus_02_T + "x" + Answer_03_T;
            string Miss_02 = Answer_01 + "x^2" + Miss_Minus_02_T + "x" + Miss_Minus_03_T;
            string Miss_03 = Miss_Minus_01 + "x^2" + Answer_02_T + "x" + Miss_Minus_03_T;
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_03()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Random r = new Random();
            int r1 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r1 == 1)
            {
                Question_Word = "8x^2y^2 × 3xy^2 ÷ 6xyを解け";
                Definition_Word = "4x^2y^3";
                Miss_01 = "4x^4y^5";
                Miss_02 = "4xy^2";
                Miss_03 = "4x^3y^4";
            }
            else if (r1 == 2)
            {
                Question_Word = "8x^2y^2 × 3xy^2 ÷ 6xyを解け";
                Definition_Word = "4x^2y^3";
                Miss_01 = "4x^4y^5";
                Miss_02 = "4xy^2";
                Miss_03 = "4x^3y^4";
            }
            else if (r1 == 3)
            {
                Question_Word = "8x^2y^2 × 3xy^2 ÷ 6xyを解け";
                Definition_Word = "4x^2y^3";
                Miss_01 = "4x^4y^5";
                Miss_02 = "4xy^2";
                Miss_03 = "4x^3y^4";
            }
            else if (r1 == 4)
            {
                Question_Word = "8x^2y^2 × 3xy^2 ÷ 6xyを解け";
                Definition_Word = "4x^2y^3";
                Miss_01 = "4x^4y^5";
                Miss_02 = "4xy^2";
                Miss_03 = "4x^3y^4";
            }
            else if (r1 == 5)
            {
                Question_Word = "8x^2y^2 × 3xy^2 ÷ 6xyを解け";
                Definition_Word = "4x^2y^3";
                Miss_01 = "4x^4y^5";
                Miss_02 = "4xy^2";
                Miss_03 = "4x^3y^4";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        async void Question_Grade_02_Number_04()
        {
            Text_01_T.FontSize = 30;
            Text_02_T.FontSize = 30;
            Random r = new Random();
            int r2 = r.Next(-30, 31);
            int r3 = r.Next(-30, 31);
            int r4 = r.Next(-30, 31);
            int r5 = r.Next(-30, 31);
            Question_Word = "a=" + r3 + ", b=" + r4 + "のとき、つぎの式の値を求めよ\n" + r2 + "(3a + 5b) + " + r5 + "(a - 3b)";
            //処理速度の心配で分けて計算
            int Answer_00 = (3 * r3) + (5 * r4);
            await System.Threading.Tasks.Task.Delay(5);
            int Answer_01 = r2 * Answer_00;
            await System.Threading.Tasks.Task.Delay(5);
            int Answer_02 = r3 - (3 * r4);
            await System.Threading.Tasks.Task.Delay(5);
            int Answer_03 = r5 * Answer_02;
            //StackOver～でクラッシュするためコメントにしています。(0がでても仕方ない。。。)
            /*if (r2 == 0 || r3 == 0 || r4 == 0 || r5 == 0)
            {
                Question_Grade_02_Number_04();
                return;
            }*/
            int Answer = Answer_01 + Answer_03;
            int Miss_01 = Answer - r.Next(-10, -1);
            int Miss_02 = Answer + r.Next(1, 6);
            int Miss_03 = Answer + r.Next(6, 11);
            Answer_Question(Answer.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_05()
        {
            //□について解け
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Question_Word = "次の式をaについて解け\na/5 + 10 = T";
                Definition_Word = "a = 5T - 50";
                Miss_01 = "a = T - 50";
                Miss_02 = "a = 5T - 10";
                Miss_03 = "a = T + 10";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の式をaについて解け\na/3 - 12 = T^2";
                Definition_Word = "a = 3T^2 + 36";
                Miss_01 = "a = T^2 + 36";
                Miss_02 = "a = 3T^2 + 12";
                Miss_03 = "a = T^2 - 12";
            }
            else if (r2 == 3)
            {
                Question_Word = "次の式をaについて解け\n4a + 16 = 24T";
                Definition_Word = "a = 6T - 4";
                Miss_01 = "a = 24T -4";
                Miss_02 = "a = 6T - 16";
                Miss_03 = "a = 24T -16";
            }
            else if (r2 == 4)
            {
                Question_Word = "次の式をaについて解け\n10a - 15 = 20T";
                Definition_Word = "a = (4T + 3) / 2";
                Miss_01 = "a = (4T + 15) / 2";
                Miss_02 = "a = (20T + 15) / 2";
                Miss_03 = "a = (20T + 3) / 2";
            }
            else if (r2 == 5)
            {
                Question_Word = "次の式をaについて解け\n7a - 15 = 4T^3";
                Definition_Word = "a = (4T^3 + 15) / 7";
                Miss_01 = "a = (4T^3 - 15) / 7";
                Miss_02 = "a = 4T^3 + 15";
                Miss_03 = "a = 4T^3 - 15";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_06()
        {
            //方程式
            Text_01_T.FontSize = 32;
            Text_02_T.FontSize = 32;
            Random r = new Random();
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            int r2 = r.Next(1, 6);
            Kakko_Image.Visibility = Visibility.Visible;
            if (r2 == 1)
            {
                Question_Word = "次の連立方程式を解け\n3x + 2y = 9\ny = x + 2";
                Definition_Word = "x = 1 ,y = 3";
                Miss_01 = "x = 3 ,y = 1";
                Miss_02 = "x = -1 ,y = 3";
                Miss_03 = "x = -3 ,y = 1";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の連立方程式を解け\n5x + y = 5\ny = x + 5";
                Definition_Word = "x = 0 ,y = 5";
                Miss_01 = "x = 5 ,y = 0";
                Miss_02 = "x = 0 ,y = -5";
                Miss_03 = "x = -5 ,y = 0";

            }
            else if (r2 == 3)
            {
                Question_Word = "次の連立方程式を解け\n5x + y = 5\ny = x + 5";
                Definition_Word = "x = 0 ,y = 5";
                Miss_01 = "x = 5 ,y = 0";
                Miss_02 = "x = 0 ,y = -5";
                Miss_03 = "x = -5 ,y = 0";
            }
            else if (r2 == 4)
            {
                Question_Word = "次の連立方程式を解け\n2x + 2y = 8\ny = 4x - 1";
                Definition_Word = "x = 1 ,y = 3";
                Miss_01 = "x = -1 ,y = -3";
                Miss_02 = "x = -3 ,y = 1";
                Miss_03 = "x = -1 ,y = 3";
            }
            else if (r2 == 5)
            {
                Question_Word = "次の連立方程式を解け\n5x + 6y = 8\ny = -x + 6";
                Definition_Word = "x = 28 ,y = -22";
                Miss_01 = "x = -28 ,y = 22";
                Miss_02 = "x = -22 ,y = 28";
                Miss_03 = "x = 22 ,y = -28";
            }
            Answer_Question(Definition_Word, Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_07()
        {
            Text_01_T.FontSize = 32;
            Text_02_T.FontSize = 32;
            Kakko_Image.Visibility = Visibility.Visible;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "次の連立方程式を解け\n4x + 2y = 2\n4x + 5y = -7";
                Definition_Word = "x = 2 , y = -3";
                Miss_01 = "x = -3 , y = 2";
                Miss_02 = "x = -2 , y = 3";
                Miss_03 = "x = 3 , y = -2";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の連立方程式を解け\n2x + 4y = 6\nx + 3y = 4";
                Definition_Word = "x = 1 , y = 1";
                Miss_01 = "x = -1 , y = -1";
                Miss_02 = "x = 1 , y = -1";
                Miss_03 = "x = -1 , y = -1";
            }
            else if (r2 == 3)
            {
                Question_Word = "次の連立方程式を解け\n4x + y =	10\n3x + y = 6";
                Definition_Word = "x = 4 , y = -6";
                Miss_01 = "x = -4 , y - 6";
                Miss_02 = "x = 4 , y = 6";
                Miss_03 = "x = -4 , y = 6";
            }
            else if (r2 == 4)
            {
                Question_Word = "次の連立方程式を解け\n5x + 7y = 1\n7x + 6y = 9";
                Definition_Word = "x = 3 , y = -2";
                Miss_01 = "x = -3 , y = -2";
                Miss_02 = "x = 3 , = 2";
                Miss_03 = "x = -3 , y = 2";
            }
            else if (r2 == 5)
            {
                Question_Word = "次の連立方程式を解け\n4x - y = 3\n3x - y = 1";
                Definition_Word = "x = 2 , y = 5";
                Miss_01 = "x = -2 , y = -5";
                Miss_02 = "x = 2 , y = -5";
                Miss_03 = "x = -2 , y = 5";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_08()
        {
            Text_01_T.FontSize = 32;
            Text_02_T.FontSize = 32;
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Kakko_Image.Visibility = Visibility.Hidden;
                Question_Word = "次の連立方程式を解け\n2x - y + 11 = 3x + 2y = 8x + 6y";
                Definition_Word = "x = -4 , y = 5";
                Miss_01 = "x = 4 , y = 5";
                Miss_02 = "x = -4 , y = -5";
                Miss_03 = "x = 4 , y = -5";
            }
            else if (r2 == 2)
            {
                Kakko_Image.Visibility = Visibility.Visible;
                Question_Word = "次の連立方程式を解け\nax + by = 2\n3bx + 2ay = 6";
                Definition_Word = "a = 5 , b = 4";
                Miss_01 = "a = -5 , b = 4";
                Miss_02 = "a = 5 , b = -4";
                Miss_03 = "a = -5 , b = -4";
            }
            else if (r2 == 3)
            {
                Kakko_Image.Visibility = Visibility.Visible;
                Question_Word = "次の連立方程式を解け\n3(2x + 3y + 1) - (2x - 5) = 11\n2(4x - 7y) + 3(x + 5y - 8) = 8 ";
                Definition_Word = "x = 3 , y = 1";
                Miss_01 = "x = -3 , y = 1";
                Miss_02 = "x = 3 , y = -1";
                Miss_03 = "x = -3 , y = -1";
            }
            else if (r2 == 4)
            {
                Kakko_Image.Visibility = Visibility.Visible;
                Question_Word = "次の連立方程式を解け\n7x + 6y = -4\n8x - 15y = -24";
                Definition_Word = "x = -4/3 , y = 8/9";
                Miss_01 = "x = 4/3 , y = 8/9";
                Miss_02 = "x = -4/3 , y = -8/9";
                Miss_03 = "x = 4/3 , y = -8/9";
            }
            else if (r2 == 5)
            {
                Kakko_Image.Visibility = Visibility.Visible;
                Question_Word = "次の連立方程式を解け\n2.1x + 0.3y = -7.5\n0.08x + 0.04y = -0.2";
                Definition_Word = "x = -4 , y = 3";
                Miss_01 = "x = 4 , y = 3";
                Miss_02 = "x = -4 , y = -3";
                Miss_03 = "x = 4 , y = -3";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_09()
        {
            Text_01_T.FontSize = 32;
            Text_02_T.FontSize = 32;
            Kakko_Image.Visibility = Visibility.Visible;
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Question_Word = "次の連立方程式を解け\n2.1x + 0.3y = -7.5\n0.08x + 0.04y = -0.2";
                Definition_Word = "x = -4 , y = 3";
                Miss_01 = "x = 4 , y = -3";
                Miss_02 = "x = 3 , y = -4";
                Miss_03 = "x = -4 , y = -3";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の連立方程式を解け\n0.8x + 6y = 12\n1.6x - 9y = 3";
                Definition_Word = "x = 15/2 , y = 1";
                Miss_01 = "x = -15/2 , y = -1";
                Miss_02 = "x = -15/2 , y = 1";
                Miss_03 = "x = 15/2 , y = -1";
            }
            else if (r2 == 3)
            {
                Question_Word = "次の連立方程式を解け\nx/2 - y/4 = 9/4\nx/6 + y/8 = 23/24";
                Definition_Word = "x = 5 , y = 1";
                Miss_01 = "x = -5 , y = -1";
                Miss_02 = "x = -5 , y = 1";
                Miss_03 = "x = 5 , y = -1";
            }
            else if (r2 == 4)
            {
                Question_Word = "次の連立方程式を解け\n4x/3 - 3y/4 = -14\n0.3x - 0.7y = -7.4";
                Definition_Word = "x = -6 , y = 8";
                Miss_01 = "x = 6 , y = -8";
                Miss_02 = "x = -6 , y = -8";
                Miss_03 = "x = 8 , y = -6";
            }
            else if (r2 == 5)
            {
                Question_Word = "次の連立方程式を解け\n9x/2 - 8y/3 = 5\n5x/4 + 4y/9 = 1/2";
                Definition_Word = "x = 2/3 , y = -3/4";
                Miss_01 = "x = -2/3 , y = 3/4";
                Miss_02 = "x = -2/3 , y = -3/4";
                Miss_03 = "x = 3/4 , y = -2/3";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_10()
        {
            Kakko_Image.Visibility = Visibility.Hidden;
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "y = 2x + 8について\nx = -5のときのyの値を求めよ";
                Definition_Word = "y = -2";
                Miss_01 = "y = 2";
                Miss_02 = "y = 13";
                Miss_03 = "y = -13";
            }
            else if (r2 == 2)
            {
                Question_Word = "y = x/4 + 4について\nx = 16のときのyの値を求めよ";
                Definition_Word = "y = 8";
                Miss_01 = "y = -8";
                Miss_02 = "y = 2";
                Miss_03 = "y = -2";
            }
            else if (r2 == 3)
            {
                Question_Word = "y = 3x/5 + 7について\nx = 20のときのyの値を求めよ";
                Definition_Word = "y = 19";
                Miss_01 = "y = -19";
                Miss_02 = "y = 5";
                Miss_03 = "y = -5";
            }
            else if (r2 == 4)
            {
                Question_Word = "3y = 7x - 2について\nx = -4のときのyの値を求めよ";
                Definition_Word = "y = -10";
                Miss_01 = "y = 10";
                Miss_02 = "y = -26";
                Miss_03 = "y = 26";
            }
            else if (r2 == 5)
            {
                Question_Word = "2y = x/2 + 8について\nx = 8のときのyの値を求めよ";
                Definition_Word = "y = 6";
                Miss_01 = "y = -6";
                Miss_02 = "y = 2";
                Miss_03 = "y = -2";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_11()
        {
            int Answer;
            Text_01_T.FontSize = 50;
            Text_02_T.FontSize = 50;
            Random r = new Random();
            int r2 = r.Next(-9999, 10000);
            int r3 = r.Next(1, 10000);
            Question_Word = "y = " + r2 + " + " + r3;
            Answer = r2 + r3;
            Answer_Question("y = " + Answer, "y = " + (Answer + 2), "y = " + (Answer + 3), "y = " + (Answer + 1));
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_12()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "x = -2のとき,y = 17でx = 1のとき,y = -1となる一次関数の式を求めよ";
                Definition_Word = "y = -6x + 5";
                Miss_01 = "y = -4x + 5";
                Miss_02 = "y = 6x + 2";
                Miss_03 = "y = 4x - 5";
            }
            else if (r2 == 2)
            {
                Question_Word = "x = -3のとき,y = 13でx = 9のとき,y = -11となる一次関数の式を求めよ";
                Definition_Word = "y = -2x + 7";
                Miss_01 = "y = 2x - 7";
                Miss_02 = "y = 5x - 3";
                Miss_03 = "y = -5x + 3";
            }
            else if (r2 == 3)
            {
                Question_Word = "x = 5のとき,y = 9でx = 9のとき,y = 29となる一次関数の式を求めよ";
                Definition_Word = "y = 5x - 16";
                Miss_01 = "y = -5x + 16";
                Miss_02 = "y = 3x + 8";
                Miss_03 = "y = -3x - 8";
            }
            else if (r2 == 4)
            {
                Question_Word = "x = 3のとき,y = -4でx = 9のとき,y = 26となる一次関数の式を求めよ";
                Definition_Word = "y = 5x -19";
                Miss_01 = "y = -5x + 19";
                Miss_02 = "y = 8x + 11";
                Miss_03 = "y = -8x - 11";
            }
            else if (r2 == 5)
            {
                Question_Word = "x = 7のとき,y = -4でx = 9のとき,y = 12となる一次関数の式を求めよ";
                Definition_Word = "y = 8x -60";
                Miss_01 = "y = -8x + 60";
                Miss_02 = "y = 4x - 15";
                Miss_03 = "y = -4x + 15";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_13()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            IsImageUse = false;
            if (r2 == 1)
            {
                Question_Word = "次の2点から1次関数の式を出せ\n(3 , 2) , (6 , 6)";
                Definition_Word = "y = 4/3x - 2";
                Miss_01 = "y = -4/3x - 2";
                Miss_02 = "y = 4/3x + 2";
                Miss_03 = "y = -4/3x + 2";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の2点から1次関数の式を出せ\n(1 , 6) , (3 , 2)";
                Definition_Word = "y = -2x + 8";
                Miss_01 = "y = 2x + 8";
                Miss_02 = "y = -2x - 8";
                Miss_03 = "y =2x - 8";
            }
            else if (r2 == 3)
            {
                Question_Word = "画像の2点から1次関数の式を出せ";
                Definition_Word = "y = −2x + 8";
                Miss_01 = "y = 2x + 8";
                Miss_02 = "y = -2x - 8";
                Miss_03 = "y = 2x - 8";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_013_01.png";
                IsImageUse = true;
            }
            else if (r2 == 4)
            {
                Question_Word = "次の2点から1次関数の式を出せ\n(2 , -1) (4 , -13)";
                Definition_Word = "y = -6x + 11";
                Miss_01 = "y = 6x + 11";
                Miss_02 = "y = -6x - 11";
                Miss_03 = "y = 6x - 11";
            }
            else if (r2 == 5)
            {
                Question_Word = "次の2点から1次関数の式を出せ\n(−1 , 3) , ( 5 , 0)";
                Definition_Word = "y = -1/2 + 5/2";
                Miss_01 = "y = 1/2 + 5/2";
                Miss_02 = "y = -1/2 - 5/2";
                Miss_03 = "y = 1/2 - 5/2";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
        }
        void Question_Grade_02_Number_14()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "１次関数y = 2x - 3でxの変域が-1≦x≦4のときのyの変域を求めよ";
                Definition_Word = "-5 ≦ y ≦ 5";
                Miss_01 = "-2 ≦ y ≦ 8";
                Miss_02 = "-1 ≦ y ≦ 5";
                Miss_03 = "-11 ≦ y ≦ -5";
            }
            else if (r2 == 2)
            {
                Question_Word = "y = 5x + 1でxの変域が-2≦x≦3のときのyの変域を求めよ";
                Definition_Word = "-9 ≦ y ≦ 16";
                Miss_01 = "11 ≦ y ≦ 16";
                Miss_02 = "-10 ≦ y ≦ 15";
                Miss_03 = "15 ≦ y ≦ 16";
            }
            else if (r2 == 3)
            {
                Question_Word = "y = -3x + 4でxの変域が-2≦x≦3のときのyの変域を求めよ";
                Definition_Word = "-5 ≦ y ≦ 10";
                Miss_01 = "-5 ≦ y ≦ -2";
                Miss_02 = "-2 ≦ y ≦ 10";
                Miss_03 = "10 ≦ y ≦ 13";
            }
            else if (r2 == 4)
            {
                Question_Word = "y = ax + bにおいてa > 0でxの変域が-1≦x≦3、yの変域-5≦y≦7のときa,bの値をそれぞれ求めよ";
                Definition_Word = "a = 3 , b = -2";
                Miss_01 = "a = -3 , b = 2";
                Miss_02 = "a = 3 , b = -2";
                Miss_03 = "a = -3 , b = -2";
            }
            else if (r2 == 5)
            {
                Question_Word = "y = ax + bにおいてa < 0でxの変域が-2≦x≦4,yの変域1≦y≦13のときa,bの値をそれぞれ求めよ";
                Definition_Word = "a = -2 , b = 9";
                Miss_01 = "a = 2 , b = 9";
                Miss_02 = "a = -2 , b = -9";
                Miss_03 = "a = 2 , b = -9";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_15()
        {
            Text_01_T.FontSize = 32;
            Text_02_T.FontSize = 32;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "y = 2x + 3 と y = -3x + 1の交点を求めよ";
                Definition_Word = "(-2/5,11/5)";
                Miss_01 = "(-2,11)";
                Miss_02 = "(-5/2,5/11)";
                Miss_03 = "(5/11,-5/2)";
            }
            else if (r2 == 2)
            {
                Question_Word = "y = 3x + 2 と y = 5x - 8の交点を求めよ";
                Definition_Word = "(5,17)";
                Miss_01 = "(17,5)";
                Miss_02 = "(-5,-17)";
                Miss_03 = "(-5,17)";
            }
            else if (r2 == 3)
            {
                Question_Word = "次の直線の式を求めよ\n直線x - 2y + 14 = 0と4x + 3y + 1 = 0の交点を通りx軸と平行";
                Definition_Word = "y = 5";
                Miss_01 = "y = -5";
                Miss_02 = "y = -4";
                Miss_03 = "y = 4";
            }
            else if (r2 == 4)
            {
                Question_Word = "y = 5x - 7 と y = 4x + 5の交点を求めよ";
                Definition_Word = "(12,53)";
                Miss_01 = "(53,12)";
                Miss_02 = "(-12,-53)";
                Miss_03 = "(-53,-12)";
            }
            else if (r2 == 5)
            {
                Question_Word = "次の直線の式を求めよ\n3点(-1 , 2p),(2 , p-4),(5 , 6p)が一直線上にあるときのpの値を求めよ";
                Definition_Word = "p = -4/3";
                Miss_01 = "p = 4/3";
                Miss_02 = "p = 2/3";
                Miss_03 = "p = -2/3";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_16()
        {
            //動く点P
            Text_01_T.FontSize = 30;
            Text_02_T.FontSize = 30;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "AB=8cm, BC=16cmの長方形ABCDがあり、点PはAを出発して毎秒2cmでA→B→C→Dと進む。\n出発から7秒後の△APDの面積を求めよ";
                Definition_Word = "64cm^2";
                Miss_01 = "128cm^2";
                Miss_02 = "24cm^2";
                Miss_03 = "32cm^2";
            }
            else if (r2 == 2)
            {
                Question_Word = "AB=8cm, BC=16cmの長方形ABCDがあり、点PはAを出発して毎秒2cmでA→B→C→Dと進む。\n出発から11秒後の△APDの面積を求めよ";
                Definition_Word = "64cm^2";
                Miss_01 = "32cm^2";
                Miss_02 = "8cm^2";
                Miss_03 = "11cm^2";
            }
            else if (r2 == 3)
            {
                Question_Word = "AB=8cm, BC=16cmの長方形ABCDがあり、点PはAを出発して毎秒2cmでA→B→C→Dと進む。\n出発から3秒後の△APDの面積を求めよ";
                Definition_Word = "48cm^2";
                Miss_01 = "96cm^2";
                Miss_02 = "24cm^2";
                Miss_03 = "36cm^2";
            }
            else if (r2 == 4)
            {
                Question_Word = "AB=8cm, BC=16cmの長方形ABCDがあり、点PはAを出発して毎秒3cmでA→B→C→Dと進む。\n出発から8秒後の△APDの面積を求めよ";
                Definition_Word = "0cm^2";
                Miss_01 = "2cm^2";
                Miss_02 = "4cm^2";
                Miss_03 = "6cm^2";
            }
            else if (r2 == 5)
            {
                Question_Word = "AB=5cm, BC=13cmの長方形ABCDがあり、点PはAを出発して毎秒1cmでA→B→C→Dと進む。\n出発から4秒後の△APDの面積を求めよ";
                Definition_Word = "26cm^2";
                Miss_01 = "52cm^2";
                Miss_02 = "13cm^2";
                Miss_03 = "4cm^2";
            }
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_016_01.png";
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_02_Number_17()
        {
            Text_01_T.FontSize = 30;
            Text_02_T.FontSize = 30;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "AB=10cm, BC=15cmの長方形ABCDがあり、点PはAを出発して毎秒2cmでA→B→C→Dと進む。\n出発からx秒後の△APDの面積yを求めよ\nただし、xは5以下とする。";
                Definition_Word = "y = 15x / 2";
                Miss_01 = "y = 15x";
                Miss_02 = "y = 5x / 2";
                Miss_03 = "5x";
            }
            else if (r2 == 2)
            {
                Question_Word = "AB=10cm, BC=15cmの長方形ABCDがあり、点PはAを出発して毎秒2cmでA→B→C→Dと進む。\n出発からx秒後の△APDの面積yを求めよ\nただし、xは5以上12以下とする。";
                Definition_Word = "y = 75";
                Miss_01 = "y = 150";
                Miss_02 = "y = 150x / 2";
                Miss_03 = "y = 17x";
            }
            else if (r2 == 3)
            {
                Question_Word = "AB=10cm, BC=15cmの長方形ABCDがあり、点PはAを出発して毎秒2cmでA→B→C→Dと進む。\n出発からx秒後の△APDの面積yを求めよ\nただし、xは13以上17以下とする。";
                Definition_Word = "y = 15 X (10 - 2x) / 2";
                Miss_01 = "y = 15 X (10 - x)";
                Miss_02 = "y = 15 X (10 -2x)";
                Miss_03 = "y = 15 X (10 - x) / 2";
            }
            else if (r2 == 4)
            {
                Question_Word = "AB=7cm, BC=17cmの長方形ABCDがあり、点PはAを出発して毎秒2cmでA→B→C→Dと進む。\n出発からx秒後の△APDの面積yの変域を求めよ\nただし、xは1以上15以下とする。";
                Definition_Word = "17cm^2 < ycm^2 < 119 / 2 cm^2";
                Miss_01 = "17cm^2 < ycm^2 < 119cm^2";
                Miss_02 = "34cm^2 < ycm^2 < 119 / 2 cm^2";
                Miss_03 = "34cm^2 < ycm^2 < 119cm^2";
            }
            else if (r2 == 5)
            {
                Question_Word = "AB=6cm, BC=20cmの長方形ABCDがあり、点PはAを出発して毎秒4cmでA→B→C→Dと進む。\n出発からx秒後の△APDの面積yの変域を求めよ\nただし、xは1以上8以下とする。";
                Definition_Word = "40cm^2 < ycm^2 < 60 cm^2";
                Miss_01 = "40cm^2 < ycm^2 < 120cm^2";
                Miss_02 = "80cm^2 < ycm^2 < 60 cm^2";
                Miss_03 = "80cm^2 < ycm^2 < 120cm^2";
            }
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_016_01.png";
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_02_Number_18()
        {
            Text_01_T.FontSize = 50;
            Text_02_T.FontSize = 50;
            //同位角
            Random r2 = new Random();
            int r3 = r2.Next(50, 78);
            Question_Word = "x =" + r3 + "°のときyの角度を求めよ";
            string Answer;
            string Miss_01;
            string Miss_02;
            string Miss_03;
            Answer = r3 + "°";
            Miss_01 = (r3 + 2) + "°";
            Miss_02 = (r3 + 7) + "°";
            Miss_03 = (r3 + 5) + "°";
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_018_01.png";
            Answer_Question(Answer, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_02_Number_19()
        {
            Text_01_T.FontSize = 50;
            Text_02_T.FontSize = 50;
            //錯角
            Random r2 = new Random();
            int r3 = r2.Next(50, 78);
            Question_Word = "x =" + r3 + "°のときyの角度を求めよ";
            string Answer;
            string Miss_01;
            string Miss_02;
            string Miss_03;
            Answer = r3 + "°";
            Miss_01 = (r3 + 2) + "°";
            Miss_02 = (r3 + 7) + "°";
            Miss_03 = (r3 + 5) + "°";
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_019_01.png";
            Answer_Question(Answer, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_02_Number_20()
        {
            Text_01_T.FontSize = 50;
            Text_02_T.FontSize = 50;
            //内角
            Random r2 = new Random();
            int r3 = r2.Next(60, 83);
            int r4 = 130 - r3;
            Question_Word = "x = 50°,z =" + r4 + "°のときyの角度を求めよ";
            string Answer;
            string Miss_01;
            string Miss_02;
            string Miss_03;
            Answer = r3 + "°";
            Miss_01 = (r3 + 2) + "°";
            Miss_02 = (r3 + 3) + "°";
            Miss_03 = (r3 + 5) + "°";
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_020_01.png";
            Answer_Question(Answer, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_02_Number_21()
        {
            Text_01_T.FontSize = 50;
            Text_02_T.FontSize = 50;
            //外角
            Random r2 = new Random();
            int r3 = r2.Next(65, 86);
            int r4 = r2.Next(30, 40);
            Question_Word = "x =" + r3 + "°,z =" + r4 + "°のときyの角度を求めよ";
            string Answer;
            string Miss_01;
            string Miss_02;
            string Miss_03;
            Answer = (r3 + r4) + "°";
            Miss_01 = (r3 + r4 + 2) + "°";
            Miss_02 = (r3 + r4 + 3) + "°";
            Miss_03 = (r3 + r4 + 5) + "°";
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_021_01.png";
            Answer_Question(Answer, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_02_Number_22()
        {
            Text_01_T.FontSize = 32;
            Text_02_T.FontSize = 32;
            Random r = new Random();
            int r1 = r.Next(10, 81);
            int r2 = r1 * 2;
            int Miss_01;
            int Miss_02;
            int Miss_03;
            Question_Word = "A = " + r2 + "のときxの大きさを求めよ。ただし同じ印をつけた辺は等しいとする\n画像の角の大きさは考慮しない";
            if (IsDecimal((180 - r2) / 2))
            {
                Question_Grade_02_Number_22();
                return;
            }
            else
            {
                Definition_Word = ((180 - r2) / 2).ToString();
                Miss_01 = (180 - r2) / 2 - 2;
                Miss_02 = (180 - r2) / 2 + 2;
                Miss_03 = (180 - r2) / 2 + 4;
            }
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_022_01.png";
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_02_Number_23()
        {
            Text_01_T.FontSize = 32;
            Text_02_T.FontSize = 32;
            Random r = new Random();
            int r2 = r.Next(2, 81);
            Question_Word = "A = " + r2 + "のときxの大きさを求めよ。ただし同じ印をつけた辺は等しいとする\n画像の角の大きさは考慮しない";
            Definition_Word = (180 - (r2 * 2)).ToString();
            int Miss_01 = 180 - (r2 * 2) - 2;
            int Miss_02 = 180 - (r2 * 2) + 2;
            int Miss_03 = 180 - (r2 * 2) + 4;
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_023_01.png";
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_02_Number_24()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "3角形の内角の和は何度か答えよ";
                Definition_Word = "180°";
                Miss_01 = "90°";
                Miss_02 = "360°";
                Miss_03 = "n°";
            }
            else if (r2 == 2)
            {
                Question_Word = "n角形の外角の和は何度か答えよ";
                Definition_Word = "360°";
                Miss_01 = "90°";
                Miss_02 = "180°";
                Miss_03 = "n°";
            }
            else if (r2 == 3)
            {
                Question_Word = "n角形の内角の和は何度か答えよ";
                Definition_Word = "180(n - 2)";
                Miss_01 = "180n";
                Miss_02 = "90(n - 2)";
                Miss_03 = "90n";
            }
            else if (r2 == 4)
            {
                Question_Word = "正九角形の一つの外角は何度か求めよ";
                Definition_Word = "40°";
                Miss_01 = "10°";
                Miss_02 = "20°";
                Miss_03 = "30°";
            }
            else if (r2 == 5)
            {
                Question_Word = "十二角形の内角の和を求めよ";
                Definition_Word = "1800°";
                Miss_01 = "1440°";
                Miss_02 = "2160°";
                Miss_03 = "1620°";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_25()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "画像のxは何度か求めよ\nただし同じ印がついている角は等しいとする";
                Definition_Word = "25°";
                Miss_01 = "50°";
                Miss_02 = "35°";
                Miss_03 = "40°";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_025_01.png";
            }
            else if (r2 == 2)
            {
                Question_Word = "画像のxは何度か求めよ\nただし同じ印がついている角は等しいとする";
                Definition_Word = "115°";
                Miss_01 = "100°";
                Miss_02 = "110°";
                Miss_03 = "120°";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_025_02.png";
            }
            else if (r2 == 3)
            {
                Question_Word = "画像のxは何度か求めよ";
                Definition_Word = "32°";
                Miss_01 = "40°";
                Miss_02 = "35°";
                Miss_03 = "18°";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_025_03.png";
            }
            else if (r2 == 4)
            {
                Question_Word = "画像のxは何度か求めよ";
                Definition_Word = "75°";
                Miss_01 = "65°";
                Miss_02 = "55°";
                Miss_03 = "60°";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_025_04.png";
            }
            else if (r2 == 5)
            {
                Question_Word = "画像のxは何度か求めよ";
                Definition_Word = "38°";
                Miss_01 = "55°";
                Miss_02 = "40°";
                Miss_03 = "29°";
                Math_Image_Source = Path + "/Resources/BG/Math/Grade_02/Number_025_05.png";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_02_Number_26()
        {
            Text_01_T.FontSize = 45;
            Text_02_T.FontSize = 45;
            double Answer;
            string Answer_0;
            Random r = new Random();
            int r_1 = r.Next(2, 7);
            Question_Word = "このコインを" + r_1 + "回投げる場合\n" + r_1 + "回とも表が出る場合";
            Answer = Math.Pow(2, r_1);
            Answer_0 = "1/" + Answer;
            Answer_Question(Answer_0.ToString(), "1/" + (Answer + 2), "1/" + (Answer + 4), "1/" + (Answer - 2));
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_27()
        {
            //3 = 8通り = 3/8
            //4 = 16通り = 5/16
            Text_01_T.FontSize = 50;
            Text_02_T.FontSize = 50;
            Random r = new Random();
            int r_1 = r.Next(3, 5);
            int r_2;
            string Answer_0 = "";
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            r_2 = r_1 - 1;
            Question_Word = "このコインを" + r_1 + "回投げる場合\n" + r_2 + "回とも表が出る場合";
            if (r_1 == 3)
            {
                Answer_0 = "3/8";
                Miss_01 = "1/2";
                Miss_02 = "5/16";
                Miss_03 = "2/5";
            }
            else if (r_1 == 4)
            {
                Answer_0 = "1/4";
                Miss_01 = "4/9";
                Miss_02 = "1/2";
                Miss_03 = "2/5";
            }
            Answer_Question(Answer_0.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_28()
        {
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Question_Word = "半径4cmの球の表面積を求めよ";
                Definition_Word = "64πcm^2";
                Miss_01 = "86πcm^2";
                Miss_02 = "32πcm^2";
                Miss_03 = "56πcm^2";
            }
            else if (r2 == 2)
            {
                Question_Word = "半径5cmの球の体積を求めよ";
                Definition_Word = "500/3cm^3";
                Miss_01 = "355πcm^3";
                Miss_02 = "400/3πcm^3";
                Miss_03 = "225πcm^3";
            }
            else if (r2 == 3)
            {
                Question_Word = "底面の面積が15cm,高さ6cmの三角錐の体積を求めよ";
                Definition_Word = "30cm^3";
                Miss_01 = "90cm^3";
                Miss_02 = "45cm^3";
                Miss_03 = "40cm^3";
            }
            else if (r2 == 4)
            {
                Question_Word = "母線6cm,直径8cmの円錐の表面積を求めよ";
                Definition_Word = "40πcm^2";
                Miss_01 = "44πcm^2";
                Miss_02 = "32πcm^2";
                Miss_03 = "30πcm^2";
            }
            else if (r2 == 5)
            {
                Question_Word = "底面20cm,高さ9cm四角錐の体積を求めよ";
                Definition_Word = "60cm^3";
                Miss_01 = "90cm^3";
                Miss_02 = "45cm^3";
                Miss_03 = "75cm^3";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_29()
        {
            Text_01_T.FontSize = 35;
            Text_02_T.FontSize = 35;
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Question_Word = "一次関数5y = 30x + 10とy = 3x - 8の交点を求めよ";
                Definition_Word = "(-10/3,-18)";
                Miss_01 = "(10/3,18)";
                Miss_02 = "(-10,-18)";
                Miss_03 = "(10,18)";
            }
            else if (r2 == 2)
            {
                Question_Word = "一次関数5y = 30x + 10とy = 4x - 7の交点を求めよ";
                Definition_Word = "(-9/2,-25)";
                Miss_01 = "(9/2,25)";
                Miss_02 = "(-9,-25)";
                Miss_03 = "(9,25)";
            }
            else if (r2 == 3)
            {
                Question_Word = "一次関数5y = 30x + 10とy = 5x - 6の交点を求めよ";
                Definition_Word = "(-8,-46)";
                Miss_01 = "(8,46)";
                Miss_02 = "(-8,46)";
                Miss_03 = "(8,-46)";
            }
            else if (r2 == 4)
            {
                Question_Word = "一次関数6y = 36x + 12とy = 5x - 6の交点を求めよ";
                Definition_Word = "(-8,-46)";
                Miss_01 = "(8,46)";
                Miss_02 = "(-8,46)";
                Miss_03 = "(8,-46)";
            }
            else if (r2 == 5)
            {
                Question_Word = "一次関数7y = 28x + 14とy = 5x - 6の交点を求めよ";
                Definition_Word = "(8,34)";
                Miss_01 = "(-8,-34)";
                Miss_02 = "(-8,34)";
                Miss_03 = "(8,-34)";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_02_Number_30()
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
                Question_Word = "y = ax + bのxの変域,2<x<4のとき\nyの変域を求めよ";
                Definition_Word = "2a + b<y<4a + b";
                Miss_01 = "2a - b<y<4a - b";
                Miss_02 = "2a + b<y<4a - b";
                Miss_03 = "2a - b<y<4a + b";
            }
            else if (r2 == 2)
            {
                Question_Word = "y = ax + bのxの変域,-2<x<4のとき\nyの変域を求めよ";
                Definition_Word = "-2a + b<y<4a + b";
                Miss_01 = "-2a - b<y<4a - b";
                Miss_02 = "-2a + b<y<4a - b";
                Miss_03 = "-2a - b<y<4a + b";
            }
            else if (r2 == 3)
            {
                Question_Word = "y = ax + bのxの変域,2<x<8のとき\nyの変域を求めよ";
                Definition_Word = "2a + b<y<8a + b";
                Miss_01 = "2a - b<y<8a - b";
                Miss_02 = "2a + b<y<8a - b";
                Miss_03 = "2a - b<y<8a + b";
            }
            else if (r2 == 4)
            {
                Question_Word = "y = ax + bのxの変域,2<x<-8のとき\nyの変域を求めよ";
                Definition_Word = "2a + b<y<-8a + b";
                Miss_01 = "2a - b<y<-8a - b";
                Miss_02 = "2a + b<y<-8a - b";
                Miss_03 = "2a - b<y<-8a + b";
            }
            else if (r2 == 5)
            {
                Question_Word = "y = ax + bのxの変域,3<x<-8のとき\nyの変域を求めよ";
                Definition_Word = "3a + b<y<-8a + b";
                Miss_01 = "3a - b<y<-8a - b";
                Miss_02 = "3a + b<y<-8a - b";
                Miss_03 = "3a - b<y<-8a + b";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
    }
}