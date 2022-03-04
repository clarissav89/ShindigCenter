using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ActivityCenter.Models
{
    public class Shindig
    {
        [Key]
        public int shindigId { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime startTime { get; set; }

        public int duration { get; set; }
        public string durationAmt { get; set; }

        public int userId { get; set; }
        public User UserRef { get; set; }

        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;

        public List<User_Shindig> connections { get; set; }
    }
}