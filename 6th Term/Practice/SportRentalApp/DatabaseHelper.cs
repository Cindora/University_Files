using Npgsql;
using System.Data;

namespace SportRentalApp
{
    public static class DatabaseHelper
    {
        // Строка подключения (измените под свой пароль, порт, имя БД)
        public static string connectionString = "Host=localhost;Port=5432;Database=sport_rental;Username=admin;Password=admin";

        public static DataTable ExecuteQuery(string query, params NpgsqlParameter[] parameters)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    DataTable dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    return dt;
                }
            }
        }

        public static int ExecuteNonQuery(string query, params NpgsqlParameter[] parameters)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}