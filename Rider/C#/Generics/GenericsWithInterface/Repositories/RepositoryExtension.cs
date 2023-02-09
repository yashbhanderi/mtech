using Rider.C_.Generics.Entities;

namespace Rider.C_.Generics.GenericsWithInterface.Repositories;

public static class RepositoryExtension
{
    public static void AddBatch<T>(this IWriteRepository<T> repository, T[] arr) where T : IEntity
    {
        foreach (var item in arr)
        {   
            repository.Add(item);
        }

        repository.Save();
    }
}