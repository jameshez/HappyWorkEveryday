using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using HappyWorkEveryday.Model;

namespace HappyWorkEveryday.ViewModel
{


    public class AskforLeaveViewModel: INotifyPropertyChanged
    {
        public AskforLeaveViewModel()
        {
          
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
        private ObservableCollection<User> usergroup = new ObservableCollection<User>();
        public ObservableCollection<User> UserGroup
        {
            get { return usergroup; }
            set
            {
                usergroup = value;
                NotifyPropertyChanged("UserGroup");
            }
        }
        //SelectedItem property
        private User selectedItem = new User();

        public User SelectedItem
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
