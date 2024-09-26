using System.Net.Http.Json;
using WF_api.Models;

namespace WF_api;

public partial class Form1 : Form {
    private readonly HttpClient client = new();

    public Form1() {
        InitializeComponent();
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.ReadOnly = true;
    }

    private async void btnLoad_Click(object sender, EventArgs e) {
        try {
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            var todos = await client.GetFromJsonAsync<List<Todo>>("todos");
            dataGridView1.DataSource = todos;

        }
        catch (Exception ex) {
            MessageBox.Show(ex.Message);
        }
    }
}