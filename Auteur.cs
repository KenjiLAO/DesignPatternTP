public class Auteur : IAbonnement
{
    private List<IAbonne> _abonnes = new List<IAbonne>();

    public string Nom { get; set; }

    public void AjouterAbonne(IAbonne abonne)
    {
        _abonnes.Add(abonne);
    }

    public void NotifierAbonnes()
    {
        foreach (var abonne in _abonnes)
        {
            abonne.MettreAJour();
        }
    }
}