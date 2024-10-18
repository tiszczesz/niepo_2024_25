using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace cw2.Models
{
    public class AnimlasRepo
    {
        private string _connString = "Data Source=animals.db";
        public List<Animal> GetAnimals()
        {
           var animals = new List<Animal>();
           using SqliteConnection conn = new SqliteConnection(_connString);
           SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Animals";
            conn.Open();
            SqliteDataReader rd = cmd.ExecuteReader();
            while (rd.Read()) {
                animals.Add(new Animal
                {
                    Id = rd.GetInt32(0),
                    Name = rd.GetString(1),
                    Species = rd.GetString(2),
                    Age = rd.GetInt32("age"),
                    Weight = rd.GetDouble("weight")
                });
            }
            conn.Close();
            return animals;
        }
    }
}
