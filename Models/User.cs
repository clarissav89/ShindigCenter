using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string name { get; set; }


        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*d)(?=.*[^da-zA-Z]).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at least one upper case letter, one lower case letter, a number (0-9) and a special character (e.g. !@#$%^&*)")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [NotMapped]
        [Compare("password")]
        [DataType(DataType.Password)]
        public string confirmPass { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;
        public List<User_Shindig> connections { get; set; }
        public List<Shindig> myShindig { get; set; }
    }
}