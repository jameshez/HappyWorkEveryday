using HappyWorkService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HappyWorkService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public int Add(Tb_User t)
        {
            return DBRepository<Tb_User>.GetInstance().Add(t);
        }

        public int Delete(Tb_User t)
        {
            return DBRepository<Tb_User>.GetInstance().Delete(t);
        }

        public Tb_User Find(object id)
        {
            return DBRepository<Tb_User>.GetInstance().Find(id);
        }

        public IList<Tb_User> FindAll()
        {
            return DBRepository<Tb_User>.GetInstance().FindAll();
        }

        public Tb_User FindByAlias(string Alias)
        {
            using (AttendanceEntities db = new AttendanceEntities())
            {
                return db.Tb_User.Where(t => t.Alias == Alias).FirstOrDefault();
            }

        }

        public int Update(Tb_User t)
        {
            return DBRepository<Tb_User>.GetInstance().Update(t);
        }
    }
}
