using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CoreFileUploadSvcProto.Controllers
{
    [Route("api/[controller]")]
    public class FileController : Controller
    {
        // POST: /Account/Register
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null) throw new Exception("File is null");
            if (file.Length == 0) throw new Exception("File is empty");

            using (Stream stream = file.OpenReadStream())
            {
                using (var binaryReader = new BinaryReader(stream))
                {
                    var fileContent = binaryReader.ReadBytes((int)file.Length);
                    //await _uploadService.AddFile(fileContent, file.FileName, file.ContentType);
                }
            }
        return Ok("it worked");
        }
    }
}
