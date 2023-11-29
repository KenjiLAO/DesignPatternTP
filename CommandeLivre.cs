public class CommandeLivre
{
    public void CommanderLivre(Commande commande)
    {
        Console.WriteLine($"Commande passée pour {commande.Quantite} exemplaires de {commande.livre.titre}. Adresse de livraison : {commande.AdresseLivraison}");
    }
}
