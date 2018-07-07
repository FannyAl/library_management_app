using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Biblio_class
{
    public class Emprunt
    {
        #region //Atribut de la class Emprunt
        private string _numAdherent; //[DisplayName  private int num_Adherent] + (ligne 5) using System.ComponentModel;)
        private int _numExemplaire;
        private DateTime _dateJ;
        private DateTime _dateRestitutionEffective;

        //Attribut de Class
        private static int _nbEmprunt;
        #endregion


        #region //Proprietes

        //....................
        public string NumAdherent
        {
            get { return _numAdherent; }
            set { _numAdherent = value; }
        }

        //.........................
        [DisplayName("Code Exemplaire")]
        public int NumExemplaire
        {
            get { return _numExemplaire; }
            set { _numExemplaire = value; }
        }

        //.................
        public DateTime DateJ
        {
            get { return _dateJ; }
            set { _dateJ = value; }
        }

        //....................................
        public DateTime DateRestitutionEffective
        {
            get { return _dateRestitutionEffective; }
            set { _dateRestitutionEffective = value; }
        }
        #endregion


        #region // Les Constructeur  de la class Emprunt

        //..........................................
        public Emprunt()//Constructeur par défaut
        {
            _numAdherent = "";
            _numExemplaire = 0;
            _dateJ = DateTime.Now;
            _dateRestitutionEffective = DateTime.MinValue;
        }

        //.....................................
        public Emprunt(string NumAdherent, int NumExemplaire, DateTime Datej, DateTime DateRestitution)//Constructeur d'initialisation
        {
            Adherent a = new Adherent();
            a.NumeroAdherent = NumAdherent;

            string retour = a.droit_emprunter();
            if (retour == "OK")
            {
                _numAdherent = NumAdherent;
                _numExemplaire = NumExemplaire;
                _dateJ = Datej;
                _dateRestitutionEffective = DateRestitution;

                //Ajout++
                _nbEmprunt++;
            }
            else
            {
                Exception e = new Exception(retour);
                throw e;
            }
        }
        #endregion


        #region // Les Méthodes  de la class Emprunt

        //..............................
        public static int NbEmprunt()
        {
            return _nbEmprunt;
        }

        //....................................
        public string Affichage_num_Adherent()
        {
            return _numAdherent;

        }

        //......................................
        public int Affichage_num_Exemplaire()
        {
            return _numExemplaire;

        }

        //................................................
        public DateTime Affiche_DateJ()
        {
            return _dateJ;

        }

        //.....................................................
        public DateTime Affiche_Date_Restitution_Effective()
        {
            return _dateRestitutionEffective;

        }


        #endregion

        
    }
}
