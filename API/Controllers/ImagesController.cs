using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.DTOs;
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
        public async Task<IActionResult> GetImages([FromQuery] int pageNumber)
        {
            int pageSize = 10;

            //if nothing provided in query, return page 1
            if (pageNumber == 0)
                pageNumber = 1;

            var totalRecords = await _context.Images.CountAsync();
            var images = _context.Images.Include(x => x.User).Skip((pageNumber - 1) * pageSize).Take(pageSize).OrderBy(x => x.PostingDate);
            var result = new List<ResultDTO>();

            foreach (var i in images)
            {
                var resultDto = new ResultDTO
                {
                    Id = i.Id,
                    Url = i.Url,
                    Username = i.User.Name
                };
                result.Add(resultDto);
            }

            var response = ResponseHelper<ResultDTO>.GetPagedResponse("/api/images", result, pageNumber, pageSize, totalRecords);

            return Ok(response);
        }
    }
}