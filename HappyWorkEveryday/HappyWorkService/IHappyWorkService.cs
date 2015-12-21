using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace HappyWorkService
{
    interface IHappyWorkService<T> where T : class
    {
        #region Add
        [OperationContract]
        [WebInvoke(
            UriTemplate = "Add",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "POST")]
        int Add(T t);
        #endregion

        #region Update
        [OperationContract]
        [WebInvoke(
            UriTemplate = "Update",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "POST")]
        int Update(T t);
        #endregion

        #region Delete
        [OperationContract]
        [WebInvoke(
           UriTemplate = "Delete",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           Method = "POST")]
        int Delete(T t);
        #endregion

        #region Find a object by id
        [OperationContract]
        [WebInvoke(
           UriTemplate = "Find",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           Method = "POST")]
        T Find(object id);
        #endregion

        #region Find a collection by a certain condition
        [OperationContract]
        [WebInvoke(
          UriTemplate = "Find",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          Method = "POST")]
        IList<T> Find(params object[] parameters);
        #endregion

    }
}
