using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.DTOs;
using API.Models.Entities;
using API.Models.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User newUser)
        {
            var users = _context.Users;
            foreach (var u in users)
            {
                if (u.Email == newUser.Email)
                {
                    var errors = new List<Error>{
                        new Error{
                            Status = BadRequest().StatusCode,
                            Title = "Email already exists",
                            Detail = "This email already exists in the database"
                        }
                    };
                    return BadRequest(errors);
                }

            }

            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
            return Ok(newUser);
        }

        [HttpPost("{id}/image")]
        public async Task<IActionResult> AddImageToUser(string id, [FromBody] Image imageToAdd)
        {
            var user = await _context.Users.Include(x => x.Images)
                .SingleOrDefaultAsync(x => x.Id.Equals(new Guid(id)));

            var tags = new List<Tag>();
            foreach (var t in ImageHelper.GetTags(imageToAdd.Url))
            {
                tags.Add(new Tag
                {
                    Text = t
                });
            }

            var image = new Image
            {
                Url = imageToAdd.Url,
                PostingDate = DateTime.Now,
                Tags = tags
            };

            user.Images.Add(image);
            await _context.SaveChangesAsync();

            var lastImages = user.Images.OrderByDescending(x => x.PostingDate).Take(10);
            if (lastImages.Count() != 10)
                lastImages = user.Images.OrderByDescending(x => x.PostingDate);

            var urls = new List<string>();

            foreach (var l in lastImages)
            {
                urls.Add(l.Url);
            }

            var response = new AddImageDTO
            {
                Id = new Guid(id),
                Username = user.Name,
                Email = user.Email,
                ImagesUrls = urls
            };

            return Ok(new Response<AddImageDTO>(response));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserImages(string id)
        {
            var user = await _context.Users.Include(x => x.Images)
                .SingleOrDefaultAsync(x => x.Id.Equals(new Guid(id)));

            var lastImages = user.Images.OrderByDescending(x => x.PostingDate).Take(10);
            if (lastImages.Count() != 10)
                lastImages = user.Images.OrderByDescending(x => x.PostingDate);

            var urls = new List<string>();

            foreach (var l in lastImages)
            {
                urls.Add(l.Url);
            }

            var response = new AddImageDTO
            {
                Id = new Guid(id),
                Username = user.Name,
                Email = user.Email,
                ImagesUrls = urls
            };

            return Ok(new Response<AddImageDTO>(response));
        }

        [HttpGet("{id}/images")]
        public async Task<IActionResult> GetAllUserImages(string id, [FromQuery] int pageNumber)
        {
            int pageSize = 10;

            //if nothing provided in query, return page 1
            if (pageNumber == 0)
                pageNumber = 1;

            var user = await _context.Users.Include(x => x.Images)
                .SingleOrDefaultAsync(x => x.Id.Equals(new Guid(id)));

            var totalRecords = user.Images.Count();

            var images = user.Images.Skip((pageNumber - 1) * pageSize).Take(pageSize).OrderByDescending(x => x.PostingDate);

            var result = new List<UserImagesDTO>();
            foreach (var i in images)
            {
                var resultDto = new UserImagesDTO
                {
                    Id = i.Id,
                    Url = i.Url
                };
                result.Add(resultDto);
            }

            var response = ResponseHelper<UserImagesDTO>.GetPagedResponse($"/api/users/{id}/images?", result, pageNumber, pageSize, totalRecords);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _context.Users.Include(x => x.Images)
                .SingleOrDefaultAsync(x => x.Id.Equals(new Guid(id)));

            foreach (var i in user.Images)
            {
                _context.Images.Remove(i);
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok("User is successfully removed");
        }
    }
}