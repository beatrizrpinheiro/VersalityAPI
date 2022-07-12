using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AulaController : Controller
    {

        private readonly FilesContext _dbContext;

        public AulaController(FilesContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dbContext.Aula.ToListAsync());
        }
    }
}
