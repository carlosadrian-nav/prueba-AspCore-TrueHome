namespace TrueHome.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> GetById(int id);
        IQueryable<T> GetAll();
        void Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        void SaveChanges();
    }
}
