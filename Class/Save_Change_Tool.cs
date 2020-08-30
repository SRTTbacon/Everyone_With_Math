using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows;

namespace Everyone_With_Math
{
    public partial class Home_Window : Window
    {
        //ツールがあれば起動し、なければダウンロードさせる(確認メッセージあり)
        //ダウンロード先 = Path + "/Resources/Save_Tool_Change/"
        //exeファイルを移動させるとうまく動作しません。
        WebClient wc;
        private void Save_Change_Tool_Download_B_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(Path + "/Resources/Save_Tool_Change/Everyone_With_Math_Save.exe"))
            {
                StreamWriter stw = File.CreateText(Path + "/Resources/Save_Change_Permission.dat");
                stw.WriteLine("This file allows save changes...");
                stw.Close();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = Path + "/Resources/Save_Tool_Change/Everyone_With_Math_Save.exe",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = Process.Start(startInfo);
            }
            else
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("ファイルが存在しません。ダウンロードしますか？。\nファイル容量:16kb", "確認", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                    {
                        Directory.CreateDirectory(Path + "/Resources/Save_Tool_Change");
                        Uri uri = new Uri("https://www.dropbox.com/s/na8ofg6tnsz1kp8/Everyone_With_Math_Save.exe?dl=1");
                        if (wc == null)
                        {
                            wc = new WebClient();
                            wc.DownloadFileCompleted += delegate
                            {
                                try
                                {
                                    StreamWriter stw = File.CreateText(Path + "/Resources/Save_Change_Permission.dat");
                                    stw.WriteLine("This file allows save changes...");
                                    stw.Close();
                                    ProcessStartInfo startInfo = new ProcessStartInfo
                                    {
                                        FileName = Path + "/Resources/Save_Tool_Change/Everyone_With_Math_Save.exe",
                                        UseShellExecute = false,
                                        CreateNoWindow = true
                                    };
                                    Process process = Process.Start(startInfo);
                                }
                                catch (Exception d)
                                {
                                    MessageBox.Show("エラー:" + d.Message);
                                }
                            };
                        }
                        wc.DownloadFileAsync(uri, Path + "/Resources/Save_Tool_Change/Everyone_With_Math_Save.exe");
                    }
                    else
                    {
                        MessageBox.Show("インターネットに接続されていないためダウンロードできませんでした。");
                    }
                }
            }
        }
    }
}