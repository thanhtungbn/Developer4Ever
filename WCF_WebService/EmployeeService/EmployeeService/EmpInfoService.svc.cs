﻿using System;
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
    }
}
