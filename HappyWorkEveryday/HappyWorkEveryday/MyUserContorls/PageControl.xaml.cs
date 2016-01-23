using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HappyWorkEveryday.MyUserContorls
{
    public delegate void ItemSourceChangedEventHandler(SourceChangedEventArges e);
    public sealed partial class PageControl : UserControl
    {
        public PageControl()
        {
            this.InitializeComponent();
        }

        public ObservableCollection<object> OriginalItemSource
        {
            get { return (ObservableCollection<object>)GetValue(OriginalItemSourceProperty); }
            set
            {
                SetValue(OriginalItemSourceProperty, value);

            }
        }

        // Using a DependencyProperty as the backing store for OriginalItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OriginalItemSourceProperty =
            DependencyProperty.Register("OriginalItemSource", typeof(ObservableCollection<object>), typeof(PageControl), new PropertyMetadata(new ObservableCollection<object>(), OnOriginalSourceChanged));

        private static void OnOriginalSourceChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ((PageControl)o).Filter();
            ((PageControl)o).ShowCurrentPageIndex();
        }


        public ObservableCollection<object> ItemSource
        {
            get { return (ObservableCollection<object>)GetValue(ItemSourceProperty); }
            set
            {
                SetValue(ItemSourceProperty, value);
                
            }
        }

        // Using a DependencyProperty as the backing store for ItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register("ItemSource", typeof(ObservableCollection<object>), typeof(PageControl), new PropertyMetadata(null));

        /// <summary>
        /// 当前页码
        /// </summary>
        public int currentPageIndex
        {
            get { return (int)GetValue(currentPageIndexProperty); }
            set
            {
                SetValue(currentPageIndexProperty, value);
                
            }
        }

        // Using a DependencyProperty as the backing store for currentPageIndex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty currentPageIndexProperty =
            DependencyProperty.Register("currentPageIndex", typeof(int), typeof(PageControl), new PropertyMetadata(0));

        /// <summary>
        /// 每页显示的数量
        /// </summary>
        public int itemPerPage
        {
            get { return (int)GetValue(itemPerPageProperty); }
            set
            {
                SetValue(itemPerPageProperty, value);
                
            }
        }

        // Using a DependencyProperty as the backing store for itemPerPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty itemPerPageProperty =
            DependencyProperty.Register("itemPerPage", typeof(int), typeof(PageControl), new PropertyMetadata(0));





        private int totalPage = 0;

        

        public event ItemSourceChangedEventHandler SourceChanged;

        private void HandleSourceChanged(SourceChangedEventArges e)
        {
            if (SourceChanged != null)
            {
                SourceChanged(e);
            }
        }

        private void ShowCurrentPageIndex()
        {
            this.tbCurrentPage.Text = (currentPageIndex + 1).ToString();
        }

        void Filter()
        {
            ObservableCollection<object> filtered = new ObservableCollection<object>();
            foreach (var item in OriginalItemSource)
            {
                int index = OriginalItemSource.IndexOf(item);

                if (index >= itemPerPage * currentPageIndex && index < itemPerPage * (currentPageIndex + 1))
                {
                    filtered.Add(item);
                }
            }
            SourceChangedEventArges e = new SourceChangedEventArges(filtered);
            HandleSourceChanged(e);
            this.ItemSource = filtered;


            if (string.IsNullOrEmpty(tbTotalPage.Text)||tbTotalPage.Text == "0")
            {
                int itemscount = OriginalItemSource.Count;
                totalPage = itemscount / itemPerPage;
                if (itemscount % itemPerPage != 0)
                {
                    totalPage += 1;
                }

                this.tbTotalPage.Text = totalPage.ToString();
            }

        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            // Display the first page 
            if (currentPageIndex != 0)
            {
                currentPageIndex = 0;
                Filter();
            }
            ShowCurrentPageIndex();
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            // Display previous page 
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                Filter();
            }
            ShowCurrentPageIndex();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            // Display next page 
            if (currentPageIndex < totalPage - 1)
            {
                currentPageIndex++;
                Filter();
            }
            ShowCurrentPageIndex();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            // Display the last page 
            if (currentPageIndex != totalPage - 1)
            {
                currentPageIndex = totalPage - 1;
                Filter();
            }
            ShowCurrentPageIndex();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            int itemscount = OriginalItemSource.Count;
            totalPage = itemscount / itemPerPage;
            if (itemscount % itemPerPage != 0)
            {
                totalPage += 1;
            }
            ShowCurrentPageIndex();
            this.tbTotalPage.Text = totalPage.ToString();
            Filter();
        }

    }

    public class SourceChangedEventArges : EventArgs
    {
        public ObservableCollection<object> ItemSource { get; set; }

        public SourceChangedEventArges(ObservableCollection<object> e)
        {
            this.ItemSource = e;
        }
    }
}
