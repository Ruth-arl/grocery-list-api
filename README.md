# Application de gestion de liste d'épicerie

## Description

Cette application Web Full-Stack permet de gérer une liste d'épicerie.

L'utilisateur peut :

* Ajouter un produit
* Modifier un produit
* Supprimer un produit
* Consulter la liste complète des produits
* Rechercher un produit
* Voir le prix total de la liste

Chaque produit contient :

* Un nom
* Une quantité
* Un prix unitaire

Les données sont sauvegardées dans un fichier JSON afin d'être conservées même après l'arrêt du serveur.

---

## Technologies utilisées

### Backend

* C#
* ASP.NET Core Web API
* .NET 8

### Frontend

* HTML
* CSS
* JavaScript
* Bootstrap 5

### Persistance des données

* Fichier JSON

---

## Prérequis

Les outils suivants doivent être installés :

* Visual Studio 2022
* .NET 8 SDK

---

## Démarrage du projet

### 1. Démarrer l'API

1. Ouvrir la solution dans Visual Studio 2022.
2. Définir le projet API comme projet de démarrage.
3. Exécuter l'application en mode HTTPS.

L'API sera disponible à l'adresse :

https://localhost:7138/grocery_list

---

### 2. Démarrer le frontend

1. Ouvrir le fichier index.html dans un navigateur Web.
2. Vérifier que l'API est déjà démarrée.

Le frontend communique directement avec l'API via des requêtes HTTP.

---

## Fonctionnalités disponibles

* Ajout d'un produit
* Modification d'un produit
* Suppression d'un produit
* Consultation de la liste complète
* Recherche d'un produit
* Calcul automatique du prix total
* Validation des données côté client et côté serveur

---

## Validation des données

Nom :

* Ne peut pas être vide

Quantité :

* Doit être supérieure ou égale à 1

Prix unitaire :

* Doit être supérieur à 0

---

## Persistance

Les données sont sauvegardées dans le fichier :

grocery.json

Ainsi, la liste demeure disponible même après le redémarrage du serveur.

---

Temps approximatif consacré au projet : 8 à 11 heures.

## Auteur

Ruth Arlene Goua
