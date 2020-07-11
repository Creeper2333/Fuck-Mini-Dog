using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using MoveWindow;
using System.Security.Cryptography;
using System;
using System.Windows.Shapes;

namespace EggMan
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Process p = new Process();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(playSound);
            System.Drawing.Rectangle r = System.Windows.Forms.Screen.GetWorkingArea(new System.Drawing.Point(0,0));
            double width = r.Width;
            double height = r.Height;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Egg egg = new Egg();
                    egg.Left = width / 3 * j;
                    egg.Top = height / 3 * i;
                    egg.Show();
                }
                
            }
                
            t.Start();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer(System.Environment.CurrentDirectory + "\\audio\\shutdown.wav");
            s.PlaySync();
            s.Dispose();
            Application.Current.Shutdown();
        }
        public void playSound()
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer(System.Environment.CurrentDirectory + "\\audio\\startup.wav");
            s.PlaySync();
            s.Dispose();
        }

        
    }
}
