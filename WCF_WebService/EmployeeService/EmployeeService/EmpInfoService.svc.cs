using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmpInfoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmpInfoService.svc or EmpInfoService.svc.cs at the Solution Explorer and start debugging.
    public class EmpInfoService : IEmpInfoService
    {   
        public string GetEmpSalary(string EmpId)
        {
            return "Salary of" + EmpId + " is" + 4000;
        }

        public  void SendAlarm (post_SendAlarm request)
        {
            //response_SendAlarm intial_response = new response_SendAlarm();
            //if (request.IPAddress=="192.168.10.100")
            //{
            //    intial_response.Ack = "Success";
            //    intial_response.Reason = "";
            //}
            //else
            //{
            //    intial_response.Ack = "failure";
            //    intial_response.Reason = "Invalid MACAddress";
            //}
            //return intial_response;
        }
    }
}
