using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HappyWorkEveryday.MyUserContorls
{
    public sealed partial class MyBackUp : UserControl
    {
        public MyBackUp()
        {
            this.InitializeComponent();
            if (backup.Count > 0)
            {
                foreach (string key in backup.Keys)
                {
                    CreateStackpanel(key, backup[key]);
                }
            }
        }

        List<string> _technology;
        public List<string> technology
        {
            get { return _technology; }

            set
            {
                _technology = value;
                cbtechnology.ItemsSource = _technology;

            }
        }

        private List<string> _alias;
        public List<string> alias
        {
            get { return _alias; }
            set
            {
                _alias = value;
                cbalias.ItemsSource = _alias;

            }
        }

        private int tag = 0;

        private NameValueCollection _backup = new NameValueCollection();
        public NameValueCollection backup
        {
            get { return _backup; }
            set
            {
                _backup = value;

            }
        }

        private void CreateStackpanel(string name, string tech)
        {
            StackPanel sp = new StackPanel();
            sp.Name = "stp"+tag;
            //this.RegisterName("stp" + tag, sp);
            sp.Orientation = Orientation.Horizontal;




            Button btn = new Button();
            btn.Tag = tag.ToString();
            btn.Content = "Remove";
            btn.Click += btn_Click;
            btn.HorizontalAlignment = HorizontalAlignment.Right;



            TextBlock tb1 = new TextBlock();
            tb1.Name = "txb1" + tag;
            //this.RegisterName("txb1" + tag, tb1);
            tb1.Text = name;
            tb1.HorizontalAlignment = HorizontalAlignment.Left;

            TextBlock tb2 = new TextBlock();
            tb2.Name = "txb2" + tag;
            //this.RegisterName("txb2" + tag, tb2);
            tb2.Text = tech;
            tb2.HorizontalAlignment = HorizontalAlignment.Center;

            sp.Children.Add(tb1);
            sp.Children.Add(tb2);
            sp.Children.Add(btn);

            stackpanel.Children.Add(sp);
            tag++;
        }

        void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string _tag = btn.Tag.ToString();
            StackPanel stp = stackpanel.FindName("stp" + _tag) as StackPanel;
            TextBlock tb1 = stackpanel.FindName("txb1" + _tag) as TextBlock;
            TextBlock tb2 = stackpanel.FindName("txb2" + _tag) as TextBlock;
            stackpanel.Children.Remove(stp);

            DeleteValue(tb1.Text, tb2.Text);
        }

        private void DeleteValue(string key, string value)
        {
            string[] values = _backup.GetValues(key);
            List<string> ls = new List<string>();
            foreach (string item in values)
            {
                if (item != value)
                {
                    ls.Add(item);
                }
            }
            _backup.Remove(key);
            if (ls.Count > 0)
            {
                foreach (string i in ls)
                {
                    _backup.Add(key, i);
                }
            }
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            if (cbalias.SelectedItem == null || cbtechnology.SelectedItem == null)
            {
                await new MessageDialog("Alias or Technology UnSelected").ShowAsync();
                return;
            }
            else
            {
                string name = cbalias.SelectedItem.ToString();
                string tech = cbtechnology.SelectedItem.ToString();
                CreateStackpanel(name, tech);
                _backup.Add(name, tech);
            }
        }
    }
}
