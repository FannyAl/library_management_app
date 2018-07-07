using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblio_class
{

    //*********************************************************
    //*********************************************************
    //*************     Les Classes METIERS    ****************
    //*********************************************************
    //*********************************************************
    //*************   La classe BIBLIOTHEQUES   ***************
    //*********************************************************

    /// <summary>
    /// La classe BIBLIOTHEQUES
    /// </summary>
    public class Bibliotheques : List<Bibliotheque> //Déclaration de l'attribut de Collection Bibliothèques
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //**************     Les BIBLIOTHEQUES    *****************
        int nb_bibli = 0;
        int no_bibli_courant = 0;

        //*********************************************************
        //**** Initialisation de la liste des Bibliotheques *******
        //*********************************************************
        #region CONSTRUCTEUR Bibliotheque

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe Bibliotheques
        /// </summary>
        public Bibliotheques()
        {
            //Fonction d'initialisation de la Collection
            DAO_Bibliotheque.Init_Bibliotheques(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe Bibliothèques


        #region Méthodes Liste de toutes les Bibliothèques

        //*********************************************************
        //*** Les noms de toutes les Bibliothèques de la liste*****
        //*********************************************************
        /// <summary>
        /// Les noms de toutes les Bibliothèques de la liste
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_Nom_Biblioteque()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Bibliotheque b in this)
            {
                liste[i] = b.Libelle;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //****   Toutes les Bibliothèques de la liste        ******
        //*********************************************************
        /// <summary>
        /// Toutes les Bibliothèques de la liste
        /// </summary>
        /// <returns>Liste de Noms des Bibliotheques</returns>
        public List<Bibliotheque> Liste_Bibliotheque()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par code, libellé, adresse

        //*********************************************************
        //*******  RECHERCHE de la bibliothèque par CODE **********
        //*********************************************************
        /// <summary>
        /// RECHERCHE de la bibliothèque par CODE
        /// </summary>
        /// <param name="code">Code Bibliothèque</param>
        /// <returns></returns>
        public Bibliotheques Recherche_parCODE(string code)
        {
            // Recupération des infos selon un CODE
            Bibliotheques liste = new Bibliotheques();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Bibliotheque b in this)
            {
                if (b.CodeBiblio == code)
                {
                    liste.Add(b);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //******  RECHERCHE de la bibliothèque par LIBELLE ********
        //*********************************************************
        /// <summary>
        /// RECHERCHE de la bibliothèque par LIBELLE
        /// </summary>
        /// <param name="libelle">Libellé de la Bibliothèque</param>
        /// <returns>liste bibliothèque</returns>
        public Bibliotheques Recherche_parLIBELLE(string libelle)
        {
            // Recupération des infos selon le LIBELLE
            Bibliotheques liste = new Bibliotheques();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Bibliotheque b in this)
            {
                //Pour retourner l'alernative d'une bibliothèque qui possède des informations similaires avant de la créer
                if (b.Libelle == libelle)
                {
                    liste.Add(b);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //******  RECHERCHE de la bibliothèque par ADRESSE ********
        //*********************************************************
        /// <summary>
        /// RECHERCHE de la bibliothèque par ADRESSE
        /// </summary>
        /// <param name="adresse">Adresse de la Bibliothèque</param>
        /// <returns>liste bibliothèques</returns>
        public Bibliotheques Recherche_parADRESSE(string adresse)
        {
            // Recupération des infos selon un l'ADRESSE
            Bibliotheques liste = new Bibliotheques();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Bibliotheque b in this)
            {
                if (b.Adresse == adresse)
                {
                    liste.Add(b);
                    break;
                }
            }
            return liste;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER
        
        //*********************************************************
        //****   MISE A JOUR des infos d'une bibliothèque       ***
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'une bibliothèque
        /// </summary>
        /// <param name="bib">Bibliothèque</param>
        public void MAJ_liste_biblio(Bibliotheque bib)
        { 
            //Recherche de l'adhérent à modifier dans la base de données
            foreach (Bibliotheque b in this)
            {
                if (b.CodeBiblio == bib.CodeBiblio)
                {
                    b.MAJ(bib);
                    break;
                }
            }
        }


        //*********************************************************
        //***  AJOUT d'une nouvelle bibliothèque dans la liste  ***
        //*********************************************************
        /// <summary>
        /// AJOUT_new()
        /// </summary>
        /// <param name="b">Bibliothèque</param>
        public void AJOUT_new(Bibliotheque b)
        {
            // Ajout d'une nouvelle bibliothèque
            this.Add(b);
            DAO_Bibliotheque.AJOUT_Biblio(b);
            nb_bibli += 1;
        }


        //*********************************************************
        //*****   SUPPRIMER une bibliothèque dans la liste   ******
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="b">Bibliothèque</param>
        public void SUPPRIMER(Bibliotheque b)
        {
            // Suppression de la bibliothèque courante
            this.Remove(b);
            DAO_Bibliotheque.SUPPR_Biblio(b);
            nb_bibli--;
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT
        
        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// biblio_PRECEDENT()
        /// </summary>
        /// <returns>Bibliothèque précédente</returns>
        public Bibliotheque biblio_PRECEDENT()
        {   
            // Fonction permettant de recuperer l'element precedent de la liste
            try
            {
                no_bibli_courant -= 1;
                return (this[no_bibli_courant]);
            }
            catch (Exception e)
            {
                no_bibli_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// biblio_SUIVANT()
        /// </summary>
        /// <returns>Bibliothèque suivante</returns>
        public Bibliotheque biblio_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            try
            {
                no_bibli_courant += 1;
                return (this[no_bibli_courant]);

            }
            catch (Exception e)
            {
                no_bibli_courant -= 1;
                throw e;
            }
        }

        #endregion


        #region Méthode CODE PROVISOIR

        //*********************************************************
        //****   Attribution d'un Code bibliothèque PROVISOIR   ***
        //*********************************************************
        /// <summary>
        /// Code_PROVISOIR()
        /// </summary>
        /// <returns>Numéro de bibliothèque provisoir</returns>
        public int Code_PROVISOIR()
        {
            // Fonction permettant de determiner le code BIBLIOTHEQUE maximum
            // pour l'attribution d'un code BIBLIOTHEQUE (New)
            try
            {
                no_bibli_courant = this.Count - 1;
                return (no_bibli_courant + 2);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #endregion
    }
}
