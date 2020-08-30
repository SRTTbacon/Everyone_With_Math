using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using WMPLib;

namespace Everyone_With_Math.Class
{
    public partial class Load : UserControl
    {
        WindowsMediaPlayer SE = new WindowsMediaPlayer();
        string Path = Directory.GetCurrentDirectory();
        public bool IsLoadClick = false;
        public bool IsClosing = false;
        bool Load_Mouse_Enter = false;
        public bool Load_Click_True = false;
        bool File_01_Crack = false;
        bool File_02_Crack = false;
        bool File_03_Crack = false;
        [DllImport("User32.dll")]
        static extern short GetAsyncKeyState(int vKey);
        public Load()
        {
            InitializeComponent();
            Main_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Load.png"));
            Load_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_01.png"));
            Load_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_01.png"));
            Load_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_01.png"));
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back.png"));
            //特定のレイアウトがクリックされたら実行する
            Load_01_Grade_T.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_01);
            Load_01_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_01);
            Load_01_Picture_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_01);
            Load_01_Question_T.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_01);
            Load_01_Time_T.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_01);
            Load_02_Grade_T.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_02);
            Load_02_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_02);
            Load_02_Picture_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_02);
            Load_02_Question_T.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_02);
            Load_02_Time_T.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_02);
            Load_03_Grade_T.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_03);
            Load_03_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_03);
            Load_03_Picture_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_03);
            Load_03_Question_T.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_03);
            Load_03_Time_T.MouseDown += new System.Windows.Input.MouseButtonEventHandler(Load_MouseDown_03);
        }
        void SE_Play(string File)
        {
            SE.controls.stop();
            SE.URL = File;
            SE.controls.play();
        }
        public void Window_Show()
        {
            //画面が更新されるたびにセーブデータの状況を更新する
            try
            {
                XDocument xml2 = XDocument.Load(Path + "/Resources/Save/Configs.dat");
                XElement item2 = xml2.Element("Configs_Save");
                SE.settings.volume = int.Parse(item2.Element("SE_Volume").Value);
                if (File.Exists(Path + "/Resources/Save/Save_01.dat"))
                {
                    File_01_Crack = true;
                    BitmapImage bmpImage = new BitmapImage();
                    bmpImage.BeginInit();
                    bmpImage.CacheOption = BitmapCacheOption.OnLoad;
                    bmpImage.UriSource = new Uri(Path + "/Resources/Save/Save_01_Picture.dat");
                    bmpImage.EndInit();
                    Load_01_Picture_Image.Source = bmpImage;
                    using (var eifs = new FileStream(Path + "/Resources/Save/Save_01.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Save/Save_10.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                        }
                    }
                    XDocument xml = XDocument.Load(Path + "/Resources/Save/Save_10.dat");
                    XElement item = xml.Element("Save_Definition");
                    Load_01_Time_T.Text = item.Element("Time").Value;
                    Load_01_Question_T.Text = item.Element("Question_Number").Value + "問目";
                    Load_01_Grade_T.Text = item.Element("Grade").Value;
                    File.Delete(Path + "/Resources/Save/Save_10.dat");
                    File_01_Crack = false;
                }
                if (File.Exists(Path + "/Resources/Save/Save_02.dat"))
                {
                    File_02_Crack = true;
                    BitmapImage bmpImage = new BitmapImage();
                    bmpImage.BeginInit();
                    bmpImage.CacheOption = BitmapCacheOption.OnLoad;
                    bmpImage.UriSource = new Uri(Path + "/Resources/Save/Save_02_Picture.dat");
                    bmpImage.EndInit();
                    Load_02_Picture_Image.Source = bmpImage;
                    using (var eifs = new FileStream(Path + "/Resources/Save/Save_02.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Save/Save_10.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                        }
                    }
                    XDocument xml = XDocument.Load(Path + "/Resources/Save/Save_10.dat");
                    XElement item = xml.Element("Save_Definition");
                    Load_02_Time_T.Text = item.Element("Time").Value;
                    Load_02_Question_T.Text = item.Element("Question_Number").Value + "問目";
                    Load_02_Grade_T.Text = item.Element("Grade").Value;
                    File.Delete(Path + "/Resources/Save/Save_10.dat");
                    File_02_Crack = false;
                }
                if (File.Exists(Path + "/Resources/Save/Save_03.dat"))
                {
                    File_03_Crack = true;
                    BitmapImage bmpImage = new BitmapImage();
                    bmpImage.BeginInit();
                    bmpImage.CacheOption = BitmapCacheOption.OnLoad;
                    bmpImage.UriSource = new Uri(Path + "/Resources/Save/Save_03_Picture.dat");
                    bmpImage.EndInit();
                    Load_03_Picture_Image.Source = bmpImage;
                    using (var eifs = new FileStream(Path + "/Resources/Save/Save_03.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Save/Save_10.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                        }
                    }
                    XDocument xml = XDocument.Load(Path + "/Resources/Save/Save_10.dat");
                    XElement item = xml.Element("Save_Definition");
                    Load_03_Time_T.Text = item.Element("Time").Value;
                    Load_03_Question_T.Text = item.Element("Question_Number").Value + "問目";
                    Load_03_Grade_T.Text = item.Element("Grade").Value;
                    File.Delete(Path + "/Resources/Save/Save_10.dat");
                    File_03_Crack = false;
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("入力データが完全なブロックではありません。"))
                {
                    if (File_01_Crack == true)
                    {
                        MessageBox.Show("セーブデータが取得できませんでした。\nSave_01は削除されます。");
                        File.Delete(Path + "/Resources/Save/Save_01.dat");
                        File.Delete(Path + "/Resources/Save/Save_01_Picture.dat");
                        Load_01_Picture_Image.Source = null;
                        File_01_Crack = false;
                    }
                    else if (File_02_Crack == true)
                    {
                        MessageBox.Show("セーブデータが取得できませんでした。\nSave_02は削除されます。");
                        File.Delete(Path + "/Resources/Save/Save_02.dat");
                        File.Delete(Path + "/Resources/Save/Save_02_Picture.dat");
                        Load_02_Picture_Image.Source = null;
                        File_02_Crack = false;
                    }
                    else if (File_03_Crack == true)
                    {
                        MessageBox.Show("セーブデータが取得できませんでした。\nSave_03は削除されます。");
                        File.Delete(Path + "/Resources/Save/Save_03.dat");
                        File.Delete(Path + "/Resources/Save/Save_03_Picture.dat");
                        Load_03_Picture_Image.Source = null;
                        File_03_Crack = false;
                    }
                }
            }
        }
        private void Back_B_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back_01.png"));
        }
        void Back_B_MouseLeave(object sender,System.Windows.Input.MouseEventArgs e)
        {
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back.png"));
        }
        void Back_B_MouseDown(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Close_Key();
        }
        private void Load_01_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (Load_Mouse_Enter == false)
            {
                SE_Play(Path + "/Resources/SE/SE_04.wav");
                Load_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_02.png"));
                Load_Mouse_Enter = true;
            }
        }
        private void Load_01_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Load_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_01.png"));
            Load_Mouse_Enter = false;
        }
        void Mouse_Enter_01(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Load_01_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_02.png"));
            Load_Mouse_Enter = true;
        }
        private void Load_02_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (Load_Mouse_Enter == false)
            {
                SE_Play(Path + "/Resources/SE/SE_04.wav");
                Load_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_02.png"));
            }
        }
        private void Load_02_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Load_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_01.png"));
            Load_Mouse_Enter = false;
        }
        void Mouse_Enter_02(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Load_02_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_02.png"));
            Load_Mouse_Enter = true;
        }
        private void Load_03_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (Load_Mouse_Enter == false)
            {
                SE_Play(Path + "/Resources/SE/SE_04.wav");
                Load_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_02.png"));
            }
        }
        private void Load_03_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Load_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_01.png"));
            Load_Mouse_Enter = false;
        }
        void Mouse_Enter_03(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Load_03_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Save_02.png"));
            Load_Mouse_Enter = true;
        }
        //セーブデータがクリックされたら実行
        void Load_MouseDown_01(object sender,System.Windows.Input.MouseEventArgs e)
        {
            if (IsClosing == false)
            {
                if (File.Exists(Path + "/Resources/Save/Save_01.dat"))
                {
                    Load_Start(1);
                }
            }
        }
        void Load_MouseDown_02(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (IsClosing == false)
            {
                if (File.Exists(Path + "/Resources/Save/Save_02.dat"))
                {
                    Load_Start(2);
                }
            }
        }
        void Load_MouseDown_03(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (IsClosing == false)
            {
                if (File.Exists(Path + "/Resources/Save/Save_03.dat"))
                {
                    Load_Start(3);
                }
            }
        }
        async void Load_Start(int Number)
        {
            //セーブデータが選択されたら画面を閉じる
            if (IsClosing == false)
            {
                IsClosing = true;
                Opacity = 1;
                StreamWriter stw = File.CreateText(Path + "/Resources/Save/Load_01.dat");
                stw.WriteLine(Number);
                stw.Close();
                while (true)
                {
                    if (Opacity <= 0)
                    {
                        Visibility = Visibility.Hidden;
                        Load_Click_True = true;
                        break;
                    }
                    Opacity -= 0.05;
                    await Task.Delay(30);
                }
            }
        }
        async void Close_Key()
        {
            //フェードアウトしながら閉じる
            if (IsClosing == false)
            {
                Load_Click_True = false;
                IsClosing = true;
                Opacity = 1;
                while (true)
                {
                    if (Opacity <= 0)
                    {
                        IsClosing = false;
                        Visibility = Visibility.Hidden;
                        break;
                    }
                    Opacity -= 0.05;
                    await Task.Delay(30);
                }
            }
        }
    }
}