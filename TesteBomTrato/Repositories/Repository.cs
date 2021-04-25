using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteBomTrato.Data;
using TesteBomTrato.Models;

namespace TesteBomTrato.Repositories
{
    public class Repository : IRepository
    {
        public readonly Context _context;
        public Repository(Context context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
        public Processo GetProcessosById(int processoId)
        {
            IQueryable<Processo> query = _context.Processos;

            query = query.AsNoTracking()
                            .OrderBy(p => p.Id)
                            .Where(processo => processo.Id == processoId);

            return query.FirstOrDefault();
        }

        public async Task<Processo[]> GetAllProcessosAsync()
        {
            IQueryable<Processo> query = _context.Processos;

            query = query.AsNoTracking()
                            .OrderBy(p => p.Id);

            return await query.ToArrayAsync();
        }
    }
}