using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Everyone_With_Math.Class
{
    public partial class Math_01 : Window
    {
        bool Choice_Click = false;
        int Choice_01_Story_Next = 0;
        int Choice_02_Story_Next = 0;
        int Choice_03_Story_Next = 0;
        bool Choice_Show_Story_Not_Next = false;
        bool Math_Image_Play = false;
        int Animation_Image = 2;
        string Image_Random = "";
        int Question_Number = 1;
        string Math_Image_Source = "";
        int Correct_Answer_Number = 0;
        bool IsGrade_1_2_3_Clear = false;
        int Story_File_Number = 0;
        bool Grade_1_2_3_Clear_After_Story = false;
        bool Is_Chara_04_Feed_In = false;
        bool Is_Chara_04_Feed_Out = false;
        void Text_Event()
        {
            //文章が特定の場所に行ったらイベントを発生(スタート直後のテキスト)
            if (Clear == false)
            {
                if (Story_Page_01 == 4)
                {
                    Choice_01_Story_Next = 5;
                    Choice_02_Story_Next = 8;
                    Choice_03_Story_Next = 11;
                    Choice_01_T.Text = "中学1年生以上";
                    Choice_02_T.Text = "中学2年生以上";
                    Choice_03_T.Text = "中学3年生以上";
                    Choice_Show_Story_Not_Next = true;
                    Choice_Show();
                }
                if (Story_Page_01 == 7 || Story_Page_01 == 10 || Story_Page_01 == 13)
                {
                    Story_Page_01 = 14;
                    Story_Next_Clicked = false;
                    Story_Next_Clicked_Click = false;
                    Text_Next();
                }
                if (Story_Page_01 == 20)
                {
                    Feed_In_Out_Circle();
                }
            }
            //クリア後のテキスト
            else if (Story_File_Number != 0)
            {
                if (Story_Page_01 == 5)
                {
                    //二択の選択肢を出す(見る = ストーリー開始,見ない = メインメニューに移行)
                    Choice_Show_Story_Not_Next = true;
                    Button_Select_Double();
                }
            }
        }
        void Clear_Event()
        {
            //イラストはフリー素材を使用(ニコニ・コモンズのインターネット全体の使用を認めているもの、または製作者様が使用を許可しているもの(改変も共に許可されているもの))
            //2学年クリア時のストーリー
            if (Story_File_Number == 1)
            {
                if (Story_Page_02 == 4)
                {
                    Clear_Story_Image_Change_Text_Next(Path + "/Resources/BG/Story/自分の部屋1.png");
                }
                else if (Story_Page_02 == 9)
                {
                    Clear_Story_Image_Change(Path + "/Resources/BG/Story/部屋1.png");
                }
                else if (Story_Page_02 == 19)
                {
                    Feed_In_Out_Circle_In_Story(Path + "/Resources/BG/Story/部屋1.png", null);
                }
                else if (Story_Page_02 == 23)
                {
                    Clear_Story_Feed_In_Out_Image_Change(Path + "/Resources/BG/Story/通学路.png", null);
                    SE_02_Play(Path + "/Resources/SE/SE_07.mp3");
                }
                else if (Story_Page_02 == 35)
                {
                    Feed_In_Out_Circle_In_Story(Path + "/Resources/BG/Story/学校2.png", Path + "/Resources/SE/SE_08.mp3");
                }
                else if (Story_Page_02 == 46)
                {
                    Clear_Story_Feed_In_Out_Image_Change(Path + "/Resources/BG/Story/部屋2.png", Path + "/Resources/SE/SE_07.mp3");
                }
                else if (Story_Page_02 == 52)
                {
                    Clear_Story_Image_Change(Path + "/Resources/BG/Story/自分の部屋2.png");
                }
                else if (Story_Page_02 == 56)
                {
                    Clear_Screen_Close();
                }
            }
            else if (Story_File_Number == 2)
            {
                if (Story_Page_02 == 3)
                {
                    Clear_Story_Image_Change(Path + "/Resources/BG/Story/自分の部屋1.png");
                }
                else if (Story_Page_02 == 9)
                {
                    Clear_Story_Image_Change(Path + "/Resources/BG/Story/部屋1.png");
                }
                else if (Story_Page_02 == 11)
                {
                    Feed_In_Out_Black_In_Story(null);
                }
                else if (Story_Page_02 == 13)
                {
                    SE_02_Play(Path + "/Resources/SE/SE_06.mp3");
                }
                else if (Story_Page_02 == 19)
                {
                    Clear_Story_Image_Change(Path + "/Resources/BG/Story/通学路.png");
                }
                else if (Story_Page_02 == 35)
                {
                    Feed_In_Out_Circle_In_Story(Path + "/Resources/BG/Story/学校1.png", Path + "/Resources/SE/SE_10.mp3");
                }
                else if (Story_Page_02 == 39)
                {
                    Feed_In_Out_Circle_In_Story(Path + "/Resources/BG/Story/学校入り口.png", null);
                }
                else if (Story_Page_02 == 47)
                {
                    Clear_Story_Feed_Double_Image(Path + "/Resources/BG/Story/通学路.png", Path + "/Resources/BG/Story/部屋2.png");
                }
                else if (Story_Page_02 == 52)
                {
                    Clear_Story_Image_Change(Path + "/Resources/BG/Story/自分の部屋2.png");
                }
                else if (Story_Page_02 == 55)
                {
                    Clear_Screen_Close();
                }
            }
            else if (Story_File_Number == 3)
            {
                if (Story_Page_02 == 3)
                {
                    Clear_Story_Image_Change_Text_Next(Path + "/Resources/BG/Story/自分の部屋1.png");
                }
                else if (Story_Page_02 == 7)
                {
                    Feed_In_Out_Circle_In_Story(Path + "/Resources/BG/Story/自分の部屋1.png", null);
                }
                else if (Story_Page_02 == 10)
                {
                    Clear_Story_Image_Change(Path + "/Resources/BG/Story/部屋1.png");
                }
                else if (Story_Page_02 == 15)
                {
                    Clear_Story_Feed_In_Out_Image_Change(Path + "/Resources/BG/Story/学校1.png", Path + "/Resources/SE/SE_08.mp3");
                }
                else if (Story_Page_02 == 21)
                {
                    Clear_Story_Image_Change_Text_Next(Path + "/Resources/BG/Story/通学路.png");
                }
                else if (Story_Page_02 == 37)
                {
                    Feed_In_Out_Circle_In_Story(Path + "/Resources/BG/Story/自分の部屋1.png", null);
                }
                else if (Story_Page_02 == 46)
                {
                    Feed_In_Out_Circle_In_Story(Path + "/Resources/BG/Story/自分の部屋2.png", null);
                }
                else if (Story_Page_02 == 54)
                {
                    Clear_Story_Feed_In_Out_Image_Change(Path + "/Resources/BG/Story/自分の部屋1.png", null);
                }
                else if (Story_Page_02 == 62)
                {
                    Clear_Screen_Close();
                }
            }
            //全学年クリアしたときのストーリー
            else if (Story_File_Number == 4)
            {
                if (Story_Page_02 == 29 || Story_Page_02 == 35)
                {
                    Feed_In_Out_Black_In_Story(Path + "/Resources/SE/SE_08.mp3");
                }
                else if (Story_Page_02 == 68)
                {
                    Clear_Screen_Close();
                }
                else if (Story_Page_02 == 3)
                {
                    Clear_Story_Image_Change(Path + "/Resources/BG/Story/部屋1.png");
                }
                else if (Story_Page_02 == 13)
                {
                    Clear_Story_Image_Change(Path + "/Resources/BG/Story/通学路.png");
                    SE_02_Play(Path + "/Resources/SE/SE_06.mp3");
                }
                else if (Story_Page_02 == 21 || Story_Page_02 == 52)
                {
                    Feed_In_Out_Circle_In_Story(Path + "/Resources/BG/Story/学校1.png", null);
                }
            }
        }
        async void Choice_Show()
        {
            //選択肢を表示
            Choice_01_Image.Visibility = Visibility.Visible;
            Choice_02_Image.Visibility = Visibility.Visible;
            Choice_03_Image.Visibility = Visibility.Visible;
            Choice_01_T.Visibility = Visibility.Visible;
            Choice_02_T.Visibility = Visibility.Visible;
            Choice_03_T.Visibility = Visibility.Visible;
            Choice_01_Image.Opacity = 0;
            Choice_02_Image.Opacity = 0;
            Choice_03_Image.Opacity = 0;
            Choice_01_T.Opacity = 0;
            Choice_02_T.Opacity = 0;
            Choice_03_T.Opacity = 0;
            while (true)
            {
                if (Choice_01_Image.Opacity >= 1 || Choice_Click == true)
                {
                    break;
                }
                Choice_01_Image.Opacity += 0.05;
                Choice_02_Image.Opacity += 0.05;
                Choice_03_Image.Opacity += 0.05;
                Choice_01_T.Opacity += 0.05;
                Choice_02_T.Opacity += 0.05;
                Choice_03_T.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
        }
        async void Choice_Click_OK()
        {
            if (Choice_Click == false)
            {
                //選択肢がクリックされたら実行
                Choice_Show_Story_Not_Next = false;
                Story_Next_Clicked_Click = false;
                if (Clear == true)
                {
                    Choice_Click = true;
                    if (Result_Manager == true)
                    {
                        if (Choice_Number == 1)
                        {
                            Choice_Show_Story_Not_Next = true;
                            Result_Window.Visibility = Visibility.Visible;
                            Result_Window.Window_Show(Grade_Number);
                            Result_Manager = false;
                            while (Result_Window.Visibility == Visibility.Visible)
                            {
                                await Task.Delay(500);
                            }
                            Choice_Show_Story_Not_Next = false;
                            Text_Next();
                            Text_Next();
                        }
                    }
                    else if (Choice_Number == 1)
                    {
                        Clear_Story_Start();
                    }
                    else if (Choice_Number == 2)
                    {
                        IsExit_B_Click_True = true;
                        Close_Window();
                    }
                    while (true)
                    {
                        if (Choice_01_Image.Opacity <= 0)
                        {
                            Choice_01_Image.Visibility = Visibility.Hidden;
                            Choice_02_Image.Visibility = Visibility.Hidden;
                            Choice_01_T.Visibility = Visibility.Hidden;
                            Choice_02_T.Visibility = Visibility.Hidden;
                            Choice_Click = false;
                            Story_Next_Clicked_Click = false;
                            Choice_Show_Story_Not_Next = false;
                            break;
                        }
                        Choice_01_Image.Opacity -= 0.05;
                        Choice_02_Image.Opacity -= 0.05;
                        Choice_01_T.Opacity -= 0.05;
                        Choice_02_T.Opacity -= 0.05;
                        await Task.Delay(1000 / 30);
                    }
                    if (Result_Manager == true)
                    {
                        if (Choice_Number == 2)
                        {
                            Text_Next();
                            Text_Next();
                        }
                    }
                }
                else
                {
                    if (First_Story_End == false)
                    {
                        //学年を選ぶとき
                        Choice_Click = true;
                        int Number = 0;
                        if (Choice_Number == 1)
                        {
                            Number = Choice_01_Story_Next;
                            Grade_Number = 1;
                        }
                        else if (Choice_Number == 2)
                        {
                            Number = Choice_02_Story_Next;
                            Grade_Number = 2;
                        }
                        else if (Choice_Number == 3)
                        {
                            Number = Choice_03_Story_Next;
                            Grade_Number = 3;
                        }
                        while (true)
                        {
                            if (Choice_01_Image.Opacity <= 0)
                            {
                                Choice_01_Image.Visibility = Visibility.Hidden;
                                Choice_02_Image.Visibility = Visibility.Hidden;
                                Choice_03_Image.Visibility = Visibility.Hidden;
                                Choice_01_T.Visibility = Visibility.Hidden;
                                Choice_02_T.Visibility = Visibility.Hidden;
                                Choice_03_T.Visibility = Visibility.Hidden;
                                Choice_Click = false;
                                Story_Page_01 = Number;
                                Choice_Show_Story_Not_Next = false;
                                Text_Next();
                                break;
                            }
                            Choice_01_Image.Opacity -= 0.05;
                            Choice_02_Image.Opacity -= 0.05;
                            Choice_03_Image.Opacity -= 0.05;
                            Choice_01_T.Opacity -= 0.05;
                            Choice_02_T.Opacity -= 0.05;
                            Choice_03_T.Opacity -= 0.05;
                            await Task.Delay(1000 / 30);
                        }
                    }
                    else if (Story_Next_Clicked == false)
                    {
                        //問題の解答
                        Choice_Click = true;
                        if (Choice_Number == 1)
                        {
                            if (IsQuestion_Number_Only == true)
                            {
                                MessageBox.Show("正解");
                            }
                            //Math_IsCorrectクラスに定義されている
                            Choice_Math_Number_Correct(true);
                        }
                        else if (Choice_Number == 2 || Choice_Number == 3 || Choice_Number == 4)
                        {
                            if (IsQuestion_Number_Only == true)
                            {
                                MessageBox.Show("不正解");
                            }
                            Choice_Math_Number_Correct(false);
                        }
                        while (true)
                        {
                            if (Choice_01_Image.Opacity <= 0)
                            {
                                Next_Question();
                                break;
                            }
                            Choice_01_Image.Opacity -= 0.05;
                            Choice_02_Image.Opacity -= 0.05;
                            Choice_03_Image.Opacity -= 0.05;
                            Choice_04_Image.Opacity -= 0.05;
                            Choice_01_T.Opacity -= 0.05;
                            Choice_02_T.Opacity -= 0.05;
                            Choice_03_T.Opacity -= 0.05;
                            Choice_04_T.Opacity -= 0.05;
                            await Task.Delay(1000 / 30);
                        }
                        Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
                        Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
                        Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
                        Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
                    }
                }
            }
        }
        async void Next_Question()
        {
            //次に問題へ移行する(問題数が30問になったら別の処理を実行)
            Choice_01_Image.Visibility = Visibility.Hidden;
            Choice_02_Image.Visibility = Visibility.Hidden;
            Choice_03_Image.Visibility = Visibility.Hidden;
            Choice_04_Image.Visibility = Visibility.Hidden;
            Choice_01_T.Visibility = Visibility.Hidden;
            Choice_02_T.Visibility = Visibility.Hidden;
            Choice_03_T.Visibility = Visibility.Hidden;
            Choice_04_T.Visibility = Visibility.Hidden;
            Choice_01_T.FontSize = 36;
            Choice_02_T.FontSize = 36;
            Choice_03_T.FontSize = 36;
            Choice_04_T.FontSize = 36;
            if (Question_Number >= 30 && IsQuestion_Number_Only == false)
            {
                Clear = true;
                First_Story_End = false;
                IsCanNotSaveNow = true;
                Correct_Answer_Keisan();
                await Task.Delay(10);
                if (IsDebug == true)
                {
                    Correct_Answer_Number = 21;
                }
                //正解数が22問以上だった場合実行
                if (Correct_Answer_Number >= 22)
                {
                    if (!File.Exists(Path + "/Resources/Save/Grade_Clear.dat"))
                    {
                        StreamWriter stw = File.CreateText(Path + "/Resources/Save/Grade_Clear.dat");
                        stw.Close();
                    }
                    if (Grade_Number == 1)
                    {
                        StreamReader str = new StreamReader(Path + "/Resources/Save/Grade_Clear.dat");
                        string Moji = str.ReadToEnd();
                        str.Close();
                        if (!Moji.Contains("Created_By_SRTTbacon_And_Gumipoteti_Grade_Number_01_Clear_True"))
                        {
                            StreamWriter stw = new StreamWriter(Path + "/Resources/Save/Grade_Clear.dat", true);
                            stw.WriteLine("\nCreated_By_SRTTbacon_And_Gumipoteti_Grade_Number_01_Clear_True");
                            stw.Close();
                        }
                    }
                    else if (Grade_Number == 2)
                    {
                        StreamReader str = new StreamReader(Path + "/Resources/Save/Grade_Clear.dat");
                        string Moji = str.ReadToEnd();
                        str.Close();
                        if (!Moji.Contains("Programmed_By_SRTTbacon_Illustration_By_Gumipoteti_Grade_Number_02_Clear_True"))
                        {
                            StreamWriter stw = new StreamWriter(Path + "/Resources/Save/Grade_Clear.dat", true);
                            stw.WriteLine("\nProgrammed_By_SRTTbacon_Illustration_By_Gumipoteti_Grade_Number_02_Clear_True");
                            stw.Close();
                        }
                    }
                    else if (Grade_Number == 3)
                    {
                        StreamReader str = new StreamReader(Path + "/Resources/Save/Grade_Clear.dat");
                        string Moji = str.ReadToEnd();
                        str.Close();
                        if (!Moji.Contains("SRTTbacon_Like_Math_Gumipoteti_Love_Math_Grade_Number_03_Clear_True"))
                        {
                            StreamWriter stw = new StreamWriter(Path + "/Resources/Save/Grade_Clear.dat", true);
                            stw.WriteLine("\nSRTTbacon_Like_Math_Gumipoteti_Love_Math_Grade_Number_03_Clear_True");
                            stw.Close();
                        }
                    }
                    StreamReader str2 = new StreamReader(Path + "/Resources/Save/Grade_Clear.dat");
                    string Moji2 = str2.ReadToEnd();
                    str2.Close();
                    //もし1,2,3年すべてクリアした場合、特別なストーリーを見せる(選択あり)
                    //はたしてそんな人はいるのか...
                    Answer_Number_StreamWriter();
                    if (Moji2.Contains("Created_By_SRTTbacon_And_Gumipoteti_Grade_Number_01_Clear_True") && Moji2.Contains("Programmed_By_SRTTbacon_Illustration_By_Gumipoteti_Grade_Number_02_Clear_True") && Moji2.Contains("SRTTbacon_Like_Math_Gumipoteti_Love_Math_Grade_Number_03_Clear_True"))
                    {
                        Grade_1_2_3_Clear_After_Story = true;
                    }
                    Story_File_Number = Grade_Number;
                    Story_01 = Grade_Number + "年生の問題が終了したよ\n君が正解した問題数は" + Correct_Answer_Number + "だね\n合格ラインは22問だから合格だよ\nリザルトを見ますか？\n\n" + Grade_Number + "学年のストーリーが見れます\nストーリーを見ますか？\n\nメニュー画面に新モードを追加したから確認してね\n";
                    if (!File.Exists(Path + "/Resources/Save/Grade_Questions.dat"))
                    {
                        StreamWriter stw2 = File.CreateText(Path + "/Resources/Save/Grade_Questions.dat");
                        stw2.Close();
                    }
                    await Task.Delay(10);
                    StreamWriter stw3 = new StreamWriter(Path + "/Resources/Save/Grade_Questions.dat", true);
                    if (Grade_Number == 1)
                    {
                        stw3.WriteLine("IsGrade_01_Questions_Show_True\n");
                    }
                    else if (Grade_Number == 2)
                    {
                        stw3.WriteLine("IsGrade_02_Thirty_Questions_Show_You_Are_Answered_True\n");
                    }
                    else if (Grade_Number == 3)
                    {
                        stw3.WriteLine("IsGrade_03_Difficult_Questions_Created_By_Gumipoteti_True\n");
                    }
                    stw3.Close();
                }
                else
                {
                    Answer_Number_StreamWriter();
                    Story_01 = Grade_Number + "年生の問題が終了したよ\n君が正解した問題数は" + Correct_Answer_Number + "だね\n合格ラインは22問だから残念だけど不合格だよ\nリザルトを見ますか？\n\nこれからメニュー画面に移行するね\n";
                    if (!File.Exists(Path + "/Resources/Save/Grade_Questions.dat"))
                    {
                        StreamWriter stw2 = File.CreateText(Path + "/Resources/Save/Grade_Questions.dat");
                        stw2.Close();
                    }
                    await Task.Delay(10);
                    StreamWriter stw = new StreamWriter(Path + "/Resources/Save/Grade_Questions.dat", true);
                    if (Grade_Number == 1)
                    {
                        stw.WriteLine("IsGrade_01_Questions_Show_True\n");
                    }
                    else if (Grade_Number == 2)
                    {
                        stw.WriteLine("IsGrade_02_Thirty_Questions_Show_You_Are_Answered_True\n");
                    }
                    else if (Grade_Number == 3)
                    {
                        stw.WriteLine("IsGrade_03_Difficult_Questions_Created_By_Gumipoteti_True\n");
                    }
                    stw.Close();
                }
                Story_Page_01 = 0;
                Text_01_T.FontSize = 40;
                Text_02_T.FontSize = 40;
                Question_Number_T.Visibility = Visibility.Hidden;
                Help_T.Visibility = Visibility.Hidden;
                Text_Next();
            }
            else if (Difficult_Question_Number >= 4)
            {
                Correct_Answer_Keisan();
                Clear = true;
                First_Story_End = false;
                Text_01_T.FontSize = 40;
                Text_02_T.FontSize = 40;
                string Message_01 = "超難問の問題が終了しました\n";
                string Message_02 = "結果|1問目:" + Difficult_Question_Number_01_String + "|2問目:" + Difficult_Question_Number_02_String + "|3問目:" + Difficult_Question_Number_03_String + "|4問目:" + Difficult_Question_Number_04_String + "\n";
                string Message_03 = "かかった時間:" + Timer_Hour + "時間" + Timer_Minutes + "分" + Timer_Seconds + "秒(" + Timer_All + "秒)\nメイン画面へ移動します。";
                Story_01 = Message_01 + Message_02 + Message_03;
                Story_Page_01 = 0;
                Question_Number_T.Visibility = Visibility.Hidden;
                Help_T.Visibility = Visibility.Hidden;
                Text_Next();
            }
            else
            {
                Choice_Click = false;
                if (Difficult_Question_Mode == true)
                {
                    Difficult_Question_Number++;
                    Difficult_Question_Set();
                }
                else if (IsQuestion_Number_Only == false)
                {
                    Question_Number += 1;
                    Question_Number_T.Text = Question_Number + "/30";
                    Question_Number_Definition();
                }
                else
                {
                    Question_Number_T.Text = Question_Number + "/30";
                    Question_Number_Definition();
                }
                await Task.Delay(50);
                Text_Next();
            }
        }
        async void Feed_In_Out_Circle()
        {
            //渦巻のフェードアウト・インを行う。また、画面が見えなくなった時点でウィンドウを透明にする
            Feed_Image.Visibility = Visibility.Visible;
            Feed_Image.Opacity = 1;
            Choice_Show_Story_Not_Next = true;
            bool Window_Image_Hide = false;
            int Number = 1;
            Name_01_T.Visibility = Visibility.Hidden;
            Name_02_T.Visibility = Visibility.Hidden;
            while (true)
            {
                if (File.Exists(Path + "/Resources/Motion/Feed/Feed_In_Out_Circle/" + Number + ".png"))
                {
                    Feed_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Feed/Feed_In_Out_Circle/" + Number + ".png"));
                    Number += 1;
                }
                else
                {
                    Choice_Show_Story_Not_Next = false;
                    Feed_Image.Visibility = Visibility.Hidden;
                    Window_Show();
                    Question_Number_T.Visibility = Visibility.Visible;
                    Question_Number_T.Text = "1/30";
                    Text_01_T.FontSize = 40;
                    Text_02_T.FontSize = 40;
                    First_Story_End = true;
                    //選択肢の位置を指定
                    Choice_01_Image.Margin = new Thickness(-1900, 75, 0, 0);
                    Choice_01_T.Margin = new Thickness(-1900, 110, 0, 0);
                    Choice_02_Image.Margin = new Thickness(-680, 75, 0, 0);
                    Choice_02_T.Margin = new Thickness(-680, 110, 0, 0);
                    Choice_03_Image.Margin = new Thickness(-1900, 250, 0, 0);
                    Choice_03_T.Margin = new Thickness(-1900, 285, 0, 0);
                    Choice_04_Image.Margin = new Thickness(-680, 250, 0, 0);
                    Choice_04_T.Margin = new Thickness(-680, 285, 0, 0);
                    Help_T.Visibility = Visibility.Visible;
                    Help_T.Text = "'^'は累乗を表す。\n'/'は分数を表す。注意:'/'の右側が分母とする";
                    BGM_Start();
                    //それぞれの問題をセット
                    if (Grade_Number == 1)
                    {
                        Question_Grade_01_Number_01();
                    }
                    else if (Grade_Number == 2)
                    {
                        Question_Grade_02_Number_01();
                    }
                    else if (Grade_Number == 3)
                    {
                        Question_Grade_03_Number_01();
                    }
                    break;
                }
                if (Number >= 60)
                {
                    //フェードアウトが終わったら実行
                    Text_01_T.Text = "";
                    Text_02_T.Text = "";
                    if (Window_Image_Hide == false)
                    {
                        Window_Image_Hide = true;
                        Window_Image.Opacity = 0;
                        Title_Image.Opacity = 0;
                        Text_01_T.Opacity = 0;
                        Text_02_T.Opacity = 0;
                        Main_Image_01.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Math_Main_01.png"));
                        Main_Image_02.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Math_Main_01.png"));
                        Math_Image_Play = true;
                        Main_Image_02.Opacity = 1;
                        Animation_Image = 2;
                        Math_Back_Animation();
                    }
                }
                await Task.Delay(1000 / 30);
            }
        }
        async void Math_Back_Animation()
        {
            while (Math_Image_Play == true)
            {
                //30秒ごとに背景画像を変更
                if (Animation_Image == 1)
                {
                    Animation_Image = 2;
                }
                else if (Animation_Image == 2)
                {
                    Animation_Image = 1;
                }
                Image_Feed();
                await Task.Delay(30000);
            }
        }
        async void Fire_Animation()
        {
            Main_Image_01.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Fire_Back_01.png"));
            Main_Image_02.Visibility = Visibility.Visible;
            Main_Image_02.Opacity = 1;
            int Number = 1;
            while (true)
            {
                Main_Image_02.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Fire/" + Number + ".png"));
                Number++;
                if (Number >= 91)
                {
                    Number = 1;
                }
                await Task.Delay(1000 / 30);
            }
        }
        async void Image_Feed()
        {
            //背景の画像をランダムで表示(フェードイン・アウトするためImageを2つ用意している)
            Random r = new Random();
            Image_Random = Path + "/Resources/BG/Math/" + r.Next(1, 11) + ".jpg";
            if (Animation_Image == 1)
            {
                Main_Image_02.Source = new BitmapImage(new Uri(Image_Random));
                while (true)
                {
                    if (Main_Image_02.Opacity >= 1)
                    {
                        break;
                    }
                    Main_Image_02.Opacity += 0.01;
                    await Task.Delay(1000 / 30);
                }
            }
            else if (Animation_Image == 2)
            {
                Main_Image_01.Source = new BitmapImage(new Uri(Image_Random));
                while (true)
                {
                    if (Main_Image_02.Opacity <= 0)
                    {
                        break;
                    }
                    Main_Image_02.Opacity -= 0.01;
                    await Task.Delay(1000 / 30);
                }
            }
        }
        async void Feed_In_Out_Circle_In_Story(string Image_Source, string SE_File_Source)
        {
            //円状にフェードイン・アウトさせる(画像で処理しているため多少動作が重くなる可能性大)
            Story_Not_Proceed = true;
            Feed_Image.Visibility = Visibility.Visible;
            Feed_Image.Opacity = 1;
            int Image_Number = 1;
            while (true)
            {
                if (File.Exists(Path + "/Resources/Motion/Feed/Feed_Out_01/" + Image_Number + ".png"))
                {
                    Feed_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Feed/Feed_Out_01/" + Image_Number + ".png"));
                    Image_Number += 1;
                }
                else
                {
                    Image_Number = 1;
                    break;
                }
                await Task.Delay(1000 / 30);
            }
            await Task.Delay(1000);
            Main_Image_01.Source = new BitmapImage(new Uri(Image_Source));
            Main_Image_02.Source = new BitmapImage(new Uri(Image_Source));
            while (true)
            {
                if (File.Exists(Path + "/Resources/Motion/Feed/Feed_In_01/" + Image_Number + ".png"))
                {
                    Feed_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Feed/Feed_In_01/" + Image_Number + ".png"));
                    Image_Number += 1;
                }
                else
                {
                    Feed_Image.Visibility = Visibility.Hidden;
                    Story_Not_Proceed = false;
                    Text_Next();
                    if (SE_File_Source != "" && SE_File_Source != null)
                    {
                        SE_02_Play(SE_File_Source);
                    }
                    break;
                }
                await Task.Delay(1000 / 30);
            }
        }
        async void Feed_In_Out_Black_In_Story(string SE_File_Source)
        {
            //画面を暗くして復帰させる
            Story_Not_Proceed = true;
            Feed_Image.Visibility = Visibility.Visible;
            Feed_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Black.png"));
            Feed_Image.Opacity = 0;
            while (true)
            {
                if (Feed_Image.Opacity >= 1)
                {
                    break;
                }
                Feed_Image.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
            await Task.Delay(1000);
            while (true)
            {
                if (Feed_Image.Opacity <= 0)
                {
                    Feed_Image.Visibility = Visibility.Hidden;
                    Story_Not_Proceed = false;
                    Text_Next();
                    if (SE_File_Source != "" && SE_File_Source == null)
                    {
                        SE_02_Play(SE_File_Source);
                    }
                    break;
                }
                Feed_Image.Opacity -= 0.05;
                await Task.Delay(1000 / 30);
            }
        }
        async void Clear_Screen_Close()
        {
            //1,2,3学年クリア後のストーリーが終わったら実行される
            //画面をだんだん白くしてホーム画面が作成されたらフェードアウトさせる
            Story_Not_Proceed = true;
            Feed_Image.Visibility = Visibility.Visible;
            Feed_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/White.png"));
            Feed_Image.Opacity = 0;
            while (Feed_Image.Opacity < 1)
            {
                Feed_Image.Opacity += 0.02;
                await Task.Delay(1000 / 30);
            }
            await Task.Delay(1500);
            if (Grade_1_2_3_Clear_After_Story == true)
            {
                Button_Answer_Word_01 = "見る";
                Button_Answer_Word_02 = "見ない";
                Button_Select_Double();
                Story_File_Number = 4;
                Text_01_T.Text = "";
                Text_02_T.Text = "";
                foreach (char c in "全学年の問題がクリアされています。最後のストーリーを見ますか？")
                {
                    Text_01_T.Text += c;
                    Text_02_T.Text += c;
                    await Task.Delay(60 - Story_Speed);
                }
            }
            else
            {
                Home_Window f = new Home_Window();
                f.Show();
                while (true)
                {
                    if (Opacity <= 0)
                    {
                        BGM_Close = true;
                        BGM.controls.stop();
                        BGM.close();
                        SE.close();
                        Close();
                        break;
                    }
                    Opacity -= 0.05;
                    BGM.settings.volume--;
                    await Task.Delay(1000 / 30);
                }
            }
        }
        async void Clear_Story_Start()
        {
            //クリア後のストーリーを表示
            Story_Not_Proceed = true;
            Feed_Image.Visibility = Visibility.Visible;
            Feed_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/White.png"));
            if (Story_Mode_Only == true)
            {
                Feed_Image.Opacity = 1;
            }
            else
            {
                Feed_Image.Opacity = 0;
            }
            First_Story_End = true;
            Story_Next_Clicked = true;
            while (true)
            {
                if (Feed_Image.Opacity >= 1)
                {
                    BGM.controls.stop();
                    break;
                }
                Feed_Image.Opacity += 0.01;
                BGM.settings.volume -= 1;
                await Task.Delay(1000 / 30);
            }
            Text_01_T.Text = "";
            Text_02_T.Text = "";
            Name_01_T.Visibility = Visibility.Visible;
            Name_02_T.Visibility = Visibility.Visible;
            Log_Image.Visibility = Visibility.Visible;
            BackLog_L.Items.Clear();
            Name_01_T.Text = "";
            Name_02_T.Text = "";
            Text_01_T.FontSize = 40;
            Text_02_T.FontSize = 40;
            Text_01_T.Margin = new Thickness(Text_01_T.Margin.Left + 50, Text_01_T.Margin.Top, 0, 0);
            Text_02_T.Margin = new Thickness(Text_02_T.Margin.Left + 50, Text_02_T.Margin.Top, 0, 0);
            Name_01_T.Margin = new Thickness(-2210, 545, 0, 0);
            Name_02_T.Margin = new Thickness(-2212, 543, 0, 0);
            IsGrade_1_2_3_Clear = true;
            Math_Image_Play = false;
            try
            {
                //ストーリーの暗号化を解除
                if (Story_File_Number == 1)
                {
                    using (var eifs = new FileStream(Path + "/Resources/Story/Story_01.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Story/Story_TEMP.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                            StreamReader str4 = new StreamReader(Path + "/Resources/Story/Story_TEMP.dat");
                            Story_02 = str4.ReadToEnd();
                            str4.Close();
                            File.Delete(Path + "/Resources/Story/Story_TEMP.dat");
                        }
                    }
                    using (var eifs = new FileStream(Path + "/Resources/Story/Story_Name_01.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Story/Story_TEMP.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                            StreamReader str4 = new StreamReader(Path + "/Resources/Story/Story_TEMP.dat");
                            Name_01 = str4.ReadToEnd();
                            str4.Close();
                            File.Delete(Path + "/Resources/Story/Story_TEMP.dat");
                        }
                    }
                }
                else if (Story_File_Number == 2)
                {
                    using (var eifs = new FileStream(Path + "/Resources/Story/Story_02.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Story/Story_TEMP.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                            StreamReader str4 = new StreamReader(Path + "/Resources/Story/Story_TEMP.dat");
                            Story_02 = str4.ReadToEnd();
                            str4.Close();
                            File.Delete(Path + "/Resources/Story/Story_TEMP.dat");
                        }
                    }
                    using (var eifs = new FileStream(Path + "/Resources/Story/Story_Name_02.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Story/Story_TEMP.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                            StreamReader str4 = new StreamReader(Path + "/Resources/Story/Story_TEMP.dat");
                            Name_01 = str4.ReadToEnd();
                            str4.Close();
                            File.Delete(Path + "/Resources/Story/Story_TEMP.dat");
                        }
                    }
                    using (var eifs = new FileStream(Path + "/Resources/Story/Story_02_Chara.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Story/Story_TEMP.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                            StreamReader str4 = new StreamReader(Path + "/Resources/Story/Story_TEMP.dat");
                            Chara_01 = str4.ReadToEnd();
                            str4.Close();
                            File.Delete(Path + "/Resources/Story/Story_TEMP.dat");
                        }
                    }
                }
                else if (Story_File_Number == 3)
                {
                    using (var eifs = new FileStream(Path + "/Resources/Story/Story_03.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Story/Story_TEMP.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                            StreamReader str4 = new StreamReader(Path + "/Resources/Story/Story_TEMP.dat");
                            Story_02 = str4.ReadToEnd();
                            str4.Close();
                            File.Delete(Path + "/Resources/Story/Story_TEMP.dat");
                        }
                    }
                    using (var eifs = new FileStream(Path + "/Resources/Story/Story_Name_03.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Story/Story_TEMP.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                            StreamReader str4 = new StreamReader(Path + "/Resources/Story/Story_TEMP.dat");
                            Name_01 = str4.ReadToEnd();
                            str4.Close();
                            File.Delete(Path + "/Resources/Story/Story_TEMP.dat");
                        }
                    }
                }
                else if (Story_File_Number == 4)
                {
                    using (var eifs = new FileStream(Path + "/Resources/Story/Story_04.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Story/Story_TEMP.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                            StreamReader str4 = new StreamReader(Path + "/Resources/Story/Story_TEMP.dat");
                            Story_02 = str4.ReadToEnd();
                            str4.Close();
                            File.Delete(Path + "/Resources/Story/Story_TEMP.dat");
                        }
                    }
                    using (var eifs = new FileStream(Path + "/Resources/Story/Story_Name_04.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Story/Story_TEMP.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                            StreamReader str4 = new StreamReader(Path + "/Resources/Story/Story_TEMP.dat");
                            Name_01 = str4.ReadToEnd();
                            str4.Close();
                            File.Delete(Path + "/Resources/Story/Story_TEMP.dat");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //基本、ファイルの暗号化が不完全な場合に実行
                MessageBox.Show("エラー:ファイルが破損しています。もう一度ダウンロードするか、開発者へ連絡してください。\nソフトは強制終了されます。");
                StreamWriter stw = File.CreateText(Path + "/Log.txt");
                stw.Write(e.Message + "\n発生時刻 = " + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                stw.Close();
                Close();
            }
            Main_Image_01.Source = new BitmapImage(new Uri(Path + "/Resources/BG/White.png"));
            Main_Image_02.Source = new BitmapImage(new Uri(Path + "/Resources/BG/White.png"));
            await Task.Delay(1000);
            BGM_Start();
            BGM.settings.volume = 0;
            while (true)
            {
                if (Feed_Image.Opacity <= 0)
                {
                    BGM.settings.volume = (int)Configs_Window.BGM_Volume_S.Value;
                    Feed_Image.Visibility = Visibility.Hidden;
                    Story_Next_Clicked = false;
                    Story_Not_Proceed = false;
                    Text_Next();
                    if (Story_File_Number == 2 || Story_File_Number == 4)
                    {
                        SE_02_Play(Path + "/Resources/SE/SE_10.mp3");
                    }
                    break;
                }
                if (BGM.settings.volume <= Configs_Window.BGM_Volume_S.Value)
                {
                    BGM.settings.volume += 1;
                }
                Feed_Image.Opacity -= 0.01;
                await Task.Delay(1000 / 30);
            }
            BGM_Close = true;
            await Task.Delay(1000);
            BGM_Start();
        }
        async void Button_Select_Double()
        {
            //2択の選択を表示させる
            Choice_Click = false;
            Choice_01_T.Text = Button_Answer_Word_01;
            Choice_02_T.Text = Button_Answer_Word_02;
            Choice_01_Image.Visibility = Visibility.Visible;
            Choice_02_Image.Visibility = Visibility.Visible;
            Choice_01_T.Visibility = Visibility.Visible;
            Choice_02_T.Visibility = Visibility.Visible;
            Choice_01_Image.Opacity = 0;
            Choice_02_Image.Opacity = 0;
            Choice_01_T.Opacity = 0;
            Choice_02_T.Opacity = 0;
            Choice_01_Image.Margin = new Thickness(-1900, 175, 0, 0);
            Choice_01_T.Margin = new Thickness(-1900, 210, 0, 0);
            Choice_02_Image.Margin = new Thickness(-680, 175, 0, 0);
            Choice_02_T.Margin = new Thickness(-680, 210, 0, 0);
            while (true)
            {
                if (Choice_01_Image.Opacity >= 1 || Choice_Click == true)
                {
                    break;
                }
                Choice_01_Image.Opacity += 0.05;
                Choice_02_Image.Opacity += 0.05;
                Choice_01_T.Opacity += 0.05;
                Choice_02_T.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
        }
        async void Clear_Story_Image_Change(string Image_Source)
        {
            //画像をフェードインしながら表示
            if (Main_Image_02.Opacity >= 1)
            {
                Main_Image_01.Source = new BitmapImage(new Uri(Image_Source));
                while (true)
                {
                    if (Main_Image_02.Opacity <= 0)
                    {
                        break;
                    }
                    Main_Image_02.Opacity -= 0.02;
                    await Task.Delay(1000 / 30);
                }
            }
            else
            {
                Main_Image_02.Source = new BitmapImage(new Uri(Image_Source));
                while (true)
                {
                    if (Main_Image_02.Opacity >= 1)
                    {
                        break;
                    }
                    Main_Image_02.Opacity += 0.02;
                    await Task.Delay(1000 / 30);
                }
            }
        }
        async void Clear_Story_Image_Change_Text_Next(string Image_Source)
        {
            Story_Not_Proceed = true;
            //画像をフェードインしながら表示
            if (Main_Image_02.Opacity >= 1)
            {
                Main_Image_01.Source = new BitmapImage(new Uri(Image_Source));
                while (true)
                {
                    if (Main_Image_02.Opacity <= 0)
                    {
                        Story_Not_Proceed = false;
                        Text_Next();
                        break;
                    }
                    Main_Image_02.Opacity -= 0.02;
                    await Task.Delay(1000 / 30);
                }
            }
            else
            {
                Main_Image_02.Source = new BitmapImage(new Uri(Image_Source));
                while (true)
                {
                    if (Main_Image_02.Opacity >= 1)
                    {
                        Story_Not_Proceed = false;
                        Text_Next();
                        break;
                    }
                    Main_Image_02.Opacity += 0.02;
                    await Task.Delay(1000 / 30);
                }
            }
        }
        async void Clear_Story_Feed_In_Out_Image_Change(string Image_Source, string SE_File_Source)
        {
            Story_Not_Proceed = true;
            if (Main_Image_02.Opacity >= 1)
            {
                Main_Image_01.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Black.png"));
                while (Main_Image_02.Opacity > 0)
                {
                    Main_Image_02.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
                Main_Image_02.Source = new BitmapImage(new Uri(Image_Source));
                await Task.Delay(1000);
                while (Main_Image_02.Opacity < 1)
                {
                    Main_Image_02.Opacity += 0.05;
                    await Task.Delay(1000 / 30);
                }
                Story_Not_Proceed = false;
                Text_Next();
                if (SE_File_Source != "" && SE_File_Source != null)
                {
                    SE_02_Play(SE_File_Source);
                }

            }
            else
            {
                Main_Image_02.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Black.png"));
                while (Main_Image_02.Opacity < 1)
                {
                    Main_Image_02.Opacity += 0.05;
                    await Task.Delay(1000 / 30);
                }
                Main_Image_01.Source = new BitmapImage(new Uri(Image_Source));
                await Task.Delay(1000);
                while (Main_Image_02.Opacity > 0)
                {
                    Main_Image_02.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
                Story_Not_Proceed = false;
                Text_Next();
                if (SE_File_Source != "" && SE_File_Source != null)
                {
                    SE_02_Play(SE_File_Source);
                }
            }
        }
        async void Clear_Story_Feed_Double_Image(string First_Image, string Second_Image)
        {
            //二回連続で画像が入れ替わる
            Story_Not_Proceed = true;
            if (Main_Image_02.Opacity >= 1)
            {
                Main_Image_01.Source = new BitmapImage(new Uri(First_Image));
                while (true)
                {
                    if (Main_Image_02.Opacity <= 0)
                    {
                        break;
                    }
                    Main_Image_02.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
                Main_Image_02.Source = new BitmapImage(new Uri(Second_Image));
                await Task.Delay(500);
                while (true)
                {
                    if (Main_Image_02.Opacity >= 1)
                    {
                        Story_Not_Proceed = false;
                        Text_Next();
                        break;
                    }
                    Main_Image_02.Opacity += 0.05;
                    await Task.Delay(1000 / 30);
                }
            }
            if (Main_Image_02.Opacity <= 0)
            {
                Main_Image_02.Source = new BitmapImage(new Uri(First_Image));
                while (true)
                {
                    if (Main_Image_02.Opacity >= 1)
                    {
                        break;
                    }
                    Main_Image_02.Opacity += 0.05;
                    await Task.Delay(1000 / 30);
                }
                Main_Image_01.Source = new BitmapImage(new Uri(Second_Image));
                await Task.Delay(500);
                while (true)
                {
                    if (Main_Image_02.Opacity <= 0)
                    {
                        Story_Not_Proceed = false;
                        Text_Next();
                        break;
                    }
                    Main_Image_02.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
            }
        }
        async void Story_04_Chara_Image_Select(int Number)
        {
            //キャラクターを表示(0は非表示、それ以外は該当の画像ファイルを表示)
            if (Number == 0 && Chara_Image.Visibility == Visibility.Visible)
            {
                Is_Chara_04_Feed_Out = true;
                while (true)
                {
                    if (Is_Chara_04_Feed_In == true)
                    {
                        break;
                    }
                    if (Chara_Image.Opacity <= 0)
                    {
                        Chara_Image.Visibility = Visibility.Hidden;
                        Chara_Mini_Image.Visibility = Visibility.Hidden;
                        Chara_Image.Source = null;
                        break;
                    }
                    Chara_Mini_Image.Opacity -= 0.05;
                    Chara_Image.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
                Is_Chara_04_Feed_Out = false;
            }
            else if (Number != 0 && Chara_Image.Visibility == Visibility.Hidden)
            {
                Chara_Image.Visibility = Visibility.Visible;
                Chara_Mini_Image.Visibility = Visibility.Visible;
                Chara_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Story/Chara/" + Chara_Image_Number + "/" + Number + ".png"));
                Chara_Mini_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Story/Chara/" + Chara_Image_Number + "/" + Number + ".png"));
                Is_Chara_04_Feed_In = true;
                while (true)
                {
                    if (Chara_Image.Opacity >= 1 || Is_Chara_04_Feed_Out == true)
                    {
                        break;
                    }
                    Chara_Mini_Image.Opacity += 0.05;
                    Chara_Image.Opacity += 0.05;
                    await Task.Delay(1000 / 30);
                }
                Is_Chara_04_Feed_In = false;
            }
            else if (Number != 0 && Chara_Image.Visibility == Visibility.Visible)
            {
                Chara_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Story/Chara/" + Chara_Image_Number + "/" + Number + ".png"));
                Chara_Mini_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Story/Chara/" + Chara_Image_Number + "/" + Number + ".png"));
            }
        }
        async void Button_Text_Change()
        {
            //回答ボタンを表示
            Choice_01_T.Text = Button_Answer_Word_01;
            Choice_02_T.Text = Button_Answer_Word_02;
            Choice_03_T.Text = Button_Answer_Word_03;
            Choice_04_T.Text = Button_Answer_Word_04;
            Choice_01_Image.Visibility = Visibility.Visible;
            Choice_02_Image.Visibility = Visibility.Visible;
            Choice_03_Image.Visibility = Visibility.Visible;
            Choice_04_Image.Visibility = Visibility.Visible;
            Choice_01_T.Visibility = Visibility.Visible;
            Choice_02_T.Visibility = Visibility.Visible;
            Choice_03_T.Visibility = Visibility.Visible;
            Choice_04_T.Visibility = Visibility.Visible;
            Choice_01_Image.Opacity = 1;
            Choice_02_Image.Opacity = 1;
            Choice_03_Image.Opacity = 1;
            Choice_04_Image.Opacity = 1;
            Choice_01_T.Opacity = 1;
            Choice_02_T.Opacity = 1;
            Choice_03_T.Opacity = 1;
            Choice_04_T.Opacity = 1;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            //ボタンの配置をランダムに
            Random Position = new Random();
            bool Position_Number_01 = false;
            bool Position_Number_02 = false;
            bool Position_Number_03 = false;
            bool Position_Number_04 = false;
            bool Position_01_Free = true;
            bool Position_02_Free = true;
            bool Position_03_Free = true;
            bool Position_04_Free = true;
            while (true)
            {
                if (Position_Number_01 == true && Position_Number_02 == true && Position_Number_03 == true && Position_Number_04 == true)
                {
                    break;
                }
                int Position_01 = Position.Next(1, 5);
                if (Position_Number_01 == false && Position_01 == 1 && Position_01_Free == true)
                {
                    Choice_01_Image.Margin = new Thickness(-1900, 75, 0, 0);
                    Choice_01_T.Margin = new Thickness(-1900, 110, 0, 0);
                    Position_Number_01 = true;
                    Position_01_Free = false;
                }
                else if (Position_Number_01 == false && Position_01 == 2 && Position_02_Free == true)
                {
                    Choice_01_Image.Margin = new Thickness(-680, 75, 0, 0);
                    Choice_01_T.Margin = new Thickness(-680, 110, 0, 0);
                    Position_Number_01 = true;
                    Position_02_Free = false;
                }
                else if (Position_Number_01 == false && Position_01 == 3 && Position_03_Free == true)
                {
                    Choice_01_Image.Margin = new Thickness(-1900, 250, 0, 0);
                    Choice_01_T.Margin = new Thickness(-1900, 285, 0, 0);
                    Position_Number_01 = true;
                    Position_03_Free = false;
                }
                else if (Position_Number_01 == false && Position_01 == 4 && Position_04_Free == true)
                {
                    Choice_01_Image.Margin = new Thickness(-680, 250, 0, 0);
                    Choice_01_T.Margin = new Thickness(-680, 285, 0, 0);
                    Position_Number_01 = true;
                    Position_04_Free = false;
                }
                else if (Position_Number_02 == false && Position_01 == 1 && Position_01_Free == true)
                {
                    Choice_02_Image.Margin = new Thickness(-1900, 75, 0, 0);
                    Choice_02_T.Margin = new Thickness(-1900, 110, 0, 0);
                    Position_Number_02 = true;
                    Position_01_Free = false;
                }
                else if (Position_Number_02 == false && Position_01 == 2 && Position_02_Free == true)
                {
                    Choice_02_Image.Margin = new Thickness(-680, 75, 0, 0);
                    Choice_02_T.Margin = new Thickness(-680, 110, 0, 0);
                    Position_Number_02 = true;
                    Position_02_Free = false;
                }
                else if (Position_Number_02 == false && Position_01 == 3 && Position_03_Free == true)
                {
                    Choice_02_Image.Margin = new Thickness(-1900, 250, 0, 0);
                    Choice_02_T.Margin = new Thickness(-1900, 285, 0, 0);
                    Position_Number_02 = true;
                    Position_03_Free = false;
                }
                else if (Position_Number_02 == false && Position_01 == 4 && Position_04_Free == true)
                {
                    Choice_02_Image.Margin = new Thickness(-680, 250, 0, 0);
                    Choice_02_T.Margin = new Thickness(-680, 285, 0, 0);
                    Position_Number_02 = true;
                    Position_04_Free = false;
                }
                else if (Position_Number_03 == false && Position_01 == 1 && Position_01_Free == true)
                {
                    Choice_03_Image.Margin = new Thickness(-1900, 75, 0, 0);
                    Choice_03_T.Margin = new Thickness(-1900, 110, 0, 0);
                    Position_Number_03 = true;
                    Position_01_Free = false;
                }
                else if (Position_Number_03 == false && Position_01 == 2 && Position_02_Free == true)
                {
                    Choice_03_Image.Margin = new Thickness(-680, 75, 0, 0);
                    Choice_03_T.Margin = new Thickness(-680, 110, 0, 0);
                    Position_Number_03 = true;
                    Position_02_Free = false;
                }
                else if (Position_Number_03 == false && Position_01 == 3 && Position_03_Free == true)
                {
                    Choice_03_Image.Margin = new Thickness(-1900, 250, 0, 0);
                    Choice_03_T.Margin = new Thickness(-1900, 285, 0, 0);
                    Position_Number_03 = true;
                    Position_03_Free = false;
                }
                else if (Position_Number_03 == false && Position_01 == 4 && Position_04_Free == true)
                {
                    Choice_03_Image.Margin = new Thickness(-680, 250, 0, 0);
                    Choice_03_T.Margin = new Thickness(-680, 285, 0, 0);
                    Position_Number_03 = true;
                    Position_04_Free = false;
                }
                else if (Position_Number_04 == false && Position_01 == 1 && Position_01_Free == true)
                {
                    Choice_04_Image.Margin = new Thickness(-1900, 75, 0, 0);
                    Choice_04_T.Margin = new Thickness(-1900, 110, 0, 0);
                    Position_Number_04 = true;
                    Position_01_Free = false;
                }
                else if (Position_Number_04 == false && Position_01 == 2 && Position_02_Free == true)
                {
                    Choice_04_Image.Margin = new Thickness(-680, 75, 0, 0);
                    Choice_04_T.Margin = new Thickness(-680, 110, 0, 0);
                    Position_Number_04 = true;
                    Position_02_Free = false;
                }
                else if (Position_Number_04 == false && Position_01 == 3 && Position_03_Free == true)
                {
                    Choice_04_Image.Margin = new Thickness(-1900, 250, 0, 0);
                    Choice_04_T.Margin = new Thickness(-1900, 285, 0, 0);
                    Position_Number_04 = true;
                    Position_03_Free = false;
                }
                else if (Position_Number_04 == false && Position_01 == 4 && Position_04_Free == true)
                {
                    Choice_04_Image.Margin = new Thickness(-680, 250, 0, 0);
                    Choice_04_T.Margin = new Thickness(-680, 285, 0, 0);
                    Position_Number_04 = true;
                    Position_04_Free = false;
                }
                await Task.Delay(5);
            }
            if (IsImageUse == true)
            {
                //問題で画像を使う場合に実行
                Math_Image.Source = new BitmapImage(new Uri(Math_Image_Source));
                if (Math_Image.Visibility == Visibility.Hidden)
                {
                    Math_Image.Visibility = Visibility.Visible;
                    while (true)
                    {
                        if (Math_Image.Opacity >= 1)
                        {
                            break;
                        }
                        Math_Image.Opacity += 0.05;
                        await Task.Delay(1000 / 30);
                    }
                }
            }
            else if (Math_Image.Visibility == Visibility.Visible)
            {
                while (true)
                {
                    if (Math_Image.Opacity <= 0)
                    {
                        Math_Image.Visibility = Visibility.Hidden;
                        break;
                    }
                    Math_Image.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
            }
        }
    }
}