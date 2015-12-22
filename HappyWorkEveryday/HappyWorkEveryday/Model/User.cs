using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyWorkEveryday.Model
{
    public class User: INotifyPropertyChanged
    {
        public int _id;

        public int UserId
        {
            get { return _id; }
            set
            {
                if (value != this._id)
                {
                    this._id = value;
                    NotifyPropertyChanged("UserId");
                }
            }
        }

        public string _alias;

        public string Alias
        {
            get { return _alias; }
            set
            {
                if (value != this._alias)
                {
                    this._alias = value;
                    NotifyPropertyChanged("Alias");
                }
            }

        }

        public string _en_Name;

        public string EnglishName
        {
            get { return _en_Name; }
            set
            {
                if (value != this._en_Name)
                {
                    this._en_Name = value;
                    NotifyPropertyChanged("EnglishName");
                }
            }

        }

        public int _overtime;

        public int OverTime
        {
            get { return _overtime; }
            set
            {
                if (value != this._overtime)
                {
                    this._overtime = value;
                    NotifyPropertyChanged("OverTime");
                }
            }

        }

        public int _role_id;

        public int RoleId
        {
            get { return _role_id; }
            set
            {
                if (value != this._role_id)
                {
                    this._role_id = value;
                    NotifyPropertyChanged("RoleId");
                }
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

    }
}
