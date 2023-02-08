using Rider.C_.Generics.Entities;
using Rider.C_.Generics.GenericsWithInterface.Data;
using Rider.C_.Generics.GenericsWithInterface.Repositories;

namespace Rider.C_.Generics.GenericsWithInterface;

public class StorageApp
{

    public static void Main(string[] args)
    {
        var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
        var organizationRepository = new ListRepository<Organization>();
        AddEmployee(employeeRepository);
        AddOrganization(organizationRepository);
    }

    private static void AddEmployee(SqlRepository<Employee> employeeRepository)
    {
        employeeRepository.Add(new Employee{_name = "Yash Bhanderi"});
        employeeRepository.Add(new Employee{_name = "John Doe"});
        employeeRepository.Add(new Employee{_name = "Mark Tailor"});
        employeeRepository.GetById(2);
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