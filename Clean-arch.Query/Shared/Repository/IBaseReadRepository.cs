namespace Clean_arch.Query.Shared.Repository
{
    public interface IBaseReadRepository<TEntity> where TEntity : BaseReadModel
    {
        Task Delete(long id);

        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(long id);

        Task Insert(TEntity entity);

        Task Update(TEntity entity);
    }
}