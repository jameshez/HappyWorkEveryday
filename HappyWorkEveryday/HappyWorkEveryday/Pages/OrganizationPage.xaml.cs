using HappyWorkEveryday.Helper;
using HappyWorkEveryday.MSDNUserServiceReference;
using HappyWorkEveryday.OrganizationService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class OrganizationPage : Page
    {
        public OrganizationPage()
        {
            this.InitializeComponent();
            //something();
            

        }

        //ObservableCollection<OrganizationPageModel> a = new ObservableCollection<OrganizationPageModel>();

        //public async void something()
        //{
        //    //var a = await MSDNUser_Client.FindAllAsync();
        //    var a = await ServiceFactory.Orginzation.FindOrganizationRelationshipAsync();



        //    var t = from p in a
        //            group p by p.TeamName into g
        //            select g;

        //    item.ItemsSource = t;
        //}
    }
}
