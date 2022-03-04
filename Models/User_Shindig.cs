using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ActivityCenter.Models
{
    public class User_Shindig
    {
        [Key]
        public int user_ShindigId { get; set; }
        public int userId { get; set; }
        public User User { get; set; }
        public int shindigId { get; set; }
        public Shindig Shindig { get; set; }

    }
}