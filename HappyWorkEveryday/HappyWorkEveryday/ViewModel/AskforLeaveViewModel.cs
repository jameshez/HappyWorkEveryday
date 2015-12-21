using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using HappyWorkEveryday.Model;
using HappyWorkEveryday.UserServiceReference;

namespace HappyWorkEveryday.ViewModel
{


    public class AskforLeaveViewModel: INotifyPropertyChanged
    {
        UserServiceReference.UserServiceClient client = new UserServiceReference.UserServiceClient();
        public AskforLeaveViewModel()
        {
            UserGroup = null;
        }

        //Implement the interface
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
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
                NotifyPropertyChanged("UserGroup");
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
                NotifyPropertyChanged("SelectedItem");
            }
        }

        

    }
}
