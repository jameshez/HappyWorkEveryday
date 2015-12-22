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
using HappyWorkEveryday.ViewModel;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HappyWorkEveryday
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MainpageViewModel a = new MainpageViewModel();
        public MainPage()
        {
            this.InitializeComponent();
            AskforLeaveViewModel vm = new AskforLeaveViewModel();


            this.DataContext = a;
            ///testing
            //test();
        }

        //public async void test()
        //{
        //    AskforLeaveViewModel testmodel = new AskforLeaveViewModel();


        //    var k = await LocalInformationHelper.getCurrentUserName();
        //    if (k.Item1 == true)
        //    {
        //        Debug.WriteLine(k.Item2);
        //    }
        //    else
        //    {
        //        Debug.WriteLine(k.Item2);
        //    }
        //}

        private void AskForLeavelStackPanel_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            AskForLeavelStackPanel.BorderBrush = new SolidColorBrush(Colors.Aqua);
            AskForLeavelStackPanel.BorderThickness = new Thickness(2);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 30;
            AskForLeavelStackPanel.Projection = PlaneProjection;
        }

        private void AskForLeavelStackPanel_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            AskForLeavelStackPanel.BorderThickness = new Thickness(0);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            AskForLeavelStackPanel.Projection = PlaneProjection;
        }

        private void QueryLeavelStackPanel_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            QueryLeavelStackPanel.BorderBrush = new SolidColorBrush(Colors.Aqua);
            QueryLeavelStackPanel.BorderThickness = new Thickness(2);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 30;
            QueryLeavelStackPanel.Projection = PlaneProjection;
        }

        private void QueryLeavelStackPanel_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            QueryLeavelStackPanel.BorderThickness = new Thickness(0);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            QueryLeavelStackPanel.Projection = PlaneProjection;
        }

        private void LeavelRecordsStackPanel_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            LeavelRecordsStackPanel.BorderBrush = new SolidColorBrush(Colors.Aqua);
            LeavelRecordsStackPanel.BorderThickness = new Thickness(2);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 30;
            LeavelRecordsStackPanel.Projection = PlaneProjection;
        }

        private void LeavelRecordsStackPanel_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            LeavelRecordsStackPanel.BorderThickness = new Thickness(0);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            LeavelRecordsStackPanel.Projection = PlaneProjection;
        }

        private void OrganizationStackPanel_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            OrganizationStackPanel.BorderBrush = new SolidColorBrush(Colors.Aqua);
            OrganizationStackPanel.BorderThickness = new Thickness(2);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 30;
            OrganizationStackPanel.Projection = PlaneProjection;
        }

        private void OrganizationStackPanel_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            OrganizationStackPanel.BorderThickness = new Thickness(0);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            OrganizationStackPanel.Projection = PlaneProjection;
        }

        private void AskForLeavelStackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(AskForLeavelPage));
        }
    }
}
