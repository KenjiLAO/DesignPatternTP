public class Bibliotheque
{
    private List<Livre> _livres = new List<Livre>();

    public void AjouterLivre(Livre livre)
    {
        _livres.Add(livre);
    }

    public void Afficher()
    {
        foreach (var livre in _livres)
        {
            livre.Afficher();
        }
    }
}