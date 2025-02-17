using System.Security.Cryptography;
using System.Text;

namespace AuthProject.Api.helpers
{
    public class EncryptHelper
    {
        public static string EncryptPassword(string password)
        {
            using var sha256Hash = SHA256.Create();

            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
                builder.Append(item.ToString("x2"));

            return builder.ToString();
        }
    }
}
