using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class // A REVOIR POUR DEMAIN 02/03/2016s
{
    public class Themes : List<Theme>
    {
        #region LES CONSTRUCTEURS
        public Themes()
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    this.Add(new Theme(i.ToString(), "Lib" + i, "Descr" + i));
            //}
            DAO_Theme.Init_Themes(this);
        }
        #endregion LES CONSTRUCTEURS

        #region LES METHODES
        public Themes par_libeller(string libel)
        {
            // Recupération des infos selon un NOM
            Themes liste = new Themes();
            liste.Clear();

            ////****   Version avec LISTE ou TABLEAU   ****
            foreach (Theme t in this)
            {
                if (t.LibellerTheme == libel)
                {
                    liste.Add(t);
                    break;
                }
            }
            return liste;
        }


        public Themes par_code(string code)
        {
            // Recupération des infos selon un NOM
            Themes liste = new Themes();
            liste.Clear();

            ////****     Version avec LISTE ou TABLEAU  ***
            foreach (Theme t in this)
            {
                if (t.CodeTheme == code)
                {
                    liste.Add(t);
                    break;
                }
            }
            return liste;
        }

        //****   Mise a jour des infos d'un adherent            ***
        public void enregistre_MAJ(Theme th)
        {
            // On recherche l'adherent à modifier dans la liste
            foreach (Theme t in this)
            {
                if (t.CodeTheme == th.CodeTheme)
                {
                   // t.MAJ_Theme(th);
                    break;
                }
            }
        }

        //****   AJout d'un nouveau theme dans la liste         ***
        public void enregistre_Ajout(Theme t)
        {
            this.Add(t);
        }

        //****   Suppression de theme dans la liste          ***
        public void supprime(Theme t)
        {
            // Suppression du theme passé en parametre
            this.Remove(t);
        }

        public void init()
        {
            DAO_Theme.Init_Themes(this);
        }
        #endregion LES METHODES
    }
}
