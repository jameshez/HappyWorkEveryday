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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HappyWorkEveryday
{
    public sealed partial class BackUPUserControl :UserControl
    {
        public Dictionary<string, string> dict { get; set; }
        public BackUPUserControl()
        {
            this.InitializeComponent();
            
            
        }    

       
        public string BackUpTextBoxValue
        {
            get { return (string)GetValue(BackUpTextBoxValueProperty); }
            set { SetValue(BackUpTextBoxValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackUpTextBoxValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackUpTextBoxValueProperty =
            DependencyProperty.Register("BackUpTextBoxValue", typeof(string), typeof(BackUPUserControl), new PropertyMetadata(0));
        public string ForumsTextBoxValue
        {
            get { return (string)GetValue(ForumsTextBoxValueProperty); }
            set { SetValue(ForumsTextBoxValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackUpTextBoxValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ForumsTextBoxValueProperty =
            DependencyProperty.Register("ForumsTextBoxValue", typeof(string), typeof(BackUPUserControl), new PropertyMetadata(0));


       
        private void MyBackUPComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BackUpTextBoxValue = BackupTextBox.Text.ToString();
           
            
        }

        private void MyForumsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ForumsTextBoxValue = ForumsTextBox.Text;
            if(MyBackUPComboBox.SelectedIndex==-1)
            {


            }
            else
            {
                dict = new Dictionary<string, string>();
                dict.Add(BackUpTextBoxValue, ForumsTextBoxValue);
            }
        }


        private void MyBackupImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Flyout myflyout = Resources["MyBackUPFlyOut"] as Flyout;
            myflyout.ShowAt(MyBackupImage);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 150;
            MyBackupImage.Projection = PlaneProjection;
        }

        private void MyForumsImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Flyout myflyout = Resources["MyForumsFlyOut"] as Flyout;
            myflyout.ShowAt(MyForumsImage);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 150;
            MyForumsImage.Projection = PlaneProjection;
        }
    }
}
