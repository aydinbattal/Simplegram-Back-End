using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.Entities;

namespace API.Models.Responses
{
    public static class ResponseHelper<T>
    {
        public static PagedResponse<T> GetPagedResponse(string url, IEnumerable<T> data, int pageNumber, int pageSize, int totalImages)
        {
            var response = new PagedResponse<T>(data);
            int totalPages = (int)Math.Ceiling(totalImages / (double)pageSize);
            response.Meta.Add("totalPages", totalPages.ToString());
            response.Meta.Add("totalImages", totalImages.ToString());
            response.Links.Add("first", $"{url}?pagenumber=1&pagesize{pageSize}");
            response.Links.Add("last", $"{url}?pagenumber={totalPages}&pagesize{pageSize}");
            response.Links.Add("next", pageNumber == totalPages ? null : $"{url}?pagenumber={pageNumber + 1}&pagesize{pageSize}");
            response.Links.Add("previous", pageNumber == 1 ? null : $"{url}?pagenumber={pageNumber - 1}&pagesize{pageSize}");
            return response;
        }
    }
}