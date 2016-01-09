using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HappyWorkEveryday.MyUserContorls
{
    public sealed partial class TextboxImageUserControl :UserControl
    { 
        public TextboxImageUserControl()
        {
            this.InitializeComponent();
            
        }

        #region Barry Property System
        private string _dateflyoutvalue;
        public string StartDateFlyoutValue
        {
            get { return _dateflyoutvalue; }
            set { value = _dateflyoutvalue; }
        }
        #endregion
        public string TextBoxDateText
        {
            get { return (string)GetValue(TextBoxDateTextProperty); }
            set { SetValue(TextBoxDateTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxDateTextProperty =
            DependencyProperty.Register("TextBoxDateText", typeof(string), typeof(TextboxImageUserControl), new PropertyMetadata(0));

        public string TextBoxTimeText
        {
            get { return (string)GetValue(TextBoxTimeTextProperty); }
            set { SetValue(TextBoxTimeTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxTimeTextProperty =
            DependencyProperty.Register("TextBoxText", typeof(string), typeof(TextboxImageUserControl), new PropertyMetadata(0));


        public double MyWidth
        {
            get { return (double)GetValue(MyWidthProperty); }
            set { SetValue(MyWidthProperty, value);
                MyTextBox.Width = MyWidth;
            }

        }

        // Using a DependencyProperty as the backing store for MyWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyWidthProperty =
            DependencyProperty.Register("MyWidth", typeof(int), typeof(TextboxImageUserControl), new PropertyMetadata(0));



        public Uri MyImageSoruce
        {
            get {
                
                return (Uri)GetValue(MyImageSoruceProperty);

                 }
            set { SetValue(MyImageSoruceProperty, value);
                MyImage.Source = new BitmapImage(MyImageSoruce);
            }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyImageSoruceProperty =
            DependencyProperty.Register("MyImageSoruce", typeof(Uri), typeof(TextboxImageUserControl), new PropertyMetadata(0));

        private void MyImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Uri test = new Uri("ms-appx:///Image/calendar-icon.png");
            Uri test1 = new Uri("ms-appx:///Image/Time-icon.png");
            if (MyImageSoruce.Equals(test))
            {
                DatePickerFlyout myflyout = Resources["MyDatePickFlyout"] as DatePickerFlyout;
                myflyout.ShowAt(MyImage);
                PlaneProjection PlaneProjection = new PlaneProjection();
                PlaneProjection.GlobalOffsetZ = 150;
                MyImage.Projection = PlaneProjection;
            }
            else if(MyImageSoruce.Equals(test1))
            {
                TimePickerFlyout myflyout = Resources["MyTimePickFlyout"] as TimePickerFlyout;
                myflyout.ShowAt(MyImage);
                PlaneProjection PlaneProjection = new PlaneProjection();
                PlaneProjection.GlobalOffsetZ = 150;
                MyImage.Projection = PlaneProjection;

            }

        }

        private void DatePickerFlyout_DatePicked(DatePickerFlyout sender, DatePickedEventArgs args)
        {
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            MyImage.Projection = PlaneProjection;
            _dateflyoutvalue = (sender as DatePickerFlyout).Date.DateTime.ToString("yyyy-MM-dd");
            MyTextBox.Text = _dateflyoutvalue;
            MyTextBox.Foreground = new SolidColorBrush(Colors.Red);
            MyTextBox.FontSize = 15;
            TextBoxDateText = MyTextBox.Text;

        }

        private void DatePickerFlyout_Closed(object sender, object e)
        {
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            MyImage.Projection = PlaneProjection;

        }

        private void TimePickerFlyout_TimePicked(TimePickerFlyout sender, TimePickedEventArgs args)
        {
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            MyImage.Projection = PlaneProjection;
            MyTextBox.Text = (sender as TimePickerFlyout).Time.ToString();
            MyTextBox.Foreground = new SolidColorBrush(Colors.Red);
            MyTextBox.FontSize = 15;
            TextBoxTimeText = MyTextBox.Text;
        }

        private void TimePickerFlyout_Closed(object sender, object e)
        {
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            MyImage.Projection = PlaneProjection;
        }
    }
}
