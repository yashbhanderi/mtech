using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rider.C_.Generics.Entities;

namespace Rider.C_.Generics.GenericsWithInterface.Data;

// DbContext is a class in Entity Framework Core that serves as a gateway to the database.
//     It is responsible for managing the connections to the database, executing the queries, and retrieving the results. 
//     The DbContext class allows you to query data, add, modify and delete entities, and persist changes back to the database. 
//     It also contains information about the entities and relationships in your model 
// and acts as a unit of work that tracks changes made to entities during a business transaction.
 
public class StorageAppDbContext : DbContext
{
    // DbSet is a class in Entity Framework Core that represents a collection of entities in the database. 
    //     It allows you to perform various CRUD (Create, Read, Update, Delete) operations on a database table 
    //     and serves as a bridge between the database and the application.
    //     You can define a DbSet property in your DbContext class ---------->  for each table in the database !!!!!, 
    //     and Entity Framework will use this information to interact with the database on your behalf.
    // public DbSet<Employee>? Employees { get; set; }
    
    // Set<T>  returns DbSet<T> entity
    public DbSet<Employee> Employee => Set<Employee>();
    public DbSet<Organization> Organization => Set<Organization>();
    
    // By overriding this method, you can provide custom configuration for your context that is specific to your application. 
    //     This can be useful for setting different connection strings for different environments 
    //     (such as development, testing, and production)
    
    // public StorageAppDbContext(DbContextOptions<StorageAppDbContext> options) : base(options)
    // {

    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //     base.OnModelCreating(builder);
    // }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("StorageAppDb");
    }
}