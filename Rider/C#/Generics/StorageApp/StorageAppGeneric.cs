using generics.Entites;

namespace generics;

// public class StorageAppGeneric<T>
public class StorageAppGeneric<T> where T : EntityBase
{
    // private readonly List<T> _items = new();
    protected readonly List<T> _items = new();

    public void Add(T item)
    {
        item._id = _items.Count + 1;
        _items.Add(item);
    }

    public T GetById(int id)
    {
        // Here.. item => item.  <-- Get only four methods.. Bcz It is of type Generic 
        // But If we want to access Properties of the class
        // We have to use WHERE KEYWORD to specify particular class access
        
        // Single = Return only item satisfing condition
        // If more than one found <-- Gives error
        return _items.Single(item => item._id == id);
    }

    public void Save()
    {
        foreach (var item in _items)
        {   
            // IMPPPPPPPPPPPPP !!!!!
            // When we log any object -------->   Class.Object  <---- will print
            // BUTT We have to change it for better purposes bcz It can use in traversal of objects
            // SOOOOO... We have to override it's default settings
            // THATT'sss Whyyy.. We can use ToString or Just as it is object...
            // ANDDD.. IT'll call override ToString Methoddd !!!!!!!!
            Console.WriteLine(item.ToString());     
        }
    }
}

public class StorageAppGenericWithRemove<T> : StorageAppGeneric<T> where T : EntityBase
{
    public void Remove(T item)
    {   
        // First we are finding index of a item containg param item
        // Then removing it
        // int index = _items.FindIndex(emp => emp.ToString().Contains(item));
        
        // _items.Remove(_items[index]);
        // _items.RemoveAt(index);
        
        // This will find index of item given by parameter in the _items list
        int index = _items.FindIndex(emp => item.ToString().Equals(emp.ToString()));
        _items.RemoveAt(index);
    }
}

// public class StorageAppGenericWithMultipleParam<T> : StorageAppGeneric<T, Tkey>
// {
//     
// }

// public class StorageAppGenericWithConstraint<T> where T : EntityBase
// {
//     
// }


