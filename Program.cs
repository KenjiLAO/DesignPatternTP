//Permet de passer en JSON ou en objet selon l'appel de fonction
JsonFormat jsonManager = new JsonFormat();

//TODO: si il y a au moins 1 livre, conditionner
    UsineLivre creaLivre = new UsineLivre();

    Livre livre1 = creaLivre.CreerLivre();
    livre1.titre = "Comment aller aux toilettes";
    livre1.auteur = "Kenji Lao";

    Livre livre2 = creaLivre.CreerLivre();
    livre2.titre = "Pourquoi ne pas faire son lit le matin ?";
    livre2.auteur = "Kenji Lauj";

    Bibliotheque bibliotheque = new Bibliotheque();
    bibliotheque.AjouterLivre(livre1);
    bibliotheque.AjouterLivre(livre2);

Console.WriteLine("Bibliothèque :");
bibliotheque.AfficherLivre();

//Un client passe un commande
CommandeLivre commandeLivraison = new CommandeLivre();
Commande commande = new Commande { livre = livre2, Quantite = 3, AdresseLivraison = "Quarante-douze Rue de la pet" };
commandeLivraison.CommanderLivre(commande);

//Ajoute un acteur
Auteur auteur = new Auteur { Nom = "Jean", Prenom = "Dupont"};

//Ajoute un client
Client client = new Client { Nom = "Alice", Prenom = "Portier", Mail = "aportier@gmail.com" };

//Abonne le client à l'acteur ayant passé commande
auteur.AjouterAbonne(client);
//Permet au client de recevoir une notification
auteur.NotifierAbonnes();

//Sauvegarde les données en fichier JSON
jsonManager.SauvegarderEnJson(commande, "commande.json");
jsonManager.SauvegarderEnJson(bibliotheque, "bibliotheque.json");
jsonManager.SauvegarderEnJson(client, "client.json");
jsonManager.SauvegarderEnJson(auteur, "auteur.json");

//Récupère les données d'un fichier JSON
Commande commande1 = jsonManager.ChargerDepuisJson<Commande>("commande.json");

//Evite les bugs si il n'y a pas de commandes
if (commande1 != null) {
    Console.WriteLine("Bibliothèque Chargée depuis JSON: ");
    Console.WriteLine("Nom du livre : " + commande1.livre.titre);
    Console.WriteLine("Quantité commandée : " + commande1.Quantite);
    Console.WriteLine("Adresse de livraison : " + commande1.AdresseLivraison);
}
