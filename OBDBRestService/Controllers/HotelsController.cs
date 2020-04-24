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
    public class HotelsController : ApiController
    {
        const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDBTheodor;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        // GET api/Hotels
        public List<Hotel> Get()
        {
           List<Hotel> hotels = new List<Hotel>();

           using (SqlConnection connection = new SqlConnection(ConnectionString))
           {
               string queryString = "select * from Hotels";
               SqlCommand command = new SqlCommand(queryString, connection);
               command.Connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               while (reader.Read())
               {
                   Hotel h = new Hotel()
                   {
                       Hotel_Id = (int)reader["Hotel_Id"],
                       Hotel_Name = (string)reader["Hotel_Name"],
                       Hotel_Address = (string)reader["Hotel_Address"]
                   };



                   hotels.Add(h);

               }

               command.Connection.Close();
           }

            return hotels;
        }

        // GET api/Hotels/Roskilde
        public Hotel Get(string str)
        {
            Hotel hotel = new Hotel();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string queryString = $"select * from Hotels WHERE Hotel_Address LIKE '%{str}%'";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    hotel.Hotel_Id = (int)reader["Hotel_Id"];
                    hotel.Hotel_Name = (string)reader["Hotel_Name"];
                    hotel.Hotel_Address = (string)reader["Hotel_Address"];



                }

                command.Connection.Close();
            }
            return hotel;
        }

        // POST api/hotels
        public void Post([FromBody]Hotel value)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string queryString = $"INSERT INTO Hotels VALUES({value.Hotel_Name}, {value.Hotel_Address})";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        // PUT api/hotels/5
        public void Put(int id, [FromBody]Hotel value)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string queryString = $"UPDATE Hotels SET Hotel_Name = '{value.Hotel_Name}', Hotel_Address = '{value.Hotel_Address}' WHERE Hotel_Id = {id}";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                command.ExecuteNonQuery();

                command.Connection.Close();
            }


        }

        // DELETE api/hotels/5
        public void Delete(int id)
        {
        }
    }
}
