# Virtual-Library
Le but de ce projet est de créer un système d’information pour la gestion d’une librairie et  pour le contrôle des transactions dans cette librairie, ce projet est codé en c# (.net frame work), la gestion de la base de donnée est manipulée dans le SQL SERVER.
Cette librairie contient  des livres de plusieurs catégories : 
•	Des livres Littéraires
•	Des livres historiques
•	Des Roman
•	Des livres politiques….
Un administrateur est le bibliothécaire qui est responsable de visualiser les différents livres, d’ajouter des livres, aussi connaitre les réservations effectués  par les clients, et visualiser leurs calendriers. Les clients par  leurs tours effectuent toutes les opérations des réservations d'un livre. 

1. Les utilisateurs du système sont:

	Administrateur qui est responsable d’effectuer toutes les opérations suivantes :
•	Authentifier au système 
•	Ajouter ou supprimer un client
•	Ajouter des livres et leurs informations à la base de données
•	Réserver un livre pour un client 
•	Emprunter un livre au client
•	Modifier les informations de livres existants
•	Visualiser les différentes catégories de livres disponibles à la bibliothèque 
•	Consulter la liste des livres disponibles dans chaque catégorie
•	Changer l'état d'un livre(réserver, emprunter,..)
•	Gérer les Latences de récupération des livres empruntés
•	Accéder a un dossier complet sur le calendrier de réservation des livres



	Client qui est responsable d'effectuer les opérations suivantes:
•	Authentifier au système
•	Pouvoir rechercher un livre en particulier
•	Visualiser les différentes catégories de livres disponibles à la bibliothèque 
•	Réserver un livre
•	Emprunter un livre
•	Consulter la liste des livres disponibles dans chaque catégorie
•	Savoir l'état d'un livre en particulier
•	pouvez visualiser les différentes catégories de livres disponibles à la bibliothèque
•	Voir la liste des livres disponibles dans chaque catégorie
•	Pouvoir posséder un compte dans la bibliothèque

2. Les objets manipulés :

 Administrateur  
o	id
o	Nom
o	prénom
o	Téléphone
o	Username
o	Password

 Client 
o	Id 
o	Nom 
o	prénom
o	Username
o	Password

 Livre
o	Id 
o	Nom
o	Catégorie
o	Nom de l'auteur
o	Quantité de livre
o	Edition
o	Publisher
o	Etat

Catégorie
o	Id 
o	Nom
o	List de livre

 Emprunte
o	Id
o	Id_Client
o	Id_Livre
o	Date d’emprunte
o	Date prévue

 Réservation
o	Id
o	Id_Client
o	Id_Livre
o	Date de réservation
