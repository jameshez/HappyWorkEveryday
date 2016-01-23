using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
        AttendanceWebService.AttendanceServiceClient client = new AttendanceWebService.AttendanceServiceClient();
        public LeaveRecordViewModel()
        {
            initData();

            SearchCommand = new RelayCommand<string>((alias) =>
            {
                if (SelectedLeaveType != "All Type")
                {
                    var ret = from r in _SearchableLeaveRecords
                              where (r.Alias.ToUpper().Contains(alias.ToUpper()) || r.EnglishName.ToUpper().Contains(alias.ToUpper())) && r.LeaveType == SelectedLeaveType
                              select r;
                    LeaveRecords = new ObservableCollection<object>(ret);
                }
                else
                {
                    var ret = from r in _SearchableLeaveRecords
                              where r.Alias.ToUpper().Contains(alias.ToUpper()) || r.EnglishName.ToUpper().Contains(alias.ToUpper())
                              select r;
                    LeaveRecords = new ObservableCollection<object>(ret);
                }
                RaisePropertyChanged("LeaveRecords");
            });
        }

        private ObservableCollection<String> _leaveType = new ObservableCollection<string>() { "All Type", "Sick Leave", "Annual Leave", "Flexible Leave" };
        public ObservableCollection<string> leaveType
        {
            get
            {
                return _leaveType;
            }
            set
            {
                _leaveType = value;
                RaisePropertyChanged("leaveType");
            }
        }

        private string _SelectedLeaveType = "All Type";

        public string SelectedLeaveType
        {
            get { return _SelectedLeaveType; }
            set { _SelectedLeaveType = value; RaisePropertyChanged("SelectedLeaveType"); }
        }


        public RelayCommand<string> SearchCommand
        {
            get; set;
        }

        public RelayCommand<string> LeaveTypeChangeCommand
        {
            get; set;
        }


        private async void initData()
        {
            try
            {
                var ret = await client.GetAllLeaveRecoderAsync(AttendanceWebService.SearchType.All, "");
                ObservableCollection<object> cc = new ObservableCollection<object>(ret);
                LeaveRecords = cc;
                _SearchableLeaveRecords = ret;
            }
            catch (Exception e)
            {
                Logger.WriteLogInfo(false, e);
            }
            RaisePropertyChanged("LeaveRecords");
        }

        private ObservableCollection<AttendanceWebService.Detail> _SearchableLeaveRecords;
        private ObservableCollection<object> _LeaveRecords;
        public ObservableCollection<object> LeaveRecords
        {
            get { return _LeaveRecords; }
            set
            {
                _LeaveRecords = value;
                RaisePropertyChanged("LeaveRecords");
            }
        }





        private ObservableCollection<object> _Itemsource;

        public ObservableCollection<object> Itemsource
        {
            get { return _Itemsource; }
            set
            {
                _Itemsource = value;
                RaisePropertyChanged("Itemsource");
            }
        }
    }
}
