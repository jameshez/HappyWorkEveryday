using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace HappyWorkEveryday.ViewModel
{
    class MainpageViewModel:ViewModelBase
    {
        Grid root;

        public MainpageViewModel(Grid root)
        {
            NavigateCommand = new RelayCommand<object>(
                (s) => ShowPopUpExecute(s)
                );

            PointerEnterCommand = new RelayCommand<object>(
                (s) => ExecutePointerEnter(s)
                );

            PointerExistCommand = new RelayCommand<object>(
                 (s) => ExecutePointExist(s)
                );
            this.root = root;
        }

        

        public RelayCommand<object> NavigateCommand
        {
            get; private set;
        }

        public RelayCommand<object> PointerEnterCommand
        {
            get; private set;
        }
        public RelayCommand<object> PointerExistCommand
        {
            get; private set;
        }
        

        private async void ShowPopUpExecute(object s)
        {

            var dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Frame rootFrame = Window.Current.Content as Frame;
                rootFrame.Navigate(typeof(Pages.SplitViewPage),s);
            });
        }

        private void ExecutePointerEnter(object s)
        {
            var a = root.FindName(s.ToString()) as StackPanel;
            a.BorderBrush = new SolidColorBrush(Colors.Aqua);
            a.BorderThickness = new Thickness(2);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 30;
            a.Projection = PlaneProjection;
        }
        private void ExecutePointExist(object s)
        {
            var a = root.FindName(s.ToString()) as StackPanel;

            a.BorderThickness = new Thickness(0);
            PlaneProjection PlaneProjection = new PlaneProjection();
            PlaneProjection.GlobalOffsetZ = 0;
            a.Projection = PlaneProjection;
        }
    }
}
