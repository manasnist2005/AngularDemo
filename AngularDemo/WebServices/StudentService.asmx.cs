using AngularDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace AngularDemo.WebServices
{
    /// <summary>
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StudentService : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetAllStudents()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(GetAllStudent()));
        }

        [WebMethod]
        public void GetStudentDetail(int id)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(GetAllStudent().Where(s=> s.id==id)));
        }
        private List<Student> GetAllStudent()
        {
            List<Student> listStudents = new List<Student>();
            listStudents.Add(new Student { id = 1, name = "Manas", city = "Pune", gender = "Male" });
            listStudents.Add(new Student { id = 2, name = "Siva", city = "Chennai", gender = "Male" });
            listStudents.Add(new Student { id = 3, name = "Sonali", city = "Pune", gender = "Female" });
            listStudents.Add(new Student { id = 4, name = "Aisha", city = "Mumbai", gender = "Female" });
            listStudents.Add(new Student { id = 5, name = "Alok", city = "Bangalore", gender = "Male" });
            listStudents.Add(new Student { id = 6, name = "Nitesh", city = "Delhi", gender = "Male" });
            listStudents.Add(new Student { id = 7, name = "Sanjukta", city = "Pune", gender = "Female" });
            listStudents.Add(new Student { id = 8, name = "Rahim", city = "Hyderabad", gender = "Male" });
            listStudents.Add(new Student { id = 9, name = "Jyoti", city = "Kolkata", gender = "Male" });
            return listStudents;
        }
    }
}
