## Używanie EF z Sqlite

1. Zainstalować pakiety:
   1. Microsoft.EntityFrameworkCore.Sqlite"
   2. Microsoft.EntityFrameworkCore.Tools
2. Utworzyć plik maanifest i zainstalować lokalnie ef

```console
dotnet new tool-manifest
dotnet tool install dotnet-ef
```

3. Utworzyć Dbcontext dla aplikacji:

```cs
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
              Birthdate = DateOnly.Parse("2000-01-01")
          },
          new Student
          {
              Id = 2,
              Firstname = "Anna",
              Lastname = "Nowak",
              IndexNumber = "s12346",
              Birthdate = DateOnly.Parse("1999-02-02")
          },
          new Student
          {
              Id = 3,
              Firstname = "Piotr",
              Lastname = "Zielinski",
              IndexNumber = "s12347",
              Birthdate = DateOnly.Parse("1998-03-03")
          }
        );
    }
}
```

4. Wykonać migrację po zbudowaniu projektu

```console
dotnet ef migrations add First
```

5. Utworzyć baże danych z migracji

```console
dotnet ef database update
```
