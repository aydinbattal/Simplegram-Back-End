using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Email should not be empty")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Name should not be empty")]
        public string Name { get; set; }
        public List<Image> Images { get; set; }
    }
}