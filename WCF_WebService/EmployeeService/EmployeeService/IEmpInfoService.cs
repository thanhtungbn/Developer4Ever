using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmpInfoService" in both code and config file together.
    [ServiceContract]
    public interface IEmpInfoService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Tung/{EmpId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        string GetEmpSalary(string EmpId);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate ="create", ResponseFormat = WebMessageFormat.Json, RequestFormat =WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        bool create(post_SendAlarm request);
    }

    
}
