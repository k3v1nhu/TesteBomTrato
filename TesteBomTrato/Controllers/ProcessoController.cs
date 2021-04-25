using Microsoft.AspNetCore.Mvc;
using TesteBomTrato.Data;
using TesteBomTrato.Repositories;
using TesteBomTrato.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TesteBomTrato.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessoController : ControllerBase
    {
        private readonly Context _context;
        public readonly IRepository _repo;

        public ProcessoController(Context context, IRepository repo)
        {
            _context = context;
            _repo = repo;

        }

        [HttpGet("byId/{id}")]
        public IActionResult Get(int id)
        {
            var proc = _context.Processos.FirstOrDefault(p => p.Id == id);
            if (proc == null) return BadRequest("Processo Não Encontrado");

            return Ok(_context.Processos);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Processos);
        }

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

        [HttpPut("{id}")]
        public IActionResult Put(int id, Processo processo)
        {
            var proc = _context.Processos.AsNoTracking().Where(p => p.Id == id).FirstOrDefault();
            if (proc == null) return BadRequest("Processo Não Encontrado");

            _repo.Update(processo);
            if(_repo.SaveChanges())
            {
                return Ok(processo);
            }

            return BadRequest("Ops... Tivemos um Problema!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Processo processo)
        {
            var proc = _context.Processos.AsNoTracking().Where(p => p.Id == id).FirstOrDefault();
            if (proc == null) return BadRequest("Processo Não Encontrado");

            _repo.Update(processo);
            if(_repo.SaveChanges())
            {
                return Ok(processo);
            }

            return BadRequest("Ops... Tivemos um Problema!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var proc = _context.Processos.FirstOrDefault(p => p.Id == id);
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