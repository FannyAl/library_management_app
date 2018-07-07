using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Couche_DAO;

namespace Biblio_class
{
    static class DAO_Livre
    {
        /// <summary>
        /// La méthode Init_Livres initialise la liste des Livres
        /// </summary>
        /// <param name="liv">Une liste de livres est passé en paramètre</param>
        public static void Init_Livres(Livres liv)
        {
            try
            {
                //On nettoie la collection de livres 28/03
                liv.Clear();
                String[] result = new String[3];

                // La requète SQL 28/03
                String strSql = "SELECT * FROM LIVRE";

                // On execute la requete
                DbDataReader sqlRdr = DAO.Execute_Query(strSql);        // IDataReader a la place du DbDataReader (sans modif) ?

                // On lit toutes les colonnes de la ligne
                while (sqlRdr.Read())
                {
                    if (!sqlRdr.IsDBNull(0))
                        result[0] = sqlRdr.GetString(0);
                    else result[0] = "<nc>";
                    if (!sqlRdr.IsDBNull(1))
                        result[1] = sqlRdr.GetString(1);
                    else result[1] = "<nc>";
                    if (!sqlRdr.IsDBNull(2))
                        result[2] = sqlRdr.GetString(2);
                    else result[2] = "<nc>";

                    // On ajoute le livre dans la liste
                    liv.Add(new Livre(result[0], result[1], result[2]));

                    //nb_livre += 1;
                }
                sqlRdr.Close();       // On ferme la requete
                sqlRdr = null;
            }
            catch (Exception)
            {
                // ==> S'il y a une erreur, la LISTE est vide
            }
        }


        //*****************************************************
        //****       Mise a jour des infos d'un livre       ***
        //*****************************************************
        public static bool MAJ_Livre(Livre liv)
        {
            String strSql = "UPDATE LIVRE SET codTheme ='" + liv.CodeTheme
                + "' , titreLivre='" + liv.TitreLivre
                + "' WHERE IsbnLivre='" + liv.CodeISBN + "'";

            // Cette requete SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }


        //**************************************************
        //***       Ajout d'un livre dans la liste       ***
        //**************************************************
        public static bool Ajout_Livre(Livre liv)
        {
            String strSql = "INSERT INTO LIVRE VALUES('"
                + liv.CodeISBN + "' , '" +
                  liv.CodeTheme + " , '" +
                  liv.TitreLivre + "') ";

            // Cette requete SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }


        //**********************************************************
        //****    Suppression d'un exemplaire par son numéro    ****
        //**********************************************************
        public static bool Supprimer_Livre(Livre liv)
        {
            String strSql = "DELETE FROM LIVRE WHERE IsbnLivre='" + liv.CodeISBN + "'";

            // Cette requete SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}