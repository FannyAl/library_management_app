using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Biblio_class;
using System.Configuration;
using System.Data.Common;
using Couche_DAO;


namespace Biblio_class
{
    static class DAO_Bibliotheque
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        ////*************  Les Objets ADO.net   *******************

        ////*******************************************************
        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************
        ////*******************************************************

        //*********************************************************
        //**** Initialisation de la liste des Bibliothèque ********
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste des Bibliothèque
        /// </summary>
        /// <param name="b">Une bibliothèque est passée en paramètre</param>
        public static void Init_Bibliotheques(Bibliotheques b)
        {

            //****  Acces base de données
            try
            {
                b.Clear();
                String[] result = new String[5]; //Renvoie 6 données : le code biblio, le Libellé, l'adresse, le code postal et la ville

                // Requête Sql
                String strSql = "select * from BIBLIOTHEQUE";  // Requête SQL : importation de toutes les informations de la table BIBLIOTHEQUE

                // Exécution de la requête
                IDataReader sqlRdr = DAO.Execute_Query(strSql);
                while (sqlRdr.Read()) // tant que mode lecture actif
                {
                    // Génère un tableau avec les réultats de la requête
                    if (!sqlRdr.IsDBNull(0))
                        result[0] = sqlRdr.GetString(0);
                    else result[0] = "<nc>";

                    if (!sqlRdr.IsDBNull(1))
                        result[1] = sqlRdr.GetString(1);
                    else result[1] = "<nc>";

                    if (!sqlRdr.IsDBNull(2))
                        result[2] = sqlRdr.GetString(2);
                    else result[2] = "<nc>";


                    //Ajout de la bibiliothèque dans la liste
                    b.Add(new Bibliotheque(result[0], result[1], result[2], 28930, "Marmuseau"));
                    //nb_biliotheques += 1;
                }

                //Fermeture de la requête
                sqlRdr.Close();
                sqlRdr = null;

            }
            catch (Exception ex)
            {
                // ==> dans ce cas la LISTE est vide
            }
        }

        //*********************************************************
        //****   Mise A Jour des infos d'une bibliothèque       ***
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'une bibliothèque
        /// </summary>
        /// <param name="b">Bibliothèque</param>
        /// <returns>Résultat requête sql</returns>
        public static bool MAJ_Biblio(Bibliotheque b)
        {
            String strSql = "Update BIBLIOTHEQUE set libeBibliotheque ='" + b.Libelle + "' , adrBibliotheque='" + b.Adresse +
               "' WHERE codBibliotheque='" + b.CodeBiblio.ToString() + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        ////*********************************************************
        ////**** AJOUT d'une nouvelle bibliothèque dans la liste  ***
        ////*********************************************************
        /// <summary>
        /// AJOUT d'une nouvelle bibliothèque dans la liste
        /// </summary>
        /// <param name="b">Bibliothèque</param>
        /// <returns>Résultat requête sql</returns>
        public static bool AJOUT_Biblio(Bibliotheque b)
        {
            String strSql = "Insert into BIBLIOTHEQUE VALUE ('"
              + b.CodeBiblio.ToString() + "' , '" +
                b.Libelle + "' , '" +
                b.Adresse + "' , '" + "')";
                //b.CodePostal + "' , '" +
                //b.Ville + "')"; // Requete à exécuter en attendant le complément de données sur le code postal et la ville

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //****   SUPPRESSION de la bibliothèque dans la liste   ***
        //*********************************************************
        /// <summary>
        /// SUPPRESSION de la bibliothèque dans la liste
        /// </summary>
        /// <param name="b">Bibliothèque</param>
        /// <returns>Résultat requête sql</returns>
        public static bool SUPPR_Biblio(Bibliotheque b)
        {
            // Requête QSL
            String strSql = "Delete from BIBLIOTHEQUE where codBibliotheque ='" + b.CodeBiblio.ToString() + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

    }
}
