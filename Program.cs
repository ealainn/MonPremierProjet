// My First Project 
using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Livre{
    public  string titre;
    public  string auteur;
    public int annee_de_publication;
    public bool isAvailable;

    public Livre(string titre, string auteur, int  annee_de_publication){
        titre = titre;
        auteur = auteur;
        annee_de_publication = annee_de_publication;
        isAvailable = true;
    }

}

class User{
    public  string nom;
    public  List<Livre> LivreEmpruntes;
    
    public User(string nom, List<string> LivreEmpruntes){
        nom = nom;
        LivreEmpruntes = LivreEmpruntes;
    }
    public void Emprunter(Livre livre_voulu){
        if (livre_voulu.isAvailable){
               LivreEmpruntes.Add(livre_voulu);
               livre_voulu.isAvailable  =  false;
               Console.WriteLine("Vous venez d'emprunter le livre: " + livre_voulu.titre);
               Console.WriteLine("La  liste de livre empruntés est a present " + LivreEmpruntes);
        }
        else {
            Console.WriteLine("Ce livre n'est pas disponible à l'emprunt");
        }

    }
    public void Retourner(Livre livre_voulu){
        if (LivreEmpruntes.Contains(livre_voulu)){
            LivreEmpruntes.Remove(livre_voulu);
            livre_voulu.isAvailable = true;
            Console.WriteLine("Vous venez de rendre le livre: " + livre_voulu.titre);
            Console.WriteLine("La  liste de livre empruntés est a present " + LivreEmpruntes);
        }
        else {
            Console.WriteLine("Vous n'avez pas emprunté ce livre");
        }
    }
    public void AfficherLivreEmpruntes(){
        Console.WriteLine("La  liste de livre empruntés est a present " + LivreEmpruntes);
    }

}

class Bibliotheque{
    public List<Livre> Livres;
    public List<User> Users;

    public Bibliotheque(List<Livre> Livres, List<User> Users){
        Livres = Livres;
        Users = Users;
    }

    public void AjouterLivre(Livre livre){
        Livres.Add(livre);
        Console.WriteLine("Le livre " + livre.titre + " a été ajouté à la bibliothèque");
    }

    public void AjouterUser(User user){
        Users.Add(user);
        Console.WriteLine("L'utilisateur " + user.nom + " a été ajouté à la bibliothèque");
    }

    public void AfficherLivre(){
        Console.WriteLine("La liste des livres de la bibliothèque est: ");
        foreach (Livre livre in Livres){
            Console.WriteLine(livre.titre);
        }
    }

    public void AfficherUser(){
        Console.WriteLine("La liste des utilisateurs de la bibliothèque est: ");
        foreach (User user in Users){
            Console.WriteLine(user.nom);
        }
    }

    public void EmprunterLivre(User user, Livre livre){
        user.Emprunter(livre);
    }

    public void RetournerLivre(User user, Livre livre){
        user.Retourner(livre);
    }

    public void AfficherLivreEmpruntes(User user){
        user.AfficherLivreEmpruntes();
    }
}