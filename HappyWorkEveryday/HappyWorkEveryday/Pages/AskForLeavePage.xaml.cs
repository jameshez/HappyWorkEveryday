using HappyWorkEveryday.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HappyWorkEveryday.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AskForLeavePage : Page
    {
        public AskForLeavePage()
        {
            this.InitializeComponent();
           
            Debug.WriteLine("AskForLeavePage initialized at {0}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff"));
            //this.DataContext = new AskforLeaveViewModel();
        }
        static int count;
        StackPanel TestPanel;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestPanel = new StackPanel();
            TestPanel.Name = "MyPanel" + count;
            TestPanel.Orientation = Orientation.Horizontal;
            BackUPUserControl test = new BackUPUserControl();
            Image mybutton = new Image();
            mybutton.Name = count.ToString(); ;
            mybutton.Height = 30;
            mybutton.Width = 30;
            mybutton.Tapped += Mybutton_Click;
            mybutton.Source = new BitmapImage(new Uri("ms-appx:///Image/minus_button.png"));
            TestPanel.Children.Add(test);
            TestPanel.Children.Add(mybutton);
            BackupStackPanel.Children.Add(TestPanel);
            count++;

        }

        private void Mybutton_Click(object sender, RoutedEventArgs e)
        {
            Image testButton = sender as Image;
            string name = "MyPanel" + testButton.Name;
            StackPanel test = BackupStackPanel.FindName(name) as StackPanel;
            BackupStackPanel.Children.Remove(test);
                     
        }

        private void CancleButton_Click(object sender, RoutedEventArgs e)
        {
            BackupStackPanel.Children.Remove(BackupStackPanelFirst);
        }

       




        //private void ForOthersRadioButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (ForOthersRadioButton.IsChecked == true)
        //    {
        //        Flyout MyFlyout = Resources["MyFlyout"] as Flyout;
        //        MyFlyout.ShowAt(ForOthersRadioButton);
        //    }
        //}
    }
}
