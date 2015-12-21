using HappyWorkModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HappyWorkService
{
    public class HappyWorkService<T> : IHappyWorkService<T> where T : class
    {
        protected AttendanceEntities db = new AttendanceEntities();

        public int Add(T t)
        {
            db.Set<T>().Attach(t);
            db.Entry<T>(t).State = EntityState.Added;
            return db.SaveChanges();
        }

        public int Delete(T t)
        {
            db.Set<T>().Attach(t);
            db.Entry<T>(t).State = EntityState.Deleted;
            return db.SaveChanges();
        }

        public IList<T> Find(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public T Find(object id)
        {
            return db.Set<T>().Find(id);
        }

        public int Update(T t)
        {
            db.Set<T>().Attach(t);
            db.Entry<T>(t).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}