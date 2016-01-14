using HappyWorkEveryday.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
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
    public sealed partial class AskForLeavePage : Page, INotifyPropertyChanged
    {
        public AskForLeavePage()
        {
            this.InitializeComponent();
            List<string> test = new List<string>() { "test1", "tersty" };
            List<string> test1 = new List<string>() { "test1", "tersty" };
            uc.alias = test;
            uc.technology = test1;
            this.SizeChanged += AskForLeavePage_SizeChanged;
            this.DataContext = this;
            this.Loaded += AskForLeavePage_Loaded;


        }

        private void AskForLeavePage_Loaded(object sender, RoutedEventArgs e)
        {
            MyWidthProperty = Window.Current.Bounds.Width;
        }

        private void AskForLeavePage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MyWidthProperty = Window.Current.Bounds.Width;
           

        }

      

        public double MyWidthProperty
        {
            get { return (double)GetValue(MyWidthPropertyProperty); }
            set { SetValue(MyWidthPropertyProperty, value);
                NotifyPropertyChanged("MyWidthProperty");

            }
        }

        // Using a DependencyProperty as the backing store for MyWidthProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyWidthPropertyProperty =
            DependencyProperty.Register("MyWidthProperty", typeof(double), typeof(AskForLeavePage), new PropertyMetadata(0));

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
