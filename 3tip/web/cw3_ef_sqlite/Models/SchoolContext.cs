using System;
using Microsoft.EntityFrameworkCore;

namespace cw3_ef_sqlite.Models;

public class SchoolContext :DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> options)
        :base(options)
    {}
}
