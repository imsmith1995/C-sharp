using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;
        public string Justification { get; set; } = String.Empty;
        public string? RejectionReason { get; set; } = String.Empty;
        public string DeliveryMode { get; set; } = "Pickup";
        public string Status { get; set; } = "NEW";
        public decimal Total { get; set; }
        public int UserId { get; set; }

        public static string SqlSelectAll = "SELECT * from Requests;";


        public static void SetSqlParameterId(SqlCommand cmd, int id)
        {
            cmd.Parameters.AddWithValue("@Id", id);
        }

        public static void LoadFromReader(Request request, SqlDataReader reader)
        {
            request.Id = Convert.ToInt32(reader["Id"]);
            request.Description = Convert.ToString(reader["Description"]);
            request.Justification = Convert.ToString(reader["Justification"]);
            request.RejectionReason = Convert.ToString(reader["RejectionReason"]);
            request.DeliveryMode = Convert.ToString(reader["DeliveryMode"]);
            request.Status = Convert.ToString(reader["Status"]);
            request.Total = Convert.ToDecimal(reader["Total"]);
            request.UserId = Convert.ToInt32(reader["UserId"]);
        }

        public void SetSqlParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@Justification", Justification);
            cmd.Parameters.AddWithValue("@RejectionReason", RejectionReason);
            cmd.Parameters.AddWithValue("@DeliveryMode", DeliveryMode);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@UserId", UserId);
            SetSqlParameterId(cmd, Id);
        }

        public void LoadFromReader(SqlDataReader reader)
        {
            LoadFromReader(this, reader);
        }
    }
}
