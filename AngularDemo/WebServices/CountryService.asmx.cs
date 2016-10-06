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
    /// Summary description for CountryService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CountryService : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetData()
        {
            List<Country> listCountries = new List<Country>();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(CreateCountryData()));
        }

        private List<Country> CreateCountryData()
        {
            List<Country> listCountries = new List<Country>();
            List<City> lstCityIndia = new List<City>();
            lstCityIndia.Add(new City { Id = 1, Name = "Mumbai", CountryId = 1 });
            lstCityIndia.Add(new City { Id = 2, Name = "Delhi", CountryId = 1 });
            lstCityIndia.Add(new City { Id = 3, Name = "Kolkata", CountryId = 1 });
            lstCityIndia.Add(new City { Id = 4, Name = "Chennai", CountryId = 1 });
            lstCityIndia.Add(new City { Id = 5, Name = "Bangalore", CountryId = 1 });
            lstCityIndia.Add(new City { Id = 6, Name = "Pune", CountryId = 1 });
            listCountries.Add(new Country { Id = 1, Name = "India", Cities = lstCityIndia });
            List<City> lstCityUSA = new List<City>();
            lstCityUSA.Add(new City { Id = 7, Name = "NewYork", CountryId = 2});
            lstCityUSA.Add(new City { Id = 8, Name = "Washington", CountryId = 2 });
            lstCityUSA.Add(new City { Id = 9, Name = "Los Angeles", CountryId = 2 });
            lstCityUSA.Add(new City { Id = 10, Name = "Vegas", CountryId = 2 });
            lstCityUSA.Add(new City { Id = 11, Name = "Houston", CountryId = 2});
            lstCityUSA.Add(new City { Id = 12, Name = "Chicago", CountryId = 2 });
            listCountries.Add(new Country { Id = 2, Name = "USA", Cities = lstCityUSA });
            List<City> lstCityIK = new List<City>();
            lstCityIK.Add(new City { Id = 13, Name = "London", CountryId = 3 });
            lstCityIK.Add(new City { Id = 14, Name = "Birmingham", CountryId = 3 });
            lstCityIK.Add(new City { Id = 15, Name = "Coventry", CountryId = 3 });
            lstCityIK.Add(new City { Id = 16, Name = "Liverpool", CountryId = 3 });
            lstCityIK.Add(new City { Id = 17, Name = "Manchester", CountryId = 3 });            
            listCountries.Add(new Country { Id = 3, Name = "UK", Cities = lstCityIK });
           

            return listCountries;

        }
    }
}
