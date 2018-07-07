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
    //*************   La classe EMPLACEMENT   ****************
    //*********************************************************

    public class Emplacements : List<Emplacement> //Déclaration de l'attribut de Collection Bibliothèques
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //****************     Les EMPLACEMENTS   *****************
        int nb_emp = 0;
        int no_emp_courant = 0;


        //*********************************************************
        //****Initialisation de la liste des EMPLACEMENTS *********
        //*********************************************************
        #region CONSTRUCTEUR Bibliotheque

        //Fonction d'initialisation de la Collection
        /// <summary>
        /// CONSTRUCTEUR par défault de la classe Emplacement
        /// </summary>
        public Emplacements()
        {
            this.Clear();
            DAO_Emplacement.Init_Emplacements(this);
        }

        #endregion


        //*********************************************************
        //*************      Les METHODE            ***************
        //*********************************************************
        #region METHODES de la classe Bibliothèques

        #region Méthodes Liste de toutes les Bibliothèques

        //*********************************************************
        //***** Les noms de tous les Emplacements de la liste *****
        //*********************************************************
        /// <summary>
        /// Noms de tous les Emplacements de la liste
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_Nom_Emplacement()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Emplacement e in this)
            {
                liste[i] = e.Libelle;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //*****   Toutes les Emplacements de la liste        ******
        //*********************************************************
        /// <summary>
        /// Toutes les Emplacements de la liste
        /// </summary>
        /// <returns>Liste de Noms des Emplacements</returns>
        public List<Emplacement> Liste_Emplacement()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par code

        //*********************************************************
        //*********  RECHERCHE de l'emplacement par CODE **********
        //*********************************************************
        /// <summary>
        /// Recherche de l'emplacement par CODE
        /// </summary>
        /// <param name="code">String</param>
        /// <returns>resultat</returns>
        public Emplacement Get_Info_byCode(string code)
        {
            // Recupération des infos selon un CODE
            Emplacement resultat = new Emplacement();

            //****    Recherche Collection   ***
            foreach (Emplacement e in this)
            {
                if (e.CodeEmplacement == code)
                {
                    resultat = e;
                    break;
                }
            }
            return resultat;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER

        //*********************************************************
        //****   MISE A JOUR des infos d'un emplacement      ******
        //*********************************************************
        /// <summary>
        ///  MISE A JOUR des infos d'un emplacement
        /// </summary>
        /// <param name="emp">Emplacement</param>
        public void MAJ_Empl(Emplacement emp)
        {
            ////****     Version avec LISTE  ***

            foreach (Emplacement e in this)
            {
                if ((e.CodeBiblio == emp.CodeBiblio) && (e.CodeEmplacement == emp.CodeEmplacement))
                {
                    e.MAJ(emp);
                    break;
                }
            }
        }


        //*********************************************************
        //*****  AJOUT d'un nouvel emplacement dans la liste  *****
        //*********************************************************
        /// <summary>
        /// AJOUT d'un nouvel emplacement dans la liste
        /// </summary>
        /// <param name="emp">Emplacement</param>
        public void AJOUT_new(Emplacement emp)
        {
            // Ajout d'une nouvelle bibliothèque
            this.Add(emp);
            DAO_Emplacement.AJOUT_Emplacement(emp);
            nb_emp += 1;
        }


        //*********************************************************
        //****   SUPPRESSION d'un emplacment dans la liste   ******
        //*********************************************************
        /// <summary>
        /// SUPPRESSION d'un emplacment dans la liste
        /// </summary>
        /// <param name="e">Emplacement</param>
        public void SUPPRIMER(Emplacement e)
        {
            // Suppression de l'emplacement courante
            this.Remove(e);
            nb_emp--;
            DAO_Emplacement.SUPR_Emplacement(e);
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT

        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// Recuperation de l'element PRECEDENT de la liste
        /// </summary>
        /// <returns>Emplacement precedent</returns>
        public Emplacement empl_PRECEDENT()
        {   // Fonction permettant de recuperer l'element precedent de la liste
            //****     Version avec LISTE   *** 

            try
            {
                no_emp_courant -= 1;
                return (this[no_emp_courant]);

            }
            catch (Exception e)
            {
                no_emp_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// Recuperation de l'element SUIVANT de la liste
        /// </summary>
        /// <returns>Emplacement suivant</returns>
        public Emplacement empl_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            //****     Version avec LISTE   *** 

            try
            {
                no_emp_courant += 1;
                return (this[no_emp_courant]);

            }
            catch (Exception e)
            {
                no_emp_courant -= 1;
                throw e;
            }
        }

        #endregion


        #region Méthode CODE provisoir

        ////*********************************************************
        ////****   Attribution d'un Code bibliothèque PROVISOIR   ***
        ////*********************************************************
        ///// <summary>
        ///// Attribution d'un Code bibliothèque PROVISOIR
        ///// </summary>
        ///// <returns>Numéro d'emplacemcent provisoir</returns>
        //public int Code_PROVISOIR()
        //{   // Fonction permettant de determiner le code EMPLACEMENT maximum
        //    // pour l'attribution d'un code EMPLACMENT (New)
        //    try
        //    {
        //        no_emp_courant = this.Count - 1;
        //        return (no_emp_courant + 1);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        #endregion


        #endregion

    }
}
