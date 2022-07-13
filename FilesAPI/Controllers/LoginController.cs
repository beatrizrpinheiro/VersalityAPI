using FilesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly FilesContext _dbContext;

        public LoginController(FilesContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.Login.ToListAsync());
        }

        //POST API LOGIN
        [HttpPost]
        public IActionResult Post([FromBody] Login login)
        {
            try
            {
                _dbContext.Login.Add(login);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");  
            }

            return Ok(login);
        }
    }
}
