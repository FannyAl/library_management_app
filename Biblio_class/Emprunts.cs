using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class
{
    public class Emprunts : List<Emprunt>
    {
        
        #region//List<Emprunt>

        //...................
        //public void inti()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        this.Add(new Emprunt("NumAdherent", (i + 1), DateTime.Now, DateTime.Now));
        //    }

        //}
        #endregion

        #region//Attribut list Emprunt
        private static List<Emprunt> Emprunt = new List<Emprunt>();
        #endregion

        #region//Les methode

        //.................................................
        public string AfficheEmprunt()
        {
            return "affiche";
        }

        //.................................................

        public void init()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    this.Ajoute(new Emprunt(i.ToString(), i, DateTime.Now, new DateTime(9999, 12, 31)));
            //}
            DAO_Emprunt.Init_Emprunts(this);
        }

        public  Emprunts RechercheEmprunt(string no_adh)
        {
            Emprunts resultat = new Emprunts();
            foreach (Emprunt e in this)
            {
                if ((e.NumAdherent == no_adh) && (e.DateRestitutionEffective > DateTime.Now))
                {
                    resultat.Add(e);
                }
            }

            return resultat;
        }

        public void Ajoute(Emprunt e)
        {
            this.Add(e);
            DAO_Emprunt.Ajout_Emprunt(e);

        }

        public Emprunts Retour(Emprunts E, DateTime date) 
        {
            Emprunts resultat = new Emprunts();
            foreach (Emprunt e in this)
            {
                if (e.DateRestitutionEffective == new DateTime(9999, 12, 31))
                {
                    e.DateRestitutionEffective = DateTime.Now;
                    resultat.Add(e);
                }
            }

            return resultat;
        }

        public Emprunts Recherche_Du_Pret(Emprunts e)
        {
            
            return this;

        }

        public Emprunt Recherche_par_num(string num)
        {
            Emprunt resultat = new Emprunt();

            foreach (Emprunt e in this)
            {
                if (e.NumAdherent == num)
                {
                    resultat = e;
                }
            }
            return resultat;
        }


        //public Emprunt Recherche_du_pret(string num)
        //{
        //    //Emprunts es = new Emprunts();
        //    Emprunt resultat = new Emprunt();

        //    foreach (Emprunt e in this)
        //    {
        //        if (num == e.NumAdherent)
        //        {
        //            resultat = e;
        //        }
        //    }
        //    return resultat;
        //}


        public Emprunts Recherche_du_pret(string num)
        {
            Emprunts resultat = new Emprunts();
            //Emprunt resultat = new Emprunt();

            foreach (Emprunt e in this)
            {
                if (num == e.NumAdherent)
                {
                    resultat.Add(e);
                }
            }
            return resultat;
        }

        #endregion
    }
}
