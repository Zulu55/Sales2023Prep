using Sales.Shared.Entities;

namespace Sales.Shared.DTOs
{
    public class TokenDTO
    {
        public string Token { get; set; } = null!;

        public DateTime Expiration { get; set; }

        public User User { get; set; } = null!;

    }
}
