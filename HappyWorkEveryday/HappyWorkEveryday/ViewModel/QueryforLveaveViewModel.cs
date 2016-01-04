using GalaSoft.MvvmLight;
using HappyWorkEveryday.MSDNUserServiceReference;
using HappyWorkEveryday.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyWorkEveryday.ViewModel
{
    class QueryforLveaveViewModel : ViewModelBase
    {
        UserServiceClient client = new UserServiceClient();
        MSDNUserServiceClient MSDNUser_Client = new MSDNUserServiceClient();

        public QueryforLveaveViewModel()
        {

        }
    }
}
