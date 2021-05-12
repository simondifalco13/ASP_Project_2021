using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.DAL.CDAL
{
    public class AccountDAL : IAccountDAL
    {
        private string connectionString, connectionString2;
        public AccountDAL(string connectionString,string connectionString2)
        {
            this.connectionString = connectionString;
            this.connectionString2 = connectionString2;
        }

        public  bool SaveRestorer(Restorer r)
        {
            bool existingUser = VerifyExistingUser(r);
            if (existingUser != true)
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
                    cmd.Parameters.AddWithValue("Address", r.Address);
                    cmd.Parameters.AddWithValue("PostalCode", r.Pc);
                    cmd.Parameters.AddWithValue("PhoneNumber", r.Tel);
                    cmd.Parameters.AddWithValue("Country", r.Country);
                    connection.Open();
                    int res = cmd.ExecuteNonQuery();
                    success = res > 0;
                }
                return success;
            }
            else
            {
                return false;
            }
        }

        // A reçu l'objet depuis le contrôleur. ( Contrôleur -> Class métier -> DAL )
        public bool SaveCustomer(Customer accountC) {
            string request = "INSERT INTO dbo.Customers (FirstName,LastName,DoB,Email,Password,Gender,City,Address,PostalCode,PhoneNumber,Country) VALUES (@FirstName,@LastName,@DoB,@Email,@Password,@Gender,@City,@Address,@PostalCode,@PhoneNumber,@Country)";
            bool success = false;
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("FirstName", accountC.Firstname);
                cmd.Parameters.AddWithValue("LastName", accountC.Lastname);
                cmd.Parameters.AddWithValue("DoB", accountC.DoB);
                cmd.Parameters.AddWithValue("Email", accountC.Email);
                cmd.Parameters.AddWithValue("Password", accountC.Password);
                cmd.Parameters.AddWithValue("Gender", accountC.Gender);
                cmd.Parameters.AddWithValue("City", accountC.City);
                cmd.Parameters.AddWithValue("Address", accountC.Address);
                cmd.Parameters.AddWithValue("PostalCode", accountC.Pc);
                cmd.Parameters.AddWithValue("PhoneNumber", accountC.Tel);
                cmd.Parameters.AddWithValue("Country", accountC.Country);
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                success = res > 0;
            }
            return success;
        }

        public bool VerifyExistingUser(Restorer r)
        {
            bool exists = false;
            List<string> emails = new List<string>();
            string request = "SELECT Email FROM dbo.Restorers";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(request, connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        emails.Add(reader.GetString("Email"));
                    }
                }
            }
            foreach (var email in emails)
            {
                if (email == r.Email)
                {
                    exists = true;
                }
            }
            return exists;

        }
    }
}
