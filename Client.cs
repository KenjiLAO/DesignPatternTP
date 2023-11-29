public class Client : IAbonne
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Mail { get; set; }

    public void MettreAJour()
    {
        Console.WriteLine($"{Nom + ' ' + Prenom} a reçu une mise à jour de l'auteur.");
    }
}