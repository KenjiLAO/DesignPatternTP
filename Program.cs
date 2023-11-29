UsineLivre livreFactory = new UsineLivre();

Livre livre1 = livreFactory.CreerLivre();
livre1.titre = "Comment aller aux toilettes";
livre1.auteur = "Kenji Lao";

Livre livre2 = livreFactory.CreerLivre();
livre2.titre = "Pourquoi ne pas faire son lit le matin ?";
livre2.auteur = "Kenji Lauj";

Bibliotheque bibliotheque = new Bibliotheque();
bibliotheque.AjouterLivre(livre1);
bibliotheque.AjouterLivre(livre2);

Console.WriteLine("Bibliothèque :");
bibliotheque.AfficherLivre();

CommandeLivre commandeLivraison = new CommandeLivre();
Commande commande = new Commande { livre = livre2, Quantite = 3, AdresseLivraison = "Quarante-douze Rue de la pet" };
commandeLivraison.CommanderLivre(commande);

Auteur auteur = new Auteur { Nom = "Jean", Prenom = "Dupont"};
Client client = new Client { Nom = "Alice", Prenom = "Portier", Mail = "aportier@gmail.com" };

auteur.AjouterAbonne(client);
auteur.NotifierAbonnes();