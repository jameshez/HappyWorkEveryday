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
using HappyWorkEveryday.MSDNUserServiceReference;
namespace HappyWorkEveryday.ViewModel
{


    public class AskforLeaveViewModel : ViewModelBase
    {

        UserServiceClient client = new UserServiceClient();
        MSDNUserServiceClient MSDNUser_Client = new MSDNUserServiceClient();

        #region Property
        private bool isFlyoutOpen;
        public bool IsFlyoutOpen
        {
            get { return isFlyoutOpen; }
            set
            {
                isFlyoutOpen = value;
                RaisePropertyChanged("IsFlyoutOpen");
            }
        }

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
        //SelectedUserRecord property
        private Tb_User selectedUserRecord = new Tb_User();

        public Tb_User SelectedUserRecord
        {
            get { return selectedUserRecord; }
            set
            {
                selectedUserRecord = value;
                RaisePropertyChanged("SelectedUserRecord");
            }
        }
        //Get List alias
        private ObservableCollection<string> _user_alias_group = new ObservableCollection<string>();

        public ObservableCollection<string> User_Alias_Group
        {
            get { return _user_alias_group; }
            set
            {
                _user_alias_group = value;
                RaisePropertyChanged("User_Alias_Group");
            }
        }

        private string _selectedalias;

        public string SelectedAlias
        {
            get { return _selectedalias; }
            set
            {
                _selectedalias = value;
                RaisePropertyChanged("SelectedAlias");
            }
        }
        #endregion


        #region Command
        public RelayCommand<object> OpenCommand { get; set; }
        public RelayCommand CloseCommand { get; set; }

        public RelayCommand<object> ComboBoxSelectCommand { get; set; }
        #endregion




        public AskforLeaveViewModel()
        {
            OpenCommand = new RelayCommand<object>((x) =>
            {
                RadioButton rb = (RadioButton)x;
                Flyout flyout = rb.FindName("fly") as Flyout;
                flyout.ShowAt(rb);
            });
            CloseCommand = new RelayCommand(() => IsFlyoutOpen = false);
            ComboBoxSelectCommand = new RelayCommand<object>(async(x) =>
            {
                ComboBox cb = (ComboBox)x;
                SelectedAlias=cb.SelectedItem.ToString();
                selectedUserRecord=await client.FindByAliasAsync(SelectedAlias);
            });

            InitializeData();

        }
        private async void InitializeData()
        {
            //usergroup = await client.FindAllAsync();
            _user_alias_group = new ObservableCollection<string>((await MSDNUser_Client.FindAllAsync()).Select(m => m.Alias));       
        }

      


    }
}
