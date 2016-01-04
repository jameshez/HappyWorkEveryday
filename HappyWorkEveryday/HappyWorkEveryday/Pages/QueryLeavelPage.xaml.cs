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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HappyWorkEveryday.Pages
{
  
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QueryLeavelPage : Page
    {

        public QueryLeavelPage()
        {
            this.InitializeComponent();
            
        }

        private void MyPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(MyPivot.SelectedIndex==0)
            {
                MyTextBlockAnnual.Opacity = 0.5;
                MyTextBlockFlexible.Opacity = 1;
            }
           else if (MyPivot.SelectedIndex == 1)
            {
               MyTextBlockFlexible.Opacity = 0.5;
                MyTextBlockAnnual.Opacity = 1;
            }
        }
    }
}
