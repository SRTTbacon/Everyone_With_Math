using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Everyone_With_Math.Class
{
    public partial class Math_01 : Window
    {
        //3学年の問題を定義
        bool Question_03_01_Answer;
        bool Question_03_02_Answer;
        bool Question_03_03_Answer;
        bool Question_03_04_Answer;
        bool Question_03_05_Answer;
        bool Question_03_06_Answer;
        bool Question_03_07_Answer;
        bool Question_03_08_Answer;
        bool Question_03_09_Answer;
        bool Question_03_10_Answer;
        bool Question_03_11_Answer;
        bool Question_03_12_Answer;
        bool Question_03_13_Answer;
        bool Question_03_14_Answer;
        bool Question_03_15_Answer;
        bool Question_03_16_Answer;
        bool Question_03_17_Answer;
        bool Question_03_18_Answer;
        bool Question_03_19_Answer;
        bool Question_03_20_Answer;
        bool Question_03_21_Answer;
        bool Question_03_22_Answer;
        bool Question_03_23_Answer;
        bool Question_03_24_Answer;
        bool Question_03_25_Answer;
        bool Question_03_26_Answer;
        bool Question_03_27_Answer;
        bool Question_03_28_Answer;
        bool Question_03_29_Answer;
        bool Question_03_30_Answer;
        int Difficult_Question_Number = 1;
        bool Difficult_Question_Number_01_Correct = false;
        bool Difficult_Question_Number_02_Correct = false;
        bool Difficult_Question_Number_03_Correct = false;
        bool Difficult_Question_Number_04_Correct = false;
        bool Difficult_Question_Number_05_Correct = false;
        string Difficult_Question_Number_01_String = "";
        string Difficult_Question_Number_02_String = "";
        string Difficult_Question_Number_03_String = "";
        string Difficult_Question_Number_04_String = "";
        void Question_Grade_03_Number_01()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Random r = new Random();
            int r3 = r.Next(2, 11);
            int r4 = r.Next(2, 11);
            int r5 = r.Next(2, 11);
            int r6 = r.Next(2, 11);
            if (r3 == r5)
            {
                Question_Grade_03_Number_01();
                return;
            }
            Question_Word = "次の式を展開せよ\n(" + r3 + "x +" + r4 + ")(" + r5 + "x +" + r6 + ")";
            Definition_Word = (r3 * r5) + "x^2 + " + (r3 * r6 + r4 * r5) + "x + " + r4 * r6;
            string Miss_01 = r3 * r5 + "x^2 + " + (r4 + r6) + "x + " + r4 * r6;
            string Miss_02 = r3 * r5 + "x^2 + " + ((r4 + r6) * r3) + "x + " + r4 * r6;
            string Miss_03 = r3 * r5 + "x^2 + " + ((r4 + r6) * r5) + "x + " + r4 * r6;
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_02()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(3, 22);
            if (r2 == 0)
            {
                Question_Grade_03_Number_02();
                return;
            }
            Question_Word = "次の式を展開せよ\n(x" + " + " + r2 + ")^2";
            Definition_Word = "x^2 + " + (r2 + r2) + "x + " + Math.Pow(r2, 2);
            Miss_01 = "x^2 + " + Math.Pow(r2, 2);
            Miss_02 = "x^2 + " + Math.Pow(r2, 2) + "x + " + Math.Pow(r2, 2);
            Miss_03 = "2x^2 + " + (r2 + r2) + "x + " + Math.Pow(r2, 2);
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_03()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 21);
            if (r2 == 0)
            {
                Question_Grade_03_Number_03();
                return;
            }
            Question_Word = "次の式を展開せよ\n(x + " + r2 + ") (x - " + r2 + ")";
            Definition_Word = "x^2 - " + Math.Pow(r2, 2);
            Miss_01 = "x^2 + " + (r2 + r2) + " - " + Math.Pow(r2, 2);
            Miss_02 = "x^2 - " + (r2 + r2) + " - " + Math.Pow(r2, 2);
            Miss_03 = "x^2 + " + Math.Pow(r2, 2);
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_04()
        {
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Question_Word = "次の式を因数分解せよ\nx^2 + 5x + 6";
                Definition_Word = "(x + 3)(x + 2)";
                Miss_01 = "(x + 4)(x + 2)";
                Miss_02 = "(x - 3)(x - 2)";
                Miss_03 = "(x - 4)(x - 2)";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の式を因数分解せよ\nx^2 + 2x - 15";
                Definition_Word = "(x + 5)(x - 3)";
                Miss_01 = "(x + 4)(x + 7)";
                Miss_02 = "(x + 5)(x - 3)";
                Miss_03 = "(x - 4)(x - 7)";
            }
            else if (r2 == 3)
            {
                Question_Word = "次の式を因数分解せよ\nx^2 - 10x + 21";
                Definition_Word = "(x - 3)(x - 7)";
                Miss_01 = "(x + 5)(x + 2)";
                Miss_02 = "(x + 3)(x + 7)";
                Miss_03 = "(x - 5)(x - 2)";
            }
            else if (r2 == 4)
            {
                Question_Word = "次の式を因数分解せよ\nx^2 + x - 12";
                Definition_Word = "(x - 3)(x + 4)";
                Miss_01 = "(x + 4)(x + 2)";
                Miss_02 = "(x + 3)(x - 4)";
                Miss_03 = "(x - 4)(x - 2)";
            }
            else if (r2 == 5)
            {
                Question_Word = "次の式を因数分解せよ\nx^2 + 9x + 14";
                Definition_Word = "(x + 2)(x + 7)";
                Miss_01 = "(x + 4)(x + 5)";
                Miss_02 = "(x - 2)(x - 7)";
                Miss_03 = "(x - 4)(x - 5)";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_05()
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
                Question_Word = "次の式を因数分解せよ\na(x + y) - 5(x + y)";
                Definition_Word = "(x + y)(a - 5)";
                Miss_01 = "(x - y)(a - 5)";
                Miss_02 = "(x + y)(a + 5)";
                Miss_03 = "(x - 5)(a + 5)";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の式を因数分解せよ\n(a + 2)(a + 3) - 78";
                Definition_Word = "(a - 7)(a + 12)";
                Miss_01 = "(a + 7)(a - 12)";
                Miss_02 = "(a + 6)(a - 13)";
                Miss_03 = "(a - 6)(a + 13)";
            }
            else if (r2 == 3)
            {
                Choice_01_T.FontSize = 30;
                Choice_02_T.FontSize = 30;
                Choice_03_T.FontSize = 30;
                Choice_04_T.FontSize = 30;
                Question_Word = "次の式を因数分解せよ\n(a + b)^2 - (x + y)^2";
                Definition_Word = "(a + b + x + y)(a + b - x - y)";
                Miss_01 = "(a^2 + 2ab + b^2) - (x^2 + 2xy + y^2)";
                Miss_02 = "{(a + b)(x - y)}^2";
                Miss_03 = "(a + b)^2 + (x + y)(x - y)";
            }
            else if (r2 == 4)
            {
                Question_Word = "次の式を因数分解せよ\n3a + 3c";
                Definition_Word = "3(a + c)";
                Miss_01 = "ac(3 + 3)";
                Miss_02 = "6(a + c)";
                Miss_03 = "(3a + 3c)";
            }
            else if (r2 == 5)
            {
                Question_Word = "次の式を因数分解せよ\n2x^2 - 18x";
                Definition_Word = "2x(x - 9)";
                Miss_01 = "x(2x - 18)";
                Miss_02 = "(2x^2 - 18x)";
                Miss_03 = "2x(x - 9x)";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_06()
        {
            Choice_01_T.FontSize = 36;
            Choice_02_T.FontSize = 36;
            Choice_03_T.FontSize = 36;
            Choice_04_T.FontSize = 36;
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Question_Word = "45を素因数分解せよ";
                Definition_Word = "3^2 × 5";
                Miss_01 = "5 × 9";
                Miss_02 = "-5 × -9";
                Miss_03 = "3 × 15";
            }
            else if (r2 == 2)
            {
                Question_Word = "18を素因数分解せよ";
                Definition_Word = "2 × 3^2";
                Miss_01 = "2 × 9";
                Miss_02 = "3 × 6";
                Miss_03 = "-3 × -6";
            }
            else if (r2 == 3)
            {
                Question_Word = "24を素因数分解せよ";
                Definition_Word = "2^3 × 3";
                Miss_01 = "4 × 6";
                Miss_02 = "3 × 8";
                Miss_03 = "-3 × -8";
            }
            else if (r2 == 4)
            {
                Question_Word = "9を素因数分解せよ";
                Definition_Word = "3^2";
                Miss_01 = "-3^2";
                Miss_02 = "-9";
                Miss_03 = "素因数分解できない";
            }
            else if (r2 == 5)
            {
                Question_Word = "4を素因数分解せよ";
                Definition_Word = "2^2";
                Miss_01 = "-2^2";
                Miss_02 = "-4";
                Miss_03 = "素因数分解できない";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_07()
        {
            Text_01_T.FontSize = 45;
            Text_02_T.FontSize = 45;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (r2 == 1)
            {
                Question_Word = "4の平方根を求めよ";
                Definition_Word = "±2";
                Miss_01 = "2";
                Miss_02 = "-2";
                Miss_03 = "±4";
            }
            else if (r2 == 2)
            {
                Question_Word = "49の平方根を求めよ";
                Definition_Word = "±7";
                Miss_01 = "7";
                Miss_02 = "-7";
                Miss_03 = "±49";
            }
            else if (r2 == 3)
            {
                Question_Word = "100の平方根を求めよ";
                Definition_Word = "±10";
                Miss_01 = "10";
                Miss_02 = "-10";
                Miss_03 = "±100";
            }
            else if (r2 == 4)
            {
                Question_Word = "225の平方根を求めよ";
                Definition_Word = "±15";
                Miss_01 = "15";
                Miss_02 = "-15";
                Miss_03 = "±225";
            }
            else if (r2 == 5)
            {
                Question_Word = "0.04の平方根を求めよ";
                Definition_Word = "±0.2";
                Miss_01 = "0.2";
                Miss_02 = "-0.2";
                Miss_03 = "±0.04";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_08()
        {
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Random r = new Random();
            int r2 = r.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r2 == 1)
            {
                Question_Word = "√3と1のどっちが大きいか";
                Definition_Word = "√3 > 1";
                Miss_01 = "√3 < 1";
                Miss_02 = "√3 = 1";
                Miss_03 = "√3 ≧ 1";
            }
            else if (r2 == 2)
            {
                Question_Word = "√5と2のどっちが大きいか";
                Definition_Word = "√5 > 2";
                Miss_01 = "√5 < 2";
                Miss_02 = "√5 = 2";
                Miss_03 = "√5 ≧ 2";
            }
            else if (r2 == 3)
            {
                Question_Word = "√9と3のどっちが大きいか";
                Definition_Word = "√9 = 3";
                Miss_01 = "√9 < 3";
                Miss_02 = "√9 > 3";
                Miss_03 = "√9 ≧ 3";
            }
            else if (r2 == 4)
            {
                Question_Word = "√12と4のどっちが大きいか";
                Definition_Word = "√12 < 4";
                Miss_01 = "√12 > 4";
                Miss_02 = "√12 = 4";
                Miss_03 = "√12 ≧ 4";
            }
            else if (r2 == 5)
            {
                Question_Word = "√10と3のどっちが大きいか";
                Definition_Word = "√10 > 3";
                Miss_01 = "√10 < 3";
                Miss_02 = "√10 = 3";
                Miss_03 = "√10 ≧ 3";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_09()
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
                Question_Word = "次の式を計算せよ\n4√2 + 5√2";
                Definition_Word = "9√2";
                Miss_01 = "9√4";
                Miss_02 = "18";
                Miss_03 = "9";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の式を計算せよ\n9√7 - 3√7";
                Definition_Word = "6√7";
                Miss_01 = "6√14";
                Miss_02 = "12√7";
                Miss_03 = "12√14";
            }
            else if (r2 == 3)
            {
                Question_Word = "次の式を計算せよ\n5√3 + 8√3";
                Definition_Word = "13√3";
                Miss_01 = "12√3";
                Miss_02 = "12";
                Miss_03 = "3";
            }
            else if (r2 == 4)
            {
                Question_Word = "次の式を計算せよ\n3√5 - 10√5";
                Definition_Word = "-7√5";
                Miss_01 = "13√5";
                Miss_02 = "-7√10";
                Miss_03 = "13√10";
            }
            else if (r2 == 5)
            {
                Question_Word = "次の式を計算せよ\n7√6 + 9√6";
                Definition_Word = "16√6";
                Miss_01 = "16√6";
                Miss_02 = "16";
                Miss_03 = "2";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_10()
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
                Question_Word = "次の式を計算せよ\n3√2 × 4√3";
                Definition_Word = "12√6";
                Miss_01 = "7√6";
                Miss_02 = "12√2";
                Miss_03 = "12√3";
            }
            if (r2 == 2)
            {
                Question_Word = "次の式を計算せよ\n4√2 × 5√2";
                Definition_Word = "40";
                Miss_01 = "20√4";
                Miss_02 = "20";
                Miss_03 = "40√2";
            }
            if (r2 == 3)
            {
                Question_Word = "次の式を計算せよ\n2√3 × 2√3";
                Definition_Word = "12";
                Miss_01 = "4√9";
                Miss_02 = "4";
                Miss_03 = "12√9";
            }
            if (r2 == 4)
            {
                Question_Word = "次の式を計算せよ\n2√4 × 3√3";
                Definition_Word = "12√3";
                Miss_01 = "9√4";
                Miss_02 = "18";
                Miss_03 = "9";
            }
            if (r2 == 5)
            {
                Question_Word = "次の式を計算せよ\n3√7 × 2√2";
                Definition_Word = "6√14";
                Miss_01 = "14√14";
                Miss_02 = "14√7";
                Miss_03 = "6√7";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_11()
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
                Question_Word = "次の二次方程式を解け\nx^2 = 25";
                Definition_Word = "x = ±5";
                Miss_01 = "x = 5";
                Miss_02 = "x = -5";
                Miss_03 = "x = ±√5";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の二次方程式を解け\nx^2 = 529";
                Definition_Word = "x = ±23";
                Miss_01 = "x = 23";
                Miss_02 = "x = -23";
                Miss_03 = "x = ±√23";
            }
            else if (r2 == 3)
            {
                Question_Word = "次の二次方程式を解け\n(x + 2)^2 = 5";
                Definition_Word = "x = -2±√5";
                Miss_01 = "x = 2±√5";
                Miss_02 = "x = -2+√5";
                Miss_03 = "x = 2-√5";
            }
            else if (r2 == 4)
            {
                Question_Word = "次の二次方程式を解け\n(x - 6)^2 = 10";
                Definition_Word = "x = 6±√10";
                Miss_01 = "x = -6±√10";
                Miss_02 = "x = 6+√10";
                Miss_03 = "x = -6-√10";
            }
            else if (r2 == 5)
            {
                Question_Word = "次の二次方程式を解け\n(x + 5)^2 = 16";
                Definition_Word = "x = -9 , x = -2";
                Miss_01 = "x = ±9 , x = ±2";
                Miss_02 = "x = 9 , x = 2";
                Miss_03 = "x = √9 , x = √2";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_12()
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
                Question_Word = "次の二次方程式を解け\nx^2 + 5x = -6";
                Definition_Word = "x = -2 ,-3";
                Miss_01 = "x = 2 ,3";
                Miss_02 = "x = -2 ,3";
                Miss_03 = "x = 2 ,-3";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の二次方程式を解け\nx^2 - 4x = -4";
                Definition_Word = "x = 2";
                Miss_01 = "x = -2";
                Miss_02 = "x = 0";
                Miss_03 = "x = ±2";
            }
            else if(r2 == 3)
            {
                Question_Word = "次の二次方程式を解け\nx^2 + 7x = -12";
                Definition_Word = "x = -3 ,-4";
                Miss_01 = "x = 3 ,4";
                Miss_02 = "x = 3 ,-4";
                Miss_03 = "x = ±4";
            }
            else if(r2 == 4)
            {
                Question_Word = "次の二次方程式を解け\nx^2 - 6x = -8";
                Definition_Word = "x = 4 ,2";
                Miss_01 = "x = -4 ,-2";
                Miss_02 = "x = 4 ,-2";
                Miss_03 = "x = ±4";
            }
            else if(r2 == 5)
            {
                Question_Word = "次の二次方程式を解け\nx^2 - 10x + 9 = 0";
                Definition_Word = "x = 9 ,1";
                Miss_01 = "x = -9 ,-1";
                Miss_02 = "x = -9 ,1";
                Miss_03 = "x = 9 ,-1";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_13()
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
                Question_Word = "xの値を求めよ\n(x + 5)(x - 1) = 0";
                Definition_Word = "x = -5 , x = 1";
                Miss_01 = "x = 5 , x = -1";
                Miss_02 = "x = -5 , x = -1";
                Miss_03 = "x = 5 , x = 1";
            }
            else if (r2 == 2)
            {
                Question_Word = "xの値を求めよ\n(x + 7)(x + 9) = 0";
                Definition_Word = "x = -7 , x = -9";
                Miss_01 = "x = 7 , x = -9";
                Miss_02 = "x = -7 ,x = 9";
                Miss_03 = "x = 7 , x = 9";
            }
            else if (r2 == 3)
            {
                Question_Word = "xの値を求めよ\nx(x - 6) = 0";
                Definition_Word = "x = 0, x = 6";
                Miss_01 = "x = 0 , x = -6";
                Miss_02 = "x = 6";
                Miss_03 = "x = ±6";
            }
            else if (r2 == 4)
            {
                Question_Word = "xの値を求めよ\nx(x + 10) = 0";
                Definition_Word = "x = 0, x = -10";
                Miss_01 = "x = 0 , x = 10";
                Miss_02 = "x = -10";
                Miss_03 = "x = ±10";
            }
            else if (r2 == 5)
            {
                Question_Word = "xの値を求めよ\nx(x - 21) = 0";
                Definition_Word = "x = 0 , x = 21";
                Miss_01 = "x = 0 , x = -21";
                Miss_02 = "x = 21";
                Miss_03 = "x = ±21";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_14()
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
                Question_Word = "次の二次方程式を解け\n2x^2 + 3x - 1 = 0";
                Definition_Word = "x = -3±√17/4";
                Miss_01 = "x = -4±√17/4";
                Miss_02 = "x = 3±√17/4";
                Miss_03 = "x = 4±√17/4";
            }
            else if (r2 == 2)
            {
                Question_Word = "次の二次方程式を解け\n5x^2 - 9x + 3 = 0";
                Definition_Word = "x = 9±√21/10";
                Miss_01 = "x = 8±√21/10";
                Miss_02 = "x = -9±√21/10";
                Miss_03 = "x = -8±√21/10";
            }
            else if (r2 == 3)
            {
                Question_Word = "次の二次方程式を解け\n3x^2 - 2x - 2 = 0";
                Definition_Word = "x = 1±√7/3";
                Miss_01 = "x = 2±√7/3";
                Miss_02 = "x = -1±√7/3";
                Miss_03 = "x = -2±√7/3";
            }
            else if (r2 == 4)
            {
                Question_Word = "次の二次方程式を解け\n2x^2 + 5x - 1 = 0";
                Definition_Word = "x = -5±√33/4";
                Miss_01 = "x = 6±√33/4";
                Miss_02 = "x = 5±√33/4";
                Miss_03 = "x = -6±√33/4";
            }
            else if (r2 == 5)

            {
                Question_Word = "次の二次方程式を解け\n2x^2 - 4x + 1 = 0";
                Definition_Word = "x = 2±√2/2";
                Miss_01 = "x = 3±√2/2";
                Miss_02 = "x = -2±√2/2";
                Miss_03 = "x = -3±√2/2";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_15()
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
                Question_Word = "大小2つの数がある。その差は8で積が48である。このような2数を全て求めよ";
                Definition_Word = "12と4, -4 と-12";
                Miss_01 = "12と4";
                Miss_02 = "12と-4";
                Miss_03 = "-4と12";
            }
            else if (r2 == 2)
            {
                Question_Word = "連続する3つの自然数がある。小さいほうの2数の積の3倍は、大きいほうの2数の積の2倍より50大きい。この3つの自然数を求めよ";
                Definition_Word = "9, 10, 11";
                Miss_01 = "8, 9, 10";
                Miss_02 = "7, 8, 9";
                Miss_03 = "6, 7, 8";
            }
            else if (r2 == 3)
            {
                Question_Word = "大小2つの数がある。その差が4で積が96である。この2数を求めよ";
                Definition_Word = "12と8, -8と-12";
                Miss_01 = "0と4, 0と-4";
                Miss_02 = "12と8";
                Miss_03 = "-8と-12";
            }
            else if (r2 == 4)
            {
                Question_Word = "大小2つの数がある。その和が6で積が-16である。この2数を求めよ";
                Definition_Word = "8と-2";
                Miss_01 = "-8と-2";
                Miss_02 = "8と2";
                Miss_03 = "8と2, -8と-2";
            }
            else if (r2 == 5)
            {
                Question_Word = "連続する3つの自然数がある。それぞれの数を2乗した数の和が50になる。この3つの自然数を求めよ";
                Definition_Word = "3, 4, 5";
                Miss_01 = "2, 3, 4";
                Miss_02 = "-2, -3, -4";
                Miss_03 = "-3, -4, -5";
            }
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_16()
        {
            Random r2 = new Random();
            int r = r2.Next(2, 18);
            int Answer_0;
            Question_Word = "y = 3x^2\nの式にて、x =" + r + "だった場合のyの値を求めよ";
            Answer_0 = (int)Math.Pow(3 * r, 2);
            Answer_Question("y =" + Answer_0, "y = " + (Answer_0 + 2), "y = " + (Answer_0 + 4), "y = " + (Answer_0 - 2));
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_17()
        {
            Random r2 = new Random();
            int r = r2.Next(2, 9);
            int Answer_0;
            int Answer_2;
            Question_Word = "y =" + r +"x^2\nxの値が-2から5のように変化するときの変化の割合を求めよ";
            Answer_0 = (-2 + 5) * r;
            Answer_2 = Answer_0 - 2;
            Answer_Question(Answer_0.ToString(), (Answer_0 + 2).ToString(), (Answer_0 + 4).ToString(), Answer_2.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_18()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "△ABC 相似 △ADEにて AB = 6cm ,AC = 5cm, AD = 4cmの場合\nAEの長さを求めよ";
                Definition_Word = "10/3cm";
                Miss_01 = "3cm";
                Miss_02 = "4cm";
                Miss_03 = "8/3cm";
            }
            else if (r == 2)
            {
                Question_Word = "△ABC 相似 △ADEにて AB = 8cm ,AC = 6.5cm, AD = 5cmの場合\nAEの長さを求めよ";
                Definition_Word = "65/16cm";
                Miss_01 = "4cm";
                Miss_02 = "5cm";
                Miss_03 = "67/16cm";
            }
            else if (r == 3)
            {
                Question_Word = "△ABC 相似 △ADEにて AB = 3cm ,AC = 2.7cm, AD = 2cmの場合\nAEの長さを求めよ";
                Definition_Word = "9/5cm";
                Miss_01 = "2cm";
                Miss_02 = "3cm";
                Miss_03 = "8/5cm";
            }
            else if (r == 4)
            {
                Question_Word = "△ABC 相似 △ADEにて AB = 4cm ,AC = 3.5cm, AD = 3cmの場合\nAEの長さを求めよ";
                Definition_Word = "21/8cm";
                Miss_01 = "3cm";
                Miss_02 = "2cm";
                Miss_03 = "11/4cm";
            }
            else if (r == 5)
            {
                Question_Word = "△ABC 相似 △ADEにて AB = 9cm ,AC = 7cm, AD = 6cmの場合\nAEの長さを求めよ";
                Definition_Word = "14/3cm";
                Miss_01 = "4cm";
                Miss_02 = "5cm";
                Miss_03 = "13/3cm";
            }
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_03/Number_018_01.png";
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_03_Number_19()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "△ABC 相似 △DEFの相似比が3:5だった場合の\n面積比を求めよ";
                Definition_Word = "9:25";
                Miss_01 = "27:125";
                Miss_02 = "8:23";
                Miss_03 = "10:27";
            }
            else if (r == 2)
            {
                Question_Word = "△ABC 相似 △DEFの相似比が2:3だった場合の\n面積比を求めよ";
                Definition_Word = "4:9";
                Miss_01 = "8:27";
                Miss_02 = "5:8";
                Miss_03 = "5:11";
            }
            else if (r == 3)
            {
                Question_Word = "△ABC 相似 △DEFの相似比が4:7だった場合の\n面積比を求めよ";
                Definition_Word = "16:49";
                Miss_01 = "27:343";
                Miss_02 = "17:47";
                Miss_03 = "29:345";
            }
            else if (r == 4)
            {
                Question_Word = "△ABC 相似 △DEFの相似比が1:3だった場合の\n面積比を求めよ";
                Definition_Word = "1:9";
                Miss_01 = "1:27";
                Miss_02 = "1:12";
                Miss_03 = "1:28";
            }
            else if (r == 5)
            {
                Question_Word = "△ABC 相似 △DEFの相似比が5:6だった場合の\n面積比を求めよ";
                Definition_Word = "25:36";
                Miss_01 = "125:216";
                Miss_02 = "23:34";
                Miss_03 = "123:217";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_20()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "∠ADBが48°,∠DACが30°のとき\n∠ACBの角度を求めよ";
                Definition_Word = "∠ACB = 48°";
                Miss_01 = "∠ACB = 30°";
                Miss_02 = "∠ACB = 45°";
                Miss_03 = "∠ACB = 32°";
            }
            else if (r == 2)
            {
                Question_Word = "∠ADBが45°,∠DACが32°のとき\n∠ACBの角度を求めよ";
                Definition_Word = "∠ACB = 45°";
                Miss_01 = "∠ACB = 32°";
                Miss_02 = "∠ACB = 49°";
                Miss_03 = "∠ACB = 30°";
            }
            else if (r == 3)
            {
                Question_Word = "∠ADBが46°,∠DACが33°のとき\n∠ACBの角度を求めよ";
                Definition_Word = "∠ACB = 46°";
                Miss_01 = "∠ACB = 33°";
                Miss_02 = "∠ACB = 47°";
                Miss_03 = "∠ACB = 31°";
            }
            else if (r == 4)
            {
                Question_Word = "∠ADBが50°,∠DACが35°のとき\n∠ACBの角度を求めよ";
                Definition_Word = "∠ACB = 50°";
                Miss_01 = "∠ACB = 35°";
                Miss_02 = "∠ACB = 52°";
                Miss_03 = "∠ACB = 33°";
            }
            else if (r == 5)
            {
                Question_Word = "∠ADBが52°,∠DACが29°のとき\n∠ACBの角度を求めよ";
                Definition_Word = "∠ACB = 52°";
                Miss_01 = "∠ACB = 29°";
                Miss_02 = "∠ACB = 50°";
                Miss_03 = "∠ACB = 28°";
            }
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_03/Number_020_01.png";
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_03_Number_21()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "∠BACが25°,∠BOCが50°のとき\n∠DFEの角度を求めよ";
                Definition_Word = "∠DFE = 25°";
                Miss_01 = "∠ACB = 50°";
                Miss_02 = "∠ACB = 27°";
                Miss_03 = "∠ACB = 48°";
            }
            else if (r == 2)
            {
                Question_Word = "∠BACが26°,∠BOCが52°のとき\n∠DFEの角度を求めよ";
                Definition_Word = "∠DFE = 26°";
                Miss_01 = "∠ACB = 52°";
                Miss_02 = "∠ACB = 28°";
                Miss_03 = "∠ACB = 50°";
            }
            else if (r == 3)
            {
                Question_Word = "∠BACが24°,∠BOCが48°のとき\n∠DFEの角度を求めよ";
                Definition_Word = "∠DFE = 24°";
                Miss_01 = "∠ACB = 48°";
                Miss_02 = "∠ACB = 25°";
                Miss_03 = "∠ACB = 46°";
            }
            else if (r == 4)
            {
                Question_Word = "∠BACが27°,∠BOCが54°のとき\n∠DFEの角度を求めよ";
                Definition_Word = "∠DFE = 27°";
                Miss_01 = "∠ACB = 54°";
                Miss_02 = "∠ACB = 25°";
                Miss_03 = "∠ACB = 52°";
            }
            else if (r == 5)
            {
                Question_Word = "∠BACが22°,∠BOCが44°のとき\n∠DFEの角度を求めよ";
                Definition_Word = "∠DFE = 22°";
                Miss_01 = "∠ACB = 44°";
                Miss_02 = "∠ACB = 24°";
                Miss_03 = "∠ACB = 43°";
            }
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_03/Number_021_01.png";
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_03_Number_22() 
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "x = 5, y = 3のときのzの値を\n三平方の定理を用いて求めよ";
                Definition_Word = "z = √34";
                Miss_01 = "z = √35";
                Miss_02 = "z = 6";
                Miss_03 = "z = 2√8";
            }
            else if (r == 2)
            {
                Question_Word = "x = 6, y = 4のときのzの値を\n三平方の定理を用いて求めよ";
                Definition_Word = "z = 2√13";
                Miss_01 = "z = 2√14";
                Miss_02 = "z = 2√11";
                Miss_03 = "z = 4√3";
            }
            else if (r == 3)
            {
                Question_Word = "x = 3, y = 2のときのzの値を\n三平方の定理を用いて求めよ";
                Definition_Word = "z = √13";
                Miss_01 = "z = √14";
                Miss_02 = "z = √15";
                Miss_03 = "z = 4";
            }
            else if (r == 4)
            {
                Question_Word = "x = 7, y = 4のときのzの値を\n三平方の定理を用いて求めよ";
                Definition_Word = "z = √65";
                Miss_01 = "z = √66";
                Miss_02 = "z = √67";
                Miss_03 = "z = 8";
            }
            else if (r == 5)
            {
                Question_Word = "x = 9, y = 5のときのzの値を\n三平方の定理を用いて求めよ";
                Definition_Word = "z = √106";
                Miss_01 = "z = √105";
                Miss_02 = "z = 2√26";
                Miss_03 = "z = √103";
            }
            Math_Image_Source = Path + "/Resources/BG/Math/Grade_03/Number_022_01.png";
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = true;
        }
        void Question_Grade_03_Number_23()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "座標(2,3)の点Aと座標(5,1)の点Bがある\nAB間の長さを求めよ";
                Definition_Word = "AB = √13";
                Miss_01 = "AB = √14";
                Miss_02 = "AB = 2√3";
                Miss_03 = "AB = √15";
            }
            else if (r == 2)
            {
                Question_Word = "座標(2,4)の点Aと座標(3,7)の点Bがある\nAB間の長さを求めよ";
                Definition_Word = "AB = √10";
                Miss_01 = "AB = √11";
                Miss_02 = "AB = 2√3";
                Miss_03 = "AB = 3";
            }
            else if (r == 3)
            {
                Question_Word = "座標(2,2)の点Aと座標(4,-5)の点Bがある\nAB間の長さを求めよ";
                Definition_Word = "AB = √53";
                Miss_01 = "AB = 3√6";
                Miss_02 = "AB = √55";
                Miss_03 = "AB = 2√13";
            }
            else if (r == 4)
            {
                Question_Word = "座標(2,2)の点Aと座標(4,-5)の点Bがある\nAB間の長さを求めよ";
                Definition_Word = "AB = √53";
                Miss_01 = "AB = 3√6";
                Miss_02 = "AB = √55";
                Miss_03 = "AB = 2√13";
            }
            else if (r == 5)
            {
                Question_Word = "座標(2,-2)の点Aと座標(3,5)の点Bがある\nAB間の長さを求めよ";
                Definition_Word = "AB = 5√2";
                Miss_01 = "AB = √51";
                Miss_02 = "AB = 7";
                Miss_03 = "AB = 4√3";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_24()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "母線6cm, 底面の半径が4cmの円錐の高さを求めよ";
                Definition_Word = "2√5cm";
                Miss_01 = "√21cm";
                Miss_02 = "√22cm";
                Miss_03 = "√19cm";
            }
            else if (r == 2)
            {
                Question_Word = "母線5cm, 底面の半径が3cmの円錐の高さを求めよ";
                Definition_Word = "4cm";
                Miss_01 = "√17cm";
                Miss_02 = "√15cm";
                Miss_03 = "3√2cm";
            }
            else if (r == 3)
            {
                Question_Word = "母線7cm, 底面の半径が3cmの円錐の高さを求めよ";
                Definition_Word = "2√10cm";
                Miss_01 = "√41cm";
                Miss_02 = "√39cm";
                Miss_03 = "√38cm";
            }
            else if (r == 4)
            {
                Question_Word = "母線6cm, 底面の半径が5cmの円錐の高さを求めよ";
                Definition_Word = "√11cm";
                Miss_01 = "2√3cm";
                Miss_02 = "√13cm";
                Miss_03 = "√10cm";
            }
            else if (r == 5)
            {
                Question_Word = "母線9cm, 底面の半径が6cmの円錐の高さを求めよ";
                Definition_Word = "3√5cm";
                Miss_01 = "√46cm";
                Miss_02 = "2√11cm";
                Miss_03 = "√43cm";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_25()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "因数分解せよ\nx^4 - 16";
                Definition_Word = "(x^2 + 4)(x + 2)(x - 2)";
                Miss_01 = "(x + 2)(x - 2)(x + 2)(x - 2)";
                Miss_02 = "(x + 2)^2(x - 2)^2";
                Miss_03 = "できない";
            }
            else if (r == 2)
            {
                Question_Word = "因数分解せよ\nx^4 - 16y^4";
                Definition_Word = "(x^2 + 4y^2)(x + 2y)(x - 2y)";
                Miss_01 = "(x + 2y)(x - 2y)(x + 2y)(x - 2y)";
                Miss_02 = "(x + 2y)^2(x - 2y)^2";
                Miss_03 = "できない";
            }
            else if (r == 3)
            {
                Question_Word = "因数分解せよ\n16 - x^4";
                Definition_Word = "(4 + x^2)(2 + x)(2 - x)";
                Miss_01 = "(2 + x)(2 - x)(2 + x)(2 - x)";
                Miss_02 = "(2 + x)^2(2 - x)^2";
                Miss_03 = "できない";
            }
            else if (r == 4)
            {
                Question_Word = "因数分解せよ\n16y^4 - x^4";
                Definition_Word = "(4y^2 + x^2)(2y + x)(2y - x)";
                Miss_01 = "(2y + x)(2y - x)(2y + x)(2y - x)";
                Miss_02 = "(2y + x)^2(2y - x)^2";
                Miss_03 = "できない";
            }
            else if (r == 5)
            {
                Question_Word = "因数分解せよ\nx^8 - 16";
                Definition_Word = "(x^4 + 4)(x^2 + 2)(x^2 - 2)";
                Miss_01 = "(x^2 + 2)(x^2 - 2)(x^2 + 2)(x^2 - 2)";
                Miss_02 = "(x^2 + 2)^2(x^2 - 2)^2";
                Miss_03 = "できない";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_26()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "素因数分解せよ\n320";
                Definition_Word = "2^6 × 5";
                Miss_01 = "2^5 × 5";
                Miss_02 = "2^6 × 5^2";
                Miss_03 = "2^5 × 5^2";
            }
            else if (r == 2)
            {
                Question_Word = "素因数分解せよ\n200";
                Definition_Word = "2^3 × 5^2";
                Miss_01 = "2^2 × 5^3";
                Miss_02 = "2^4 × 5";
                Miss_03 = "2^3 × 3^2";
            }
            else if (r == 3)
            {
                Question_Word = "素因数分解せよ\n408";
                Definition_Word = "2^3 × 3 × 17";
                Miss_01 = "2^3 × 3^3";
                Miss_02 = "2^4 × 17";
                Miss_03 = "3 × 7^3";
            }
            else if (r == 4)
            {
                Question_Word = "素因数分解せよ\n500";
                Definition_Word = "2^2 × 5^3";
                Miss_01 = "2^3 × 5^2";
                Miss_02 = "2^4 × 5";
                Miss_03 = "2^6 × 5";
            }
            else if (r == 5)
            {
                Question_Word = "素因数分解せよ\n1000";
                Definition_Word = "2^3 × 5^3";
                Miss_01 = "2^4 × 5^2";
                Miss_02 = "2^5 × 5";
                Miss_03 = "2^6 × 5^2";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_27()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "π, √10の大小を答えよ";
                Definition_Word = "π < √10";
                Miss_01 = "π > √10";
                Miss_02 = "√10 < π";
                Miss_03 = "π = √10";
            }
            else if (r == 2)
            {
                Question_Word = "9, √81の大小を答えよ";
                Definition_Word = "9 = √81";
                Miss_01 = "9 > √81";
                Miss_02 = "√81 < 9";
                Miss_03 = "9 < √81";
            }
            else if (r == 3)
            {
                Question_Word = "2√2, √3の大小を答えよ";
                Definition_Word = "2√2 > √3";
                Miss_01 = "√3 > 2√2";
                Miss_02 = "2√2 < √3";
                Miss_03 = "2√2 = √3";
            }
            else if (r == 4)
            {
                Question_Word = "3, √9の大小を答えよ";
                Definition_Word = "3 = √9";
                Miss_01 = "3 > √9";
                Miss_02 = "√9 < 3";
                Miss_03 = "√9 > 3";
            }
            else if (r == 5)
            {
                Question_Word = "π, 3の大小を答えよ";
                Definition_Word = "π > 3";
                Miss_01 = "π < 3";
                Miss_02 = "3 > π";
                Miss_03 = "3 = π";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_28()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "斜辺以外が3cm, 4cmの直角三角形の斜辺の長さを求めよ";
                Definition_Word = "5cm";
                Miss_01 = "6cm";
                Miss_02 = "7cm";
                Miss_03 = "√7";
            }
            else if (r == 2)
            {
                Question_Word = "斜辺以外が5cm, 12cmの直角三角形の斜辺の長さを求めよ";
                Definition_Word = "13cm";
                Miss_01 = "14cm";
                Miss_02 = "12cm";
                Miss_03 = "√14";
            }
            else if (r == 3)
            {
                Question_Word = "斜辺以外が6cm, 8cmの直角三角形の斜辺の長さを求めよ";
                Definition_Word = "10cm";
                Miss_01 = "11cm";
                Miss_02 = "12cm";
                Miss_03 = "√11cm";
            }
            else if (r == 4)
            {
                Question_Word = "斜辺以外が7cm, 24cmの直角三角形の斜辺の長さを求めよ";
                Definition_Word = "25cm";
                Miss_01 = "26cm";
                Miss_02 = "27cm";
                Miss_03 = "√41";
            }
            else if (r == 5)
            {
                Question_Word = "斜辺以外が10cm, 24cmの直角三角形の斜辺の長さを求めよ";
                Definition_Word = "26cm";
                Miss_01 = "27cm";
                Miss_02 = "25cm";
                Miss_03 = "√29";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_29()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "相似比が3:2の平面図形AとBがある\nAの面積が24cm^2の場合のBの面積を求めよ";
                Definition_Word = "32/3cm^2";
                Miss_01 = "16cm^2";
                Miss_02 = "31/3cm^2";
                Miss_03 = "12cm^2";
            }
            else if (r == 2)
            {
                Question_Word = "相似比が3:1の平面図形AとBがある\nAの面積が24cm^2の場合のBの面積を求めよ";
                Definition_Word = "8/3cm^2";
                Miss_01 = "3cm^2";
                Miss_02 = "7/3cm^2";
                Miss_03 = "4cm^2";
            }
            else if (r == 3)
            {
                Question_Word = "相似比が2:1の平面図形AとBがある\nAの面積が20cm^2の場合のBの面積を求めよ";
                Definition_Word = "5cm^2";
                Miss_01 = "10cm^2";
                Miss_02 = "5/2cm^2";
                Miss_03 = "11/2cm^2";
            }
            else if (r == 4)
            {
                Question_Word = "相似比が4:3の平面図形AとBがある\nAの面積が20cm^2の場合のBの面積を求めよ";
                Definition_Word = "45/4cm^2";
                Miss_01 = "31/2cm^2";
                Miss_02 = "16cm^2";
                Miss_03 = "33/2cm^2";
            }
            else if (r == 5)
            {
                Question_Word = "相似比が5:2の平面図形AとBがある\nAの面積が30cm^2の場合のBの面積を求めよ";
                Definition_Word = "14/5cm^2";
                Miss_01 = "3cm^2";
                Miss_02 = "61/5cm^2";
                Miss_03 = "62/5cm^2";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Question_Grade_03_Number_30()
        {
            Random r2 = new Random();
            int r = r2.Next(1, 6);
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            if (r == 1)
            {
                Question_Word = "相似比が3:2の立体AとBがある\nAの体積が81cm^3の場合のBの体積を求めよ";
                Definition_Word = "24cm^3";
                Miss_01 = "23cm^3";
                Miss_02 = "25cm^3";
                Miss_03 = "22cm^3";
            }
            else if (r == 2)
            {
                Question_Word = "相似比が3:1の立体AとBがある\nAの体積が81cm^3の場合のBの体積を求めよ";
                Definition_Word = "3cm^3";
                Miss_01 = "4cm^3";
                Miss_02 = "5cm^3";
                Miss_03 = "2cm^3";
            }
            else if (r == 3)
            {
                Question_Word = "相似比が2:1の立体AとBがある\nAの体積が50cm^3の場合のBの体積を求めよ";
                Definition_Word = "25/4cm^3";
                Miss_01 = "23/4cm^3";
                Miss_02 = "12cm^3";
                Miss_03 = "13/2cm^3";
            }
            else if (r == 4)
            {
                Question_Word = "相似比が4:3の立体AとBがある\nAの体積が50cm^3の場合のBの体積を求めよ";
                Definition_Word = "675/32cm^3";
                Miss_01 = "169/8cm^3";
                Miss_02 = "677/32cm^3";
                Miss_03 = "337/16cm^3";
            }
            else if (r == 5)
            {
                Question_Word = "相似比が5:2の立体AとBがある\nAの体積が60cm^3の場合のBの体積を求めよ";
                Definition_Word = "96/25cm^3";
                Miss_01 = "97/25cm^3";
                Miss_02 = "98/25cm^3";
                Miss_03 = "19/5cm^3";
            }
            Answer_Question(Definition_Word.ToString(), Miss_01.ToString(), Miss_02.ToString(), Miss_03.ToString());
            Button_Text_Change();
            IsImageUse = false;
        }
        void Difficult_Question_Set()
        {
            //応用問題(そこそこ難しい問題4問)
            IsCanNotSaveNow = true;
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Choice_01_T.FontSize = 25;
            Choice_02_T.FontSize = 25;
            Choice_03_T.FontSize = 25;
            Choice_04_T.FontSize = 25;
            string Miss_01 = "";
            string Miss_02 = "";
            string Miss_03 = "";
            Random r = new Random();
            int r2 = r.Next(1, 6);
            if (Difficult_Question_Number == 1)
            {
                FontSize = 25;
                if (r2 == 1)
                {
                    Question_Word = "x^2 + xy - 4x - y + 3\nの式を因数分解せよ";
                    Definition_Word = "(x - 1)(x - 3 + y)";
                    Miss_01 = "(x - 3)(x - 1) + y(x - 1)";
                    Miss_02 = "x(x + y - 4) + 3";
                    Miss_03 = "x(x - 4) + y(x - 1) + 3";
                }
                else if (r2 == 2)
                {
                    Question_Word = "x^2 + 2xy - 5x - 6y + 6";
                    Definition_Word = "(x - 3)(x + 2y - 2)";
                    Miss_01 = "x(x + 2y - 5) - 6y + 6";
                    Miss_02 = "(x + 5)(x + 1) + 2y(x - 3)";
                    Miss_03 = "x(x - 5) + 2y(x - 3) + 6";
                }
                else if (r2 == 3)
                {
                    Question_Word = "ab - 4c - 2a + 2bc";
                    Definition_Word = "(a + 2c)(b - 2)";
                    Miss_01 = "a(b - 2) - 2c(2 - b)";
                    Miss_02 = "b(a + 2c) - 2(a + 2c)";
                    Miss_03 = "-2(a + 2c - bc) + ab";
                }
                else if (r2 == 4)
                {
                    Question_Word = "x^3 - (2y - 3)x^2 - 2(3y - 1)x - 4y";
                    Definition_Word = "(x + 1)(x + 2)(x - 2a)";
                    Miss_01 = "x^2(x - 2y - 3) - 2x(3y - 1) - 4y";
                    Miss_02 = "x(x^2 - 2xy - 3y - 6y + 2) - 4y";
                    Miss_03 = "-2xy(x + 3) + x^2(x - 3) + 2(x - 2y)";
                }
                else if (r2 == 5)
                {
                    Question_Word = "x^2 + 2xy + y^2 + 2x + 2y - 8";
                    Definition_Word = "(x + y + 4)(x + y - 2)";
                    Miss_01 = "x(x + 2y + 2) + y(y + 2) - 8";
                    Miss_02 = "(x + 4)(x - 2) + y(2x + y + 2)";
                    Miss_03 = "(y + 4)(y - 2) + x(x + 2y + 2)";
                }
            }
            else if (Difficult_Question_Number == 2)
            {
                FontSize = 25;
                if (r2 == 1)
                {
                    Question_Word = "(2x^2 + 4)^2(2x^2 + 4)^2";
                    Definition_Word = "16x^8 + 128x^6 + 384x^4 + 512x^2 + 256";
                    Miss_01 = "16x^4 + 128x^3 + 384x^2 + 512x + 256";
                    Miss_02 = "16x^8 + 128x^6 - 384x^4 + 512x^2 + 256";
                    Miss_03 = "16x^4 + 128x^3 - 384x^2 + 512x + 256";
                }
                else if (r2 == 2)
                {
                    Question_Word = "(3x^2 + 2)^2(3x^2 + 2)^2";
                    Definition_Word = "81x^8 + 216x^6 + 216x^4 + 96x^2 + 16";
                    Miss_01 = "81x^4 + 216x^3 + 216x^2 + 96x + 16";
                    Miss_02 = "81x^8 + 216x^6 - 216x^4 + 96x^2 + 16";
                    Miss_03 = "81x^4 + 216x^3 - 216x^2 + 96x + 16";
                }
                else if (r2 == 3)
                {
                    Question_Word = "(4x^2 + 3)^2(4x^2 + 3)^2";
                    Definition_Word = "256x^8 + 768x^6 + 864x^4 + 432x^2 + 81";
                    Miss_01 = "256x^4 + 768x^3 + 864x^2 + 432x + 81";
                    Miss_02 = "256x^8 + 768x^6 - 864x^4 + 432x^2 + 81";
                    Miss_03 = "256x^4 + 768x^3 - 864x^2 + 432x + 81";
                }
                else if (r2 == 4)
                {
                    Question_Word = "(2x^2 - 3)^2(2x^2 - 3)^2";
                    Definition_Word = "16x^8 - 96x^6 + 216x^4 - 216x^2 + 81";
                    Miss_01 = "16x^4 - 96x^3 + 216x^2 - 216x + 81";
                    Miss_02 = "16x^8 - 96x^6 - 216x^4 - 216x^2 + 81";
                    Miss_03 = "16x^4 - 96x^3 - 216x^2 - 216x + 81";
                }
                else if (r2 == 5)
                {
                    Question_Word = "(3x^2 - 2)^2(3x^2 - 2)^2";
                    Definition_Word = "81x^8 - 216x^6 + 216x^4 - 96x^2 + 16";
                    Miss_01 = "81x^4 - 216x^3 + 216x^2 - 96x + 16";
                    Miss_02 = "81x^8 - 216x^6 - 216x^4 - 96x^2 + 16";
                    Miss_03 = "81x^4 - 216x^3 - 216x^2 - 96x + 16";
                }
            }
            else if (Difficult_Question_Number == 3)
            {
                FontSize = 35;
                Text_01_T.FontSize = 30;
                Text_02_T.FontSize = 30;
                if (r2 == 1)
                {
                    Question_Word = "大,小それぞれ5面のサイコロを振ったときの出る目すべて足す場合\n最も出る可能性の高い2つのサイコロの和を求めよ";
                    Definition_Word = "6";
                    Miss_01 = "5";
                    Miss_02 = "可能性の高い和は無い";
                    Miss_03 = "5と6";
                }
                else if (r2 == 2)
                {
                    Question_Word = "大,中,小それぞれサイコロを振ったときの出る目すべて足す場合\n最も出る可能性の高い3つのサイコロの和を求めよ";
                    Definition_Word = "10と11";
                    Miss_01 = "可能性の高い和は無い";
                    Miss_02 = "8と13";
                    Miss_03 = "9";
                }
                else if (r2 == 3)
                {
                    Question_Word = "大,小それぞれサイコロを振ったときの出る目すべて足す場合\n最も出る可能性の高い2つのサイコロの和を求めよ";
                    Definition_Word = "7";
                    Miss_01 = "可能性の高い和は無い";
                    Miss_02 = "6";
                    Miss_03 = "6と7";
                }
                else if (r2 == 4)
                {
                    Question_Word = "赤,青,黒,白それぞれサイコロを振ったときの出る目すべて足す場合\n最も出る可能性の高い4つのサイコロの和を求めよ";
                    Definition_Word = "14";
                    Miss_01 = "可能性の高い和は無い";
                    Miss_02 = "12";
                    Miss_03 = "12と13";
                }
                else if (r2 == 5)
                {
                    Question_Word = "赤,黒,白それぞれ5面のサイコロを振ったときの出る目すべて足す場合\n最も出る可能性の高い4つのサイコロの和を求めよ";
                    Definition_Word = "9";
                    Miss_01 = "可能性の高い和は無い";
                    Miss_02 = "7と8";
                    Miss_03 = "7";
                }
            }
            else if (Difficult_Question_Number == 4)
            {
                Text_01_T.FontSize = 25;
                Text_02_T.FontSize = 25;
                if (r2 == 1)
                {
                    FontSize = 34;
                    Question_Word = "ある中学校の生徒80人が学力テストを受験した。全体の平均点は58点で、男子の平均点は52点、女子の平均点は62点であった。男子・女子の人数はそれぞれ何人か求めよ";
                    Definition_Word = "男子32人、女子48人";
                    Miss_01 = "男子48人、女子32人";
                    Miss_02 = "男子38人、女子42人";
                    Miss_03 = "男子42人、女子38人";
                }
                else if (r2 == 2)
                {
                    FontSize = 34;
                    Question_Word = "周囲2400mの池を、A、B2人が同時に同じ地点から歩いた。反対の方向に歩くと2人は15分で出会い、同じ方向に歩くと60分でAがBを初めて追い抜いた。A、Bはそれぞれ分速何mで歩いたか求めよ";
                    Definition_Word = "A=分速100m、B=分速60m";
                    Miss_01 = "A=分速60m、B=分速100m";
                    Miss_02 = "A=分速160m、B=分速40m";
                    Miss_03 = "A=分速40m、B=分速160m";
                }
                else if (r2 == 3)
                {
                    FontSize = 27;
                    Text_01_T.FontSize = 27;
                    Text_02_T.FontSize = 27;
                    Question_Word = "ある列車が一定の速さで走っている。この列車が長さ570mの鉄橋を渡りはじめてから渡り終わるまでに18秒かかった。また、長さ3500mのトンネルをくぐるとき、この列車がすっかりかくれている時間は56秒であった。この列車の長さと速さをそれぞれ求めよ";
                    Definition_Word = "列車の長さ=420m、列車の速さ=秒速55m";
                    Miss_01 = "列車の長さ=380m、列車の速さ=秒速65m";
                    Miss_02 = "列車の長さ=290m、列車の速さ=秒速45m";
                    Miss_03 = "列車の長さ=500m、列車の速さ=秒速75m";
                }
                else if (r2 == 4)
                {
                    FontSize = 25;
                    Question_Word = "容器Aと容器Bに、濃さの違う食塩水がそれぞれ400gずつある。容器Aから食塩水を200gとり容器Bに移したら、容器Bには4%の食塩水600gができた。そのあと、容器Bから食塩水を200gとり容器Aに移したら、容器Aには6%の食塩水400gができた。最初、容器A、容器Bにはそれぞれ何%の食塩水があったか求めよ";
                    Definition_Word = "容器Aの食塩水=8%、容器Bの食塩水=2%";
                    Miss_01 = "容器Aの食塩水=2%、容器Bの食塩水=8%";
                    Miss_02 = "容器Aの食塩水=6%、容器Bの食塩水=4%";
                    Miss_03 = "容器Aの食塩水=4%、容器Bの食塩水=6%";
                }
                else if (r2 == 5)
                {
                    FontSize = 25;
                    Question_Word = "兄と弟の所持金の比は5:3であった。兄が父から300円もらい、弟が120円使ったら、所持金の比が5:2になった。はじめに兄と弟はそれぞれ何円持っていたか求めよ";
                    Definition_Word = "兄の所持金=1200円、弟の所持金=720円";
                    Miss_01 = "兄の所持金=720円、弟の所持金=1200円";
                    Miss_02 = "兄の所持金=920円、弟の所持金=552円";
                    Miss_03 = "兄の所持金=522円、弟の所持金=920円";
                }
            }
            Choice_01_T.FontSize = FontSize;
            Choice_02_T.FontSize = FontSize;
            Choice_03_T.FontSize = FontSize;
            Choice_04_T.FontSize = FontSize;
            Answer_Question(Definition_Word, Miss_01, Miss_02, Miss_03);
            Button_Text_Change();
            IsImageUse = false;
        }
    }
}