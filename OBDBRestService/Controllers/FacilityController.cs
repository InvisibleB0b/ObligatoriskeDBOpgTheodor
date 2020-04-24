using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HotelsClasses;

namespace OBDBRestService.Controllers
{
    public class FacilityController : ApiController
    {

        static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDBTheodor;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // GET api/values
        public List<Facility> Get()
        {
            List<Facility> facilities = new List<Facility>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string queryString = "select * from Facilities";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   Facility f = new Facility()
                   {
                       Facility_Id = (int)reader["Facility_Id"],
                       Facility_Name = (string)reader["Facility_Name"]
                   };
                    facilities.Add(f);
                }

                command.Connection.Close();
            }


            return facilities;
        }

        // GET api/values/5
        public Facility Get(int id)
        {
            Facility f = new Facility();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string queryString = $"select * from Facilities WHERE Facility_Id = {id}";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    f.Facility_Id = (int) reader["Facility_Id"];
                    f.Facility_Name = (string) reader["Facility_Name"];

                }

                command.Connection.Close();
            }

            return f;
        }

        // POST api/values
        public int Post([FromBody]Facility value)
        {
            int id = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string queryString = $"INSERT INTO Facilities VALUES('{value.Facility_Name}') SELECT Facility_Id FROM Facilities WHERE Facility_ID = @@IDENTITY";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = (int) reader["Facility_Id"];
                }

                command.Connection.Close();
            }

            return id;
        }

        // PUT api/values/5
        public Facility Put(int id, [FromBody]Facility value)
        {

            Facility f = new Facility();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string queryString = $"UPDATE Facilities SET Facility_Name = '{value.Facility_Name}' WHERE Facility_ID = {id} SELECT * FROM Facilities WHERE Facility_Id = {id} ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {

                    f.Facility_Id = (int)reader["Facility_Id"];
                    f.Facility_Name = (string)reader["Facility_Name"];

                }
                command.Connection.Close();
            }

            return f;

        }

        // DELETE api/values/5
        public void Delete(int id)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string queryString = $"DELETE Facilities WHERE Facility_Id = {id} ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                command.ExecuteNonQuery();
                command.Connection.Close();
            }

        }
    }
}
