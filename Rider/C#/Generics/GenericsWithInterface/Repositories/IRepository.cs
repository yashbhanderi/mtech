using Rider.C_.Generics.Entities;

namespace Rider.C_.Generics.GenericsWithInterface.Repositories;


// ➡️ Out keyword
// When We want to declare or pass the variable...<--- BUT We don't want to Initialize it at same time 😓
// Here.. To Bypass Coveriance <- 😁
// We have only taken Read methods..Bcz out keyword can only use where It's okay to not be specific <- 🤷‍♂️
public interface IReadRepository<out T>
{
         IEnumerable<T> GetAll();
         T? GetById(int id);
}


// Class is not needed to provide ref type
// IEntity also not needed..BUT If we provide..This Ensure that IRepository interface will
// Only use for IEntity Type...Not for other type
public interface IRepository<T> : IReadRepository<T> where T : IEntity
{
    void Add(T item);
    void Remove(T item);
    void Save();
}