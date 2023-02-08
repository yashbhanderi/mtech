// using generics.Entites;
// using Rider.C_.Generics.StorageApp;
//
// namespace generics;
//
// public class StorageApp
// {
//
//     public static void Main(string[] args)
//     {
//         var EmployeeRepository = new StorageAppGeneric<Employee>();
//         EmployeeRepository.Add(new Employee{_name = "Yash Bhanderi"});
//         EmployeeRepository.Add(new Employee{_name = "John Doe"});
//         EmployeeRepository.Add(new Employee{_name = "Mark Tailor"});
//         //
//         // EmployeeRepository.Save();
//         
//         var OrganizationRepository = new StorageAppGeneric<Organization>();
//         OrganizationRepository.Add(new Organization{_name = "Google"});
//         OrganizationRepository.Add(new Organization{_name = "Microsoft"});
//         OrganizationRepository.Add(new Organization{_name = "Apple"});
//         
//         // OrganizationRepository.Save();
//
//         var EmployeeRepositoryWithRm = new StorageAppGenericWithRemove<Employee>();
//         EmployeeRepositoryWithRm.Add(new Employee() {_name = "Ellen"});
//         EmployeeRepositoryWithRm.Add(new Employee() {_name = "Sansa"});
//         EmployeeRepositoryWithRm.Add(new Employee() {_name = "Tylor"});
//         
//         EmployeeRepositoryWithRm.Save();
//
//         EmployeeRepositoryWithRm.Remove(new Employee() {_name = "Sansa"});
//         // Console.WriteLine();
//         EmployeeRepositoryWithRm.Save();
//         
//         // where T = EntityBase is given
//         // Here, I can still send Employee Type Generic
//         // BCZZ Employee is Child Class of EntityBase
//         var EmployeeRepositoryWithConstraint = new StorageAppGeneric<Employee>();
//
//         // Console.WriteLine(EmployeeRepository.GetById(1));
//     }
// }