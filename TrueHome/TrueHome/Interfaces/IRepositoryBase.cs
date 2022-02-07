namespace TrueHome.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll(T entity);
        void Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        void SaveChanges();
    }
}
