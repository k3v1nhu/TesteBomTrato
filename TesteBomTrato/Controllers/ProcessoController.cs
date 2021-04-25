using Microsoft.AspNetCore.Mvc;
using TesteBomTrato.Data;
using TesteBomTrato.Repositories;
using TesteBomTrato.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TesteBomTrato.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessoController : ControllerBase
    {
        public readonly IRepository _repo;

        public ProcessoController(IRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Utilize este método para retornar todos os processos cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _repo.GetAllProcessosAsync();
            return Ok(result);
        }

        /// <summary>
        /// Utilize este método para retornar um processo com base em seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            var result = _repo.GetProcessosById(id);
            if (result == null) return BadRequest("O Processo não foi Encontrado!");

            return Ok(result);
        }

        /// <summary>
        /// Utilize este método para cadastrar um novo processo
        /// </summary>
        /// <param name="processo"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Processo processo)
        {
            _repo.Add(processo);
            if(_repo.SaveChanges())
            {
                return Ok(processo);
            }

            return BadRequest("Ops... O Processo Não Foi Cadastrado!");
        }

        /// <summary>
        /// Utilize este método para modificar informações de um dos processos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="processo"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Processo processo)
        {
            var proc = _repo.GetProcessosById(id);
            if (proc == null) return BadRequest("Processo Não Encontrado");

            _repo.Update(processo);
            if(_repo.SaveChanges())
            {
                return Ok(processo);
            }

            return BadRequest("Ops... Tivemos um Problema!");
        }

        /// <summary>
        /// Utilize este método para ajustar um dos processos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="processo"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Processo processo)
        {
            var proc = _repo.GetProcessosById(id);
            if (proc == null) return BadRequest("Processo Não Encontrado");

            _repo.Update(processo);
            if(_repo.SaveChanges())
            {
                return Ok(processo);
            }

            return BadRequest("Ops... Tivemos um Problema!");
        }

        /// <summary>
        /// Utilize este método para deletar um processo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var proc = _repo.GetProcessosById(id);
            if (proc == null) return BadRequest("Processo Não Encontrado");

            _repo.Delete(proc);
            if(_repo.SaveChanges())
            {
                return Ok("Processo Deletado!");
            }

            return BadRequest("Ops... O Processo Não Foi Deletado!");
        }
    }
}