using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HappyWorkEveryday.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public class SpltViewItemTest
    {
        public string Button { get; set; }
        public string Text { get; set; }
    }

    public sealed partial class SplitViewPage : Page
    {
        ObservableCollection<SpltViewItemTest> SpltViewItemTestList = null; //define m_function_items

        public SplitViewPage()
        {
            this.InitializeComponent();
            SpltViewItemTestList = new ObservableCollection<SpltViewItemTest>();
            MyListViewPanel.ItemsSource = SpltViewItemTestList;
          


        }

       

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
                    
            SpltViewItemTestList.Add(new SpltViewItemTest { Button = "\uE8D6", Text = "AskForLeavel" });
            SpltViewItemTestList.Add(new SpltViewItemTest { Button = "\uE11A", Text = "QueryLeavel" });
            SpltViewItemTestList.Add(new SpltViewItemTest { Button = "\uE90B", Text = "LeavelRecords" });
            SpltViewItemTestList.Add(new SpltViewItemTest { Button = "\uE710", Text = "Organization" });

            MyListViewPanel.SelectedIndex = Convert.ToInt32(e.Parameter);
            

        }

        private void PanelOpenButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            int count = 0;
            if (this.RootSpiltView.IsPaneOpen == true)
            {
                foreach (SpltViewItemTest test in SpltViewItemTestList)
                {
                    if (test.Button.Equals("\uE72B"))
                    {
                        count = count + 1;
                    }
                }
                if (count == 0)

                {
                    SpltViewItemTestList.Add(new SpltViewItemTest { Button = "\uE72B", Text = "" });
                    MyListViewPanel.ItemsSource = SpltViewItemTestList;
                }

                CopyrightTextBlock.Visibility = Visibility.Collapsed;

            }

            else
            {
                for(int i=0;i<SpltViewItemTestList.Count;i++)
                {
                    if (SpltViewItemTestList[i].Button.Equals("\uE72B"))
                    {
                        SpltViewItemTestList.Remove(SpltViewItemTestList[i]);
                    }                  
                    
                }
                MyListViewPanel.ItemsSource = SpltViewItemTestList;

            }

            this.RootSpiltView.IsPaneOpen = !this.RootSpiltView.IsPaneOpen; //pane open or close
        }

        private void MyListViewPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

            if (MyListViewPanel.SelectedIndex==0)
            {              
                frame.Navigate(typeof(Pages.AskForLeavePage));
            
            }
           else if (MyListViewPanel.SelectedIndex == 1)
            {
                frame.Navigate(typeof(Pages.QueryLeavelPage));
            }
          else if (MyListViewPanel.SelectedIndex == 2)
            {
                frame.Navigate(typeof(Pages.LeavelRecordsPage));
            }
          else if (MyListViewPanel.SelectedIndex == 3)
            {
                frame.Navigate(typeof(Pages.OrganizationPage));
            }
            else if (MyListViewPanel.SelectedIndex == 4)
            {
                this.Frame.Navigate(typeof(MainPage));
            }
          
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
