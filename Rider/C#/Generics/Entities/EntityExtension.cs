using System.Text.Json;

namespace Rider.C_.Generics.Entities;

public static class EntityExtension
{
    public static T? Copy<T>(this T item) where T : IEntity
    {
        var json = JsonSerializer.Serialize<T>(item);
        return JsonSerializer.Deserialize<T>(json);
    }
}