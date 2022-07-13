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
            var usuario = _dbContext.Login.FirstOrDefault(x => x.Usuario == login.Usuario);
            if (usuario == null || usuario.Senha != login.Senha)
                return BadRequest();

            return Ok();
        }
    }
}
