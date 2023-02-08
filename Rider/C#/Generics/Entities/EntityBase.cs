using System.ComponentModel.DataAnnotations;

namespace Rider.C_.Generics.Entities;

public class EntityBase : IEntity
{   
    [Key]
    public int _id { get; set; }
}