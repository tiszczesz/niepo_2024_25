namespace cw11_VS2022.Models
{
    public class RepoNoTable
    {
        private string _connectionString;

        public RepoNoTable(IConfiguration configuration) {
            _connectionString = configuration.GetConnectionString("MsSqlConnString");
        }
    }
}
