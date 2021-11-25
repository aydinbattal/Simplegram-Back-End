using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.Entities;
using API.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImagesController : ControllerBase
    {
        private readonly DataContext _context;

        public ImagesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetImages([FromQuery] int pageNumber, int pageSize)
        {


            var result = _context.Images.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            var totalRecords = await _context.Images.CountAsync();

            var response = ResponseHelper<Image>.GetPagedResponse("/api/images", result, pageNumber, pageSize, totalRecords);

            return Ok(response);
        }
    }
}