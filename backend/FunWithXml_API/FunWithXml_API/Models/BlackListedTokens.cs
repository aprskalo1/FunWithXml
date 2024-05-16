using System.ComponentModel.DataAnnotations;

namespace FunWithXml_API.Models
{
    public class BlackListedTokens
    {
        [Key]
        public Guid Id { get; set; }

        public string Token { get; set; }
    }
}
