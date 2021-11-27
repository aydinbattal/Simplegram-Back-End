using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.Entities;

namespace API.Models.DTOs
{
    public class ImageDetailDTO
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string User_name { get; set; }
        public Guid User_id { get; set; }
        public List<String> Tags { get; set; }
    }
}