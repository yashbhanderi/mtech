namespace generics;

public class SimpleStack<T>
{
    // Since It is readonly, we can initialize later..
    
    // If it is double...We can only add object values
    // If we want to add string values or anny other than object
    // We have 3 options
    // 1) double -> object
    // 2) copy and paste (for given type)
    // 3) generics
    
    // 1) object method:
    // 1. Boxing-Unboxing
    // first double will be boxing --> object
    // Then... object --> double
    // This boxing unboxing takes memory space
    // And It will cause performance issues in large data handling
    // 2. Type-safety OVERRR!
    // Now we can push any type of item in the stack
    // SOOOO... There is no type safety anymore..and it can cause error during printing, calculations or anything
    
    // 2) copy paste <---- No chance
    
    

    // private readonly object[] _items;
    // private int _count = -1;
    //
    // public SimpleStack() => _items = new object[10];
    //
    // public void Push(object x) => _items[++_count] = x;
    //
    // public int Count() => _count+1;
    //
    // public object Pop() => _items[_count--];
    
    
    private readonly T[] _items;
    private int _count = -1;
    
    public SimpleStack() => _items = new T[10];
    
    public void Push(T x) => _items[++_count] = x;
    
    public int Count() => _count+1;
    
    public T Pop() => _items[_count--];
}
