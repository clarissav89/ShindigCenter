using System;
using System.ComponentModel.DataAnnotations;

namespace ActivityCenter.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        public string userEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string userPassword { get; set; }
    }
}