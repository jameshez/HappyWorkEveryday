﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HappyWorkService.CustomModels;
using HappyWorkService.Repository;

namespace HappyWorkService.Services.LeaveRecordService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LeaveRecordService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LeaveRecordService.svc or LeaveRecordService.svc.cs at the Solution Explorer and start debugging.
    public class LeaveRecordService : ILeaveRecordService
    {
        protected static object obj = new object();
        public IList<LeaveRecordPageModel> FindAllLeaveRecords()
        {
            lock (obj)
            {
                try
                {
                    using (AttendanceEntities db = new AttendanceEntities())
                    {
                        var result = (from user in db.Tb_User.ToList()
                                      join detail in db.Tb_Detail.ToList() on user.UserId equals detail.UserId
                                      select new LeaveRecordPageModel()
                                      {
                                          Alias = user.Alias,
                                          EnglishName = user.EnglishName,
                                          StartTime = detail.StartTime.ToString(),
                                          EndTime = detail.EndTime.ToString(),
                                          TotalTime = detail.TotalTime,
                                          LeaveType = detail.LeaveType,
                                          IsApproved = detail.IsApproved == 0 ? "No" : "Yes"

                                      }).ToList();
                        return result;
                    }

                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
    }
}
