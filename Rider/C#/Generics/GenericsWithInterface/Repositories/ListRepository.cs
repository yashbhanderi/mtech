using Rider.C_.Generics.Entities;

namespace Rider.C_.Generics.GenericsWithInterface.Repositories;

public class ListRepository<T>: IRepository<T> where T : class, IEntity
{
    // private readonly List<T> _items = new();
    protected readonly List<T> _items = new();

    public IEnumerable<T> GetAll()
    {
        return _items.ToList();
    }

    public void Add(T item)
    {
        item._id = _items.Count + 1;
        _items.Add(item);
    }

    public T GetById(int id)
    {
        return _items.Single(item => item._id == id);
    }
    
    public void Remove(T item)
    {   

        int index = _items.FindIndex(emp => item.ToString().Equals(emp.ToString()));
        _items.RemoveAt(index);
    }

    public void Save()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item.ToString());     
        }
    }
}