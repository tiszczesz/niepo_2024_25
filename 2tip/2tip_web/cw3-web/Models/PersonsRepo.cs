using System;

namespace cw3_web.Models;

public class PersonsRepo
{
    public static List<Person> GetPersons(){
         return  new List<Person>
        {
            new Person { Id = 1, Firstname = "John", Lastname = "Doe", Birthdate = new DateOnly(1990, 1, 1) },
            new Person { Id = 2, Firstname = "Jane", Lastname = "Smith", Birthdate = new DateOnly(1985, 2, 15) },
            new Person { Id = 3, Firstname = "Michael", Lastname = "Johnson", Birthdate = new DateOnly(1978, 3, 30) },
            new Person { Id = 4, Firstname = "Emily", Lastname = "Davis", Birthdate = new DateOnly(1992, 4, 10) },
            new Person { Id = 5, Firstname = "Chris", Lastname = "Brown", Birthdate = new DateOnly(1988, 5, 25) },
            new Person { Id = 6, Firstname = "Jessica", Lastname = "Wilson", Birthdate = new DateOnly(1995, 6, 5) },
            new Person { Id = 7, Firstname = "David", Lastname = "Martinez", Birthdate = new DateOnly(1982, 7, 20) },
            new Person { Id = 8, Firstname = "Sarah", Lastname = "Anderson", Birthdate = new DateOnly(1991, 8, 15) },
            new Person { Id = 9, Firstname = "Daniel", Lastname = "Taylor", Birthdate = new DateOnly(1980, 9, 10) },
            new Person { Id = 10, Firstname = "Laura", Lastname = "Thomas", Birthdate = new DateOnly(1987, 10, 30) }
        };
    }
}
