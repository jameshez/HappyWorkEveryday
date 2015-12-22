using HappyWorkService.Repository;
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
            return DBRepository<Tb_AdminLog>.GetInstance().Add(t);
        }

        public int Delete(Tb_AdminLog t)
        {
            return DBRepository<Tb_AdminLog>.GetInstance().Delete(t);
        }

        public Tb_AdminLog Find(object id)
        {
            return DBRepository<Tb_AdminLog>.GetInstance().Find(id);
        }

        public IList<Tb_AdminLog> FindAll()
        {
            return DBRepository<Tb_AdminLog>.GetInstance().FindAll();
        }

        public int Update(Tb_AdminLog t)
        {
            return DBRepository<Tb_AdminLog>.GetInstance().Update(t);
        }
    }
}
