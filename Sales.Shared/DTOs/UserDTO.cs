using Sales.Shared.Entities;

namespace Sales.Shared.DTOs
{
    public class UserDTO : User
    {
        public string Password { get; set; } = null!;
    }
}
