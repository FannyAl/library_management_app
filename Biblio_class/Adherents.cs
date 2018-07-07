using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class
{
     public class Adherents : List<Adherent> 
    {
         public void init()
         {
             //for (int i = 0; i < 10; i++)
             //{
             //    this.Add(new Adherent("Num Adherent"+i, "Nom" + i, "Prenom" + i, i, "Nom rue" + i, i, "Ville" + i, "Tel" + i , "Mail" + i, DateTime.Now.AddDays(30), "Mdp" + i));

             //}
             DAO_Adherent.Init_Adherents(this);
         }


         public Adherents Recherche_par_num(int num)
         {
             Adherents resultat = new Adherents();
             resultat.Clear();

             foreach (Adherent a in this)
             {
                 if (a.NumeroAdherent.ToString() == num.ToString())
                 {
                     resultat.Add(a);
                     break;
                 }
             }
             DAO_Adherent.Init_Adherents(this);
             return this;
         }


         public Adherents Recherche_par_nom(string nom)
         {
             Adherents resultat = new Adherents();
             resultat.Clear();

             foreach (Adherent a in this)
             {
                 if (a.Nom.ToUpper() == nom.ToUpper())
                 {
                     resultat.Add(a);
                     break;
                 }
             }
             DAO_Adherent.Init_Adherents(this);
             return this;
         }


         /// <summary>
         /// Méthode Ajouter un Adhérent
         /// </summary>
         /// <param name="tabAdher"></param>
         public void Ajoute(string numAd, string nom, string prenom, int numR , string nomR, int cpost, string ville, string tel, string adrMail, DateTime perime, string mdp)
         {
             Adherent a = new Adherent(numAd, nom, prenom, numR, nomR, cpost, ville, tel, adrMail, perime, mdp);
             this.Add(a);
             //...
             DAO_Adherent.Ajout_Adherent(a);
         }

         /// <summary>
         /// Méthode de MAJ d'un Adhérent
         /// </summary>
         /// <param name="tabAdher"></param>
         public void enregistre_MAJ(Adherent adh)
         {
              //On recherche l'adherent à modifier dans la liste
             foreach (Adherent a in this)
             {
                 if (a.NumeroAdherent == adh.NumeroAdherent)
                 {
                     a.MAJ(adh);
                     break;
                 }
             }
         }

         /// <summary>
         /// Méthode Supprimer
         /// </summary>
         /// <param name="SuppAdher"></param>
         public void Supprimer(Adherent a)
         {
             // Suppression de l'adherent courant
             DAO_Adherent.Supprimer_Adherent(a);
             this.Remove(a);
         }
    }
}