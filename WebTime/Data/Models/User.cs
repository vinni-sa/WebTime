using System.ComponentModel.DataAnnotations;

namespace WebTime.Data.Models
{
    public class User
    {
        [Key] public int IdUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}