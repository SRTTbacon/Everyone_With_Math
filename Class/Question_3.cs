using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Everyone_With_Math.Class
{
    public partial class Math_01 : Window
    {
        //3�w�N�̖����`
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
            Question_Word = "���̎���W�J����\n(" + r3 + "x +" + r4 + ")(" + r5 + "x +" + r6 + ")";
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
            Question_Word = "���̎���W�J����\n(x" + " + " + r2 + ")^2";
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
            Question_Word = "���̎���W�J����\n(x + " + r2 + ") (x - " + r2 + ")";
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
                Question_Word = "���̎���������������\nx^2 + 5x + 6";
                Definition_Word = "(x + 3)(x + 2)";
                Miss_01 = "(x + 4)(x + 2)";
                Miss_02 = "(x - 3)(x - 2)";
                Miss_03 = "(x - 4)(x - 2)";
            }
            else if (r2 == 2)
            {
                Question_Word = "���̎���������������\nx^2 + 2x - 15";
                Definition_Word = "(x + 5)(x - 3)";
                Miss_01 = "(x + 4)(x + 7)";
                Miss_02 = "(x + 5)(x - 3)";
                Miss_03 = "(x - 4)(x - 7)";
            }
            else if (r2 == 3)
            {
                Question_Word = "���̎���������������\nx^2 - 10x + 21";
                Definition_Word = "(x - 3)(x - 7)";
                Miss_01 = "(x + 5)(x + 2)";
                Miss_02 = "(x + 3)(x + 7)";
                Miss_03 = "(x - 5)(x - 2)";
            }
            else if (r2 == 4)
            {
                Question_Word = "���̎���������������\nx^2 + x - 12";
                Definition_Word = "(x - 3)(x + 4)";
                Miss_01 = "(x + 4)(x + 2)";
                Miss_02 = "(x + 3)(x - 4)";
                Miss_03 = "(x - 4)(x - 2)";
            }
            else if (r2 == 5)
            {
                Question_Word = "���̎���������������\nx^2 + 9x + 14";
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
                Question_Word = "���̎���������������\na(x + y) - 5(x + y)";
                Definition_Word = "(x + y)(a - 5)";
                Miss_01 = "(x - y)(a - 5)";
                Miss_02 = "(x + y)(a + 5)";
                Miss_03 = "(x - 5)(a + 5)";
            }
            else if (r2 == 2)
            {
                Question_Word = "���̎���������������\n(a + 2)(a + 3) - 78";
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
                Question_Word = "���̎���������������\n(a + b)^2 - (x + y)^2";
                Definition_Word = "(a + b + x + y)(a + b - x - y)";
                Miss_01 = "(a^2 + 2ab + b^2) - (x^2 + 2xy + y^2)";
                Miss_02 = "{(a + b)(x - y)}^2";
                Miss_03 = "(a + b)^2 + (x + y)(x - y)";
            }
            else if (r2 == 4)
            {
                Question_Word = "���̎���������������\n3a + 3c";
                Definition_Word = "3(a + c)";
                Miss_01 = "ac(3 + 3)";
                Miss_02 = "6(a + c)";
                Miss_03 = "(3a + 3c)";
            }
            else if (r2 == 5)
            {
                Question_Word = "���̎���������������\n2x^2 - 18x";
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
                Question_Word = "45��f������������";
                Definition_Word = "3^2 �~ 5";
                Miss_01 = "5 �~ 9";
                Miss_02 = "-5 �~ -9";
                Miss_03 = "3 �~ 15";
            }
            else if (r2 == 2)
            {
                Question_Word = "18��f������������";
                Definition_Word = "2 �~ 3^2";
                Miss_01 = "2 �~ 9";
                Miss_02 = "3 �~ 6";
                Miss_03 = "-3 �~ -6";
            }
            else if (r2 == 3)
            {
                Question_Word = "24��f������������";
                Definition_Word = "2^3 �~ 3";
                Miss_01 = "4 �~ 6";
                Miss_02 = "3 �~ 8";
                Miss_03 = "-3 �~ -8";
            }
            else if (r2 == 4)
            {
                Question_Word = "9��f������������";
                Definition_Word = "3^2";
                Miss_01 = "-3^2";
                Miss_02 = "-9";
                Miss_03 = "�f���������ł��Ȃ�";
            }
            else if (r2 == 5)
            {
                Question_Word = "4��f������������";
                Definition_Word = "2^2";
                Miss_01 = "-2^2";
                Miss_02 = "-4";
                Miss_03 = "�f���������ł��Ȃ�";
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
                Question_Word = "4�̕����������߂�";
                Definition_Word = "�}2";
                Miss_01 = "2";
                Miss_02 = "-2";
                Miss_03 = "�}4";
            }
            else if (r2 == 2)
            {
                Question_Word = "49�̕����������߂�";
                Definition_Word = "�}7";
                Miss_01 = "7";
                Miss_02 = "-7";
                Miss_03 = "�}49";
            }
            else if (r2 == 3)
            {
                Question_Word = "100�̕����������߂�";
                Definition_Word = "�}10";
                Miss_01 = "10";
                Miss_02 = "-10";
                Miss_03 = "�}100";
            }
            else if (r2 == 4)
            {
                Question_Word = "225�̕����������߂�";
                Definition_Word = "�}15";
                Miss_01 = "15";
                Miss_02 = "-15";
                Miss_03 = "�}225";
            }
            else if (r2 == 5)
            {
                Question_Word = "0.04�̕����������߂�";
                Definition_Word = "�}0.2";
                Miss_01 = "0.2";
                Miss_02 = "-0.2";
                Miss_03 = "�}0.04";
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
                Question_Word = "��3��1�̂ǂ������傫����";
                Definition_Word = "��3 > 1";
                Miss_01 = "��3 < 1";
                Miss_02 = "��3 = 1";
                Miss_03 = "��3 �� 1";
            }
            else if (r2 == 2)
            {
                Question_Word = "��5��2�̂ǂ������傫����";
                Definition_Word = "��5 > 2";
                Miss_01 = "��5 < 2";
                Miss_02 = "��5 = 2";
                Miss_03 = "��5 �� 2";
            }
            else if (r2 == 3)
            {
                Question_Word = "��9��3�̂ǂ������傫����";
                Definition_Word = "��9 = 3";
                Miss_01 = "��9 < 3";
                Miss_02 = "��9 > 3";
                Miss_03 = "��9 �� 3";
            }
            else if (r2 == 4)
            {
                Question_Word = "��12��4�̂ǂ������傫����";
                Definition_Word = "��12 < 4";
                Miss_01 = "��12 > 4";
                Miss_02 = "��12 = 4";
                Miss_03 = "��12 �� 4";
            }
            else if (r2 == 5)
            {
                Question_Word = "��10��3�̂ǂ������傫����";
                Definition_Word = "��10 > 3";
                Miss_01 = "��10 < 3";
                Miss_02 = "��10 = 3";
                Miss_03 = "��10 �� 3";
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
                Question_Word = "���̎����v�Z����\n4��2 + 5��2";
                Definition_Word = "9��2";
                Miss_01 = "9��4";
                Miss_02 = "18";
                Miss_03 = "9";
            }
            else if (r2 == 2)
            {
                Question_Word = "���̎����v�Z����\n9��7 - 3��7";
                Definition_Word = "6��7";
                Miss_01 = "6��14";
                Miss_02 = "12��7";
                Miss_03 = "12��14";
            }
            else if (r2 == 3)
            {
                Question_Word = "���̎����v�Z����\n5��3 + 8��3";
                Definition_Word = "13��3";
                Miss_01 = "12��3";
                Miss_02 = "12";
                Miss_03 = "3";
            }
            else if (r2 == 4)
            {
                Question_Word = "���̎����v�Z����\n3��5 - 10��5";
                Definition_Word = "-7��5";
                Miss_01 = "13��5";
                Miss_02 = "-7��10";
                Miss_03 = "13��10";
            }
            else if (r2 == 5)
            {
                Question_Word = "���̎����v�Z����\n7��6 + 9��6";
                Definition_Word = "16��6";
                Miss_01 = "16��6";
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
                Question_Word = "���̎����v�Z����\n3��2 �~ 4��3";
                Definition_Word = "12��6";
                Miss_01 = "7��6";
                Miss_02 = "12��2";
                Miss_03 = "12��3";
            }
            if (r2 == 2)
            {
                Question_Word = "���̎����v�Z����\n4��2 �~ 5��2";
                Definition_Word = "40";
                Miss_01 = "20��4";
                Miss_02 = "20";
                Miss_03 = "40��2";
            }
            if (r2 == 3)
            {
                Question_Word = "���̎����v�Z����\n2��3 �~ 2��3";
                Definition_Word = "12";
                Miss_01 = "4��9";
                Miss_02 = "4";
                Miss_03 = "12��9";
            }
            if (r2 == 4)
            {
                Question_Word = "���̎����v�Z����\n2��4 �~ 3��3";
                Definition_Word = "12��3";
                Miss_01 = "9��4";
                Miss_02 = "18";
                Miss_03 = "9";
            }
            if (r2 == 5)
            {
                Question_Word = "���̎����v�Z����\n3��7 �~ 2��2";
                Definition_Word = "6��14";
                Miss_01 = "14��14";
                Miss_02 = "14��7";
                Miss_03 = "6��7";
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
                Question_Word = "���̓񎟕�����������\nx^2 = 25";
                Definition_Word = "x = �}5";
                Miss_01 = "x = 5";
                Miss_02 = "x = -5";
                Miss_03 = "x = �}��5";
            }
            else if (r2 == 2)
            {
                Question_Word = "���̓񎟕�����������\nx^2 = 529";
                Definition_Word = "x = �}23";
                Miss_01 = "x = 23";
                Miss_02 = "x = -23";
                Miss_03 = "x = �}��23";
            }
            else if (r2 == 3)
            {
                Question_Word = "���̓񎟕�����������\n(x + 2)^2 = 5";
                Definition_Word = "x = -2�}��5";
                Miss_01 = "x = 2�}��5";
                Miss_02 = "x = -2+��5";
                Miss_03 = "x = 2-��5";
            }
            else if (r2 == 4)
            {
                Question_Word = "���̓񎟕�����������\n(x - 6)^2 = 10";
                Definition_Word = "x = 6�}��10";
                Miss_01 = "x = -6�}��10";
                Miss_02 = "x = 6+��10";
                Miss_03 = "x = -6-��10";
            }
            else if (r2 == 5)
            {
                Question_Word = "���̓񎟕�����������\n(x + 5)^2 = 16";
                Definition_Word = "x = -9 , x = -2";
                Miss_01 = "x = �}9 , x = �}2";
                Miss_02 = "x = 9 , x = 2";
                Miss_03 = "x = ��9 , x = ��2";
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
                Question_Word = "���̓񎟕�����������\nx^2 + 5x = -6";
                Definition_Word = "x = -2 ,-3";
                Miss_01 = "x = 2 ,3";
                Miss_02 = "x = -2 ,3";
                Miss_03 = "x = 2 ,-3";
            }
            else if (r2 == 2)
            {
                Question_Word = "���̓񎟕�����������\nx^2 - 4x = -4";
                Definition_Word = "x = 2";
                Miss_01 = "x = -2";
                Miss_02 = "x = 0";
                Miss_03 = "x = �}2";
            }
            else if(r2 == 3)
            {
                Question_Word = "���̓񎟕�����������\nx^2 + 7x = -12";
                Definition_Word = "x = -3 ,-4";
                Miss_01 = "x = 3 ,4";
                Miss_02 = "x = 3 ,-4";
                Miss_03 = "x = �}4";
            }
            else if(r2 == 4)
            {
                Question_Word = "���̓񎟕�����������\nx^2 - 6x = -8";
                Definition_Word = "x = 4 ,2";
                Miss_01 = "x = -4 ,-2";
                Miss_02 = "x = 4 ,-2";
                Miss_03 = "x = �}4";
            }
            else if(r2 == 5)
            {
                Question_Word = "���̓񎟕�����������\nx^2 - 10x + 9 = 0";
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
                Question_Word = "x�̒l�����߂�\n(x + 5)(x - 1) = 0";
                Definition_Word = "x = -5 , x = 1";
                Miss_01 = "x = 5 , x = -1";
                Miss_02 = "x = -5 , x = -1";
                Miss_03 = "x = 5 , x = 1";
            }
            else if (r2 == 2)
            {
                Question_Word = "x�̒l�����߂�\n(x + 7)(x + 9) = 0";
                Definition_Word = "x = -7 , x = -9";
                Miss_01 = "x = 7 , x = -9";
                Miss_02 = "x = -7 ,x = 9";
                Miss_03 = "x = 7 , x = 9";
            }
            else if (r2 == 3)
            {
                Question_Word = "x�̒l�����߂�\nx(x - 6) = 0";
                Definition_Word = "x = 0, x = 6";
                Miss_01 = "x = 0 , x = -6";
                Miss_02 = "x = 6";
                Miss_03 = "x = �}6";
            }
            else if (r2 == 4)
            {
                Question_Word = "x�̒l�����߂�\nx(x + 10) = 0";
                Definition_Word = "x = 0, x = -10";
                Miss_01 = "x = 0 , x = 10";
                Miss_02 = "x = -10";
                Miss_03 = "x = �}10";
            }
            else if (r2 == 5)
            {
                Question_Word = "x�̒l�����߂�\nx(x - 21) = 0";
                Definition_Word = "x = 0 , x = 21";
                Miss_01 = "x = 0 , x = -21";
                Miss_02 = "x = 21";
                Miss_03 = "x = �}21";
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
                Question_Word = "���̓񎟕�����������\n2x^2 + 3x - 1 = 0";
                Definition_Word = "x = -3�}��17/4";
                Miss_01 = "x = -4�}��17/4";
                Miss_02 = "x = 3�}��17/4";
                Miss_03 = "x = 4�}��17/4";
            }
            else if (r2 == 2)
            {
                Question_Word = "���̓񎟕�����������\n5x^2 - 9x + 3 = 0";
                Definition_Word = "x = 9�}��21/10";
                Miss_01 = "x = 8�}��21/10";
                Miss_02 = "x = -9�}��21/10";
                Miss_03 = "x = -8�}��21/10";
            }
            else if (r2 == 3)
            {
                Question_Word = "���̓񎟕�����������\n3x^2 - 2x - 2 = 0";
                Definition_Word = "x = 1�}��7/3";
                Miss_01 = "x = 2�}��7/3";
                Miss_02 = "x = -1�}��7/3";
                Miss_03 = "x = -2�}��7/3";
            }
            else if (r2 == 4)
            {
                Question_Word = "���̓񎟕�����������\n2x^2 + 5x - 1 = 0";
                Definition_Word = "x = -5�}��33/4";
                Miss_01 = "x = 6�}��33/4";
                Miss_02 = "x = 5�}��33/4";
                Miss_03 = "x = -6�}��33/4";
            }
            else if (r2 == 5)

            {
                Question_Word = "���̓񎟕�����������\n2x^2 - 4x + 1 = 0";
                Definition_Word = "x = 2�}��2/2";
                Miss_01 = "x = 3�}��2/2";
                Miss_02 = "x = -2�}��2/2";
                Miss_03 = "x = -3�}��2/2";
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
                Question_Word = "�召2�̐�������B���̍���8�Őς�48�ł���B���̂悤��2����S�ċ��߂�";
                Definition_Word = "12��4, -4 ��-12";
                Miss_01 = "12��4";
                Miss_02 = "12��-4";
                Miss_03 = "-4��12";
            }
            else if (r2 == 2)
            {
                Question_Word = "�A������3�̎��R��������B�������ق���2���̐ς�3�{�́A�傫���ق���2���̐ς�2�{���50�傫���B����3�̎��R�������߂�";
                Definition_Word = "9, 10, 11";
                Miss_01 = "8, 9, 10";
                Miss_02 = "7, 8, 9";
                Miss_03 = "6, 7, 8";
            }
            else if (r2 == 3)
            {
                Question_Word = "�召2�̐�������B���̍���4�Őς�96�ł���B����2�������߂�";
                Definition_Word = "12��8, -8��-12";
                Miss_01 = "0��4, 0��-4";
                Miss_02 = "12��8";
                Miss_03 = "-8��-12";
            }
            else if (r2 == 4)
            {
                Question_Word = "�召2�̐�������B���̘a��6�Őς�-16�ł���B����2�������߂�";
                Definition_Word = "8��-2";
                Miss_01 = "-8��-2";
                Miss_02 = "8��2";
                Miss_03 = "8��2, -8��-2";
            }
            else if (r2 == 5)
            {
                Question_Word = "�A������3�̎��R��������B���ꂼ��̐���2�悵�����̘a��50�ɂȂ�B����3�̎��R�������߂�";
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
            Question_Word = "y = 3x^2\n�̎��ɂāAx =" + r + "�������ꍇ��y�̒l�����߂�";
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
            Question_Word = "y =" + r +"x^2\nx�̒l��-2����5�̂悤�ɕω�����Ƃ��̕ω��̊��������߂�";
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
                Question_Word = "��ABC ���� ��ADE�ɂ� AB = 6cm ,AC = 5cm, AD = 4cm�̏ꍇ\nAE�̒��������߂�";
                Definition_Word = "10/3cm";
                Miss_01 = "3cm";
                Miss_02 = "4cm";
                Miss_03 = "8/3cm";
            }
            else if (r == 2)
            {
                Question_Word = "��ABC ���� ��ADE�ɂ� AB = 8cm ,AC = 6.5cm, AD = 5cm�̏ꍇ\nAE�̒��������߂�";
                Definition_Word = "65/16cm";
                Miss_01 = "4cm";
                Miss_02 = "5cm";
                Miss_03 = "67/16cm";
            }
            else if (r == 3)
            {
                Question_Word = "��ABC ���� ��ADE�ɂ� AB = 3cm ,AC = 2.7cm, AD = 2cm�̏ꍇ\nAE�̒��������߂�";
                Definition_Word = "9/5cm";
                Miss_01 = "2cm";
                Miss_02 = "3cm";
                Miss_03 = "8/5cm";
            }
            else if (r == 4)
            {
                Question_Word = "��ABC ���� ��ADE�ɂ� AB = 4cm ,AC = 3.5cm, AD = 3cm�̏ꍇ\nAE�̒��������߂�";
                Definition_Word = "21/8cm";
                Miss_01 = "3cm";
                Miss_02 = "2cm";
                Miss_03 = "11/4cm";
            }
            else if (r == 5)
            {
                Question_Word = "��ABC ���� ��ADE�ɂ� AB = 9cm ,AC = 7cm, AD = 6cm�̏ꍇ\nAE�̒��������߂�";
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
                Question_Word = "��ABC ���� ��DEF�̑����䂪3:5�������ꍇ��\n�ʐϔ�����߂�";
                Definition_Word = "9:25";
                Miss_01 = "27:125";
                Miss_02 = "8:23";
                Miss_03 = "10:27";
            }
            else if (r == 2)
            {
                Question_Word = "��ABC ���� ��DEF�̑����䂪2:3�������ꍇ��\n�ʐϔ�����߂�";
                Definition_Word = "4:9";
                Miss_01 = "8:27";
                Miss_02 = "5:8";
                Miss_03 = "5:11";
            }
            else if (r == 3)
            {
                Question_Word = "��ABC ���� ��DEF�̑����䂪4:7�������ꍇ��\n�ʐϔ�����߂�";
                Definition_Word = "16:49";
                Miss_01 = "27:343";
                Miss_02 = "17:47";
                Miss_03 = "29:345";
            }
            else if (r == 4)
            {
                Question_Word = "��ABC ���� ��DEF�̑����䂪1:3�������ꍇ��\n�ʐϔ�����߂�";
                Definition_Word = "1:9";
                Miss_01 = "1:27";
                Miss_02 = "1:12";
                Miss_03 = "1:28";
            }
            else if (r == 5)
            {
                Question_Word = "��ABC ���� ��DEF�̑����䂪5:6�������ꍇ��\n�ʐϔ�����߂�";
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
                Question_Word = "��ADB��48��,��DAC��30���̂Ƃ�\n��ACB�̊p�x�����߂�";
                Definition_Word = "��ACB = 48��";
                Miss_01 = "��ACB = 30��";
                Miss_02 = "��ACB = 45��";
                Miss_03 = "��ACB = 32��";
            }
            else if (r == 2)
            {
                Question_Word = "��ADB��45��,��DAC��32���̂Ƃ�\n��ACB�̊p�x�����߂�";
                Definition_Word = "��ACB = 45��";
                Miss_01 = "��ACB = 32��";
                Miss_02 = "��ACB = 49��";
                Miss_03 = "��ACB = 30��";
            }
            else if (r == 3)
            {
                Question_Word = "��ADB��46��,��DAC��33���̂Ƃ�\n��ACB�̊p�x�����߂�";
                Definition_Word = "��ACB = 46��";
                Miss_01 = "��ACB = 33��";
                Miss_02 = "��ACB = 47��";
                Miss_03 = "��ACB = 31��";
            }
            else if (r == 4)
            {
                Question_Word = "��ADB��50��,��DAC��35���̂Ƃ�\n��ACB�̊p�x�����߂�";
                Definition_Word = "��ACB = 50��";
                Miss_01 = "��ACB = 35��";
                Miss_02 = "��ACB = 52��";
                Miss_03 = "��ACB = 33��";
            }
            else if (r == 5)
            {
                Question_Word = "��ADB��52��,��DAC��29���̂Ƃ�\n��ACB�̊p�x�����߂�";
                Definition_Word = "��ACB = 52��";
                Miss_01 = "��ACB = 29��";
                Miss_02 = "��ACB = 50��";
                Miss_03 = "��ACB = 28��";
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
                Question_Word = "��BAC��25��,��BOC��50���̂Ƃ�\n��DFE�̊p�x�����߂�";
                Definition_Word = "��DFE = 25��";
                Miss_01 = "��ACB = 50��";
                Miss_02 = "��ACB = 27��";
                Miss_03 = "��ACB = 48��";
            }
            else if (r == 2)
            {
                Question_Word = "��BAC��26��,��BOC��52���̂Ƃ�\n��DFE�̊p�x�����߂�";
                Definition_Word = "��DFE = 26��";
                Miss_01 = "��ACB = 52��";
                Miss_02 = "��ACB = 28��";
                Miss_03 = "��ACB = 50��";
            }
            else if (r == 3)
            {
                Question_Word = "��BAC��24��,��BOC��48���̂Ƃ�\n��DFE�̊p�x�����߂�";
                Definition_Word = "��DFE = 24��";
                Miss_01 = "��ACB = 48��";
                Miss_02 = "��ACB = 25��";
                Miss_03 = "��ACB = 46��";
            }
            else if (r == 4)
            {
                Question_Word = "��BAC��27��,��BOC��54���̂Ƃ�\n��DFE�̊p�x�����߂�";
                Definition_Word = "��DFE = 27��";
                Miss_01 = "��ACB = 54��";
                Miss_02 = "��ACB = 25��";
                Miss_03 = "��ACB = 52��";
            }
            else if (r == 5)
            {
                Question_Word = "��BAC��22��,��BOC��44���̂Ƃ�\n��DFE�̊p�x�����߂�";
                Definition_Word = "��DFE = 22��";
                Miss_01 = "��ACB = 44��";
                Miss_02 = "��ACB = 24��";
                Miss_03 = "��ACB = 43��";
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
                Question_Word = "x = 5, y = 3�̂Ƃ���z�̒l��\n�O�����̒藝��p���ċ��߂�";
                Definition_Word = "z = ��34";
                Miss_01 = "z = ��35";
                Miss_02 = "z = 6";
                Miss_03 = "z = 2��8";
            }
            else if (r == 2)
            {
                Question_Word = "x = 6, y = 4�̂Ƃ���z�̒l��\n�O�����̒藝��p���ċ��߂�";
                Definition_Word = "z = 2��13";
                Miss_01 = "z = 2��14";
                Miss_02 = "z = 2��11";
                Miss_03 = "z = 4��3";
            }
            else if (r == 3)
            {
                Question_Word = "x = 3, y = 2�̂Ƃ���z�̒l��\n�O�����̒藝��p���ċ��߂�";
                Definition_Word = "z = ��13";
                Miss_01 = "z = ��14";
                Miss_02 = "z = ��15";
                Miss_03 = "z = 4";
            }
            else if (r == 4)
            {
                Question_Word = "x = 7, y = 4�̂Ƃ���z�̒l��\n�O�����̒藝��p���ċ��߂�";
                Definition_Word = "z = ��65";
                Miss_01 = "z = ��66";
                Miss_02 = "z = ��67";
                Miss_03 = "z = 8";
            }
            else if (r == 5)
            {
                Question_Word = "x = 9, y = 5�̂Ƃ���z�̒l��\n�O�����̒藝��p���ċ��߂�";
                Definition_Word = "z = ��106";
                Miss_01 = "z = ��105";
                Miss_02 = "z = 2��26";
                Miss_03 = "z = ��103";
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
                Question_Word = "���W(2,3)�̓_A�ƍ��W(5,1)�̓_B������\nAB�Ԃ̒��������߂�";
                Definition_Word = "AB = ��13";
                Miss_01 = "AB = ��14";
                Miss_02 = "AB = 2��3";
                Miss_03 = "AB = ��15";
            }
            else if (r == 2)
            {
                Question_Word = "���W(2,4)�̓_A�ƍ��W(3,7)�̓_B������\nAB�Ԃ̒��������߂�";
                Definition_Word = "AB = ��10";
                Miss_01 = "AB = ��11";
                Miss_02 = "AB = 2��3";
                Miss_03 = "AB = 3";
            }
            else if (r == 3)
            {
                Question_Word = "���W(2,2)�̓_A�ƍ��W(4,-5)�̓_B������\nAB�Ԃ̒��������߂�";
                Definition_Word = "AB = ��53";
                Miss_01 = "AB = 3��6";
                Miss_02 = "AB = ��55";
                Miss_03 = "AB = 2��13";
            }
            else if (r == 4)
            {
                Question_Word = "���W(2,2)�̓_A�ƍ��W(4,-5)�̓_B������\nAB�Ԃ̒��������߂�";
                Definition_Word = "AB = ��53";
                Miss_01 = "AB = 3��6";
                Miss_02 = "AB = ��55";
                Miss_03 = "AB = 2��13";
            }
            else if (r == 5)
            {
                Question_Word = "���W(2,-2)�̓_A�ƍ��W(3,5)�̓_B������\nAB�Ԃ̒��������߂�";
                Definition_Word = "AB = 5��2";
                Miss_01 = "AB = ��51";
                Miss_02 = "AB = 7";
                Miss_03 = "AB = 4��3";
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
                Question_Word = "���6cm, ��ʂ̔��a��4cm�̉~���̍��������߂�";
                Definition_Word = "2��5cm";
                Miss_01 = "��21cm";
                Miss_02 = "��22cm";
                Miss_03 = "��19cm";
            }
            else if (r == 2)
            {
                Question_Word = "���5cm, ��ʂ̔��a��3cm�̉~���̍��������߂�";
                Definition_Word = "4cm";
                Miss_01 = "��17cm";
                Miss_02 = "��15cm";
                Miss_03 = "3��2cm";
            }
            else if (r == 3)
            {
                Question_Word = "���7cm, ��ʂ̔��a��3cm�̉~���̍��������߂�";
                Definition_Word = "2��10cm";
                Miss_01 = "��41cm";
                Miss_02 = "��39cm";
                Miss_03 = "��38cm";
            }
            else if (r == 4)
            {
                Question_Word = "���6cm, ��ʂ̔��a��5cm�̉~���̍��������߂�";
                Definition_Word = "��11cm";
                Miss_01 = "2��3cm";
                Miss_02 = "��13cm";
                Miss_03 = "��10cm";
            }
            else if (r == 5)
            {
                Question_Word = "���9cm, ��ʂ̔��a��6cm�̉~���̍��������߂�";
                Definition_Word = "3��5cm";
                Miss_01 = "��46cm";
                Miss_02 = "2��11cm";
                Miss_03 = "��43cm";
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
                Question_Word = "������������\nx^4 - 16";
                Definition_Word = "(x^2 + 4)(x + 2)(x - 2)";
                Miss_01 = "(x + 2)(x - 2)(x + 2)(x - 2)";
                Miss_02 = "(x + 2)^2(x - 2)^2";
                Miss_03 = "�ł��Ȃ�";
            }
            else if (r == 2)
            {
                Question_Word = "������������\nx^4 - 16y^4";
                Definition_Word = "(x^2 + 4y^2)(x + 2y)(x - 2y)";
                Miss_01 = "(x + 2y)(x - 2y)(x + 2y)(x - 2y)";
                Miss_02 = "(x + 2y)^2(x - 2y)^2";
                Miss_03 = "�ł��Ȃ�";
            }
            else if (r == 3)
            {
                Question_Word = "������������\n16 - x^4";
                Definition_Word = "(4 + x^2)(2 + x)(2 - x)";
                Miss_01 = "(2 + x)(2 - x)(2 + x)(2 - x)";
                Miss_02 = "(2 + x)^2(2 - x)^2";
                Miss_03 = "�ł��Ȃ�";
            }
            else if (r == 4)
            {
                Question_Word = "������������\n16y^4 - x^4";
                Definition_Word = "(4y^2 + x^2)(2y + x)(2y - x)";
                Miss_01 = "(2y + x)(2y - x)(2y + x)(2y - x)";
                Miss_02 = "(2y + x)^2(2y - x)^2";
                Miss_03 = "�ł��Ȃ�";
            }
            else if (r == 5)
            {
                Question_Word = "������������\nx^8 - 16";
                Definition_Word = "(x^4 + 4)(x^2 + 2)(x^2 - 2)";
                Miss_01 = "(x^2 + 2)(x^2 - 2)(x^2 + 2)(x^2 - 2)";
                Miss_02 = "(x^2 + 2)^2(x^2 - 2)^2";
                Miss_03 = "�ł��Ȃ�";
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
                Question_Word = "�f������������\n320";
                Definition_Word = "2^6 �~ 5";
                Miss_01 = "2^5 �~ 5";
                Miss_02 = "2^6 �~ 5^2";
                Miss_03 = "2^5 �~ 5^2";
            }
            else if (r == 2)
            {
                Question_Word = "�f������������\n200";
                Definition_Word = "2^3 �~ 5^2";
                Miss_01 = "2^2 �~ 5^3";
                Miss_02 = "2^4 �~ 5";
                Miss_03 = "2^3 �~ 3^2";
            }
            else if (r == 3)
            {
                Question_Word = "�f������������\n408";
                Definition_Word = "2^3 �~ 3 �~ 17";
                Miss_01 = "2^3 �~ 3^3";
                Miss_02 = "2^4 �~ 17";
                Miss_03 = "3 �~ 7^3";
            }
            else if (r == 4)
            {
                Question_Word = "�f������������\n500";
                Definition_Word = "2^2 �~ 5^3";
                Miss_01 = "2^3 �~ 5^2";
                Miss_02 = "2^4 �~ 5";
                Miss_03 = "2^6 �~ 5";
            }
            else if (r == 5)
            {
                Question_Word = "�f������������\n1000";
                Definition_Word = "2^3 �~ 5^3";
                Miss_01 = "2^4 �~ 5^2";
                Miss_02 = "2^5 �~ 5";
                Miss_03 = "2^6 �~ 5^2";
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
                Question_Word = "��, ��10�̑召�𓚂���";
                Definition_Word = "�� < ��10";
                Miss_01 = "�� > ��10";
                Miss_02 = "��10 < ��";
                Miss_03 = "�� = ��10";
            }
            else if (r == 2)
            {
                Question_Word = "9, ��81�̑召�𓚂���";
                Definition_Word = "9 = ��81";
                Miss_01 = "9 > ��81";
                Miss_02 = "��81 < 9";
                Miss_03 = "9 < ��81";
            }
            else if (r == 3)
            {
                Question_Word = "2��2, ��3�̑召�𓚂���";
                Definition_Word = "2��2 > ��3";
                Miss_01 = "��3 > 2��2";
                Miss_02 = "2��2 < ��3";
                Miss_03 = "2��2 = ��3";
            }
            else if (r == 4)
            {
                Question_Word = "3, ��9�̑召�𓚂���";
                Definition_Word = "3 = ��9";
                Miss_01 = "3 > ��9";
                Miss_02 = "��9 < 3";
                Miss_03 = "��9 > 3";
            }
            else if (r == 5)
            {
                Question_Word = "��, 3�̑召�𓚂���";
                Definition_Word = "�� > 3";
                Miss_01 = "�� < 3";
                Miss_02 = "3 > ��";
                Miss_03 = "3 = ��";
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
                Question_Word = "�ΕӈȊO��3cm, 4cm�̒��p�O�p�`�̎Εӂ̒��������߂�";
                Definition_Word = "5cm";
                Miss_01 = "6cm";
                Miss_02 = "7cm";
                Miss_03 = "��7";
            }
            else if (r == 2)
            {
                Question_Word = "�ΕӈȊO��5cm, 12cm�̒��p�O�p�`�̎Εӂ̒��������߂�";
                Definition_Word = "13cm";
                Miss_01 = "14cm";
                Miss_02 = "12cm";
                Miss_03 = "��14";
            }
            else if (r == 3)
            {
                Question_Word = "�ΕӈȊO��6cm, 8cm�̒��p�O�p�`�̎Εӂ̒��������߂�";
                Definition_Word = "10cm";
                Miss_01 = "11cm";
                Miss_02 = "12cm";
                Miss_03 = "��11cm";
            }
            else if (r == 4)
            {
                Question_Word = "�ΕӈȊO��7cm, 24cm�̒��p�O�p�`�̎Εӂ̒��������߂�";
                Definition_Word = "25cm";
                Miss_01 = "26cm";
                Miss_02 = "27cm";
                Miss_03 = "��41";
            }
            else if (r == 5)
            {
                Question_Word = "�ΕӈȊO��10cm, 24cm�̒��p�O�p�`�̎Εӂ̒��������߂�";
                Definition_Word = "26cm";
                Miss_01 = "27cm";
                Miss_02 = "25cm";
                Miss_03 = "��29";
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
                Question_Word = "�����䂪3:2�̕��ʐ}�`A��B������\nA�̖ʐς�24cm^2�̏ꍇ��B�̖ʐς����߂�";
                Definition_Word = "32/3cm^2";
                Miss_01 = "16cm^2";
                Miss_02 = "31/3cm^2";
                Miss_03 = "12cm^2";
            }
            else if (r == 2)
            {
                Question_Word = "�����䂪3:1�̕��ʐ}�`A��B������\nA�̖ʐς�24cm^2�̏ꍇ��B�̖ʐς����߂�";
                Definition_Word = "8/3cm^2";
                Miss_01 = "3cm^2";
                Miss_02 = "7/3cm^2";
                Miss_03 = "4cm^2";
            }
            else if (r == 3)
            {
                Question_Word = "�����䂪2:1�̕��ʐ}�`A��B������\nA�̖ʐς�20cm^2�̏ꍇ��B�̖ʐς����߂�";
                Definition_Word = "5cm^2";
                Miss_01 = "10cm^2";
                Miss_02 = "5/2cm^2";
                Miss_03 = "11/2cm^2";
            }
            else if (r == 4)
            {
                Question_Word = "�����䂪4:3�̕��ʐ}�`A��B������\nA�̖ʐς�20cm^2�̏ꍇ��B�̖ʐς����߂�";
                Definition_Word = "45/4cm^2";
                Miss_01 = "31/2cm^2";
                Miss_02 = "16cm^2";
                Miss_03 = "33/2cm^2";
            }
            else if (r == 5)
            {
                Question_Word = "�����䂪5:2�̕��ʐ}�`A��B������\nA�̖ʐς�30cm^2�̏ꍇ��B�̖ʐς����߂�";
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
                Question_Word = "�����䂪3:2�̗���A��B������\nA�̑̐ς�81cm^3�̏ꍇ��B�̑̐ς����߂�";
                Definition_Word = "24cm^3";
                Miss_01 = "23cm^3";
                Miss_02 = "25cm^3";
                Miss_03 = "22cm^3";
            }
            else if (r == 2)
            {
                Question_Word = "�����䂪3:1�̗���A��B������\nA�̑̐ς�81cm^3�̏ꍇ��B�̑̐ς����߂�";
                Definition_Word = "3cm^3";
                Miss_01 = "4cm^3";
                Miss_02 = "5cm^3";
                Miss_03 = "2cm^3";
            }
            else if (r == 3)
            {
                Question_Word = "�����䂪2:1�̗���A��B������\nA�̑̐ς�50cm^3�̏ꍇ��B�̑̐ς����߂�";
                Definition_Word = "25/4cm^3";
                Miss_01 = "23/4cm^3";
                Miss_02 = "12cm^3";
                Miss_03 = "13/2cm^3";
            }
            else if (r == 4)
            {
                Question_Word = "�����䂪4:3�̗���A��B������\nA�̑̐ς�50cm^3�̏ꍇ��B�̑̐ς����߂�";
                Definition_Word = "675/32cm^3";
                Miss_01 = "169/8cm^3";
                Miss_02 = "677/32cm^3";
                Miss_03 = "337/16cm^3";
            }
            else if (r == 5)
            {
                Question_Word = "�����䂪5:2�̗���A��B������\nA�̑̐ς�60cm^3�̏ꍇ��B�̑̐ς����߂�";
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
            //���p���(��������������4��)
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
                    Question_Word = "x^2 + xy - 4x - y + 3\n�̎���������������";
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
                    Question_Word = "��,�����ꂼ��5�ʂ̃T�C�R����U�����Ƃ��̏o��ڂ��ׂđ����ꍇ\n�ł��o��\���̍���2�̃T�C�R���̘a�����߂�";
                    Definition_Word = "6";
                    Miss_01 = "5";
                    Miss_02 = "�\���̍����a�͖���";
                    Miss_03 = "5��6";
                }
                else if (r2 == 2)
                {
                    Question_Word = "��,��,�����ꂼ��T�C�R����U�����Ƃ��̏o��ڂ��ׂđ����ꍇ\n�ł��o��\���̍���3�̃T�C�R���̘a�����߂�";
                    Definition_Word = "10��11";
                    Miss_01 = "�\���̍����a�͖���";
                    Miss_02 = "8��13";
                    Miss_03 = "9";
                }
                else if (r2 == 3)
                {
                    Question_Word = "��,�����ꂼ��T�C�R����U�����Ƃ��̏o��ڂ��ׂđ����ꍇ\n�ł��o��\���̍���2�̃T�C�R���̘a�����߂�";
                    Definition_Word = "7";
                    Miss_01 = "�\���̍����a�͖���";
                    Miss_02 = "6";
                    Miss_03 = "6��7";
                }
                else if (r2 == 4)
                {
                    Question_Word = "��,��,��,�����ꂼ��T�C�R����U�����Ƃ��̏o��ڂ��ׂđ����ꍇ\n�ł��o��\���̍���4�̃T�C�R���̘a�����߂�";
                    Definition_Word = "14";
                    Miss_01 = "�\���̍����a�͖���";
                    Miss_02 = "12";
                    Miss_03 = "12��13";
                }
                else if (r2 == 5)
                {
                    Question_Word = "��,��,�����ꂼ��5�ʂ̃T�C�R����U�����Ƃ��̏o��ڂ��ׂđ����ꍇ\n�ł��o��\���̍���4�̃T�C�R���̘a�����߂�";
                    Definition_Word = "9";
                    Miss_01 = "�\���̍����a�͖���";
                    Miss_02 = "7��8";
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
                    Question_Word = "���钆�w�Z�̐��k80�l���w�̓e�X�g���󌱂����B�S�̂̕��ϓ_��58�_�ŁA�j�q�̕��ϓ_��52�_�A���q�̕��ϓ_��62�_�ł������B�j�q�E���q�̐l���͂��ꂼ�ꉽ�l�����߂�";
                    Definition_Word = "�j�q32�l�A���q48�l";
                    Miss_01 = "�j�q48�l�A���q32�l";
                    Miss_02 = "�j�q38�l�A���q42�l";
                    Miss_03 = "�j�q42�l�A���q38�l";
                }
                else if (r2 == 2)
                {
                    FontSize = 34;
                    Question_Word = "����2400m�̒r���AA�AB2�l�������ɓ����n�_����������B���΂̕����ɕ�����2�l��15���ŏo��A���������ɕ�����60����A��B�����߂Ēǂ��������BA�AB�͂��ꂼ�ꕪ����m�ŕ����������߂�";
                    Definition_Word = "A=����100m�AB=����60m";
                    Miss_01 = "A=����60m�AB=����100m";
                    Miss_02 = "A=����160m�AB=����40m";
                    Miss_03 = "A=����40m�AB=����160m";
                }
                else if (r2 == 3)
                {
                    FontSize = 27;
                    Text_01_T.FontSize = 27;
                    Text_02_T.FontSize = 27;
                    Question_Word = "�����Ԃ����̑����ő����Ă���B���̗�Ԃ�����570m�̓S����n��͂��߂Ă���n��I���܂ł�18�b���������B�܂��A����3500m�̃g���l����������Ƃ��A���̗�Ԃ��������肩����Ă��鎞�Ԃ�56�b�ł������B���̗�Ԃ̒����Ƒ��������ꂼ�ꋁ�߂�";
                    Definition_Word = "��Ԃ̒���=420m�A��Ԃ̑���=�b��55m";
                    Miss_01 = "��Ԃ̒���=380m�A��Ԃ̑���=�b��65m";
                    Miss_02 = "��Ԃ̒���=290m�A��Ԃ̑���=�b��45m";
                    Miss_03 = "��Ԃ̒���=500m�A��Ԃ̑���=�b��75m";
                }
                else if (r2 == 4)
                {
                    FontSize = 25;
                    Question_Word = "�e��A�Ɨe��B�ɁA�Z���̈Ⴄ�H���������ꂼ��400g������B�e��A����H������200g�Ƃ�e��B�Ɉڂ�����A�e��B�ɂ�4%�̐H����600g���ł����B���̂��ƁA�e��B����H������200g�Ƃ�e��A�Ɉڂ�����A�e��A�ɂ�6%�̐H����400g���ł����B�ŏ��A�e��A�A�e��B�ɂ͂��ꂼ�ꉽ%�̐H�����������������߂�";
                    Definition_Word = "�e��A�̐H����=8%�A�e��B�̐H����=2%";
                    Miss_01 = "�e��A�̐H����=2%�A�e��B�̐H����=8%";
                    Miss_02 = "�e��A�̐H����=6%�A�e��B�̐H����=4%";
                    Miss_03 = "�e��A�̐H����=4%�A�e��B�̐H����=6%";
                }
                else if (r2 == 5)
                {
                    FontSize = 25;
                    Question_Word = "�Z�ƒ�̏������̔��5:3�ł������B�Z��������300�~���炢�A�킪120�~�g������A�������̔䂪5:2�ɂȂ����B�͂��߂ɌZ�ƒ�͂��ꂼ�ꉽ�~�����Ă��������߂�";
                    Definition_Word = "�Z�̏�����=1200�~�A��̏�����=720�~";
                    Miss_01 = "�Z�̏�����=720�~�A��̏�����=1200�~";
                    Miss_02 = "�Z�̏�����=920�~�A��̏�����=552�~";
                    Miss_03 = "�Z�̏�����=522�~�A��̏�����=920�~";
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