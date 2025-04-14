using System;
using Microsoft.EntityFrameworkCore;

namespace cw3_ef_sqlite.Models;

public class SchoolContext : DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options)
    { }
    public DbSet<Student> Students { get; set; }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        //ustawienie danych poczatkowych prz tworzeniu bazy danych
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Student>().HasData(
          new Student
          {
              Id = 1,
              Firstname = "Jan",
              Lastname = "Kowalski",
              IndexNumber = "s12345",
              Birthdate = "2000-01-01"
          },
          new Student
          {
              Id = 2,
              Firstname = "Anna",
              Lastname = "Nowak",
              IndexNumber = "s12346",
              Birthdate = "1999-02-02"
          },
          new Student
          {
              Id = 3,
              Firstname = "Piotr",
              Lastname = "Zielinski",
              IndexNumber = "s12347",
              Birthdate = "1998-03-03"
          }
        );
    }
}
