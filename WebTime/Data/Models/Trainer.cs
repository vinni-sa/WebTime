using System.ComponentModel.DataAnnotations;

namespace WebTime.Data.Models
{
    public class Trainer
    {
        [Key] public int IdTrainer { get; set; }
        public string NameTrainer { get; set; }
        public string SurnameTrainer { get; set; }
    }
}