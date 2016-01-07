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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HappyWorkEveryday.MyUserContorls
{
    public sealed partial class TextboxImageUserControl :TextBox
    {
        public TextboxImageUserControl()
        {
            this.InitializeComponent();
        }



        public ImageSource MyImageSoruce
        {
            get { return (ImageSource)GetValue(MyImageSoruceProperty); }
            set { SetValue(MyImageSoruceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyImageSoruceProperty =
            DependencyProperty.Register("MyImageSoruce", typeof(ImageSource), typeof(TextboxImageUserControl), new PropertyMetadata(0));


    }
}
