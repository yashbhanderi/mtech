using Rider.C_.Generics.Entities;

namespace Rider.C_.Generics.GenericsWithInterface.Repositories;


// ➡️ In keyword
// Work only for input params
// More Specific
// It is used to implement Contravariance
// When using with reference types, it only prevents you from assigning a new reference. 😓
// The motivation of in is to be used with a struct to improve performance by declaring that the value will not be modified

public interface IWriteRepository<in T>
{
    void Add(T item);
    void Remove(T item);
    void Save();
}

// ➡️ Out keyword
// Work only for returning values
// Less Specific
// When We want to declare or pass the variable...<--- BUT We don't want to Initialize it at same time 😓
// It is used to implement Covariance

// Here.. To Bypass Covariance <- 😁
// We have only taken Read methods..Bcz out keyword can only use where It's okay to not be specific <- 🤷‍♂️
public interface IReadRepository<out T>
{
         IEnumerable<T> GetAll();
         T? GetById(int id);
}


// Class is not needed to provide ref type
// IEntity also not needed..BUT If we provide..This Ensure that IRepository interface will
// Only use for IEntity Type...Not for other type

// Here, We want to have this repo with in keyword for contravariance
// But it's not possible due to Base class with out param
// Sooo..We have to create separate interface with in param
public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : IEntity
{

}