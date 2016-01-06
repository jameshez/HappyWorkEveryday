using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HappyWorkService.CustomModels;
using HappyWorkService.Repository;

namespace HappyWorkService.Services.OrganizationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrganizationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrganizationService.svc or OrganizationService.svc.cs at the Solution Explorer and start debugging.
    public class OrganizationService : IOrganizationService
    {
        protected static object obj = new object();
        public IList<OrganizationPageModel> FindOrganizationRelationship()
        {
            lock (obj)
            {
                try
                {
                    var result = (from msdn in DBRepository<Tb_MSDNUser>.db.Tb_MSDNUser.ToList()
                                  join team in DBRepository<Tb_TeamInfo>.db.Tb_TeamInfo.ToList() on msdn.TeamId equals team.Id
                                  select new OrganizationPageModel()
                                  {
                                      Alias = msdn.Alias,
                                      EnglishName = msdn.Name,
                                      TeamName = team.TeamName,
                                      TeamLeader = team.TeamName
                                  }).ToList();
                    return result;
                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
    }
}
