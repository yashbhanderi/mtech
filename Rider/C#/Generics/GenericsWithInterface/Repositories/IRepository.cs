using Rider.C_.Generics.Entities;

namespace Rider.C_.Generics.GenericsWithInterface.Repositories;

// Class is not needed to provide ref type
// IEntity also not needed..BUT If we provide..This Ensure that IRepository interface will
// Only use for IEntity Type...Not for other type
public interface IRepository<T> where T : IEntity
{
    void Add(T item);
    T? GetById(int id);
    void Remove(T item);
    void Save();
}