using GalaSoft.MvvmLight;
using HappyWorkEveryday.Helper;
using HappyWorkEveryday.MSDNUserServiceReference;
using HappyWorkEveryday.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyWorkEveryday.ViewModel
{
    public class QueryforLeaveViewModel : ViewModelBase
    {
        

        public QueryforLeaveViewModel()
        {
            //initData();
        }

        private async void initData()
        {
            try
            {
                _LeaveRecords = await ServiceFactory.Client.FindAllAsync();
            }
            catch (Exception e)
            {
                Logger.WriteLogInfo(false, e);
            }

            RaisePropertyChanged("LeaveRecords");
        }

        private ObservableCollection<Tb_User> _LeaveRecords;
        public ObservableCollection<Tb_User> LeaveRecords
        {
            get
            {
                if (_LeaveRecords == null)
                {
                    initData();
                }
                return _LeaveRecords;
            }
        }
    }
}
