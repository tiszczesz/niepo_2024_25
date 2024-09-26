using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WF_api.Models;

namespace WF_api.Data
{
    public class FetchDataTodos
    {
        public static async Task<List<Todo>> GetTodos(string url) {
            HttpClient http = new HttpClient();
            http.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            var todos =  await http.GetFromJsonAsync<List<Todo>>("todos");
            return todos;
        }
    }
}
