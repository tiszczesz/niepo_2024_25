using System;

namespace ark3_solution.Models;

public class NoticesRepo
{
    private string? connectionString;

    public NoticesRepo(IConfiguration configuration)
    {
        connectionString = configuration.GetConnectionString("mysql");
    }
}
