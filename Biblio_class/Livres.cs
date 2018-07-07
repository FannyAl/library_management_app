using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class // A REVOIR POUR DEMAIN 02/03/2016
{
    public class Livres : List<Livre>
    {
        #region Les constructeurs

        public Livres()      // Constructeur par défaut
        {
            for (int i = 0; i < 10; i++)
            {
                this.Add(new Livre("isbn " + i, i.ToString(), "Titre " + i));
            }
        }

        public Livres(string cod_theme)     // Constructeur d'initialisation
        {
            for (int i = 0; i < 10; i++)
            {
                this.Add(new Livre("isbn " + i, cod_theme, "Titre " + i));
            }
        }
        #endregion

        #region Les Methodes
        //****   Methode de recherche des Livres             ******
        //****   portant un titre passé en parametre         ******
        public Livres recherche_par_titre(string titr)
        {
            // Recupération des infos selon un Titre
            Livres liste = new Livres();
            liste.Clear();

            ////****     Version avec LISTE ou TABLEAU  ***
            foreach (Livre l in this)
            {
                if (l.TitreLivre == titr)
                {
                    liste.Add(l);
                    break;
                }
            }
            return liste;
        }

        //****   Methode de recherche des Themes             ******
        //****   portant un Libelle passé en parametre       ******
        public Livres recherche_par_code(string isbn)
        {
            // Recupération des infos selon un NOM
            Livres liste = new Livres();
            liste.Clear();

            ////****     Version avec LISTE ou TABLEAU  ***
            foreach (Livre l in this)
            {
                if (l.CodeISBN == isbn)
                {
                    liste.Add(l);
                    break;
                }
            }
            return liste;
        }

        //********   Mise a jour des infos d'un Livre          ********
        public void enregistre_MAJ(Livre l)
        {
            // On recherche l'adherent à modifier dans la liste
            foreach (Livre liv in this)
            {
                if (liv.CodeISBN == l.CodeISBN)
                {
                    liv.MAJ(l);
                    break;
                }
            }
        }

        //********   Ajout d'un nouveau livre dans la liste    ********
        public void enregistre_Ajout(Livre l)
        {
            this.Add(l);
        }

        //********   Suppression de le theme dans la liste     ********
        public void supprime(Livre l)
        {
            // Suppression du LIVRE passé en parametre
            this.Remove(l);
        }
        #endregion

        public void init()
        {
            DAO_Livre.Init_Livres(this);
        }

        public void listeExemplaires()
        {

        }
    }
}
