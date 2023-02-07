namespace generics.Entites;

public class Employee : EntityBase
{
    // public int _id { get; set; }
    public string? _name { get; set; }
    
    // IMPPPPPPPPPPPPP !!!!!
    // When we log any object -------->   Class.Object  <---- will print
    // BUTT We have to change it for better purposes bcz It can use in traversal of objects
    // SOOOOO... We have to override it's default settings
    // THATT'sss Whyyy.. We can use ToString or Just as it is object...
    // ANDDD.. IT'll call override ToString Methoddd !!!!!!!!
    public override string ToString()
    {
        return $"ID: {_id}, Name: {_name}\n";
    }
}