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
    //*************   La classe BIBLIOTHEQUE   ****************

    /// <summary>
    /// La classe BIBLIOTHEQUE
    /// </summary>
    public class Bibliotheque
    {
        // Les DONNEE membres de la classe Bibliothèque
        #region Attributs de la class Bibliothèque

        private string m_strCodeBiblio;
        private string m_strLibelle;
        private string m_strAdresse;
        private int m_intCodePostal;
        private string m_strVille;
    
        #endregion


        // Les PRORPIETES de la classe Bibliothèque
        #region Propriétés de la class bibliothèque

        
        /// <summary>
        /// PROPRIETE code bibliothèque
        /// </summary>
        [DisplayName("Code Bibliothèque")] //Modifier le nom des familles de données dans la datagrid
        public string CodeBiblio 
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strCodeBiblio; } 
            set { m_strCodeBiblio = value; } 
        }

        /// <summary>
        /// PROPRIETE Libellé bibliothèque
        /// </summary>
        [DisplayName("Libellé")]
        public string Libelle
        {
            get { return m_strLibelle; }
            set { m_strLibelle = value; }
        }

        /// <summary>
        /// PROPRIETE Adresse bibliothèque
        /// </summary>
        [DisplayName("Adresse")]
        public string Adresse
        {
            get { return m_strAdresse; }
            set { m_strAdresse = value; }
        }

        /// <summary>
        /// PROPRIETE Code Postal bibliothèque
        /// </summary>
        [DisplayName("Code postal")]
        public int CodePostal
        {
            get { return m_intCodePostal; }
            set { m_intCodePostal = value; }
        }

        /// <summary>
        /// PROPRIETE Ville bibliothèque
        /// </summary>
        public string Ville
        {
            get { return m_strVille; }
            set { m_strVille = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe Bibliothèque
        #region Constructeurs/Destructeur de la class Bibliothèque

        /// <summary>
        /// CONSTRUCTEUR d'initialisation de la classe Bibliothèque
        /// </summary>
        /// <param name="codeBi">Code Bibliothèque en paramètre</param>
        /// <param name="Libel">Libellé en paramètre</param>
        /// <param name="Adr">Adresse en paramètre</param>
        /// <param name="Cp">Code Postal en paramètre</param>
        /// <param name="Vill">Ville en paramètre</param>
        public Bibliotheque(string codeBi, string Libel, string Adr, int Cp, string Vill)
        {
            m_strCodeBiblio = codeBi;
            m_strLibelle = Libel;
            m_strAdresse = Adr;
            m_intCodePostal = Cp;
            m_strVille = Vill;
        }

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe Bibliothèque
        /// </summary>
        public Bibliotheque()
        {
            m_strCodeBiblio = "";
            m_strLibelle = "";
            m_strAdresse = "";
            m_intCodePostal = 00000;
            m_strVille = "";
        }

        #endregion


        // Les METHODES de la classe Bibliothèque
        #region METHODES de la class Bibliothèque

        //*********************************************************
        //***********  AFFICHE les infos bibliothèque  ************
        //*********************************************************
        /// <summary>
        /// AFFICHE les infos bibliothèque
        /// </summary>
        /// <returns>this.m_strCodeBiblio + " " + this.m_strLibelle + " " + this.m_strAdresse</returns>
        public string affiche()
        {
            return this.m_strCodeBiblio + " " + this.m_strLibelle + " " + this.m_strAdresse;
        }


        //*********************************************************
        //*************  MAJ de la Bibliothèque    ****************
        //*********************************************************
        /// <summary>
        /// Méthode MAJ de la Bibliothèque
        /// </summary>
        /// <param name="b">Bibliothèque</param>
        public void MAJ(Bibliotheque b)
        {
            // MAJ de toutes les données de la bibliothèque sauf la ville et le code postal qui ne figurent pas dans la BDD
            this.CodeBiblio = b.CodeBiblio;
            this.Libelle = b.Libelle;
            this.Adresse = b.Adresse;

            DAO_Bibliotheque.MAJ_Biblio(b);
        }

        #endregion
    }
}
