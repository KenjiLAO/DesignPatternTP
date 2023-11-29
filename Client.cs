public class Client : IAbonne
{
    public string Nom { get; set; }

    public void MettreAJour()
    {
        Console.WriteLine($"{Nom} a reçu une mise à jour de l'auteur.");
    }
}