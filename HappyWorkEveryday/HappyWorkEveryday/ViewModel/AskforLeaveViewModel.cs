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
using HappyWorkEveryday.Helper;

namespace HappyWorkEveryday.ViewModel
{
   

    public class AskforLeaveViewModel : ViewModelBase
    {

        UserServiceClient client = new UserServiceClient();
        MSDNUserServiceClient MSDNUser_Client = new MSDNUserServiceClient();
        #region Property System
        public string localuser { get; set; }
        #region Date and Time
        public string _startdate { get; set; }
        public string _todate { get; set; }
        public string _starttime { get; set; }
        public string _totime { get; set; }

        public string StartDate
        {
            get { return _startdate; }
            set
            {
                _startdate = value;
                RaisePropertyChanged("StartDate");            
            }
        }

        public string ToDate
        {
            get { return _todate; }
            set
            {
                _todate = value;
                RaisePropertyChanged("ToDate");
            }
        }

        public string StartTime
        {
            get { return _starttime; }
            set
            {
                _starttime = value;
                RaisePropertyChanged("StartTime");
            }
        }

        public string ToTime
        {
            get { return _totime; }
            set
            {
                _totime = value;
                RaisePropertyChanged("ToTime");
            }
        }
        #endregion

        #region FlyoutProperty
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
        #endregion

        #region Tb_User group
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
        #endregion

        #region ItemSource for Combobox
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
        #endregion


        #region Record when search using alias
        //SelectedUserRecord collection
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
        #endregion

        #region Selected Alias, used for button binding.
        //Selected Alias, used for button binding.
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
       

        #endregion


        #region Command
        //Popup flyout
        public RelayCommand<object> OpenCommand { get; set; }
        //Command to close the flyout 
        public RelayCommand CloseCommand { get; set; }
        //Select alias
        public RelayCommand<object> ComboBoxSelectCommand { get; set; }
        //Submit userdata
        public RelayCommand SubmitCommand { get; set; }
        
        #endregion




        public  AskforLeaveViewModel()
        {
            try
            {
                //InitializeData for combobox binding
                InitializeData();
                //Get Local User
                FetchLocalAlias();
              
                OpenCommand = new RelayCommand<object>((x) =>
                {
                    RadioButton rb = (RadioButton)x;
                    if (rb.Name == "ForMySelfRadioButton")
                    {

                        SelectedAlias = localuser;

                    }
                    else if (rb.Name == "ForOthersRadioButton")
                    {
                        Flyout flyout = rb.FindName("fly") as Flyout;
                        flyout.ShowAt(rb);
                    }
                });

                CloseCommand = new RelayCommand(() => IsFlyoutOpen = false);


                ComboBoxSelectCommand = new RelayCommand<object>(async (x) =>
                {
                    ComboBox cb = (ComboBox)x;
                    SelectedAlias = cb.SelectedItem.ToString();
                    SelectedUserRecord = await client.FindByAliasAsync(SelectedAlias);
                    
                    
                });

                SubmitCommand = new RelayCommand(() =>
                  {
                      
                      var x = StartDate;
                      if(SelectedUserRecord.OverTime==0)
                      {

                      }
                      else
                      {

                      }
                  }
                );

            }
            catch (Exception e)
            {
                Logger.WriteLogInfo(false, "Error:" + e.Message.ToString());
               // Logger.WriteLogInfo(false, "Table does not contain" + SelectedAlias + "'s overtime");
            }
        }



        private async void InitializeData()
        {
            //usergroup = await client.FindAllAsync();

            _user_alias_group = new ObservableCollection<string>((await MSDNUser_Client.FindAllAsync()).Select(m => m.Alias));

        }

        private async void FetchLocalAlias()
        {
            var GetName = await LocalInformationHelper.getCurrentUserName();
            localuser = GetName.Item2;
            SelectedAlias = localuser;
        }


    }


   
}
