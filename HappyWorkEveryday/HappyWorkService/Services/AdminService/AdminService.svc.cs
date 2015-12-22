using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HappyWorkService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdminService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdminService.svc or AdminService.svc.cs at the Solution Explorer and start debugging.
    public class AdminService : IAdminService
    {
        public int Add(Tb_AdminLog t)
        {
            throw new NotImplementedException();
        }

        public int Delete(Tb_AdminLog t)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public Tb_AdminLog Find(object id)
        {
            throw new NotImplementedException();
        }

        public IList<Tb_AdminLog> FindAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Tb_AdminLog t)
        {
            throw new NotImplementedException();
        }
    }
}
