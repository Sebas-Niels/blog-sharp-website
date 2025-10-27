using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSharpWebsite.DataAccessLibrary.SqlServer
{
    public abstract class BaseDao
    {
        public string ConnectionString { get; private set; }

        protected BaseDao(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
