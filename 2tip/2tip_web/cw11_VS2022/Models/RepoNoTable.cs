using Microsoft.Data.SqlClient;

namespace cw11_VS2022.Models
{
    public class RepoNoTable
    {
        private string _connectionString;

        public RepoNoTable(IConfiguration configuration) {
            _connectionString = configuration.GetConnectionString("MsSqlConnString");
        }

        public List<NoTableData> GetAll() {
            List<NoTableData> list = new();
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM NoTable";
            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                NoTableData data = new NoTableData {
                    Id = reader.GetInt32(0),
                    NoName = reader.IsDBNull(1) ? null : reader.GetString(1),
                    NoAge = reader.GetInt32(2)
                };
                list.Add(data);
            }
            return list;
        }
    }
}
