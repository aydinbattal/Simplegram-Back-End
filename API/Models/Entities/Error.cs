using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities
{
    public class Error
    {
        public int Status { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
    }
}