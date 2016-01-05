using HappyWorkEveryday.MSDNUserServiceReference;
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
