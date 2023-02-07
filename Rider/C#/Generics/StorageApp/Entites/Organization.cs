namespace generics.Entites;

public class Organization : EntityBase
{
    // public int _id { get; set; }
    public string? _name { get; set; }

    public override string ToString()
    {
        return $"ID: {_id}, Name: {_name}\n";
    }
}