using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyWorkService.Repository
{
    public class DBRepository<T> where T : class
    {
        //public static AttendanceEntities db = new AttendanceEntities();
        private static DBRepository<T> instance;
        private static readonly object syncObj = new object();
        private DBRepository()
        {
        }
        public static DBRepository<T> GetInstance()
        {
            if (instance == null)
            {
                lock (syncObj)
                {
                    if (instance == null)
                    {
                        instance = new DBRepository<T>();
                    }
                }
            }
            return instance;
        }

        #region Add
        public int Add(T t)
        {
            using (AttendanceEntities db = new AttendanceEntities())
            {
                db.Set<T>().Attach(t);
                db.Entry(t).State = System.Data.Entity.EntityState.Added;
                return db.SaveChanges();
            }
        }
        #endregion

        #region Update
        public int Update(T t)
        {
            using (AttendanceEntities db = new AttendanceEntities())
            {
                db.Set<T>().Attach(t);
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
            
        }
        #endregion

        #region Delete
        public int Delete(T t)
        {
            using (AttendanceEntities db = new AttendanceEntities())
            {
                db.Set<T>().Attach(t);
                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();
            }
        }
        #endregion

        #region Find a object by id
        public T Find(object id)
        {
            using (AttendanceEntities db = new AttendanceEntities())
            {
                return db.Set<T>().Find(id);
            }
            
        }
        #endregion

        #region Find all record
        public IList<T> FindAll()
        {
            using (AttendanceEntities db = new AttendanceEntities())
            {
                return db.Set<T>().ToList();
            }
        }
        #endregion
    }
}