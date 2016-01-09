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

            List<string> alias = new List<string>();
            alias.Add("v-doxie");
            alias.Add("v-barryw");
            alias.Add("v-james");

            List<string> technology = new List<string>();
            technology.Add("WPF");
            technology.Add("UWP");
            technology.Add("VB.NET");

            uc.alias = alias;
            uc.technology = technology;
        }
        
    }
}
