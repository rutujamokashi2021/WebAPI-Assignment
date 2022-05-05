using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpWebAPI
{
    public class EmployeeAuthentication:IDisposable
    {
        public string ValidateEmployee(string username, string password)
        {
            string Name = username == "rutuja" ? "Valid" : "InValid";
            string Password = password == "18!Rutuja" ? "Valid" : "Invalid";

            if (Name == "Valid" && Password == "Valid")
                return "true";
            else
                return "false";
        }
        public void Dispose()
        {
            //Dispose();
        }
    }
}