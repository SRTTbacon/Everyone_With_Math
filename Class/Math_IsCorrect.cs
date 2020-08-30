using System.Windows;
using System.Xml.Linq;
using System.IO;

namespace Everyone_With_Math.Class
{
    public partial class Math_01 : Window
    {
        int Grade_Number = 0;
        void Choice_Math_Number_Correct(bool Correct)
        {
            //選んだボタンが1番だったらtrue,その他はfalseとして記録
            if (Grade_Number == 1)
            {
                if (Question_Number == 1)
                {
                    Question_01_01_Answer = Correct;
                }
                else if (Question_Number == 2)
                {
                    Question_01_02_Answer = Correct;
                }
                else if (Question_Number == 3)
                {
                    Question_01_03_Answer = Correct;
                }
                else if (Question_Number == 4)
                {
                    Question_01_04_Answer = Correct;
                }
                else if (Question_Number == 5)
                {
                    Question_01_05_Answer = Correct;
                }
                else if (Question_Number == 6)
                {
                    Question_01_06_Answer = Correct;
                }
                else if (Question_Number == 7)
                {
                    Question_01_07_Answer = Correct;
                }
                else if (Question_Number == 8)
                {
                    Question_01_08_Answer = Correct;
                }
                else if (Question_Number == 9)
                {
                    Question_01_09_Answer = Correct;
                }
                else if (Question_Number == 10)
                {
                    Question_01_10_Answer = Correct;
                }
                else if (Question_Number == 11)
                {
                    Question_01_11_Answer = Correct;
                }
                else if (Question_Number == 12)
                {
                    Question_01_12_Answer = Correct;
                }
                else if (Question_Number == 13)
                {
                    Question_01_13_Answer = Correct;
                }
                else if (Question_Number == 14)
                {
                    Question_01_14_Answer = Correct;
                }
                else if (Question_Number == 15)
                {
                    Question_01_15_Answer = Correct;
                }
                else if (Question_Number == 16)
                {
                    Question_01_16_Answer = Correct;
                }
                else if (Question_Number == 17)
                {
                    Question_01_17_Answer = Correct;
                }
                else if (Question_Number == 18)
                {
                    Question_01_18_Answer = Correct;
                }
                else if (Question_Number == 19)
                {
                    Question_01_19_Answer = Correct;
                }
                else if (Question_Number == 20)
                {
                    Question_01_20_Answer = Correct;
                }
                else if (Question_Number == 21)
                {
                    Question_01_21_Answer = Correct;
                }
                else if (Question_Number == 22)
                {
                    Question_01_22_Answer = Correct;
                }
                else if (Question_Number == 23)
                {
                    Question_01_23_Answer = Correct;
                }
                else if (Question_Number == 24)
                {
                    Question_01_24_Answer = Correct;
                }
                else if (Question_Number == 25)
                {
                    Question_01_25_Answer = Correct;
                }
                else if (Question_Number == 26)
                {
                    Question_01_26_Answer = Correct;
                }
                else if (Question_Number == 27)
                {
                    Question_01_27_Answer = Correct;
                }
                else if (Question_Number == 28)
                {
                    Question_01_28_Answer = Correct;
                }
                else if (Question_Number == 29)
                {
                    Question_01_29_Answer = Correct;
                }
                else if (Question_Number == 30)
                {
                    Question_01_30_Answer = Correct;
                }
            }
            else if (Grade_Number == 2)
            {
                if (Question_Number == 1)
                {
                    Question_02_01_Answer = Correct;
                }
                else if (Question_Number == 2)
                {
                    Question_02_02_Answer = Correct;
                }
                else if (Question_Number == 3)
                {
                    Question_02_03_Answer = Correct;
                }
                else if (Question_Number == 4)
                {
                    Question_02_04_Answer = Correct;
                }
                else if (Question_Number == 5)
                {
                    Question_02_05_Answer = Correct;
                }
                else if (Question_Number == 6)
                {
                    Question_02_06_Answer = Correct;
                }
                else if (Question_Number == 7)
                {
                    Question_02_07_Answer = Correct;
                }
                else if (Question_Number == 8)
                {
                    Question_02_08_Answer = Correct;
                }
                else if (Question_Number == 9)
                {
                    Question_02_09_Answer = Correct;
                }
                else if (Question_Number == 10)
                {
                    Question_02_10_Answer = Correct;
                }
                else if (Question_Number == 11)
                {
                    Question_02_11_Answer = Correct;
                }
                else if (Question_Number == 12)
                {
                    Question_02_12_Answer = Correct;
                }
                else if (Question_Number == 13)
                {
                    Question_02_13_Answer = Correct;
                }
                else if (Question_Number == 14)
                {
                    Question_02_14_Answer = Correct;
                }
                else if (Question_Number == 15)
                {
                    Question_02_15_Answer = Correct;
                }
                else if (Question_Number == 16)
                {
                    Question_02_16_Answer = Correct;
                }
                else if (Question_Number == 17)
                {
                    Question_02_17_Answer = Correct;
                }
                else if (Question_Number == 18)
                {
                    Question_02_18_Answer = Correct;
                }
                else if (Question_Number == 19)
                {
                    Question_02_19_Answer = Correct;
                }
                else if (Question_Number == 20)
                {
                    Question_02_20_Answer = Correct;
                }
                else if (Question_Number == 21)
                {
                    Question_02_21_Answer = Correct;
                }
                else if (Question_Number == 22)
                {
                    Question_02_22_Answer = Correct;
                }
                else if (Question_Number == 23)
                {
                    Question_02_23_Answer = Correct;
                }
                else if (Question_Number == 24)
                {
                    Question_02_24_Answer = Correct;
                }
                else if (Question_Number == 25)
                {
                    Question_02_25_Answer = Correct;
                }
                else if (Question_Number == 26)
                {
                    Question_02_26_Answer = Correct;
                }
                else if (Question_Number == 27)
                {
                    Question_02_27_Answer = Correct;
                }
                else if (Question_Number == 28)
                {
                    Question_02_28_Answer = Correct;
                }
                else if (Question_Number == 29)
                {
                    Question_02_29_Answer = Correct;
                }
                else if (Question_Number == 30)
                {
                    Question_02_30_Answer = Correct;
                }
            }
            else if (Grade_Number == 3)
            {
                if (Question_Number == 1)
                {
                    Question_03_01_Answer = Correct;
                }
                else if (Question_Number == 2)
                {
                    Question_03_03_Answer = Correct;
                }
                else if (Question_Number == 3)
                {
                    Question_03_03_Answer = Correct;
                }
                else if (Question_Number == 4)
                {
                    Question_03_04_Answer = Correct;
                }
                else if (Question_Number == 5)
                {
                    Question_03_05_Answer = Correct;
                }
                else if (Question_Number == 6)
                {
                    Question_03_06_Answer = Correct;
                }
                else if (Question_Number == 7)
                {
                    Question_03_07_Answer = Correct;
                }
                else if (Question_Number == 8)
                {
                    Question_03_08_Answer = Correct;
                }
                else if (Question_Number == 9)
                {
                    Question_03_09_Answer = Correct;
                }
                else if (Question_Number == 10)
                {
                    Question_03_10_Answer = Correct;
                }
                else if (Question_Number == 11)
                {
                    Question_03_11_Answer = Correct;
                }
                else if (Question_Number == 12)
                {
                    Question_03_12_Answer = Correct;
                }
                else if (Question_Number == 13)
                {
                    Question_03_13_Answer = Correct;
                }
                else if (Question_Number == 14)
                {
                    Question_03_14_Answer = Correct;
                }
                else if (Question_Number == 15)
                {
                    Question_03_15_Answer = Correct;
                }
                else if (Question_Number == 16)
                {
                    Question_03_16_Answer = Correct;
                }
                else if (Question_Number == 17)
                {
                    Question_03_17_Answer = Correct;
                }
                else if (Question_Number == 18)
                {
                    Question_03_18_Answer = Correct;
                }
                else if (Question_Number == 19)
                {
                    Question_03_19_Answer = Correct;
                }
                else if (Question_Number == 20)
                {
                    Question_03_20_Answer = Correct;
                }
                else if (Question_Number == 21)
                {
                    Question_03_21_Answer = Correct;
                }
                else if (Question_Number == 22)
                {
                    Question_03_22_Answer = Correct;
                }
                else if (Question_Number == 23)
                {
                    Question_03_23_Answer = Correct;
                }
                else if (Question_Number == 24)
                {
                    Question_03_24_Answer = Correct;
                }
                else if (Question_Number == 25)
                {
                    Question_03_25_Answer = Correct;
                }
                else if (Question_Number == 26)
                {
                    Question_03_26_Answer = Correct;
                }
                else if (Question_Number == 27)
                {
                    Question_03_27_Answer = Correct;
                }
                else if (Question_Number == 28)
                {
                    Question_03_28_Answer = Correct;
                }
                else if (Question_Number == 29)
                {
                    Question_03_29_Answer = Correct;
                }
                else if (Question_Number == 30)
                {
                    Question_03_30_Answer = Correct;
                }
            }
            else if (Difficult_Question_Mode == true)
            {
                if (Difficult_Question_Number == 1)
                {
                    Difficult_Question_Number_01_Correct = Correct;
                }
                else if (Difficult_Question_Number == 2)
                {
                    Difficult_Question_Number_02_Correct = Correct;
                }
                else if (Difficult_Question_Number == 3)
                {
                    Difficult_Question_Number_03_Correct = Correct;
                }
                else if (Difficult_Question_Number == 4)
                {
                    Difficult_Question_Number_04_Correct = Correct;
                }
                else if (Difficult_Question_Number == 5)
                {
                    Difficult_Question_Number_05_Correct = Correct;
                }
            }
        }
        void Load_Question_Answer_01()
        {
            //セーブデータが1学年だった場合1学年の問題の解答を取得
            XDocument xml = XDocument.Load(Path + "/Resources/Save/Save_10.dat");
            XElement item = xml.Element("Save_Definition");
            Question_01_01_Answer = bool.Parse(item.Element("Question_01_01_Answer").Value);
            Question_01_02_Answer = bool.Parse(item.Element("Question_01_02_Answer").Value);
            Question_01_03_Answer = bool.Parse(item.Element("Question_01_03_Answer").Value);
            Question_01_04_Answer = bool.Parse(item.Element("Question_01_04_Answer").Value);
            Question_01_05_Answer = bool.Parse(item.Element("Question_01_05_Answer").Value);
            Question_01_06_Answer = bool.Parse(item.Element("Question_01_06_Answer").Value);
            Question_01_07_Answer = bool.Parse(item.Element("Question_01_07_Answer").Value);
            Question_01_08_Answer = bool.Parse(item.Element("Question_01_08_Answer").Value);
            Question_01_09_Answer = bool.Parse(item.Element("Question_01_09_Answer").Value);
            Question_01_10_Answer = bool.Parse(item.Element("Question_01_10_Answer").Value);
            Question_01_11_Answer = bool.Parse(item.Element("Question_01_11_Answer").Value);
            Question_01_12_Answer = bool.Parse(item.Element("Question_01_12_Answer").Value);
            Question_01_13_Answer = bool.Parse(item.Element("Question_01_13_Answer").Value);
            Question_01_14_Answer = bool.Parse(item.Element("Question_01_14_Answer").Value);
            Question_01_15_Answer = bool.Parse(item.Element("Question_01_15_Answer").Value);
            Question_01_16_Answer = bool.Parse(item.Element("Question_01_16_Answer").Value);
            Question_01_17_Answer = bool.Parse(item.Element("Question_01_17_Answer").Value);
            Question_01_18_Answer = bool.Parse(item.Element("Question_01_18_Answer").Value);
            Question_01_19_Answer = bool.Parse(item.Element("Question_01_19_Answer").Value);
            Question_01_20_Answer = bool.Parse(item.Element("Question_01_20_Answer").Value);
            Question_01_21_Answer = bool.Parse(item.Element("Question_01_21_Answer").Value);
            Question_01_22_Answer = bool.Parse(item.Element("Question_01_22_Answer").Value);
            Question_01_23_Answer = bool.Parse(item.Element("Question_01_23_Answer").Value);
            Question_01_24_Answer = bool.Parse(item.Element("Question_01_24_Answer").Value);
            Question_01_25_Answer = bool.Parse(item.Element("Question_01_25_Answer").Value);
            Question_01_26_Answer = bool.Parse(item.Element("Question_01_26_Answer").Value);
            Question_01_27_Answer = bool.Parse(item.Element("Question_01_27_Answer").Value);
            Question_01_28_Answer = bool.Parse(item.Element("Question_01_28_Answer").Value);
            Question_01_29_Answer = bool.Parse(item.Element("Question_01_29_Answer").Value);
            Question_01_30_Answer = bool.Parse(item.Element("Question_01_30_Answer").Value);
            File.Delete(Path + "/Resources/Save/Save_10.dat");
        }
        void Load_Question_Answer_02()
        {
            //セーブデータが2学年だった場合2学年の問題の解答を取得
            XDocument xml = XDocument.Load(Path + "/Resources/Save/Save_10.dat");
            XElement item = xml.Element("Save_Definition");
            Question_02_01_Answer = bool.Parse(item.Element("Question_02_01_Answer").Value);
            Question_02_02_Answer = bool.Parse(item.Element("Question_02_02_Answer").Value);
            Question_02_03_Answer = bool.Parse(item.Element("Question_02_03_Answer").Value);
            Question_02_04_Answer = bool.Parse(item.Element("Question_02_04_Answer").Value);
            Question_02_05_Answer = bool.Parse(item.Element("Question_02_05_Answer").Value);
            Question_02_06_Answer = bool.Parse(item.Element("Question_02_06_Answer").Value);
            Question_02_07_Answer = bool.Parse(item.Element("Question_02_07_Answer").Value);
            Question_02_08_Answer = bool.Parse(item.Element("Question_02_08_Answer").Value);
            Question_02_09_Answer = bool.Parse(item.Element("Question_02_09_Answer").Value);
            Question_02_10_Answer = bool.Parse(item.Element("Question_02_10_Answer").Value);
            Question_02_11_Answer = bool.Parse(item.Element("Question_02_11_Answer").Value);
            Question_02_12_Answer = bool.Parse(item.Element("Question_02_12_Answer").Value);
            Question_02_13_Answer = bool.Parse(item.Element("Question_02_13_Answer").Value);
            Question_02_14_Answer = bool.Parse(item.Element("Question_02_14_Answer").Value);
            Question_02_15_Answer = bool.Parse(item.Element("Question_02_15_Answer").Value);
            Question_02_16_Answer = bool.Parse(item.Element("Question_02_16_Answer").Value);
            Question_02_17_Answer = bool.Parse(item.Element("Question_02_17_Answer").Value);
            Question_02_18_Answer = bool.Parse(item.Element("Question_02_18_Answer").Value);
            Question_02_19_Answer = bool.Parse(item.Element("Question_02_19_Answer").Value);
            Question_02_20_Answer = bool.Parse(item.Element("Question_02_20_Answer").Value);
            Question_02_21_Answer = bool.Parse(item.Element("Question_02_21_Answer").Value);
            Question_02_22_Answer = bool.Parse(item.Element("Question_02_22_Answer").Value);
            Question_02_23_Answer = bool.Parse(item.Element("Question_02_23_Answer").Value);
            Question_02_24_Answer = bool.Parse(item.Element("Question_02_24_Answer").Value);
            Question_02_25_Answer = bool.Parse(item.Element("Question_02_25_Answer").Value);
            Question_02_26_Answer = bool.Parse(item.Element("Question_02_26_Answer").Value);
            Question_02_27_Answer = bool.Parse(item.Element("Question_02_27_Answer").Value);
            Question_02_28_Answer = bool.Parse(item.Element("Question_02_28_Answer").Value);
            Question_02_29_Answer = bool.Parse(item.Element("Question_02_29_Answer").Value);
            Question_02_30_Answer = bool.Parse(item.Element("Question_02_30_Answer").Value);
            File.Delete(Path + "/Resources/Save/Save_10.dat");
        }
        void Load_Question_Answer_03()
        {
            //セーブデータが3学年だった場合3学年の問題の解答を取得
            XDocument xml = XDocument.Load(Path + "/Resources/Save/Save_10.dat");
            XElement item = xml.Element("Save_Definition");
            Question_03_01_Answer = bool.Parse(item.Element("Question_03_01_Answer").Value);
            Question_03_02_Answer = bool.Parse(item.Element("Question_03_02_Answer").Value);
            Question_03_03_Answer = bool.Parse(item.Element("Question_03_03_Answer").Value);
            Question_03_04_Answer = bool.Parse(item.Element("Question_03_04_Answer").Value);
            Question_03_05_Answer = bool.Parse(item.Element("Question_03_05_Answer").Value);
            Question_03_06_Answer = bool.Parse(item.Element("Question_03_06_Answer").Value);
            Question_03_07_Answer = bool.Parse(item.Element("Question_03_07_Answer").Value);
            Question_03_08_Answer = bool.Parse(item.Element("Question_03_08_Answer").Value);
            Question_03_09_Answer = bool.Parse(item.Element("Question_03_09_Answer").Value);
            Question_03_10_Answer = bool.Parse(item.Element("Question_03_10_Answer").Value);
            Question_03_11_Answer = bool.Parse(item.Element("Question_03_11_Answer").Value);
            Question_03_12_Answer = bool.Parse(item.Element("Question_03_12_Answer").Value);
            Question_03_13_Answer = bool.Parse(item.Element("Question_03_13_Answer").Value);
            Question_03_14_Answer = bool.Parse(item.Element("Question_03_14_Answer").Value);
            Question_03_15_Answer = bool.Parse(item.Element("Question_03_15_Answer").Value);
            Question_03_16_Answer = bool.Parse(item.Element("Question_03_16_Answer").Value);
            Question_03_17_Answer = bool.Parse(item.Element("Question_03_17_Answer").Value);
            Question_03_18_Answer = bool.Parse(item.Element("Question_03_18_Answer").Value);
            Question_03_19_Answer = bool.Parse(item.Element("Question_03_19_Answer").Value);
            Question_03_20_Answer = bool.Parse(item.Element("Question_03_20_Answer").Value);
            Question_03_21_Answer = bool.Parse(item.Element("Question_03_21_Answer").Value);
            Question_03_22_Answer = bool.Parse(item.Element("Question_02_22_Answer").Value);
            Question_03_23_Answer = bool.Parse(item.Element("Question_03_23_Answer").Value);
            Question_03_24_Answer = bool.Parse(item.Element("Question_03_24_Answer").Value);
            Question_03_25_Answer = bool.Parse(item.Element("Question_03_25_Answer").Value);
            Question_03_26_Answer = bool.Parse(item.Element("Question_03_26_Answer").Value);
            Question_03_27_Answer = bool.Parse(item.Element("Question_03_27_Answer").Value);
            Question_03_28_Answer = bool.Parse(item.Element("Question_03_28_Answer").Value);
            Question_03_29_Answer = bool.Parse(item.Element("Question_03_29_Answer").Value);
            Question_03_30_Answer = bool.Parse(item.Element("Question_03_30_Answer").Value);
            File.Delete(Path + "/Resources/Save/Save_10.dat");
        }
    }
}