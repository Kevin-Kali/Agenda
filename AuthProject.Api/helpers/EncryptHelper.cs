using System.Security.Cryptography;
using System.Text;

namespace AuthProject.Api.helpers
{
    public class EncryptHelper
    {
        public static string EncryptPassword(string password) => BCrypt.Net.BCrypt.HashPassword(password);

        public static bool VerifyPassword(string enteredPassword, string storedPasswordHash) => BCrypt.Net.BCrypt.Verify(enteredPassword, storedPasswordHash);
    }
}
