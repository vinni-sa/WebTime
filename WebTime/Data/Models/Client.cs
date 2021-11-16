using System.ComponentModel.DataAnnotations;

namespace WebTime.Data.Models
{
    public class Client
    {
        [Key] public int IdClient { get; set; }
        public string TelephoneClient { get; set; }
    }
}