using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class
{
    public class Livre
    {
        #region Attributs, Propriétés avec accesseurs
        private string isbnLivre;
        public string CodeISBN
        {
            get { return isbnLivre; }
            set { isbnLivre = value; }
        }

        private string codTheme;
        public string CodeTheme
        {
            get { return codTheme; }
            set { codTheme = value; }
        }

        private string titreLivre;
        public string TitreLivre
        {
            get { return titreLivre; }
            set { titreLivre = value; }
        }
        #endregion

        #region Les Constructeurs
        // Constructeur par défaut
        public Livre()
        {
            CodeISBN = "";
            CodeTheme = "";
            TitreLivre = "";
        }

        /// <summary>
        /// Constructeur surchargé de la classe Livre
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="code_theme"></param>
        /// <param name="titre_livre"></param>
        public Livre(string isbn, string code_theme, string titre_livre)
        {
            CodeISBN = isbn;
            CodeTheme = code_theme;
            TitreLivre = titre_livre;
        }
        #endregion

        #region Les Methodes
        // Affiche les infos du Theme
        public string infosTheme()
        {
            return this.CodeISBN + " " + this.CodeTheme + " " + this.TitreLivre;
        }

        // Mise a jour du LIVRE
        public void MAJ(Livre l)
        {
            // On MAJ tout SAUF l'indentifiant (ISBN)
            this.CodeTheme = l.CodeTheme;
            this.TitreLivre = l.TitreLivre;

            DAO_Livre.MAJ_Livre(l);
        }

        //public Exemplaires ListeExemplaires()
        //{
        //    // Retourne la liste des livres d'un code THEME
        //    return new Exemplaires(this.CodeISBN);
        //}
        #endregion
    }
    // OK avec le modele de Fabrice.
}
