public class Livre
{
    public string Titre { get; set; }
    public string Auteur { get; set; }

    public void Afficher()
    {
        Console.WriteLine($"Livre : {Titre} par {Auteur}");
    }
}