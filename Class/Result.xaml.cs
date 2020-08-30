using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Everyone_With_Math.Class
{
    public partial class Result : UserControl
    {
        string Path = Directory.GetCurrentDirectory();
        bool IsClosing = false;
        public Result()
        {
            InitializeComponent();
            Close_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_01.png"));
        }
        async public void Window_Show(int Grade_Number)
        {
            Text_T.Text = "リザルト(" + Grade_Number + "学年)";
            Item_Add();
            Opacity = 0;
            IsClosing = true;
            while (true)
            {
                if (Opacity >= 1)
                {
                    IsClosing = false;
                    break;
                }
                Opacity += 0.05;
                await Task.Delay(30);
            }
        }
        private void Close_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Close_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_02.png"));
        }
        private void Close_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Close_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Close_01.png"));
        }
        private async void Close_Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (IsClosing == false)
            {
                File.Delete(Path + "/Resources/Result.dat");
                while (true)
                {
                    if (Opacity <= 0)
                    {
                        Visibility = System.Windows.Visibility.Hidden;
                        break;
                    }
                    Opacity -= 0.05;
                    await Task.Delay(30);
                }
            }
        }
        void Item_Add()
        {
            int Number = 1;
            StreamReader str = new StreamReader(Path + "/Resources/Result.dat");
            while (str.EndOfStream == false)
            {
                string OK = str.ReadLine();
                if (OK == "True")
                {
                    Question_Result_C.Items.Add("問題" + Number + " : 正解");
                }
                else if (OK == "False")
                {
                    Question_Result_C.Items.Add("問題" + Number + " : 不正解");
                }
                else
                {
                    //基本出ない
                    Question_Result_C.Items.Add("問題" + Number + " : 取得できませんでした。(*_ _)ペコリ");
                }
                Number++;
            }
            str.Close();
        }
    }
}