using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelsClasses;

namespace HotelsControllers
{
    public class ManageHotels:IManage<Hotel>
    {

        static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDBTheodor;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Hotel> GetAlle()
        {
            List<Hotel> hotels = new List<Hotel>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string queryString = "select * from Hotel";
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

        public Hotel GetFromId(int number)
        {
            throw new NotImplementedException();
        }

        public bool Create(Hotel obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Hotel obj, int id)
        {
            throw new NotImplementedException();
        }

        public Hotel Delete(int number)
        {
            throw new NotImplementedException();
        }
    }
}
