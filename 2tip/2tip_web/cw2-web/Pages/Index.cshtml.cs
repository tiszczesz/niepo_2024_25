using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw2_web.Pages
{
    public class IndexModel : PageModel
    {
        public int MyNumber { get; set; }
        public void OnGet()
        {
            Random random = new Random();//tworzymy obiekt klasy Random
            MyNumber = random.Next(1, 100);//losujemy liczbę z zakresu 1-100
        }
        public List<string> Names(){
            return new List<string> { "Ala", "Ola", "Ela","Balbina" };
        }
        public List<string> GetColors(){
            return new List<string> { "red", "green", "blue", "yellow" };
        }
    }
}
