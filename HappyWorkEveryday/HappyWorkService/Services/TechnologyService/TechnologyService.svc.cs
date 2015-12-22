using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HappyWorkService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TechnologyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TechnologyService.svc or TechnologyService.svc.cs at the Solution Explorer and start debugging.
    public class TechnologyService : ITechnologyService
    {
        public int Add(Tb_Technology t)
        {
            throw new NotImplementedException();
        }

        public int Delete(Tb_Technology t)
        {
            throw new NotImplementedException();
        }

        public Tb_Technology Find(object id)
        {
            throw new NotImplementedException();
        }

        public IList<Tb_Technology> FindAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Tb_Technology t)
        {
            throw new NotImplementedException();
        }
    }
}
