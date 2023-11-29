public class CommandeLivre
{
    public void Executer(Commande commande)
    {
        Console.WriteLine($"Commande passée pour {commande.Quantite} exemplaires de {commande.Livre.Afficher()}. Adresse de livraison : {commande.AdresseLivraison}");
    }
}
