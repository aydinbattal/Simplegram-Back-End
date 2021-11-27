using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.DTOs
{
    public class ResultDTO
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
    }
}