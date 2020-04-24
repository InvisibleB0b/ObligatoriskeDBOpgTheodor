using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HotelsClasses;

namespace OBDBRestService.Controllers
{
    public class FacilityController : ApiController
    {

       // static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDBTheodor;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // GET api/values
        public List<Facility> Get()
        {
            List<Facility> facilities = new List<Facility>();




            return facilities;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
