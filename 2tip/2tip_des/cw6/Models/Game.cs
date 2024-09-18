namespace cw6.Models;

public class Game{
    //pola cechy obiektu
    private string? _title;//pole prywatne
    public string? Title{//wlasciwosc dla pola prywatnego _title
        get{
            return _title?.ToUpper()+"!";
        }
        set{
            _title = value?.Length<3 ? "nieznany" : value;
        }
    }
    //atomatyczna wlasciwosc auto property
    public string? Genre{get;set;}//wlasciwosc z automatycznym polem;

    //metody zachowania obiektu
    public override string ToString(){
        return $"Title: {Title}, Genre: {Genre}";
    }
}