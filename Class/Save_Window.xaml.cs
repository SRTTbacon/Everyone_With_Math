using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using System.Xml.Serialization;
using WMPLib;

namespace Everyone_With_Math.Class
{
    public partial class Save : UserControl
    {
        //このクラスもバグで勝手に削除されて.exeから無理やり復元したためコードが読みにくくなっています。
        private string Path = Directory.GetCurrentDirectory();
        private WindowsMediaPlayer SE = new WindowsMediaPlayer();
        WindowsMediaPlayer SE_01 = new WindowsMediaPlayer();
        public bool IsClosing = false;
        private bool Save_Mouse_Enter = false;
        bool File_01_Crack = false;
        bool File_02_Crack = false;
        bool File_03_Crack = false;
        public Save()
        {
            InitializeComponent();
            Main_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save.png")));
            Back_B.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Back.png")));
            Save_01_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_01.png")));
            Save_02_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_01.png")));
            Save_03_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_01.png")));
            Save_01_Delete_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_01.png"));
            Save_02_Delete_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_01.png"));
            Save_03_Delete_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_01.png"));
            Save_01_Delete_Image.Visibility = Visibility.Hidden;
            Save_02_Delete_Image.Visibility = Visibility.Hidden;
            Save_03_Delete_Image.Visibility = Visibility.Hidden;
            Save_01_Grade_T.MouseDown += new MouseButtonEventHandler(Save_01_Click);
            Save_01_Image.MouseDown += new MouseButtonEventHandler(Save_01_Click);
            Save_01_Picture_Image.MouseDown += new MouseButtonEventHandler(Save_01_Click);
            Save_01_Question_T.MouseDown += new MouseButtonEventHandler(Save_01_Click);
            Save_01_Time_T.MouseDown += new MouseButtonEventHandler(Save_01_Click);
            Save_02_Grade_T.MouseDown += new MouseButtonEventHandler(Save_02_Click);
            Save_02_Image.MouseDown += new MouseButtonEventHandler(Save_02_Click);
            Save_02_Picture_Image.MouseDown += new MouseButtonEventHandler(Save_02_Click);
            Save_02_Question_T.MouseDown += new MouseButtonEventHandler(Save_02_Click);
            Save_02_Time_T.MouseDown += new MouseButtonEventHandler(Save_02_Click);
            Save_03_Grade_T.MouseDown += new MouseButtonEventHandler(Save_03_Click);
            Save_03_Image.MouseDown += new MouseButtonEventHandler(Save_03_Click);
            Save_03_Picture_Image.MouseDown += new MouseButtonEventHandler(Save_03_Click);
            Save_03_Question_T.MouseDown += new MouseButtonEventHandler(Save_03_Click);
            Save_03_Time_T.MouseDown += new MouseButtonEventHandler(Save_03_Click);
        }
        private void Back_B_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close_Key();
        }
        private void Back_B_MouseEnter(object sender, MouseEventArgs e)
        {
            SE_Play(string.Concat(Path, "/Resources/SE/SE_04.wav"));
            Back_B.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Back_01.png")));
        }
        private void Back_B_MouseLeave(object sender, MouseEventArgs e)
        {
            Back_B.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Back.png")));
        }
        private async void Close_Key()
        {
            //フェードアウトしながら閉じる
            if (IsClosing == false)
            {
                IsClosing = true;
                Opacity = 1;
                while (true)
                {
                    if (Opacity <= 0)
                    {
                        break;
                    }
                    Opacity = Opacity - 0.05;
                    await Task.Delay(30);
                }
                IsClosing = false;
                Visibility = Visibility.Hidden;
            }
        }
        private void Save_01_Click(object sender, MouseButtonEventArgs e)
        {
            Save_Data(1);
        }
        private void Save_01_Grade_T_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_01_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_01_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!Save_Mouse_Enter)
            {
                SE_Play(string.Concat(Path, "/Resources/SE/SE_04.wav"));
                Save_01_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
                Save_Mouse_Enter = true;
            }
        }
        private void Save_01_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Save_01_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_01.png")));
            Save_Mouse_Enter = false;
        }
        private void Save_01_Picture_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_01_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_01_Question_T_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_01_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_01_Time_T_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_01_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_02_Click(object sender, MouseButtonEventArgs e)
        {
            Save_Data(2);
        }
        private void Save_02_Grade_T_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_02_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_02_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!Save_Mouse_Enter)
            {
                SE_Play(string.Concat(Path, "/Resources/SE/SE_04.wav"));
                Save_02_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
                Save_Mouse_Enter = true;
            }
        }
        private void Save_02_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Save_02_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_01.png")));
            Save_Mouse_Enter = false;
        }
        private void Save_02_Picture_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_02_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_02_Question_T_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_02_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_02_Time_T_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_02_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_03_Click(object sender, MouseButtonEventArgs e)
        {
            Save_Data(3);
        }
        private void Save_03_Grade_T_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_03_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_03_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!Save_Mouse_Enter)
            {
                SE_Play(string.Concat(Path, "/Resources/SE/SE_04.wav"));
                Save_03_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
                Save_Mouse_Enter = true;
            }
        }
        private void Save_03_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Save_03_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_01.png")));
            Save_Mouse_Enter = false;
        }
        private void Save_03_Picture_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_03_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_03_Question_T_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_03_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_03_Time_T_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_03_Image.Source = new BitmapImage(new Uri(string.Concat(Path, "/Resources/BG/Save_02.png")));
            Save_Mouse_Enter = true;
        }
        private void Save_Data(int Save_Number)
        {
            if (!IsClosing)
            {
                //Save_99,datの内容をもとにセーブデータを作成
                File.CreateText(string.Concat(new object[] { Path, "/Resources/Save/Save_0", Save_Number, "_Temp.dat" })).Close();
                DateTime now = DateTime.Now;
                Save_Definition saveDefinition = new Save_Definition()
                {
                    Time = string.Concat(new object[] { now.Year, "/", now.Month, "/", now.Day, "/", now.Hour, ":", now.Minute, ":", now.Second })
                };
                using (var eifs = new FileStream(Path + "/Resources/Save/Save_99.dat", FileMode.Open, FileAccess.Read))
                {
                    using (var eofs = new FileStream(Path + "/Resources/Save/Save_98.dat", FileMode.Create, FileAccess.Write))
                    {
                        FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                    }
                }
                XDocument xDocument = XDocument.Load(string.Concat(Path, "/Resources/Save/Save_98.dat"));
                XElement xElement = xDocument.Element("Save_Definition");
                saveDefinition.Question_Number = int.Parse(xElement.Element("Question_Number").Value);
                saveDefinition.Grade = xElement.Element("Grade").Value;
                saveDefinition.Question_01_01_Answer = bool.Parse(xElement.Element("Question_01_01_Answer").Value);
                saveDefinition.Question_01_02_Answer = bool.Parse(xElement.Element("Question_01_02_Answer").Value);
                saveDefinition.Question_01_03_Answer = bool.Parse(xElement.Element("Question_01_03_Answer").Value);
                saveDefinition.Question_01_04_Answer = bool.Parse(xElement.Element("Question_01_04_Answer").Value);
                saveDefinition.Question_01_05_Answer = bool.Parse(xElement.Element("Question_01_05_Answer").Value);
                saveDefinition.Question_01_06_Answer = bool.Parse(xElement.Element("Question_01_06_Answer").Value);
                saveDefinition.Question_01_07_Answer = bool.Parse(xElement.Element("Question_01_07_Answer").Value);
                saveDefinition.Question_01_08_Answer = bool.Parse(xElement.Element("Question_01_08_Answer").Value);
                saveDefinition.Question_01_09_Answer = bool.Parse(xElement.Element("Question_01_09_Answer").Value);
                saveDefinition.Question_01_10_Answer = bool.Parse(xElement.Element("Question_01_10_Answer").Value);
                saveDefinition.Question_01_11_Answer = bool.Parse(xElement.Element("Question_01_11_Answer").Value);
                saveDefinition.Question_01_12_Answer = bool.Parse(xElement.Element("Question_01_12_Answer").Value);
                saveDefinition.Question_01_13_Answer = bool.Parse(xElement.Element("Question_01_13_Answer").Value);
                saveDefinition.Question_01_14_Answer = bool.Parse(xElement.Element("Question_01_14_Answer").Value);
                saveDefinition.Question_01_15_Answer = bool.Parse(xElement.Element("Question_01_15_Answer").Value);
                saveDefinition.Question_01_16_Answer = bool.Parse(xElement.Element("Question_01_16_Answer").Value);
                saveDefinition.Question_01_17_Answer = bool.Parse(xElement.Element("Question_01_17_Answer").Value);
                saveDefinition.Question_01_18_Answer = bool.Parse(xElement.Element("Question_01_18_Answer").Value);
                saveDefinition.Question_01_19_Answer = bool.Parse(xElement.Element("Question_01_19_Answer").Value);
                saveDefinition.Question_01_20_Answer = bool.Parse(xElement.Element("Question_01_20_Answer").Value);
                saveDefinition.Question_01_21_Answer = bool.Parse(xElement.Element("Question_01_21_Answer").Value);
                saveDefinition.Question_01_22_Answer = bool.Parse(xElement.Element("Question_01_22_Answer").Value);
                saveDefinition.Question_01_23_Answer = bool.Parse(xElement.Element("Question_01_23_Answer").Value);
                saveDefinition.Question_01_24_Answer = bool.Parse(xElement.Element("Question_01_24_Answer").Value);
                saveDefinition.Question_01_25_Answer = bool.Parse(xElement.Element("Question_01_25_Answer").Value);
                saveDefinition.Question_01_26_Answer = bool.Parse(xElement.Element("Question_01_26_Answer").Value);
                saveDefinition.Question_01_27_Answer = bool.Parse(xElement.Element("Question_01_27_Answer").Value);
                saveDefinition.Question_01_28_Answer = bool.Parse(xElement.Element("Question_01_28_Answer").Value);
                saveDefinition.Question_01_29_Answer = bool.Parse(xElement.Element("Question_01_29_Answer").Value);
                saveDefinition.Question_01_30_Answer = bool.Parse(xElement.Element("Question_01_30_Answer").Value);
                saveDefinition.Question_02_01_Answer = bool.Parse(xElement.Element("Question_02_01_Answer").Value);
                saveDefinition.Question_02_02_Answer = bool.Parse(xElement.Element("Question_02_02_Answer").Value);
                saveDefinition.Question_02_03_Answer = bool.Parse(xElement.Element("Question_02_03_Answer").Value);
                saveDefinition.Question_02_04_Answer = bool.Parse(xElement.Element("Question_02_04_Answer").Value);
                saveDefinition.Question_02_05_Answer = bool.Parse(xElement.Element("Question_02_05_Answer").Value);
                saveDefinition.Question_02_06_Answer = bool.Parse(xElement.Element("Question_02_06_Answer").Value);
                saveDefinition.Question_02_07_Answer = bool.Parse(xElement.Element("Question_02_07_Answer").Value);
                saveDefinition.Question_02_08_Answer = bool.Parse(xElement.Element("Question_02_08_Answer").Value);
                saveDefinition.Question_02_09_Answer = bool.Parse(xElement.Element("Question_02_09_Answer").Value);
                saveDefinition.Question_02_10_Answer = bool.Parse(xElement.Element("Question_02_10_Answer").Value);
                saveDefinition.Question_02_11_Answer = bool.Parse(xElement.Element("Question_02_11_Answer").Value);
                saveDefinition.Question_02_12_Answer = bool.Parse(xElement.Element("Question_02_12_Answer").Value);
                saveDefinition.Question_02_13_Answer = bool.Parse(xElement.Element("Question_02_13_Answer").Value);
                saveDefinition.Question_02_14_Answer = bool.Parse(xElement.Element("Question_02_14_Answer").Value);
                saveDefinition.Question_02_15_Answer = bool.Parse(xElement.Element("Question_02_15_Answer").Value);
                saveDefinition.Question_02_16_Answer = bool.Parse(xElement.Element("Question_02_16_Answer").Value);
                saveDefinition.Question_02_17_Answer = bool.Parse(xElement.Element("Question_02_17_Answer").Value);
                saveDefinition.Question_02_18_Answer = bool.Parse(xElement.Element("Question_02_18_Answer").Value);
                saveDefinition.Question_02_19_Answer = bool.Parse(xElement.Element("Question_02_19_Answer").Value);
                saveDefinition.Question_02_20_Answer = bool.Parse(xElement.Element("Question_02_20_Answer").Value);
                saveDefinition.Question_02_21_Answer = bool.Parse(xElement.Element("Question_02_21_Answer").Value);
                saveDefinition.Question_02_22_Answer = bool.Parse(xElement.Element("Question_02_22_Answer").Value);
                saveDefinition.Question_02_23_Answer = bool.Parse(xElement.Element("Question_02_23_Answer").Value);
                saveDefinition.Question_02_24_Answer = bool.Parse(xElement.Element("Question_02_24_Answer").Value);
                saveDefinition.Question_02_25_Answer = bool.Parse(xElement.Element("Question_02_25_Answer").Value);
                saveDefinition.Question_02_26_Answer = bool.Parse(xElement.Element("Question_02_26_Answer").Value);
                saveDefinition.Question_02_27_Answer = bool.Parse(xElement.Element("Question_02_27_Answer").Value);
                saveDefinition.Question_02_28_Answer = bool.Parse(xElement.Element("Question_02_28_Answer").Value);
                saveDefinition.Question_02_29_Answer = bool.Parse(xElement.Element("Question_02_29_Answer").Value);
                saveDefinition.Question_02_30_Answer = bool.Parse(xElement.Element("Question_02_30_Answer").Value);
                saveDefinition.Question_03_01_Answer = bool.Parse(xElement.Element("Question_03_01_Answer").Value);
                saveDefinition.Question_03_02_Answer = bool.Parse(xElement.Element("Question_03_02_Answer").Value);
                saveDefinition.Question_03_03_Answer = bool.Parse(xElement.Element("Question_03_03_Answer").Value);
                saveDefinition.Question_03_04_Answer = bool.Parse(xElement.Element("Question_03_04_Answer").Value);
                saveDefinition.Question_03_05_Answer = bool.Parse(xElement.Element("Question_03_05_Answer").Value);
                saveDefinition.Question_03_06_Answer = bool.Parse(xElement.Element("Question_03_06_Answer").Value);
                saveDefinition.Question_03_07_Answer = bool.Parse(xElement.Element("Question_03_07_Answer").Value);
                saveDefinition.Question_03_08_Answer = bool.Parse(xElement.Element("Question_03_08_Answer").Value);
                saveDefinition.Question_03_09_Answer = bool.Parse(xElement.Element("Question_03_09_Answer").Value);
                saveDefinition.Question_03_10_Answer = bool.Parse(xElement.Element("Question_03_10_Answer").Value);
                saveDefinition.Question_03_11_Answer = bool.Parse(xElement.Element("Question_03_11_Answer").Value);
                saveDefinition.Question_03_12_Answer = bool.Parse(xElement.Element("Question_03_12_Answer").Value);
                saveDefinition.Question_03_13_Answer = bool.Parse(xElement.Element("Question_03_13_Answer").Value);
                saveDefinition.Question_03_14_Answer = bool.Parse(xElement.Element("Question_03_14_Answer").Value);
                saveDefinition.Question_03_15_Answer = bool.Parse(xElement.Element("Question_03_15_Answer").Value);
                saveDefinition.Question_03_16_Answer = bool.Parse(xElement.Element("Question_03_16_Answer").Value);
                saveDefinition.Question_03_17_Answer = bool.Parse(xElement.Element("Question_03_17_Answer").Value);
                saveDefinition.Question_03_18_Answer = bool.Parse(xElement.Element("Question_03_18_Answer").Value);
                saveDefinition.Question_03_19_Answer = bool.Parse(xElement.Element("Question_03_19_Answer").Value);
                saveDefinition.Question_03_20_Answer = bool.Parse(xElement.Element("Question_03_20_Answer").Value);
                saveDefinition.Question_03_21_Answer = bool.Parse(xElement.Element("Question_03_21_Answer").Value);
                saveDefinition.Question_03_22_Answer = bool.Parse(xElement.Element("Question_03_22_Answer").Value);
                saveDefinition.Question_03_23_Answer = bool.Parse(xElement.Element("Question_03_23_Answer").Value);
                saveDefinition.Question_03_24_Answer = bool.Parse(xElement.Element("Question_03_24_Answer").Value);
                saveDefinition.Question_03_25_Answer = bool.Parse(xElement.Element("Question_03_25_Answer").Value);
                saveDefinition.Question_03_26_Answer = bool.Parse(xElement.Element("Question_03_26_Answer").Value);
                saveDefinition.Question_03_27_Answer = bool.Parse(xElement.Element("Question_03_27_Answer").Value);
                saveDefinition.Question_03_28_Answer = bool.Parse(xElement.Element("Question_03_28_Answer").Value);
                saveDefinition.Question_03_29_Answer = bool.Parse(xElement.Element("Question_03_29_Answer").Value);
                saveDefinition.Question_03_30_Answer = bool.Parse(xElement.Element("Question_03_30_Answer").Value);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Save_Definition));
                StreamWriter streamWriter = new StreamWriter(string.Concat(new object[] { Path, "/Resources/Save/Save_0", Save_Number, "_Temp.dat" }), false, new UTF8Encoding(false));
                xmlSerializer.Serialize(streamWriter, saveDefinition);
                streamWriter.Close();
                Bitmap bmp = new Bitmap(Path + "/Resources/Save/Save_Picture.dat");
                Bitmap bmp2 = new Bitmap(bmp, 1280, 720);
                bmp2.Save(Path + "/Resources/Save/Save_0" + Save_Number + "_Picture.dat");
                bmp.Dispose();
                bmp2.Dispose();
                if (Save_Number == 1)
                {
                    Save_01_Picture_Image.Source = null;
                    Save_01_Time_T.Text = saveDefinition.Time;
                    Save_01_Grade_T.Text = saveDefinition.Grade;
                    MemoryStream data = new MemoryStream(File.ReadAllBytes(Path + "/Resources/Save/Save_01_Picture.dat"));
                    WriteableBitmap wbmp = new WriteableBitmap(BitmapFrame.Create(data));
                    data.Close();
                    Save_01_Picture_Image.Source = wbmp;
                    Save_01_Question_T.Text = string.Concat(saveDefinition.Question_Number, "問目");
                }
                else if (Save_Number == 2)
                {
                    Save_02_Picture_Image.Source = null;
                    Save_02_Time_T.Text = saveDefinition.Time;
                    Save_02_Grade_T.Text = saveDefinition.Grade;
                    MemoryStream data = new MemoryStream(File.ReadAllBytes(Path + "/Resources/Save/Save_02_Picture.dat"));
                    WriteableBitmap wbmp = new WriteableBitmap(BitmapFrame.Create(data));
                    data.Close();
                    Save_02_Picture_Image.Source = wbmp;
                    Save_02_Question_T.Text = string.Concat(saveDefinition.Question_Number, "問目");
                }
                else if (Save_Number == 3)
                {
                    Save_03_Picture_Image.Source = null;
                    Save_03_Time_T.Text = saveDefinition.Time;
                    Save_03_Grade_T.Text = saveDefinition.Grade;
                    MemoryStream data = new MemoryStream(File.ReadAllBytes(Path + "/Resources/Save/Save_03_Picture.dat"));
                    WriteableBitmap wbmp = new WriteableBitmap(BitmapFrame.Create(data));
                    data.Close();
                    Save_03_Picture_Image.Source = wbmp;
                    Save_03_Question_T.Text = string.Concat(saveDefinition.Question_Number, "問目");
                }
                //セーブファイルを暗号化
                using (var eifs = new FileStream(Path + "/Resources/Save/Save_0" + Save_Number + "_Temp.dat", FileMode.Open, FileAccess.Read))
                {
                    using (var eofs = new FileStream(Path + "/Resources/Save/Save_0" + Save_Number + ".dat", FileMode.Create, FileAccess.Write))
                    {
                        FileEncode.FileEncryptor.Encrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                    }
                }
                File.Delete(Path + "/Resources/Save/Save_0" + Save_Number + "_Temp.dat");
                File.Delete(Path + "/Resources/Save/Save_98.dat");
                SE_Play(Path + "/Resources/SE/SE_02.wav",true);
            }
        }
        private void SE_Play(string File)
        {
            //SEを再生
            SE.controls.stop();
            SE.URL = File;
            SE.controls.play();
        }
        void SE_Play(string File,bool a)
        {
            //通常のSE_Playが実行されている可能性がある場合に使用
            SE_01.controls.stop();
            SE_01.URL = File;
            SE_01.controls.play();
        }
        [DllImport("User32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        static  extern short GetAsyncKeyState(int vKey);
        async void Window_Close_Key()
        {
            bool flag;
            while (true)
            {
                flag = (GetAsyncKeyState(27) == 0 ? false : !IsClosing);
                if (flag)
                {
                    break;
                }
                await Task.Delay(100);
            }
            Close_Key();
        }
        public void Window_Show()
        {
            try
            {
                //設定をロード
                XDocument xDocument = XDocument.Load(string.Concat(Path, "/Resources/Save/Configs.dat"));
                XElement xElement = xDocument.Element("Configs_Save");
                SE.settings.volume = int.Parse(xElement.Element("SE_Volume").Value);
                SE_01.settings.volume = int.Parse(xElement.Element("SE_Volume").Value);
                //セーブデータが存在したら内容を取得し画像や文に表示させる
                if (File.Exists(string.Concat(Path, "/Resources/Save/Save_01.dat")))
                {
                    File_01_Crack = true;
                    Save_01_Picture_Image.Source = null;
                    MemoryStream data = new MemoryStream(File.ReadAllBytes(Path + "/Resources/Save/Save_01_Picture.dat"));
                    WriteableBitmap wbmp = new WriteableBitmap(BitmapFrame.Create(data));
                    data.Close();
                    Save_01_Picture_Image.Source = wbmp;
                    using (var eifs = new FileStream(Path + "/Resources/Save/Save_01.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Save/Save_10.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                        }
                    }
                    XDocument xDocument1 = XDocument.Load(string.Concat(Path, "/Resources/Save/Save_10.dat"));
                    XElement xElement1 = xDocument1.Element("Save_Definition");
                    Save_01_Time_T.Text = xElement1.Element("Time").Value;
                    Save_01_Question_T.Text = string.Concat(xElement1.Element("Question_Number").Value, "問目");
                    Save_01_Grade_T.Text = xElement1.Element("Grade").Value;
                    File.Delete(string.Concat(Path, "/Resources/Save/Save_10.dat"));
                    Save_01_Delete_Image.Visibility = Visibility.Visible;
                    File_01_Crack = false;
                }
                if (File.Exists(string.Concat(Path, "/Resources/Save/Save_02.dat")))
                {
                    File_02_Crack = true;
                    Save_02_Picture_Image.Source = null;
                    MemoryStream data = new MemoryStream(File.ReadAllBytes(Path + "/Resources/Save/Save_02_Picture.dat"));
                    WriteableBitmap wbmp = new WriteableBitmap(BitmapFrame.Create(data));
                    data.Close();
                    Save_02_Picture_Image.Source = wbmp;
                    using (var eifs = new FileStream(Path + "/Resources/Save/Save_02.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Save/Save_10.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                        }
                    }
                    XDocument xDocument2 = XDocument.Load(string.Concat(Path, "/Resources/Save/Save_10.dat"));
                    XElement xElement2 = xDocument2.Element("Save_Definition");
                    Save_02_Time_T.Text = xElement2.Element("Time").Value;
                    Save_02_Question_T.Text = string.Concat(xElement2.Element("Question_Number").Value, "問目");
                    Save_02_Grade_T.Text = xElement2.Element("Grade").Value;
                    File.Delete(string.Concat(Path, "/Resources/Save/Save_10.dat"));
                    Save_02_Delete_Image.Visibility = Visibility.Visible;
                    File_02_Crack = false;
                }
                if (File.Exists(string.Concat(Path, "/Resources/Save/Save_03.dat")))
                {
                    File_03_Crack = true;
                    Save_03_Picture_Image.Source = null;
                    MemoryStream data = new MemoryStream(File.ReadAllBytes(Path + "/Resources/Save/Save_03_Picture.dat"));
                    WriteableBitmap wbmp = new WriteableBitmap(BitmapFrame.Create(data));
                    data.Close();
                    Save_03_Picture_Image.Source = wbmp;
                    using (var eifs = new FileStream(Path + "/Resources/Save/Save_03.dat", FileMode.Open, FileAccess.Read))
                    {
                        using (var eofs = new FileStream(Path + "/Resources/Save/Save_10.dat", FileMode.Create, FileAccess.Write))
                        {
                            FileEncode.FileEncryptor.Decrypt(eifs, eofs, "Created_By_SRTTbacon_and_Gumipoteti_E");
                        }
                    }
                    XDocument xDocument3 = XDocument.Load(string.Concat(Path, "/Resources/Save/Save_10.dat"));
                    XElement xElement3 = xDocument3.Element("Save_Definition");
                    Save_03_Time_T.Text = xElement3.Element("Time").Value;
                    Save_03_Question_T.Text = string.Concat(xElement3.Element("Question_Number").Value, "問目");
                    Save_03_Grade_T.Text = xElement3.Element("Grade").Value;
                    File.Delete(string.Concat(Path, "/Resources/Save/Save_10.dat"));
                    Save_03_Delete_Image.Visibility = Visibility.Visible;
                    File_03_Crack = false;
                }
            }
            catch (Exception e)
            {
                //セーブファイルが存在するのに正常に取得できなかった場合
                if (e.Message.Contains("入力データが完全なブロックではありません。"))
                {
                    if (File_01_Crack == true)
                    {
                        MessageBox.Show("セーブデータが取得できませんでした。\nSave_01は削除されます。");
                        File.Delete(Path + "/Resources/Save/Save_01.dat");
                        File.Delete(Path + "/Resources/Save/Save_01_Picture.dat");
                        Save_01_Picture_Image.Source = null;
                        Save_01_Delete_Image.Visibility = Visibility.Hidden;
                        File_01_Crack = false;
                    }
                    else if (File_02_Crack == true)
                    {
                        MessageBox.Show("セーブデータが取得できませんでした。\nSave_02は削除されます。");
                        File.Delete(Path + "/Resources/Save/Save_02.dat");
                        File.Delete(Path + "/Resources/Save/Save_02_Picture.dat");
                        Save_02_Picture_Image.Source = null;
                        Save_02_Delete_Image.Visibility = Visibility.Hidden;
                        File_02_Crack = false;
                    }
                    else if (File_03_Crack == true)
                    {
                        MessageBox.Show("セーブデータが取得できませんでした。\nSave_03は削除されます。");
                        File.Delete(Path + "/Resources/Save/Save_03.dat");
                        File.Delete(Path + "/Resources/Save/Save_03_Picture.dat");
                        Save_03_Picture_Image.Source = null;
                        Save_03_Delete_Image.Visibility = Visibility.Hidden;
                        File_03_Crack = false;
                    }
                }
            }
        }
        private void Save_01_Delete_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_01_Delete_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_02.png"));
        }
        private void Save_01_Delete_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Save_01_Delete_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_01.png"));
        }
        private void Save_02_Delete_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_02_Delete_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_02.png"));
        }
        private void Save_02_Delete_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Save_02_Delete_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_01.png"));
        }
        private void Save_03_Delete_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Save_03_Delete_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_02.png"));
        }
        private void Save_03_Delete_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Save_03_Delete_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_01.png"));
        }
        private void Save_01_Delete_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Save_Delete(1);
        }
        private void Save_02_Delete_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Save_Delete(2);
        }
        private void Save_03_Delete_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Save_Delete(3);
        }
        void Save_Delete(int Save_Number)
        {
            try
            {
                MessageBoxResult result = MessageBox.Show("セーブ" + Save_Number + "を削除しますか？\nこの操作は取り消すことができません。", "確認", MessageBoxButton.YesNo, MessageBoxImage.Exclamation, MessageBoxResult.No);
                if (result == MessageBoxResult.Yes)
                {
                    File.Delete(Path + "/Resources/Save/Save_0" + Save_Number + ".dat");
                    File.Delete(Path + "/Resources/Save/Save_0" + Save_Number + "_Picture.dat");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("エラー:正常にデータを削除できませんでした。\n" + e.Message);
            }
        }
    }
}
public class Save_Definition
{
    //セーブ内容の定義
    public int Question_Number;
    public string Grade;
    public string Time;
    public bool Question_01_01_Answer;
    public bool Question_01_02_Answer;
    public bool Question_01_03_Answer;
    public bool Question_01_04_Answer;
    public bool Question_01_05_Answer;
    public bool Question_01_06_Answer;
    public bool Question_01_07_Answer;
    public bool Question_01_08_Answer;
    public bool Question_01_09_Answer;
    public bool Question_01_10_Answer;
    public bool Question_01_11_Answer;
    public bool Question_01_12_Answer;
    public bool Question_01_13_Answer;
    public bool Question_01_14_Answer;
    public bool Question_01_15_Answer;
    public bool Question_01_16_Answer;
    public bool Question_01_17_Answer;
    public bool Question_01_18_Answer;
    public bool Question_01_19_Answer;
    public bool Question_01_20_Answer;
    public bool Question_01_21_Answer;
    public bool Question_01_22_Answer;
    public bool Question_01_23_Answer;
    public bool Question_01_24_Answer;
    public bool Question_01_25_Answer;
    public bool Question_01_26_Answer;
    public bool Question_01_27_Answer;
    public bool Question_01_28_Answer;
    public bool Question_01_29_Answer;
    public bool Question_01_30_Answer;
    public bool Question_02_01_Answer;
    public bool Question_02_02_Answer;
    public bool Question_02_03_Answer;
    public bool Question_02_04_Answer;
    public bool Question_02_05_Answer;
    public bool Question_02_06_Answer;
    public bool Question_02_07_Answer;
    public bool Question_02_08_Answer;
    public bool Question_02_09_Answer;
    public bool Question_02_10_Answer;
    public bool Question_02_11_Answer;
    public bool Question_02_12_Answer;
    public bool Question_02_13_Answer;
    public bool Question_02_14_Answer;
    public bool Question_02_15_Answer;
    public bool Question_02_16_Answer;
    public bool Question_02_17_Answer;
    public bool Question_02_18_Answer;
    public bool Question_02_19_Answer;
    public bool Question_02_20_Answer;
    public bool Question_02_21_Answer;
    public bool Question_02_22_Answer;
    public bool Question_02_23_Answer;
    public bool Question_02_24_Answer;
    public bool Question_02_25_Answer;
    public bool Question_02_26_Answer;
    public bool Question_02_27_Answer;
    public bool Question_02_28_Answer;
    public bool Question_02_29_Answer;
    public bool Question_02_30_Answer;
    public bool Question_03_01_Answer;
    public bool Question_03_02_Answer;
    public bool Question_03_03_Answer;
    public bool Question_03_04_Answer;
    public bool Question_03_05_Answer;
    public bool Question_03_06_Answer;
    public bool Question_03_07_Answer;
    public bool Question_03_08_Answer;
    public bool Question_03_09_Answer;
    public bool Question_03_10_Answer;
    public bool Question_03_11_Answer;
    public bool Question_03_12_Answer;
    public bool Question_03_13_Answer;
    public bool Question_03_14_Answer;
    public bool Question_03_15_Answer;
    public bool Question_03_16_Answer;
    public bool Question_03_17_Answer;
    public bool Question_03_18_Answer;
    public bool Question_03_19_Answer;
    public bool Question_03_20_Answer;
    public bool Question_03_21_Answer;
    public bool Question_03_22_Answer;
    public bool Question_03_23_Answer;
    public bool Question_03_24_Answer;
    public bool Question_03_25_Answer;
    public bool Question_03_26_Answer;
    public bool Question_03_27_Answer;
    public bool Question_03_28_Answer;
    public bool Question_03_29_Answer;
    public bool Question_03_30_Answer;
}