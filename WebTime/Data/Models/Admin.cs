﻿using System.ComponentModel.DataAnnotations;

namespace WebTime.Data.Models
{
    public class Admin
    {
        [Key] public int IdAdmin { get; set; }
        public int IdClub { get; set; }
    }
}