using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> DownloadFile(string? name)
        {
            var fileName = System.IO.Path.GetFileName($"C:\\Files\\{name}");

            var content = await System.IO.File.ReadAllBytesAsync($"C:\\Files\\{name}");

            new FileExtensionContentTypeProvider()
                .TryGetContentType(fileName, out string contentType);

            return File(content, contentType, fileName);
        }

        [HttpGet("FileName")]
        public ActionResult GetFileName()
        {
            List<string> arquivos = new List<string>();
            DirectoryInfo d = new DirectoryInfo("C:\\Files"); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles();
            foreach (FileInfo file in Files)
            {
                arquivos.Add(file.Name);
            }

            return Ok(arquivos);
        }
    }
}