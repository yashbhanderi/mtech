// namespace Rider.C_.Generics.StorageApp.Entities;

using System.ComponentModel.DataAnnotations;

namespace Rider.C_.Generics.Entities;

public interface IEntity
{
    [Key]
    public int _id { get; set; }
}