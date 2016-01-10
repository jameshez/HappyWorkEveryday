﻿using GalaSoft.MvvmLight;
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
        public LeaveRecordViewModel()
        {
            //initData();

            SearchCommand = new RelayCommand<string>((alias) =>
            {

                var m = new ObservableCollection<LeaveRecordPageModel>( 
                        from r in _SearchableLeaveRecords
                        where (r.Alias.ToUpper().Contains(alias.ToUpper()) || r.EnglishName.ToUpper().Contains(alias.ToUpper()))
                        select r);

                _LeaveRecords = m;
                RaisePropertyChanged("LeaveRecords");
            });


            LeaveTypeChangeCommand = new RelayCommand<string>((leavetype)=>
            {
                //leaveType = leavetype;
                var result = new ObservableCollection<LeaveRecordPageModel>(
                    from r in _LeaveRecords
                    where r.LeaveType.Equals(leavetype)
                    select r);
                RaisePropertyChanged("LeaveRecords");
            });
        }

        private string _leaveType;
        public string leaveType
        {
            get
            {
                return _leaveType;
            }
            set
            {
                _leaveType = value.ToString();
            }
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
                _LeaveRecords = await ServiceFactory.Detail.FindAllLeaveRecordsAsync();
                _SearchableLeaveRecords = _LeaveRecords;
            }
            catch (Exception e)
            {
                Logger.WriteLogInfo(false, e);

                _LeaveRecords = TestDataGenerator.Generate<LeaveRecordPageModel>(10);
                _SearchableLeaveRecords = _LeaveRecords;
            }

            RaisePropertyChanged("LeaveRecords");
        }

        private ObservableCollection<LeaveRecordPageModel> _SearchableLeaveRecords;
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
