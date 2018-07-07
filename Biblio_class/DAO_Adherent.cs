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
    static class DAO_Adherent
    {
        /// <summary>
        /// La méthode Init_Adherents initialise la liste des Adherents
        /// </summary>
        /// <param name="a">Une liste d'adherents est passé en paramètre</param>
        public static void Init_Adherents(Adherents a)
        {
            try
            {
                // On nettoie la collection d'adhérent 28/03
                a.Clear();
                String[] result = new String[11];

                // La requète SQL 28/03
                String strSql = "SELECT * FROM ADHERENT";

                // On execute la requete
                DbDataReader sqlRdr = DAO.Execute_Query(strSql);        // IDataReader a la place du DbDataReader (sans modif) ?

                // On lit toutes les colonnes de la ligne
                while (sqlRdr.Read())
                {
                    //  Il y a au moins un element ==> On prepare le tableau a transmettre à l'autre formulaire
                    if (!sqlRdr.IsDBNull(0))
                        result[0] = sqlRdr.GetString(0);
                    else result[0] = "<nc>";
                    if (!sqlRdr.IsDBNull(1))
                        result[1] = sqlRdr.GetString(1);
                    else result[1] = "<nc>";
                    if (!sqlRdr.IsDBNull(2))
                        result[2] = sqlRdr.GetString(2);
                    else result[2] = "<nc>";
                    if (!sqlRdr.IsDBNull(3))
                        result[3] = sqlRdr.GetInt16(3).ToString();
                    else result[3] = "0";
                    if (!sqlRdr.IsDBNull(4))
                        result[4] = sqlRdr.GetString(4);
                    else result[4] = "<nc>";
                    if (!sqlRdr.IsDBNull(5))
                        result[5] = sqlRdr.GetDecimal(5).ToString();
                    else result[5] = "0";
                    if (!sqlRdr.IsDBNull(6))
                        result[6] = sqlRdr.GetString(6);
                    else result[6] = "<nc>";
                    if (!sqlRdr.IsDBNull(7))
                        result[7] = sqlRdr.GetString(7);
                    else result[7] = "<nc>";
                    if (!sqlRdr.IsDBNull(8))
                        result[8] = sqlRdr.GetString(8);
                    else result[8] = "<nc>";
                    if (!sqlRdr.IsDBNull(9))
                        result[9] = sqlRdr.GetDateTime(9).ToString();
                    else result[9] = "0";//DateTime
                    if (!sqlRdr.IsDBNull(10))
                        result[10] = sqlRdr.GetString(10);
                    else result[10] = "<nc>";

                    // On ajoute l'adherent dans la liste
                    a.Add(new Adherent(result[0], result[1], result[2], int.Parse(result[3]), result[4], int.Parse(result[5]), result[6], result[7], result[8], DateTime.Parse(result[9]), result[10]));

                    //nb_adherents += 1;
                }
                sqlRdr.Close();       // On ferme la requete
                sqlRdr = null;
            }
            catch (Exception)
            {
                // ==> S'il y a une erreur, la LISTE est vide
            }
        }
        //***********************************************************************************************

        public static void Init_AdherentsNum(Adherents a)
        {
            try
            {
                // On nettoie la collection d'adhérent 28/03
                a.Clear();
                String[] result = new String[11];

                // La requète SQL 28/03
                String strSql = "SELECT * FROM ADHERENT";

                // On execute la requete
                DbDataReader sqlRdr = DAO.Execute_Query(strSql);        // IDataReader a la place du DbDataReader (sans modif) ?

                // On lit toutes les colonnes de la ligne
                while (sqlRdr.Read())
                {
                    //  Il y a au moins un element ==> On prepare le tableau a transmettre à l'autre formulaire
                    if (!sqlRdr.IsDBNull(0))
                        result[0] = sqlRdr.GetString(0);
                    else result[0] = "<nc>";
                    if (!sqlRdr.IsDBNull(1))
                        result[1] = sqlRdr.GetString(1);
                    else result[1] = "<nc>";
                    if (!sqlRdr.IsDBNull(2))
                        result[2] = sqlRdr.GetString(2);
                    else result[2] = "<nc>";
                    if (!sqlRdr.IsDBNull(3))
                        result[3] = sqlRdr.GetInt16(3).ToString();
                    else result[3] = "0";
                    if (!sqlRdr.IsDBNull(4))
                        result[4] = sqlRdr.GetString(4);
                    else result[4] = "<nc>";
                    if (!sqlRdr.IsDBNull(5))
                        result[5] = sqlRdr.GetDecimal(5).ToString();
                    else result[5] = "0";
                    if (!sqlRdr.IsDBNull(6))
                        result[6] = sqlRdr.GetString(6);
                    else result[6] = "<nc>";
                    if (!sqlRdr.IsDBNull(7))
                        result[7] = sqlRdr.GetString(7);
                    else result[7] = "<nc>";
                    if (!sqlRdr.IsDBNull(8))
                        result[8] = sqlRdr.GetString(8);
                    else result[8] = "<nc>";
                    if (!sqlRdr.IsDBNull(9))
                        result[9] = sqlRdr.GetDateTime(9).ToString();
                    else result[9] = "0";//DateTime
                    if (!sqlRdr.IsDBNull(10))
                        result[10] = sqlRdr.GetString(10);
                    else result[10] = "<nc>";

                    // On ajoute l'adherent dans la liste
                    a.Add(new Adherent(result[0], result[1], result[2], int.Parse(result[3]), result[4], int.Parse(result[5]), result[6], result[7], result[8], DateTime.Parse(result[9]), result[10]));

                    //nb_adherents += 1;
                }
                sqlRdr.Close();       // On ferme la requete
                sqlRdr = null;
            }
            catch (Exception)
            {
                // ==> S'il y a une erreur, la LISTE est vide
            }
        }


        //***********************************************************************************************



        //********************************************************
        //****       Mise a jour des infos d'un adhérent       ***
        //********************************************************
        public static bool MAJ_Adherent(Adherent a)
        {
            String strSql = "UPDATE ADHERENT SET nomAdherent ='" + a.Nom
                + "' , prenomAdherent='" + a.Prenom
                + "' , numRueAdherent='" + a.NumeroDeRue
                + "' , nomRueAdherent='" + a.NomDeRue
                + "' , CPAdherent='" + a.CodePostal
                + "' , villeAdherent='" + a.Ville
                + "' , teleAdherent='" + a.Telephone
                + "' , adrMailAdherent='" + a.Mail
                + "' , perimeLe='" + a.PerimeLe
                + "' , pwdAdherent='" + a.Password
                + "' WHERE numAdherent='" + a.NumeroAdherent + "'";

            // Cette requête SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }


        //*************************************************
        //***  Ajout d'un nouvel adherent dans la liste ***
        //*************************************************
        public static bool Ajout_Adherent(Adherent a)
        {
            String strSql = "INSERT INTO ADHERENT VALUES('"
                + a.NumeroAdherent + "' , '" +
                  a.Nom + "' , '" +
                  a.Prenom + "' , " +
                  a.NumeroDeRue + " , '" +
                  a.NomDeRue.ToString() + "' , " +
                  a.CodePostal.ToString() + " , '" +
                  a.Ville.ToString() + "' , '" +
                  a.Telephone + "' , '" +
                  a.Mail.ToString() + "' , '" +
                  a.PerimeLe.ToString() + "' , '" +
                  a.Password + "') ";

            // Cette requête SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }


        //*********************************************************
        //****    Suppression d'un adhérent par son numéro     ****
        //*********************************************************
        public static bool Supprimer_Adherent(Adherent a)
        {
            String strSql = "DELETE FROM ADHERENT WHERE numAdherent='" + a.NumeroAdherent.ToString() + "'";

            // Cette requête SQL est formuler à la BDD
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
