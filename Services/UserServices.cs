using React5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Threading.Tasks;
using System.Data.SQLite;
using React5.Database;
using React5.Functions;

namespace React5.Services
{
    public class UserServices
    {
        public static bool RegisterUser(User user)
        {
            bool valid = false;
            if (!UserFunction.ValidateCredentials(user, "Register"))  /*validate credentials on backend side*/
            {
                Console.WriteLine("Credentials required");
                return false;  // redirect to signup page
            }
            DatabaseCon con = new DatabaseCon();
            try
            {
                string mail = Convert.ToString(user.mail);
                string pass = Convert.ToString(user.hashpassword);
                string hashed = UserFunction.ComputeSha256Hash(pass);
                string username = Convert.ToString(user.username);
                con.OpenConnection();
                string query = "insert into user ('username', 'hashpassword', 'mail', 'rating') values(@username, @hashpassword, @mail, @rating)";
                SQLiteCommand comm = new SQLiteCommand(query, con.myConnection);
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@hashpassword", hashed);
                comm.Parameters.AddWithValue("@mail", mail);
                comm.Parameters.AddWithValue("@rating", 0);
                var res = comm.ExecuteNonQuery();
                valid = true;
            }
            catch (Exception ex) {
               Console.WriteLine(ex.Message);
            }
            finally
            {
                con.CloseConnetion();
            }
            return valid;

        }
        public static bool LoginUser(User user)
        {
            bool valid = false;
            if (!UserFunction.ValidateCredentials(user, "Login"))
                return valid;
            DatabaseCon con = new DatabaseCon();
            try
            {
                string mail = Convert.ToString(user.mail);
                string pass = Convert.ToString(user.hashpassword);
                string hashed = UserFunction.ComputeSha256Hash(pass);
                con.OpenConnection();
                string query = "SELECT * FROM user where mail=@mail";
                SQLiteCommand myCommand = new SQLiteCommand(query, con.myConnection);
                myCommand.Parameters.AddWithValue("@mail", mail);
                SQLiteDataReader result = myCommand.ExecuteReader();
                if (result.HasRows)
                {

                    while (result.Read())
                    {
                        string pass_db = Convert.ToString(result["hashpassword"]);
                        if (pass_db == hashed)
                        {
                            valid = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.CloseConnetion();
            }
            return valid;
        }
    
    }
}
