using TesteBomTrato.Models;

namespace TesteBomTrato.Repositories
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        Processo GetProcessosById(int processoId);
        Processo[] GetAllProcessos();
    }
}