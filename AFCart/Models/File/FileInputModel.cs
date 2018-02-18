using Microsoft.AspNetCore.Http;

namespace AFCartAPI.Models.File
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
