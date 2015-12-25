using HappyWorkEveryday.MSDNUserServiceReference;
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
            something();
            

        }


        MSDNUserServiceClient MSDNUser_Client = new MSDNUserServiceClient();

        ObservableCollection<Tb_MSDNUser> a = new ObservableCollection<Tb_MSDNUser>();

        public async void something()
        {
            //var a = await MSDNUser_Client.FindAllAsync();

            a.Add(new Tb_MSDNUser() { Alias = "UWP", Id = 1, Name = "Fang" });
            a.Add(new Tb_MSDNUser() { Alias = "UWP", Id = 2, Name = "James" });
            a.Add(new Tb_MSDNUser() { Alias = "F&D", Id = 2, Name = "Barry" });
            a.Add(new Tb_MSDNUser() { Alias = "F&D", Id = 1, Name = "Dongwei" });
            a.Add(new Tb_MSDNUser() { Alias = "JJKS", Id = 1, Name = "Minxing" });


            var t = from p in a
                    group p by p.Alias into g
                    select g;

            item.ItemsSource = t;
        }
    }
}
