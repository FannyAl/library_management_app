using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
using Couche_DAO;
using Biblio_class;

 
namespace Biblio_class
{
     static class DAO_Emprunt
    {

         // Affiche des Emprunt d'un Adherent 
         public static void  Init_Emprunts(Emprunts e)
         {
             try
             {
                e.Clear();

                String[] result = new String[4];

                String SqlSelect = "Select * From Emprunt";
                
                DbDataReader reader = DAO.Execute_Query(SqlSelect);
                
                 
                 while (reader.Read())
                {
                    if (!reader.IsDBNull(0)) result[0] = reader.GetString(0);
                    else result[0] = "";
                    if (!reader.IsDBNull(1)) result[1] = reader.GetInt32(1).ToString();
                    else result[1] = "";
                    if (!reader.IsDBNull(2)) result[2] = reader.GetDateTime(2).ToString();
                    else result[2] = "";
                    if (!reader.IsDBNull(3)) result[3] = reader.GetDateTime(3).ToString();
                    else result[3] = "31/12/9999";

		           //                    string ,   int    , DateTime  , DateTime
                    e.Add(new Emprunt( result[0], Convert.ToInt32(result[1]), DateTime.Parse(result[2]), DateTime.Parse(result[3])));   
                }
                reader.Close();
                reader = null;    
             }
             catch (Exception)
             {
               //Affiche vide 
             }
         }


         // Mise à jour des Emprunt d'un Adherent

         public static bool MAj_Emprunt(Emprunt e)
         {
             String SqlMaj = "UPDATE EMPRUNT" +
                              "SET DateRestitutionEffective =" + e.DateRestitutionEffective +
                              "WHERE numAdherent" + e.NumAdherent +",numExemplaire" + e.NumExemplaire;
                                  
             return DAO.Execute_Ins_Upd_Delete(SqlMaj);
         }


         // Ajouter un Emprunt d'un Adherent

         public static bool Ajout_Emprunt(Emprunt e)
        {
            String SqlAjout = " INSERT INTO EMPRUNT " +
                               "VALUES('"+ e.NumAdherent +"',"+ e.NumExemplaire +",'"+ e.DateJ +"','" +e.DateRestitutionEffective +"')";
             
             return DAO.Execute_Ins_Upd_Delete(SqlAjout);
     
        }

    } 
}  
