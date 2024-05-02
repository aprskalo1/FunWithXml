using System.ComponentModel.DataAnnotations;

namespace FunWithXml_API.Models
{
    public class LoginModel
    {
        [Key]
        [System.Text.Json.Serialization.JsonIgnore]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
