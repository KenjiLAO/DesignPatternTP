public class Livre
{
    public string titre { get; set; }
    public string auteur { get; set; }

    public void Afficher()
    {
        Console.WriteLine($"Livre : {titre} par {auteur}");
    }
}