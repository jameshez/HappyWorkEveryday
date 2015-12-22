using HappyWorkService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HappyWorkService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RoleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RoleService.svc or RoleService.svc.cs at the Solution Explorer and start debugging.
    public class RoleService : IRoleService
    {
        public int Add(Tb_Role t)
        {
            return DBRepository<Tb_Role>.GetInstance().Add(t);
        }

        public int Delete(Tb_Role t)
        {
            return DBRepository<Tb_Role>.GetInstance().Delete(t);
        }

        public Tb_Role Find(object id)
        {
            return DBRepository<Tb_Role>.GetInstance().Find(id);
        }

        public IList<Tb_Role> FindAll()
        {
            return DBRepository<Tb_Role>.GetInstance().FindAll();
        }

        public int Update(Tb_Role t)
        {
            return DBRepository<Tb_Role>.GetInstance().Update(t);
        }
    }
}
