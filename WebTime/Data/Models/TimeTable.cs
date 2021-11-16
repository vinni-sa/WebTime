using System.ComponentModel.DataAnnotations;

namespace WebTime.Data.Models
{
    public class TimeTable
    {
        [Key] public int IdUser { get; set; }
        public int IdAdmin { get; set; }
        public string Time { get; set; }
        public int IdTrainer { get; set; }
        public int IdHall { get; set; }
        public int ClientCount { get; set; }
        public string NameTraining { get; set; }
        public string TypeTraining { get; set; }
    }
}