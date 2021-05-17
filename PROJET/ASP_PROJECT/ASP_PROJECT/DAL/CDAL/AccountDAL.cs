using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.Other;
using ASP_PROJECT.Models.POCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.DAL.CDAL
{
    public class AccountDAL : IAccountDAL{
        private string connectionString;
        public AccountDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public  bool SaveRestorer(Restorer r)
        {
            bool existingUser = VerifyExistingRestorer(r);
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
        public bool VerifyExistingRestorer(Restorer r)
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





        // A reçu l'objet depuis le contrôleur. ( Contrôleur -> Class métier -> DAL )
        public bool SaveCustomer(Customer accountC) {
            bool existingCustomer = VerifyExistingCustomer(accountC);

            if (existingCustomer == false) {
                string request = "INSERT INTO dbo.Customers (FirstName,LastName,DateOfBirth,Email,Password,Gender,City,Address,PostalCode,PhoneNumber,Country) VALUES (@FirstName,@LastName,@DateOfBirth,@Email,@Password,@Gender,@City,@Address,@PostalCode,@PhoneNumber,@Country)";
                bool success = false;
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    SqlCommand cmd = new SqlCommand(request, connection);
                    cmd.Parameters.AddWithValue("FirstName", accountC.Firstname);
                    cmd.Parameters.AddWithValue("LastName", accountC.Lastname);
                    cmd.Parameters.AddWithValue("DateOfBirth", accountC.DoB);
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
            } else {
                return false;
            }
        }
        public bool VerifyExistingCustomer(Customer accountC) {
            bool exists = false;
            List<string> emails = new List<string>();
            string request = "SELECT Email FROM dbo.Customers";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand(request, connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        emails.Add(reader.GetString("Email"));
                    }
                }
            }
            foreach (var email in emails) {
                if (email == accountC.Email) {
                    exists = true;
                }
            }
            return exists;
        }

        public Account Login(Account account)
        {
            string AccountEmail = account.Email;
            string AccountPassword = account.Password;
            string email=null, password=null;
            //bool logged = false;
            Account LoggedAccount = null;
            //revoir manière de penser : chercher si le compte est contenu dans une des 2 tables, si c'est le cas crée une variable Account LoggedAccount=new Restorer() ou LoggedAccount=new customer
            if (account is Customer){
                string request = "SELECT Email,Password FROM dbo.Customers WHERE Email=@Email";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(request, connection);
                    cmd.Parameters.AddWithValue("Email", AccountEmail);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            email=reader.GetString("Email");
                            password=reader.GetString("Password");
                        }
                    }
                }
                if (email!=null){
                    var hash = password;
                    bool match = Hash.comparePassword(AccountPassword, hash);
                    if (match)
                    {
                        // logged = true;
                        // Est-ce ok ?
                        //methode qui stocke dans LoggedAccount l'objet correspondant de la db pour le return : GetCustomerByMail(string mail)
                        LoggedAccount=GetCustomerByMail(AccountEmail);
                    }
                }
            }else if (account is Restorer){
                string request = "SELECT Email,Password FROM dbo.Restorers";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(request, connection);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            email = reader.GetString("Email");
                            password = reader.GetString("Password");
                        }
                    }
                }
                if (email != null)
                {
                    var hash = password;
                    bool match = Hash.comparePassword(AccountPassword, hash);
                    if (match)
                    {
                        // logged = true;
                        // Est-ce ok ?
                        LoggedAccount=GetRestorerByMail(AccountEmail);
                        //methode qui stocke dans LoggedAccount l'objet correspondant de la db pour le return : GetRestorerByMail(string mail)
                    }
                }
            }
            return LoggedAccount;
        }

        public Customer GetCustomerByMail(string accountMail) {
            Customer customer = new Customer();


            string request = "SELECT CustomerId,FirstName,LastName,Gender,City,Address,PostalCode,PhoneNumber,DateOfBirth,Country FROM dbo.Customers WHERE Email=@Email";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("Email", accountMail);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {

                        customer.Id = reader.GetInt32("CustomerId");
                        customer.Firstname = reader.GetString("FirstName");
                        customer.Lastname = reader.GetString("LastName");
                        customer.Gender = reader.GetChar("Gender");
                        customer.City = reader.GetString("City");
                        customer.Address = reader.GetString("Address");
                        customer.Pc = reader.GetString("PostalCode");
                        customer.Tel = reader.GetString("PhoneNumber");
                        customer.DoB = reader.GetDateTime("DateOfBirth");
                        customer.Country = reader.GetString("Country");
                    }
                }
            }
            return customer;
        }
        public Restorer GetRestorerByMail(string accountMail) {
            Restorer restorer=new Restorer();


            string request = "SELECT RestorerId,FirstName,LastName,Gender,City,Address,PostalCode,PhoneNumber,Country FROM dbo.Restorers WHERE Email=@Email";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                SqlCommand cmd = new SqlCommand(request, connection);
                cmd.Parameters.AddWithValue("Email", accountMail);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {

                        restorer.Id = reader.GetInt32("RestorerId");
                        restorer.Firstname = reader.GetString("FirstName");
                        restorer.Lastname = reader.GetString("LastName");
                        restorer.Gender = reader.GetChar("Gender");
                        restorer.City = reader.GetString("City");
                        restorer.Address = reader.GetString("Address");
                        restorer.Pc = reader.GetString("PostalCode");
                        restorer.Tel = reader.GetString("PhoneNumber");
                        restorer.Country = reader.GetString("Country");
                    }
                }
            }
            return restorer;
        }
    }
}