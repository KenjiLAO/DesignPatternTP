public interface IAbonnement {
    void AjouterAbonne(IAbonne abonne);
    void NotifierAbonnes();
}

public interface IAbonne {
    void MettreAJour();
}