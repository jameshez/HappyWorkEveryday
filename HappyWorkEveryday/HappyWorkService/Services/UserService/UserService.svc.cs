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
        protected AttendanceEntities db = new AttendanceEntities();
        public int Add(Tb_User t)
        {
            db.Tb_User.Attach(t);
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }

        public int Delete(Tb_User t)
        {
            db.Tb_User.Attach(t);
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }
        
        public Tb_User Find(object id)
        {
           return db.Tb_User.Find(id);
        }

        public IList<Tb_User> FindAll()
        {
            return db.Tb_User.ToList();
        }

        public int Update(Tb_User t)
        {
            db.Tb_User.Attach(t);
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
