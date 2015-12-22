using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HappyWorkService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DetailService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DetailService.svc or DetailService.svc.cs at the Solution Explorer and start debugging.
    public class DetailService : IDetailService
    {
        public int Add(Tb_Detail t)
        {
            throw new NotImplementedException();
        }

        public int Delete(Tb_Detail t)
        {
            throw new NotImplementedException();
        }

        public Tb_Detail Find(object id)
        {
            throw new NotImplementedException();
        }

        public IList<Tb_Detail> FindAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Tb_Detail t)
        {
            throw new NotImplementedException();
        }
    }
}
