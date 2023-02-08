// namespace Rider
// {
//     
//     public class User
//     {
//         public string name;
//         public int id;
//
//         public override string ToString()
//         {
//             return $"ID: {id}, Name: {name}";
//         }
//     }
//     class Program
//     {
//
//         interface IGetData<T>
//         {
//             public void GetData();
//         } 
//
//         interface IAddData<T>
//         {
//             public void AddData(T x);
//         }
//
//         class Database<T> : IGetData<T>, IAddData<T>
//         {
//             private List<T> ls = new();
//
//             public void GetData()
//             {
//                 foreach (var user in ls)
//                 {
//                     Console.WriteLine(user);
//                 }
//             }
//             public void AddData(T item)
//             {
//                 ls.Add(item);
//             }
//         }
//
//         public static void Main()
//         {
//             // User u1 = new User() {name="Yash Bhanderi"};
//             // User u2 = new User() {name="Kent Clarke"};
//             // User u3 = new User() {name="Robert Downey"};
//
//             var d = new Database<User>();
//             d.AddData(new User() {name="Yash Bhanderi"});
//             d.AddData(new User() {name="Kent Clarke"});
//             d.AddData(new User() {name="Robert Downey"});
//             
//             d.GetData();
//         }
//     }
// }
