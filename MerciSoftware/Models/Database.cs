using Dapper;
using Microsoft.Data.SqlClient;
using MerciSoftware.Models;

namespace MerciSoftware.Models
{
    public class Database
    {
        private readonly string _conn;

        public Database(IConfiguration configuration)
        {
            _conn = configuration.GetConnectionString("Default");
        }

        private SqlConnection CreaConnessione()
        {
            return new SqlConnection(_conn);
        }




    }
}
