using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
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

        public Color HexToColor(string hexColor)
        {
            //remove #
            hexColor = hexColor.Replace("#", "");
            int r = 0;
            int g = 0;
            int b = 0;
            int a = 255;

            if (hexColor.Length == 8)
            {
                //#AARRGGBB
                a = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                r = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                g = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
                b = int.Parse(hexColor.Substring(6, 2), NumberStyles.AllowHexSpecifier);
            }
            else if (hexColor.Length == 6)
            {
                //#RRGGBB
                r = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                g = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                b = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
            }
            return Color.FromArgb(Convert.ToByte(a), Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)); 
        }


        private void CreateStackpanel(string name, string tech)
        {
            StackPanel sp = new StackPanel();
            sp.Name = "stp"+tag;
            //this.RegisterName("stp" + tag, sp);
            sp.Orientation = Orientation.Horizontal;




            Image btn = new Image();
            btn.Tag = tag.ToString();
            btn.Source = new BitmapImage(new Uri("ms-appx:///Image/minus_button.png"));
            btn.Tapped += btn_Click;
            btn.Width = 30;
            btn.Height = 30;
            btn.HorizontalAlignment = HorizontalAlignment.Right;


            Border test = new Border();
            test.CornerRadius =new CornerRadius(10);
            test.BorderThickness = new Thickness(2);
            test.BorderBrush = new SolidColorBrush(HexToColor("#FF0A9DE2"));
            test.Background = new SolidColorBrush(HexToColor("#FFB8F2FF"));
            TextBlock tb1 = new TextBlock();
            test.Width = 150;
            
            tb1.Name = "txb1" + tag;
            //this.RegisterName("txb1" + tag, tb1);
            tb1.Text = name;
            tb1.HorizontalAlignment = HorizontalAlignment.Left;
            test.Child = tb1;
            TextBlock testbx = new TextBlock();
            testbx.Width = 150;
            test.Height = 30;

            Border test1 = new Border();
            test1.CornerRadius = new CornerRadius(10);
            test1.BorderThickness = new Thickness(2);
            test1.BorderBrush = new SolidColorBrush(HexToColor("#FF0A9DE2"));
            test1.Background = new SolidColorBrush(HexToColor("#FFB8F2FF"));
            test1.Width = 150;
            test1.Height = 30;
            TextBlock tb2 = new TextBlock();
            tb2.Name = "txb2" + tag;
            //this.RegisterName("txb2" + tag, tb2);
            tb2.Text = tech;
            tb2.HorizontalAlignment = HorizontalAlignment.Left;

            test1.Child = tb2;
            TextBlock testbx1 = new TextBlock();
            testbx1.Width = 100;
            sp.Children.Add(test);
            sp.Children.Add(testbx);
            sp.Children.Add(testbx1);
            sp.Children.Add(test1);
            sp.Children.Add(btn);
            sp.Height = 35;
            stackpanel.Children.Add(sp);
            tag++;
        }

        void btn_Click(object sender, RoutedEventArgs e)
        {
            Image btn = sender as Image;
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
            if (values != null)
            {
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
          
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            MyTextBlock.Visibility = Visibility.Visible;
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
