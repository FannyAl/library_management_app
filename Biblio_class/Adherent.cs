using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class // A REVOIR POUR DEMAIN 29/02/2016
{

    public class Adherent : Adherents
    {
        public bool click_nouveau = false;
        public bool click_modifier = false;
        public bool click_supprimer = false;

        public List<Adherents> l;

        #region Attributs, Propriétés avec accesseurs
        private string numAdherent;
        public string NumeroAdherent
        {
            get { return numAdherent; }
            set { numAdherent = value; }
        }

        private string nomAdherent;
        public string Nom
        {
            get { return nomAdherent; }
            set { nomAdherent = value; }
        }

        private string prenomAdherent;
        public string Prenom
        {
            get { return prenomAdherent; }
            set { prenomAdherent = value; }
        }

        private int numRueAdherent;
        public int NumeroDeRue
        {
            get { return numRueAdherent; }
            set { numRueAdherent = value; }
        }

        private string nomRueAdherent;
        public string NomDeRue
        {
            get { return nomRueAdherent; }
            set { nomRueAdherent = value; }
        }

        private int CPAdherent;
        public int CodePostal
        {
            get { return CPAdherent; }
            set { CPAdherent = value; }
        }

        private string villeAdherent;
        public string Ville
        {
            get { return villeAdherent; }
            set { villeAdherent = value; }
        }

        private string teleAdherent;
        public string Telephone
        {
            get { return teleAdherent; }
            set { teleAdherent = value; }
        }

        private string adrMailAdherent;
        public string Mail
        {
            get { return adrMailAdherent; }
            set
            {
                string pont = value;    // affecte seulement si l'adresse est valide
                if (verif_mail(pont))
                {
                    adrMailAdherent = value;
                }
            }
        }

        private DateTime perimeLe;
        public DateTime PerimeLe
        {
            get { return perimeLe; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new Exception("Date expirée");
                }
                else
                {
                    perimeLe = value;
                }
            }
        }

        private string pwdAdherent;
        public string Password
        {
            get { return pwdAdherent; }
            set { pwdAdherent = value; }
        }
        #endregion

        #region Constructeur par défaut et d'initialisation
        public Adherent()
        {
            NumeroAdherent = "";
            Nom = "";
            Prenom = "";
            NumeroDeRue = 0;
            NomDeRue = "";
            CodePostal = 0;
            Ville = "";
            Telephone = "";
            Mail = "";
            PerimeLe = DateTime.Now.AddDays(30);
            Password = "";
        }

        /// <summary>
        /// Constructeur surchargé de la classe Adherent
        /// </summary>
        /// <param name="numAdh"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="numRue"></param>
        /// <param name="nomRue"></param>
        /// <param name="cpostal"></param>
        /// <param name="ville"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="perime"></param>
        /// <param name="mdp"></param>
        public Adherent(string numAdh, string nom, string prenom, int numRue, string nomRue, int cpostal, string ville, string tel, string mail, DateTime perime, string mdp)
        {
            NumeroAdherent = numAdh;
            Nom = nom;
            Prenom = prenom;
            NumeroDeRue = numRue;
            NomDeRue = nomRue;
            CodePostal = cpostal;
            Ville = ville;
            Telephone = tel;
            Mail = mail;
            //PerimeLe = perime;
            Password = mdp;
        }
        #endregion

        #region Mes méthodes

        public string droit_emprunter()
        {
            if (this.PerimeLe < DateTime.Now)
            {
                return "L'utilisateur n'est pas à jour !";
            }
            else
            {
                Info_generale i = new Info_generale();
                Emprunts e = new Emprunts();

                if (e.RechercheEmprunt(this.numAdherent.ToString()).Count == i.NbreMaxiLivreEmprunt)
                {
                    return "Nombre maximum d'emprunt atteint !";
                }
                else
                {
                    return "OK";
                }
            }
        }

        // Méthode légère de vérification du format de l'adresse saisie
        public bool verif_mail(string adr)
        {
            if (adr.IndexOf('@') == -1 || adr.IndexOf('.') == -1 || adr.Length < 8 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Affiche les infos de l'Adherent
        public string affiche()
        {
            return this.NumeroAdherent + " " + this.Nom + " " + this.Prenom;
        }

        // Mise à jour de l'adherent
        public void MAJ(Adherent a)
        {
            //Tout est mis à jour SAUF le numéro d'adhérent
            this.Nom = a.Nom;
            this.Prenom = a.Prenom;
            this.NumeroDeRue = a.NumeroDeRue;
            this.NomDeRue = a.NomDeRue;
            this.CodePostal = a.CodePostal;
            this.Ville = a.Ville;
            this.Telephone = a.Telephone;
            this.Mail = a.Mail;
            this.PerimeLe = a.PerimeLe;
            this.Password = a.Password;

            DAO_Adherent.MAJ_Adherent(a);
        }
        #endregion
    }
}