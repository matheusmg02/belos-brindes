using System.ComponentModel.DataAnnotations;

namespace web_api.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Senha { get; set; }
        public int Token { get; set; } 
        public string Email { get; set; }

    }
}
