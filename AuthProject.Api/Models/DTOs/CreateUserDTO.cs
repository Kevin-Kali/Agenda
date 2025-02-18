namespace AuthProject.Api.Models.DTOs
{
    public class CreateUserDTO
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
