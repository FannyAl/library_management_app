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
    class DAO_Emplacement
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        ////*********          Les Objets ADO.net   ***************

        ////*******************************************************
        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************
        ////*******************************************************

        //*********************************************************
        //**** Initialisation de la liste des Emplacements ********
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste des Emplacements
        /// </summary>
        /// <param name="emp">Liste des Emplacements</param>
        public static void Init_Emplacements(Emplacements emp)
        { 
            //Connexion avec base de données
            try
            {
                emp.Clear();
                String[] result = new String[7];

                // Requête Sql
                String strSql = "Select * from EMPLACEMENT";

                //// Execution de la requete
                IDataReader sqlRdr = DAO.Execute_Query(strSql);
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

                    if (!sqlRdr.IsDBNull(3))
                        result[3] = sqlRdr.GetString(3);
                    else result[3] = "<nc>";


                    // Décomposition du code Emplacement
                    string[] temp = result[3].Split('-');
                    string s0 = temp[0].Trim();
                    string s1 = temp[1].Trim();
                    string s2 = temp[2].Trim();
                    // Conversion du numero de l'emplacement en entier
                    int etage = Convert.ToInt32(s0.Substring(s0.Length - 1, 1));
                    int allee = Convert.ToInt32(s1.Substring(s1.Length - 1, 1));
                    int rayon = Convert.ToInt32(s2.Substring(s2.Length - 1, 1)); 


                    // Ajout de l'emplacement dans la liste
                    emp.Add(new Emplacement(result[0], result[1], result[2], etage, allee, rayon));
                    //nb_emplacments += 1;
                }

                //Fermeture de la requête
                sqlRdr.Close();
                sqlRdr = null;

            }
            catch (Exception ex)
            {
                // ==> Si erreur, la LISTE est vide
            }

        }


        //*********************************************************
        //****   Mise a jour des infos d'un emplacement         ***
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'un emplacement
        /// </summary>
        /// <param name="emp">Emplacement</param>
        /// <returns>Requête SQL</returns>
        public static bool MAJ_Emplacement(Emplacement emp)
        {
            //Requête Sql
            String strSql = "Update EMPLACEMENT set codTheme ='" +
                emp.CodeTheme + "' , libelEmplacement= '" + emp.Libelle + "' where codEmplacement='" + 
                emp.CodeEmplacement +
                "' and codBibliotheque='" + emp.CodeBiblio.ToString() + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
         }

        ////*********************************************************
        ////****   Ajout d'un nouvel emplacement dans la liste    ***
        ////*********************************************************
        /// <summary>
        /// Ajout d'un nouvel emplacement dans la liste
        /// </summary>
        /// <param name="emp">Emplacement</param>
        /// <returns>Requête SQL</returns>
        public static bool AJOUT_Emplacement(Emplacement emp)
        { 
            // Requête sql
            String strSql = "Insert into EMPLACEMENT values('"
              + emp.CodeBiblio + "' , '" +
                emp.CodeEmplacement + "' , '" +
                emp.CodeTheme + "' , '" +
                emp.Libelle + "')";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //****   Suppression de l'emplacement dans la liste     ***
        //*********************************************************
        /// <summary>
        /// Suppression de l'emplacement dans la liste
        /// </summary>
        /// <param name="emp">Emplacement</param>
        /// <returns>Requête SQL</returns>
        public static bool SUPR_Emplacement(Emplacement emp)
        {
            // Requête Sql
            String strSql = "Delete from EMPLACEMENT where codEmplacement='" + emp.CodeEmplacement.ToString() + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
