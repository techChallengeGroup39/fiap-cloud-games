using Core.Entity;
using Core.Input;
using Core.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiapCloudGamesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : Controller
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }




        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_roleRepository.ObterTodos());
            }
            catch (DbUpdateException dbEx)
            {
                return BadRequest(new { error = dbEx.InnerException?.Message ?? dbEx.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Internal server error", detail = ex.Message });
            }
        }



        [HttpGet("{guid:guid}")]
        public IActionResult Get([FromRoute]Guid guid)
        {
            try
            {
                return Ok(_roleRepository.ObterPorGuid(guid));
            }
            catch (DbUpdateException dbEx)
            {
                return BadRequest(new { error = dbEx.InnerException?.Message ?? dbEx.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Internal server error", detail = ex.Message });
            }
        }




        [HttpPost]
        public IActionResult Post([FromBody] RoleInput input)
        {
            var userName = User.Identity?.Name ?? "sistema" ; //Sera resolvido posteriormente com o sistema de autenticação
            try
            {
                var role = new Role()
                {
                    Nome = input.Nome,
                    CriadoPor = userName,
                    Status = input.Status,
                };
                _roleRepository.Cadastrar(role);
                return Ok();
            }
            catch (DbUpdateException dbEx)
            {
                return BadRequest(new { error = dbEx.InnerException?.Message ?? dbEx.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Internal server error", detail = ex.Message });
            }
        }



        [HttpPut]
        public IActionResult Put([FromBody] RoleUpdateInput input)
        {
            var userName = User.Identity?.Name ?? "sistema"; //Sera resolvido posteriormente com o sistema de autenticação
            try
            {
                var role = _roleRepository.ObterPorGuid(input.Guid);
                role.Nome = input.Nome;
                role.Status = input.Status;
                role.ModificadoPor = userName;
                role.DataModificacao = DateTime.Now;
                _roleRepository.Alterar(role);
                return Ok();
            }
            catch (DbUpdateException dbEx)
            {
                return BadRequest(new { error = dbEx.InnerException?.Message ?? dbEx.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Internal server error", detail = ex.Message });
            }
        }



        [HttpDelete("{guid:guid}")]
        public IActionResult Pelete([FromRoute] Guid guid)
        {
            var userName = User.Identity?.Name ?? "sistema"; //Sera resolvido posteriormente com o sistema de autenticação
            try
            {
               _roleRepository.Deletar(guid);
                return Ok();
            }
            catch (DbUpdateException dbEx)
            {
                return BadRequest(new { error = dbEx.InnerException?.Message ?? dbEx.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Internal server error", detail = ex.Message });
            }
        }
    }
}
