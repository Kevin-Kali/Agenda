using System.ComponentModel.DataAnnotations;

namespace AuthProject.Api.Models
{
    public class User
    {
        [StringLength(150)]
        public string UserName { get; set; } = String.Empty;

        public string PasswordHash { get; set; } = String.Empty;
    }
}
