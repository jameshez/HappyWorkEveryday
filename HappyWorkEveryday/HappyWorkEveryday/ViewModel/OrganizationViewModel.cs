using GalaSoft.MvvmLight;
using HappyWorkEveryday.Helper;
using HappyWorkEveryday.OrganizationService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyWorkEveryday.ViewModel
{
    class OrganizationViewModel: ViewModelBase
    {
        private async void initData()
        {
            try
            {
                var t = await ServiceFactory.Orginzation.FindOrganizationRelationshipAsync();

                _OrgRecords = from p in t
                                 group p by p.TeamName into g
                                 select g;
                
            }
            catch (Exception e)
            {
                Logger.WriteLogInfo(false, e);
            }

            RaisePropertyChanged("OrgRecords");
        }

        

        private IEnumerable<IGrouping<string,OrganizationPageModel>> _OrgRecords;
        public IEnumerable<IGrouping<string, OrganizationPageModel>> OrgRecords
        {
            get
            {
                if (_OrgRecords == null)
                {
                    initData();
                }

                return _OrgRecords;
            }
        }
    }
}
