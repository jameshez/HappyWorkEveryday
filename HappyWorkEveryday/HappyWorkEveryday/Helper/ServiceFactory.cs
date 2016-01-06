using HappyWorkEveryday.DetailServiceReference;
using HappyWorkEveryday.LeaveRecordService;
using HappyWorkEveryday.MSDNUserServiceReference;
using HappyWorkEveryday.OrganizationService;
using HappyWorkEveryday.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyWorkEveryday.Helper
{
    public static class ServiceFactory
    {

        private static UserServiceClient _Client;
        /// <summary>
        /// user table data, include: id, alias, EName, overtime, roleId
        /// </summary>
        public static UserServiceClient Client
        {
            get
            {
                if (_Client == null)
                {
                    _Client = new UserServiceClient();
                    
                }
                return _Client;
            }
        }

        private static OrganizationServiceClient _Orginzation;
        /// <summary>
        /// orginzation detail data
        /// </summary>
        public static OrganizationServiceClient Orginzation
        {
            get
            {
                if (_Orginzation == null)
                {
                    _Orginzation = new OrganizationServiceClient();

                }
                return _Orginzation;
            }
        }


        private static LeaveRecordServiceClient _Detail;
        /// <summary>
        /// detail record per engineer
        /// </summary>
        public static LeaveRecordServiceClient Detail
        {
            get
            {
                if (_Detail == null)
                {
                    _Detail = new LeaveRecordServiceClient();

                }
                return _Detail;
            }
        }


        private static MSDNUserServiceClient _MSDNUser_Client;
        /// <summary>
        /// 
        /// </summary>
        public static MSDNUserServiceClient MSDNUser_Client
        {
            get
            {
                if (_MSDNUser_Client == null)
                {
                    _MSDNUser_Client = new MSDNUserServiceClient();

                }
                return _MSDNUser_Client;
            }
        }

    }
}
