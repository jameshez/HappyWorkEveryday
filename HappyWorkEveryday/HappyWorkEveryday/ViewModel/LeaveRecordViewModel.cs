using GalaSoft.MvvmLight;
using HappyWorkEveryday.DetailServiceReference;
using HappyWorkEveryday.Helper;
using HappyWorkEveryday.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyWorkEveryday.ViewModel
{
    public class LeaveRecordViewModel : ViewModelBase
    {
        public LeaveRecordViewModel()
        {
            //initData();
        }

        private async void initData()
        {
            try
            {
                _LeaveRecords = await ServiceFactory.Detail.FindAllAsync();
            }
            catch (Exception e)
            {
                Logger.WriteLogInfo(false, e);
            }

            RaisePropertyChanged("LeaveRecords");
        }

        private ObservableCollection<Tb_Detail> _LeaveRecords;
        public ObservableCollection<Tb_Detail> LeaveRecords
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
