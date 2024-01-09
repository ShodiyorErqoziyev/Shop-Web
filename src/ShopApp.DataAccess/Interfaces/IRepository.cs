using ShopApp.Domain.Entities;

namespace ShopApp.DataAccess.Interfaces;

public interface IRepository<T> where T : BaseEntitty
{
    public Task CreatedAsync(T entity);
    public Task UpdatedAsync(long id, T entity);
    public Task DeleteAsync(long id);
    public Task<T> GetByIdAsync(long id);
}
