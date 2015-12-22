using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HappyWorkService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdminService" in both code and config file together.
    [ServiceContract]
    public interface IAdminService
    {
        #region Add
        [OperationContract]
        //[WebInvoke(
        //    UriTemplate = "Add",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    Method = "POST")]
        int Add(Tb_AdminLog t);
        #endregion

        #region Update
        [OperationContract]
        //[WebInvoke(
        //    UriTemplate = "Update",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    Method = "POST")]
        int Update(Tb_AdminLog t);
        #endregion

        #region Delete
        [OperationContract]
        //[WebInvoke(
        //   UriTemplate = "Delete",
        //   RequestFormat = WebMessageFormat.Json,
        //   ResponseFormat = WebMessageFormat.Json,
        //   Method = "POST")]
        int Delete(Tb_AdminLog t);
        #endregion

        #region Find a object by id
        [OperationContract]
        //[WebInvoke(
        //   UriTemplate = "Find",
        //   RequestFormat = WebMessageFormat.Json,
        //   ResponseFormat = WebMessageFormat.Json,
        //   Method = "POST")]
        Tb_AdminLog Find(object id);
        #endregion

        #region Find all record
        [OperationContract]
        //[WebInvoke(
        //  UriTemplate = "Find",
        //  RequestFormat = WebMessageFormat.Json,
        //  ResponseFormat = WebMessageFormat.Json,
        //  Method = "POST")]
        IList<Tb_AdminLog> FindAll();
        #endregion
    }
}
