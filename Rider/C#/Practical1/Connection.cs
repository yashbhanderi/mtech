using MySql.Data.MySqlClient;

namespace Rider.C_.Practical1
{
    public static class Connection
    {
        public static readonly MySqlConnection MySqlConnection =
            new("Server=localhost;Port=3306;Database=practical1;Uid=root;Pwd=Yy@8140279748;");
    }
}