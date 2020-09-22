using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using WMPLib;

namespace Everyone_With_Math.Class
{
    public partial class Math_01 : Window
    {
        WindowsMediaPlayer SE = new WindowsMediaPlayer();
        WindowsMediaPlayer SE_01 = new WindowsMediaPlayer();
        WindowsMediaPlayer SE_02 = new WindowsMediaPlayer();
        WindowsMediaPlayer BGM = new WindowsMediaPlayer();
        string Path = Directory.GetCurrentDirectory();
        string Window_Show_Name = "";
        bool IsDialogShowed = false;
        static System.Drawing.Point aaa = new System.Drawing.Point();
        readonly int h = System.Windows.Forms.Screen.GetBounds(aaa).Height;
        readonly int w = System.Windows.Forms.Screen.GetBounds(aaa).Width;
        bool IsOtherWindowShowed = false;
        bool IsChoiceMouseEnter = false;
        bool IsExit_B_Click_True = false;
        bool BGM_Close = false;
        bool IsCanNotSaveNow = false;
        bool IsSave_Show = false;
        bool IsQuestion_Number_Only = false;
        bool IsDebug = false;
        int Chara_Image_Number = 0;
        bool Difficult_Question_Mode = false;
        bool Story_Mode_Only = false;
        int Timer_All = 0;
        int Timer_Seconds = 0;
        int Timer_Minutes = 0;
        int Timer_Hour = 0;
        int BGM_Number_Now = 0;
        public Math_01()
        {
            //起動時の処理
            InitializeComponent();
            //デバッグモードの有効化
#if DEBUG
            IsDebug = true;
#endif
            if (File.Exists(Path + "/IsDebugMode.dat"))
            {
                StreamReader str = new StreamReader(Path + "/IsDebugMode.dat");
                string str_read = str.ReadLine();
                str.Close();
                if (str_read == "True" || str_read == "true")
                {
                    IsDebug = true;
                }
            }
            Window_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Window_02.png"));
            Title_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Title.png"));
            Dialog_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Dialog_01.png"));
            Dialog_No_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/No.png"));
            Dialog_Yes_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Yes.png"));
            Dialog_Message_Iage.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Message_03.png"));
            Dialog_Effect_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Spark/1.png"));
            White_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/White.png"));
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Black_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Black.png"));
            Main_Image_01.Source = new BitmapImage(new Uri(Path + "/Resources/BG/White.png"));
            Main_Image_02.Source = new BitmapImage(new Uri(Path + "/Resources/BG/White.png"));
            Save_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save/Save_00.png"));
            Load_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save/Load_00.png"));
            Kakko_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Math/中カッコ.png"));
            BackLog_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/BackLog_01.png"));
            BackLog_Close_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_01.png"));
            Log_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Log_01.png"));
            Config_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Config.png"));
            Chara_Image.Source = null;
            Chara_Mini_Image.Source = null;
            Log_Image.Visibility = Visibility.Hidden;
            Window_Image.Opacity = 0;
            Title_Image.Opacity = 0;
            Text_01_T.Opacity = 0;
            Text_02_T.Opacity = 0;
            Chara_Image.Opacity = 0;
            Chara_Mini_Image.Opacity = 0;
            Chara_Image.Visibility = Visibility.Hidden;
            Chara_Mini_Image.Visibility = Visibility.Hidden;
            Configs_Window.Visibility = Visibility.Hidden;
            Config_Image.Opacity = 0;
            Configs_Window.Opacity = 0;
            Save_Image.Opacity = 0;
            Load_Image.Opacity = 0;
            Kakko_Image.Visibility = Visibility.Hidden;
            Text_01_T.Text = "";
            Text_02_T.Text = "";
            Choice_01_T.Text = "";
            Choice_02_T.Text = "";
            Choice_03_T.Text = "";
            Window_Show();
            //テキストを読み込む(AESで暗号化しているため複合化する。パスは"Created_By_SRTTbacon_and_Gumipoteti_E")
            using (var eifs = new FileStream(Path + "/Resources/Story/Story_Start.dat", FileMode.Open, FileAccess.Read))
            {
                using (var eofs = new FileStream(Path + "/Resources/Story_TEMP.dat", FileMode.Create, FileAccess.Write))
                {
                    FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                    StreamReader str4 = new StreamReader(Path + "/Resources/Story_TEMP.dat");
                    Story_01 = str4.ReadToEnd();
                    str4.Close();
                    File.Delete(Path + "/Resources/Story_TEMP.dat");
                }
            }
            //ボタン以外のどこをクリックしてもテキストが更新されるように
            Main_Image_01.MouseDown += new MouseButtonEventHandler(Story_Text_Next);
            Main_Image_02.MouseDown += new MouseButtonEventHandler(Story_Text_Next);
            Text_01_T.MouseDown += new MouseButtonEventHandler(Story_Text_Next);
            Text_02_T.MouseDown += new MouseButtonEventHandler(Story_Text_Next);
            Name_01_T.MouseDown += new MouseButtonEventHandler(Story_Text_Next);
            Name_02_T.MouseDown += new MouseButtonEventHandler(Story_Text_Next);
            Chara_Image.MouseDown += new MouseButtonEventHandler(Story_Text_Next);
            Chara_Mini_Image.MouseDown += new MouseButtonEventHandler(Story_Text_Next);
            Window_Image.MouseDown += new MouseButtonEventHandler(Story_Text_Next);
            Mouse_Effect_Image.MouseDown += new MouseButtonEventHandler(Story_Text_Next);
            Choice_01_Image.MouseDown += new MouseButtonEventHandler(Choice_01_Mouse_Down);
            Choice_01_T.MouseDown += new MouseButtonEventHandler(Choice_01_Mouse_Down);
            Choice_02_Image.MouseDown += new MouseButtonEventHandler(Choice_02_Mouse_Down);
            Choice_02_T.MouseDown += new MouseButtonEventHandler(Choice_02_Mouse_Down);
            Choice_03_Image.MouseDown += new MouseButtonEventHandler(Choice_03_Mouse_Down);
            Choice_03_T.MouseDown += new MouseButtonEventHandler(Choice_03_Mouse_Down);
            Choice_04_Image.MouseDown += new MouseButtonEventHandler(Choice_04_Mouse_Down);
            Choice_04_T.MouseDown += new MouseButtonEventHandler(Choice_04_Mouse_Down);
            SE.settings.volume = (int)Configs_Window.SE_Volume_S.Value;
            SE_01.settings.volume = (int)Configs_Window.SE_Volume_S.Value;
            SE_02.settings.volume = (int)Configs_Window.SE_Volume_S.Value;
            BGM.settings.volume = (int)Configs_Window.BGM_Volume_S.Value;
            //設定の項目取得(フルスクリーン&テキスト背景カラー)
            XDocument xml2 = XDocument.Load(Path + "/Resources/Save/Configs.dat");
            XElement item2 = xml2.Element("Configs_Save");
            XElement item_01 = item2.Element("FullScreenMode");
            XElement item_02 = item2.Element("Window_Color");
            XElement item_03 = item2.Element("Click_Explosion");
            Window_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Window_0" + item_02.Value + ".png"));
            if (bool.Parse(item_03.Value) == true)
            {
                System.Drawing.Point p = new System.Drawing.Point();
                int h = System.Windows.Forms.Screen.GetBounds(p).Height;
                int w = System.Windows.Forms.Screen.GetBounds(p).Width;
                //Configs.datのClick_Explosionの項目をメモ帳などで変更されたとき条件を満たしていなければ機能を無効に
                if (bool.Parse(item_03.Value) == true && w == 1920 && h == 1080)
                {
                    Configs_Window.Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_03.png"));
                }
                else
                {
                    Configs_Window.Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_01.png"));
                    Configs_Window.Click_Explosion = false;
                }
            }
            if (bool.Parse(item_01.Value) == false)
            {
                //ウィンドウモードだった場合画面の大きさをディスプレイの大きさx0.9にする(24インチ1920x1080の場合はこれでちょうどよかったため)
                WindowState = WindowState.Normal;
                int h = System.Windows.Forms.Screen.GetBounds(aaa).Height;
                int w = System.Windows.Forms.Screen.GetBounds(aaa).Width;
                Width = w * 0.9;
                Height = h * 0.9;
                Left = w * 0.05;
                Top = h * 0.025;
            }
            int Load_Number = 0;
            if (File.Exists(Path + "/Resources/Save/Load_01.dat"))
            {
                StreamReader str2 = new StreamReader(Path + "/Resources/Save/Load_01.dat");
                Load_Number = int.Parse(str2.ReadLine());
                str2.Close();
            }
            if (File.Exists(Path + "/Resources/Save/Load_Question_Number.dat"))
            {
                //Grade_01クラスで指定した問題を永遠とプレイできるように
                StreamReader Read = new StreamReader(Path + "/Resources/Save/Load_Question_Number.dat");
                int Read_Number = int.Parse(Read.ReadLine());
                int Grade_Number_01 = int.Parse(Read.ReadLine());
                Read.Close();
                Grade_Number = Grade_Number_01;
                Question_Number = Read_Number - 1;
                First_Story_End = true;
                Choice_Click = false;
                Text_01_T.FontSize = 40;
                Text_02_T.FontSize = 40;
                Question_Number_T.Visibility = Visibility.Visible;
                Question_Number += 1;
                Question_Number_T.Text = Question_Number + "/30";
                Question_Number_Definition();
                Name_01_T.Visibility = Visibility.Hidden;
                Name_02_T.Visibility = Visibility.Hidden;
                Help_T.Visibility = Visibility.Visible;
                Help_T.Text = "'^'は累乗を表す。\n'/'は分数を表す。注意:'/'の右側が分母とする";
                Text_Next();
                Main_Image_01.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Math_Main_01.png"));
                Main_Image_02.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Math_Main_01.png"));
                Math_Image_Play = true;
                Main_Image_02.Opacity = 1;
                Animation_Image = 2;
                Math_Back_Animation();
                BGM_Start();
                IsQuestion_Number_Only = true;
                File.Delete(Path + "/Resources/Save/Load_Question_Number.dat");
            }
            else if (File.Exists(Path + "/Resources/Save/Last_Question_Mode.dat"))
            {
                //超難問モードで実行
                Grade_Number = 0;
                Story_File_Number = 0;
                Difficult_Question_Mode = true;
                First_Story_End = true;
                Choice_Click = false;
                Text_01_T.FontSize = 40;
                Text_02_T.FontSize = 40;
                Question_Number_T.Visibility = Visibility.Visible;
                Question_Number_T.Text = "超難問";
                Difficult_Question_Set();
                Name_01_T.Visibility = Visibility.Hidden;
                Name_02_T.Visibility = Visibility.Hidden;
                Help_T.Visibility = Visibility.Visible;
                Help_T.Text = "'^'は累乗を表す。\n'/'は分数を表す。注意:'/'の右側が分母とする";
                Text_Next();
                Main_Image_01.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Math_Main_01.png"));
                Main_Image_02.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Math_Main_01.png"));
                Math_Image_Play = true;
                Main_Image_02.Opacity = 1;
                Animation_Image = 0;
                Fire_Animation();
                BGM_Start();
                File.Delete(Path + "/Resources/Save/Last_Question_Mode.dat");
                Timer_Start();
            }
            else if (File.Exists(Path + "/Resources/Save/Load_Story.dat"))
            {
                //ストーリーモードのみの実行
                StreamReader str = new StreamReader(Path + "/Resources/Save/Load_Story.dat");
                Story_File_Number = int.Parse(str.ReadLine());
                str.Close();
                Story_Mode_Only = true;
                Clear = true;
                First_Story_End = false;
                IsCanNotSaveNow = true;
                File.Delete(Path + "/Resources/Save/Load_Story.dat");
                Clear_Story_Start();
            }
            //Load_01.datの内容が1,2,3だった場合セーブデータを取得し反映させる
            else if (Load_Number == 1 || Load_Number == 2 || Load_Number == 3)
            {
                //暗号化されたデータを複合化し読み込む
                using (var eifs = new FileStream(Path + "/Resources/Save/Save_0" + Load_Number + ".dat", FileMode.Open, FileAccess.Read))
                {
                    using (var eofs = new FileStream(Path + "/Resources/Save/Save_10.dat", FileMode.Create, FileAccess.Write))
                    {
                        FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                    }
                }
                XDocument xml = XDocument.Load(Path + "/Resources/Save/Save_10.dat");
                XElement item = xml.Element("Save_Definition");
                if (item.Element("Grade").Value.Contains("1"))
                {
                    Grade_Number = 1;
                    Load_Question_Answer_01();
                }
                else if (item.Element("Grade").Value.Contains("2"))
                {
                    Grade_Number = 2;
                    Load_Question_Answer_02();
                }
                else if (item.Element("Grade").Value.Contains("3"))
                {
                    Grade_Number = 3;
                    Load_Question_Answer_03();
                }
                Question_Number = int.Parse(item.Element("Question_Number").Value) - 1;
                File.Delete(Path + "/Resources/Save/Save_10.dat");
                First_Story_End = true;
                Choice_Click = false;
                Text_01_T.FontSize = 40;
                Text_02_T.FontSize = 40;
                Name_01_T.Visibility = Visibility.Hidden;
                Name_02_T.Visibility = Visibility.Hidden;
                Question_Number_T.Visibility = Visibility.Visible;
                Question_Number += 1;
                Question_Number_T.Text = Question_Number + "/30";
                Question_Number_Definition();
                Help_T.Visibility = Visibility.Visible;
                Help_T.Text = "'^'は累乗を表す。\n'/'は分数を表す。注意:'/'の右側が分母とする";
                Text_Next();
                Main_Image_01.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Math_Main_01.png"));
                Main_Image_02.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Math_Main_01.png"));
                Math_Image_Play = true;
                Main_Image_02.Opacity = 1;
                Animation_Image = 2;
                Math_Back_Animation();
                BGM_Close = false;
                BGM_Start();
            }
            Random r = new Random();
            Chara_Image_Number = r.Next(1, 3);
        }
        async void Window_Show()
        {
            //ボタンや画像をフェードインさせる(起動時のみ実行)
            //BackLog_Imageはストーリー時(クリア後)のみ表示させるのでここでは記述しない
            while (true)
            {
                if (Window_Image.Opacity >= 1)
                {
                    Text_Next();
                    break;
                }
                Window_Image.Opacity += 0.02;
                Title_Image.Opacity += 0.02;
                Config_Image.Opacity += 0.02;
                Text_01_T.Opacity += 0.02;
                Text_02_T.Opacity += 0.02;
                Save_Image.Opacity += 0.02;
                Load_Image.Opacity += 0.02;
                await Task.Delay(1000 / 30);
            }
        }
        private void Title_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Title_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Title_01.png"));
        }
        private void Title_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Title_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Title.png"));
        }
        private void Title_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Dialog_Show();
        }
        async void Dialog_Show()
        {
            //ダイアログを表示
            if (IsDialogShowed == false && IsOtherWindowShowed == false)
            {
                SE_01_Play(Path + "/Resources/SE/SE_03.wav");
                Dialog_Image.Visibility = Visibility.Visible;
                Dialog_Effect_Image.Visibility = Visibility.Visible;
                Dialog_Message_Iage.Visibility = Visibility.Visible;
                Dialog_No_Image.Visibility = Visibility.Visible;
                Dialog_Yes_Image.Visibility = Visibility.Visible;
                IsDialogShowed = true;
                Curser_Location();
                Dialog_Effect();
                while (true)
                {
                    if (Dialog_Message_Iage.Opacity >= 1)
                    {
                        IsExit_B_Click_True = true;
                        break;
                    }
                    if (Dialog_Image.Opacity <= 0.75)
                    {
                        Dialog_Image.Opacity += 0.05;
                        Dialog_Effect_Image.Opacity += 0.05;
                    }
                    Dialog_Message_Iage.Opacity += 0.05;
                    Dialog_No_Image.Opacity += 0.05;
                    Dialog_Yes_Image.Opacity += 0.05;
                    await Task.Delay(1000 / 30);
                }
            }
            else if (IsDialogShowed == true && Dialog_No_Image.Opacity >= 1)
            {
                SE_Play(Path + "/Resources/SE/SE_01.wav");
                while (Dialog_Message_Iage.Opacity > 0)
                {
                    Dialog_Image.Opacity -= 0.05;
                    Dialog_No_Image.Opacity -= 0.05;
                    Dialog_Yes_Image.Opacity -= 0.05;
                    Dialog_Message_Iage.Opacity -= 0.05;
                    Dialog_Effect_Image.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
                Dialog_Image.Visibility = Visibility.Hidden;
                Dialog_No_Image.Visibility = Visibility.Hidden;
                Dialog_Yes_Image.Visibility = Visibility.Hidden;
                Dialog_Message_Iage.Visibility = Visibility.Hidden;
                Dialog_Effect_Image.Visibility = Visibility.Hidden;
                Dialog_Image.Opacity = 0;
                Dialog_Message_Iage.Opacity = 0;
                Dialog_Yes_Image.Opacity = 0;
                Dialog_No_Image.Opacity = 0;
                Dialog_Effect_Image.Opacity = 0;
                IsExit_B_Click_True = false;
                IsDialogShowed = false;
            }
            //他のウィンドウが開いていた場合それを閉じる
            else if (Window_Show_Name == "設定")
            {
                if (Configs_Window.Opacity >= 1)
                {
                    Configs_Window.IsClosing = true;
                    while (true)
                    {
                        if (Configs_Window.Opacity <= 0)
                        {
                            Configs_Window.IsClosing = false;
                            IsOtherWindowShowed = false;
                            Window_Show_Name = "";
                            Configs_Window.Visibility = Visibility.Hidden;
                            break;
                        }
                        Configs_Window.Opacity -= 0.05;
                        await Task.Delay(1000 / 30);
                    }
                }
            }
            else if (Window_Show_Name == "ロード")
            {
                if (Load_Window.Opacity >= 1)
                {
                    Load_Window.IsClosing = true;
                    while (true)
                    {
                        if (Load_Window.Opacity <= 0)
                        {
                            Load_Window.IsClosing = false;
                            IsOtherWindowShowed = false;
                            Window_Show_Name = "";
                            Load_Window.Visibility = Visibility.Hidden;
                            break;
                        }
                        Load_Window.Opacity -= 0.05;
                        await Task.Delay(1000 / 30);
                    }
                }
            }
            else if (Window_Show_Name == "セーブ")
            {
                if (Save_Window.Opacity >= 1)
                {
                    while (true)
                    {
                        if (Save_Window.Opacity <= 0)
                        {
                            Save_Window.IsClosing = false;
                            IsOtherWindowShowed = false;
                            Window_Show_Name = "";
                            Save_Window.Visibility = Visibility.Hidden;
                            break;
                        }
                        Save_Window.Opacity -= 0.05;
                        await Task.Delay(1000 / 30);
                    }
                }
            }
            else if (Window_Show_Name == "ログ")
            {
                if (BackLog_Close_Image.Opacity >= 1)
                {
                    while (true)
                    {
                        if (BackLog_Close_Image.Opacity <= 0)
                        {
                            BackLog_Image.Visibility = Visibility.Hidden;
                            BackLog_L.Visibility = Visibility.Hidden;
                            BackLog_Close_Image.Visibility = Visibility.Hidden;
                            IsOtherWindowShowed = false;
                            Window_Show_Name = "";
                            break;
                        }
                        BackLog_Image.Opacity -= 0.05;
                        BackLog_L.Opacity -= 0.05;
                        BackLog_Close_Image.Opacity -= 0.05;
                        await Task.Delay(1000 / 30);
                    }
                }
            }
        }
        async void Dialog_Effect()
        {
            //ダイアログの雷のエフェクトを表示
            int Number = 1;
            while (IsDialogShowed == true)
            {
                if (Number <= 8)
                {
                    Dialog_Effect_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Spark/" + Number + ".png"));
                    Number += 1;
                }
                else
                {
                    Number = 1;
                }
                await Task.Delay(1000 / 30);
            }
        }
        void SE_Play(string File)
        {
            //FileのSEを再生
            SE.controls.stop();
            SE.URL = File;
            SE.controls.play();
        }
        void SE_01_Play(string File)
        {
            //IsSE_01はtrueでもfalseでも処理は変わらない
            SE_01.controls.stop();
            SE_01.URL = File;
            SE_01.controls.play();
        }
        void SE_02_Play(string File)
        {
            SE_02.controls.stop();
            SE_02.URL = File;
            SE_02.controls.play();
        }
        async void Curser_Location()
        {
            //カーソルの位置をダイアログの中心に移動する(h = height,w = width)
            int Y_Number = h / 2 - System.Windows.Forms.Cursor.Position.Y;
            int X_Number = w / 2 - System.Windows.Forms.Cursor.Position.X;
            int Y_Speed = Y_Number / 10;
            int X_Speed = X_Number / 10;
            int Time = 0;
            while (true)
            {
                if (System.Windows.Forms.Cursor.Position.Y >= h / 2 - 25 && System.Windows.Forms.Cursor.Position.Y <= h / 2 + 25)
                {

                }
                else
                {
                    System.Windows.Forms.Cursor.Position = new System.Drawing.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y + Y_Speed);
                }
                if (System.Windows.Forms.Cursor.Position.X >= w / 2 - 25 && System.Windows.Forms.Cursor.Position.X <= w / 2 + 25)
                {

                }
                else
                {
                    System.Windows.Forms.Cursor.Position = new System.Drawing.Point(System.Windows.Forms.Cursor.Position.X + X_Speed, System.Windows.Forms.Cursor.Position.Y);
                }
                if (System.Windows.Forms.Cursor.Position.X >= w / 2 - 25 && System.Windows.Forms.Cursor.Position.X <= w / 2 + 25 && System.Windows.Forms.Cursor.Position.Y >= h / 2 - 25 && System.Windows.Forms.Cursor.Position.Y <= h / 2 + 25 || Time >= 10)
                {
                    break;
                }
                Time += 1;
                await Task.Delay(1000 / 60);
            }
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //Escキーが押されたら終了ダイアログを表示(すでに表示されていたら実行しない)
            if (e.Key == Key.Escape && IsSave_Show == false)
            {
                Dialog_Show();
            }
        }
        private void Dialog_Yes_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Dialog_Yes_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Yes_01.png"));
        }
        private void Dialog_Yes_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Dialog_Yes_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Yes.png"));
        }
        private void Dialog_No_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Dialog_No_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/No_01.png"));
        }
        private void Dialog_No_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Dialog_No_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/No.png"));
        }
        private void Dialog_Yes_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //終了ダイアログにて"はい"が追われた場合Close_Windowを実行
            Close_Window();
        }
        async void Close_Window()
        {
            //はいが選択された場合、白い画像をフェードインさせてソフトを終了させる
            IsExit_B_Click_True = false;
            SE_Play(Path + "/Resources/SE/SE_02.wav");
            IsDialogShowed = true;
            White_Image.Visibility = Visibility.Visible;
            White_Image.Opacity = 0;
            while (White_Image.Opacity < 1)
            {
                White_Image.Opacity += 0.02;
                await Task.Delay(1000 / 30);
            }
            await Task.Delay(500);
            while (Opacity > 0)
            {
                Opacity -= 0.05;
                await Task.Delay(1000 / 30);
            }
            IsDialogShowed = false;
            BGM_Close = true;
            BGM.controls.stop();
            Home_Window f = new Home_Window();
            f.Show();
            Close();
        }
        private async void Dialog_No_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (IsExit_B_Click_True == true)
            {
                //いいえが選択された場合ダイアログを非表示に
                SE_Play(Path + "/Resources/SE/SE_01.wav");
                IsExit_B_Click_True = false;
                IsDialogShowed = true;
                while (Dialog_Message_Iage.Opacity > 0)
                {
                    Dialog_Image.Opacity -= 0.05;
                    Dialog_No_Image.Opacity -= 0.05;
                    Dialog_Yes_Image.Opacity -= 0.05;
                    Dialog_Message_Iage.Opacity -= 0.05;
                    Dialog_Effect_Image.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
                Dialog_Image.Visibility = Visibility.Hidden;
                Dialog_No_Image.Visibility = Visibility.Hidden;
                Dialog_Yes_Image.Visibility = Visibility.Hidden;
                Dialog_Message_Iage.Visibility = Visibility.Hidden;
                Dialog_Effect_Image.Visibility = Visibility.Hidden;
                Dialog_Image.Opacity = 0;
                Dialog_Message_Iage.Opacity = 0;
                Dialog_Yes_Image.Opacity = 0;
                Dialog_No_Image.Opacity = 0;
                Dialog_Effect_Image.Opacity = 0;
                IsDialogShowed = false;
            }
        }
        private void Choice_01_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            if (IsChoiceMouseEnter == false)
            {
                SE_Play(Path + "/Resources/SE/SE_04.wav");
            }
            IsChoiceMouseEnter = true;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_02.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
        }
        private void Choice_01_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            IsChoiceMouseEnter = false;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
        }
        private void Choice_01_T_MouseEnter(object sender, MouseEventArgs e)
        {
            IsChoiceMouseEnter = true;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_02.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
        }
        private void Choice_02_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            if (IsChoiceMouseEnter == false)
            {
                SE_Play(Path + "/Resources/SE/SE_04.wav");
            }
            IsChoiceMouseEnter = true;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_02.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
        }
        private void Choice_02_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            IsChoiceMouseEnter = false;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
        }
        private void Choice_02_T_MouseEnter(object sender, MouseEventArgs e)
        {
            IsChoiceMouseEnter = true;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_02.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
        }
        private void Choice_03_T_MouseEnter(object sender, MouseEventArgs e)
        {
            IsChoiceMouseEnter = true;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_02.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
        }
        private void Choice_03_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            if (IsChoiceMouseEnter == false)
            {
                SE_Play(Path + "/Resources/SE/SE_04.wav");
            }
            IsChoiceMouseEnter = true;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_02.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
        }
        private void Choice_03_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            IsChoiceMouseEnter = false;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
        }
        private void Choice_04_T_MouseEnter(object sender, MouseEventArgs e)
        {
            IsChoiceMouseEnter = true;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_02.png"));
        }
        private void Choice_04_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            if (IsChoiceMouseEnter == false)
            {
                SE_Play(Path + "/Resources/SE/SE_04.wav");
            }
            IsChoiceMouseEnter = true;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_02.png"));
        }
        private void Choice_04_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            IsChoiceMouseEnter = false;
            Choice_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
            Choice_04_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Choice_01.png"));
        }
        private void Config_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Config_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Config_01.png"));
        }
        private void Config_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Config_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Config.png"));
        }
        private async void Config_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //設定ウィンドウを表示
            IsOtherWindowShowed = true;
            Window_Show_Name = "設定";
            Configs_Window.Visibility = Visibility.Visible;
            Configs_Window.Load_Configs();
            Configs_Window.Opacity = 0;
            Configs_Window.IsClosing = true;
            Configs_Window.Change = true;
            IsSave_Show = true;
            while (true)
            {
                if (Configs_Window.Opacity >= 1)
                {
                    Config_Change();
                    Configs_Window.IsClosing = false;
                    break;
                }
                Configs_Window.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
        }
        async void Config_Change()
        {
            //設定ウィンドウが開かれている間設定を更新させる
            while (Configs_Window.Change == true)
            {
                SE.settings.volume = (int)Configs_Window.SE_Volume_S.Value;
                SE_01.settings.volume = (int)Configs_Window.SE_Volume_S.Value;
                SE_02.settings.volume = (int)Configs_Window.SE_Volume_S.Value;
                BGM.settings.volume = (int)Configs_Window.BGM_Volume_S.Value;
                Story_Speed = (int)Configs_Window.Text_Speed_S.Value;
                Window_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Window_0" + (Configs_Window.Window_Color_L.SelectedIndex + 1) + ".png"));
                if (Configs_Window.FullScreen == false)
                {
                    WindowState = WindowState.Normal;
                    int h = System.Windows.Forms.Screen.GetBounds(aaa).Height;
                    int w = System.Windows.Forms.Screen.GetBounds(aaa).Width;
                    Width = w * 0.9;
                    Height = h * 0.9;
                    Left = w * 0.05;
                    Top = h * 0.025;
                    if (Configs_Window.Click_Explosion == true)
                    {
                        //クリック機能を有効にしたままウィンドウモードにできないように
                        Configs_Window.Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_01.png"));
                        Configs_Window.Click_Explosion = false;
                        Configs_Window.Click_Explosion_L.Visibility = Visibility.Hidden;
                    }
                }
                else
                {
                    WindowState = WindowState.Maximized;
                }
                await Task.Delay(100);
            }
            IsOtherWindowShowed = false;
            Window_Show_Name = "";
            IsSave_Show = false;
        }
        private void Save_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Save_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save/Save_01.png"));
        }
        private void Save_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Save_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save/Save_00.png"));
        }
        private async void Save_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //セーブボタンが押されたら仮のセーブファイルと画像を作成
            IsOtherWindowShowed = true;
            Window_Show_Name = "セーブ";
            IsSave_Show = true;
            StreamWriter stw = File.CreateText(Path + "/Resources/Save/Save_99_Temp.dat");
            stw.Close();
            Save_Definition Save = new Save_Definition();
            if (Grade_Number == 0 || IsCanNotSaveNow == true)
            {
                //セーブできない場面だった場合
                MessageBox.Show("この段階ではセーブできません。");
                return;
            }
            Save.Grade = "中学" + Grade_Number + "年生以上";
            Save.Question_Number = Question_Number;
            //仮の現在時刻を取得(セーブクラスで再設定するため使用しない)
            DateTime d = DateTime.Now;
            Save.Time = d.Year + "/" + d.Month + "/" + d.Date + "/" + d.Hour + ":" + d.Minute + ":" + d.Second;
            Save.Question_01_01_Answer = Question_01_01_Answer;
            Save.Question_01_02_Answer = Question_01_02_Answer;
            Save.Question_01_03_Answer = Question_01_03_Answer;
            Save.Question_01_04_Answer = Question_01_04_Answer;
            Save.Question_01_05_Answer = Question_01_05_Answer;
            Save.Question_01_06_Answer = Question_01_06_Answer;
            Save.Question_01_07_Answer = Question_01_07_Answer;
            Save.Question_01_08_Answer = Question_01_08_Answer;
            Save.Question_01_09_Answer = Question_01_09_Answer;
            Save.Question_01_10_Answer = Question_01_10_Answer;
            Save.Question_01_11_Answer = Question_01_11_Answer;
            Save.Question_01_12_Answer = Question_01_12_Answer;
            Save.Question_01_13_Answer = Question_01_13_Answer;
            Save.Question_01_14_Answer = Question_01_14_Answer;
            Save.Question_01_15_Answer = Question_01_15_Answer;
            Save.Question_01_16_Answer = Question_01_16_Answer;
            Save.Question_01_17_Answer = Question_01_17_Answer;
            Save.Question_01_18_Answer = Question_01_18_Answer;
            Save.Question_01_19_Answer = Question_01_19_Answer;
            Save.Question_01_20_Answer = Question_01_20_Answer;
            Save.Question_01_21_Answer = Question_01_21_Answer;
            Save.Question_01_22_Answer = Question_01_22_Answer;
            Save.Question_01_23_Answer = Question_01_23_Answer;
            Save.Question_01_24_Answer = Question_01_24_Answer;
            Save.Question_01_25_Answer = Question_01_25_Answer;
            Save.Question_01_26_Answer = Question_01_26_Answer;
            Save.Question_01_27_Answer = Question_01_27_Answer;
            Save.Question_01_28_Answer = Question_01_28_Answer;
            Save.Question_01_29_Answer = Question_01_29_Answer;
            Save.Question_01_30_Answer = Question_01_30_Answer;
            Save.Question_02_01_Answer = Question_02_01_Answer;
            Save.Question_02_02_Answer = Question_02_02_Answer;
            Save.Question_02_03_Answer = Question_02_03_Answer;
            Save.Question_02_04_Answer = Question_02_04_Answer;
            Save.Question_02_05_Answer = Question_02_05_Answer;
            Save.Question_02_06_Answer = Question_02_06_Answer;
            Save.Question_02_07_Answer = Question_02_07_Answer;
            Save.Question_02_08_Answer = Question_02_08_Answer;
            Save.Question_02_09_Answer = Question_02_09_Answer;
            Save.Question_02_10_Answer = Question_02_10_Answer;
            Save.Question_02_11_Answer = Question_02_11_Answer;
            Save.Question_02_12_Answer = Question_02_12_Answer;
            Save.Question_02_13_Answer = Question_02_13_Answer;
            Save.Question_02_14_Answer = Question_02_14_Answer;
            Save.Question_02_15_Answer = Question_02_15_Answer;
            Save.Question_02_16_Answer = Question_02_16_Answer;
            Save.Question_02_17_Answer = Question_02_17_Answer;
            Save.Question_02_18_Answer = Question_02_18_Answer;
            Save.Question_02_19_Answer = Question_02_19_Answer;
            Save.Question_02_20_Answer = Question_02_20_Answer;
            Save.Question_02_21_Answer = Question_02_21_Answer;
            Save.Question_02_22_Answer = Question_02_22_Answer;
            Save.Question_02_23_Answer = Question_02_23_Answer;
            Save.Question_02_24_Answer = Question_02_24_Answer;
            Save.Question_02_25_Answer = Question_02_25_Answer;
            Save.Question_02_26_Answer = Question_02_26_Answer;
            Save.Question_02_27_Answer = Question_02_27_Answer;
            Save.Question_02_28_Answer = Question_02_28_Answer;
            Save.Question_02_29_Answer = Question_02_29_Answer;
            Save.Question_02_30_Answer = Question_02_30_Answer;
            Save.Question_03_01_Answer = Question_03_01_Answer;
            Save.Question_03_02_Answer = Question_03_02_Answer;
            Save.Question_03_03_Answer = Question_03_03_Answer;
            Save.Question_03_04_Answer = Question_03_04_Answer;
            Save.Question_03_05_Answer = Question_03_05_Answer;
            Save.Question_03_06_Answer = Question_03_06_Answer;
            Save.Question_03_07_Answer = Question_03_07_Answer;
            Save.Question_03_08_Answer = Question_03_08_Answer;
            Save.Question_03_09_Answer = Question_03_09_Answer;
            Save.Question_03_10_Answer = Question_03_10_Answer;
            Save.Question_03_11_Answer = Question_03_11_Answer;
            Save.Question_03_12_Answer = Question_03_12_Answer;
            Save.Question_03_13_Answer = Question_03_13_Answer;
            Save.Question_03_14_Answer = Question_03_14_Answer;
            Save.Question_03_15_Answer = Question_03_15_Answer;
            Save.Question_03_16_Answer = Question_03_16_Answer;
            Save.Question_03_17_Answer = Question_03_17_Answer;
            Save.Question_03_18_Answer = Question_03_18_Answer;
            Save.Question_03_19_Answer = Question_03_19_Answer;
            Save.Question_03_20_Answer = Question_03_20_Answer;
            Save.Question_03_21_Answer = Question_03_21_Answer;
            Save.Question_03_22_Answer = Question_03_22_Answer;
            Save.Question_03_23_Answer = Question_03_23_Answer;
            Save.Question_03_24_Answer = Question_03_24_Answer;
            Save.Question_03_25_Answer = Question_03_25_Answer;
            Save.Question_03_26_Answer = Question_03_26_Answer;
            Save.Question_03_27_Answer = Question_03_27_Answer;
            Save.Question_03_28_Answer = Question_03_28_Answer;
            Save.Question_03_29_Answer = Question_03_29_Answer;
            Save.Question_03_30_Answer = Question_03_30_Answer;
            //Save_Definitionの内容をxml形式で保存
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Save_Definition));
            StreamWriter sw = new StreamWriter(Path + "/Resources/Save/Save_99_Temp.dat", false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, Save);
            sw.Close();
            using (var eifs = new FileStream(Path + "/Resources/Save/Save_99_Temp.dat", FileMode.Open, FileAccess.Read))
            {
                using (var eofs = new FileStream(Path + "/Resources/Save/Save_99.dat", FileMode.Create, FileAccess.Write))
                {
                    FileEncode.FileEncryptor.Encrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                }
            }
            File.Delete(Path + "/Resources/Save/Save_99_Temp.dat");
            //現在の画面をキャプチャしてpngで保存
            Bitmap bmp = new Bitmap(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(new System.Drawing.Point(0, 0), new System.Drawing.Point(0, 0), bmp.Size);
            g.Dispose();
            bmp.Save(Path + "/Resources/Save/Save_Picture.dat", System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();
            //セーブウィンドウを表示
            Save_Window.Window_Show();
            Save_Window.Visibility = Visibility.Visible;
            Save_Window.IsClosing = true;
            Save_Window.Opacity = 0;
            while (true)
            {
                if (Save_Window.Opacity >= 1)
                {
                    Save_Show_Or_Close();
                    Save_Window.IsClosing = false;
                    break;
                }
                Save_Window.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
        }
        async void Save_Show_Or_Close()
        {
            //セーブウィンドウが閉じるまでループ(閉じたら仮で作成したセーブファイルを削除)
            while (true)
            {
                if (Save_Window.Opacity <= 0)
                {
                    IsSave_Show = false;
                    File.Delete(Path + "/Resources/Save/Save_Picture.dat");
                    File.Delete(Path + "/Resources/Save/Save_99.dat");
                    IsOtherWindowShowed = false;
                    Window_Show_Name = "";
                    break;
                }
                await Task.Delay(100);
            }
        }
        async void BGM_Start()
        {
            //BGMを再生
            BGM_Close = false;
            //BGM_Stoppedが終了するまで待機
            await Task.Delay(1000);
            Random r = new Random();
            int r2 = r.Next(1, 8);
            int r3 = r.Next(1, 5);
            BGM.controls.stop();
            if (IsGrade_1_2_3_Clear == true)
            {
                BGM.URL = Path + "/Resources/BGM/Story_03.mp3";
            }
            else if (Difficult_Question_Mode == true)
            {
                if (BGM_Number_Now == r3)
                {
                    BGM_Start();
                    return;
                }
                BGM_Number_Now = r3;
                BGM.URL = Path + "/Resources/BGM/Difficult_0" + r3 + ".mp3";
            }
            else
            {
                BGM.URL = Path + "/Resources/BGM/" + r2 + ".mp3";
            }
            BGM.controls.play();
            BGM_Stopped();
        }
        async void BGM_Stopped()
        {
            //BGMが終わったらBGMのファイルを更新して再度再生させる
            //BGM_Closeがtrueだった場合BGMのループを停止させる(現在再生されているBGMは再生を続ける)
            while (BGM_Close == false)
            {
                if (BGM.playState == WMPPlayState.wmppsPaused || BGM.playState == WMPPlayState.wmppsStopped)
                {
                    BGM_Start();
                    break;
                }
                await Task.Delay(1000);
            }
        }
        private void Load_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Load_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save/Load_01.png"));
        }
        private void Load_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Load_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save/Load_00.png"));
        }
        private async void Load_Image_MouseDown(object sender, MouseEventArgs e)
        {
            //ロードウィンドウを表示
            IsOtherWindowShowed = true;
            Window_Show_Name = "ロード";
            IsSave_Show = true;
            Load_Window.Visibility = Visibility.Visible;
            Load_Window.Window_Show();
            Load_Window.IsClosing = true;
            Load_Window.Opacity = 0;
            while (true)
            {
                if (Load_Window.Opacity >= 1)
                {
                    Load_Window.IsClosing = false;
                    Load_Window_IsClose();
                    Load_Start();
                    break;
                }
                Load_Window.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
        }
        async void Load_Window_IsClose()
        {
            //ロードウィンドウを閉じるまでループ
            while (true)
            {
                if (Load_Window.Opacity <= 0)
                {
                    IsSave_Show = false;
                    IsOtherWindowShowed = false;
                    Window_Show_Name = "";
                    break;
                }
                await Task.Delay(100);
            }
        }
        async void Load_Start()
        {
            //ロードウィンドウにてセーブデータがロードされたら現在のウィンドウを閉じて新たにMath_01のウィンドウを開く
            while (true)
            {
                if (Load_Window.Load_Click_True == true)
                {
                    Start();
                    IsSave_Show = true;
                    break;
                }
                else if (Load_Window.Visibility == Visibility.Hidden)
                {
                    break;
                }
                await Task.Delay(500);
            }
        }
        async void Start()
        {
            //ウィンドウを閉じて再度開く(ロード専用)
            IsOtherWindowShowed = true;
            White_Image.Visibility = Visibility.Visible;
            White_Image.Opacity = 0;
            while (true)
            {
                if (White_Image.Opacity >= 1)
                {
                    Math_01 f = new Math_01();
                    f.Show();
                    BGM_Close = true;
                    BGM.controls.stop();
                    Close();
                    break;
                }
                White_Image.Opacity += 0.01;
                await Task.Delay(1000 / 30);
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Mouse_Click_Effect();
        }
        async void Mouse_Click_Effect()
        {
            if (Configs_Window.Click_Explosion == true)
            {
                //クリックした位置にエフェクトの画像を表示させる(1920x1080のディスプレイでないと位置がおかしくなるためConfigs_Windowで制限している)
                double Mouse_X = System.Windows.Forms.Cursor.Position.X;
                int Mouse_Y = System.Windows.Forms.Cursor.Position.Y;
                System.Windows.Point p = new System.Windows.Point(Mouse_X, Mouse_Y);
                System.Windows.Point cp = PointToScreen(p);
                Mouse_Effect_Image.Margin = new Thickness(-2560 + cp.X * 1.333333, p.Y * 0.645 - 15, 0, 0);
                int Number = 1;
                while (true)
                {
                    if (File.Exists(Path + "/Resources/Motion/Click/" + Configs_Window.Click_Explosion_Image_Name + "/" + Number + ".png"))
                    {
                        Mouse_Effect_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Click/" + Configs_Window.Click_Explosion_Image_Name + "/" + Number + ".png"));
                        Number += 1;
                    }
                    else
                    {
                        Mouse_Effect_Image.Source = null;
                        break;
                    }
                    await Task.Delay(1000 / 30);
                }
            }
        }
        private void Log_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Log_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Log_02.png"));
        }
        private void Log_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Log_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Log_01.png"));
        }
        private async void Log_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //バックログを開く
            IsOtherWindowShowed = true;
            Window_Show_Name = "ログ";
            BackLog_Image.Opacity = 0;
            BackLog_Image.Visibility = Visibility.Visible;
            BackLog_L.Opacity = 0;
            BackLog_L.Visibility = Visibility.Visible;
            BackLog_Close_Image.Opacity = 0;
            BackLog_Close_Image.Visibility = Visibility.Visible;
            var index = BackLog_L.Items.Count - 1;
            var item = BackLog_L.Items.GetItemAt(index);
            BackLog_L.ScrollIntoView(item);
            while (true)
            {
                if (BackLog_Close_Image.Opacity >= 1)
                {
                    break;
                }
                BackLog_Image.Opacity += 0.05;
                BackLog_L.Opacity += 0.05;
                BackLog_Close_Image.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
        }
        private void BackLog_Close_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            BackLog_Close_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_02.png"));
        }
        private void BackLog_Close_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            BackLog_Close_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_01.png"));
        }
        private async void BackLog_Close_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //バックログを閉じる
            if (BackLog_Close_Image.Opacity >= 1)
            {
                while (true)
                {
                    if (BackLog_Close_Image.Opacity <= 0)
                    {
                        BackLog_Image.Visibility = Visibility.Hidden;
                        BackLog_L.Visibility = Visibility.Hidden;
                        BackLog_Close_Image.Visibility = Visibility.Hidden;
                        IsOtherWindowShowed = false;
                        Window_Show_Name = "";
                        break;
                    }
                    BackLog_Image.Opacity -= 0.05;
                    BackLog_L.Opacity -= 0.05;
                    BackLog_Close_Image.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
            }
        }
        async void Timer_Start()
        {
            //ストップウォッチを開始(問題が終了した地点で停止)
            while (Clear == false)
            {
                Timer_Seconds++;
                Timer_All++;
                if (Timer_Seconds >= 60)
                {
                    Timer_Minutes++;
                    Timer_Seconds = 0;
                }
                if (Timer_Minutes >= 60)
                {
                    Timer_Hour++;
                    Timer_Minutes = 0;
                }
                await Task.Delay(1000);
            }
        }
    }
}