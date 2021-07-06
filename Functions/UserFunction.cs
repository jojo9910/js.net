
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Threading.Tasks;
using React5.Models;

namespace React5.Functions
{
    public class UserFunction
    {
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static bool ValidateCredentials(User user, string opreation)
        {
            if (opreation == "Register")
            {
                if (user.username == "" || user.mail == "" || user.hashpassword == "")
                    return false;
            }
            else if (opreation == "Login")
            {
                if (user.mail == "" || user.hashpassword == "")
                    return false;
            }
            return true;

        }
    }
}
