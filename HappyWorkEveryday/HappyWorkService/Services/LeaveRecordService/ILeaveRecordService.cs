using HappyWorkService.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HappyWorkService.Services.LeaveRecordService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILeaveRecordService" in both code and config file together.
    [ServiceContract]
    public interface ILeaveRecordService
    {
        [OperationContract]
        IList<LeaveRecordPageModel> FindAllLeaveRecords();
    }
}
