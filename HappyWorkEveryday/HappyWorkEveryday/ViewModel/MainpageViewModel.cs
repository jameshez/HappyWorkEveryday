﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HappyWorkEveryday.ViewModel
{
    class MainpageViewModel:ViewModelBase
    {

        public MainpageViewModel()
        {
            NavigateCommand = new RelayCommand(
                ShowPopUpExecute, () => true
                );
        }

        public ICommand NavigateCommand
        {
            get; private set;
        }

        private async void ShowPopUpExecute()
        {

            var dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                MessageDialog a = new MessageDialog("asdasdasda");
                await a.ShowAsync();

                Frame rootFrame = Window.Current.Content as Frame;
                rootFrame.Navigate(typeof(AskForLeavelPage));
            });
        }
    }
}
