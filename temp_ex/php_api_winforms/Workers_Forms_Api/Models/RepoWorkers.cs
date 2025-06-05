using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Workers_Forms_Api.Models
{
    public class RepoWorkers
    {
        private string url = @"http://localhost/szkola_2024_25/temp/workers_api/my_api.php";

        public RepoWorkers() {
            
        }
        public List<Worker> GetWorkers() {
            var workers = new List<Worker>();
            try {
                using (var client = new HttpClient()) {
                    var response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode) {
                        var json = response.Content.ReadAsStringAsync().Result;
                        //bo małe litery w nazwach pól
                       
                        workers = System.Text.Json.JsonSerializer.Deserialize<List<Worker>>(json);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error fetching workers: {ex.Message}");
            }
            return workers;
        }

    }
}
