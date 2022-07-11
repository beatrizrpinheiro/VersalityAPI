using FilesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TermometroController : Controller
    {
        private readonly FilesContext _dbContext;

        public TermometroController(FilesContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.Termometro.ToListAsync());
        }

        //POST API TERMOMETRO_DE_SALA
        [HttpPost]
        public IActionResult Post([FromBody] Termometro termometro)
        {
            try
            {
                _dbContext.Termometro.Add(termometro);
                _dbContext.SaveChanges();
            }
            catch(Exception e)
            {

            }

            return Ok(termometro);
        }
    }
}
