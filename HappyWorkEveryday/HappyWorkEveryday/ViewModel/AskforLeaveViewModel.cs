using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HappyWorkEveryday.Model;
using HappyWorkEveryday.UserServiceReference;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using HappyWorkEveryday.Helper;
using Windows.UI.Popups;

namespace HappyWorkEveryday.ViewModel
{


    public class AskforLeaveViewModel: ViewModelBase
    {

        private bool isFlyoutOpen;
        public bool IsFlyoutOpen
        {
            get { return isFlyoutOpen; }
            set {
                isFlyoutOpen = value;
                RaisePropertyChanged("IsFlyoutOpen");
            }
        }


        public RelayCommand<object> OpenCommand { get; set; }
        public RelayCommand CloseCommand { get; set; }

        UserServiceClient client = new UserServiceClient();
        public  AskforLeaveViewModel()
        {
            OpenCommand = new RelayCommand<object>((x)=> {
                RadioButton rb = (RadioButton)x;
                Flyout flyout = rb.FindName("fly") as Flyout;
                flyout.ShowAt(rb);
            });
            CloseCommand = new RelayCommand(() => IsFlyoutOpen = false);


            loaddata();
        }

        

        public RelayCommand ShowUserCommand
        {
            get; private set;
        }

        private async void PopupUser()
        {
           
        }


        private async void loaddata()
        {
            usergroup = await client.FindAllAsync();

            var s = usergroup.ToList();
        }
        //Implement the interface
        //public event PropertyChangedEventHandler PropertyChanged;
        //private void NotifyPropertyChanged(String info)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(info));
        //    }
        //}

        //Initialize property for binding
        //User group property
        private ObservableCollection<Tb_User> usergroup = new ObservableCollection<Tb_User>();
        public ObservableCollection<Tb_User> UserGroup
        {
            get { return usergroup; }
            set
            {
                usergroup = value;
                RaisePropertyChanged("UserGroup");
                //NotifyPropertyChanged("UserGroup");
            }
        }
        //SelectedItem property
        private Tb_User selectedItem = new Tb_User();

        public Tb_User SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }

        

    }
}
