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
using HappyWorkEveryday.Helper;
using System.Diagnostics;
using Windows.UI;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HappyWorkEveryday
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            ///testing
            test();
        }

        public async void test()
        {
            var k = await LocalInformationHelper.getCurrentUserName();
            if (k.Item1 == true)
            {
                Debug.WriteLine(k.Item2);
            }
            else
            {
                Debug.WriteLine(k.Item2);
            }
        }

        private void StackPanel_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            StackPanel1.BorderBrush = new SolidColorBrush(Colors.Aqua);
            StackPanel1.BorderThickness = new Thickness(2);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 30;
            StackPanel1.Projection = PlaneProjection;
        }

        private void StackPanel1_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            StackPanel1.BorderThickness = new Thickness(0);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            StackPanel1.Projection = PlaneProjection;
        }

        private void StackPanel2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            StackPanel2.BorderBrush = new SolidColorBrush(Colors.Aqua);
            StackPanel2.BorderThickness = new Thickness(2);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 30;
            StackPanel2.Projection = PlaneProjection;
        }

        private void StackPanel2_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            StackPanel2.BorderThickness = new Thickness(0);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            StackPanel2.Projection = PlaneProjection;
        }

        private void StackPanel3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            StackPanel3.BorderBrush = new SolidColorBrush(Colors.Aqua);
            StackPanel3.BorderThickness = new Thickness(2);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 30;
            StackPanel3.Projection = PlaneProjection;
        }

        private void StackPanel3_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            StackPanel3.BorderThickness = new Thickness(0);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            StackPanel3.Projection = PlaneProjection;
        }

        private void StackPanel4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            StackPanel4.BorderBrush = new SolidColorBrush(Colors.Aqua);
            StackPanel4.BorderThickness = new Thickness(2);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 30;
            StackPanel4.Projection = PlaneProjection;
        }

        private void StackPanel4_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            StackPanel4.BorderThickness = new Thickness(0);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            StackPanel4.Projection = PlaneProjection;
        }
    }
}
