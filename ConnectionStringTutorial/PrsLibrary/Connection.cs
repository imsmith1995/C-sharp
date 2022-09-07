﻿using Microsoft.Data.SqlClient;

namespace PrsLibrary
{
    public class Connection
    {
        private string connectionString = @"server = localhost\sqlexpress;" +
                                        "database = PRS;trusted_connection = true;" +
                                        "trustServerCertificate = true;";

        public SqlConnection? sqlConnection { get; set; } = null;

        public void SelectSql(string sql)
        {
            sql = "Select * From Users;";
            SqlCommand sqlCommand = new(sql, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string? username = Convert.ToString(reader["Username"]);
                string? firstname = Convert.ToString(reader["Firstname"]);
                string? lastname = Convert.ToString(reader["Lastname"]);
                System.Diagnostics.Debug.WriteLine($"{id}|{username}|{firstname}|{lastname}");
            }
            reader.Close();
        }

        public void Connect()
        {
            if(sqlConnection is not null)
            {
                System.Diagnostics.Debug.WriteLine("Connection already exists!");
                return;
            }
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if(sqlConnection.State != System.Data.ConnectionState.Open) {
                throw new Exception("Could not make connection to database!");
            }
            System.Diagnostics.Debug.WriteLine("Connection opened successfully!");
        }

        public void Disconnect()
        {
            if (sqlConnection is not null)
            {
                sqlConnection.Close();
                sqlConnection = null;
            }
        }
    }
}