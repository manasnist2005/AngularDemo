using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace AngularDemo
{
    /// <summary>
    /// Summary description for EmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
   [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void GetAllEmployees()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(GetEmployees()));
            //return "Hello World";
        }

        private List<Employee> GetEmployees()
        {
            List<Employee> lstEmployee = new List<Employee>();

            lstEmployee.Add(new Employee { id = 1, name = "Manas", gender = "Male", company = "Tieto", salary = 3456 });
            lstEmployee.Add(new Employee { id = 2, name = "Sonali", gender = "Female", company = "TCS", salary = 4476 });
            lstEmployee.Add(new Employee { id = 3, name = "Manoj", gender = "Male", company = "Wipro", salary = 2456 });
            lstEmployee.Add(new Employee { id = 4, name = "Kiran", gender = "Female", company = "PWC", salary = 4286 });
            lstEmployee.Add(new Employee { id = 5, name = "Lala", gender = "Male", company = "Infosys", salary = 7466 });
            return lstEmployee;

        }

    }
}
