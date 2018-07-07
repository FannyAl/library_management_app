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
    static class DAO_Theme
    {
        /// <summary>
        /// la méthode Init_Themes initialise la liste des Thèmes
        /// </summary>
        /// <param name="tem">Une liste de thèmes est passé en paramètre</param>
        public static void Init_Themes(Themes tem)
        {
            try
            {
                //On nettoie la collection de thèmes 28/03
                tem.Clear();
                String[] result = new String[3];

                // La requète SQL 28/03
                String strSql = "SELECT * FROM THEME";

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
                    tem.Add(new Theme(result[0], result[1], result[2]));

                    //nb_theme += 1;
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
        //****       Mise a jour des infos d'un theme       ***
        //*****************************************************
        public static bool MAJ_Theme(Theme tem)
        {
            String strSql = "UPDATE THEME SET libelTheme ='" + tem.LibellerTheme
                + "' , descripTheme='" + tem.DescriptionTheme +
                  "' WHERE codTheme='" + tem.CodeTheme + "'";

            // Cette requete SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }


        //**************************************************
        //***       Ajout d'un theme dans la liste       ***
        //**************************************************
        public static bool Ajout_Theme(Theme tem)
        {
            String strSql = "INSERT INTO THEME VALUES('"
                + tem.CodeTheme + " , '" +
                  tem.LibellerTheme + "' , '" +
                  tem.DescriptionTheme + "') ";

            // Cette requete SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }


        //**********************************************************
        //****    Suppression d'un exemplaire par son numéro    ****
        //**********************************************************
        public static bool Supprimer_Theme(Theme tem)
        {
            String strSql = "DELETE FROM THEME WHERE codTheme='" + tem.CodeTheme + "'";

            // Cette requete SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}