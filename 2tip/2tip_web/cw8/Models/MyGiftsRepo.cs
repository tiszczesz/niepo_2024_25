using System;
using System.Text.Json;

namespace cw8.Models;

public class MyGiftsRepo
{
    private string _fileName = "gifts.json";
    public List<MyGift> MyGifts { get; set; }
    public MyGiftsRepo()
    {
        var json = File.ReadAllText(_fileName);
        MyGifts = JsonSerializer.Deserialize<List<MyGift>>(json) ?? new List<MyGift>();
    }

}
