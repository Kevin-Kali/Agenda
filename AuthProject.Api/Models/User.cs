using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AuthProject.Api.Models
{
    [Index(nameof(UserName), IsUnique=true)]
    public class User
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string UserName { get; set; } = String.Empty;

        [StringLength(255)]
        public string PasswordHash { get; set; } = String.Empty;
    }
}
