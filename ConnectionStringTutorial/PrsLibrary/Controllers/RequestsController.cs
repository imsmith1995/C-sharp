using Microsoft.Data.SqlClient;
using PrsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Controllers
{
    public class RequestsController
    {
        public readonly Connection connection = null;
        private RequestsController requCtrl = null;

        public RequestsController (Connection conn)
        {
            connection = conn;
            requCtrl = new(connection);
        }

        public IEnumerable<Request> GetAll()
        {
            string sql = Request.SqlSelectAll;
            SqlCommand cmd = new(sql, connection.sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Request> requests = new();
            while (reader.Read())
            {
                Request request = new Request();
                Request.LoadFromReader(request, reader);
                requests.Add(request);
            }
            reader.Close();
            return requests;
        }
    }
}
