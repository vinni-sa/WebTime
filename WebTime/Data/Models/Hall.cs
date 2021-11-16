using System.ComponentModel.DataAnnotations;

namespace WebTime.Data.Models
{
    public class Hall
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
}