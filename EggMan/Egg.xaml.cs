using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EggMan
{
    /// <summary>
    /// Egg.xaml 的交互逻辑
    /// </summary>
    public partial class Egg : Window
    {
        public Egg()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.ImageBrush i =new System.Windows.Media.ImageBrush(new System.Windows.Media.Imaging.BitmapImage(
                new System.Uri("egg.png", System.UriKind.RelativeOrAbsolute)));
            i.Stretch = Stretch.UniformToFill;
            i.TileMode = TileMode.None;
            Background = i;
        }
    }
}
