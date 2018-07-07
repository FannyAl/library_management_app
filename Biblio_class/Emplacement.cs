using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Biblio_class
{
    //*********************************************************
    //*********************************************************
    //*************     Les Classes METIERS    ****************
    //*********************************************************
    //*********************************************************
    //*************   La classe EMPLACEMENT   *****************

    /// <summary>
    /// La classe EMPLACEMENT
    /// </summary>
    public class Emplacement
    {
        // Les DONNEE membres de la classe Emplacement
        #region Attributs de la class Emplacement

        private string m_strCodeBiblio;
        private string m_strCodeEmplacement;
        private string m_strCodeTheme;
        private decimal m_nEtage;
        private decimal m_nAllee;
        private decimal m_nRayon;
        private string m_strLibel;
        private string m_strTheme;

        #endregion


        // Les PRORPIETES de la classe Emplacement
        #region Propriétés de la class emplacement

        /// <summary>
        /// CODE de la bibliothèque
        /// </summary>
        [DisplayName("Code Bibliothèque")] //Modifier le nom des familles de données dans la datagrid
        public string CodeBiblio
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strCodeBiblio; }
            set { m_strCodeBiblio = value; }
        }

        /// <summary>
        /// CODE de l'emplacement
        /// </summary>
        [DisplayName("Code Emplacement")]
        public string CodeEmplacement
        {
            get { return m_strCodeEmplacement; }
            set { m_strCodeEmplacement = value; }
        }

        /// <summary>
        /// Code Thème
        /// </summary>
        [DisplayName("Code Thème")]
        public string CodeTheme
        {
            get { return m_strCodeTheme; }
            set { m_strCodeTheme = value; }
        }

        /// <summary>
        /// ETAGE Emplacement
        /// </summary>
        [DisplayName("Etage")]
        public decimal Etage
        {
            get {return m_nEtage; }
            set { m_nEtage = value; }
        }

        
        /// <summary>
        /// ALLEE Emplacemement
        /// </summary>
        [DisplayName("Allée")]
        public decimal Allee
        {
            get { return m_nAllee; }
            set { m_nAllee = value; }
        }

        /// <summary>
        /// RAYON Emplacement
        /// </summary>
        [DisplayName("Rayon")]
        public decimal Rayon
        {
            get { return m_nRayon; }
            set { m_nRayon = value; }
        }

        /// <summary>
        /// LIBELLE Emplacement
        /// </summary>
        [DisplayName("Libellé")]
        public string Libelle
        {
            get { return m_strLibel; }
            set { m_strLibel = value;}
        }

        /// <summary>
        /// THEME Emplacement
        /// </summary>
        [DisplayName("Thème")]
        public string Theme
        {
            get { return m_strTheme; }
            set { m_strTheme = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe Emplacement
        #region Constructeurs/Destructeur de la class Emplacement

        //Constructeur d'initialisation
        /// <summary>
        /// Constructeur d'initialisation de la classe Emplacement
        /// </summary>
        /// <param name="codeBi">string</param>
        /// <param name="codeEmp">string</param>
        /// <param name="codeTheme">string</param>
        /// <param name="etage">decimal</param>
        /// <param name="allee">decimal</param>
        /// <param name="rayon">decimal</param>
        public Emplacement(string codeBi, string codeEmp, string codeTheme, decimal etage, decimal allee, decimal rayon)
        {
            m_strCodeBiblio = codeBi;
            m_strCodeEmplacement = codeEmp;
            m_strCodeTheme = codeTheme;
            m_strTheme = codeTheme;
            m_nEtage = etage;
            m_nAllee = allee;
            m_nRayon = rayon;
            m_strLibel = "Etage" + m_nEtage + "-Allée" + m_nAllee + "-Rayon" + m_nRayon;
        }

        //Constructeur par défault
        /// <summary>
        /// CONSTRUCTEUR par défault de la classe Emplacement
        /// </summary>
        public Emplacement()
        {
            m_strCodeBiblio = "XXXXX";
            m_strCodeEmplacement = "XX-XX-XX";
            m_strCodeTheme = "XXXXX";
            m_nEtage = 0;
            m_nAllee = 0;
            m_nRayon = 0;
            m_strLibel = "Etage0-Allée0-Rayon0";
        }

        #endregion


        // Les METHODES de la classe Emplacement
        #region METHODES de la class Emplacement

        //*********************************************************
        //*******  Affichages des infos de l'Emplacement **********
        //*********************************************************
        /// <summary>
        /// Affichages des infos de l'Emplacement
        /// </summary>
        /// <returns>this.CodeEmplacement + " " + this.CodeTheme + " " + this.Libelle</returns>
        public string affiche()
        {
            return this.CodeEmplacement + " " + this.CodeTheme + " " + this.Libelle;
        }

        //*********************************************************
        //****   Attribution d'un NOUVEAU Code emplacement    *****
        //*********************************************************
        public string New_Code_Empl()
        {
            return "E" + this.Etage + "-A" + this.Allee + "-R" + this.Rayon;
        }

        //*********************************************************
        //***************  MAJ des Emplacements  ******************
        //*********************************************************
        /// <summary>
        /// Mise à jours des Emplacements
        /// </summary>
        /// <param name="e">Emplacement</param>
        public void MAJ(Emplacement e)
        {
            // Pour toutes les données sauf le code bibliothèque
            this.CodeEmplacement = e.CodeEmplacement;
            this.CodeTheme = e.CodeTheme;
            this.Libelle = e.Libelle;

            DAO_Emplacement.MAJ_Emplacement(e);
        }

        #endregion
    }
}
