using System;
using MySql.Data.MySqlClient;
namespace MentalHealth
{
    public class User
    {
        static string connectionString = "server=localhost;uid=root;pwd=root@123;database=Relevantz";
        public void Adduser()
        {
            Console.WriteLine("Enter user id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter user name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter user mood: ");
            string mood = Console.ReadLine();
            Console.WriteLine("Enter user sleeptime: ");
            string sleeptime = Console.ReadLine();
            Console.WriteLine("Enter recommendation for user: ");
            string recommendation = Console.ReadLine();
            Console.WriteLine("Enter therapist for user: ");
            string therapist = Console.ReadLine();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO users (id, name, mood, sleeptime, recommendation,therapist) VALUES (@id, @name, @mood, @sleeptime, @recommendation,@therapist)";
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@mood", mood);
            command.Parameters.AddWithValue("@sleeptime", sleeptime);
            command.Parameters.AddWithValue("@recommendation", recommendation);
            command.Parameters.AddWithValue("@therapist", therapist);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("User added successfully");

        }
        public void Searchuser()
        {
            Console.WriteLine("Enter user id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM users WHERE id = @id";
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("id:{0}", reader["id"]);
                Console.WriteLine("name:{0}", reader["name"]);
                Console.WriteLine("mood:{0}", reader["mood"]);
                Console.WriteLine("sleeptime:{0}", reader["sleeptime"]);
                Console.WriteLine("recommendation:{0}", reader["recommendation"]);
                Console.WriteLine("therapist:{0}", reader["therapist"]);
            }
            connection.Close();
        }
        public void Updateuser()
        {
            Console.WriteLine("Enter user id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter user name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter user mood: ");
            string mood = Console.ReadLine();
            Console.WriteLine("Enter user sleeptime: ");
            string sleeptime = Console.ReadLine();
            Console.WriteLine("Enter recommendation for user: ");
            string recommendation = Console.ReadLine();
            Console.WriteLine("Enter therapist for user: ");
            string therapist = Console.ReadLine();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE users SET name = @name, mood = @mood, sleeptime = @sleeptime, recommendation = @recommendation, therapist = @therapist WHERE id = @id";
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@mood", mood);
            command.Parameters.AddWithValue("@sleeptime", sleeptime);
            command.Parameters.AddWithValue("@recommendation", recommendation);
            command.Parameters.AddWithValue("@therapist", therapist);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("User updated successfully");
        }
        public void Deleteuser()
        {
            Console.WriteLine("Enter user id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM users WHERE id = @id";
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("User deleted successfully");
        }
        public void Displayuser()
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM users";
            using var command = new MySqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("id:{0}", reader["id"]);
                Console.WriteLine("name:{0}", reader["name"]);
                Console.WriteLine("mood:{0}", reader["mood"]);
                Console.WriteLine("sleeptime:{0}", reader["sleeptime"]);
                Console.WriteLine("recommendation:{0}", reader["recommendation"]);
                Console.WriteLine("therapist:{0}", reader["therapist"]);
            }
            connection.Close();
        }
    }
}