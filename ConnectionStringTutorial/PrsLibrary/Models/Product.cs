using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string PartNbr { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Unit { get; set; } = "Each";
        public string? Photopath { get; set; } = null;
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }

        public static string SqlSelectAll = 
            "SELECT * from Products; ";
        public static string SqlSelectByPk = "SELECT * from Products where Id = @Id;";
        public static string SqlDelete = $"DELETE from Products Where id = @id;";
        public static string SqlInsert =
            " INSERT Into Products " +
            " (PartNbr, Name, Price, Unit, Photopath, VendorId )" +
            " VALUES " +
            "(@PartNbr, @Name, @Price, @Unit, @Photopath, @VendorId );";
        public static string SqlUpdate = 
            $"UPDATE Products Set " +
             " PartNbr = @PartNbr, " +
             " Name = @Name, " +
             "Price = @Price, " +
             "Unit = @Unit, " +
             "Photopath = @Photopath, " +
             "VendorId = @VendorId," +
             "Where Id = @Id;";

        public static void SetSqlParameterId(SqlCommand cmd, int id)
        {
            cmd.Parameters.AddWithValue("@Id", id);
        }

        public static void LoadFromReader(Product product, SqlDataReader reader)
        {
            product.Id = Convert.ToInt32(reader["Id"]);
            product.PartNbr = Convert.ToString(reader["PartNbr"]);
            product.Name = Convert.ToString(reader["Name"]);
            product.Price = Convert.ToDecimal(reader["Price"]);
            product.Unit = Convert.ToString(reader["Unit"]);
            product.Photopath = Convert.ToString(reader["Photopath"]);
            product.VendorId = Convert.ToInt32(reader["VendorId"]);
        }

        public void SetSqlParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@PartNbr", PartNbr);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Unit", Unit);
            cmd.Parameters.AddWithValue("@Photopath", Photopath);
            cmd.Parameters.AddWithValue("@VendorId", VendorId);
            SetSqlParameterId(cmd, Id); 
        }

        public void LoadFromReader(SqlDataReader reader)
        {
            LoadFromReader(this, reader);
        }
    }
}
