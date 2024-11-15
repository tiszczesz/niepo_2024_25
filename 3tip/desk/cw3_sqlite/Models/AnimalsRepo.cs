using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace cw3_sqlite.Models
{
    public class AnimalsRepo
    {
        private string connString = "Data Source=animals.db";
        public AnimalsRepo() { }

        public List<Animal> GetAnimals() {
            var result = new List<Animal>();
            using SqliteConnection conn = new SqliteConnection(connString);
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Animal";
            conn.Open();
            using SqliteDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                result.Add(new Animal
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Species = reader.GetString(2),
                    BitrhDay = DateOnly
                        .FromDateTime( reader.GetDateTime(3))
                });
            }

            return result;
        }
    }
}
