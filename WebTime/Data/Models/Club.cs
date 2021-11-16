using System.ComponentModel.DataAnnotations;

namespace WebTime.Data.Models
{
    public class Club
    {
        [Key] public int IdClub { get; set; }
        public string NameClub { get; set; }
        public string AddressClub { get; set; }
        public string TelephoneClub { get; set; }
    }
}