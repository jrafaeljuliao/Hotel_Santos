using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAcess
{
    public abstract class ConnectionSQL
    {
        private readonly string connectionString;
        public ConnectionSQL()
        {
            connectionString = "Server=homedesk\\SQLEXPRESS;DataBase= Hotel; integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
