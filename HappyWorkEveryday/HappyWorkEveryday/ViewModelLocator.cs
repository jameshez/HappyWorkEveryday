using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyWorkEveryday.ViewModel;
using HappyWorkEveryday.Pages;
using System.Diagnostics;

namespace HappyWorkEveryday
{
    class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<AskforLeaveViewModel>();

            Debug.WriteLine("AskforLeaveViewModel registered at {0}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff"));
        }

        public static AskforLeaveViewModel _AskForLeavePage;
        public static AskforLeaveViewModel AskForLeavePage
        {
            get
            {
                if (_AskForLeavePage == null)
                    _AskForLeavePage = ServiceLocator.Current.GetInstance<AskforLeaveViewModel>();

                Debug.WriteLine("AskforLeaveViewModel initialized at {0}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ffff"));
                return _AskForLeavePage;
            }
        }
    }
}
