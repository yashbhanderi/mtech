namespace Rider.C_.Generics.Entities;

public class Manager : Employee
{
    public override string ToString()
    {
        return $"ID: {_id}, Name: {_name} - Manager\n";
    }
}