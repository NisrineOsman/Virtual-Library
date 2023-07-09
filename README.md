# Virtual-Library
# Le but de ce projet est de créer un système d’information pour la gestion d’une librairie et  pour le contrôle des transactions dans cette librairie, ce projet est codé en c# (.net frame work), la gestion de la base de donnée est manipulée dans le SQL SERVER.

Cette librairie contient  des livres de plusieurs catégories : 
•	Des livres Littéraires
•	Des livres historiques
•	Des Roman
•	Des livres politiques….
Un administrateur est le bibliothécaire qui est responsable de visualiser les différents livres, d’ajouter des livres, aussi connaitre les réservations effectués  par les clients, et visualiser leurs calendriers. Les clients par  leurs tours effectuent toutes les opérations des réservations d'un livre. 

# 1. Les utilisateurs du système sont:

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

# 2. Les objets manipulés :

 Administrateur  
•	id
•	Nom
•	prénom
•	Téléphone
•	Username
•	Password

 Client 
•	Id 
•	Nom 
•	prénom
•	Username
•	Password

 Livre
•	Id 
•	Nom
•	Catégorie
•	Nom de l'auteur
•	Quantité de livre
•	Edition
•	Publisher
•	Etat

Catégorie
•	Id 
•	Nom
•	List de livre

 Emprunte
•	Id
•	Id_Client
•	Id_Livre
•	Date d’emprunte
•	Date prévue

 Réservation
•	Id
•	Id_Client
•	Id_Livre
•	Date de réservation
