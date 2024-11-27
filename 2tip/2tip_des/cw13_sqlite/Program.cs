// See https://aka.ms/new-console-template for more information
using cw13_sqlite.Models;

Console.WriteLine("Hello, World!");

Console.WriteLine("  ====== Lista produktów ======  ");
var productsRepo = new ProductsRepo();
var products = productsRepo.GetProducts();
foreach(var product in products){
    Console.WriteLine($"{product.Id} {product.Name} {product.Price} {product.Description}");
}
