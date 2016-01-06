using GalaSoft.MvvmLight;
using HappyWorkEveryday.DetailServiceReference;
using HappyWorkEveryday.Helper;
using HappyWorkEveryday.LeaveRecordService;
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
                _LeaveRecords = await ServiceFactory.Detail.FindAllLeaveRecordsAsync();
            }
            catch (Exception e)
            {
                Logger.WriteLogInfo(false, e);
            }

            RaisePropertyChanged("LeaveRecords");
        }

        private ObservableCollection<LeaveRecordPageModel> _LeaveRecords;
        public ObservableCollection<LeaveRecordPageModel> LeaveRecords
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
