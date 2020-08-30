using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using WMPLib;

namespace Everyone_With_Math
{
    public partial class Home_Window : Window
    {
        string Path = Directory.GetCurrentDirectory();
        bool IsImageClicked = false;
        bool IsEffect_Show = false;
        bool Dialog_IsShowed = false;
        bool IsOtherWindowShowed = false;
        //画面の解像度を取得
        static System.Drawing.Point aaa = new System.Drawing.Point();
        readonly int h = System.Windows.Forms.Screen.GetBounds(aaa).Height;
        readonly int w = System.Windows.Forms.Screen.GetBounds(aaa).Width;
        readonly WindowsMediaPlayer SE = new WindowsMediaPlayer();
        readonly WindowsMediaPlayer SE_01 = new WindowsMediaPlayer();
        readonly WindowsMediaPlayer BGM = new WindowsMediaPlayer();
        bool IsDebug = false;
        string Window_Show_Name = "";
        int Number_Of_Times = 0;
        bool Difficult_Question_Mode = false;
        bool Window_Close = false;
        public Home_Window()
        {
            /*暗号化されたファイルを複合化するコード
            using (var eifs = new FileStream(ファイル場所(元), FileMode.Open, FileAccess.Read))
            {
                using (var eofs = new FileStream(ファイル場所(新), FileMode.Create, FileAccess.Write))
                {
                    FileEncode_SRTTbacon.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                    StreamReader str4 = new StreamReader(ファイル場所(新));
                    string型 = str4.ReadToEnd();
                    str4.Close();
                    File.Delete(ファイル場所(新));
                }
            }
            ファイルをAESで暗号化するコード
            using (var eifs = new FileStream(ファイル場所(元), FileMode.Open, FileAccess.Read))
            {
                using (var eofs = new FileStream(ファイル場所(新), FileMode.Create, FileAccess.Write))
                {
                    FileEncode_SRTTbacon.FileEncryptor.Encrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                    File.Delete(ファイル場所(元));
                }
            }*/
            //起動時の処理
            if (!File.Exists(Path + "/Resources/Save/Configs.dat"))
            {
                Configs_Start_Save();
            }
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
            //フォルダのアクセス権がなければ強制終了させる(またはフォルダ自体が存在しない場合)
            if (Directory.Exists(Path + "/Resources"))
            {
                //フォルダのパスが200文字以上だった場合ファイルを作成または削除ができないため起動できないように(最大は248文字だが、Pathの下のフォルダを入れると超える可能性があるため200文字を制限とする)
                if (Path.Length >= 200)
                {
                    MessageBox.Show("フォルダパスが長すぎます。パスの文字数が200以下でなければいけません。\nソフトは強制終了されます。");
                    Close();
                }
                try
                {
                    StreamWriter stw = File.CreateText(Path + "/Resources/Test.dat");
                    stw.WriteLine("Created_By_SRTTbacon_And_Gumipoteti");
                    stw.Close();
                    File.Delete(Path + "/Resources/Test.dat");
                }
                catch
                {
                    MessageBox.Show("フォルダにアクセス権があるか確認してください。\n現在のフォルダ:" + Path + "\nソフトは強制終了されます。");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("リソースフォルダが存在しません。ソフトは強制終了されます。");
                Close();
            }
            if (File.Exists(Path + "/Resources/Save/Configs.dat"))
            {
                try
                {
                    XDocument xml = XDocument.Load(Path + "/Resources/Save/Configs.dat");
                    XElement item = xml.Element("Configs_Save");
                    XElement item_00 = item.Element("SE_Volume");
                    XElement item_01 = item.Element("BGM_Volume");
                    XElement item_02 = item.Element("Text_Speed");
                    XElement item_03 = item.Element("FullScreenMode");
                    XElement item_04 = item.Element("Window_Color");
                    XElement item_05 = item.Element("Click_Explosion");
                    SE.settings.volume = int.Parse(item_00.Value);
                    SE_01.settings.volume = int.Parse(item_00.Value);
                    BGM.settings.volume = int.Parse(item_01.Value);
                    Configs_Window.SE_Volume_S.Value = int.Parse(item_00.Value);
                    Configs_Window.BGM_Volume_S.Value = int.Parse(item_01.Value);
                    Configs_Window.Text_Speed_S.Value = int.Parse(item_02.Value);
                    Configs_Window.Click_Explosion = bool.Parse(item_05.Value);
                    if (bool.Parse(item_05.Value) == true)
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
                    if (bool.Parse(item_03.Value) == false)
                    {
                        //フルスクリーンでない場合
                        WindowState = WindowState.Normal;
                        int h = System.Windows.Forms.Screen.GetBounds(aaa).Height;
                        int w = System.Windows.Forms.Screen.GetBounds(aaa).Width;
                        Width = w * 0.9;
                        Height = h * 0.9;
                        Left = w * 0.05;
                        Top = h * 0.025;
                    }
                }
                catch
                {
                    //エラーが出た場合新しく設定ファイルを作成
                    MessageBox.Show("正常に設定が読み込めなかったため設定を初期化しました。すみません！！！");
                    Configs_Start_Save();
                }
            }
            else
            {
                Configs_Start_Save();
            }
            //リソースフォルダがない場合メッセージを表示させて強制終了する
            //デバッグの場合はセーブデータを変更できるツールを表示できるように(Dropboxからダウンロードされる)
            if (IsDebug == true)
            {
                Save_Change_Tool_Download_B.Visibility = Visibility.Visible;
            }
            else
            {
                Save_Change_Tool_Download_B.Visibility = Visibility.Hidden;
            }
            //Pathはexeファイルが起動しているディレクトリ
            try
            {
                Main_Image_01.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Title_Main.png"));
                Dialog_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Dialog_01.png"));
                Dialog_No_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/No.png"));
                Dialog_Yes_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Yes.png"));
                Dialog_Message_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Message_01.png"));
                Dialog_Effect_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Spark/1.png"));
                White_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/White.png"));
            }
            catch
            {
                MessageBox.Show("リソースファイルが存在しません。もう一度ダウンロードすることをお勧めします。\nソフトは強制終了します。");
                Close();
            }
            Window_Show();
            Title_Animation();
            //設定ファイルがあれば反映させてなければ作成させる
            if (IsDebug == true)
            {
                //デバッグ状態だった場合表示
                Start_Grade_01_B.Visibility = Visibility.Visible;
                Start_Grade_02_B.Visibility = Visibility.Visible;
                Start_Grade_03_B.Visibility = Visibility.Visible;
            }
            else if (File.Exists(Path + "/Resources/Save/Grade_Questions.dat"))
            {
                //ある学年をクリアしていたら永遠に特定の問題をプレイできるように(ボタンを追加させる)
                StreamReader str = new StreamReader(Path + "/Resources/Save/Grade_Questions.dat");
                string Read = str.ReadToEnd();
                str.Close();
                if (Read.Contains("IsGrade_01_Questions_Show_True"))
                {
                    Start_Grade_01_B.Visibility = Visibility.Visible;
                }
                else
                {
                    Start_Grade_01_B.Visibility = Visibility.Hidden;
                }
                if (Read.Contains("IsGrade_02_Thirty_Questions_Show_You_Are_Answered_True"))
                {
                    Start_Grade_02_B.Visibility = Visibility.Visible;
                }
                else
                {
                    Start_Grade_02_B.Visibility = Visibility.Hidden;
                }
                if (Read.Contains("IsGrade_03_Difficult_Questions_Created_By_Gumipoteti_True"))
                {
                    Start_Grade_03_B.Visibility = Visibility.Visible;
                }
                else
                {
                    Start_Grade_03_B.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                Start_Grade_01_B.Visibility = Visibility.Hidden;
                Start_Grade_02_B.Visibility = Visibility.Hidden;
                Start_Grade_03_B.Visibility = Visibility.Hidden;
            }
            if (File.Exists(Path + "/Resources/Save/Number_Of_Times.dat"))
            {
                using (var eifs = new FileStream(Path + "/Resources/Save/Number_Of_Times.dat", FileMode.Open, FileAccess.Read))
                {
                    using (var eofs = new FileStream(Path + "/Resources/Save/Number_Of_Times_Temp.dat", FileMode.Create, FileAccess.Write))
                    {
                        FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                        StreamReader str4 = new StreamReader(Path + "/Resources/Save/Number_Of_Times_Temp.dat");
                        Number_Of_Times = int.Parse(str4.ReadToEnd());
                        str4.Close();
                        File.Delete(Path + "/Resources/Save/Number_Of_Times_Temp.dat");
                    }
                }
                if (Number_Of_Times <= 0 && IsDebug == true)
                {
                    Number_Of_Times = 5;
                }
            }
            else if (File.Exists(Path + "/Resources/BG/Story/Temp.dat"))
            {
                if (IsDebug == true)
                {
                    Number_Of_Times = 5;
                }
                else
                {
                    Number_Of_Times = 0;
                }
            }
            else
            {
                StreamWriter stw = File.CreateText(Path + "/Resources/Temp.dat");
                stw.WriteLine(5);
                stw.Close();
                using (var eifs = new FileStream(Path + "/Resources/Temp.dat", FileMode.Open, FileAccess.Read))
                {
                    using (var eofs = new FileStream(Path + "/Resources/Save/Number_Of_Times.dat", FileMode.Create, FileAccess.Write))
                    {
                        FileEncode.FileEncryptor.Encrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                    }
                }
                File.Delete(Path + "/Resources/Temp.dat");
                StreamWriter stw2 = File.CreateText(Path + "/Resources/BG/Story/Temp.dat");
                stw2.WriteLine("Don't delete this file, Please");
                stw2.Close();
                Number_Of_Times = 5;
            }
            File.Delete(Path + "/Resources/Save/Load_Story.dat");
            Rain_SE_Play();
        }
        async void Window_Show()
        {
            //フェードインしながらウィンドウを表示
            Opacity = 0;
            while (Opacity < 1)
            {
                Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
        }
        void Configs_Start_Save()
        {
            //設定ファイルを作成(xml形式)
            //設定ファイルはbase64で暗号化しない
            StreamWriter s = File.CreateText(Path + "/Resources/Save/Configs.dat");
            s.Close();
            Configs_Save obj = new Configs_Save
            {
                SE_Volume = 25,
                BGM_Volume = 25,
                Auto_Speed = 30,
                Text_Speed = 30,
                FullScreenMode = true,
                Window_Color = 1,
                Click_Explosion = false,
                Click_Explosion_Image_Name = "円"
            };
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Configs_Save));
            StreamWriter sw = new StreamWriter(Path + "/Resources/Save/Configs.dat", false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, obj);
            sw.Close();
            SE.settings.volume = 25;
            SE_01.settings.volume = 25;
            BGM.settings.volume = 25;
        }
        async void Rain_SE_Play()
        {
            //雨の効果音を再生(止まっていたら再度再生)
            BGM.controls.stop();
            BGM.URL = Path + "/Resources/SE/SE_05.mp3";
            BGM.controls.play();
            while (Window_Close == false)
            {
                if (BGM.playState == WMPPlayState.wmppsPaused || BGM.playState == WMPPlayState.wmppsStopped)
                {
                    Rain_SE_Play();
                    break;
                }
                await Task.Delay(500);
            }
        }
        async void Title_Animation()
        {
            //エフェクトをつけたpngファイルを読み込み表示させる
            //int Title_01 = 1:
            int Number_01 = 1;
            //int Number_02 = 1;
            while (true)
            {
                //CPU使用率が大きかったため廃止(雨に変更)
                /*if (Number_02 <= 300)
                {
                    Animation_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Title/" + Number_02 + ".png"));
                    Number_02 += 1;
                }
                else
                {
                    Number_02 = 1;
                }*/
                if (Number_01 <= 151)
                {
                    Animation_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Rain/" + Number_01 + ".png"));
                    Number_01 += 1;
                }
                else
                {
                    Number_01 = 1;
                }
                await Task.Delay(1000 / 30);
            }
        }
        private void Exit_B_Click(object sender, RoutedEventArgs e)
        {
            //終了ボタンが押されたらダイアログを表示
            Mouse_Click_Effect();
            Exit_Dialog_Show();
        }
        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            //Escapeキーが押されたら終了ボタンと同じ処理をする
            if (e.Key == System.Windows.Input.Key.Escape)
            {
                Exit_Dialog_Show();
            }
        }
        async void Exit_Dialog_Show()
        {
            if (IsImageClicked == false && Dialog_IsShowed == false && IsOtherWindowShowed == false)
            {
                //終了ダイアログを表示させる
                SE_01_Play(Path + "/Resources/SE/SE_03.wav");
                Curser_Location();
                IsImageClicked = true;
                IsEffect_Show = true;
                Dialog_IsShowed = true;
                Dialog_Effect_Animation();
                Dialog_Image.Visibility = Visibility.Visible;
                Dialog_No_Image.Visibility = Visibility.Visible;
                Dialog_Yes_Image.Visibility = Visibility.Visible;
                Dialog_Message_Image.Visibility = Visibility.Visible;
                Dialog_Effect_Image.Visibility = Visibility.Visible;
                Dialog_Image.Opacity = 0;
                Dialog_Message_Image.Opacity = 0;
                Dialog_Yes_Image.Opacity = 0;
                Dialog_No_Image.Opacity = 0;
                Dialog_Effect_Image.Opacity = 0;
                while (Dialog_Message_Image.Opacity < 1)
                {
                    if (Dialog_Image.Opacity < 0.75)
                    {
                        Dialog_Image.Opacity += 0.05;
                    }
                    if (Dialog_Effect_Image.Opacity < 0.75)
                    {
                        Dialog_Effect_Image.Opacity += 0.05;
                    }
                    Dialog_No_Image.Opacity += 0.05;
                    Dialog_Yes_Image.Opacity += 0.05;
                    Dialog_Message_Image.Opacity += 0.05;
                    await Task.Delay(1000 / 30);
                }
                IsImageClicked = false;
            }
            else if (Dialog_IsShowed == true && Dialog_No_Image.Opacity >= 1)
            {
                SE_Play(Path + "/Resources/SE/SE_01.wav");
                IsImageClicked = true;
                while (Dialog_Message_Image.Opacity > 0)
                {
                    Dialog_Image.Opacity -= 0.05;
                    Dialog_No_Image.Opacity -= 0.05;
                    Dialog_Yes_Image.Opacity -= 0.05;
                    Dialog_Message_Image.Opacity -= 0.05;
                    Dialog_Effect_Image.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
                Dialog_Image.Visibility = Visibility.Hidden;
                Dialog_No_Image.Visibility = Visibility.Hidden;
                Dialog_Yes_Image.Visibility = Visibility.Hidden;
                Dialog_Message_Image.Visibility = Visibility.Hidden;
                Dialog_Effect_Image.Visibility = Visibility.Hidden;
                Dialog_Image.Opacity = 0;
                Dialog_Message_Image.Opacity = 0;
                Dialog_Yes_Image.Opacity = 0;
                Dialog_No_Image.Opacity = 0;
                Dialog_Effect_Image.Opacity = 0;
                IsImageClicked = false;
                IsEffect_Show = false;
                Dialog_IsShowed = false;
            }
            //他のウィンドウが開いていた場合それを閉じる
            else if (Window_Show_Name == "設定")
            {
                if (Configs_Window.Opacity >= 1 && Configs_Window.IsClosing == false)
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
                if (Load_Window.Opacity >= 1 && Load_Window.IsClosing == false)
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
            else if (Window_Show_Name == "Grade")
            {
                if (Grade_01_Window.Opacity >= 1 && Grade_01_Window.IsClosing == false)
                {
                    Grade_01_Window.IsClosing = true;
                    while (true)
                    {
                        if (Grade_01_Window.Opacity <= 0)
                        {
                            Grade_01_Window.IsClosing = false;
                            IsOtherWindowShowed = false;
                            Window_Show_Name = "";
                            Grade_01_Window.Visibility = Visibility.Hidden;
                            break;
                        }
                        Grade_01_Window.Opacity -= 0.05;
                        await Task.Delay(1000 / 30);
                    }
                }
            }
        }
        async void Curser_Location()
        {
            //カーソルの位置をダイアログの中心に移動する
            int Y_Number = h / 2 - System.Windows.Forms.Cursor.Position.Y;
            int X_Number = w / 2 - System.Windows.Forms.Cursor.Position.X;
            int Y_Speed = Y_Number / 10;
            int X_Speed = X_Number / 10;
            int Time = 0;
            //環境が少ないためディスプレイによってはうまく動作しない可能性あり
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
        async void Dialog_Effect_Animation()
        {
            //ダイアログの雷エフェクトのアニメーション設定
            int Number = 1;
            while (IsEffect_Show == true)
            {
                if (Number < 8)
                {
                    Number += 1;
                    Dialog_Effect_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Spark/" + Number + ".png"));
                }
                else
                {
                    Number = 1;
                    Dialog_Effect_Image.Source = new BitmapImage(new Uri(Path + "/Resources/Motion/Spark/1.png"));
                }
                await Task.Delay(1000 / 30);
            }
        }
        private void Dialog_Yes_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Dialog_Yes_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Yes_01.png"));
        }
        private void Dialog_No_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Dialog_No_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/No_01.png"));
        }
        private void Dialog_Yes_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Dialog_Yes_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Yes.png"));
        }
        private void Dialog_No_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Dialog_No_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/No.png"));
        }
        private async void Dialog_No_Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (IsImageClicked == false)
            {
                //いいえが選択された場合ダイアログを非表示に
                if (Difficult_Question_Mode == false)
                {
                    SE_Play(Path + "/Resources/SE/SE_01.wav");
                }
                IsImageClicked = true;
                while (Dialog_Effect_Image.Opacity > 0)
                {
                    Dialog_Image.Opacity -= 0.05;
                    Dialog_No_Image.Opacity -= 0.05;
                    Dialog_Yes_Image.Opacity -= 0.05;
                    Dialog_Message_Image.Opacity -= 0.05;
                    Dialog_Message_Text.Opacity -= 0.05;
                    Dialog_Effect_Image.Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
                Dialog_Image.Visibility = Visibility.Hidden;
                Dialog_No_Image.Visibility = Visibility.Hidden;
                Dialog_Yes_Image.Visibility = Visibility.Hidden;
                Dialog_Message_Image.Visibility = Visibility.Hidden;
                Dialog_Message_Text.Visibility = Visibility.Hidden;
                Dialog_Effect_Image.Visibility = Visibility.Hidden;
                Dialog_Image.Opacity = 0;
                Dialog_Message_Image.Opacity = 0;
                Dialog_Message_Text.Opacity = 0;
                Dialog_Yes_Image.Opacity = 0;
                Dialog_No_Image.Opacity = 0;
                Dialog_Effect_Image.Opacity = 0;
                IsImageClicked = false;
                IsEffect_Show = false;
                Dialog_IsShowed = false;
                Difficult_Question_Mode = false;
            }
        }
        private async void Dialog_Yes_Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (Difficult_Question_Mode == false)
            {
                //はいが選択された場合、白い画像をフェードインさせてソフトを終了させる
                SE_Play(Path + "/Resources/SE/SE_02.wav");
                White_Image.Visibility = Visibility.Visible;
                White_Image.Opacity = 0;
                while (White_Image.Opacity < 1)
                {
                    IsImageClicked = true;
                    White_Image.Opacity += 0.02;
                    await Task.Delay(1000 / 30);
                }
                await Task.Delay(500);
                while (Opacity > 0)
                {
                    Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
                IsImageClicked = false;
                Close();
            }
            else
            {
                int Number = 0;
                using (var eifs = new FileStream(Path + "/Resources/Save/Number_Of_Times.dat", FileMode.Open, FileAccess.Read))
                {
                    using (var eofs = new FileStream(Path + "/Resources/Save/Number_Of_Times_Temp.dat", FileMode.Create, FileAccess.Write))
                    {
                        FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                        StreamReader str4 = new StreamReader(Path + "/Resources/Save/Number_Of_Times_Temp.dat");
                        Number = int.Parse(str4.ReadToEnd());
                        str4.Close();
                    }
                    File.Delete(Path + "/Resources/Save/Number_Of_Times_Temp.dat");
                }
                if (Number != 0 || IsDebug == true)
                {
                    SE_01_Play(Path + "/Resources/SE/SE_09.wav");
                    Window_Close = true;
                    StreamWriter stw2 = File.CreateText(Path + "/Resources/Temp.dat");
                    stw2.WriteLine(Number - 1);
                    stw2.Close();
                    using (var eifs = new FileStream(Path + "/Resources/Temp.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Save/Number_Of_Times.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Encrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                        }
                    }
                    File.Delete(Path + "/Resources/Temp.dat");
                    White_Image.Visibility = Visibility.Visible;
                    White_Image.Opacity = 0;
                    while (White_Image.Opacity < 1)
                    {
                        IsImageClicked = true;
                        BGM.settings.volume -= 2;
                        White_Image.Opacity += 0.02;
                        await Task.Delay(1000 / 30);
                    }
                    BGM.controls.stop();
                    await Task.Delay(1000);
                    StreamWriter stw = File.CreateText(Path + "/Resources/Save/Last_Question_Mode.dat");
                    stw.Close();
                    Class.Math_01 f = new Class.Math_01();
                    f.Show();
                    Close();
                    Difficult_Question_Mode = false;
                }
                else
                {
                    SE_Play(Path + "/Resources/SE/SE_01.wav");
                }
            }
        }
        void SE_Play(string File)
        {
            SE.controls.stop();
            SE.URL = File;
            SE.controls.play();
        }
        void SE_01_Play(string File)
        {
            //途中で止まらせたくないSE用
            //この場合boolはtrueでもfalseでも変わらない
            SE_01.controls.stop();
            SE_01.URL = File;
            SE_01.controls.play();
        }
        private void Exit_B_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
        }
        private void Config_B_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
        }
        private void Start_B_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
        }
        private async void Config_B_Click(object sender, RoutedEventArgs e)
        {
            //設定ウィンドウを表示
            Mouse_Click_Effect();
            Configs_Window.Visibility = Visibility.Visible;
            Configs_Window.Load_Configs();
            Configs_Window.Opacity = 0;
            Configs_Window.IsClosing = true;
            Configs_Window.Change = true;
            IsOtherWindowShowed = true;
            Window_Show_Name = "設定";
            while (Configs_Window.Opacity < 1)
            {
                Configs_Window.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
            Configs_Change();
            Configs_Window.IsClosing = false;
        }
        async void Configs_Change()
        {
            //設定が変更されたら適応させる(設定ウィンドウが閉じられるまで実行)
            while (true)
            {
                if (Configs_Window.Change == true)
                {
                    SE.settings.volume = (int)Configs_Window.SE_Volume_S.Value;
                    SE_01.settings.volume = (int)Configs_Window.SE_Volume_S.Value;
                    BGM.settings.volume = (int)Configs_Window.BGM_Volume_S.Value;
                    if (Configs_Window.FullScreen == true)
                    {
                        WindowState = WindowState.Maximized;
                    }
                    else
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
                }
                else
                {
                    Window_Show_Name = "";
                    IsOtherWindowShowed = false;
                    break;
                }
                await Task.Delay(100);
            }
        }
        private void Start_B_Click(object sender, RoutedEventArgs e)
        {
            //スタート！！！
            Mouse_Click_Effect();
            //ロード時のものと区別できるように(通常スタートは0でロードだと1,2,3のどれか)
            StreamWriter stw = File.CreateText(Path + "/Resources/Save/Load_01.dat");
            stw.WriteLine("0");
            stw.Close();
            Start();
        }
        async void Start()
        {
            //Math_01を表示(数学のメインウィンドウ)
            White_Image.Visibility = Visibility.Visible;
            White_Image.Opacity = 0;
            IsOtherWindowShowed = true;
            Window_Close = true;
            while (true)
            {
                BGM.settings.volume -= 1;
                if (White_Image.Opacity >= 1)
                {
                    Class.Math_01 f = new Class.Math_01();
                    f.Show();
                    BGM.controls.stop();
                    Close();
                    break;
                }
                White_Image.Opacity += 0.02;
                await Task.Delay(1000 / 30);
            }
        }
        private void Load_B_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
        }
        private async void Load_B_Click(object sender, RoutedEventArgs e)
        {
            //ロードウィンドウを表示
            Mouse_Click_Effect();
            Load_Window.Visibility = Visibility.Visible;
            Load_Window.Opacity = 0;
            IsOtherWindowShowed = true;
            Load_Window.IsClosing = true;
            Window_Show_Name = "ロード";
            Load_Start();
            Load_Window.Window_Show();
            while (true)
            {
                if (Load_Window.Opacity >= 1)
                {
                    Load_Window.IsClosing = false;
                    break;
                }
                Load_Window.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
        }
        async void Load_Start()
        {
            //ロードされたらMath_01を実行して閉じる
            while (true)
            {
                if (Load_Window.Load_Click_True == true)
                {
                    Start();
                    IsOtherWindowShowed = false;
                    break;
                }
                else if (Load_Window.Visibility == Visibility.Hidden)
                {
                    Window_Show_Name = "";
                    IsOtherWindowShowed = false;
                    break;
                }
                await Task.Delay(500);
            }
        }
        void Start_Grade_B_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
        }
        private void Start_Grade_01_B_Click(object sender, RoutedEventArgs e)
        {
            Grade_Number_Window_Show(1);
        }
        private void Start_Grade_02_B_Click(object sender, RoutedEventArgs e)
        {
            Grade_Number_Window_Show(2);
        }
        private void Start_Grade_03_B_Click(object sender, RoutedEventArgs e)
        {
            Grade_Number_Window_Show(3);
        }
        async void Grade_Number_Window_Show(int Number)
        {
            Mouse_Click_Effect();
            //指定した問題を永遠にできるようにするウィンドウを表示
            IsOtherWindowShowed = true;
            Grade_01_Window.Opacity = 0;
            Grade_01_Window.IsClosing = true;
            Window_Show_Name = "Grade";
            Grade_01_Window.Window_Start(Number);
            Grade_01_Window.Visibility = Visibility.Visible;
            while (true)
            {
                if (Grade_01_Window.Opacity >= 1)
                {
                    Grade_01_Window.IsClosing = false;
                    break;
                }
                Grade_01_Window.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
            while (Grade_01_Window.Opacity >= 1)
            {
                await Task.Delay(100);
            }
            if (File.Exists(Path + "/Resources/Save/Load_Question_Number.dat"))
            {
                Window_Show_Name = "";
                Start();
            }
            else
            {
                Window_Show_Name = "";
                IsOtherWindowShowed = false;
            }
        }
        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
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
                Point p = new Point(Mouse_X, Mouse_Y);
                Point cp = PointToScreen(p);
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
        private async void Difficult_Question_B_Click(object sender, RoutedEventArgs e)
        {
            SE_01_Play(Path + "/Resources/SE/SE_09.wav");
            Dialog_Message_Text.Text = "このモードは回数制限があります:あと" + Number_Of_Times + "回\n実行しますか？";
            Curser_Location();
            Difficult_Question_Mode = true;
            IsImageClicked = true;
            IsEffect_Show = true;
            Dialog_IsShowed = true;
            Dialog_Effect_Animation();
            Dialog_Image.Visibility = Visibility.Visible;
            Dialog_No_Image.Visibility = Visibility.Visible;
            Dialog_Yes_Image.Visibility = Visibility.Visible;
            Dialog_Message_Text.Visibility = Visibility.Visible;
            Dialog_Effect_Image.Visibility = Visibility.Visible;
            Dialog_Image.Opacity = 0;
            Dialog_Message_Text.Opacity = 0;
            Dialog_Yes_Image.Opacity = 0;
            Dialog_No_Image.Opacity = 0;
            Dialog_Effect_Image.Opacity = 0;
            while (Dialog_Message_Text.Opacity < 1)
            {
                if (Dialog_Image.Opacity < 0.75)
                {
                    Dialog_Image.Opacity += 0.05;
                }
                if (Dialog_Effect_Image.Opacity < 0.75)
                {
                    Dialog_Effect_Image.Opacity += 0.05;
                }
                Dialog_No_Image.Opacity += 0.05;
                Dialog_Yes_Image.Opacity += 0.05;
                Dialog_Message_Text.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
            IsImageClicked = false;
        }
        private void Difficult_Question_B_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
        }
        private async void Story_B_Click(object sender, RoutedEventArgs e)
        {
            Story_Window.Visibility = Visibility.Visible;
            Story_Window.Window_Show();
            Story_Window.Opacity = 0;
            while (Story_Window.Opacity <= 1 && Story_Window.IsClosing == false)
            {
                Story_Window.Opacity += 0.05;
                await Task.Delay(1000 / 30);
            }
            while (Story_Window.IsClosed == false)
            {
                await Task.Delay(100);
            }
            if (File.Exists(Path + "/Resources/Save/Load_Story.dat"))
            {
                Window_Close = true;
                White_Image.Opacity = 0;
                White_Image.Visibility = Visibility.Visible;
                while (White_Image.Opacity <= 1)
                {
                    BGM.settings.volume -= 2;
                    White_Image.Opacity += 0.02;
                    await Task.Delay(1000 / 30);
                }
                BGM.controls.stop();
                Class.Math_01 f = new Class.Math_01();
                f.Show();
                Close();
            }
        }
    }
}
public class Configs_Save
{
    //セーブファイルに保存する内容
    public int SE_Volume;
    public int BGM_Volume;
    public int Text_Speed;
    public int Auto_Speed;
    public bool FullScreenMode;
    public int Window_Color;
    public bool Click_Explosion;
    public string Click_Explosion_Image_Name;
}