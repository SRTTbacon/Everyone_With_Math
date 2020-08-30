using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using WMPLib;

namespace Everyone_With_Math
{
    public partial class Story_Window : UserControl
    {
        //ストーリーのみを実行させる
        string Path = Directory.GetCurrentDirectory();
        WindowsMediaPlayer SE = new WindowsMediaPlayer();
        public bool IsClosing = false;
        public bool IsClosed = false;
        bool IsDebug = false;
        public Story_Window()
        {
            InitializeComponent();
            Main_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Story_Base_01.png"));
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back.png"));
            SE.URL = Path + "/Resources/SE/SE_04.wav";
            XDocument xml = XDocument.Load(Path + "/Resources/Save/Configs.dat");
            XElement item = xml.Element("Configs_Save");
            XElement item_00 = item.Element("SE_Volume");
            SE.settings.volume = int.Parse(item_00.Value);
            SE.controls.stop();
            Text_T.Text = "選択できるストーリーが存在しません。\n各学年をクリアすると追加されます。";
#if DEBUG
            IsDebug = true;
#endif
        }
        public void Window_Show()
        {
            //一度クリアした学年のみ表示(どの学年もクリアしていない場合テキストを表示)
            bool Story_01_Clear = false, Story_02_Clear = false, Story_03_Clear = false;
            Story_01_B.Visibility = System.Windows.Visibility.Hidden;
            Story_02_B.Visibility = System.Windows.Visibility.Hidden;
            Story_03_B.Visibility = System.Windows.Visibility.Hidden;
            Story_04_B.Visibility = System.Windows.Visibility.Hidden;
            Text_T.Visibility = System.Windows.Visibility.Hidden;
            if (File.Exists(Path + "/Resources/Save/Grade_Clear.dat"))
            {
                StreamReader str = new StreamReader(Path + "/Resources/Save/Grade_Clear.dat");
                string Moji = str.ReadToEnd();
                str.Close();
                if (Moji.Contains("Created_By_SRTTbacon_And_Gumipoteti_Grade_Number_01_Clear_True"))
                {
                    Story_01_B.Visibility = System.Windows.Visibility.Visible;
                    Story_01_Clear = true;
                }
                if (Moji.Contains("Programmed_By_SRTTbacon_Illustration_By_Gumipoteti_Grade_Number_02_Clear_True"))
                {
                    Story_02_B.Visibility = System.Windows.Visibility.Visible;
                    Story_02_Clear = true;
                }
                if (Moji.Contains("SRTTbacon_Like_Math_Gumipoteti_Love_Math_Grade_Number_03_Clear_True"))
                {
                    Story_03_B.Visibility = System.Windows.Visibility.Visible;
                    Story_03_Clear = true;
                }
                if (Story_01_Clear == true && Story_02_Clear == true && Story_03_Clear == true)
                {
                    Story_04_B.Visibility = System.Windows.Visibility.Visible;
                }
                else if (Story_01_Clear == false && Story_02_Clear == false && Story_03_Clear == false)
                {
                    Text_T.Visibility = System.Windows.Visibility.Visible;
                }
                if (IsDebug == true)
                {
                    Story_01_B.Visibility = System.Windows.Visibility.Visible;
                    Story_02_B.Visibility = System.Windows.Visibility.Visible;
                    Story_03_B.Visibility = System.Windows.Visibility.Visible;
                    Story_04_B.Visibility = System.Windows.Visibility.Visible;
                }
            }
            else if (IsDebug == true)
            {
                Story_01_B.Visibility = System.Windows.Visibility.Visible;
                Story_02_B.Visibility = System.Windows.Visibility.Visible;
                Story_03_B.Visibility = System.Windows.Visibility.Visible;
                Story_04_B.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                Text_T.Visibility = System.Windows.Visibility.Visible;
            }
        }
        void SE_Enter(object sender, MouseEventArgs e)
        {
            SE.controls.stop();
            SE.controls.play();
        }
        void Back_B_MouseEnter(object sender, MouseEventArgs e)
        {
            SE.controls.stop();
            SE.controls.play();
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back_01.png"));
        }
        void Back_B_MouseLeave(object sender, MouseEventArgs e)
        {
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back.png"));
        }
        async void Close_Key()
        {
            //ウィンドウを閉じる
            if (IsClosing == false)
            {
                IsClosing = true;
                while (true)
                {
                    if (Opacity <= 0)
                    {
                        IsClosing = false;
                        Visibility = System.Windows.Visibility.Hidden;
                        IsClosed = true;
                        break;
                    }
                    Opacity -= 0.05;
                    await Task.Delay(1000 / 30);
                }
            }
        }
        private void Back_B_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close_Key();
        }
        private void Story_01_B_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Load_Story_Start(1);
        }
        private void Story_02_B_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Load_Story_Start(2);
        }
        private void Story_03_B_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Load_Story_Start(3);
        }
        private void Story_04_B_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Load_Story_Start(4);
        }
        void Load_Story_Start(int Story_Number)
        {
            //Math_01に伝えるため一時的にファイルを作成
            StreamWriter stw = File.CreateText(Path + "/Resources/Save/Load_Story.dat");
            stw.WriteLine(Story_Number);
            stw.Close();
            Close_Key();
        }
    }
}