using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HappyWorkEveryday.ViewModel
{
    class MainpageViewModel:ViewModelBase
    {

        public MainpageViewModel()
        {
            NavigateCommand = new RelayCommand(() => ShowPopUpExecute(), () => true);
        }

        public ICommand NavigateCommand
        {
            get; private set;
        }

        private void ShowPopUpExecute()
        {
            //MessageBox.Show("Hello!");
            //Dispatcher
        }
    }
}
