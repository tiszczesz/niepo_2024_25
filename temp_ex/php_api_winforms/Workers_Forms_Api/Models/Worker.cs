using System.Text.Json.Serialization;

namespace Workers_Forms_Api.Models;

public class Worker {

    [JsonPropertyName("id")]
    public int Id { get; set; }


    [JsonPropertyName("firstname")]
    public string Firstname { get; set; }

    [JsonPropertyName("lastname")]
    public string Lastname { get; set; }

    [JsonPropertyName("job")]
    public string Job { get; set; }

    [JsonPropertyName("salary")]
    public decimal Salary { get; set; }
}