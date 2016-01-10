using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
            SearchCommand = new RelayCommand<string>((alias) =>
            {
            var m = new ObservableCollection<Tb_User>(
                    from r in _SearchableLeaveRecords
                    where r.Alias.Contains(alias) || r.EnglishName.ToUpper().Contains(alias.ToUpper())
                        select r);

                _LeaveRecords = m;
                RaisePropertyChanged("LeaveRecords");
            });
        }

        public RelayCommand<string> SearchCommand
        {
            get; set;
        }

        private async void initData()
        {
            try
            {
                _LeaveRecords = await ServiceFactory.Client.FindAllAsync();
                _SearchableLeaveRecords = _LeaveRecords;
            }
            catch (Exception e)
            {
                Logger.WriteLogInfo(false, e);
                _LeaveRecords = TestDataGenerator.Generate<Tb_User>(10);
                _SearchableLeaveRecords = _LeaveRecords;
            }

            RaisePropertyChanged("LeaveRecords");
        }

        private ObservableCollection<Tb_User> _SearchableLeaveRecords;
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
