// using Rider.C_.Generics.Entities;
// using Rider.C_.Generics.GenericsWithInterface.Data;
// using Rider.C_.Generics.GenericsWithInterface.Repositories;
//
// namespace Rider.C_.Generics.GenericsWithInterface;
//
// public class StorageApp
// {
//
//     public static void Main(string[] args)
//     {
//         // var itemAdded = new ItemAdded<Employee>(EmployeeAdded);
//         // var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext(), EmployeeAdded);      <--- Direct send
//         // var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext(), itemAdded);
//         
//         // employeeRepository.ItemAdded += EmployeeAdded;   <--- Event with Action Delegate
//         
//         var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
//         employeeRepository.ItemAdded += employeeRepository_ItemAdded;
//         AddEmployee(employeeRepository);
//         
//         // Contravariance <- in keyword        
//         // ItemAdded<Manager> managerDel = itemAdded;
//
//         // Can't Possible
//         // Child c = new Base(); ❌
//         // Base b = new Child(); 👍
//         // IRepository<Manager> repo = new SqlRepository<Employee>();
//         
//         // Contravarience : Allows a method with the paramter of Base class ⬅️
//         // To be assgined to a delegate that expects -----> parameter of derived 
//         // NOWWW....  Child c = new Base(); 👍
//         
//         // Here..Same Scenario  -----> employeeRepo is type of Employee Generic
//         // But Assign to Manager type --> Can't Possible ❌
//         // SOOO... To Bypass this..Contravariance is used !!!!
//         
//         
//         // AddManagers(employeeRepository);
//         // WriteAllConsole(employeeRepository);    
//         
//         var organizationRepository = new ListRepository<Organization>();
//         // AddOrganization(organizationRepository);
//         // WriteAllConsole(organizationRepository);
//
//     }
//
//     private static void employeeRepository_ItemAdded(object? sender, Employee e)
//     {
//         Console.WriteLine($"Success !!!  {e._name} is added");
//     }
//
//     // private static void EmployeeAdded(Employee item)     <--- Delegate Example
//     // {
//     // }
//
//
//     // Generic Type Params are by def -----------> Coveriant Type <----------------------
//     // Which means They have to have exactly same type as class type that impliment the interface ( i.e. Employee or Org )
//     // Ex. IRepository<Organization> repo = new List<Organization>();  
//     // Cna't use IEntity ^ Here...Even if it is interface of Emp and Org
//     
//     // BUTTTTT, There's an exception ( Which is always there )
//     
//     // We can use GET (PRINTING) Method Without Being Specific about generic type 👍
//
//     // For, Add method..We have to be specific
//     // ....  Add ( IEntity item ) <-- It doesn't work ❌ 
//
//     private static void WriteAllConsole(IReadRepository<IEntity> repository)
//     {
//         var items = repository.GetAll();
//         // var oList = organizationRepository.GetAll();
//
//         foreach (var item in items)
//         {
//             Console.WriteLine(item);
//         }
//     }
//     
//     private static void AddManagers(IWriteRepository<Manager> managerRepository)
//     {
//         var manager = new Manager() { _name = "MS Dhoni" };
//         var managerCopy = manager.Copy();
//         managerRepository.Add(manager);
//
//         if (managerCopy is not null)
//         {
//             managerCopy._name += " | Copy";
//             managerRepository.Add(managerCopy);
//         }
//         
//         managerRepository.Add(new Manager() {_name = "Tony Stark"});
//         managerRepository.Add(new Manager() {_name = "Peter Parker"});
//         managerRepository.Add(new Manager() {_name = "Bruce Wayne"});
//         
//         managerRepository.Save();
//     }
//
//     private static void AddEmployee(SqlRepository<Employee> employeeRepository)
//     {
//         var employeeArr = new Employee[]
//         {
//             new Employee { _name = "Yash Bhanderi" }, 
//             new Employee { _name = "John Doe" },
//             new Employee { _name = "Mark Tailor" }
//         };
//         
//         // ➡️ Generic Methods
//         // AddBatch<Employee>(employeeRepository, employeeArr);
//         // AddBatch(employeeRepository, employeeArr);
//         
//         // ➡️ Generic Extension Methods
//         
//         employeeRepository.AddBatch(employeeArr);
//             
//         // employeeRepository.Add(new Employee{_name = "Yash Bhanderi"});
//         // employeeRepository.Add(new Employee{_name = "John Doe"});
//         // employeeRepository.Add(new Employee{_name = "Mark Tailor"});
//         // employeeRepository.GetById(2);
//         // employeeRepository.Save();
//     }
//     
//     private static void AddOrganization(ListRepository<Organization> organizationRepository)
//     {
//         var organizationArr = new Organization[]
//         {
//             new Organization { _name = "Google" },
//             new Organization { _name = "Microsoft" },
//             new Organization { _name = "Apple" }
//         };
//         organizationRepository.AddBatch(organizationArr);
//         // AddBatch(organizationRepository, organizationArr);
//         // organizationRepository.Add(new Organization{_name = "Google"});
//         // organizationRepository.Add(new Organization{_name = "Microsoft"});
//         // organizationRepository.Add(new Organization{_name = "Apple"});
//         // organizationRepository.Save();
//     }
//
//     // private static void AddBatch<T>(IRepository<T> repository, T[] arr) where T : IEntity  <--- Where is compulsary if I do not specify interface
//
// }