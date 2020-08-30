using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using WMPLib;

namespace Everyone_With_Math.Class
{
    public partial class Grade_01 : UserControl
    {
        //Grade_01と書いているがGrade_02とGrade_03も含む
        //永遠と指定した問題ができるようにするクラス
        string Path = Directory.GetCurrentDirectory();
        WindowsMediaPlayer SE = new WindowsMediaPlayer();
        public bool IsClosing = false;
        int Grade_Num = 0;
        public Grade_01()
        {
            InitializeComponent();
            //1学年の問題を自由にできるように(選んだ問題を永遠に行うことができる)
            Main_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Grade_01_Questions.png"));
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back.png"));
        }
        public void Window_Start(int Number)
        {
            Main_Image.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Grade_0" + Number + "_Questions.png"));
            XDocument xml2 = XDocument.Load(Path + "/Resources/Save/Configs.dat");
            XElement item2 = xml2.Element("Configs_Save");
            SE.settings.volume = int.Parse(item2.Element("SE_Volume").Value);
            Grade_Num = Number;
            Question_List.Items.Clear();
            //学年によって表示する文章を変更
            if (Number == 1)
            {
                Question_List.Items.Add("問題01 | 加法,減法(ランダム)");
                Question_List.Items.Add("問題02 | 乗法(ランダム)");
                Question_List.Items.Add("問題03 | 逆数(ランダム)");
                Question_List.Items.Add("問題04 | 除法1(5問のみ)");
                Question_List.Items.Add("問題05 | 除法2(5問のみ)");
                Question_List.Items.Add("問題06 | 文字列ありの加法減法(ランダム)");
                Question_List.Items.Add("問題07 | 文字列ありの乗法(ランダム)");
                Question_List.Items.Add("問題08 | 文字列ありの除法(5問のみ)");
                Question_List.Items.Add("問題09 | 円の面積、この長さ(5問のみ)");
                Question_List.Items.Add("問題10 | 方程式の表し方(5問のみ)");
                Question_List.Items.Add("問題11 | 方程式1(5問のみ)");
                Question_List.Items.Add("問題12 | 方程式2(5問のみ)");
                Question_List.Items.Add("問題13 | 比例式(5問のみ)");
                Question_List.Items.Add("問題14 | 文章問題(5問のみ)");
                Question_List.Items.Add("問題15 | 速さと時間(5問のみ)");
                Question_List.Items.Add("問題16 | 割合(5問のみ)");
                Question_List.Items.Add("問題17 | 関数(5問のみ)");
                Question_List.Items.Add("問題18 | 比例(5問のみ)");
                Question_List.Items.Add("問題19 | 反比例(5問のみ)");
                Question_List.Items.Add("問題20 | 座標(5問のみ)");
                Question_List.Items.Add("問題21 | 角度の計算(5問のみ)");
                Question_List.Items.Add("問題22 | 図形(5問のみ)");
                Question_List.Items.Add("問題23 | 四角柱の体積(ランダム)");
                Question_List.Items.Add("問題24 | 三角柱の体積(ランダム)");
                Question_List.Items.Add("問題25 | 円柱の体積1(ランダム)");
                Question_List.Items.Add("問題26 | 円柱の表面積1(ランダム)");
                Question_List.Items.Add("問題27 | 直角三角形の体積(ランダム)");
                Question_List.Items.Add("問題28 | 正四角錐の体積(ランダム)");
                Question_List.Items.Add("問題29 | 円柱の体積2(ランダム)");
                Question_List.Items.Add("問題30 | 円柱の表面積2(ランダム)");
            }
            else if (Number == 2)
            {
                Question_List.Items.Add("問題01 | 単項式の個数(5問のみ)");
                Question_List.Items.Add("問題02 | 二次方程式の計算1(ランダム)");
                Question_List.Items.Add("問題03 | 二次方程式の計算2(5問のみ)");
                Question_List.Items.Add("問題04 | 式の代入(ランダム)");
                Question_List.Items.Add("問題05 | 等式の変形(5問のみ)");
                Question_List.Items.Add("問題06 | 連立方程式1(5問のみ)");
                Question_List.Items.Add("問題07 | 連立方程式2(5問のみ)");
                Question_List.Items.Add("問題08 | 連立方程式3(5問のみ)");
                Question_List.Items.Add("問題09 | 連立方程式4(5問のみ)");
                Question_List.Items.Add("問題10 | y = の式1(5問のみ)");
                Question_List.Items.Add("問題11 | y = の式2(ランダム)");
                Question_List.Items.Add("問題12 | 一次関数の式の計算(5問のみ)");
                Question_List.Items.Add("問題13 | 2点から一次関数の式を出す(5問のみ)");
                Question_List.Items.Add("問題14 | 一次関数の変域(5問のみ)");
                Question_List.Items.Add("問題15 | 直線の式の平行、交点(5問のみ)");
                Question_List.Items.Add("問題16 | 動く点P1(5問のみ)");
                Question_List.Items.Add("問題17 | 動く点P2(5問のみ)");
                Question_List.Items.Add("問題18 | 平行線の同意角(ランダム)");
                Question_List.Items.Add("問題19 | 平行線の錯角(ランダム)");
                Question_List.Items.Add("問題20 | 三角形の内角(ランダム)");
                Question_List.Items.Add("問題21 | 三角形の外角(ランダム)");
                Question_List.Items.Add("問題22 | 角度の計算1(ランダム)");
                Question_List.Items.Add("問題23 | 角度の計算2(ランダム)");
                Question_List.Items.Add("問題24 | 多角形の角度(5問のみ)");
                Question_List.Items.Add("問題25 | 角度の計算3(5問のみ)");
                Question_List.Items.Add("問題26 | 確率1(ランダム)");
                Question_List.Items.Add("問題27 | 確率2(2問のみ)");
                Question_List.Items.Add("問題28 | 体積、表面積の計算(5問のみ)");
                Question_List.Items.Add("問題29 | 確率の和(5問のみ)");
                Question_List.Items.Add("問題30 | 文章の連立方程式(5問のみ)");
            }
            else if (Number == 3)
            {
                Question_List.Items.Add("問題01 | 式の展開1(ランダム)");
                Question_List.Items.Add("問題02 | 式の展開2(ランダム)");
                Question_List.Items.Add("問題03 | 式の展開3(ランダム)");
                Question_List.Items.Add("問題04 | 式の因数分解1(5問のみ)");
                Question_List.Items.Add("問題05 | 式の因数分解2(5問のみ)");
                Question_List.Items.Add("問題06 | 素因数分解(5問のみ)");
                Question_List.Items.Add("問題07 | 平方根(5問のみ)");
                Question_List.Items.Add("問題08 | ルートの大きさ(5問のみ)");
                Question_List.Items.Add("問題09 | ルートの計算1(5問のみ)");
                Question_List.Items.Add("問題10 | ルートの計算2(5問のみ)");
                Question_List.Items.Add("問題11 | 二次方程式1(5問のみ)");
                Question_List.Items.Add("問題12 | 二次方程式2(5問のみ)");
                Question_List.Items.Add("問題13 | 展開1(5問のみ)");
                Question_List.Items.Add("問題14 | 二次方程式3(5問のみ)");
                Question_List.Items.Add("問題15 | 文章題1(5問のみ)");
                Question_List.Items.Add("問題16 | 方程式1(ランダム)");
                Question_List.Items.Add("問題17 | 変化の割合(ランダム)");
                Question_List.Items.Add("問題18 | 相似な図形 長さ(5問のみ)");
                Question_List.Items.Add("問題19 | 相似な図形 面積比(5問のみ)");
                Question_List.Items.Add("問題20 | 図形の角度1(5問のみ)");
                Question_List.Items.Add("問題21 | 図形の角度2(5問のみ)");
                Question_List.Items.Add("問題22 | 三平方の定理1(5問のみ)");
                Question_List.Items.Add("問題23 | 三平方の定理2(5問のみ)");
                Question_List.Items.Add("問題24 | 円錐の高さ(5問のみ)");
                Question_List.Items.Add("問題25 | 因数分解(5問のみ)");
                Question_List.Items.Add("問題26 | 素因数分解(5問のみ)");
                Question_List.Items.Add("問題27 | 値の大きさの比較(5問のみ)");
                Question_List.Items.Add("問題28 | 三平方の定理3(5問のみ)");
                Question_List.Items.Add("問題29 | 相似な図形の面積(5問のみ)");
                Question_List.Items.Add("問題30 | 相似な図形の体積(5問のみ)");
            }
        }
        private void Question_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StreamWriter stw = File.CreateText(Path + "/Resources/Save/Load_Question_Number.dat");
            stw.WriteLine(Question_List.SelectedIndex + 1);
            if (Grade_Num == 1)
            {
                stw.WriteLine(1);
            }
            else if (Grade_Num == 2)
            {
                stw.WriteLine(2);
            }
            else if (Grade_Num == 3)
            {
                stw.WriteLine(3);
            }
            stw.Close();
            Close_Key();
        }
        private void Back_B_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SE_Play(Path + "/Resources/SE/SE_04.wav");
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back_01.png"));
        }
        async void Close_Key()
        {
            if (IsClosing == false)
            {
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
        void SE_Play(string Source)
        {
            SE.controls.stop();
            SE.URL = Source;
            SE.controls.play();
        }
        private void Back_B_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Back_B.Source = new BitmapImage(new Uri(Path + "/Resources/BG/Back.png"));
        }
        private void Back_B_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            File.Delete(Path + "/Resources/Save/Load_Question_Number.dat");
            Close_Key();
        }
    }
}