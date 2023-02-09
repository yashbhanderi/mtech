using Rider.C_.Generics.Entities;
using Rider.C_.Generics.GenericsWithInterface.Data;
using Rider.C_.Generics.GenericsWithInterface.Repositories;

namespace Rider.C_.Generics.GenericsWithInterface;

public class StorageApp
{

    public static void Main(string[] args)
    {
        var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
        AddEmployee(employeeRepository);
        WriteAllConsole(employeeRepository);    
        
        var organizationRepository = new ListRepository<Organization>();
        AddOrganization(organizationRepository);
        WriteAllConsole(organizationRepository);

    }
    
    
    // Generic Type Params are by def -----------> Coveriant Type <----------------------
    // Which means They have to have exactly same type as class type that impliment the interface ( i.e. Employee or Org )
    // Ex. IRepository<Organization> repo = new List<Organization>();  
    // Cna't use IEntity ^ Here...Even if it is interface of Emp and Org
    
    // BUTTTTT, There's an exception ( Which is always there )
    
    // We can use GET (PRINTING) Method Without Being Specific about generic type 👍

    // For, Add method..We have to be specific
    // ....  Add ( IEntity item ) <-- It doesn't work ❌ 

    private static void WriteAllConsole(IReadRepository<IEntity> repository)
    {
        var items = repository.GetAll();
        // var oList = organizationRepository.GetAll();

        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    private static void AddEmployee(SqlRepository<Employee> employeeRepository)
    {
        employeeRepository.Add(new Employee{_name = "Yash Bhanderi"});
        employeeRepository.Add(new Employee{_name = "John Doe"});
        employeeRepository.Add(new Employee{_name = "Mark Tailor"});
        // employeeRepository.GetById(2);
        // employeeRepository.Save();
    }
    
    private static void AddOrganization(ListRepository<Organization> organizationRepository)
    {
        organizationRepository.Add(new Organization{_name = "Google"});
        organizationRepository.Add(new Organization{_name = "Microsoft"});
        organizationRepository.Add(new Organization{_name = "Apple"});
        // organizationRepository.Save();
    }
}