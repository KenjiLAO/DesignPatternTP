public class Bibliotheque
{
    private List<Livre> livres = new List<Livre>();

    public void AjouterLivre(Livre livre)
    {
        livres.Add(livre);
    }

    public void AfficherLivre()
    {
        foreach (var livre in livres)
        {
            livre.Afficher();
        }
    }
}