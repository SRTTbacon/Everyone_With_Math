using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using WMPLib;

namespace Everyone_With_Math
{
    public partial class Configs_Class : UserControl
    {
        //定義
        WindowsMediaPlayer SE = new WindowsMediaPlayer();
        string Path = Directory.GetCurrentDirectory();
        public bool Change = false;
        public bool IsClosing = false;
        public bool FullScreen = true;
        public bool Click_Explosion = false;
        public string Click_Explosion_Image_Name = "";
        //テキストウィンドウの色リスト
        string[] Color_List = { "青", "ピンク", "緑", "黒", "黄", "赤", "橙", "白", "無" };
        [DllImport("User32.dll")]
        static extern short GetAsyncKeyState(int vKey);
        public Configs_Class()
        {
            InitializeComponent();
            //画像、リストを配置
            Main_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Configs_Base_01.png"));
            Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_01.png"));
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back.png"));
            Load_Configs();
            Change = false;
            Window_Mode_Setting.Items.Add("フルスクリーンモード");
            Window_Mode_Setting.Items.Add("ウィンドウモード");
            Window_Color_L.Items.Add("カラー:青");
            Window_Color_L.Items.Add("カラー:ピンク");
            Window_Color_L.Items.Add("カラー:緑");
            Window_Color_L.Items.Add("カラー:黒");
            Window_Color_L.Items.Add("カラー:黄");
            Window_Color_L.Items.Add("カラー:赤");
            Window_Color_L.Items.Add("カラー:橙");
            Window_Color_L.Items.Add("カラー:白");
            Window_Color_L.Items.Add("カラー:無");
            Click_Explosion_L.Items.Add("エフェクト:円");
            Click_Explosion_L.Items.Add("エフェクト:炎1");
            Click_Explosion_L.Items.Add("エフェクト:炎2");
            Click_Explosion_L.Items.Add("エフェクト:水");
            Click_Explosion_L.Items.Add("エフェクト:風");
            Click_Explosion_L.Items.Add("エフェクト:雷");
            Click_Explosion_L.Items.Add("エフェクト:氷");
            //設定を取得、反映
            XDocument xml2 = XDocument.Load(Path + "/Resources/Save/Configs.dat");
            XElement item2 = xml2.Element("Configs_Save");
            XElement item_01 = item2.Element("FullScreenMode");
            XElement item_02 = item2.Element("Window_Color");
            XElement item_03 = item2.Element("Click_Explosion_Image_Name");
            if (int.Parse(item_02.Value) == 0)
            {
                //0だった場合クラッシュしてしまうため-1をしない
                Window_Color_L.SelectedIndex = int.Parse(item_02.Value);
            }
            else
            {
                Window_Color_L.SelectedIndex = int.Parse(item_02.Value) - 1;
            }
            if (bool.Parse(item_01.Value) == false)
            {
                Window_Mode_Setting.SelectedIndex = 1;
            }
            else
            {
                Window_Mode_Setting.SelectedIndex = 0;
            }
            Click_Explosion_Image_Name = item_03.Value;
        }
        public void Load_Configs()
        {
            //設定画面が開かれるたびに設定を更新
            if (File.Exists(Path + "/Resources/Save/Configs.dat"))
            {
                try
                {
                    XDocument xml = XDocument.Load(Path + "/Resources/Save/Configs.dat");
                    XElement item = xml.Element("Configs_Save");
                    XElement item_00 = item.Element("SE_Volume");
                    XElement item_01 = item.Element("Click_Explosion");
                    XElement item_02 = item.Element("Click_Explosion_Image_Name");
                    SE.settings.volume = int.Parse(item_00.Value);
                    SE_Volume_S.Value = int.Parse(item_00.Value);
                    BGM_Volume_S.Value = int.Parse(item.Element("BGM_Volume").Value);
                    Text_Speed_S.Value = int.Parse(item.Element("Text_Speed").Value);
                    Click_Explosion = bool.Parse(item_01.Value);
                    if (Click_Explosion == true)
                    {
                        Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_03.png"));
                        Click_Explosion_L.Visibility = System.Windows.Visibility.Visible;
                        Click_Explosion_L.SelectedItem = "エフェクト:" + item_02.Value;
                    }
                    else
                    {
                        Click_Explosion_L.Visibility = System.Windows.Visibility.Hidden;
                    }
                }
                catch
                {
                    System.Windows.MessageBox.Show("正しく設定情報が読み込めませんでした。");
                    Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_01.png"));
                    Click_Explosion_L.Visibility = System.Windows.Visibility.Hidden;
                }
            }
            else
            {
                SE.settings.volume = 25;
            }
        }
        private void Back_B_MouseEnter(object sender, MouseEventArgs e)
        {
            Text_T.Text = "前の画面に戻ります";
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back_01.png"));
        }
        private void Back_B_MouseLeave(object sender, MouseEventArgs e)
        {
            Text_T.Text = "";
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back.png"));
        }
        private void Back_B_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close_Key();
        }
        void SE_Play(string File)
        {
            SE.controls.stop();
            SE.URL = File;
            SE.controls.play();
        }
        private void SE_Volume_S_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Text_T.Text = "SEの音量を変更します。";
        }
        private void SE_Volume_S_MouseLeave(object sender, MouseEventArgs e)
        {
            Text_T.Text = "";
        }
        private void SE_Volume_S_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            SE_Volume_T.Text = "SE音量:" + (int)SE_Volume_S.Value;
            SE.settings.volume = (int)SE_Volume_S.Value;
        }
        private void BGM_Volume_S_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Text_T.Text = "BGMの音量を変更します。";
        }
        private void BGM_Volume_S_MouseLeave(object sender, MouseEventArgs e)
        {
            Text_T.Text = "";
        }
        private void BGM_Volume_S_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            BGM_Volume_T.Text = "BGM音量:" + (int)BGM_Volume_S.Value;
        }
        private void Text_Speed_S_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Text_T.Text = "テキストの表示速度を変更します。";
        }
        private void Text_Speed_S_MouseLeave(object sender, MouseEventArgs e)
        {
            Text_T.Text = "";
        }
        private void Text_Speed_S_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            Text_Speed_T.Text = "テキスト速度:" + (int)Text_Speed_S.Value;
        }
        async void Close_Key()
        {
            //現在の設定をファイルに保存して閉じる(xml形式、設定ファイルは変更されてもいいので暗号化はしない)
            if (IsClosing == false)
            {
                IsClosing = true;
                StreamWriter s = File.CreateText(Path + "/Resources/Save/Configs.dat");
                s.Close();
                Configs_Save obj = new Configs_Save
                {
                    SE_Volume = (int)SE_Volume_S.Value,
                    BGM_Volume = (int)BGM_Volume_S.Value,
                    Auto_Speed = 30,
                    Text_Speed = (int)Text_Speed_S.Value,
                    FullScreenMode = FullScreen,
                    Window_Color = Window_Color_L.SelectedIndex + 1,
                    Click_Explosion = Click_Explosion,
                    Click_Explosion_Image_Name = Click_Explosion_Image_Name
                };
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Configs_Save));
                StreamWriter sw = new StreamWriter(Path + "/Resources/Save/Configs.dat", false, new System.Text.UTF8Encoding(false));
                serializer.Serialize(sw, obj);
                sw.Close();
                Opacity = 1;
                while (Opacity > 0)
                {
                    Opacity -= 0.05;
                    await Task.Delay(30);
                }
                Change = false;
                Visibility = System.Windows.Visibility.Hidden;
                IsClosing = false;
            }
        }
        private void Window_Mode_Setting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Window_Mode_Setting.SelectedItem.ToString() == "フルスクリーンモード")
            {
                FullScreen = true;
            }
            else if (Window_Mode_Setting.SelectedItem.ToString() == "ウィンドウモード")
            {
                FullScreen = false;
            }
        }
        private void Window_Mode_Setting_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Text_T.Text = "ウィンドウスタイルを変更します。";
        }
        private void Window_Mode_Setting_MouseLeave(object sender, MouseEventArgs e)
        {
            Text_T.Text = "";
        }
        private void Window_Color_L_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Text_T.Text = "テキストウィンドウの色を変更します。";
        }
        private void Window_Color_L_MouseLeave(object sender, MouseEventArgs e)
        {
            Text_T.Text = "";
        }
        private void Window_Color_L_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Window_Color_T.Text = "ウィンドウの色:" + Color_List[Window_Color_L.SelectedIndex];
        }
        private void Click_Explosion_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Text_T.Text = "クリック時にエフェクトを発生させます。";
            if (Click_Explosion == false)
            {
                Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_02.png"));
            }
            else
            {
                Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_04.png"));
            }
        }
        private void Click_Explosion_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Text_T.Text = "";
            if (Click_Explosion == false)
            {
                Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_01.png"));
            }
            else
            {
                Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_03.png"));
            }
        }
        private void Click_Explosion_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Click_Explosion == false)
            {
                //エフェクト機能が有効化されていない場合条件を満たしていれば有効にする
                //ほかの画面の大きさを考えると頭がおかしくなるので1920x1080の画面のみ対応
                System.Drawing.Point p = new System.Drawing.Point();
                int h = System.Windows.Forms.Screen.GetBounds(p).Height;
                int w = System.Windows.Forms.Screen.GetBounds(p).Width;
                if (FullScreen == false)
                {
                    //フルスクリーンでなければ処理を終了
                    System.Windows.MessageBox.Show("この機能を有効にするにはフルスクリーンモードにする必要があります。");
                    return;
                }
                if (w == 1920 && h == 1080)
                {
                    Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_03.png"));
                    Click_Explosion = true;
                    Click_Explosion_L.Visibility = System.Windows.Visibility.Visible;
                }
                else
                {
                    //画面の解像度が1920x1080でなければ表示
                    System.Windows.MessageBox.Show("この機能は画面の解像度が1920x1080でのみ有効化できます。");
                }
            }
            else
            {
                //エフェクト機能が有効化されていたら無効にする
                Click_Explosion_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Check_01.png"));
                Click_Explosion = false;
                Click_Explosion_L.Visibility = System.Windows.Visibility.Hidden;
            }
        }
        private void Click_Explosion_L_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Text_T.Text = "クリック時のエフェクトを変更します。";
        }
        private void Click_Explosion_L_MouseLeave(object sender, MouseEventArgs e)
        {
            Text_T.Text = "";
        }
        private void Click_Explosion_L_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Click_Explosion_Image_Name = Click_Explosion_L.SelectedItem.ToString().Replace("エフェクト:", "");
        }
    }
}