using System.ComponentModel.DataAnnotations;

namespace WebTime.Data.Models
{
    public class Admin
    {
        [Key] public int Id { get; set; }
        public Club Club { get; set; }
    }
}