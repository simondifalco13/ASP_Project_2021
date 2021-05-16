using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.DAL.CDAL
{
    public class AccountDAL : IAccountDAL
    {
        private string connectionString;
        public AccountDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public  bool SaveRestaurant(Restorer r)
        {
            string request = "INSERT INTO dbo.Restorers (FirstName,LastName,Email,Password,Gender,City,Address,PostalCode,PhoneNumber,Country) VALUES (@FirstName,@LastName,@Email,@Password,@Gender,@City,@Address,@PostalCode,@PhoneNumber,@Country)";
            bool success = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("FirstName", r.Firstname);
                cmd.Parameters.AddWithValue("LastName", r.Lastname);
                cmd.Parameters.AddWithValue("Email", r.Email);
                cmd.Parameters.AddWithValue("Password", r.Password);
                cmd.Parameters.AddWithValue("Gender", r.Gender);
                cmd.Parameters.AddWithValue("City", r.City);
                cmd.Parameters.AddWithValue("Address", r.Adress);
                cmd.Parameters.AddWithValue("PostalCode", r.Pc);
                cmd.Parameters.AddWithValue("PhoneNumber", r.Tel);
                cmd.Parameters.AddWithValue("Country", r.Country);
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                success = res >=10;
            }
            return success;
        }
    }
}
