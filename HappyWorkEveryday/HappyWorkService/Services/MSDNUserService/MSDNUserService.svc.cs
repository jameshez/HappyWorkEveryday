using HappyWorkService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HappyWorkService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MSDNUserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MSDNUserService.svc or MSDNUserService.svc.cs at the Solution Explorer and start debugging.
    public class MSDNUserService : IMSDNUserService
    {
        public int Add(Tb_MSDNUser t)
        {
            return DBRepository<Tb_MSDNUser>.GetInstance().Add(t);
        }

        public int Delete(Tb_MSDNUser t)
        {
            return DBRepository<Tb_MSDNUser>.GetInstance().Delete(t);
        }

        public Tb_MSDNUser Find(object id)
        {
            return DBRepository<Tb_MSDNUser>.GetInstance().Find(id);
        }

        public IList<Tb_MSDNUser> FindAll()
        {
            return DBRepository<Tb_MSDNUser>.GetInstance().FindAll();
        }

        public int Update(Tb_MSDNUser t)
        {
            return DBRepository<Tb_MSDNUser>.GetInstance().Update(t);
        }
    }
}
