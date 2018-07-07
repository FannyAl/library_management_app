using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class // A REVOIR POUR DEMAIN 02/03/2016
{
    public class Theme
    {
        #region Attributs, Propriétés avec accesseurs        
        private string codTheme;
        [DisplayName("")]
        public string CodeTheme
        {
            get { return codTheme; }
            set { codTheme = value; }
        }

        
        private string libelTheme;
        [DisplayName("")]
        public string LibellerTheme
        {
            get { return libelTheme; }
            set { libelTheme = value; }
        }

        
        private string descripTheme;
        [DisplayName("")]
        public string DescriptionTheme
        {
            get { return descripTheme; }
            set { descripTheme = value; }
        }

        #endregion

        #region Mes Constructeurs
        // Constructeur par défaut
        public Theme()
        {
            CodeTheme = "0";
            LibellerTheme = "Defaut";
            DescriptionTheme = "Defaut";
        }

        /// <summary>
        /// Constructeur surchargé de la classe Theme
        /// </summary>
        /// <param name="CodTheme"></param>
        /// <param name="LibTheme"></param>
        /// <param name="DescriptTheme"></param>
        public Theme(string CodTheme, string LibTheme, string DescriptTheme)
        {
            CodeTheme = CodTheme;
            LibellerTheme = LibTheme;
            DescriptionTheme = DescriptTheme;
        }
        #endregion

        #region Mes Methodes
        public string affiche()
        {   //Ici, This correspond à l'élément appelant la fonction
            return this.CodeTheme + " " + this.LibellerTheme + " " + this.DescriptionTheme;
        }

        // Mise a jour d'un thème(MAJ de tout SAUF le Code Theme)
        public void MAJ_Theme(Theme t)
        {
            this.LibellerTheme = t.LibellerTheme;
            this.DescriptionTheme = t.DescriptionTheme;
        }

        // Retourne la liste des livres d'un code THEME
        public Livres ListeLivres()
        {
            return new Livres(this.CodeTheme);
        }
        #endregion
    }
}
