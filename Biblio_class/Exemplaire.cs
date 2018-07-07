using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class // A REVOIR POUR DEMAIN 02/03/2016
{
    public class Exemplaire
    {
        #region Les Propriétés
        private int numExemplaire;
        [DisplayName("Numéro Exemplaire")]
        public int NumeroExemplaire
        {
            get { return numExemplaire; }
            set { numExemplaire = value; }
        }

        private string codBibliotheque;
        [DisplayName("Code Bibliothèque")]
        public string CodeBibliotheque
        {
            get { return codBibliotheque; }
            set { codBibliotheque = value; }
        }

        private string codEmplacement;
        [DisplayName("Code Emplacement")]
        public string CodeEmplacement
        {
            get { return codEmplacement; }
            set { codEmplacement = value; }
        }

        private string isbnLivre;
        [DisplayName("ISBN Livre")]
        public string CodeISBN
        {
            get { return isbnLivre; }
            set { isbnLivre = value; }
        }

        private string codExemplaire;
        [DisplayName("Code exemplaire")]
        public string CodeExemplaire
        {
            get { return codExemplaire; }
            set { codExemplaire = value; }
        }

        private string commentExemplaire;
        [DisplayName("Commentaire")]
        public string Commentaire
        {
            get { return commentExemplaire; }
            set { commentExemplaire = value; }
        }

        private bool disponible;
        [DisplayName("Disponible")]
        public bool Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }
        #endregion

        #region Les Constructeurs
        public Exemplaire()
        {
            NumeroExemplaire = 0;
            CodeBibliotheque = "";
            CodeEmplacement = "";
            CodeISBN = "";
            CodeExemplaire = "";
            Commentaire = "";
            Disponible = false;
        }

        /// <summary>
        /// Constructeur surchargé de la classe Exemplaire
        /// </summary>
        /// <param name="numExemp"></param>
        /// <param name="c_biblio"></param>
        /// <param name="c_emplacement"></param>
        /// <param name="c_isbn"></param>
        /// <param name="c_exemp"></param>
        /// <param name="comment"></param>
        /// <param name="dispo"></param>
        public Exemplaire(int numExemp, string c_biblio, string c_emplacement, string c_isbn, string c_exemp, string comment, bool dispo)
        {
            NumeroExemplaire = numExemp;
            CodeBibliotheque = c_biblio;
            CodeEmplacement = c_emplacement;
            CodeISBN = c_isbn;
            CodeExemplaire = c_exemp;
            Commentaire = comment;
            Disponible = dispo;
        }
        #endregion
    }
}