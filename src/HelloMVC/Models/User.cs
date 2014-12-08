using System;
using System.ComponentModel.DataAnnotations;

namespace HelloMVC.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
    }
}