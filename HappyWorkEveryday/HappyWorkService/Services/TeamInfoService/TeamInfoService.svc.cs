﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HappyWorkService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TeamInfoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TeamInfoService.svc or TeamInfoService.svc.cs at the Solution Explorer and start debugging.
    public class TeamInfoService : ITeamInfoService
    {
        public int Add(Tb_TeamInfo t)
        {
            throw new NotImplementedException();
        }

        public int Delete(Tb_TeamInfo t)
        {
            throw new NotImplementedException();
        }

        public Tb_TeamInfo Find(object id)
        {
            throw new NotImplementedException();
        }

        public IList<Tb_TeamInfo> FindAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Tb_TeamInfo t)
        {
            throw new NotImplementedException();
        }
    }
}
