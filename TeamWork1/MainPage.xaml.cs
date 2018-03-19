using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace TeamWork1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public Brush Green { get; private set; }
        public Brush Gray { get; private set; }
        public Visibility Visible { get; private set; }

        //tang's contribution
        private void tangRadio_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)tangRadio.IsChecked)
            {
                tangText.Text = "Tang Hao add a contribution.";
            }
        }

        private void ltoSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            ltoBorder.Width = e.NewValue * 3;
        }


        //wong_contribution
        private void wong_toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            wong_image.Height = 100;
            wong_image.Width = 100;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hou_Panal.Visibility = Visible;
        }
    }
}
