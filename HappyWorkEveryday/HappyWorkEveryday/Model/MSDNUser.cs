using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyWorkEveryday.Model
{
    public class MSDNUser: INotifyPropertyChanged
    {
        public int _id;

        public int MSDN_User_ID
        {
            get { return _id; }
            set
            {

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
