using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Everyone_With_Math.Class
{
    public partial class Math_01 : Window
    {
        //文章の表示システムのクラス
        string Story_01;
        int Story_Page_01 = 0;
        string Story_02;
        int Story_Page_02 = 0;
        string Name_01;
        string Chara_01 = "\n";
        int Story_Speed = 30;
        int Choice_Number = 0;
        bool Story_Next_Clicked = false;
        bool First_Story_End = false;
        bool Clear = false;
        bool Story_Not_Proceed = false;
        bool Result_Manager = false;
        //文章を表示中にマウスをクリックさせた場合文章を一気に表示させる
        bool Story_Next_Clicked_Click = false;
        void Story_Text_Next(object sender,MouseButtonEventArgs e)
        {
            Text_Next();
        }
        void Choice_01_Mouse_Down(object sender, MouseButtonEventArgs e)
        {
            Choice_Number = 1;
            Choice_Click_OK();
        }
        void Choice_02_Mouse_Down(object sender, MouseButtonEventArgs e)
        {
            Choice_Number = 2;
            Choice_Click_OK();
        }
        void Choice_03_Mouse_Down(object sender, MouseButtonEventArgs e)
        {
            Choice_Number = 3;
            Choice_Click_OK();
        }
        void Choice_04_Mouse_Down(object sender, MouseButtonEventArgs e)
        {
            Choice_Number = 4;
            Choice_Click_OK();
        }
        async void Text_Next()
        {
            if (First_Story_End == false)
            {
                if (Story_Next_Clicked == false && Choice_Show_Story_Not_Next == false)
                {
                    //文章を1文字ずつ表示させる。また、表示中に画面がクリックされたらその文章を一気に表示させる
                    Text_Event();
                    Story_Next_Clicked = true; 
                    string[] dest = Story_01.Split('\n');
                    string output = "";
                    int waitTimeChar = 60 - Story_Speed;
                    foreach (char c in dest[Story_Page_01])
                    {
                        if (Story_Next_Clicked_Click == true)
                        {
                            Story_Next_Clicked_Click = false;
                            Text_01_T.Text = dest[Story_Page_01];
                            Text_02_T.Text = dest[Story_Page_01];
                            break;
                        }
                        output += c.ToString();
                        Text_01_T.Text = output;
                        Text_02_T.Text = output;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(waitTimeChar);
                        }
                    }
                    //以下の文章だった場合イベントを実行
                    if (dest[Story_Page_01].Contains("リザルトを見ますか？") && Result_Manager == false)
                    {
                        Choice_Show_Story_Not_Next = true;
                        Button_Answer_Word_01 = "はい";
                        Button_Answer_Word_02 = "いいえ";
                        Button_Select_Double();
                        Result_Manager = true;
                    }
                    else if (dest[Story_Page_01].Contains("ストーリーを見ますか？"))
                    {
                        Choice_Show_Story_Not_Next = true;
                        Button_Answer_Word_01 = "見る";
                        Button_Answer_Word_02 = "見ない";
                        Button_Select_Double();
                    }
                    else if (dest[Story_Page_01].Contains("メニュー画面に新モードを追加したから確認してね") || dest[Story_Page_01].Contains("これからメニュー画面に移行するね") || dest[Story_Page_01].Contains("メイン画面へ移動します。"))
                    {
                        Choice_Show_Story_Not_Next = true;
                        Close_Window();
                    }
                    Story_Page_01 = (Story_Page_01 + 1) % dest.Length;
                    Story_Next_Clicked = false;
                    Story_Next_Clicked_Click = false;
                }
                else
                {
                    Story_Next_Clicked_Click = true;
                }
            }
            else
            {
                if (IsGrade_1_2_3_Clear == true && Story_Next_Clicked == false && Story_Not_Proceed == false)
                {
                    if (Story_Next_Clicked == false && Choice_Show_Story_Not_Next == false)
                    {
                        Story_Next_Clicked = true;
                        Clear_Event();
                        string[] dest = Story_02.Split('\n');
                        string[] Name_dest = Name_01.Split('\n');
                        string output = "";
                        int waitTimeChar = 60 - Story_Speed;
                        Name_01_T.Text = Name_dest[Story_Page_02];
                        Name_02_T.Text = Name_dest[Story_Page_02];
                        string[] Chara_01_dest = Chara_01.Split('\n');
                        if (Story_File_Number == 4 && IsDebug == true)
                        {
                            //デバッグ時のみストーリーにキャラクターが表示されるように(モチベーション向上のため)
                            Story_04_Chara_Image_Select(int.Parse(Chara_01_dest[Story_Page_02]));
                        }
                        foreach (char c in dest[Story_Page_02])
                        {
                            if (Story_Next_Clicked_Click == true)
                            {
                                Story_Next_Clicked_Click = false;
                                Text_01_T.Text = dest[Story_Page_02];
                                Text_02_T.Text = dest[Story_Page_02];
                                break;
                            }
                            output += c.ToString();
                            Text_01_T.Text = output;
                            Text_02_T.Text = output;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(waitTimeChar);
                            }
                        }
                        //ログにテキストを追加
                        BackLog_L.Items.Add(dest[Story_Page_02]);
                        Story_Page_02 = (Story_Page_02 + 1) % dest.Length;
                        Story_Next_Clicked = false;
                        Story_Next_Clicked_Click = false;
                    }
                    else
                    {
                        Story_Next_Clicked_Click = true;
                    }
                }
                else if (Story_Next_Clicked == false && Choice_Show_Story_Not_Next == false && Story_Not_Proceed == false)
                {
                    //文章を1文字ずつ表示させる。また、表示中に画面がクリックされたらその文章を一気に表示させる
                    Text_Event();
                    Story_Next_Clicked = true;
                    string dest = Question_Word;
                    string output = "";
                    int waitTimeChar = 60 - Story_Speed;
                    foreach (char c in dest)
                    {
                        if (Story_Next_Clicked_Click == true)
                        {
                            Story_Next_Clicked_Click = false;
                            Text_01_T.Text = dest;
                            Text_02_T.Text = dest;
                            break;
                        }
                        output += c.ToString();
                        Text_01_T.Text = output;
                        Text_02_T.Text = output;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(waitTimeChar);
                        }
                    }
                    Story_Next_Clicked = false;
                    Story_Next_Clicked_Click = false;
                    Choice_Show_Story_Not_Next = true;
                }
                else
                {
                    Story_Next_Clicked_Click = true;
                }
            }
        }
    }
}