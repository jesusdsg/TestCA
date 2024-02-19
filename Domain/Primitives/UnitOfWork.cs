
namespace Domain.Primitives;

public interface UnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
