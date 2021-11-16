using System.ComponentModel.DataAnnotations;

namespace WebTime.Data.Models
{
    public class Booking
    {
        [Key] public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdTable { get; set; }
    }
}