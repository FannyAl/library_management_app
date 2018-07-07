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
    static class DAO_Exemplaire
    {
        /// <summary>
        /// La méthode Init_Exemplaire initialise la liste des Exemplaires
        /// </summary>
        /// <param name="ex">Une liste d'exemplaires est passé en paramètre</param>
        public static void Init_Exemplaires(Exemplaires ex)
        {
            try
            {
                // On nettoie la collection d'exemplaires 28/03
                ex.Clear();
                String[] result = new String[7];

                // La requète SQL 28/03
                String strSql = "SELECT * FROM EXEMPLAIRE";

                // On execute la requete
                DbDataReader sqlRdr = DAO.Execute_Query(strSql);        // IDataReader a la place du DbDataReader (sans modif) ?

                // On lit toutes les colonnes de la ligne
                while (sqlRdr.Read())
                {
                    if (!sqlRdr.IsDBNull(0))
                        result[0] = sqlRdr.GetInt32(0).ToString();
                    else result[0] = "0";
                    if (!sqlRdr.IsDBNull(1))
                        result[1] = sqlRdr.GetString(1);
                    else result[1] = "<nc>";
                    if (!sqlRdr.IsDBNull(2))
                        result[2] = sqlRdr.GetString(2);
                    else result[2] = "<nc>";
                    if (!sqlRdr.IsDBNull(3))
                        result[3] = sqlRdr.GetString(3);
                    else result[3] = "<nc>";
                    if (!sqlRdr.IsDBNull(4))
                        result[4] = sqlRdr.GetString(4);
                    else result[4] = "<nc>";
                    if (!sqlRdr.IsDBNull(5))
                        result[5] = sqlRdr.GetString(5);
                    else result[5] = "<nc>";
                    if (!sqlRdr.IsDBNull(6))
                        result[6] = sqlRdr.GetBoolean(6).ToString();
                    else result[6] = "false";

                    // On ajoute l'exemplaire dans la liste
                    ex.Add(new Exemplaire(Convert.ToInt16(result[0]), result[1], result[2], result[3], result[4], result[5], Convert.ToBoolean(result[6])));

                    //nb_exemplaire += 1;
                }
                sqlRdr.Close();       // On ferme la requete
                sqlRdr = null;
            }
            catch (Exception)
            {
                // ==> S'il y a une erreur, la LISTE est vide
            }
        }


        //*********************************************************
        //****       Mise a jour des infos d'un exemplaire      ***
        //*********************************************************
        public static bool MAJ_Exemplaire(Exemplaire exemp)
        {
            String strSql = "UPDATE EXEMPLAIRE SET codBibliotheque ='" + exemp.CodeBibliotheque
                + "' , codEmplacement='" + exemp.CodeEmplacement
                + "' , IsbnLivre='" + exemp.CodeISBN
                + "' , codExemplaire='" + exemp.CodeExemplaire
                + "' , commentExemplaire='" + exemp.Commentaire
                + "' , disponible='" + exemp.Disponible
                + "' WHERE numExemplaire='" + exemp.NumeroExemplaire + "'";

            // Cette requete SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //***************************************************
        //***  Ajout d'un nouvel exemplaire dans la liste ***
        //***************************************************
        public static bool Ajout_Exemplaire(Exemplaire exemp)
        {
            String strSql = "INSERT INTO EXEMPLAIRE VALUES('"
                + exemp.NumeroExemplaire + "' , '" +
                  exemp.CodeBibliotheque + "' , '" +
                  exemp.CodeEmplacement + "' , '" +
                  exemp.CodeISBN + "' , " +
                  exemp.CodeExemplaire + " , '" +
                  exemp.Commentaire + "' , " +
                  exemp.Disponible + "') ";

            // Cette requete SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //**********************************************************
        //****    Suppression d'un exemplaire par son numéro    ****
        //**********************************************************
        public static bool Supprimer_Exemplaire(Exemplaire exemp)
        {
            String strSql = "DELETE FROM EXEMPLAIRE WHERE numExemplaire='" + exemp.NumeroExemplaire + "'";

            // Cette requete SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
