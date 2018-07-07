using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class // A REVOIR POUR DEMAIN 02/03/2016
{
    public class Exemplaires : List<Exemplaire>
    {
        #region Les constructeurs
        //public void init()
        //{
        //    for (int i = 1; i < 10; i++)
        //    {
        //        this.Add(new Exemplaire(i,"Biblio"+i,"Code"+i,"Isbn"+i,"CodeEmp"+i,"Comment"+1,true));
        //        this.Add(new Exemplaire(10+i, "Biblio" + i, "Code" + i, "Isbn" + i, "CodeEmp" + i, "Comment" + 1,false));
        //    }
        //}

        private static List<Exemplaire> Exemplaire = new List<Exemplaire>();


        public void init()
        {
            DAO_Exemplaire.Init_Exemplaires(this);
        }

        //public Exemplaires(string isbn)
        //{
            
        //}
        //public Exemplaires Affichage_exemplaire()
        //{
        //    Exemplaires resultat = new Exemplaires();
        //    //Emprunt resultat = new Emprunt();

        //    foreach (Exemplaires e in this)
        //    {
        //        if (num == e.NumAdherent)
        //        {
        //            resultat.Add(e);
        //        }
        //    }
        //    return resultat;
        //}
        #endregion
    }
}
