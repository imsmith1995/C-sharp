using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PrsLibrary.Models;

namespace PrsLibrary.Controllers
{

    public class UsersController
    {
        public Connection connection = null;

        public UsersController(Connection conn) 
        {
            connection = conn;
        }

        public User? Login(string username, string password)
        {
            string sql = "SELECT * from Users Where Username = @Username and Password = @Password;";
            SqlCommand cmd = new(sql, connection.sqlConnection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            reader.Read();
            User user = new();
            user.Id = Convert.ToInt32(reader["Id"]);
            user.Username = Convert.ToString(reader["Username"])!;
            user.Password = Convert.ToString(reader["Password"])!;
            user.Firstname = Convert.ToString(reader["Firstname"])!;
            user.Lastname = Convert.ToString(reader["Lastname"])!;
            if (reader["Phone"] == System.DBNull.Value)
            {
                user.Phone = null;
            }
            else
            {
                user.Phone = user.Phone = Convert.ToString(reader["Phone"]);
            }if (reader["Email"] == System.DBNull.Value)
            {
                user.Email = null;
            }
            else
            {
                user.Email = user.Email = Convert.ToString(reader["Email"]);
            }
            user.IsReviewer = Convert.ToBoolean(reader["IsReviewer"]);
            user.IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
            reader.Close();
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            string sql = "SELECT * from Users;";
            SqlCommand cmd = new(sql, connection.sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<User> users = new();
            while (reader.Read())
            {
                User user = new();
                user.Id = Convert.ToInt32(reader["Id"]);
                user.Username = Convert.ToString(reader["Username"]);
                user.Password = Convert.ToString(reader["Password"]);
                user.Firstname = Convert.ToString(reader["Firstname"]);
                user.Lastname = Convert.ToString(reader["Lastname"]);
                if (reader["Phone"] == System.DBNull.Value)
                {
                    user.Phone = null;
                }
                else
                {
                    user.Phone = Convert.ToString(reader["Phone"]);
                }
                if (reader["Email"] == System.DBNull.Value)
                {
                    user.Email = null;
                }
                else
                {
                    user.Email = Convert.ToString(reader["Email"]);
                }
                user.IsReviewer = Convert.ToBoolean(reader["IsReviewer"]);
                user.IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                users.Add(user);
            }
            reader.Close();
            return users;
        }

        public User? GetByPk(int id)
        {
            string sql = $"SELECT * from Users Where Id = {id};";
            SqlCommand cmd = new(sql, connection.sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            reader.Read();
            User user = new();
            user.Id = Convert.ToInt32(reader["Id"]);
            user.Username = Convert.ToString(reader["Username"]);
            user.Password = Convert.ToString(reader["Password"]);
            user.Firstname = Convert.ToString(reader["Firstname"]);
            user.Lastname = Convert.ToString(reader["Lastname"]);
            if (reader["Phone"] == System.DBNull.Value)
            {
                user.Phone = null;
            }
            else
            {
                user.Phone = Convert.ToString(reader["Phone"]);
            }
            if (reader["Email"] == System.DBNull.Value)
            {
                user.Email = null;
            }
            else
            {
                user.Email = Convert.ToString(reader["Email"]);
            }
            user.IsReviewer = Convert.ToBoolean(reader["IsReviewer"]);
            user.IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
            reader.Close();
            return user;

        }

        public bool Delete(int id)
        {
            string sql = $"DELETE From Users Where id = {id};";
            SqlCommand cmd = new(sql, connection.sqlConnection);
            int rowsAffected = cmd.ExecuteNonQuery();
            if(rowsAffected != 1)
            {
                return false;
            }
            return true;
        }

        public bool Insert(User user)
        {
            string sql = " INSERT Into Users " +
                         "(Username, Password, Firstname, Lastname, " +
                         " Phone, Email, IsReviewer, IsAdmin) VALUES " +
                         " (@Username, @Password, @Firstname, @Lastname, " +
                         " @Phone, @Email, @IsReviewer, @IsAdmin ); ";
            SqlCommand cmd = new (sql, connection.sqlConnection);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Firstname", user.Firstname);
            cmd.Parameters.AddWithValue("@Lastname", user.Lastname);
            cmd.Parameters.AddWithValue("@Phone", user.Phone);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@IsReviewer", user.IsReviewer);
            cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
            int rowsAffected = cmd.ExecuteNonQuery();
            if(rowsAffected != 1)
            {
                return false;
            }
            return true;
        }        

        public bool Update(User user)
        {
            string sql = " Update Users Set " +
                         "  Username = @Username," +
                         "  Password = @Password," +
                         "  Firstname = @Firstname," +
                         "  Lastname = @Lastname, " +
                         "  Phone = @Phone, " +
                         "  Email = @Email, " +
                         "  IsReviewer = @IsReviewer, " +
                         "  IsAdmin = @IsAdmin " +
                         "  Where Id = @Id";
            SqlCommand cmd = new (sql, connection.sqlConnection);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Firstname", user.Firstname);
            cmd.Parameters.AddWithValue("@Lastname", user.Lastname);
            cmd.Parameters.AddWithValue("@Phone", user.Phone);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@IsReviewer", user.IsReviewer);
            cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
            cmd.Parameters.AddWithValue("@Id", user.Id);
            int rowsAffected = cmd.ExecuteNonQuery();
            if(rowsAffected != 1)
            {
                return false;
            }
            return true;
        }
        
    }
}
