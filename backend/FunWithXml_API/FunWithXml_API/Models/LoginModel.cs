using System.ComponentModel.DataAnnotations;

namespace FunWithXml_API.Models
{
    public class LoginModel
    {
        [Key]
        [System.Text.Json.Serialization.JsonIgnore]
        public Guid Id { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public string? RefreshToken { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
